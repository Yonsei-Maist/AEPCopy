/// <summary>
/// ABR 측정 프로그램인 AEP의 가짜 프로그램 버전
/// 왼쪽 그래프의 경우, 실제 ABR 측정 결과 중 하나
/// 오른쪽 그래프의 경우, 랜덤 그래프 생성
/// @Author Chanwoo Gwon, Yonsei Univ. Researcher, 2020.05. ~
/// @Date 2020.09.
/// </summary>

using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Collections.Generic;

namespace AEPCopy {
	/// <summary>
	/// 메인 폼
	/// </summary>
	public partial class FormMain : Form {
		private class DoublePoint {
			public double X { get; set; }
			public double Y { get; set; }

			public DoublePoint(double X, double Y) {
				this.X = X;
				this.Y = Y;
			}
		}
		
		private class Graph {
			public double[] Values { get; set; }
			public int Peak { get; set; }
			public string Name { get; set; }

			public override string ToString() {
				return this.Name;
			}
		}

		#region Field
		/// <summary>
		/// 랜덤 유닛
		/// </summary>
		private Random initRand = new Random(new DateTime().Millisecond);
		private Random updownRand = new Random(new DateTime().Millisecond);
		private List<Graph> graphs = new List<Graph>();

		private Random rand = new Random(new DateTime().Millisecond);
		#endregion

		#region Method

		/// <summary>
		/// 생성자
		/// </summary>
		public FormMain() {
			InitializeComponent();

			this.readAllFile();
			this.drawChart();
		}

		/// <summary>
		/// 차트 출력 인터페이스
		/// </summary>
		private void drawChart() {
			DoublePoint[] leftGraph = this.getMadeGraph(); // this.makeGraph(696, 200);
			DoublePoint[] rightGraph = this.makeGraph(696, 200);

			this.draw(this.chartLeft, leftGraph, Color.FromArgb(255, 20, 0, 255));
			//this.draw(this.chartRight, rightGraph, Color.FromArgb(255, 251, 0, 5));
		}

		/// <summary>
		/// 차트를 출력하는 매소드
		/// </summary>
		/// <param name="chart">차트를 그릴 컨트롤</param>
		/// <param name="point">차트에 입력될 데이터</param>
		/// <param name="color">차트 색깔</param>
		private void draw(Chart chart, DoublePoint[] point, Color color) {
			// 차트 초기화
			chart.Series.Clear();

			//차트 데이터 생성
			Series series1 = new Series {
				Name = "Series1",
				Color = color,
				ChartType = SeriesChartType.Line,
				BorderWidth = 2,
				IsVisibleInLegend = false
			};

			// 차트 입력
			chart.Series.Add(series1);

			for (int i = 0; i < point.Length; i++) {
				DoublePoint p = point[i];
				series1.Points.AddXY(p.X, p.Y);
			}

			// 차트 다시 그리기
			chart.ResetAutoValues();
		}

		private void drawPeak(Chart chart, int peakIndex, double point) {
			//차트 데이터 생성
			Series series1 = new Series {
				Name = "Series2",
				Color = Color.Black,
				ChartType = SeriesChartType.Point,
				MarkerStyle = MarkerStyle.Circle
			};

			chart.Series.Add(series1);
			series1.Points.AddXY(peakIndex, point);
			chart.ResetAutoValues();
		}

		/// <summary>
		/// ABR 예시 값을 차트 데이터 형식으로 변환
		/// </summary>
		/// <returns></returns>
		private DoublePoint[] getMadeGraph() {
			int index = rand.Next(0, this.graphs.Count - 1);

			double[] value = this.graphs[index].Values;

			return this.toDoublePoint(value);
		}

		/// <summary>
		/// double array을 DoublePoint로 변환
		/// </summary>
		/// <param name="values"></param>
		/// <returns></returns>
		private DoublePoint[] toDoublePoint(double[] values) {
			DoublePoint[] point = new DoublePoint[values.Length];

			for (int i = 0; i < values.Length; i++) {
				point[i] = new DoublePoint(i, (int)values[i]);
			}

			return point;
		}
		
		/// <summary>
		/// 차트 랜덤 생성
		/// </summary>
		/// <param name="xLimit">x축 최대값</param>
		/// <param name="yMax">y 초기값의 최대값</param>
		/// <param name="yMin">y 초기값의 최소값</param>
		/// <returns></returns>
		private DoublePoint[] makeGraph(int xLimit, int yMax, int yMin = 50) {
			DoublePoint[] result = new DoublePoint[xLimit];
			double init = this.initRand.Next() % yMax; // y 초기값 설정
			int updown = 0; // 증가, 감소, 유지 결정
			Random adder = new Random(new DateTime().Millisecond); // 증가, 감소량 결정
			double current = init; // 현재 그래프 y값
			for (int i = 0; i < xLimit; i++) {
				double add = (adder.Next() % 1000) / 100.0;
				updown = this.updownRand.Next() % 3;

				switch (updown) {
					case 0: // up
						current += add;
						break;
					case 1: // down
						current -= add;
						break;
					default: // equal
						break;
				}

				result[i] = new DoublePoint(i, current);
			}

			return result;
		}

		/// <summary>
		/// 실제 병원데이터를 읽어들임
		/// </summary>
		private void readAllFile() {
			string dd = Properties.Resources.Response_result_origin;
			string[] lines = dd.Split('\n');

			foreach(string line in lines) {
				string[] datas = line.Trim().Split('\t');

				if (datas.Length == 4 && datas[1].Trim() == "0") {
					string[] values = datas[2].Trim().Split(',');
					double[] reals = new double[values.Length];
					for (int i =0;i<values.Length;i++) {
						reals[i] = double.Parse(values[i]);
					}

					string[] peaks = datas[3].Split(',');

					string[] dirs = datas[0].Split('/');

					Graph g = new Graph() {
						Values = reals,
						Peak = int.Parse(peaks[peaks.Length - 1]),
						Name = dirs[dirs.Length - 1]
					};

					this.graphs.Add(g);
					this.lvFileList.Items.Add(g.Name);
				}
			}
		}

		#endregion

		#region Event Handler
		private void btnRefresh_Click(object sender, EventArgs e) {
			this.drawChart();
		}

		private void lvFileList_SelectedIndexChanged(object sender, EventArgs e) {
			if (this.lvFileList.SelectedIndices.Count == 0)
				return;

			int selectedIndex = this.lvFileList.SelectedIndices[0];

			Graph g = this.graphs[selectedIndex];
			double[] data = g.Values;
			DoublePoint[] points = this.toDoublePoint(data);

			this.draw(this.chartLeft, points, Color.FromArgb(255, 20, 0, 255));
			this.draw(chartRight, points, Color.FromArgb(255, 251, 0, 5));
			this.drawPeak(chartRight, g.Peak, data[g.Peak]);
		}

		#endregion
	}
}

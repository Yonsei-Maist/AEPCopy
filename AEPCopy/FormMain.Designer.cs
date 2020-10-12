namespace AEPCopy {
	partial class FormMain {
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 사용 중인 모든 리소스를 정리합니다.
		/// </summary>
		/// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 디자이너에서 생성한 코드

		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다. 
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
		/// </summary>
		private void InitializeComponent() {
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.menuMain = new System.Windows.Forms.MenuStrip();
			this.patientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.testsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.panelBtn = new System.Windows.Forms.Panel();
			this.btnRefresh = new System.Windows.Forms.Button();
			this.splitGraph = new System.Windows.Forms.SplitContainer();
			this.panelLeft = new System.Windows.Forms.Panel();
			this.chartLeft = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.panelRight = new System.Windows.Forms.Panel();
			this.chartRight = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.lvFileList = new System.Windows.Forms.ListView();
			this.column파일명 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.menuMain.SuspendLayout();
			this.panelBtn.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitGraph)).BeginInit();
			this.splitGraph.Panel1.SuspendLayout();
			this.splitGraph.Panel2.SuspendLayout();
			this.splitGraph.SuspendLayout();
			this.panelLeft.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chartLeft)).BeginInit();
			this.panelRight.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chartRight)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuMain
			// 
			this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.patientToolStripMenuItem,
            this.testsToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.menuMain.Location = new System.Drawing.Point(0, 0);
			this.menuMain.Name = "menuMain";
			this.menuMain.Size = new System.Drawing.Size(800, 24);
			this.menuMain.TabIndex = 0;
			this.menuMain.Text = "menuStrip1";
			// 
			// patientToolStripMenuItem
			// 
			this.patientToolStripMenuItem.Name = "patientToolStripMenuItem";
			this.patientToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
			this.patientToolStripMenuItem.Text = "Patient";
			// 
			// testsToolStripMenuItem
			// 
			this.testsToolStripMenuItem.Name = "testsToolStripMenuItem";
			this.testsToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
			this.testsToolStripMenuItem.Text = "Tests";
			// 
			// optionsToolStripMenuItem
			// 
			this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
			this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
			this.optionsToolStripMenuItem.Text = "Options";
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "Help";
			// 
			// panelBtn
			// 
			this.panelBtn.Controls.Add(this.btnRefresh);
			this.panelBtn.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelBtn.Location = new System.Drawing.Point(0, 24);
			this.panelBtn.Name = "panelBtn";
			this.panelBtn.Size = new System.Drawing.Size(800, 31);
			this.panelBtn.TabIndex = 1;
			// 
			// btnRefresh
			// 
			this.btnRefresh.Location = new System.Drawing.Point(3, 5);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new System.Drawing.Size(75, 23);
			this.btnRefresh.TabIndex = 0;
			this.btnRefresh.Text = "새로고침";
			this.btnRefresh.UseVisualStyleBackColor = true;
			this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
			// 
			// splitGraph
			// 
			this.splitGraph.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitGraph.Location = new System.Drawing.Point(0, 0);
			this.splitGraph.Name = "splitGraph";
			// 
			// splitGraph.Panel1
			// 
			this.splitGraph.Panel1.Controls.Add(this.panelLeft);
			// 
			// splitGraph.Panel2
			// 
			this.splitGraph.Panel2.Controls.Add(this.panelRight);
			this.splitGraph.Size = new System.Drawing.Size(515, 395);
			this.splitGraph.SplitterDistance = 281;
			this.splitGraph.TabIndex = 2;
			// 
			// panelLeft
			// 
			this.panelLeft.Controls.Add(this.chartLeft);
			this.panelLeft.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelLeft.Location = new System.Drawing.Point(0, 0);
			this.panelLeft.Name = "panelLeft";
			this.panelLeft.Size = new System.Drawing.Size(281, 395);
			this.panelLeft.TabIndex = 0;
			// 
			// chartLeft
			// 
			this.chartLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			chartArea1.AxisX.MajorGrid.Enabled = false;
			chartArea1.AxisY.MajorGrid.Enabled = false;
			chartArea1.Name = "ChartArea1";
			this.chartLeft.ChartAreas.Add(chartArea1);
			legend1.Name = "Legend1";
			this.chartLeft.Legends.Add(legend1);
			this.chartLeft.Location = new System.Drawing.Point(12, 16);
			this.chartLeft.Name = "chartLeft";
			series1.ChartArea = "ChartArea1";
			series1.Legend = "Legend1";
			series1.Name = "Series1";
			this.chartLeft.Series.Add(series1);
			this.chartLeft.Size = new System.Drawing.Size(256, 329);
			this.chartLeft.TabIndex = 0;
			this.chartLeft.Text = "chart1";
			// 
			// panelRight
			// 
			this.panelRight.Controls.Add(this.chartRight);
			this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelRight.Location = new System.Drawing.Point(0, 0);
			this.panelRight.Name = "panelRight";
			this.panelRight.Size = new System.Drawing.Size(230, 395);
			this.panelRight.TabIndex = 0;
			// 
			// chartRight
			// 
			this.chartRight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			chartArea2.AxisX.MajorGrid.Enabled = false;
			chartArea2.AxisY.MajorGrid.Enabled = false;
			chartArea2.Name = "ChartArea1";
			this.chartRight.ChartAreas.Add(chartArea2);
			legend2.Name = "Legend1";
			this.chartRight.Legends.Add(legend2);
			this.chartRight.Location = new System.Drawing.Point(7, 16);
			this.chartRight.Name = "chartRight";
			series2.ChartArea = "ChartArea1";
			series2.Legend = "Legend1";
			series2.Name = "Series1";
			this.chartRight.Series.Add(series2);
			this.chartRight.Size = new System.Drawing.Size(211, 329);
			this.chartRight.TabIndex = 1;
			this.chartRight.Text = "chart1";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.splitGraph);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 55);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(800, 395);
			this.panel1.TabIndex = 3;
			// 
			// panel2
			// 
			this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.panel2.Controls.Add(this.lvFileList);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel2.Location = new System.Drawing.Point(515, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(285, 395);
			this.panel2.TabIndex = 3;
			// 
			// lvFileList
			// 
			this.lvFileList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column파일명});
			this.lvFileList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lvFileList.GridLines = true;
			this.lvFileList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
			this.lvFileList.HideSelection = false;
			this.lvFileList.Location = new System.Drawing.Point(0, 0);
			this.lvFileList.MultiSelect = false;
			this.lvFileList.Name = "lvFileList";
			this.lvFileList.Size = new System.Drawing.Size(285, 395);
			this.lvFileList.Sorting = System.Windows.Forms.SortOrder.Descending;
			this.lvFileList.TabIndex = 0;
			this.lvFileList.UseCompatibleStateImageBehavior = false;
			this.lvFileList.View = System.Windows.Forms.View.Details;
			this.lvFileList.SelectedIndexChanged += new System.EventHandler(this.lvFileList_SelectedIndexChanged);
			// 
			// column파일명
			// 
			this.column파일명.Text = "파일명";
			this.column파일명.Width = 300;
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panelBtn);
			this.Controls.Add(this.menuMain);
			this.MainMenuStrip = this.menuMain;
			this.Name = "FormMain";
			this.Text = "AEPCopy";
			this.menuMain.ResumeLayout(false);
			this.menuMain.PerformLayout();
			this.panelBtn.ResumeLayout(false);
			this.splitGraph.Panel1.ResumeLayout(false);
			this.splitGraph.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitGraph)).EndInit();
			this.splitGraph.ResumeLayout(false);
			this.panelLeft.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.chartLeft)).EndInit();
			this.panelRight.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.chartRight)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuMain;
		private System.Windows.Forms.ToolStripMenuItem testsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem patientToolStripMenuItem;
		private System.Windows.Forms.Panel panelBtn;
		private System.Windows.Forms.SplitContainer splitGraph;
		private System.Windows.Forms.Panel panelLeft;
		private System.Windows.Forms.Panel panelRight;
		private System.Windows.Forms.DataVisualization.Charting.Chart chartLeft;
		private System.Windows.Forms.DataVisualization.Charting.Chart chartRight;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnRefresh;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.ListView lvFileList;
		private System.Windows.Forms.ColumnHeader column파일명;
	}
}


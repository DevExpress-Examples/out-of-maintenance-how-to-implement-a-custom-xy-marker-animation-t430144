namespace AnimationExample {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SeriesPoint seriesPoint1 = new DevExpress.XtraCharts.SeriesPoint(new System.DateTime(1950, 1, 1, 0, 0, 0, 0), new object[] {
            ((object)(332D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint2 = new DevExpress.XtraCharts.SeriesPoint(new System.DateTime(1960, 1, 1, 0, 0, 0, 0), new object[] {
            ((object)(417D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint3 = new DevExpress.XtraCharts.SeriesPoint(new System.DateTime(1970, 1, 1, 0, 0, 0, 0), new object[] {
            ((object)(513D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint4 = new DevExpress.XtraCharts.SeriesPoint(new System.DateTime(1980, 1, 1, 0, 0, 0, 0), new object[] {
            ((object)(614D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint5 = new DevExpress.XtraCharts.SeriesPoint(new System.DateTime(1990, 1, 1, 0, 0, 0, 0), new object[] {
            ((object)(721D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint6 = new DevExpress.XtraCharts.SeriesPoint(new System.DateTime(2000, 1, 1, 0, 0, 0, 0), new object[] {
            ((object)(836D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint7 = new DevExpress.XtraCharts.SeriesPoint(new System.DateTime(2010, 1, 1, 0, 0, 0, 0), new object[] {
            ((object)(935D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint8 = new DevExpress.XtraCharts.SeriesPoint(new System.DateTime(2020, 1, 1, 0, 0, 0, 0), new object[] {
            ((object)(1027D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint9 = new DevExpress.XtraCharts.SeriesPoint(new System.DateTime(2030, 1, 1, 0, 0, 0, 0), new object[] {
            ((object)(1110D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint10 = new DevExpress.XtraCharts.SeriesPoint(new System.DateTime(2040, 1, 1, 0, 0, 0, 0), new object[] {
            ((object)(1178D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint11 = new DevExpress.XtraCharts.SeriesPoint(new System.DateTime(2050, 1, 1, 0, 0, 0, 0), new object[] {
            ((object)(1231D))});
            DevExpress.XtraCharts.LineSeriesView lineSeriesView1 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.XYSeriesUnwindAnimation xySeriesUnwindAnimation1 = new DevExpress.XtraCharts.XYSeriesUnwindAnimation();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            this.button1 = new System.Windows.Forms.Button();
            this.defaultLookAndFeel = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.chartControl = new DevExpress.XtraCharts.ChartControl();
            this.pnlButton = new DevExpress.XtraEditors.PanelControl();
            this.btnAnimate = new DevExpress.XtraEditors.SimpleButton();
            this.pnlChart = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlButton)).BeginInit();
            this.pnlButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlChart)).BeginInit();
            this.pnlChart.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(591, 339);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 25);
            this.button1.TabIndex = 1;
            this.button1.Text = "Animate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OnAnimateClick);
            // 
            // defaultLookAndFeel
            // 
            this.defaultLookAndFeel.LookAndFeel.SkinName = "Office 2016 Colorful";
            // 
            // chartControl
            // 
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.WholeRange.AlwaysShowZeroLevel = false;
            this.chartControl.Diagram = xyDiagram1;
            this.chartControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Left;
            this.chartControl.Legend.Name = "Default Legend";
            this.chartControl.Location = new System.Drawing.Point(4, 4);
            this.chartControl.Name = "chartControl";
            series1.Name = "Americas";
            series1.Points.AddRange(new DevExpress.XtraCharts.SeriesPoint[] {
            seriesPoint1,
            seriesPoint2,
            seriesPoint3,
            seriesPoint4,
            seriesPoint5,
            seriesPoint6,
            seriesPoint7,
            seriesPoint8,
            seriesPoint9,
            seriesPoint10,
            seriesPoint11});
            lineSeriesView1.LineMarkerOptions.Kind = DevExpress.XtraCharts.MarkerKind.Plus;
            lineSeriesView1.LineMarkerOptions.Size = 25;
            lineSeriesView1.MarkerVisibility = DevExpress.Utils.DefaultBoolean.True;
            xySeriesUnwindAnimation1.Enabled = false;
            lineSeriesView1.SeriesAnimation = xySeriesUnwindAnimation1;
            series1.View = lineSeriesView1;
            this.chartControl.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartControl.Size = new System.Drawing.Size(662, 333);
            this.chartControl.TabIndex = 2;
            chartTitle1.Text = "Historic, current and future population ";
            this.chartControl.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1});
            // 
            // pnlButton
            // 
            this.pnlButton.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlButton.Controls.Add(this.btnAnimate);
            this.pnlButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButton.Location = new System.Drawing.Point(0, 339);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.Padding = new System.Windows.Forms.Padding(4, 2, 4, 4);
            this.pnlButton.Size = new System.Drawing.Size(670, 29);
            this.pnlButton.TabIndex = 3;
            // 
            // btnAnimate
            // 
            this.btnAnimate.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAnimate.Location = new System.Drawing.Point(566, 2);
            this.btnAnimate.Name = "btnAnimate";
            this.btnAnimate.Size = new System.Drawing.Size(100, 23);
            this.btnAnimate.TabIndex = 0;
            this.btnAnimate.Text = "Animate";
            this.btnAnimate.Click += new System.EventHandler(this.OnAnimateClick);
            // 
            // pnlChart
            // 
            this.pnlChart.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlChart.Controls.Add(this.chartControl);
            this.pnlChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChart.Location = new System.Drawing.Point(0, 0);
            this.pnlChart.Name = "pnlChart";
            this.pnlChart.Padding = new System.Windows.Forms.Padding(4, 4, 4, 2);
            this.pnlChart.Size = new System.Drawing.Size(670, 339);
            this.pnlChart.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 368);
            this.Controls.Add(this.pnlChart);
            this.Controls.Add(this.pnlButton);
            this.Controls.Add(this.button1);
            this.Name = "MainForm";
            this.Text = " Custrom XYMarker Animation Example";
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlButton)).EndInit();
            this.pnlButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlChart)).EndInit();
            this.pnlChart.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel;
        private DevExpress.XtraCharts.ChartControl chartControl;
        private DevExpress.XtraEditors.PanelControl pnlButton;
        private DevExpress.XtraEditors.SimpleButton btnAnimate;
        private DevExpress.XtraEditors.PanelControl pnlChart;
    }
}


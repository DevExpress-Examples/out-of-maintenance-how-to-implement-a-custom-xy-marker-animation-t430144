Namespace AnimationExample

    Partial Class MainForm

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim xyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
            Dim series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim seriesPoint1 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(1950, 1, 1, 0, 0, 0, 0), New Object() {(CObj((332R)))})
            Dim seriesPoint2 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(1960, 1, 1, 0, 0, 0, 0), New Object() {(CObj((417R)))})
            Dim seriesPoint3 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(1970, 1, 1, 0, 0, 0, 0), New Object() {(CObj((513R)))})
            Dim seriesPoint4 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(1980, 1, 1, 0, 0, 0, 0), New Object() {(CObj((614R)))})
            Dim seriesPoint5 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(1990, 1, 1, 0, 0, 0, 0), New Object() {(CObj((721R)))})
            Dim seriesPoint6 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2000, 1, 1, 0, 0, 0, 0), New Object() {(CObj((836R)))})
            Dim seriesPoint7 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2010, 1, 1, 0, 0, 0, 0), New Object() {(CObj((935R)))})
            Dim seriesPoint8 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2020, 1, 1, 0, 0, 0, 0), New Object() {(CObj((1027R)))})
            Dim seriesPoint9 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2030, 1, 1, 0, 0, 0, 0), New Object() {(CObj((1110R)))})
            Dim seriesPoint10 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2040, 1, 1, 0, 0, 0, 0), New Object() {(CObj((1178R)))})
            Dim seriesPoint11 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2050, 1, 1, 0, 0, 0, 0), New Object() {(CObj((1231R)))})
            Dim lineSeriesView1 As DevExpress.XtraCharts.LineSeriesView = New DevExpress.XtraCharts.LineSeriesView()
            Dim xySeriesUnwindAnimation1 As DevExpress.XtraCharts.XYSeriesUnwindAnimation = New DevExpress.XtraCharts.XYSeriesUnwindAnimation()
            Dim chartTitle1 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Me.button1 = New System.Windows.Forms.Button()
            Me.defaultLookAndFeel = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
            Me.chartControl = New DevExpress.XtraCharts.ChartControl()
            Me.pnlButton = New DevExpress.XtraEditors.PanelControl()
            Me.btnAnimate = New DevExpress.XtraEditors.SimpleButton()
            Me.pnlChart = New DevExpress.XtraEditors.PanelControl()
            CType((Me.chartControl), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((xyDiagram1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((lineSeriesView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.pnlButton), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlButton.SuspendLayout()
            CType((Me.pnlChart), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlChart.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' button1
            ' 
            Me.button1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.button1.Location = New System.Drawing.Point(591, 339)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(75, 25)
            Me.button1.TabIndex = 1
            Me.button1.Text = "Animate"
            Me.button1.UseVisualStyleBackColor = True
            AddHandler Me.button1.Click, New System.EventHandler(AddressOf Me.OnAnimateClick)
            ' 
            ' defaultLookAndFeel
            ' 
            Me.defaultLookAndFeel.LookAndFeel.SkinName = "Office 2016 Colorful"
            ' 
            ' chartControl
            ' 
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
            xyDiagram1.AxisY.WholeRange.AlwaysShowZeroLevel = False
            Me.chartControl.Diagram = xyDiagram1
            Me.chartControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chartControl.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Left
            Me.chartControl.Legend.Name = "Default Legend"
            Me.chartControl.Location = New System.Drawing.Point(4, 4)
            Me.chartControl.Name = "chartControl"
            series1.Name = "Americas"
            series1.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() {seriesPoint1, seriesPoint2, seriesPoint3, seriesPoint4, seriesPoint5, seriesPoint6, seriesPoint7, seriesPoint8, seriesPoint9, seriesPoint10, seriesPoint11})
            lineSeriesView1.LineMarkerOptions.Kind = DevExpress.XtraCharts.MarkerKind.Plus
            lineSeriesView1.LineMarkerOptions.Size = 25
            lineSeriesView1.MarkerVisibility = DevExpress.Utils.DefaultBoolean.[True]
            xySeriesUnwindAnimation1.Enabled = False
            lineSeriesView1.SeriesAnimation = xySeriesUnwindAnimation1
            series1.View = lineSeriesView1
            Me.chartControl.SeriesSerializable = New DevExpress.XtraCharts.Series() {series1}
            Me.chartControl.Size = New System.Drawing.Size(662, 333)
            Me.chartControl.TabIndex = 2
            chartTitle1.Text = "Historic, current and future population "
            Me.chartControl.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {chartTitle1})
            ' 
            ' pnlButton
            ' 
            Me.pnlButton.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.pnlButton.Controls.Add(Me.btnAnimate)
            Me.pnlButton.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.pnlButton.Location = New System.Drawing.Point(0, 339)
            Me.pnlButton.Name = "pnlButton"
            Me.pnlButton.Padding = New System.Windows.Forms.Padding(4, 2, 4, 4)
            Me.pnlButton.Size = New System.Drawing.Size(670, 29)
            Me.pnlButton.TabIndex = 3
            ' 
            ' btnAnimate
            ' 
            Me.btnAnimate.Dock = System.Windows.Forms.DockStyle.Right
            Me.btnAnimate.Location = New System.Drawing.Point(566, 2)
            Me.btnAnimate.Name = "btnAnimate"
            Me.btnAnimate.Size = New System.Drawing.Size(100, 23)
            Me.btnAnimate.TabIndex = 0
            Me.btnAnimate.Text = "Animate"
            AddHandler Me.btnAnimate.Click, New System.EventHandler(AddressOf Me.OnAnimateClick)
            ' 
            ' pnlChart
            ' 
            Me.pnlChart.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.pnlChart.Controls.Add(Me.chartControl)
            Me.pnlChart.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlChart.Location = New System.Drawing.Point(0, 0)
            Me.pnlChart.Name = "pnlChart"
            Me.pnlChart.Padding = New System.Windows.Forms.Padding(4, 4, 4, 2)
            Me.pnlChart.Size = New System.Drawing.Size(670, 339)
            Me.pnlChart.TabIndex = 4
            ' 
            ' MainForm
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(670, 368)
            Me.Controls.Add(Me.pnlChart)
            Me.Controls.Add(Me.pnlButton)
            Me.Controls.Add(Me.button1)
            Me.Name = "MainForm"
            Me.Text = " Custrom XYMarker Animation Example"
            CType((xyDiagram1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((lineSeriesView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chartControl), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.pnlButton), System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlButton.ResumeLayout(False)
            CType((Me.pnlChart), System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlChart.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private button1 As System.Windows.Forms.Button

        Private defaultLookAndFeel As DevExpress.LookAndFeel.DefaultLookAndFeel

        Private chartControl As DevExpress.XtraCharts.ChartControl

        Private pnlButton As DevExpress.XtraEditors.PanelControl

        Private btnAnimate As DevExpress.XtraEditors.SimpleButton

        Private pnlChart As DevExpress.XtraEditors.PanelControl
    End Class
End Namespace

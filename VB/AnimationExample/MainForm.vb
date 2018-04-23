Imports DevExpress.XtraCharts
Imports System

Namespace AnimationExample
    Partial Public Class MainForm
        Inherits DevExpress.XtraEditors.XtraForm

        Private ReadOnly Property series() As Series
            Get
                Return chartControl.Series(0)
            End Get
        End Property
        Private ReadOnly Property diagram() As XYDiagram
            Get
                Return TryCast(chartControl.Diagram, XYDiagram)
            End Get
        End Property
        Private ReadOnly Property view() As LineSeriesView
            Get
                Return TryCast(series.View, LineSeriesView)
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
        End Sub

        #Region "#AnimationConfig"
        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)

            chartControl.AnimationStartMode = ChartAnimationMode.OnLoad
            view.SeriesPointAnimation = New FanMarkerAnimation() With { _
                .BeginTime = New TimeSpan(0, 0, 0), .Duration = New TimeSpan(0, 0, 0, 1, 500), .PointDelay = New TimeSpan(0, 0, 0, 0, 250), .PointOrder = PointAnimationOrder.Random, .EasingFunction = New QuinticEasingFunction With {.EasingMode = EasingMode.Out} _
            }
        End Sub

        Private Sub OnAnimateClick(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click, btnAnimate.Click
            chartControl.Animate()
        End Sub
        #End Region
    End Class
End Namespace


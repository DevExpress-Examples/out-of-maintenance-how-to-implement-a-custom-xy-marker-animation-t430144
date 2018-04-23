#Region "#CustomAnimation"
Imports DevExpress.XtraCharts
Imports System
Imports System.Drawing
Imports System.Drawing.Drawing2D

Namespace AnimationExample
    Friend Class FanMarkerAnimation
        Inherits XYMarkerAnimationBase

        Public Overrides Sub ApplyState(ByVal modifier As SceneModifier, ByVal diagramBounds As RectangleF, ByVal markerParameters As MarkerSeriesPointLayoutParameters, ByVal progress As Single)
            Dim markerBounds As RectangleF = markerParameters.Bounds
            Dim markerCenterX As Single = markerBounds.Left + markerBounds.Width / 2
            Dim markerCenterY As Single = markerBounds.Top + markerBounds.Height / 2

            Dim startAngle As Single = 360 - progress * 180
            Dim sweepAngle As Single = 360 * progress
            Dim endAngle As Single = startAngle + sweepAngle

            ' To apply a fan animation we need to compute parameters of 
            ' a marker's circumscribed сircle sector.
            Dim circumscribedCircleRadius As Single = CSng(Math.Sqrt((markerBounds.Left - markerCenterX) * (markerBounds.Left - markerCenterX) + (markerBounds.Top - markerCenterY) * (markerBounds.Top - markerCenterY)))

            Dim circumscribedCircleSectorLeftBoundEndX As Single = markerCenterX + CSng(Math.Cos(startAngle / 180 * Math.PI)) * circumscribedCircleRadius
            Dim circumscribedCircleSectorLeftBoundEndY As Single = markerCenterY + CSng(Math.Sin(startAngle / 180 * Math.PI)) * circumscribedCircleRadius

            Dim circumscribedCircleSectorRightBoundEndX As Single = markerCenterX + CSng(Math.Cos(endAngle / 180 * Math.PI)) * circumscribedCircleRadius
            Dim circumscribedCircleSectorRightBoundEndY As Single = markerCenterY + CSng(Math.Sin(endAngle / 180 * Math.PI)) * circumscribedCircleRadius

            Dim circumscribedCircleBounds As New RectangleF(markerCenterX - circumscribedCircleRadius, markerCenterY - circumscribedCircleRadius, 2 * circumscribedCircleRadius, 2 *circumscribedCircleRadius)

            ' Path representing a marker's circumscribed circle sector.
            Dim path As New GraphicsPath()
            path.AddLine(markerCenterX, markerCenterY, circumscribedCircleSectorLeftBoundEndX, circumscribedCircleSectorLeftBoundEndY)
            path.AddArc(circumscribedCircleBounds, startAngle, sweepAngle)
            path.AddLine(circumscribedCircleSectorRightBoundEndX, circumscribedCircleSectorRightBoundEndY, markerCenterX, markerCenterY)

            modifier.Clip(path)
        End Sub
        Protected Overrides Function CreateObjectForClone() As ChartElement
            Return New FanMarkerAnimation()
        End Function
    End Class
End Namespace
#End Region ' #CustomAnimation
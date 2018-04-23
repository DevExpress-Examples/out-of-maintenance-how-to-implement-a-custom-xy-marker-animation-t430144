#region #CustomAnimation
using DevExpress.XtraCharts;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace AnimationExample {
    class FanMarkerAnimation : XYMarkerAnimationBase {
        public override void ApplyState(
                SceneModifier modifier, 
                RectangleF diagramBounds, 
                MarkerSeriesPointLayoutParameters markerParameters, 
                float progress
        ) {
            RectangleF markerBounds = markerParameters.Bounds;
            float markerCenterX = markerBounds.Left + markerBounds.Width / 2;
            float markerCenterY = markerBounds.Top + markerBounds.Height / 2;

            float startAngle = 360 - progress * 180;
            float sweepAngle = 360 * progress;
            float endAngle = startAngle + sweepAngle;

            // To apply a fan animation we need to compute parameters of 
            // a marker's circumscribed сircle sector.
            float circumscribedCircleRadius = (float)Math.Sqrt(
                    (markerBounds.Left - markerCenterX) * (markerBounds.Left - markerCenterX)
                    + (markerBounds.Top - markerCenterY) * (markerBounds.Top - markerCenterY)
            );

            float circumscribedCircleSectorLeftBoundEndX = 
                markerCenterX + (float)Math.Cos(startAngle / 180 * Math.PI) * circumscribedCircleRadius;
            float circumscribedCircleSectorLeftBoundEndY = 
                markerCenterY + (float)Math.Sin(startAngle / 180 * Math.PI) * circumscribedCircleRadius;

            float circumscribedCircleSectorRightBoundEndX = 
                markerCenterX + (float)Math.Cos(endAngle / 180 * Math.PI) * circumscribedCircleRadius;
            float circumscribedCircleSectorRightBoundEndY = 
                markerCenterY + (float)Math.Sin(endAngle / 180 * Math.PI) * circumscribedCircleRadius;

            RectangleF circumscribedCircleBounds = new RectangleF(
                    markerCenterX - circumscribedCircleRadius,
                    markerCenterY - circumscribedCircleRadius,
                    2 * circumscribedCircleRadius,
                    2 *circumscribedCircleRadius
            );

            // Path representing a marker's circumscribed circle sector.
            GraphicsPath path = new GraphicsPath();
            path.AddLine(
                    markerCenterX, 
                    markerCenterY, 
                    circumscribedCircleSectorLeftBoundEndX, 
                    circumscribedCircleSectorLeftBoundEndY
            );
            path.AddArc(
                circumscribedCircleBounds, 
                startAngle, 
                sweepAngle
            );
            path.AddLine(
                    circumscribedCircleSectorRightBoundEndX,
                    circumscribedCircleSectorRightBoundEndY,
                    markerCenterX,
                    markerCenterY
            );

            modifier.Clip(path);
        }
        protected override ChartElement CreateObjectForClone() {
            return new FanMarkerAnimation();
        }
    }
}
#endregion #CustomAnimation
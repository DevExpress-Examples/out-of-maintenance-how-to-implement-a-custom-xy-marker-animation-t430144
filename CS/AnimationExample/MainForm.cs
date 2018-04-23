using DevExpress.XtraCharts;
using System;

namespace AnimationExample {
    public partial class MainForm : DevExpress.XtraEditors.XtraForm {
        Series series { get { return chartControl.Series[0]; } }
        XYDiagram diagram { get { return chartControl.Diagram as XYDiagram; } }
        LineSeriesView view { get { return series.View as LineSeriesView; } }

        public MainForm() {
            InitializeComponent();
        }

        #region #AnimationConfig
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);

            chartControl.AnimationStartMode = ChartAnimationMode.OnLoad;
            view.SeriesPointAnimation = new FanMarkerAnimation() {
                BeginTime = new TimeSpan(0, 0, 0),
                Duration = new TimeSpan(0, 0, 0, 1, 500),
                PointDelay = new TimeSpan(0, 0, 0, 0, 250),
                PointOrder = PointAnimationOrder.Random,
                EasingFunction = new QuinticEasingFunction {
                    EasingMode = EasingMode.Out
                }
            };
        }

        private void OnAnimateClick(object sender, EventArgs e) {
            chartControl.Animate();
        }
        #endregion #AnimationConfig
    }
}


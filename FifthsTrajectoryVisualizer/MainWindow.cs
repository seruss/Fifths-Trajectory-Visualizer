using System;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace FifthsTrajectoryVisualizer
{
    public partial class MainWindow : Form
    {
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;
                return handleParam;
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            SizeChanged += (sender, args) => Refresh();

            trajectoryCacheWorker.DoWork += StateManager.Instance.CreateTrajectoryCache;
            trajectoryCacheWorker.ProgressChanged += (_, e) => { cacheUpdateProgress.Value = e.ProgressPercentage; };
            trajectoryCacheWorker.WorkerReportsProgress = true;
            trajectoryCacheWorker.RunWorkerCompleted += filesTabControl.RefreshImportedFilesList;

            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, circleDisplayPanel, new object[] { true });
            StateManager.Instance.DisplayRepainted += (sender, args) => circleDisplayPanel.Refresh();
        }

        public void RunCacheWorker()
        {
            trajectoryCacheWorker.RunWorkerAsync();
        }

        private void PaintPreview(object sender, PaintEventArgs e)
        {
            e.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            var panel = sender as Panel;
            var side = Math.Min(panel.Width, panel.Height);

            var bgPen = new Pen(Brushes.LightGray, 0.2f);

            var numOfCells = StateManager.Instance.CurrentSettings.GridSize * 2;

            float cellSize = 0;

            if (numOfCells > 0)
            {
                cellSize = side / (float)numOfCells;
                DrawingUtils.DrawGrid(e.Graphics, numOfCells, cellSize, bgPen);
                DrawingUtils.DrawNumbers(e.Graphics, side, cellSize * StateManager.Instance.CurrentSettings.AxisLimit);
                DrawingUtils.DrawCircles(e.Graphics, side, cellSize, cellSize * StateManager.Instance.CurrentSettings.AxisLimit);
            }
            DrawingUtils.DrawAxes(e.Graphics, side);

            if (StateManager.Instance.SelectedTrajectory?.GetPoints() is var points && points?.Any() is true && cellSize > 0)
            {
                DrawingUtils.PlotData(e.Graphics, points, side, cellSize * StateManager.Instance.CurrentSettings.AxisLimit, StateManager.Instance.CurrentSettings.ShowTrack, StateManager.Instance.CurrentSettings.ShowPoints);
                if (StateManager.Instance.CurrentSettings.ShowMainAxis)
                {
                    DrawingUtils.DrawCenterOfTrajectory(e.Graphics, StateManager.Instance.SelectedTrajectory.Center.Point, side, cellSize * StateManager.Instance.CurrentSettings.AxisLimit);
                    DrawingUtils.DrawMainAxis(e.Graphics, side, StateManager.Instance.SelectedTrajectory.MainAxis.CalculatedAxis);
                }
                if (StateManager.Instance.SelectedSignature != null)
                    DrawingUtils.DrawCPMS(e.Graphics, side, cellSize * StateManager.Instance.CurrentSettings.AxisLimit, StateManager.Instance.SelectedSignature, StateManager.Instance.CurrentSettings.ShowComponents);
            }
        }
    }
}
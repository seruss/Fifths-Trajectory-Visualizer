using MusicSignatureBuilder;
using MusicSignatureBuilder.Enums;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Diagnostics;

namespace FifthsTrajectoryVisualizer;

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

    private ConcurrentDictionary<string, Dictionary<Modes, ConcurrentDictionary<Resolutions, Trajectory>>> trajectoryCache;
    private Dictionary<string, FileInfo> fileInfos = new();
    private Trajectory currentlyDisplayed;

    public MainWindow()
    {
        InitializeComponent();
        DoubleBuffered = true;
        modeComboBox.Items.AddRange(Enum.GetNames<Modes>());
        precisionComboBox.Items.AddRange(Enum.GetNames<Resolutions>());
        SizeChanged += (_, _) => { Refresh(); };
        filesListBox.SelectedIndexChanged += (_, _) => { Refresh(); };
        currentCMPS.ValueChanged += (_, _) => { Refresh(); };
        showIndividualSignaturesCheckBox.CheckedChanged += (_, _) => { Refresh(); };
        trajectoryCacheWorker.DoWork += CreateTrajectoryCache;
        trajectoryCacheWorker.ProgressChanged += (_, e) => { cacheUpdateProgress.Value = e.ProgressPercentage; };
        trajectoryCacheWorker.WorkerReportsProgress = true;
    }

    private void PlayMidiFile(object sender, MouseEventArgs e)
    {
        int index = filesListBox.IndexFromPoint(e.Location);
        if (index != ListBox.NoMatches)
        {
            try
            {
                var filePath = fileInfos[(string)filesListBox.Items[index]].FullName;
                ProcessStartInfo startInfo = new ProcessStartInfo(@"C:\Program Files (x86)\K-Lite Codec Pack\MPC-HC64\mpc-hc64_nvo.exe", filePath);
                Process.Start(startInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Encountered errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    public override void Refresh()
    {
        if (filesListBox.SelectedItems.Count == 1 &&
            !string.IsNullOrEmpty(modeComboBox.Text) &&
            !string.IsNullOrEmpty(precisionComboBox.Text))
        {
            if (trajectoryCache.ContainsKey((string)filesListBox.SelectedItem) &&
                trajectoryCache[(string)filesListBox.SelectedItem].ContainsKey(Enum.Parse<Modes>(modeComboBox.Text, false)) &&
                trajectoryCache[(string)filesListBox.SelectedItem][Enum.Parse<Modes>(modeComboBox.Text, false)].ContainsKey(Enum.Parse<Resolutions>(precisionComboBox.Text, false)))
            {
                currentlyDisplayed = trajectoryCache
                        [(string)filesListBox.SelectedItem]
                        [Enum.Parse<Modes>(modeComboBox.Text, false)]
                        [Enum.Parse<Resolutions>(precisionComboBox.Text, false)];
            }
            else
                MessageBox.Show($"Unable to load trajectory for {(string)filesListBox.SelectedItem}", "Encountered errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        base.Refresh();
    }

    private void PaintPreview(object sender, PaintEventArgs e)
    {
        e.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
        e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

        var panel = sender as Panel;
        var side = Math.Min(panel.Width, panel.Height);

        var bgPen = new Pen(Brushes.LightGray, 0.2f);
        var pen = new Pen(Brushes.Black, 1.0f);

        var numOfCells = gridSizeTrackBar.Value * 2;

        float cellSize = 0;
        if (numOfCells > 0)
        {
            cellSize = side / (float)numOfCells;
            DrawingUtils.DrawGrid(e.Graphics, numOfCells, cellSize, bgPen);
            DrawingUtils.DrawNumbers(e.Graphics, side, cellSize * axisLimitsTrackBar.Value);
            DrawingUtils.DrawCircles(e.Graphics, side, cellSize, cellSize * axisLimitsTrackBar.Value);
        }

        DrawingUtils.DrawAxes(e.Graphics, side);

        if (currentlyDisplayed?.GetPoints() is var points && points?.Any() is true && cellSize > 0)
        {
            trajectoryInfoLabel.Text = currentlyDisplayed.ToString();

            if (showIndividualSignaturesCheckBox.Checked)
            {
                currentCMPS.Enabled = true;
                currentCMPS.Maximum = points.Count - 1;

                DrawingUtils.DrawCPMSComponents(e.Graphics, side, cellSize * axisLimitsTrackBar.Value, points[(int)currentCMPS.Value]);
            }
            else
            {
                currentCMPS.Enabled = false;
                DrawingUtils.PlotData(e.Graphics, points, side, cellSize * axisLimitsTrackBar.Value);
                DrawingUtils.DrawCenterOfTrajectory(e.Graphics, currentlyDisplayed.Center.Point, side, cellSize * axisLimitsTrackBar.Value);
                DrawingUtils.DrawMainAxis(e.Graphics, side, currentlyDisplayed.MainAxis.CalculatedAxis);
            }
        }
    }

    private void CreateTrajectoryCache(object sender, DoWorkEventArgs e)
    {
        trajectoryCache = new();
        var allTrajectoriesCount = fileInfos.Count * 10;
        var count = 0;

        var errors = new ConcurrentBag<string>();

        Parallel.ForEach(fileInfos.Values, (file) =>
        {
            trajectoryCache.TryAdd(file.Name, new());
            foreach (var mode in Enum.GetValues<Modes>())
            {
                trajectoryCache[file.Name].TryAdd(mode, new());
                Parallel.ForEach(Enum.GetValues<Resolutions>(), (resolution) =>
                {
                    try
                    {
                        trajectoryCache[file.Name][mode].TryAdd(resolution, new Trajectory(file.FullName, resolution, mode));
                        Interlocked.Increment(ref count);
                        trajectoryCacheWorker.ReportProgress(count / allTrajectoriesCount * 100);
                    }
                    catch (Exception ex)
                    {
                        errors.Add($"{file.Name}: {ex.Message}");
                    }
                });
            }
        });

        if (errors.Any())
            MessageBox.Show(string.Join("\n", errors.ToHashSet()), "Encountered errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    private void FileOpenDialog(object sender, EventArgs e)
    {
        using OpenFileDialog openFileDialog = new OpenFileDialog();
        openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
        openFileDialog.Filter = "midi files (*.mid)|*.mid";
        openFileDialog.Multiselect = true;
        openFileDialog.FilterIndex = 2;
        openFileDialog.RestoreDirectory = true;

        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            filesListBox.Items.Clear();
            fileInfos = openFileDialog.FileNames.ToDictionary(key => new FileInfo(key).Name, value => new FileInfo(value));
            filesListBox.Items.AddRange(fileInfos.Keys.ToArray());
            trajectoryCacheWorker.RunWorkerAsync();
        }
    }

    private void UpdateGridSize(object sender, EventArgs e)
    {
        gridSizeLabel.Text = $"Grid size: {gridSizeTrackBar.Value * 2}";
        Refresh();
    }

    private void UpdateAxisLimits(object sender, EventArgs e)
    {
        axisLimitsLabel.Text = $"Axis limit: {axisLimitsTrackBar.Value}";
        Refresh();
    }
}
using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace FifthsTrajectoryVisualizer
{
    public partial class DisplayTab : UserControl
    {
        public DisplayTab()
        {
            InitializeComponent();
            showSignatureComponentsCheckBox.CheckedChanged += CheckboxChangedHandler;
            showTrajectoryPointsCheckBox.CheckedChanged += CheckboxChangedHandler;
            showMainAxisAndCenterCheckBox.CheckedChanged += CheckboxChangedHandler;
            showTrajectoryTrackCheckBox.CheckedChanged += CheckboxChangedHandler;
            trajectoryPointsDataGrid.DataBindingComplete += SetPointsDisplayColumnWidth;
            trajectoryPointsDataGrid.RowStateChanged += SetCurrentCPMS;
            gridSizeTrackBar.ValueChanged += UpdateGridSize;
            axisLimitsTrackBar.ValueChanged += UpdateAxisLimits;
            StateManager.Instance.SelectedTrajectoryChanged += (sender, args) => Refresh();
            SetDefaultState();
        }

        private void SetDefaultState()
        {
            showMainAxisAndCenterCheckBox.Checked = true;
            showTrajectoryPointsCheckBox.Checked = true;
            showTrajectoryTrackCheckBox.Checked = true;
            UpdateSettings();
        }

        private void CheckboxChangedHandler(object sender, EventArgs e)
        {
            UpdateSettings();
            StateManager.Instance.RepaintTrajectoryDisplay(sender, e);
        }

        private void UpdateSettings()
        {
            StateManager.Instance.CurrentSettings = new DisplaySettings
            {
                AxisLimit = axisLimitsTrackBar.Value,
                GridSize = gridSizeTrackBar.Value,
                ShowComponents = showSignatureComponentsCheckBox.Checked,
                ShowPoints = showTrajectoryPointsCheckBox.Checked,
                ShowTrack = showTrajectoryTrackCheckBox.Checked,
                ShowMainAxis = showMainAxisAndCenterCheckBox.Checked
            };
        }

        private void SetCurrentCPMS(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.StateChanged != DataGridViewElementStates.Selected ||
                trajectoryPointsDataGrid.SelectedRows.Count != 1) return;

            var index = (int)trajectoryPointsDataGrid.SelectedRows[0].Cells[0].Value;
            StateManager.Instance.SelectedSignature = StateManager.Instance.SelectedTrajectory.GetPoints()[index];

            StateManager.Instance.RepaintTrajectoryDisplay(sender, e);
        }

        private void SetPointsDisplayColumnWidth(object sender, EventArgs e)
        {
            if (sender is not DataGridView dataGridView)
                return;

            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView.Columns[dataGridView.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void UpdateGridSize(object sender, EventArgs e)
        {
            gridSizeLabel.Text = $"Grid size: {gridSizeTrackBar.Value * 2}";
            CheckboxChangedHandler(sender, e);
        }

        private void UpdateAxisLimits(object sender, EventArgs e)
        {
            axisLimitsLabel.Text = $"Axis limit: {axisLimitsTrackBar.Value}";
            CheckboxChangedHandler(sender, e);
        }

        public override void Refresh()
        {
            if (StateManager.Instance.SelectedTrajectory?.GetPoints() is var points && points?.Any() is true)
            {
                trajectoryPointsDataGrid.DataSource = points.Select(kvp =>
                    new
                    {
                        id = kvp.Key,
                        x = kvp.Value.Coordinates.X.ToString("0.00000", CultureInfo.InvariantCulture),
                        y = kvp.Value.Coordinates.Y.ToString("0.00000", CultureInfo.InvariantCulture)
                    }).ToList();
            }
            base.Refresh();
        }
    }
}
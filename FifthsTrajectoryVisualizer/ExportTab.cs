using MusicSignatureBuilder;
using MusicSignatureBuilder.Enums;
using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FifthsTrajectoryVisualizer
{
    public partial class ExportTab : UserControl
    {
        public ExportTab()
        {
            InitializeComponent();
            rangeCheckBox.CheckedChanged += RangeCheckBoxOnCheckedChanged;
            selectExportFolderButton.Click += FolderSelectDialog;
            saveExportButton.Click += SaveExportedTrajectory;
            SetDefaultState();
        }

        private void SetDefaultState()
        {
            allFilesRadioButton.Select();
            rangeCheckBox.Checked = true;
            exportRangeStart.Enabled = false;
            exportRangeEnd.Enabled = false;

            exportRangeStart.Minimum = 0;
            exportRangeEnd.Minimum = 1;

            for (int i = 0; i < exportedPrecisionsCheckedListBox.Items.Count; i++)
                exportedPrecisionsCheckedListBox.SetItemChecked(i, true);

            for (int i = 0; i < exportedModesCheckedListBox.Items.Count; i++)
                exportedModesCheckedListBox.SetItemChecked(i, true);
        }

        private void RangeCheckBoxOnCheckedChanged(object sender, EventArgs e)
        {
            if (rangeCheckBox.Checked)
            {
                exportRangeStart.Enabled = false;
                exportRangeEnd.Enabled = false;
            }
            else
            {
                exportRangeStart.Enabled = true;
                exportRangeEnd.Enabled = true;
            }
        }

        private void FolderSelectDialog(object sender, EventArgs e)
        {
            using var openFolderDialog = new FolderBrowserDialog();
            openFolderDialog.RootFolder = Environment.SpecialFolder.MyDocuments;

            if (openFolderDialog.ShowDialog() == DialogResult.OK)
            {
                exportFileLocationTextBox.Text = openFolderDialog.SelectedPath;
            }
        }

        private void SaveExportedTrajectory(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(exportFileLocationTextBox.Text) ||
                !Directory.Exists(exportFileLocationTextBox.Text))
            {
                MessageBox.Show("Save location not set!", "Unexpected error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var cached = StateManager.Instance.Trajectories;

            if (cached is null || cached.IsEmpty)
            {
                MessageBox.Show("No files imported", "Unexpected error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var filesToExport = allFilesRadioButton.Checked ? cached.Keys : StateManager.Instance.SelectedFiles;

            if (!filesToExport.Any())
            {
                MessageBox.Show("No files selected", "Unexpected error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string timestamp = $"{DateTime.Now.Year.ToString().Substring(2)}{DateTime.Now.DayOfYear.ToString().PadLeft(3, '0')}{(int)(DateTime.Now.TimeOfDay.TotalMinutes / 3)}";// DateTime.Now.ToString("ddMMyyyyHHmm", DateTimeFormatInfo.CurrentInfo);

            try
            {
                Parallel.ForEach(filesToExport, (fileName) =>
                {
                    foreach (var mode in Enum.GetValues<Modes>())
                    {
                        if (!exportedModesCheckedListBox.CheckedItems.Contains(mode.ToString()))
                            continue;

                        var exportFolder = Path.Combine(exportFileLocationTextBox.Text, $"{fileName.Replace(".mid", "")} {mode.ToString().ToLower()}-mode {timestamp}");
                        Directory.CreateDirectory(exportFolder);

                        var coefficients = new StringBuilder();
                        coefficients.Append(Trajectory.GetCoefficientsCsvHeader());

                        Parallel.ForEach(Enum.GetValues<Sampling>(), (resolution) =>
                        {
                            if (exportedPrecisionsCheckedListBox.CheckedItems.Contains(resolution.ToString()))
                            {
                                var exportFileName = $"{resolution.ToString().ToLower()}-note-points.csv";
                                coefficients.Append(cached[fileName][mode][resolution].CoefficientsToCsv(resolution));

                                var trajectoryToExport = rangeCheckBox.Checked
                                    ? cached[fileName][mode][resolution]
                                    : cached[fileName][mode][resolution].GetLimited((int)exportRangeStart.Value, (int)exportRangeEnd.Value);

                                File.WriteAllText(Path.Combine(exportFolder, exportFileName), trajectoryToExport.PointsToCsv(), Encoding.UTF8);
                            }
                        });
                        File.WriteAllText(Path.Combine(exportFolder, "coefficients.csv"), coefficients.ToString(), Encoding.UTF8);
                    }
                });
                MessageBox.Show("Trajectory export", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Unexpected error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
using MusicSignatureBuilder.Enums;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace FifthsTrajectoryVisualizer
{
    public partial class FilesTab : UserControl
    {
        public FilesTab()
        {
            InitializeComponent();
            filesListBox.SelectedIndexChanged += SetSelectedTrajectory;
            filesListBox.SelectedIndexChanged += UpdateSelectedFiles;
            filesListBox.MouseDoubleClick += PlayMidiFile;
            fileOpenButton.Click += FileOpenDialog;
            SetDefaultState();
        }

        private void SetDefaultState()
        {
            modeComboBox.Items.AddRange(Enum.GetNames<Modes>());
            precisionComboBox.Items.AddRange(Enum.GetNames<Sampling>());
        }

        private void FileOpenDialog(object sender, EventArgs e)
        {
            using OpenFileDialog openFileDialog = new();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
            openFileDialog.Filter = "midi files (*.mid)|*.mid";
            openFileDialog.Multiselect = true;
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                StateManager.Instance.ImportedFiles = openFileDialog.FileNames.ToDictionary(key => new FileInfo(key).Name, value => new FileInfo(value));
                ((MainWindow)ParentForm).RunCacheWorker();
            }
        }

        public void RefreshImportedFilesList(object sender, EventArgs e)
        {
            try
            {
                filesListBox.Items.Clear();
                filesListBox.Items.AddRange(StateManager.Instance.ImportedFiles.Keys.ToArray());
                Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Encountered errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetSelectedTrajectory(object sender, EventArgs e)
        {
            if (filesListBox.SelectedItems.Count != 1 ||
                modeComboBox.SelectedItem is null ||
                precisionComboBox.SelectedItem is null)
                return;

            if (StateManager.Instance.Trajectories.ContainsKey((string)filesListBox.SelectedItem) &&
                StateManager.Instance.Trajectories[(string)filesListBox.SelectedItem].ContainsKey(ModesExtensions.Parse(modeComboBox.Text)) &&
                StateManager.Instance.Trajectories[(string)filesListBox.SelectedItem][ModesExtensions.Parse(modeComboBox.Text)].ContainsKey(SamplingExtensions.Parse(precisionComboBox.Text)))
            {
                StateManager.Instance.SelectedTrajectory = StateManager.Instance.Trajectories
                        [(string)filesListBox.SelectedItem]
                        [ModesExtensions.Parse(modeComboBox.Text)]
                        [SamplingExtensions.Parse(precisionComboBox.Text)];

                trajectoryInfoLabel.Text = StateManager.Instance.SelectedTrajectory.ToString();
                StateManager.Instance.ChangeSelectedTrajectory(sender, e);
                StateManager.Instance.RepaintTrajectoryDisplay(sender, e);
            }
            else
                MessageBox.Show($"Unable to load trajectory for {(string)filesListBox.SelectedItem}", "Encountered errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void UpdateSelectedFiles(object sender, EventArgs e)
        {
            StateManager.Instance.SelectedFiles = filesListBox.SelectedItems.OfType<string>();
        }

        private void PlayMidiFile(object sender, MouseEventArgs e)
        {
            int index = filesListBox.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches)
            {
                try
                {
                    var filePath = StateManager.Instance.ImportedFiles[(string)filesListBox.Items[index]].FullName;
                    ProcessStartInfo startInfo = new(@"C:\Program Files (x86)\K-Lite Codec Pack\MPC-HC64\mpc-hc64_nvo.exe", filePath);
                    Process.Start(startInfo);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Encountered errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
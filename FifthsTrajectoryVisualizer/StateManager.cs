using MusicSignatureBuilder;
using MusicSignatureBuilder.Enums;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FifthsTrajectoryVisualizer
{
    public sealed class StateManager
    {
        private static readonly StateManager _instance = new();

        public ConcurrentDictionary<string, Dictionary<Modes, ConcurrentDictionary<Sampling, Trajectory>>> Trajectories { get; set; } = new();

        public IEnumerable<string> SelectedFiles { get; set; }

        public Dictionary<string, FileInfo> ImportedFiles { get; set; } = new();

        public Trajectory SelectedTrajectory { get; set; }

        public CPMS SelectedSignature { get; set; }

        public DisplaySettings CurrentSettings { get; set; } = new();

        public event EventHandler DisplayRepainted;

        public event EventHandler SelectedTrajectoryChanged;

        public static StateManager Instance => _instance;

        private StateManager()
        {
        }

        public void CreateTrajectoryCache(object sender, DoWorkEventArgs e)
        {
            var allTrajectoriesCount = ImportedFiles.Count * 10;
            var count = 0;
            var errors = new ConcurrentBag<string>();

            if (sender is not BackgroundWorker worker)
                return;

            Parallel.ForEach(ImportedFiles.Values, (file) =>
            {
                Trajectories.TryAdd(file.Name, new());
                foreach (var mode in Enum.GetValues<Modes>())
                {
                    Trajectories[file.Name].TryAdd(mode, new());
                    Parallel.ForEach(Enum.GetValues<Sampling>(), (resolution) =>
                    {
                        try
                        {
                            Trajectories[file.Name][mode].TryAdd(resolution, new Trajectory(file.FullName, resolution, mode));
                            Interlocked.Increment(ref count);
                            worker.ReportProgress(count / allTrajectoriesCount * 100);
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

        public void RepaintTrajectoryDisplay(object sender, EventArgs e)
        {
            DisplayRepainted?.Invoke(this, EventArgs.Empty);
        }

        public void ChangeSelectedTrajectory(object sender, EventArgs e)
        {
            SelectedTrajectoryChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using MidiSheetMusic;
using MusicSignatureBuilder.Coefficients;
using MusicSignatureBuilder.Enums;

namespace MusicSignatureBuilder
{
    public class Trajectory
    {
        private readonly MidiFile _midiFile;
        private readonly Dictionary<int, Fragment> _fragments = new();
        private readonly Dictionary<int, CPMS> _characteristicPoints = new();

        public Dictionary<int, CPMS> GetPoints() => _characteristicPoints;

        public Center Center { get; private set; }

        public Deviation Deviation { get; private set; }

        public Length Length { get; private set; }

        public Area Area { get; private set; }

        public MainAxis MainAxis { get; private set; }

        public Trajectory(string file, Sampling resolution, Modes mode)
        {
            _midiFile = new(file);
            Fragment.Length = (int) (_midiFile.Time.Quarter / ((int) resolution / 4.0));
            var midiNotes = _midiFile.Tracks.Where(t => t.Instrument < 112).SelectMany(t => t.Notes);
            CreateFragments(midiNotes);
            CalculateCPMS(mode);
            CalculateCoefficients();
        }

        private void CreateFragments(IEnumerable<MidiNote> midiNotes)
        {
            foreach (var midiNote in midiNotes)
            {
                int pointId = midiNote.StartTime / Fragment.Length;
                InsertCmps(pointId, _fragments, midiNote, midiNote.Duration);
            }
        }

        private void InsertCmps(int id, Dictionary<int, Fragment> points, MidiNote note, int lengthLeft)
        {
            if (lengthLeft > 0)
            {
                if (!points.ContainsKey(id))
                    points.Add(id, new(id * Fragment.Length));

                int addedLength = note.Duration;

                if (note.StartTime >= points[id].Start && note.EndTime <= points[id].End)
                {
                    points[id].AddNote(note.Number, addedLength);
                    return;
                }

                if (note.StartTime >= points[id].Start && note.EndTime > points[id].End)
                {
                    addedLength = points[id].End - note.StartTime;
                    points[id].AddNote(note.Number, addedLength);
                }
                else if (note.StartTime < points[id].Start && note.EndTime > points[id].End)
                {
                    addedLength = Fragment.Length;
                    points[id].AddNote(note.Number, addedLength);
                }
                else if (note.StartTime < points[id].Start && note.EndTime <= points[id].End)
                {
                    addedLength = note.EndTime - points[id].Start;
                    points[id].AddNote(note.Number, addedLength);
                }

                InsertCmps(id + 1, points, note, lengthLeft - addedLength);
            }
        }

        private void CalculateCPMS(Modes mode)
        {
            int count = _midiFile.TotalPulses / Fragment.Length;
            for (int i = 0; i < count; i++)
            {
                if (_fragments.ContainsKey(i))
                    _characteristicPoints.Add(i, new CPMS(_fragments[i], mode));
                else
                    _characteristicPoints.Add(i, CPMS.Empty);
            }
        }

        private void CalculateCoefficients()
        {
            Center = new Center(_characteristicPoints);
            Deviation = new Deviation(_characteristicPoints, Center);
            Length = new Length(_characteristicPoints);
            Area = new Area(_characteristicPoints, Deviation, Length);
            MainAxis = new MainAxis(_characteristicPoints, Center.Point);
        }

        public override string ToString()
        {
            return $"Number of points: {_fragments.Count} \n" +
                   $"Center of trajectory: {Center.Point} \n" +
                   $"Distance from the center of the circle of fifths: {Center.Offset.ToString("0.00", CultureInfo.InvariantCulture)} \n" +
                   $"Average deviation: {Deviation.Average.ToString("0.00", CultureInfo.InvariantCulture)} \n" +
                   $"Length of trajectory: {Length.Value.ToString("0.00", CultureInfo.InvariantCulture)} \n" +
                   $"Area relative to the center of trajectory: {Area.Relative.ToString("0.00", CultureInfo.InvariantCulture)} \n" +
                   $"Area in reference to the center of the circle of fifths: {Area.Absolute.ToString("0.00", CultureInfo.InvariantCulture)} \n" +
                   $"Predicted key(s): {MainAxis.GetKey()} \n";
        }

        public string PointsToCsv()
        {
            return $"id,x,y\n{string.Join(Environment.NewLine, _characteristicPoints.Select(p => $"{p.Key},{p.Value.Coordinates.X.ToString(CultureInfo.InvariantCulture)},{p.Value.Coordinates.Y.ToString(CultureInfo.InvariantCulture)}"))}";
        }

        public string CoefficientsToCsv(Sampling sampling)
        {
            return $"{sampling.ToString().ToLower()} note,{Center.Point.X.ToString(CultureInfo.InvariantCulture)},{Center.Point.Y.ToString(CultureInfo.InvariantCulture)}," +
                   $"{Center.Offset.ToString(CultureInfo.InvariantCulture)},{Deviation.Average.ToString(CultureInfo.InvariantCulture)},{Length.Value.ToString(CultureInfo.InvariantCulture)}," +
                   $"{Area.Relative.ToString(CultureInfo.InvariantCulture)},{Area.Absolute.ToString(CultureInfo.InvariantCulture)},{MainAxis.GetKey()}\n";
        }

        public static string GetCoefficientsCsvHeader()
        {
            return "sampling,trajectory_center_x,trajectory_center_y,distance_from_center,avg_deviation,length,area_relative,area_absolute,predicted_key\n";
        }

        public Trajectory GetLimited(int start, int end)
        {
            var clonedTrajectory = (Trajectory)MemberwiseClone();
            foreach (var key in _characteristicPoints.Keys.Where(key => key < start || key > end))
            {
                clonedTrajectory._characteristicPoints.Remove(key);
            }
            clonedTrajectory.CalculateCoefficients();
            return clonedTrajectory;
        }
    }
}
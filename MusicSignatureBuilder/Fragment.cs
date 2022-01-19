using MusicSignatureBuilder.Enums;

namespace MusicSignatureBuilder;

public class Fragment
{
    [ThreadStatic]
    public static int Length;

    public int Start { get; }

    public int End { get; }

    private readonly Dictionary<int, int> _notesDurations = new();
    private Dictionary<int, Point> _componentVectorsCoords = new();

    public Fragment(int start)
    {
        Start = start;
        End = start + Length;
    }

    public Dictionary<int, Point> GetComponentVectorCoords() => _componentVectorsCoords;

    public void AddNote(int value, int duration)
    {
        if (!_notesDurations.ContainsKey(value))
            _notesDurations.Add(value, duration);
        else
            _notesDurations[value] += duration;
    }

    public Point Calculate(Modes mode)
    {
        switch (mode)
        {
            case Modes.Count:

                var count = _notesDurations.Keys.GroupBy(note => (Scale)(note % 12))
                    .Select(group => new { Metric = group.Key, Count = (double)group.Count() });

                var max = count.Max(x => x.Count);

                var normalized = count.ToDictionary(k => k.Metric, v => v.Count / max);

                _componentVectorsCoords = normalized.Where(x => x.Value > 0).ToDictionary(x=> ToFifthCircleScale(x.Key), x => new Point(x.Value * Math.Cos(GetAngle(x.Key)), x.Value * Math.Sin(GetAngle(x.Key))));

                return new Point(_componentVectorsCoords.Values.Sum(p => p.X), _componentVectorsCoords.Values.Sum(p => p.Y));

            case Modes.Length:

                var length = _notesDurations.GroupBy(kvp => (Scale)(kvp.Key % 12))
                    .Select(group => new { Metric = group.Key, Count = group.Sum(x => x.Value) });

                max = length.Max(x => x.Count);

                normalized = length.ToDictionary(k => k.Metric, v => v.Count / max);

                _componentVectorsCoords = normalized.Where(x => x.Value > 0).ToDictionary(x => ToFifthCircleScale(x.Key), x => new Point(x.Value * Math.Cos(GetAngle(x.Key)), x.Value * Math.Sin(GetAngle(x.Key))));

                return new Point(_componentVectorsCoords.Values.Sum(p => p.X), _componentVectorsCoords.Values.Sum(p => p.Y));
        }
        return Point.Empty;
    }

    private int ToFifthCircleScale(Scale scale)
    {
        switch (scale)
        {
            case Scale.C: return 0;
            case Scale.G: return 1;
            case Scale.D: return 2;
            case Scale.A: return 3;
            case Scale.E: return 4;
            case Scale.H: return 5;
            case Scale.Fs: return 6;
            case Scale.Cs: return 7;
            case Scale.Gs: return 8;
            case Scale.Ds: return 9;
            case Scale.As: return 10;
            case Scale.F: return 11;
        }
        return -1;
    }

    private double GetAngle(Scale scale)
    {
        switch (scale)
        {
            case Scale.C:
                return Math.PI / 2;

            case Scale.Cs:
                return 4 * Math.PI / 3;

            case Scale.D:
                return Math.PI / 6;

            case Scale.Ds:
                return Math.PI;

            case Scale.E:
                return 11 * Math.PI / 6;

            case Scale.F:
                return 2 * Math.PI / 3;

            case Scale.Fs:
                return 3 * Math.PI / 2;

            case Scale.G:
                return Math.PI / 3;

            case Scale.Gs:
                return 7 * Math.PI / 6;

            case Scale.A:
                return 0;

            case Scale.As:
                return 5 * Math.PI / 6;

            case Scale.H:
                return 5 * Math.PI / 3;
        }
        return 0;
    }
}

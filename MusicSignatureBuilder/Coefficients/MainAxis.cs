namespace MusicSignatureBuilder.Coefficients;

public class MainAxis
{
    private readonly Dictionary<int, (string Major, string Minor)> keys = new()
    {
        { 0, ("C major", "A minor") },
        { 1, ("G major ", "E minor") },
        { 2, ("D major", "H minor") },
        { 3, ("A major", "F♯ minor") },
        { 4, ("E major", "C♯ minor") },
        { 5, ("H major", "G♯ minor") },
        { 6, ("G♭/F♯ major", "E♭/D♯ minor") },
        { 7, ("D♭ major", "B minor") },
        { 8, ("A♭ major", "F minor") },
        { 9, ("E♭ major", "C minor") },
        { 10, ("B major", "G minor") },
        { 11, ("F major", "D minor") }
    };

    private readonly Dictionary<int, double> vectorLengths = new();

    private readonly Point _centerOfTrajectory;

    public List<int> CalculatedAxis { get; set; } = new();

    private static readonly double sqrt3 = Math.Sqrt(3);

    public MainAxis(Dictionary<int, CPMS> points, Point centerOfTrajectory)
    {
        Dictionary<int, double> subtracted = new();
        KeyValuePair<int, double> bestMatch = new();
        _centerOfTrajectory = centerOfTrajectory;

        for (int i = 0; i < 12; i++)
        {
            vectorLengths.Add(i, 0.0);
            subtracted.Add(i, 0.0);
        }

        foreach (var pKey in points.Keys)
        {
            var notes = points[pKey].NoteVectorLengths;
            
            if (!notes.Any())
                continue;

            for (int i = 0; i < 12; i++)
            {
                vectorLengths[i] += notes.Where(x => IsInHalf(i, x.Key)).Sum(x => x.Value);
            }

            for (int i = 0; i < 12; i++)
            {
                subtracted[i] = vectorLengths[i] - vectorLengths[(i + 6) % 12];
            }

            bestMatch = subtracted.Aggregate((x, y) => x.Value > y.Value ? x : y);

            if (subtracted.Values.Where(value => value == bestMatch.Value).Count() == 1)
            {
                CalculatedAxis.Add(bestMatch.Key);
                return;
            }
        }
        var allAxes = subtracted.Where(kvp => kvp.Value == bestMatch.Value);
        CalculatedAxis.AddRange(allAxes.Select(kvp => kvp.Key));
    }

    public string GetKey()
    {
        if (CalculatedAxis.Count == 1)
        {
            var calculatedKey = keys[(CalculatedAxis[0] + 1) % 12];
            return IsMajor(CalculatedAxis[0], _centerOfTrajectory) ? calculatedKey.Major : calculatedKey.Minor;
        }
        return string.Join("\n", CalculatedAxis.Select(axis => keys[(axis + 1) % 12]));
    }

    private bool IsInHalf(int axis, int note)
    {
        if (axis <= 6)
        {
            if (note > axis && note < axis + 6)
                return true;
        }
        else
        {
            if (note > axis || note < axis - 6)
                return true;
        }
        return false;
    }

    private bool IsMajor(int mainAxis, Point p)
    {
        switch (mainAxis)
        {
            case 0:
                if (p.Y > 0) return true;
                break;
            case 1:
                if (p.Y > -(sqrt3 / 3) * p.X) return true;
                break;
            case 2:
                if (p.Y > -sqrt3 * p.X) return true;
                break;
            case 3:
                if (p.X > 0) return true;
                break;
            case 4:
                if (p.Y < sqrt3 * p.X) return true;
                break;
            case 5:
                if (p.Y < sqrt3 / 3 * p.X) return true;
                break;
            case 6:
                if (p.Y < 0) return true;
                break;
            case 7:
                if (p.Y < -(sqrt3 / 3) * p.X) return true;
                break;
            case 8:
                if (p.Y < -sqrt3 * p.X) return true;
                break;
            case 9:
                if (p.X < 0) return true;
                break;
            case 10:
                if (p.Y > sqrt3 * p.X) return true;
                break;
            case 11:
                if (p.Y > sqrt3 / 3 * p.X) return true;
                break;
        }
        return false;
    }
}
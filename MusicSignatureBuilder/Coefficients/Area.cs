namespace MusicSignatureBuilder.Coefficients;

public class Area
{
    public double Relative { get; set; }

    public double Absolute { get; set; }

    public Area(Dictionary<int, CPMS> points, Deviation deviation, Length length)
    {
        for (int i = 1; i < points.Count; i++)
        {
            double rel = Math.Abs((deviation.AllRelative[i] + deviation.AllRelative[i - 1] + length.All[i - 1]) *
                                  (deviation.AllRelative[i] + deviation.AllRelative[i - 1] - length.All[i - 1]) *
                                  (deviation.AllRelative[i] - deviation.AllRelative[i - 1] + length.All[i - 1]) *
                                  (-deviation.AllRelative[i] + deviation.AllRelative[i - 1] + length.All[i - 1]));

            Relative += Math.Sqrt(rel) / 4;

            double abs = Math.Abs((deviation.AllAbsolute[i] + deviation.AllAbsolute[i - 1] + length.All[i - 1]) *
                              (deviation.AllAbsolute[i] + deviation.AllAbsolute[i - 1] - length.All[i - 1]) *
                              (deviation.AllAbsolute[i] - deviation.AllAbsolute[i - 1] + length.All[i - 1]) *
                              (-deviation.AllAbsolute[i] + deviation.AllAbsolute[i - 1] + length.All[i - 1]));

            Absolute += Math.Sqrt(abs) / 4;
        }
    }
}
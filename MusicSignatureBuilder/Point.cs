namespace MusicSignatureBuilder;
public struct Point
{
    public double X { get; set; }

    public double Y { get; set; }

    public Point(double x, double y)
    {
        X = x;
        Y = y;
    }

    public static Point Empty = new(0, 0);

    public override string ToString()
    {
        return $"({X.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture)}, {Y.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture)})";
    }
}

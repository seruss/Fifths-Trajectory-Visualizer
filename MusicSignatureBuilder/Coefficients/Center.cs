namespace MusicSignatureBuilder.Coefficients;

public class Center
{
    public double Offset { get; }

    public Point Point { get; }

    public Center(Dictionary<int, CPMS> points)
    {
        Point = new Point(points.Values.Select(x => x.Coordinates).Average(p => p.X), points.Values.Select(x => x.Coordinates).Average(p => p.Y));
        Offset = Math.Sqrt(Point.X * Point.X + Point.Y * Point.Y);
    }
}
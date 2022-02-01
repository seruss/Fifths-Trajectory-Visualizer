namespace MusicSignatureBuilder
{
    public struct Point
    {
        public float X { get; set; }

        public float Y { get; set; }

        public Point(float x, float y)
        {
            X = x;
            Y = y;
        }

        public static Point Empty { get; } = new(0, 0);

        public override string ToString()
        {
            return
                $"({X.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture)}, {Y.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture)})";
        }
    }
}
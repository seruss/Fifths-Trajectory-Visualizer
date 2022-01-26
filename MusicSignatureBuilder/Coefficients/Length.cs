using System;
using System.Collections.Generic;
using System.Linq;

namespace MusicSignatureBuilder.Coefficients
{
    public class Length
    {
        public double Value { get; }

        public Dictionary<int, double> All { get; } = new();

        public Length(Dictionary<int, CPMS> points)
        {
            for (int i = 1; i < points.Count; i++)
            {
                All.Add(i - 1,
                    Math.Sqrt(Math.Pow(points[i].Coordinates.X - points[i - 1].Coordinates.X, 2) +
                              Math.Pow(points[i].Coordinates.Y - points[i - 1].Coordinates.Y, 2)));
            }

            Value = All.Values.Sum();
        }
    }
}

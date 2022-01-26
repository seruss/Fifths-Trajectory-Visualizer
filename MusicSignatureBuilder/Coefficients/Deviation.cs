using System;
using System.Collections.Generic;
using System.Linq;

namespace MusicSignatureBuilder.Coefficients
{
    public class Deviation
    {
        public double Average { get; }

        public Dictionary<int, double> AllRelative { get; } = new();

        public Dictionary<int, double> AllAbsolute { get; } = new();

        public Deviation(Dictionary<int, CPMS> points, Center center)
        {
            for (int i = 0; i < points.Count; i++)
            {
                AllRelative.Add(i,
                    Math.Sqrt(Math.Pow(points[i].Coordinates.X - center.Point.X, 2) +
                              Math.Pow(points[i].Coordinates.Y - center.Point.Y, 2)));
                AllAbsolute.Add(i,
                    Math.Sqrt(Math.Pow(points[i].Coordinates.X, 2) + Math.Pow(points[i].Coordinates.Y, 2)));
            }

            Average = AllRelative.Values.Average();
        }
    }
}
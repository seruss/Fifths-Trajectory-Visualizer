using System;
using System.Collections.Generic;
using System.Linq;
using MusicSignatureBuilder.Enums;

namespace MusicSignatureBuilder
{
    public class CPMS
    {
        public List<Point> Components { get; } = new();

        public Dictionary<int, double> NoteVectorLengths { get; } = new();

        public Point Coordinates { get; set; } = Point.Empty;

        public static CPMS Empty { get; } = new();

        private CPMS()
        {
        }

        public CPMS(Fragment fragment, Modes mode)
        {
            Coordinates = fragment.Calculate(mode);
            var coords = fragment.GetComponentVectorCoords();
            Components = coords.Values.ToList();
            NoteVectorLengths = coords.ToDictionary(key => key.Key, value => CalculateVectorLength(value.Value));
        }

        private double CalculateVectorLength(Point p)
        {
            return Math.Sqrt(Math.Pow(p.X, 2) + Math.Pow(p.Y, 2));
        }
    }
}
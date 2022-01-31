using System;
using System.Collections.Generic;
using System.Linq;
using MusicSignatureBuilder.Enums;

namespace MusicSignatureBuilder
{
    public class CPMS
    {
        public List<Point> Components { get; } = new();

        public Dictionary<int, float> NoteVectorLengths { get; } = new();

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

        private static float CalculateVectorLength(Point p)
        {
            return MathF.Sqrt(MathF.Pow(p.X, 2) + MathF.Pow(p.Y, 2));
        }
    }
}
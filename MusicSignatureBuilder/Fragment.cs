using System;
using System.Collections.Generic;
using System.Linq;
using MusicSignatureBuilder.Enums;

namespace MusicSignatureBuilder
{
    public class Fragment
    {
        [ThreadStatic] public static int Length;

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
                case Modes.Multiplicity:

                    var count = _notesDurations.Keys.GroupBy(note => (Scale) (note % 12))
                        .Select(group => new {Metric = group.Key, Count = (float) group.Count()});

                    var max = count.Max(x => x.Count);

                    var normalized = count.ToDictionary(k => k.Metric, v => v.Count / max);

                    _componentVectorsCoords = normalized.Where(x => x.Value > 0)
                        .ToDictionary(x => ToFifthCircleScale(x.Key),
                            x => new Point(x.Value * MathF.Cos(GetAngle(x.Key)), x.Value * MathF.Sin(GetAngle(x.Key))));

                    return new Point(_componentVectorsCoords.Values.Sum(p => p.X), _componentVectorsCoords.Values.Sum(p => p.Y));

                case Modes.Duration:

                    var length = _notesDurations.GroupBy(kvp => (Scale) (kvp.Key % 12))
                        .Select(group => new {Metric = group.Key, Count = group.Sum(x => x.Value)});

                    max = length.Max(x => x.Count);

                    normalized = length.ToDictionary(k => k.Metric, v => v.Count / max);

                    _componentVectorsCoords = normalized.Where(x => x.Value > 0)
                        .ToDictionary(x => ToFifthCircleScale(x.Key),
                            x => new Point(x.Value * MathF.Cos(GetAngle(x.Key)), x.Value * MathF.Sin(GetAngle(x.Key))));

                    return new Point(_componentVectorsCoords.Values.Sum(p => p.X), _componentVectorsCoords.Values.Sum(p => p.Y));
            }
            return Point.Empty;
        }

        private int ToFifthCircleScale(Scale scale)
        {
            return scale switch
            {
                Scale.C => 0,
                Scale.G => 1,
                Scale.D => 2,
                Scale.A => 3,
                Scale.E => 4,
                Scale.H => 5,
                Scale.Fs => 6,
                Scale.Cs => 7,
                Scale.Gs => 8,
                Scale.Ds => 9,
                Scale.As => 10,
                Scale.F => 11,
                _ => throw new ArgumentOutOfRangeException()
            };
        }

        private float GetAngle(Scale scale)
        {
            return scale switch
            {
                Scale.C => MathF.PI / 2,
                Scale.Cs => 4 * MathF.PI / 3,
                Scale.D => MathF.PI / 6,
                Scale.Ds => MathF.PI,
                Scale.E => 11 * MathF.PI / 6,
                Scale.F => 2 * MathF.PI / 3,
                Scale.Fs => 3 * MathF.PI / 2,
                Scale.G => MathF.PI / 3,
                Scale.Gs => 7 * MathF.PI / 6,
                Scale.A => 0,
                Scale.As => 5 * MathF.PI / 6,
                Scale.H => 5 * MathF.PI / 3,
                _ => throw new ArgumentOutOfRangeException(nameof(scale), scale, null)
            };
        }
    }
}
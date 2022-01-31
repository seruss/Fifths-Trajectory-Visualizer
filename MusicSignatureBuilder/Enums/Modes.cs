using System;

namespace MusicSignatureBuilder.Enums
{

    public enum Modes
    {
        Duration,
        Multiplicity
    }

    public static class ModesExtensions
    {
        public static Modes Parse(string mode)
        {
            return mode switch
            {
                nameof(Modes.Duration) => Modes.Duration,
                nameof(Modes.Multiplicity) => Modes.Multiplicity,
                _ => throw new ArgumentOutOfRangeException(nameof(mode))
            };
        }
    }
}
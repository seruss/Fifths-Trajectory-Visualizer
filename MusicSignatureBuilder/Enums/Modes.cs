using System;

namespace MusicSignatureBuilder.Enums
{

    public enum Modes
    {
        Length,
        Count
    }

    public static class ModesExtensions
    {
        public static Modes Parse(string mode)
        {
            return mode switch
            {
                nameof(Modes.Length) => Modes.Length,
                nameof(Modes.Count) => Modes.Count,
                _ => throw new ArgumentOutOfRangeException(nameof(mode))
            };
        }
    }
}
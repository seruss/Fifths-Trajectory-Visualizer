using System;

namespace MusicSignatureBuilder.Enums
{
    public enum Sampling : byte
    {
        Whole = 1,
        Half = 2,
        Quarter = 4,
        Eighth = 8,
        Sixteenth = 16
    }

    public static class SamplingExtensions
    {
        public static Sampling Parse(string resolution)
        {
            return resolution switch
            {
                nameof(Sampling.Whole) => Sampling.Whole,
                nameof(Sampling.Half) => Sampling.Half,
                nameof(Sampling.Quarter) => Sampling.Quarter,
                nameof(Sampling.Eighth) => Sampling.Eighth,
                nameof(Sampling.Sixteenth) => Sampling.Sixteenth,
                _ => throw new ArgumentOutOfRangeException(nameof(resolution))
            };
        }
    }
}
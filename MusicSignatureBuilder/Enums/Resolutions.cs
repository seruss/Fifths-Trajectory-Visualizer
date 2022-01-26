using System;

namespace MusicSignatureBuilder.Enums
{
    public enum Resolutions : byte
    {
        Whole = 1,
        Half = 2,
        Quarter = 4,
        Eighth = 8,
        Sixteenth = 16
    }

    public static class ResolutionsExtensions
    {
        public static Resolutions Parse(string resolution)
        {
            return resolution switch
            {
                nameof(Resolutions.Whole) => Resolutions.Whole,
                nameof(Resolutions.Half) => Resolutions.Half,
                nameof(Resolutions.Quarter) => Resolutions.Quarter,
                nameof(Resolutions.Eighth) => Resolutions.Eighth,
                nameof(Resolutions.Sixteenth) => Resolutions.Sixteenth,
                _ => throw new ArgumentOutOfRangeException(nameof(resolution))
            };
        }
    }
}
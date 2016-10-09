using System;
using The.Apps.Game.Core.Logger;

namespace The.Apps.Game.Core.Extensions
{
    public static class StringExtensions
    {
        public static string FormatSafe(this string text, params object[] args)
        {
            if (string.IsNullOrWhiteSpace(text))
                return null;
            try
            {
                return string.Format(text, args);
            }
            catch (Exception exception)
            {
                Log.Error("Cannot format string: " + text, exception);
            }
            return text;
        }
    }
}

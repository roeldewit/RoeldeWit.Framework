using System;
using System.Globalization;

namespace RoeldeWit.Framework
{
    /// <summary>
    /// Class containing string extension methods
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// Replaces the format items in a specified string with the string representations of corresponding objects in a specified array using the current culture
        /// </summary>
        /// <param name="format">A composite format string</param>
        /// <param name="args">An object array that contains zero or more objects to format</param>
        /// <returns>A copy of format in which the format items have been replaced by the string representation of the corresponding objects in args</returns>
        public static string FormatCurrent(this string format, params Object[] args)
        {
            return string.Format(CultureInfo.CurrentCulture, format, args);
        }

        /// <summary>
        /// Replaces the format items in a specified string with the string representations of corresponding objects in a specified array using a invariant culture
        /// </summary>
        /// <param name="format">A composite format string</param>
        /// <param name="args">An object array that contains zero or more objects to format</param>
        /// <returns>A copy of format in which the format items have been replaced by the string representation of the corresponding objects in args</returns>
        public static string FormatInvariant(this string format, params Object[] args)
        {
            return string.Format(CultureInfo.InvariantCulture, format, args);
        }
    }
}

using System;
using System.Diagnostics.CodeAnalysis;

namespace Ministry
{
    /// <summary>
    /// Extension Methods for working with DateTime objects.
    /// </summary>
    [SuppressMessage("ReSharper", "UnusedMember.Global", Justification = "Library")]
    [SuppressMessage("ReSharper", "MemberCanBePrivate.Global", Justification = "Library")]
    [SuppressMessage("ReSharper", "UnusedType.Global", Justification = "Library")]
    public static class DateTimeHelper
    {
        /// <summary>
        /// The Unix epoch for calculations since 1970.
        /// </summary>
        /// <value>
        /// The generally accepted minimum DateTime for dating digital resources.
        /// </value>
        private static DateTime MinUnixTime => new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        /// <summary>
        /// Applies a Gmt offset to the DateTime.
        /// </summary>
        /// <param name="time">The time without gmt.</param>
        /// <returns>The input time with the computer's current gmt offset applied.</returns>
        public static DateTime ToGmtTime(this DateTime time)
            => time - (DateTime.Now.AddDays(1) - DateTime.UtcNow.AddDays(1));

        /// <summary>
        /// Applies a Gmt offset to the DateTime.
        /// </summary>
        /// <param name="time">The time without gmt.</param>
        /// <returns>The input time with the computer's current gmt offset applied.</returns>
        public static DateTime FromGmtTime(this DateTime time)
            => time - (DateTime.UtcNow.AddDays(1) - DateTime.Now.AddDays(1));

        /// <summary>
        /// Calculates the number of seconds since 1970, a Unix based date format.
        /// </summary>
        /// <remarks>Converts the input <see cref="ToGmtTime"/> to account for the computer.</remarks>
        /// <param name="time">The time to calculate seconds for.</param>
        /// <returns>The number of seconds since 1970.</returns>
        public static long ToUnixEpochTime(this DateTime time)
            => (long)time.ToUnixEpochTimeDouble();

        /// <summary>
        /// Calculates the number of seconds since 1970, a Unix based date format.
        /// </summary>
        /// <remarks>Converts the input <see cref="ToGmtTime"/> to account for the computer.</remarks>
        /// <param name="time">The time to calculate seconds for.</param>
        /// <returns>The number of seconds since 1970.</returns>
        public static double ToUnixEpochTimeDouble(this DateTime time)
            => time.ToLocalTime().Subtract(MinUnixTime).TotalSeconds;

        /// <summary>
        /// Calculates the number of seconds since 1970, a Unix based date format.
        /// </summary>
        /// <remarks>Converts the input <see cref="ToGmtTime"/> to account for the computer.</remarks>
        /// <param name="time">The time to calculate seconds for.</param>
        /// <returns>The number of seconds since 1970.</returns>
        public static DateTime FromUnixEpochTime(this long time)
            => MinUnixTime.AddSeconds(time);

        /// <summary>
        /// Calculates the number of seconds since 1970, a Unix based date format.
        /// </summary>
        /// <remarks>Converts the input <see cref="ToGmtTime"/> to account for the computer.</remarks>
        /// <param name="time">The time to calculate seconds for.</param>
        /// <returns>The number of seconds since 1970.</returns>
        public static DateTime FromUnixEpochTime(this int time)
            => MinUnixTime.AddSeconds(time);

        /// <summary>
        /// Calculates the number of seconds since 1970, a Unix based date format.
        /// </summary>
        /// <remarks>Converts the input <see cref="ToGmtTime"/> to account for the computer.</remarks>
        /// <param name="time">The time to calculate seconds for.</param>
        /// <returns>The number of seconds since 1970.</returns>
        public static DateTime FromUnixEpochTime(this double time)
            => MinUnixTime.AddSeconds(time);
    }
}
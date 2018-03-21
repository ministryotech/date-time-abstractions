using System;
using System.Diagnostics.CodeAnalysis;

// ReSharper disable once CheckNamespace
namespace Ministry
{
    #region | Interface |

    /// <summary>
    /// Accesses Date & Time information.
    /// </summary>
    public interface IDateTimeAccessor
    {
        /// <summary>
        /// Gets the current Date & Time
        /// </summary>
        DateTime Now { get; }
    }

    #endregion

    /// <summary>
    /// Accesses Date & Time information.
    /// </summary>
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    public class DateTimeAccessor : IDateTimeAccessor
    {
        /// <summary>
        /// Gets the current Date & Time
        /// </summary>
        public DateTime Now => DateTime.Now;
    }
}

using System;
using System.Diagnostics.CodeAnalysis;

namespace Ministry
{
    #region | Interface |

    /// <summary>
    /// Accesses Date and Time information.
    /// </summary>
    [SuppressMessage("ReSharper", "UnusedMember.Global", Justification = "Library")]
    public interface IDateTimeAccessor
    {
        /// <summary>
        /// Gets the current Date and Time
        /// </summary>
        /// <value>
        /// A replaceable variation on DateTime.<see cref="System.DateTime.Now"/>.
        /// </value>
        DateTime Now { get; }
    }

    #endregion

    /// <inheritdoc cref="IDateTimeAccessor"/>
    [SuppressMessage("ReSharper", "UnusedMember.Global", Justification = "Library")]
    [SuppressMessage("ReSharper", "UnusedType.Global", Justification = "Library")]
    public class DateTimeAccessor : IDateTimeAccessor
    {
        /// <inheritdoc/>
        public DateTime Now => DateTime.Now;
    }
}
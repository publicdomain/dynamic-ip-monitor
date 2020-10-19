// // <copyright file="DynamicIpMonitorSettings.cs" company="PublicDomain.com">
// //     CC0 1.0 Universal (CC0 1.0) - Public Domain Dedication
// //     https://creativecommons.org/publicdomain/zero/1.0/legalcode
// // </copyright>

namespace DynamicIpMonitor
{
    // Directives
    using System;

    /// <summary>
    /// Dynamic ip monitor settings.
    /// </summary>
    public class DynamicIpMonitorSettings
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:DynamicIpMonitor.DynamicIpMonitorSettings"/> class.
        /// </summary>
        public DynamicIpMonitorSettings()
        {
            // Parameterless constructor
        }

        /// <summary>
        /// Gets or sets the domain.
        /// </summary>
        /// <value>The domain.</value>
        public string Domain { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the interval.
        /// </summary>
        /// <value>The interval.</value>
        public int Interval { get; set; } = 30;

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="T:DynamicIpMonitor.DynamicIpMonitorSettings"/> is
        /// manual copy.
        /// </summary>
        /// <value><c>true</c> if is manual copy; otherwise, <c>false</c>.</value>
        public bool IsManualCopy { get; set; } = false;

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="T:DynamicIpMonitor.DynamicIpMonitorSettings"/> save
        /// on exit.
        /// </summary>
        /// <value><c>true</c> if save on exit; otherwise, <c>false</c>.</value>
        public bool SaveOnExit { get; set; } = true;
    }
}

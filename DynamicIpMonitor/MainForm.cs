// <copyright file="MainForm.cs" company="PublicDomain.com">
//     CC0 1.0 Universal (CC0 1.0) - Public Domain Dedication
//     https://creativecommons.org/publicdomain/zero/1.0/legalcode
// </copyright>

namespace DynamicIpMonitor
{
    // Directives
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Net;
    using System.Timers;
    using System.Windows.Forms;

    /// <summary>
    /// Description of MainForm.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// The ip address.
        /// </summary>
        string ipAddress;

        /// <summary>
        /// The ip address timer.
        /// </summary>
        System.Timers.Timer ipAddressTimer;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:DynamicIpMonitor.MainForm"/> class.
        /// </summary>
        public MainForm()
        {
            // The InitializeComponent() call is required for Windows Forms designer support.
            this.InitializeComponent();
        }

        /// <summary>
        /// Handles the start stop button click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnStartStopButtonClick(object sender, EventArgs e)
        {
            // TODO Add code
        }

        /// <summary>
        /// Handles the timer elapsed event.
        /// </summary>
        /// <param name="sender">Source object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnTimerElapsed(object sender, ElapsedEventArgs e)
        {
            // Get the IP address
            try
            {
                // Inform the user
                this.SetStatus("Working:", "Getting iP address...");

                // Set ip address
                this.ipAddress = $"{Dns.GetHostAddresses(domainTextBox.Text)[0]}";

                // Check if must copy
                if (this.copyCheckBox.Checked)
                {
                    // Copy IP to clupboard
                    Clipboard.SetText(this.ipAddress);
                }

                // Set ip address text box
                this.ipAddressTextBox.Text = this.ipAddress;

                // Inform the user
                this.SetStatus("Success:", "IP address set");
            }
            catch (Exception ex)
            {
                // Inform the user
                this.SetStatus("Error:", ex.Message);

                // Halt flow
                return;
            }
        }

        /// <summary>
        /// Handles the new tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnNewToolStripMenuItemClick(object sender, EventArgs e)
        {
            // TODO Add code
        }

        /// <summary>
        /// Handles the save tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnSaveToolStripMenuItemClick(object sender, EventArgs e)
        {
            // TODO Add code
        }

        /// <summary>
        /// Handles the exit tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnExitToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Close program
            this.Close();
        }

        /// <summary>
        /// Handles the daily releases public domain dailycom tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnDailyReleasesPublicDomainDailycomToolStripMenuItemClick(object sender, EventArgs e)
        {
            // TODO Add code
        }

        /// <summary>
        /// Handles the original thread donation codercom tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnOriginalThreadDonationCodercomToolStripMenuItemClick(object sender, EventArgs e)
        {
            // TODO Add code
        }

        /// <summary>
        /// Handles the source code githubcom tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnSourceCodeGithubcomToolStripMenuItemClick(object sender, EventArgs e)
        {
            // TODO Add code
        }

        /// <summary>
        /// Handles the about tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnAboutToolStripMenuItemClick(object sender, EventArgs e)
        {
            // TODO Add code
        }

        /// <summary>
        /// Sets the status.
        /// </summary>
        /// <param name="main">The main string.</param>
        /// <param name="secondary">The secondary string.</param>
        private void SetStatus(string main, string secondary)
        {
            // Set main 
            this.mainToolStripStatusLabel.Text = main;

            // Set secondary
            this.secondaryUnitToolStripStatusLabel.Text = secondary;
        }
    }
}

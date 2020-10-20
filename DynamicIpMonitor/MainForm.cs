﻿// <copyright file="MainForm.cs" company="PublicDomain.com">
//     CC0 1.0 Universal (CC0 1.0) - Public Domain Dedication
//     https://creativecommons.org/publicdomain/zero/1.0/legalcode
// </copyright>

namespace DynamicIpMonitor
{
    // Directives
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Drawing;
    using System.IO;
    using System.Net;
    using System.Timers;
    using System.Windows.Forms;
    using System.Xml.Serialization;

    /// <summary>
    /// Description of MainForm.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// The ip address.
        /// </summary>
        private string ipAddress;

        /// <summary>
        /// The ip address timer.
        /// </summary>
        private System.Timers.Timer ipAddressTimer;

        /// <summary>
        /// The dynamic ip monitor settings.
        /// </summary>
        private DynamicIpMonitorSettings dynamicIpMonitorSettings = new DynamicIpMonitorSettings();

        /// <summary>
        /// The dynamic ip monitor settings file path.
        /// </summary>
        private string dynamicIpMonitorSettingsFilePath = "DynamicIpMonitorSettings.txt";

        /// <summary>
        /// Initializes a new instance of the <see cref="T:DynamicIpMonitor.MainForm"/> class.
        /// </summary>
        public MainForm()
        {
            // The InitializeComponent() call is required for Windows Forms designer support.
            this.InitializeComponent();

            /* Load settings */

            // Look for settings file
            if (File.Exists(this.dynamicIpMonitorSettingsFilePath))
            {
                // Load from disk
                this.dynamicIpMonitorSettings = this.LoadSettingsFile(this.dynamicIpMonitorSettingsFilePath);

                // Set GUI
                this.SetGuiByLoadedSettings();
            }
        }

        /// <summary>
        /// Handles the start stop button click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnStartStopButtonClick(object sender, EventArgs e)
        {
            // Check button text
            if ((e != null) && this.startStopButton.Text.EndsWith("t", StringComparison.InvariantCulture))
            {
                // Check there's something to work with
                if (this.domainTextBox.TextLength == 0)
                {
                    // Advise user
                    this.SetStatus("Error:", "Empty domain!");

                    // Focus doman text box
                    this.domainTextBox.Focus();

                    // Halt flow
                    return;
                }

                // Set to stop
                this.startStopButton.Text = "&Stop";
                this.startStopButton.ForeColor = Color.Red;

                // Disable domain text box
                this.domainTextBox.Enabled = false;

                // Process IP address timer
                this.ipAddressTimer = new System.Timers.Timer((double)(this.intervalNumericUpDown.Value * 60 * 1000));
                this.ipAddressTimer.Elapsed += this.OnTimerElapsed;
                this.ipAddressTimer.Enabled = true;

                // Trigger first timer elapsed
                this.OnTimerElapsed(sender, null);
            }
            else
            {
                // Dispose of timer
                this.ipAddressTimer.Dispose();

                // Set to start
                this.startStopButton.Text = "&Start";
                this.startStopButton.ForeColor = Color.Green;

                // Ensable domain text box
                this.domainTextBox.Enabled = true;
            }
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
                    // Copy IP to clipboard
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
        /// Handles the new tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnNewToolStripMenuItemClick(object sender, EventArgs e)
        {
            // TODO Add code
        }

        /// <summary>
        /// Handles the open tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnOpenToolStripMenuItemClick(object sender, EventArgs e)
        {
            // TODO Add code
        }

        /// <summary>
        /// Handles the save tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnSaveToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Update settings by GUI values
            this.UpdateSettingsByGui();

            // Save settings to file
            this.SaveSettingsFile(this.dynamicIpMonitorSettingsFilePath);

            // Update status
            this.SetStatus("Saved settings file to disk.", string.Empty);
        }

        /// <summary>
        /// Handles the save as tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnSaveAsToolStripMenuItemClick(object sender, EventArgs e)
        {
            // TODO Add code
        }

        /// <summary>
        /// Handles the cut tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnCutToolStripMenuItemClick(object sender, EventArgs e)
        {
            // TODO Add code
        }

        /// <summary>
        /// Handles the copy tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnCopyToolStripMenuItemClick(object sender, EventArgs e)
        {
            // TODO Add code
        }

        /// <summary>
        /// Handles the paste tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnPasteToolStripMenuItemClick(object sender, EventArgs e)
        {
            // TODO Add code
        }

        /// <summary>
        /// Handles the select all tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnSelectAllToolStripMenuItemClick(object sender, EventArgs e)
        {
            // TODO Add code
        }

        /// <summary>
        /// Handles the exit tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnExitToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Close program
            this.Close();
        }

        /// <summary>
        /// Handles the daily releases public domain dailycom tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnDailyReleasesPublicDomainDailycomToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Open current website
            Process.Start("https://publicdomaindaily.com");
        }

        /// <summary>
        /// Handles the original thread donation codercom tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnOriginalThreadDonationCodercomToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Open original thread @ DonationCoder
            Process.Start("https://www.donationcoder.com/forum/index.php?topic=50589.0");
        }

        /// <summary>
        /// Handles the source code githubcom tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnSourceCodeGithubcomToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Open GitHub repository
            Process.Start("https://github.com/publicdomain/dynamic-ip-monitor");
        }

        /// <summary>
        /// Handles the about tool strip menu item click event.
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

        /// <summary>
        /// Handles the copy check box checked changed event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnCopyCheckBoxCheckedChanged(object sender, EventArgs e)
        {
            // Toggle copy text
            this.copyCheckBox.Text = this.copyCheckBox.Text.EndsWith("o", StringComparison.InvariantCulture) ? "&Manual" : "&Auto";
        }

        /// <summary>
        /// Handles the options tool strip menu item drop down item clicked event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnOptionsToolStripMenuItemDropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            // Set tool strip menu item
            ToolStripMenuItem toolStripMenuItem = (ToolStripMenuItem)e.ClickedItem;

            // Toggle checked
            toolStripMenuItem.Checked = !toolStripMenuItem.Checked;
        }

        /// <summary>
        /// Sets the GUI by loaded settings.
        /// </summary>
        private void SetGuiByLoadedSettings()
        {
            // Set domain
            this.domainTextBox.Text = this.dynamicIpMonitorSettings.Domain;

            // Set interval
            this.intervalNumericUpDown.Value = this.dynamicIpMonitorSettings.Interval;

            // Set copy mode
            this.copyCheckBox.Checked = this.dynamicIpMonitorSettings.IsAutoCopy;

            // Set save on exit menu item
            this.saveOnExitToolStripMenuItem.Checked = this.dynamicIpMonitorSettings.SaveOnExit;
        }

        /// <summary>
        /// Updates the settings by GUI.
        /// </summary>
        private void UpdateSettingsByGui()
        {
            // Update domain
            this.dynamicIpMonitorSettings.Domain = this.domainTextBox.Text;

            // Update interval
            this.dynamicIpMonitorSettings.Interval = (int)this.intervalNumericUpDown.Value;

            // Update copy mode
            this.dynamicIpMonitorSettings.IsAutoCopy = this.copyCheckBox.Checked;

            // Update save on exit
            this.dynamicIpMonitorSettings.SaveOnExit = this.saveOnExitToolStripMenuItem.Checked;
        }

        /// <summary>
        /// Loads the settings file.
        /// </summary>
        /// <returns>The settings file.</returns>
        /// <param name="settingsFilePath">Settings file path.</param>
        private DynamicIpMonitorSettings LoadSettingsFile(string settingsFilePath)
        {
            // Use file stream
            using (FileStream fileStream = File.OpenRead(settingsFilePath))
            {
                // Set xml serialzer
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(DynamicIpMonitorSettings));

                // Return populated settings data
                return xmlSerializer.Deserialize(fileStream) as DynamicIpMonitorSettings;
            }
        }

        /// <summary>
        /// Saves the settings file.
        /// </summary>
        /// <param name="settingsFilePath">Settings file path.</param>
        private void SaveSettingsFile(string settingsFilePath)
        {
            try
            {
                // Use stream writer
                using (StreamWriter streamWriter = new StreamWriter(settingsFilePath, false))
                {
                    // Set xml serialzer
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(DynamicIpMonitorSettings));

                    // Serialize settings data
                    xmlSerializer.Serialize(streamWriter, this.dynamicIpMonitorSettings);
                }
            }
            catch (Exception ex)
            {
                // Advise user
                MessageBox.Show($"Error saving settings file.{Environment.NewLine}{Environment.NewLine}Message:{Environment.NewLine}{ex.Message}", "File error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

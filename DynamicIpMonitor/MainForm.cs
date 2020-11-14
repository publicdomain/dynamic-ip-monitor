// <copyright file="MainForm.cs" company="PublicDomain.com">
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
    using System.Linq;
    using System.Net;
    using System.Reflection;
    using System.Timers;
    using System.Windows.Forms;
    using System.Xml.Serialization;
    using PublicDomain;

    /// <summary>
    /// Description of MainForm.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// The IP address text.
        /// </summary>
        private string ipAddressText;

        /// <summary>
        /// The ip address timer.
        /// </summary>
        private System.Timers.Timer ipAddressTimer;

        /// <summary>
        /// Gets or sets the associated icon.
        /// </summary>
        /// <value>The associated icon.</value>
        private Icon associatedIcon;

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

            /* Set associated icon */

            // Set associated icon from exe file
            this.associatedIcon = Icon.ExtractAssociatedIcon(typeof(MainForm).GetTypeInfo().Assembly.Location);

            // Set public domain weekly tool strip menu item image
            this.weeklyReleasesPublicDomainWeeklycomToolStripMenuItem.Image = this.associatedIcon.ToBitmap();

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
            // [TODO] Set domain list. [Can be cleaned by regex. Invalid character input can be prevented on key preview.]
            List<string> domainList = this.domainTextBox.Text.Replace(" ", string.Empty).Split(',').ToList();

            // TODO Declare IP addresses list [Type can be changed to System.Net.IPAddress]
            List<string> ipAddressList = new List<string>();

            // Error count
            int errorCount = 0;

            // Process domain list
            foreach (string domain in domainList)
            {
                // IP address or error string
                string ipOrError = this.domainIPFormatToolStripMenuItem.Checked ? $"{domain}=" : string.Empty;

                try
                {
                    // Inform the user
                    this.SetStatus($"Working:", "Getting IP for {domain}...");

                    // Set IP
                    ipOrError += $"{Dns.GetHostAddresses(domain)[0]}";
                }
                catch (Exception ex)
                {
                    // Check if must process errors' log file
                    if (this.logErrorsToFileToolStripMenuItem.Checked)
                    {
                        // Add event to error log
                        File.AppendAllLines(
                            "ErrorLog.txt",
                            new List<string>()
                            {
                                "----------------------",
                                DateTime.UtcNow.ToString(),
                                "----------------------",
                                $"{domain}:",
                                ex.Message
                            });
                    }

                    // Set error 
                    ipOrError += $"Error";

                    // Raise error count
                    errorCount++;
                }

                // Add result to IP address list
                ipAddressList.Add(ipOrError);
            }

            // Set IP address(es) text
            this.ipAddressText = string.Join(", ", ipAddressList);

            // Check if must copy
            if (this.copyCheckBox.Checked)
            {
                // Copy IP address(es) to clipboard
                Clipboard.SetText(this.ipAddressText);
            }

            // Set ip address text box
            this.ipAddressTextBox.Text = this.ipAddressText;

            // Inform the user
            this.SetStatus("Proessed:", $"{domainList.Count} domains.{(errorCount > 0 ? $" Errors: {errorCount}" : string.Empty)}");
        }

        /// <summary>
        /// Handle the main form form closing event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnMainFormFormClosing(object sender, FormClosingEventArgs e)
        {
            // Check if must save
            if (this.saveOnExitToolStripMenuItem.Checked)
            {
                // Update settings by GUI values
                this.UpdateSettingsByGui();

                // Save settings to file
                this.SaveSettingsFile(this.dynamicIpMonitorSettingsFilePath);
            }
        }

        /// <summary>
        /// Handles the new tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnNewToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Check if must remove settings file
            if (File.Exists(this.dynamicIpMonitorSettingsFilePath))
            {
                // Remove settings file
                File.Delete(this.dynamicIpMonitorSettingsFilePath);
            }

            // Check if must stop the monitor
            if (this.startStopButton.Text.EndsWith("p", StringComparison.InvariantCulture))
            {
                // Stop the monitor
                this.startStopButton.PerformClick();
            }

            // Clear IP text box
            this.ipAddressTextBox.Clear();

            // Reset settings
            this.dynamicIpMonitorSettings = new DynamicIpMonitorSettings();

            // Reset GUI with fresh setting
            this.SetGuiByLoadedSettings();
        }

        /// <summary>
        /// Handles the open tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnOpenToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Ensure it's stopped
            if (!this.domainTextBox.Enabled)
            {
                // Advise user
                MessageBox.Show("Please stop the monitor first.", "Monitor running", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                // Halt flow
                return;
            }

            // Set save file name
            this.openFileDialog.FileName = this.dynamicIpMonitorSettingsFilePath;

            // Show open file dialog
            if (this.openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Load from disk
                    this.dynamicIpMonitorSettings = this.LoadSettingsFile(this.openFileDialog.FileName);

                    // Set GUI
                    this.SetGuiByLoadedSettings();
                }
                catch (Exception exception)
                {
                    // Inform user
                    MessageBox.Show($"Error when opening \"{Path.GetFileName(this.openFileDialog.FileName)}\":{Environment.NewLine}{exception.Message}", "Open file error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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
            // Set save file name
            this.saveFileDialog.FileName = this.dynamicIpMonitorSettingsFilePath;

            // Open save file dialog
            if (this.saveFileDialog.ShowDialog() == DialogResult.OK && this.saveFileDialog.FileName.Length > 0)
            {
                try
                {
                    // Update settings by GUI values
                    this.UpdateSettingsByGui();

                    // Save settings to file
                    this.SaveSettingsFile(this.saveFileDialog.FileName);
                }
                catch (Exception exception)
                {
                    // Inform user
                    MessageBox.Show($"Error when saving to \"{Path.GetFileName(this.saveFileDialog.FileName)}\":{Environment.NewLine}{exception.Message}", "Save file error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Inform user
                MessageBox.Show($"Saved settings file to \"{Path.GetFileName(this.saveFileDialog.FileName)}\"", "Settings file saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Handles the cut tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnCutToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Click copy
            this.copyToolStripMenuItem.PerformClick();

            // Clear IP address text box
            this.ipAddressTextBox.Clear();
        }

        /// <summary>
        /// Handles the copy tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnCopyToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Check there's something to work with
            if (this.ipAddressTextBox.Text.Length > 0)
            {
                // Copy IP address
                Clipboard.SetText(this.ipAddressTextBox.Text);

                // Update status
                this.SetStatus("IP address text box copied.", string.Empty);
            }
            else
            {
                // Advise user
                this.SetStatus("Empty IP address text box.", string.Empty);
            }
        }

        /// <summary>
        /// Handles the paste tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnPasteToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Check there's something to paste
            if (Clipboard.ContainsText())
            {
                // Copy to domain text box
                this.domainTextBox.Text = Clipboard.GetText();
            }
            else
            {
                // Advise user
                this.SetStatus("No text to paste.", string.Empty);
            }
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
        /// Handles the weekly releases public domain weeklycom tool strip menu item click event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnWeeklyReleasesPublicDomainWeeklycomToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Open current website
            Process.Start("https://publicdomainweekly.com");
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
            // Set license text
            var licenseText = $"CC0 1.0 Universal (CC0 1.0) - Public Domain Dedication{Environment.NewLine}" +
                $"https://creativecommons.org/publicdomain/zero/1.0/legalcode{Environment.NewLine}{Environment.NewLine}" +
                $"Libraries and icons have separate licenses.{Environment.NewLine}{Environment.NewLine}" +
                $"Domain website icon by mohamed_hassan - Pixabay License{Environment.NewLine}" +
                $"https://pixabay.com/vectors/domain-website-blogging-design-3655918/{Environment.NewLine}{Environment.NewLine}" +
                $"Patreon icon used according to published brand guidelines{Environment.NewLine}" +
                $"https://www.patreon.com/brand{Environment.NewLine}{Environment.NewLine}" +
                $"GitHub mark icon used according to published logos and usage guidelines{Environment.NewLine}" +
                $"https://github.com/logos{Environment.NewLine}{Environment.NewLine}" +
                $"DonationCoder icon used with permission{Environment.NewLine}" +
                $"https://www.donationcoder.com/forum/index.php?topic=48718{Environment.NewLine}{Environment.NewLine}" +
                $"PublicDomain icon is based on the following source images:{Environment.NewLine}{Environment.NewLine}" +
                $"Bitcoin by GDJ - Pixabay License{Environment.NewLine}" +
                $"https://pixabay.com/vectors/bitcoin-digital-currency-4130319/{Environment.NewLine}{Environment.NewLine}" +
                $"Letter P by ArtsyBee - Pixabay License{Environment.NewLine}" +
                $"https://pixabay.com/illustrations/p-glamour-gold-lights-2790632/{Environment.NewLine}{Environment.NewLine}" +
                $"Letter D by ArtsyBee - Pixabay License{Environment.NewLine}" +
                $"https://pixabay.com/illustrations/d-glamour-gold-lights-2790573/{Environment.NewLine}{Environment.NewLine}";

            // Set title
            string programTitle = typeof(MainForm).GetTypeInfo().Assembly.GetCustomAttribute<AssemblyTitleAttribute>().Title;

            // Set version for generating semantic version 
            Version version = typeof(MainForm).GetTypeInfo().Assembly.GetName().Version;

            // Set about form
            var aboutForm = new AboutForm(
                $"About {programTitle}",
                $"{programTitle} {version.Major}.{version.Minor}.{version.Build}",
                $"Made for: davcom{Environment.NewLine}DonationCoder.com{Environment.NewLine}Day #306, Week #44 @ November 01, 2020",
                licenseText,
                this.Icon.ToBitmap());

            // Set about form icon
            aboutForm.Icon = this.associatedIcon;

            // Show about form
            aboutForm.ShowDialog();
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

            // Set Domain=IP format
            this.domainIPFormatToolStripMenuItem.Checked = this.dynamicIpMonitorSettings.DomainIpFormat;

            // Set log errors to file menu item
            this.logErrorsToFileToolStripMenuItem.Checked = this.dynamicIpMonitorSettings.LogErrorToFile;
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

            // Udate Domain=IP format
            this.dynamicIpMonitorSettings.DomainIpFormat = this.domainIPFormatToolStripMenuItem.Checked;

            // Update log errors to file
            this.dynamicIpMonitorSettings.LogErrorToFile = this.logErrorsToFileToolStripMenuItem.Checked;
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
            catch (Exception exception)
            {
                // Advise user
                MessageBox.Show($"Error saving settings file.{Environment.NewLine}{Environment.NewLine}Message:{Environment.NewLine}{exception.Message}", "File error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

﻿// <copyright file="MainForm.Designer.cs" company="PublicDomain.com">
//     CC0 1.0 Universal (CC0 1.0) - Public Domain Dedication
//     https://creativecommons.org/publicdomain/zero/1.0/legalcode
// </copyright>
// <auto-generated />

namespace DynamicIpMonitor
{
    partial class MainForm
    {
        /// <summary>
        /// Designer variable used to keep track of non-visual components.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Disposes resources used by the form.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// This method is required for Windows Forms designer support.
        /// Do not change the method contents inside the source code editor. The Forms designer might
        /// not be able to load this method if it was changed manually.
        /// </summary>
        private void InitializeComponent()
        {
        	System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
        	this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
        	this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
        	this.newToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
        	this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
        	this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
        	this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
        	this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
        	this.minimizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.saveOnExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.domainIPFormatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.dailyReleasesPublicDomainDailycomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.originalThreadDonationCodercomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.sourceCodeGithubcomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
        	this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.mainStatusStrip = new System.Windows.Forms.StatusStrip();
        	this.mainToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
        	this.secondaryUnitToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
        	this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
        	this.startStopButton = new System.Windows.Forms.Button();
        	this.label1 = new System.Windows.Forms.Label();
        	this.label2 = new System.Windows.Forms.Label();
        	this.domainTextBox = new System.Windows.Forms.TextBox();
        	this.intervalNumericUpDown = new System.Windows.Forms.NumericUpDown();
        	this.ipAddressLabel = new System.Windows.Forms.Label();
        	this.copyLabel = new System.Windows.Forms.Label();
        	this.copyCheckBox = new System.Windows.Forms.CheckBox();
        	this.ipAddressTextBox = new System.Windows.Forms.TextBox();
        	this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
        	this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
        	this.mainMenuStrip.SuspendLayout();
        	this.mainStatusStrip.SuspendLayout();
        	this.mainTableLayoutPanel.SuspendLayout();
        	((System.ComponentModel.ISupportInitialize)(this.intervalNumericUpDown)).BeginInit();
        	this.SuspendLayout();
        	// 
        	// mainMenuStrip
        	// 
        	this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
        	        	        	this.fileToolStripMenuItem1,
        	        	        	this.minimizeToolStripMenuItem,
        	        	        	this.editToolStripMenuItem,
        	        	        	this.optionsToolStripMenuItem,
        	        	        	this.helpToolStripMenuItem});
        	this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
        	this.mainMenuStrip.Name = "mainMenuStrip";
        	this.mainMenuStrip.Size = new System.Drawing.Size(252, 24);
        	this.mainMenuStrip.TabIndex = 21;
        	// 
        	// fileToolStripMenuItem1
        	// 
        	this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
        	        	        	this.newToolStripMenuItem1,
        	        	        	this.openToolStripMenuItem,
        	        	        	this.toolStripSeparator3,
        	        	        	this.saveToolStripMenuItem1,
        	        	        	this.saveAsToolStripMenuItem,
        	        	        	this.toolStripSeparator5,
        	        	        	this.exitToolStripMenuItem1});
        	this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
        	this.fileToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
        	this.fileToolStripMenuItem1.Text = "&File";
        	// 
        	// newToolStripMenuItem1
        	// 
        	this.newToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem1.Image")));
        	this.newToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Magenta;
        	this.newToolStripMenuItem1.Name = "newToolStripMenuItem1";
        	this.newToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
        	this.newToolStripMenuItem1.Size = new System.Drawing.Size(186, 22);
        	this.newToolStripMenuItem1.Text = "&New";
        	this.newToolStripMenuItem1.Click += new System.EventHandler(this.OnNewToolStripMenuItemClick);
        	// 
        	// openToolStripMenuItem
        	// 
        	this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
        	this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
        	this.openToolStripMenuItem.Name = "openToolStripMenuItem";
        	this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
        	this.openToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
        	this.openToolStripMenuItem.Text = "&Open";
        	this.openToolStripMenuItem.Click += new System.EventHandler(this.OnOpenToolStripMenuItemClick);
        	// 
        	// toolStripSeparator3
        	// 
        	this.toolStripSeparator3.Name = "toolStripSeparator3";
        	this.toolStripSeparator3.Size = new System.Drawing.Size(183, 6);
        	// 
        	// saveToolStripMenuItem1
        	// 
        	this.saveToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem1.Image")));
        	this.saveToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Magenta;
        	this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
        	this.saveToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
        	this.saveToolStripMenuItem1.Size = new System.Drawing.Size(186, 22);
        	this.saveToolStripMenuItem1.Text = "&Save";
        	this.saveToolStripMenuItem1.Click += new System.EventHandler(this.OnSaveToolStripMenuItemClick);
        	// 
        	// saveAsToolStripMenuItem
        	// 
        	this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
        	this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
        	        	        	| System.Windows.Forms.Keys.S)));
        	this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
        	this.saveAsToolStripMenuItem.Text = "Save &As";
        	this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.OnSaveAsToolStripMenuItemClick);
        	// 
        	// toolStripSeparator5
        	// 
        	this.toolStripSeparator5.Name = "toolStripSeparator5";
        	this.toolStripSeparator5.Size = new System.Drawing.Size(183, 6);
        	// 
        	// exitToolStripMenuItem1
        	// 
        	this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
        	this.exitToolStripMenuItem1.Size = new System.Drawing.Size(186, 22);
        	this.exitToolStripMenuItem1.Text = "E&xit";
        	this.exitToolStripMenuItem1.Click += new System.EventHandler(this.OnExitToolStripMenuItemClick);
        	// 
        	// minimizeToolStripMenuItem
        	// 
        	this.minimizeToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
        	this.minimizeToolStripMenuItem.Name = "minimizeToolStripMenuItem";
        	this.minimizeToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
        	this.minimizeToolStripMenuItem.Visible = false;
        	// 
        	// editToolStripMenuItem
        	// 
        	this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
        	        	        	this.cutToolStripMenuItem,
        	        	        	this.copyToolStripMenuItem,
        	        	        	this.pasteToolStripMenuItem});
        	this.editToolStripMenuItem.Name = "editToolStripMenuItem";
        	this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
        	this.editToolStripMenuItem.Text = "&Edit";
        	// 
        	// cutToolStripMenuItem
        	// 
        	this.cutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripMenuItem.Image")));
        	this.cutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
        	this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
        	this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
        	        	        	| System.Windows.Forms.Keys.X)));
        	this.cutToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
        	this.cutToolStripMenuItem.Text = "Cu&t IP";
        	this.cutToolStripMenuItem.Click += new System.EventHandler(this.OnCutToolStripMenuItemClick);
        	// 
        	// copyToolStripMenuItem
        	// 
        	this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
        	this.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
        	this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
        	this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
        	        	        	| System.Windows.Forms.Keys.C)));
        	this.copyToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
        	this.copyToolStripMenuItem.Text = "&Copy IP";
        	this.copyToolStripMenuItem.Click += new System.EventHandler(this.OnCopyToolStripMenuItemClick);
        	// 
        	// pasteToolStripMenuItem
        	// 
        	this.pasteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripMenuItem.Image")));
        	this.pasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
        	this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
        	this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
        	        	        	| System.Windows.Forms.Keys.V)));
        	this.pasteToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
        	this.pasteToolStripMenuItem.Text = "&Paste domain";
        	this.pasteToolStripMenuItem.Click += new System.EventHandler(this.OnPasteToolStripMenuItemClick);
        	// 
        	// optionsToolStripMenuItem
        	// 
        	this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
        	        	        	this.saveOnExitToolStripMenuItem,
        	        	        	this.domainIPFormatToolStripMenuItem});
        	this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
        	this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
        	this.optionsToolStripMenuItem.Text = "&Options";
        	this.optionsToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.OnOptionsToolStripMenuItemDropDownItemClicked);
        	// 
        	// saveOnExitToolStripMenuItem
        	// 
        	this.saveOnExitToolStripMenuItem.Checked = true;
        	this.saveOnExitToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
        	this.saveOnExitToolStripMenuItem.Name = "saveOnExitToolStripMenuItem";
        	this.saveOnExitToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
        	this.saveOnExitToolStripMenuItem.Text = "&Save on exit";
        	// 
        	// domainIPFormatToolStripMenuItem
        	// 
        	this.domainIPFormatToolStripMenuItem.Name = "domainIPFormatToolStripMenuItem";
        	this.domainIPFormatToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
        	this.domainIPFormatToolStripMenuItem.Text = "Domain=IP format";
        	// 
        	// helpToolStripMenuItem
        	// 
        	this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
        	        	        	this.dailyReleasesPublicDomainDailycomToolStripMenuItem,
        	        	        	this.originalThreadDonationCodercomToolStripMenuItem,
        	        	        	this.sourceCodeGithubcomToolStripMenuItem,
        	        	        	this.toolStripSeparator2,
        	        	        	this.aboutToolStripMenuItem});
        	this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
        	this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
        	this.helpToolStripMenuItem.Text = "&Help";
        	// 
        	// dailyReleasesPublicDomainDailycomToolStripMenuItem
        	// 
        	this.dailyReleasesPublicDomainDailycomToolStripMenuItem.Name = "dailyReleasesPublicDomainDailycomToolStripMenuItem";
        	this.dailyReleasesPublicDomainDailycomToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
        	this.dailyReleasesPublicDomainDailycomToolStripMenuItem.Text = "Daily releases @ PublicDomainDaily.com";
        	this.dailyReleasesPublicDomainDailycomToolStripMenuItem.Click += new System.EventHandler(this.OnDailyReleasesPublicDomainDailycomToolStripMenuItemClick);
        	// 
        	// originalThreadDonationCodercomToolStripMenuItem
        	// 
        	this.originalThreadDonationCodercomToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("originalThreadDonationCodercomToolStripMenuItem.Image")));
        	this.originalThreadDonationCodercomToolStripMenuItem.Name = "originalThreadDonationCodercomToolStripMenuItem";
        	this.originalThreadDonationCodercomToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
        	this.originalThreadDonationCodercomToolStripMenuItem.Text = "&Original thread @ DonationCoder.com";
        	this.originalThreadDonationCodercomToolStripMenuItem.Click += new System.EventHandler(this.OnOriginalThreadDonationCodercomToolStripMenuItemClick);
        	// 
        	// sourceCodeGithubcomToolStripMenuItem
        	// 
        	this.sourceCodeGithubcomToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sourceCodeGithubcomToolStripMenuItem.Image")));
        	this.sourceCodeGithubcomToolStripMenuItem.Name = "sourceCodeGithubcomToolStripMenuItem";
        	this.sourceCodeGithubcomToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
        	this.sourceCodeGithubcomToolStripMenuItem.Text = "Source code @ Github.com";
        	this.sourceCodeGithubcomToolStripMenuItem.Click += new System.EventHandler(this.OnSourceCodeGithubcomToolStripMenuItemClick);
        	// 
        	// toolStripSeparator2
        	// 
        	this.toolStripSeparator2.Name = "toolStripSeparator2";
        	this.toolStripSeparator2.Size = new System.Drawing.Size(286, 6);
        	// 
        	// aboutToolStripMenuItem
        	// 
        	this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
        	this.aboutToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
        	this.aboutToolStripMenuItem.Text = "&About...";
        	this.aboutToolStripMenuItem.Click += new System.EventHandler(this.OnAboutToolStripMenuItemClick);
        	// 
        	// mainStatusStrip
        	// 
        	this.mainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
        	        	        	this.mainToolStripStatusLabel,
        	        	        	this.secondaryUnitToolStripStatusLabel});
        	this.mainStatusStrip.Location = new System.Drawing.Point(0, 194);
        	this.mainStatusStrip.Name = "mainStatusStrip";
        	this.mainStatusStrip.Size = new System.Drawing.Size(252, 22);
        	this.mainStatusStrip.SizingGrip = false;
        	this.mainStatusStrip.TabIndex = 20;
        	// 
        	// mainToolStripStatusLabel
        	// 
        	this.mainToolStripStatusLabel.Name = "mainToolStripStatusLabel";
        	this.mainToolStripStatusLabel.Size = new System.Drawing.Size(130, 17);
        	this.mainToolStripStatusLabel.Text = "Separate domains with:";
        	// 
        	// secondaryUnitToolStripStatusLabel
        	// 
        	this.secondaryUnitToolStripStatusLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.secondaryUnitToolStripStatusLabel.Name = "secondaryUnitToolStripStatusLabel";
        	this.secondaryUnitToolStripStatusLabel.Size = new System.Drawing.Size(54, 17);
        	this.secondaryUnitToolStripStatusLabel.Text = "Commas";
        	// 
        	// mainTableLayoutPanel
        	// 
        	this.mainTableLayoutPanel.ColumnCount = 2;
        	this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
        	this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
        	this.mainTableLayoutPanel.Controls.Add(this.startStopButton, 0, 2);
        	this.mainTableLayoutPanel.Controls.Add(this.label1, 0, 0);
        	this.mainTableLayoutPanel.Controls.Add(this.label2, 1, 0);
        	this.mainTableLayoutPanel.Controls.Add(this.domainTextBox, 0, 1);
        	this.mainTableLayoutPanel.Controls.Add(this.intervalNumericUpDown, 1, 1);
        	this.mainTableLayoutPanel.Controls.Add(this.ipAddressLabel, 0, 3);
        	this.mainTableLayoutPanel.Controls.Add(this.copyLabel, 1, 3);
        	this.mainTableLayoutPanel.Controls.Add(this.copyCheckBox, 1, 4);
        	this.mainTableLayoutPanel.Controls.Add(this.ipAddressTextBox, 0, 4);
        	this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.mainTableLayoutPanel.Location = new System.Drawing.Point(0, 24);
        	this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
        	this.mainTableLayoutPanel.RowCount = 5;
        	this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
        	this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
        	this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        	this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
        	this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
        	this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
        	this.mainTableLayoutPanel.Size = new System.Drawing.Size(252, 170);
        	this.mainTableLayoutPanel.TabIndex = 22;
        	// 
        	// startStopButton
        	// 
        	this.mainTableLayoutPanel.SetColumnSpan(this.startStopButton, 2);
        	this.startStopButton.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.startStopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.startStopButton.ForeColor = System.Drawing.Color.Green;
        	this.startStopButton.Location = new System.Drawing.Point(3, 62);
        	this.startStopButton.Name = "startStopButton";
        	this.startStopButton.Size = new System.Drawing.Size(246, 46);
        	this.startStopButton.TabIndex = 2;
        	this.startStopButton.Text = "&Start";
        	this.startStopButton.UseVisualStyleBackColor = true;
        	this.startStopButton.Click += new System.EventHandler(this.OnStartStopButtonClick);
        	// 
        	// label1
        	// 
        	this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label1.Location = new System.Drawing.Point(3, 0);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(186, 25);
        	this.label1.TabIndex = 1;
        	this.label1.Text = "Domain(s):";
        	this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        	// 
        	// label2
        	// 
        	this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label2.Location = new System.Drawing.Point(195, 0);
        	this.label2.Name = "label2";
        	this.label2.Size = new System.Drawing.Size(54, 25);
        	this.label2.TabIndex = 2;
        	this.label2.Text = "Interval:";
        	this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        	// 
        	// domainTextBox
        	// 
        	this.domainTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.domainTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.domainTextBox.Location = new System.Drawing.Point(3, 28);
        	this.domainTextBox.Name = "domainTextBox";
        	this.domainTextBox.Size = new System.Drawing.Size(186, 22);
        	this.domainTextBox.TabIndex = 0;
        	// 
        	// intervalNumericUpDown
        	// 
        	this.intervalNumericUpDown.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.intervalNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.intervalNumericUpDown.Location = new System.Drawing.Point(195, 28);
        	this.intervalNumericUpDown.Maximum = new decimal(new int[] {
        	        	        	1440,
        	        	        	0,
        	        	        	0,
        	        	        	0});
        	this.intervalNumericUpDown.Minimum = new decimal(new int[] {
        	        	        	1,
        	        	        	0,
        	        	        	0,
        	        	        	0});
        	this.intervalNumericUpDown.Name = "intervalNumericUpDown";
        	this.intervalNumericUpDown.Size = new System.Drawing.Size(54, 22);
        	this.intervalNumericUpDown.TabIndex = 1;
        	this.intervalNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        	this.intervalNumericUpDown.Value = new decimal(new int[] {
        	        	        	30,
        	        	        	0,
        	        	        	0,
        	        	        	0});
        	// 
        	// ipAddressLabel
        	// 
        	this.ipAddressLabel.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.ipAddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
        	this.ipAddressLabel.Location = new System.Drawing.Point(3, 111);
        	this.ipAddressLabel.Name = "ipAddressLabel";
        	this.ipAddressLabel.Size = new System.Drawing.Size(186, 25);
        	this.ipAddressLabel.TabIndex = 3;
        	this.ipAddressLabel.Text = "IP address(es):";
        	this.ipAddressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        	// 
        	// copyLabel
        	// 
        	this.copyLabel.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.copyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
        	this.copyLabel.Location = new System.Drawing.Point(195, 111);
        	this.copyLabel.Name = "copyLabel";
        	this.copyLabel.Size = new System.Drawing.Size(54, 25);
        	this.copyLabel.TabIndex = 4;
        	this.copyLabel.Text = "&Copy";
        	this.copyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        	// 
        	// copyCheckBox
        	// 
        	this.copyCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
        	this.copyCheckBox.Checked = true;
        	this.copyCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
        	this.copyCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.copyCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
        	this.copyCheckBox.Location = new System.Drawing.Point(195, 139);
        	this.copyCheckBox.Name = "copyCheckBox";
        	this.copyCheckBox.Size = new System.Drawing.Size(54, 28);
        	this.copyCheckBox.TabIndex = 4;
        	this.copyCheckBox.Text = "&Auto";
        	this.copyCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        	this.copyCheckBox.UseVisualStyleBackColor = true;
        	this.copyCheckBox.CheckedChanged += new System.EventHandler(this.OnCopyCheckBoxCheckedChanged);
        	// 
        	// ipAddressTextBox
        	// 
        	this.ipAddressTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.ipAddressTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
        	this.ipAddressTextBox.Location = new System.Drawing.Point(3, 139);
        	this.ipAddressTextBox.Name = "ipAddressTextBox";
        	this.ipAddressTextBox.Size = new System.Drawing.Size(186, 22);
        	this.ipAddressTextBox.TabIndex = 3;
        	// 
        	// openFileDialog
        	// 
        	this.openFileDialog.DefaultExt = "txt";
        	this.openFileDialog.Filter = "TXT Files (*.txt)|*.txt|All files (*.*)|*.*";
        	this.openFileDialog.Title = "Open Dynamic IP Monitor settings";
        	// 
        	// saveFileDialog
        	// 
        	this.saveFileDialog.DefaultExt = "txt";
        	this.saveFileDialog.Filter = "TXT Files (*.txt)|*.txt|All files (*.*)|*.*";
        	this.saveFileDialog.Title = "Save Dynamic IP Monitor settings";
        	// 
        	// MainForm
        	// 
        	this.AcceptButton = this.startStopButton;
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(252, 216);
        	this.Controls.Add(this.mainTableLayoutPanel);
        	this.Controls.Add(this.mainMenuStrip);
        	this.Controls.Add(this.mainStatusStrip);
        	this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        	this.MaximizeBox = false;
        	this.Name = "MainForm";
        	this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        	this.Text = "Dynamic IP Monitor";
        	this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnMainFormFormClosing);
        	this.mainMenuStrip.ResumeLayout(false);
        	this.mainMenuStrip.PerformLayout();
        	this.mainStatusStrip.ResumeLayout(false);
        	this.mainStatusStrip.PerformLayout();
        	this.mainTableLayoutPanel.ResumeLayout(false);
        	this.mainTableLayoutPanel.PerformLayout();
        	((System.ComponentModel.ISupportInitialize)(this.intervalNumericUpDown)).EndInit();
        	this.ResumeLayout(false);
        	this.PerformLayout();
        }
        private System.Windows.Forms.ToolStripMenuItem domainIPFormatToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveOnExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.TextBox ipAddressTextBox;
        private System.Windows.Forms.CheckBox copyCheckBox;
        private System.Windows.Forms.Label copyLabel;
        private System.Windows.Forms.Label ipAddressLabel;
        private System.Windows.Forms.NumericUpDown intervalNumericUpDown;
        private System.Windows.Forms.TextBox domainTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button startStopButton;
        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.ToolStripStatusLabel secondaryUnitToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel mainToolStripStatusLabel;
        private System.Windows.Forms.StatusStrip mainStatusStrip;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem sourceCodeGithubcomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem originalThreadDonationCodercomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dailyReleasesPublicDomainDailycomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minimizeToolStripMenuItem;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
    }
}


using System;
using System.Windows.Forms;

namespace FifthsTrajectoryVisualizer
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cacheUpdateProgress = new System.Windows.Forms.ProgressBar();
            this.exportTab = new System.Windows.Forms.TabControl();
            this.filesTabPage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.filesListBox = new System.Windows.Forms.ListBox();
            this.trajectoryInfoBox = new System.Windows.Forms.GroupBox();
            this.trajectoryInfoLabel = new System.Windows.Forms.Label();
            this.fileOpenButton = new System.Windows.Forms.Button();
            this.precisionLabel = new System.Windows.Forms.Label();
            this.modeLabel = new System.Windows.Forms.Label();
            this.modeComboBox = new System.Windows.Forms.ComboBox();
            this.precisionComboBox = new System.Windows.Forms.ComboBox();
            this.settingsTabPage = new System.Windows.Forms.TabPage();
            this.currentCMPS = new System.Windows.Forms.NumericUpDown();
            this.showIndividualSignaturesCheckBox = new System.Windows.Forms.CheckBox();
            this.axisLimitsLabel = new System.Windows.Forms.Label();
            this.gridSizeLabel = new System.Windows.Forms.Label();
            this.axisLimitsTrackBar = new System.Windows.Forms.TrackBar();
            this.gridSizeTrackBar = new System.Windows.Forms.TrackBar();
            this.fileExportTabPage = new System.Windows.Forms.TabPage();
            this.saveExportButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.exportFileFormatComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.exportFileLocationTextBox = new System.Windows.Forms.TextBox();
            this.selectExportFolderButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.exportFileNameTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.selectedFilesRadioButton = new System.Windows.Forms.RadioButton();
            this.allFilesRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.exporetedPrecisionsCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.modesGroupBox = new System.Windows.Forms.GroupBox();
            this.exportedModesCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.backBoardPanel = new System.Windows.Forms.Panel();
            this.testLetters = new FifthsTrajectoryVisualizer.TransparentPanel();
            this.circleDisplayPanel = new System.Windows.Forms.Panel();
            this.trajectoryCacheWorker = new System.ComponentModel.BackgroundWorker();
            this.tableLayoutPanel1.SuspendLayout();
            this.exportTab.SuspendLayout();
            this.filesTabPage.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.trajectoryInfoBox.SuspendLayout();
            this.settingsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentCMPS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axisLimitsTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSizeTrackBar)).BeginInit();
            this.fileExportTabPage.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.modesGroupBox.SuspendLayout();
            this.backBoardPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 450F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.cacheUpdateProgress, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.exportTab, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.backBoardPanel, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1008, 530);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // cacheUpdateProgress
            // 
            this.cacheUpdateProgress.ForeColor = System.Drawing.Color.Turquoise;
            this.cacheUpdateProgress.Location = new System.Drawing.Point(3, 503);
            this.cacheUpdateProgress.Name = "cacheUpdateProgress";
            this.cacheUpdateProgress.Size = new System.Drawing.Size(440, 24);
            this.cacheUpdateProgress.TabIndex = 3;
            // 
            // exportTab
            // 
            this.exportTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exportTab.Controls.Add(this.filesTabPage);
            this.exportTab.Controls.Add(this.settingsTabPage);
            this.exportTab.Controls.Add(this.fileExportTabPage);
            this.exportTab.Location = new System.Drawing.Point(3, 3);
            this.exportTab.Name = "exportTab";
            this.exportTab.SelectedIndex = 0;
            this.exportTab.Size = new System.Drawing.Size(444, 494);
            this.exportTab.TabIndex = 2;
            // 
            // filesTabPage
            // 
            this.filesTabPage.Controls.Add(this.tableLayoutPanel2);
            this.filesTabPage.Controls.Add(this.fileOpenButton);
            this.filesTabPage.Controls.Add(this.precisionLabel);
            this.filesTabPage.Controls.Add(this.modeLabel);
            this.filesTabPage.Controls.Add(this.modeComboBox);
            this.filesTabPage.Controls.Add(this.precisionComboBox);
            this.filesTabPage.Location = new System.Drawing.Point(4, 24);
            this.filesTabPage.Name = "filesTabPage";
            this.filesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.filesTabPage.Size = new System.Drawing.Size(436, 466);
            this.filesTabPage.TabIndex = 0;
            this.filesTabPage.Text = "Files";
            this.filesTabPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.filesListBox, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.trajectoryInfoBox, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 51);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 59.81941F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.18059F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(424, 409);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // filesListBox
            // 
            this.filesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filesListBox.FormattingEnabled = true;
            this.filesListBox.ItemHeight = 15;
            this.filesListBox.Location = new System.Drawing.Point(3, 3);
            this.filesListBox.Name = "filesListBox";
            this.filesListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.filesListBox.Size = new System.Drawing.Size(418, 229);
            this.filesListBox.TabIndex = 0;
            this.filesListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.PlayMidiFile);
            // 
            // trajectoryInfoBox
            // 
            this.trajectoryInfoBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trajectoryInfoBox.Controls.Add(this.trajectoryInfoLabel);
            this.trajectoryInfoBox.Location = new System.Drawing.Point(3, 247);
            this.trajectoryInfoBox.Name = "trajectoryInfoBox";
            this.trajectoryInfoBox.Size = new System.Drawing.Size(418, 159);
            this.trajectoryInfoBox.TabIndex = 1;
            this.trajectoryInfoBox.TabStop = false;
            this.trajectoryInfoBox.Text = "Info";
            // 
            // trajectoryInfoLabel
            // 
            this.trajectoryInfoLabel.AutoSize = true;
            this.trajectoryInfoLabel.Location = new System.Drawing.Point(7, 23);
            this.trajectoryInfoLabel.Name = "trajectoryInfoLabel";
            this.trajectoryInfoLabel.Size = new System.Drawing.Size(0, 15);
            this.trajectoryInfoLabel.TabIndex = 0;
            // 
            // fileOpenButton
            // 
            this.fileOpenButton.Location = new System.Drawing.Point(9, 22);
            this.fileOpenButton.Name = "fileOpenButton";
            this.fileOpenButton.Size = new System.Drawing.Size(120, 23);
            this.fileOpenButton.TabIndex = 2;
            this.fileOpenButton.Text = "Import files...";
            this.fileOpenButton.UseVisualStyleBackColor = true;
            this.fileOpenButton.Click += new System.EventHandler(this.FileOpenDialog);
            // 
            // precisionLabel
            // 
            this.precisionLabel.AutoSize = true;
            this.precisionLabel.Location = new System.Drawing.Point(305, 9);
            this.precisionLabel.Name = "precisionLabel";
            this.precisionLabel.Size = new System.Drawing.Size(55, 15);
            this.precisionLabel.TabIndex = 4;
            this.precisionLabel.Text = "Precision";
            // 
            // modeLabel
            // 
            this.modeLabel.AutoSize = true;
            this.modeLabel.Location = new System.Drawing.Point(150, 9);
            this.modeLabel.Name = "modeLabel";
            this.modeLabel.Size = new System.Drawing.Size(84, 15);
            this.modeLabel.TabIndex = 3;
            this.modeLabel.Text = "Analysis mode";
            // 
            // modeComboBox
            // 
            this.modeComboBox.FormattingEnabled = true;
            this.modeComboBox.Location = new System.Drawing.Point(150, 22);
            this.modeComboBox.Name = "modeComboBox";
            this.modeComboBox.Size = new System.Drawing.Size(134, 23);
            this.modeComboBox.TabIndex = 2;
            // 
            // precisionComboBox
            // 
            this.precisionComboBox.FormattingEnabled = true;
            this.precisionComboBox.Location = new System.Drawing.Point(305, 22);
            this.precisionComboBox.Name = "precisionComboBox";
            this.precisionComboBox.Size = new System.Drawing.Size(122, 23);
            this.precisionComboBox.TabIndex = 1;
            // 
            // settingsTabPage
            // 
            this.settingsTabPage.Controls.Add(this.currentCMPS);
            this.settingsTabPage.Controls.Add(this.showIndividualSignaturesCheckBox);
            this.settingsTabPage.Controls.Add(this.axisLimitsLabel);
            this.settingsTabPage.Controls.Add(this.gridSizeLabel);
            this.settingsTabPage.Controls.Add(this.axisLimitsTrackBar);
            this.settingsTabPage.Controls.Add(this.gridSizeTrackBar);
            this.settingsTabPage.Location = new System.Drawing.Point(4, 24);
            this.settingsTabPage.Name = "settingsTabPage";
            this.settingsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.settingsTabPage.Size = new System.Drawing.Size(436, 466);
            this.settingsTabPage.TabIndex = 1;
            this.settingsTabPage.Text = "Display settings";
            this.settingsTabPage.UseVisualStyleBackColor = true;
            // 
            // currentCMPS
            // 
            this.currentCMPS.Location = new System.Drawing.Point(21, 202);
            this.currentCMPS.Name = "currentCMPS";
            this.currentCMPS.Size = new System.Drawing.Size(48, 23);
            this.currentCMPS.TabIndex = 8;
            // 
            // showIndividualSignaturesCheckBox
            // 
            this.showIndividualSignaturesCheckBox.AutoSize = true;
            this.showIndividualSignaturesCheckBox.Location = new System.Drawing.Point(21, 168);
            this.showIndividualSignaturesCheckBox.Name = "showIndividualSignaturesCheckBox";
            this.showIndividualSignaturesCheckBox.Size = new System.Drawing.Size(232, 19);
            this.showIndividualSignaturesCheckBox.TabIndex = 5;
            this.showIndividualSignaturesCheckBox.Text = "Show individual signature components";
            this.showIndividualSignaturesCheckBox.UseVisualStyleBackColor = true;
            // 
            // axisLimitsLabel
            // 
            this.axisLimitsLabel.AutoSize = true;
            this.axisLimitsLabel.Location = new System.Drawing.Point(15, 89);
            this.axisLimitsLabel.Name = "axisLimitsLabel";
            this.axisLimitsLabel.Size = new System.Drawing.Size(59, 15);
            this.axisLimitsLabel.TabIndex = 4;
            this.axisLimitsLabel.Text = "Axis limit:";
            // 
            // gridSizeLabel
            // 
            this.gridSizeLabel.AutoSize = true;
            this.gridSizeLabel.Location = new System.Drawing.Point(15, 23);
            this.gridSizeLabel.Name = "gridSizeLabel";
            this.gridSizeLabel.Size = new System.Drawing.Size(54, 15);
            this.gridSizeLabel.TabIndex = 3;
            this.gridSizeLabel.Text = "Grid size:";
            // 
            // axisLimitsTrackBar
            // 
            this.axisLimitsTrackBar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.axisLimitsTrackBar.Location = new System.Drawing.Point(15, 107);
            this.axisLimitsTrackBar.Maximum = 9;
            this.axisLimitsTrackBar.Minimum = 1;
            this.axisLimitsTrackBar.Name = "axisLimitsTrackBar";
            this.axisLimitsTrackBar.Size = new System.Drawing.Size(343, 45);
            this.axisLimitsTrackBar.TabIndex = 1;
            this.axisLimitsTrackBar.Value = 2;
            this.axisLimitsTrackBar.ValueChanged += new System.EventHandler(this.UpdateAxisLimits);
            // 
            // gridSizeTrackBar
            // 
            this.gridSizeTrackBar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gridSizeTrackBar.Location = new System.Drawing.Point(15, 41);
            this.gridSizeTrackBar.Name = "gridSizeTrackBar";
            this.gridSizeTrackBar.Size = new System.Drawing.Size(343, 45);
            this.gridSizeTrackBar.TabIndex = 0;
            this.gridSizeTrackBar.Value = 6;
            this.gridSizeTrackBar.ValueChanged += new System.EventHandler(this.UpdateGridSize);
            // 
            // fileExportTabPage
            // 
            this.fileExportTabPage.Controls.Add(this.saveExportButton);
            this.fileExportTabPage.Controls.Add(this.groupBox3);
            this.fileExportTabPage.Controls.Add(this.groupBox2);
            this.fileExportTabPage.Controls.Add(this.groupBox1);
            this.fileExportTabPage.Controls.Add(this.modesGroupBox);
            this.fileExportTabPage.Location = new System.Drawing.Point(4, 24);
            this.fileExportTabPage.Name = "fileExportTabPage";
            this.fileExportTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.fileExportTabPage.Size = new System.Drawing.Size(436, 466);
            this.fileExportTabPage.TabIndex = 2;
            this.fileExportTabPage.Text = "Export";
            this.fileExportTabPage.UseVisualStyleBackColor = true;
            // 
            // saveExportButton
            // 
            this.saveExportButton.Location = new System.Drawing.Point(331, 421);
            this.saveExportButton.Name = "saveExportButton";
            this.saveExportButton.Size = new System.Drawing.Size(99, 39);
            this.saveExportButton.TabIndex = 3;
            this.saveExportButton.Text = "Save";
            this.saveExportButton.UseVisualStyleBackColor = true;
            this.saveExportButton.Click += new System.EventHandler(this.SaveExportedTrajectory);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.exportFileFormatComboBox);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.exportFileLocationTextBox);
            this.groupBox3.Controls.Add(this.selectExportFolderButton);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.exportFileNameTextBox);
            this.groupBox3.Location = new System.Drawing.Point(6, 150);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(305, 195);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "File";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Format";
            // 
            // exportFileFormatComboBox
            // 
            this.exportFileFormatComboBox.FormattingEnabled = true;
            this.exportFileFormatComboBox.Items.AddRange(new object[] {
            "JSON"});
            this.exportFileFormatComboBox.Location = new System.Drawing.Point(9, 158);
            this.exportFileFormatComboBox.Name = "exportFileFormatComboBox";
            this.exportFileFormatComboBox.Size = new System.Drawing.Size(121, 23);
            this.exportFileFormatComboBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Location";
            // 
            // exportFileLocationTextBox
            // 
            this.exportFileLocationTextBox.Location = new System.Drawing.Point(9, 93);
            this.exportFileLocationTextBox.Name = "exportFileLocationTextBox";
            this.exportFileLocationTextBox.Size = new System.Drawing.Size(290, 23);
            this.exportFileLocationTextBox.TabIndex = 3;
            // 
            // selectExportFolderButton
            // 
            this.selectExportFolderButton.Location = new System.Drawing.Point(224, 126);
            this.selectExportFolderButton.Name = "selectExportFolderButton";
            this.selectExportFolderButton.Size = new System.Drawing.Size(75, 23);
            this.selectExportFolderButton.TabIndex = 2;
            this.selectExportFolderButton.Text = "Open";
            this.selectExportFolderButton.UseVisualStyleBackColor = true;
            this.selectExportFolderButton.Click += new System.EventHandler(this.FolderSelectDialog);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // exportFileNameTextBox
            // 
            this.exportFileNameTextBox.Location = new System.Drawing.Point(9, 40);
            this.exportFileNameTextBox.Name = "exportFileNameTextBox";
            this.exportFileNameTextBox.Size = new System.Drawing.Size(290, 23);
            this.exportFileNameTextBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.selectedFilesRadioButton);
            this.groupBox2.Controls.Add(this.allFilesRadioButton);
            this.groupBox2.Location = new System.Drawing.Point(6, 74);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(132, 70);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Trajectories";
            // 
            // selectedFilesRadioButton
            // 
            this.selectedFilesRadioButton.AutoSize = true;
            this.selectedFilesRadioButton.Location = new System.Drawing.Point(6, 43);
            this.selectedFilesRadioButton.Name = "selectedFilesRadioButton";
            this.selectedFilesRadioButton.Size = new System.Drawing.Size(69, 19);
            this.selectedFilesRadioButton.TabIndex = 1;
            this.selectedFilesRadioButton.TabStop = true;
            this.selectedFilesRadioButton.Text = "Selected";
            this.selectedFilesRadioButton.UseVisualStyleBackColor = true;
            // 
            // allFilesRadioButton
            // 
            this.allFilesRadioButton.AutoSize = true;
            this.allFilesRadioButton.Location = new System.Drawing.Point(6, 22);
            this.allFilesRadioButton.Name = "allFilesRadioButton";
            this.allFilesRadioButton.Size = new System.Drawing.Size(39, 19);
            this.allFilesRadioButton.TabIndex = 0;
            this.allFilesRadioButton.TabStop = true;
            this.allFilesRadioButton.Text = "All";
            this.allFilesRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.exporetedPrecisionsCheckedListBox);
            this.groupBox1.Location = new System.Drawing.Point(188, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(123, 138);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Precisions";
            // 
            // exporetedPrecisionsCheckedListBox
            // 
            this.exporetedPrecisionsCheckedListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.exporetedPrecisionsCheckedListBox.CheckOnClick = true;
            this.exporetedPrecisionsCheckedListBox.FormattingEnabled = true;
            this.exporetedPrecisionsCheckedListBox.Items.AddRange(new object[] {
            "Whole",
            "Half",
            "Quarter",
            "Eighth",
            "Sixteenth"});
            this.exporetedPrecisionsCheckedListBox.Location = new System.Drawing.Point(6, 22);
            this.exporetedPrecisionsCheckedListBox.Name = "exporetedPrecisionsCheckedListBox";
            this.exporetedPrecisionsCheckedListBox.Size = new System.Drawing.Size(111, 90);
            this.exporetedPrecisionsCheckedListBox.TabIndex = 0;
            // 
            // modesGroupBox
            // 
            this.modesGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.modesGroupBox.Controls.Add(this.exportedModesCheckedListBox);
            this.modesGroupBox.Location = new System.Drawing.Point(6, 6);
            this.modesGroupBox.Name = "modesGroupBox";
            this.modesGroupBox.Size = new System.Drawing.Size(132, 62);
            this.modesGroupBox.TabIndex = 0;
            this.modesGroupBox.TabStop = false;
            this.modesGroupBox.Text = "Modes";
            // 
            // exportedModesCheckedListBox
            // 
            this.exportedModesCheckedListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.exportedModesCheckedListBox.CheckOnClick = true;
            this.exportedModesCheckedListBox.FormattingEnabled = true;
            this.exportedModesCheckedListBox.Items.AddRange(new object[] {
            "Length",
            "Count"});
            this.exportedModesCheckedListBox.Location = new System.Drawing.Point(6, 22);
            this.exportedModesCheckedListBox.Name = "exportedModesCheckedListBox";
            this.exportedModesCheckedListBox.Size = new System.Drawing.Size(91, 36);
            this.exportedModesCheckedListBox.TabIndex = 0;
            // 
            // backBoardPanel
            // 
            this.backBoardPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.backBoardPanel.BackColor = System.Drawing.Color.White;
            this.backBoardPanel.Controls.Add(this.testLetters);
            this.backBoardPanel.Controls.Add(this.circleDisplayPanel);
            this.backBoardPanel.Location = new System.Drawing.Point(453, 3);
            this.backBoardPanel.Name = "backBoardPanel";
            this.backBoardPanel.Size = new System.Drawing.Size(552, 494);
            this.backBoardPanel.TabIndex = 0;
            // 
            // testLetters
            // 
            this.testLetters.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.testLetters.BackColor = System.Drawing.Color.Transparent;
            this.testLetters.Location = new System.Drawing.Point(3, 3);
            this.testLetters.Name = "testLetters";
            this.testLetters.Size = new System.Drawing.Size(546, 487);
            this.testLetters.TabIndex = 0;
            // 
            // circleDisplayPanel
            // 
            this.circleDisplayPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.circleDisplayPanel.Location = new System.Drawing.Point(24, 24);
            this.circleDisplayPanel.Margin = new System.Windows.Forms.Padding(0);
            this.circleDisplayPanel.Name = "circleDisplayPanel";
            this.circleDisplayPanel.Size = new System.Drawing.Size(505, 443);
            this.circleDisplayPanel.TabIndex = 0;
            this.circleDisplayPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.PaintPreview);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 551);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainWindow";
            this.Text = "Trajectory of fifths";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.exportTab.ResumeLayout(false);
            this.filesTabPage.ResumeLayout(false);
            this.filesTabPage.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.trajectoryInfoBox.ResumeLayout(false);
            this.trajectoryInfoBox.PerformLayout();
            this.settingsTabPage.ResumeLayout(false);
            this.settingsTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentCMPS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axisLimitsTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSizeTrackBar)).EndInit();
            this.fileExportTabPage.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.modesGroupBox.ResumeLayout(false);
            this.backBoardPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel backBoardPanel;
        private System.Windows.Forms.Panel circleDisplayPanel;
        private System.Windows.Forms.TabControl exportTab;
        private System.Windows.Forms.TabPage filesTabPage;
        private System.Windows.Forms.TabPage settingsTabPage;
        private System.Windows.Forms.ListBox filesListBox;
        private System.Windows.Forms.ComboBox modeComboBox;
        private System.Windows.Forms.ComboBox precisionComboBox;
        private System.Windows.Forms.Label precisionLabel;
        private System.Windows.Forms.Label modeLabel;
        private System.ComponentModel.BackgroundWorker trajectoryCacheWorker;
        private System.Windows.Forms.Button fileOpenButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox trajectoryInfoBox;
        private System.Windows.Forms.Label trajectoryInfoLabel;
        private System.Windows.Forms.ProgressBar cacheUpdateProgress;
        private System.Windows.Forms.TrackBar axisLimitsTrackBar;
        private System.Windows.Forms.TrackBar gridSizeTrackBar;
        private System.Windows.Forms.Label axisLimitsLabel;
        private System.Windows.Forms.Label gridSizeLabel;
        private TransparentPanel testLetters;
        private NumericUpDown currentCMPS;
        private CheckBox showIndividualSignaturesCheckBox;
        private TabPage fileExportTabPage;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private CheckedListBox exporetedPrecisionsCheckedListBox;
        private GroupBox modesGroupBox;
        private CheckedListBox exportedModesCheckedListBox;
        private RadioButton selectedFilesRadioButton;
        private RadioButton allFilesRadioButton;
        private Button saveExportButton;
        private GroupBox groupBox3;
        private Label label3;
        private ComboBox exportFileFormatComboBox;
        private Label label2;
        private TextBox exportFileLocationTextBox;
        private Button selectExportFolderButton;
        private Label label1;
        private TextBox exportFileNameTextBox;
    }
}


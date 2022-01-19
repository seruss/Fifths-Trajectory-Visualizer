
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
            this.tabControl = new System.Windows.Forms.TabControl();
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
            this.backBoardPanel = new System.Windows.Forms.Panel();
            this.testLetters = new FifthsTrajectoryVisualizer.TransparentPanel();
            this.circleDisplayPanel = new System.Windows.Forms.Panel();
            this.trajectoryCacheWorker = new System.ComponentModel.BackgroundWorker();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.filesTabPage.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.trajectoryInfoBox.SuspendLayout();
            this.settingsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentCMPS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axisLimitsTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSizeTrackBar)).BeginInit();
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
            this.tableLayoutPanel1.Controls.Add(this.tabControl, 0, 0);
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
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.filesTabPage);
            this.tabControl.Controls.Add(this.settingsTabPage);
            this.tabControl.Location = new System.Drawing.Point(3, 3);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(444, 494);
            this.tabControl.TabIndex = 2;
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
            this.tabControl.ResumeLayout(false);
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
            this.backBoardPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel backBoardPanel;
        private System.Windows.Forms.Panel circleDisplayPanel;
        private System.Windows.Forms.TabControl tabControl;
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
    }
}


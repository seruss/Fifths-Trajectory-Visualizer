namespace FifthsTrajectoryVisualizer
{
    partial class DisplayTab
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.settingsDockPanel = new System.Windows.Forms.Panel();
            this.showMainAxisAndCenterCheckBox = new System.Windows.Forms.CheckBox();
            this.axisLimitsLabel = new System.Windows.Forms.Label();
            this.showTrajectoryTrackCheckBox = new System.Windows.Forms.CheckBox();
            this.showTrajectoryPointsCheckBox = new System.Windows.Forms.CheckBox();
            this.gridSizeTrackBar = new System.Windows.Forms.TrackBar();
            this.axisLimitsTrackBar = new System.Windows.Forms.TrackBar();
            this.gridSizeLabel = new System.Windows.Forms.Label();
            this.showSignatureComponentsCheckBox = new System.Windows.Forms.CheckBox();
            this.trajectoryPointsDataGrid = new System.Windows.Forms.DataGridView();
            this.settingsDockPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSizeTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axisLimitsTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trajectoryPointsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsDockPanel
            // 
            this.settingsDockPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsDockPanel.Controls.Add(this.showMainAxisAndCenterCheckBox);
            this.settingsDockPanel.Controls.Add(this.axisLimitsLabel);
            this.settingsDockPanel.Controls.Add(this.showTrajectoryTrackCheckBox);
            this.settingsDockPanel.Controls.Add(this.showTrajectoryPointsCheckBox);
            this.settingsDockPanel.Controls.Add(this.gridSizeTrackBar);
            this.settingsDockPanel.Controls.Add(this.axisLimitsTrackBar);
            this.settingsDockPanel.Controls.Add(this.gridSizeLabel);
            this.settingsDockPanel.Controls.Add(this.showSignatureComponentsCheckBox);
            this.settingsDockPanel.Location = new System.Drawing.Point(224, 3);
            this.settingsDockPanel.Name = "settingsDockPanel";
            this.settingsDockPanel.Size = new System.Drawing.Size(203, 454);
            this.settingsDockPanel.TabIndex = 14;
            // 
            // showMainAxisAndCenterCheckBox
            // 
            this.showMainAxisAndCenterCheckBox.AutoSize = true;
            this.showMainAxisAndCenterCheckBox.Location = new System.Drawing.Point(3, 210);
            this.showMainAxisAndCenterCheckBox.Name = "showMainAxisAndCenterCheckBox";
            this.showMainAxisAndCenterCheckBox.Size = new System.Drawing.Size(167, 19);
            this.showMainAxisAndCenterCheckBox.TabIndex = 12;
            this.showMainAxisAndCenterCheckBox.Text = "Show main axis and center";
            this.showMainAxisAndCenterCheckBox.UseVisualStyleBackColor = true;
            // 
            // axisLimitsLabel
            // 
            this.axisLimitsLabel.AutoSize = true;
            this.axisLimitsLabel.Location = new System.Drawing.Point(3, 0);
            this.axisLimitsLabel.Name = "axisLimitsLabel";
            this.axisLimitsLabel.Size = new System.Drawing.Size(59, 15);
            this.axisLimitsLabel.TabIndex = 4;
            this.axisLimitsLabel.Text = "Axis limit:";
            // 
            // showTrajectoryTrackCheckBox
            // 
            this.showTrajectoryTrackCheckBox.AutoSize = true;
            this.showTrajectoryTrackCheckBox.Location = new System.Drawing.Point(4, 185);
            this.showTrajectoryTrackCheckBox.Name = "showTrajectoryTrackCheckBox";
            this.showTrajectoryTrackCheckBox.Size = new System.Drawing.Size(137, 19);
            this.showTrajectoryTrackCheckBox.TabIndex = 10;
            this.showTrajectoryTrackCheckBox.Text = "Show trajectory track";
            this.showTrajectoryTrackCheckBox.UseVisualStyleBackColor = true;
            // 
            // showTrajectoryPointsCheckBox
            // 
            this.showTrajectoryPointsCheckBox.AutoSize = true;
            this.showTrajectoryPointsCheckBox.Location = new System.Drawing.Point(4, 160);
            this.showTrajectoryPointsCheckBox.Name = "showTrajectoryPointsCheckBox";
            this.showTrajectoryPointsCheckBox.Size = new System.Drawing.Size(144, 19);
            this.showTrajectoryPointsCheckBox.TabIndex = 11;
            this.showTrajectoryPointsCheckBox.Text = "Show trajectory points";
            this.showTrajectoryPointsCheckBox.UseVisualStyleBackColor = true;
            // 
            // gridSizeTrackBar
            // 
            this.gridSizeTrackBar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gridSizeTrackBar.Location = new System.Drawing.Point(3, 84);
            this.gridSizeTrackBar.Name = "gridSizeTrackBar";
            this.gridSizeTrackBar.Size = new System.Drawing.Size(193, 45);
            this.gridSizeTrackBar.TabIndex = 0;
            this.gridSizeTrackBar.Value = 6;
            this.gridSizeTrackBar.Minimum = 1;
            // 
            // axisLimitsTrackBar
            // 
            this.axisLimitsTrackBar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.axisLimitsTrackBar.Location = new System.Drawing.Point(0, 18);
            this.axisLimitsTrackBar.Maximum = 9;
            this.axisLimitsTrackBar.Minimum = 2;
            this.axisLimitsTrackBar.Name = "axisLimitsTrackBar";
            this.axisLimitsTrackBar.Size = new System.Drawing.Size(196, 45);
            this.axisLimitsTrackBar.TabIndex = 1;
            this.axisLimitsTrackBar.Value = 2;
            // 
            // gridSizeLabel
            // 
            this.gridSizeLabel.AutoSize = true;
            this.gridSizeLabel.Location = new System.Drawing.Point(3, 66);
            this.gridSizeLabel.Name = "gridSizeLabel";
            this.gridSizeLabel.Size = new System.Drawing.Size(54, 15);
            this.gridSizeLabel.TabIndex = 3;
            this.gridSizeLabel.Text = "Grid size:";
            // 
            // showSignatureComponentsCheckBox
            // 
            this.showSignatureComponentsCheckBox.AutoSize = true;
            this.showSignatureComponentsCheckBox.Location = new System.Drawing.Point(4, 135);
            this.showSignatureComponentsCheckBox.Name = "showSignatureComponentsCheckBox";
            this.showSignatureComponentsCheckBox.Size = new System.Drawing.Size(177, 19);
            this.showSignatureComponentsCheckBox.TabIndex = 5;
            this.showSignatureComponentsCheckBox.Text = "Show signature components";
            this.showSignatureComponentsCheckBox.UseVisualStyleBackColor = true;
            // 
            // trajectoryPointsDataGrid
            // 
            this.trajectoryPointsDataGrid.AllowUserToAddRows = false;
            this.trajectoryPointsDataGrid.AllowUserToDeleteRows = false;
            this.trajectoryPointsDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trajectoryPointsDataGrid.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.trajectoryPointsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.trajectoryPointsDataGrid.Location = new System.Drawing.Point(3, 3);
            this.trajectoryPointsDataGrid.Name = "trajectoryPointsDataGrid";
            this.trajectoryPointsDataGrid.ReadOnly = true;
            this.trajectoryPointsDataGrid.RowTemplate.Height = 25;
            this.trajectoryPointsDataGrid.Size = new System.Drawing.Size(215, 454);
            this.trajectoryPointsDataGrid.TabIndex = 13;
            // 
            // DisplayTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.settingsDockPanel);
            this.Controls.Add(this.trajectoryPointsDataGrid);
            this.Name = "DisplayTab";
            this.Size = new System.Drawing.Size(429, 460);
            this.settingsDockPanel.ResumeLayout(false);
            this.settingsDockPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSizeTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axisLimitsTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trajectoryPointsDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel settingsDockPanel;
        private System.Windows.Forms.CheckBox showMainAxisAndCenterCheckBox;
        private System.Windows.Forms.Label axisLimitsLabel;
        private System.Windows.Forms.CheckBox showTrajectoryTrackCheckBox;
        private System.Windows.Forms.CheckBox showTrajectoryPointsCheckBox;
        private System.Windows.Forms.TrackBar gridSizeTrackBar;
        private System.Windows.Forms.TrackBar axisLimitsTrackBar;
        private System.Windows.Forms.Label gridSizeLabel;
        private System.Windows.Forms.CheckBox showSignatureComponentsCheckBox;
        private System.Windows.Forms.DataGridView trajectoryPointsDataGrid;
    }
}

namespace FifthsTrajectoryVisualizer
{
    partial class FilesTab
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
            this.fileOpenButton = new System.Windows.Forms.Button();
            this.precisionLabel = new System.Windows.Forms.Label();
            this.modeLabel = new System.Windows.Forms.Label();
            this.modeComboBox = new System.Windows.Forms.ComboBox();
            this.precisionComboBox = new System.Windows.Forms.ComboBox();
            this.filesListBox = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.trajectoryInfoBox = new System.Windows.Forms.GroupBox();
            this.trajectoryInfoLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel2.SuspendLayout();
            this.trajectoryInfoBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileOpenButton
            // 
            this.fileOpenButton.Location = new System.Drawing.Point(3, 13);
            this.fileOpenButton.Name = "fileOpenButton";
            this.fileOpenButton.Size = new System.Drawing.Size(120, 23);
            this.fileOpenButton.TabIndex = 7;
            this.fileOpenButton.Text = "Import files...";
            this.fileOpenButton.UseVisualStyleBackColor = true;
            // 
            // precisionLabel
            // 
            this.precisionLabel.AutoSize = true;
            this.precisionLabel.Location = new System.Drawing.Point(299, 0);
            this.precisionLabel.Name = "precisionLabel";
            this.precisionLabel.Size = new System.Drawing.Size(57, 15);
            this.precisionLabel.TabIndex = 10;
            this.precisionLabel.Text = "Sampling";
            // 
            // modeLabel
            // 
            this.modeLabel.AutoSize = true;
            this.modeLabel.Location = new System.Drawing.Point(144, 0);
            this.modeLabel.Name = "modeLabel";
            this.modeLabel.Size = new System.Drawing.Size(84, 15);
            this.modeLabel.TabIndex = 9;
            this.modeLabel.Text = "Analysis mode";
            // 
            // modeComboBox
            // 
            this.modeComboBox.FormattingEnabled = true;
            this.modeComboBox.Location = new System.Drawing.Point(144, 13);
            this.modeComboBox.Name = "modeComboBox";
            this.modeComboBox.Size = new System.Drawing.Size(134, 23);
            this.modeComboBox.TabIndex = 8;
            // 
            // precisionComboBox
            // 
            this.precisionComboBox.FormattingEnabled = true;
            this.precisionComboBox.Location = new System.Drawing.Point(299, 13);
            this.precisionComboBox.Name = "precisionComboBox";
            this.precisionComboBox.Size = new System.Drawing.Size(122, 23);
            this.precisionComboBox.TabIndex = 6;
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 42);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 59.81941F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.18059F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(424, 409);
            this.tableLayoutPanel2.TabIndex = 11;
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
            // FilesTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.fileOpenButton);
            this.Controls.Add(this.precisionLabel);
            this.Controls.Add(this.modeLabel);
            this.Controls.Add(this.modeComboBox);
            this.Controls.Add(this.precisionComboBox);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "FilesTab";
            this.Size = new System.Drawing.Size(426, 453);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.trajectoryInfoBox.ResumeLayout(false);
            this.trajectoryInfoBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button fileOpenButton;
        private System.Windows.Forms.Label precisionLabel;
        private System.Windows.Forms.Label modeLabel;
        private System.Windows.Forms.ComboBox modeComboBox;
        private System.Windows.Forms.ComboBox precisionComboBox;
        private System.Windows.Forms.ListBox filesListBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox trajectoryInfoBox;
        private System.Windows.Forms.Label trajectoryInfoLabel;
    }
}

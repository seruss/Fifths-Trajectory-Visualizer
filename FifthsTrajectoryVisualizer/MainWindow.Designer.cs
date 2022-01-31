
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
            this.settingsTabPage = new System.Windows.Forms.TabPage();
            this.fileExportTabPage = new System.Windows.Forms.TabPage();
            this.exportTabComponent = new FifthsTrajectoryVisualizer.ExportTab();
            this.backBoardPanel = new System.Windows.Forms.Panel();
            this.circleKeyLabels = new FifthsTrajectoryVisualizer.TransparentPanel();
            this.circleDisplayPanel = new System.Windows.Forms.Panel();
            this.trajectoryCacheWorker = new System.ComponentModel.BackgroundWorker();
            this.filesTabControl = new FifthsTrajectoryVisualizer.FilesTab();
            this.displayTabControl = new FifthsTrajectoryVisualizer.DisplayTab();
            this.tableLayoutPanel1.SuspendLayout();
            this.exportTab.SuspendLayout();
            this.filesTabPage.SuspendLayout();
            this.settingsTabPage.SuspendLayout();
            this.fileExportTabPage.SuspendLayout();
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
            this.filesTabPage.Controls.Add(this.filesTabControl);
            this.filesTabPage.Location = new System.Drawing.Point(4, 24);
            this.filesTabPage.Name = "filesTabPage";
            this.filesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.filesTabPage.Size = new System.Drawing.Size(436, 466);
            this.filesTabPage.TabIndex = 0;
            this.filesTabPage.Text = "Files";
            this.filesTabPage.UseVisualStyleBackColor = true;
            // 
            // settingsTabPage
            // 
            this.settingsTabPage.Controls.Add(this.displayTabControl);
            this.settingsTabPage.Location = new System.Drawing.Point(4, 24);
            this.settingsTabPage.Name = "settingsTabPage";
            this.settingsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.settingsTabPage.Size = new System.Drawing.Size(436, 466);
            this.settingsTabPage.TabIndex = 1;
            this.settingsTabPage.Text = "Display";
            this.settingsTabPage.UseVisualStyleBackColor = true;
            // 
            // fileExportTabPage
            // 
            this.fileExportTabPage.Controls.Add(this.exportTabComponent);
            this.fileExportTabPage.Location = new System.Drawing.Point(4, 24);
            this.fileExportTabPage.Name = "fileExportTabPage";
            this.fileExportTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.fileExportTabPage.Size = new System.Drawing.Size(436, 466);
            this.fileExportTabPage.TabIndex = 2;
            this.fileExportTabPage.Text = "Export";
            this.fileExportTabPage.UseVisualStyleBackColor = true;
            // 
            // exportTabComponent
            // 
            this.exportTabComponent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exportTabComponent.BackColor = System.Drawing.SystemColors.Window;
            this.exportTabComponent.Location = new System.Drawing.Point(6, 6);
            this.exportTabComponent.Name = "exportTabComponent";
            this.exportTabComponent.Size = new System.Drawing.Size(427, 528);
            this.exportTabComponent.TabIndex = 0;
            // 
            // backBoardPanel
            // 
            this.backBoardPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.backBoardPanel.BackColor = System.Drawing.Color.White;
            this.backBoardPanel.Controls.Add(this.circleKeyLabels);
            this.backBoardPanel.Controls.Add(this.circleDisplayPanel);
            this.backBoardPanel.Location = new System.Drawing.Point(453, 3);
            this.backBoardPanel.Name = "backBoardPanel";
            this.backBoardPanel.Size = new System.Drawing.Size(552, 494);
            this.backBoardPanel.TabIndex = 0;
            // 
            // circleKeyLabels
            // 
            this.circleKeyLabels.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.circleKeyLabels.BackColor = System.Drawing.Color.Transparent;
            this.circleKeyLabels.Location = new System.Drawing.Point(3, 3);
            this.circleKeyLabels.Name = "circleKeyLabels";
            this.circleKeyLabels.Size = new System.Drawing.Size(546, 487);
            this.circleKeyLabels.TabIndex = 0;
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
            // filesTabControl
            // 
            this.filesTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filesTabControl.BackColor = System.Drawing.SystemColors.Window;
            this.filesTabControl.Location = new System.Drawing.Point(4, 7);
            this.filesTabControl.Name = "filesTabControl";
            this.filesTabControl.Size = new System.Drawing.Size(426, 453);
            this.filesTabControl.TabIndex = 0;
            // 
            // displayTabControl
            // 
            this.displayTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.displayTabControl.BackColor = System.Drawing.SystemColors.Window;
            this.displayTabControl.Location = new System.Drawing.Point(4, 3);
            this.displayTabControl.Name = "displayTabControl";
            this.displayTabControl.Size = new System.Drawing.Size(429, 460);
            this.displayTabControl.TabIndex = 0;
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
            this.settingsTabPage.ResumeLayout(false);
            this.fileExportTabPage.ResumeLayout(false);
            this.backBoardPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel backBoardPanel;
        private System.Windows.Forms.Panel circleDisplayPanel;
        private System.Windows.Forms.TabControl exportTab;
        private System.Windows.Forms.TabPage settingsTabPage;
        private System.ComponentModel.BackgroundWorker trajectoryCacheWorker;
        private System.Windows.Forms.ProgressBar cacheUpdateProgress;
        private TransparentPanel circleKeyLabels;
        private TabPage fileExportTabPage;
        private ExportTab exportTabComponent;
        private TabPage filesTabPage;
        private FilesTab filesTabControl;
        private DisplayTab displayTabControl;
    }
}


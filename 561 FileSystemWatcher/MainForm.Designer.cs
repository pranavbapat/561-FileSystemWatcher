namespace _561_FileSystemWatcher
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxOptions = new System.Windows.Forms.GroupBox();
            this.buttonStartWatching = new System.Windows.Forms.Button();
            this.checkBoxRenamed = new System.Windows.Forms.CheckBox();
            this.checkBoxDeleted = new System.Windows.Forms.CheckBox();
            this.checkBoxChanged = new System.Windows.Forms.CheckBox();
            this.checkBoxSubFolder = new System.Windows.Forms.CheckBox();
            this.buttonStopWatching = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.tabControlRenamed = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listBoxAllChanges = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listBoxChanged = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.listBoxDeleted = new System.Windows.Forms.ListBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.listBoxRenamed = new System.Windows.Forms.ListBox();
            this.groupBoxOptions.SuspendLayout();
            this.tabControlRenamed.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxOptions
            // 
            this.groupBoxOptions.Controls.Add(this.buttonStartWatching);
            this.groupBoxOptions.Controls.Add(this.checkBoxRenamed);
            this.groupBoxOptions.Controls.Add(this.checkBoxDeleted);
            this.groupBoxOptions.Controls.Add(this.checkBoxChanged);
            this.groupBoxOptions.Controls.Add(this.checkBoxSubFolder);
            this.groupBoxOptions.Controls.Add(this.buttonStopWatching);
            this.groupBoxOptions.Controls.Add(this.label1);
            this.groupBoxOptions.Controls.Add(this.textBoxPath);
            this.groupBoxOptions.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxOptions.Location = new System.Drawing.Point(235, 40);
            this.groupBoxOptions.Name = "groupBoxOptions";
            this.groupBoxOptions.Size = new System.Drawing.Size(492, 146);
            this.groupBoxOptions.TabIndex = 0;
            this.groupBoxOptions.TabStop = false;
            this.groupBoxOptions.Text = "Options";
            // 
            // buttonStartWatching
            // 
            this.buttonStartWatching.BackColor = System.Drawing.Color.Green;
            this.buttonStartWatching.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStartWatching.Location = new System.Drawing.Point(325, 34);
            this.buttonStartWatching.Name = "buttonStartWatching";
            this.buttonStartWatching.Size = new System.Drawing.Size(129, 43);
            this.buttonStartWatching.TabIndex = 7;
            this.buttonStartWatching.Text = "Start Watching";
            this.buttonStartWatching.UseVisualStyleBackColor = false;
            this.buttonStartWatching.Click += new System.EventHandler(this.buttonStartWatching_Click);
            // 
            // checkBoxRenamed
            // 
            this.checkBoxRenamed.AutoSize = true;
            this.checkBoxRenamed.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxRenamed.Location = new System.Drawing.Point(155, 113);
            this.checkBoxRenamed.Name = "checkBoxRenamed";
            this.checkBoxRenamed.Size = new System.Drawing.Size(95, 25);
            this.checkBoxRenamed.TabIndex = 5;
            this.checkBoxRenamed.Text = "Renamed";
            this.checkBoxRenamed.UseVisualStyleBackColor = true;
            // 
            // checkBoxDeleted
            // 
            this.checkBoxDeleted.AutoSize = true;
            this.checkBoxDeleted.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxDeleted.Location = new System.Drawing.Point(17, 113);
            this.checkBoxDeleted.Name = "checkBoxDeleted";
            this.checkBoxDeleted.Size = new System.Drawing.Size(82, 25);
            this.checkBoxDeleted.TabIndex = 6;
            this.checkBoxDeleted.Text = "Deleted";
            this.checkBoxDeleted.UseVisualStyleBackColor = true;
            // 
            // checkBoxChanged
            // 
            this.checkBoxChanged.AutoSize = true;
            this.checkBoxChanged.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxChanged.Location = new System.Drawing.Point(155, 87);
            this.checkBoxChanged.Name = "checkBoxChanged";
            this.checkBoxChanged.Size = new System.Drawing.Size(91, 25);
            this.checkBoxChanged.TabIndex = 5;
            this.checkBoxChanged.Text = "Changed";
            this.checkBoxChanged.UseVisualStyleBackColor = true;
            // 
            // checkBoxSubFolder
            // 
            this.checkBoxSubFolder.AutoSize = true;
            this.checkBoxSubFolder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxSubFolder.Location = new System.Drawing.Point(17, 87);
            this.checkBoxSubFolder.Name = "checkBoxSubFolder";
            this.checkBoxSubFolder.Size = new System.Drawing.Size(113, 25);
            this.checkBoxSubFolder.TabIndex = 4;
            this.checkBoxSubFolder.Text = "Deep Watch";
            this.checkBoxSubFolder.UseVisualStyleBackColor = true;
            this.checkBoxSubFolder.CheckedChanged += new System.EventHandler(this.checkBoxSubFolder_CheckedChanged);
            // 
            // buttonStopWatching
            // 
            this.buttonStopWatching.BackColor = System.Drawing.Color.Red;
            this.buttonStopWatching.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStopWatching.Location = new System.Drawing.Point(325, 87);
            this.buttonStopWatching.Name = "buttonStopWatching";
            this.buttonStopWatching.Size = new System.Drawing.Size(129, 43);
            this.buttonStopWatching.TabIndex = 3;
            this.buttonStopWatching.Text = "Stop Watching";
            this.buttonStopWatching.UseVisualStyleBackColor = false;
            this.buttonStopWatching.Click += new System.EventHandler(this.buttonStopWatching_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Path";
            // 
            // textBoxPath
            // 
            this.textBoxPath.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPath.Location = new System.Drawing.Point(17, 48);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(248, 29);
            this.textBoxPath.TabIndex = 0;
            // 
            // tabControlRenamed
            // 
            this.tabControlRenamed.Controls.Add(this.tabPage1);
            this.tabControlRenamed.Controls.Add(this.tabPage2);
            this.tabControlRenamed.Controls.Add(this.tabPage3);
            this.tabControlRenamed.Controls.Add(this.tabPage4);
            this.tabControlRenamed.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlRenamed.Location = new System.Drawing.Point(235, 203);
            this.tabControlRenamed.Name = "tabControlRenamed";
            this.tabControlRenamed.SelectedIndex = 0;
            this.tabControlRenamed.Size = new System.Drawing.Size(492, 252);
            this.tabControlRenamed.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listBoxAllChanges);
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(484, 218);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "All Changes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listBoxAllChanges
            // 
            this.listBoxAllChanges.FormattingEnabled = true;
            this.listBoxAllChanges.ItemHeight = 21;
            this.listBoxAllChanges.Location = new System.Drawing.Point(6, 7);
            this.listBoxAllChanges.Name = "listBoxAllChanges";
            this.listBoxAllChanges.Size = new System.Drawing.Size(472, 193);
            this.listBoxAllChanges.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listBoxChanged);
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(484, 218);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Changed";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listBoxChanged
            // 
            this.listBoxChanged.FormattingEnabled = true;
            this.listBoxChanged.ItemHeight = 21;
            this.listBoxChanged.Location = new System.Drawing.Point(6, 7);
            this.listBoxChanged.Name = "listBoxChanged";
            this.listBoxChanged.Size = new System.Drawing.Size(472, 193);
            this.listBoxChanged.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.listBoxDeleted);
            this.tabPage3.Location = new System.Drawing.Point(4, 30);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(484, 218);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Deleted";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // listBoxDeleted
            // 
            this.listBoxDeleted.FormattingEnabled = true;
            this.listBoxDeleted.ItemHeight = 21;
            this.listBoxDeleted.Location = new System.Drawing.Point(6, 7);
            this.listBoxDeleted.Name = "listBoxDeleted";
            this.listBoxDeleted.Size = new System.Drawing.Size(472, 193);
            this.listBoxDeleted.TabIndex = 1;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.listBoxRenamed);
            this.tabPage4.Location = new System.Drawing.Point(4, 30);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(484, 218);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Renamed";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // listBoxRenamed
            // 
            this.listBoxRenamed.FormattingEnabled = true;
            this.listBoxRenamed.ItemHeight = 21;
            this.listBoxRenamed.Location = new System.Drawing.Point(6, 7);
            this.listBoxRenamed.Name = "listBoxRenamed";
            this.listBoxRenamed.Size = new System.Drawing.Size(472, 193);
            this.listBoxRenamed.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 506);
            this.Controls.Add(this.tabControlRenamed);
            this.Controls.Add(this.groupBoxOptions);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBoxOptions.ResumeLayout(false);
            this.groupBoxOptions.PerformLayout();
            this.tabControlRenamed.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxOptions;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.Button buttonStopWatching;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxRenamed;
        private System.Windows.Forms.CheckBox checkBoxDeleted;
        private System.Windows.Forms.CheckBox checkBoxChanged;
        private System.Windows.Forms.CheckBox checkBoxSubFolder;
        private System.Windows.Forms.TabControl tabControlRenamed;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button buttonStartWatching;
        private System.Windows.Forms.ListBox listBoxAllChanges;
        private System.Windows.Forms.ListBox listBoxChanged;
        private System.Windows.Forms.ListBox listBoxDeleted;
        private System.Windows.Forms.ListBox listBoxRenamed;
    }
}
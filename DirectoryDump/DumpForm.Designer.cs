namespace DirectoryDump
{
    partial class DumpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DumpForm));
            this.BrowseButton = new System.Windows.Forms.Button();
            this.DirTextBox = new System.Windows.Forms.TextBox();
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.DumpButton = new System.Windows.Forms.Button();
            this.radioText = new System.Windows.Forms.RadioButton();
            this.radioCsv = new System.Windows.Forms.RadioButton();
            this.checkOpenWhenDone = new System.Windows.Forms.CheckBox();
            this.comboOrder = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.folderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.browseToolItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.openOutputFolderToolItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabFunctions = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dateDelete = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.ckbIncludeRemoveDate = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.labelDeleteReport = new System.Windows.Forms.Label();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.labelStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabFunctions.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // BrowseButton
            // 
            this.BrowseButton.Location = new System.Drawing.Point(12, 31);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(75, 23);
            this.BrowseButton.TabIndex = 0;
            this.BrowseButton.Text = "Browse...";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // DirTextBox
            // 
            this.DirTextBox.Location = new System.Drawing.Point(12, 60);
            this.DirTextBox.Name = "DirTextBox";
            this.DirTextBox.Size = new System.Drawing.Size(367, 20);
            this.DirTextBox.TabIndex = 1;
            // 
            // DumpButton
            // 
            this.DumpButton.Location = new System.Drawing.Point(13, 144);
            this.DumpButton.Name = "DumpButton";
            this.DumpButton.Size = new System.Drawing.Size(75, 23);
            this.DumpButton.TabIndex = 2;
            this.DumpButton.Text = "Dump";
            this.DumpButton.UseVisualStyleBackColor = true;
            this.DumpButton.Click += new System.EventHandler(this.DumpButton_Click);
            // 
            // radioText
            // 
            this.radioText.AutoSize = true;
            this.radioText.Location = new System.Drawing.Point(6, 19);
            this.radioText.Name = "radioText";
            this.radioText.Size = new System.Drawing.Size(39, 17);
            this.radioText.TabIndex = 3;
            this.radioText.TabStop = true;
            this.radioText.Text = ".txt";
            this.radioText.UseVisualStyleBackColor = true;
            // 
            // radioCsv
            // 
            this.radioCsv.AutoSize = true;
            this.radioCsv.Location = new System.Drawing.Point(51, 19);
            this.radioCsv.Name = "radioCsv";
            this.radioCsv.Size = new System.Drawing.Size(45, 17);
            this.radioCsv.TabIndex = 4;
            this.radioCsv.TabStop = true;
            this.radioCsv.Text = ".csv";
            this.radioCsv.UseVisualStyleBackColor = true;
            // 
            // checkOpenWhenDone
            // 
            this.checkOpenWhenDone.AutoSize = true;
            this.checkOpenWhenDone.Location = new System.Drawing.Point(6, 18);
            this.checkOpenWhenDone.Name = "checkOpenWhenDone";
            this.checkOpenWhenDone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkOpenWhenDone.Size = new System.Drawing.Size(42, 17);
            this.checkOpenWhenDone.TabIndex = 5;
            this.checkOpenWhenDone.Text = "yes";
            this.checkOpenWhenDone.UseVisualStyleBackColor = true;
            // 
            // comboOrder
            // 
            this.comboOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboOrder.FormattingEnabled = true;
            this.comboOrder.Location = new System.Drawing.Point(8, 18);
            this.comboOrder.Name = "comboOrder";
            this.comboOrder.Size = new System.Drawing.Size(130, 21);
            this.comboOrder.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioCsv);
            this.groupBox1.Controls.Add(this.radioText);
            this.groupBox1.Location = new System.Drawing.Point(13, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(104, 45);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ouput options";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboOrder);
            this.groupBox2.Location = new System.Drawing.Point(123, 93);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(144, 45);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "order options";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkOpenWhenDone);
            this.groupBox3.Location = new System.Drawing.Point(273, 93);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(106, 45);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "open when done";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.folderToolStripMenuItem,
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(391, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // folderToolStripMenuItem
            // 
            this.folderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.browseToolItem,
            this.toolStripSeparator1,
            this.openOutputFolderToolItem});
            this.folderToolStripMenuItem.Name = "folderToolStripMenuItem";
            this.folderToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.folderToolStripMenuItem.Text = "Folder";
            // 
            // browseToolItem
            // 
            this.browseToolItem.Name = "browseToolItem";
            this.browseToolItem.Size = new System.Drawing.Size(176, 22);
            this.browseToolItem.Text = "Browse";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(173, 6);
            // 
            // openOutputFolderToolItem
            // 
            this.openOutputFolderToolItem.Name = "openOutputFolderToolItem";
            this.openOutputFolderToolItem.Size = new System.Drawing.Size(176, 22);
            this.openOutputFolderToolItem.Text = "Open output folder";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(13, 174);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(366, 1);
            this.panel1.TabIndex = 13;
            // 
            // tabFunctions
            // 
            this.tabFunctions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabFunctions.Controls.Add(this.tabPage1);
            this.tabFunctions.Location = new System.Drawing.Point(13, 182);
            this.tabFunctions.Name = "tabFunctions";
            this.tabFunctions.SelectedIndex = 0;
            this.tabFunctions.Size = new System.Drawing.Size(366, 151);
            this.tabFunctions.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.labelDeleteReport);
            this.tabPage1.Controls.Add(this.buttonDelete);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.ckbIncludeRemoveDate);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dateDelete);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(358, 125);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Delete files";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dateDelete
            // 
            this.dateDelete.CustomFormat = "MM/dd/yyyy";
            this.dateDelete.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateDelete.Location = new System.Drawing.Point(7, 26);
            this.dateDelete.Name = "dateDelete";
            this.dateDelete.Size = new System.Drawing.Size(200, 20);
            this.dateDelete.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "From date (MM/dd/yyyy)";
            // 
            // ckbIncludeRemoveDate
            // 
            this.ckbIncludeRemoveDate.AutoSize = true;
            this.ckbIncludeRemoveDate.Location = new System.Drawing.Point(213, 31);
            this.ckbIncludeRemoveDate.Name = "ckbIncludeRemoveDate";
            this.ckbIncludeRemoveDate.Size = new System.Drawing.Size(65, 17);
            this.ckbIncludeRemoveDate.TabIndex = 2;
            this.ckbIncludeRemoveDate.Text = "Include*";
            this.ckbIncludeRemoveDate.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(328, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "(*) If checked, files modified from selected day will be deleted as well";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(7, 97);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // labelDeleteReport
            // 
            this.labelDeleteReport.AutoSize = true;
            this.labelDeleteReport.Location = new System.Drawing.Point(88, 102);
            this.labelDeleteReport.Name = "labelDeleteReport";
            this.labelDeleteReport.Size = new System.Drawing.Size(0, 13);
            this.labelDeleteReport.TabIndex = 5;
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelStatus});
            this.statusBar.Location = new System.Drawing.Point(0, 336);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(391, 22);
            this.statusBar.TabIndex = 15;
            this.statusBar.Text = "statusStrip1";
            // 
            // labelStatus
            // 
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // DumpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(391, 358);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.tabFunctions);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DumpButton);
            this.Controls.Add(this.DirTextBox);
            this.Controls.Add(this.BrowseButton);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DumpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Directory Dump v.1.1 by oclockvn";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabFunctions.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.TextBox DirTextBox;
        private System.Windows.Forms.FolderBrowserDialog folderBrowser;
        private System.Windows.Forms.Button DumpButton;
        private System.Windows.Forms.RadioButton radioText;
        private System.Windows.Forms.RadioButton radioCsv;
        private System.Windows.Forms.CheckBox checkOpenWhenDone;
        private System.Windows.Forms.ComboBox comboOrder;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem folderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem browseToolItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem openOutputFolderToolItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabFunctions;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ckbIncludeRemoveDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateDelete;
        private System.Windows.Forms.Label labelDeleteReport;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel labelStatus;
    }
}


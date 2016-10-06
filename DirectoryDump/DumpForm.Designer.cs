﻿namespace DirectoryDump
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
            this.buttonOpenOutputFolder = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // BrowseButton
            // 
            this.BrowseButton.Location = new System.Drawing.Point(12, 12);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(75, 23);
            this.BrowseButton.TabIndex = 0;
            this.BrowseButton.Text = "Browse...";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // DirTextBox
            // 
            this.DirTextBox.Location = new System.Drawing.Point(12, 41);
            this.DirTextBox.Name = "DirTextBox";
            this.DirTextBox.Size = new System.Drawing.Size(367, 20);
            this.DirTextBox.TabIndex = 1;
            // 
            // DumpButton
            // 
            this.DumpButton.Location = new System.Drawing.Point(13, 125);
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
            this.groupBox1.Location = new System.Drawing.Point(13, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(104, 45);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ouput options";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboOrder);
            this.groupBox2.Location = new System.Drawing.Point(123, 74);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(144, 45);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "order options";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkOpenWhenDone);
            this.groupBox3.Location = new System.Drawing.Point(273, 74);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(106, 45);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "open when done";
            // 
            // buttonOpenOutputFolder
            // 
            this.buttonOpenOutputFolder.Location = new System.Drawing.Point(261, 125);
            this.buttonOpenOutputFolder.Name = "buttonOpenOutputFolder";
            this.buttonOpenOutputFolder.Size = new System.Drawing.Size(118, 23);
            this.buttonOpenOutputFolder.TabIndex = 11;
            this.buttonOpenOutputFolder.Text = "Open output folder";
            this.buttonOpenOutputFolder.UseVisualStyleBackColor = true;
            // 
            // DumpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(391, 156);
            this.Controls.Add(this.buttonOpenOutputFolder);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DumpButton);
            this.Controls.Add(this.DirTextBox);
            this.Controls.Add(this.BrowseButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DumpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Directory Dump v1 by tien quang";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private System.Windows.Forms.Button buttonOpenOutputFolder;
    }
}


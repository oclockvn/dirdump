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
            this.label1 = new System.Windows.Forms.Label();
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
            this.DumpButton.Location = new System.Drawing.Point(109, 71);
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
            this.radioText.Location = new System.Drawing.Point(13, 74);
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
            this.radioCsv.Location = new System.Drawing.Point(58, 74);
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
            this.checkOpenWhenDone.Location = new System.Drawing.Point(273, 74);
            this.checkOpenWhenDone.Name = "checkOpenWhenDone";
            this.checkOpenWhenDone.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkOpenWhenDone.Size = new System.Drawing.Size(106, 17);
            this.checkOpenWhenDone.TabIndex = 5;
            this.checkOpenWhenDone.Text = "open when done";
            this.checkOpenWhenDone.UseVisualStyleBackColor = true;
            // 
            // comboOrder
            // 
            this.comboOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboOrder.FormattingEnabled = true;
            this.comboOrder.Location = new System.Drawing.Point(258, 14);
            this.comboOrder.Name = "comboOrder";
            this.comboOrder.Size = new System.Drawing.Size(121, 21);
            this.comboOrder.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "order by";
            // 
            // DumpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(391, 103);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboOrder);
            this.Controls.Add(this.checkOpenWhenDone);
            this.Controls.Add(this.radioCsv);
            this.Controls.Add(this.radioText);
            this.Controls.Add(this.DumpButton);
            this.Controls.Add(this.DirTextBox);
            this.Controls.Add(this.BrowseButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DumpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Directory Dump v1 by tien quang";
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
        private System.Windows.Forms.Label label1;
    }
}


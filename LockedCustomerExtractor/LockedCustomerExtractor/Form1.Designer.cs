namespace LockedCustomerExtractor
{
    partial class Form1
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
            this.LockedCustomerFPLabel = new System.Windows.Forms.Label();
            this.SourceFPLabel = new System.Windows.Forms.Label();
            this.ResultFPLabel = new System.Windows.Forms.Label();
            this.ExtractButton = new System.Windows.Forms.Button();
            this.SourceInput = new System.Windows.Forms.TextBox();
            this.ResultPathInput = new System.Windows.Forms.TextBox();
            this.ReportFPInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ResultFilePathButton = new System.Windows.Forms.Button();
            this.SourceFilePathButton = new System.Windows.Forms.Button();
            this.ReportFilePathButton = new System.Windows.Forms.Button();
            this.ListBoxForInvalidClientNumber = new System.Windows.Forms.ListBox();
            this.LockCustInput = new System.Windows.Forms.RichTextBox();
            this.CB_ResultFile = new System.Windows.Forms.CheckBox();
            this.CB_ReportFile = new System.Windows.Forms.CheckBox();
            this.LinkToTheMainFolder = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // LockedCustomerFPLabel
            // 
            this.LockedCustomerFPLabel.AutoSize = true;
            this.LockedCustomerFPLabel.Location = new System.Drawing.Point(83, 115);
            this.LockedCustomerFPLabel.Name = "LockedCustomerFPLabel";
            this.LockedCustomerFPLabel.Size = new System.Drawing.Size(55, 17);
            this.LockedCustomerFPLabel.TabIndex = 0;
            this.LockedCustomerFPLabel.Text = "Lock Ids";
            // 
            // SourceFPLabel
            // 
            this.SourceFPLabel.AutoSize = true;
            this.SourceFPLabel.Location = new System.Drawing.Point(46, 271);
            this.SourceFPLabel.Name = "SourceFPLabel";
            this.SourceFPLabel.Size = new System.Drawing.Size(95, 17);
            this.SourceFPLabel.TabIndex = 1;
            this.SourceFPLabel.Text = "Source filepath";
            // 
            // ResultFPLabel
            // 
            this.ResultFPLabel.AutoSize = true;
            this.ResultFPLabel.Location = new System.Drawing.Point(48, 360);
            this.ResultFPLabel.Name = "ResultFPLabel";
            this.ResultFPLabel.Size = new System.Drawing.Size(90, 17);
            this.ResultFPLabel.TabIndex = 2;
            this.ResultFPLabel.Text = "Result filepath";
            // 
            // ExtractButton
            // 
            this.ExtractButton.BackColor = System.Drawing.Color.OldLace;
            this.ExtractButton.Location = new System.Drawing.Point(171, 527);
            this.ExtractButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ExtractButton.Name = "ExtractButton";
            this.ExtractButton.Size = new System.Drawing.Size(527, 52);
            this.ExtractButton.TabIndex = 3;
            this.ExtractButton.Text = "Extract";
            this.ExtractButton.UseVisualStyleBackColor = false;
            this.ExtractButton.Click += new System.EventHandler(this.ExtractButton_Click);
            // 
            // SourceInput
            // 
            this.SourceInput.Location = new System.Drawing.Point(171, 271);
            this.SourceInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SourceInput.Name = "SourceInput";
            this.SourceInput.Size = new System.Drawing.Size(417, 25);
            this.SourceInput.TabIndex = 5;
            // 
            // ResultPathInput
            // 
            this.ResultPathInput.Location = new System.Drawing.Point(171, 360);
            this.ResultPathInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ResultPathInput.Name = "ResultPathInput";
            this.ResultPathInput.Size = new System.Drawing.Size(417, 25);
            this.ResultPathInput.TabIndex = 6;
            // 
            // ReportFPInput
            // 
            this.ReportFPInput.Location = new System.Drawing.Point(171, 448);
            this.ReportFPInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ReportFPInput.Name = "ReportFPInput";
            this.ReportFPInput.Size = new System.Drawing.Size(417, 25);
            this.ReportFPInput.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 447);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Report filepath";
            // 
            // ResultFilePathButton
            // 
            this.ResultFilePathButton.BackColor = System.Drawing.Color.OldLace;
            this.ResultFilePathButton.Location = new System.Drawing.Point(611, 356);
            this.ResultFilePathButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ResultFilePathButton.Name = "ResultFilePathButton";
            this.ResultFilePathButton.Size = new System.Drawing.Size(87, 30);
            this.ResultFilePathButton.TabIndex = 9;
            this.ResultFilePathButton.Text = "Browse";
            this.ResultFilePathButton.UseVisualStyleBackColor = false;
            this.ResultFilePathButton.Click += new System.EventHandler(this.ResultFilePathButton_Click);
            // 
            // SourceFilePathButton
            // 
            this.SourceFilePathButton.BackColor = System.Drawing.Color.OldLace;
            this.SourceFilePathButton.Location = new System.Drawing.Point(611, 267);
            this.SourceFilePathButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SourceFilePathButton.Name = "SourceFilePathButton";
            this.SourceFilePathButton.Size = new System.Drawing.Size(87, 30);
            this.SourceFilePathButton.TabIndex = 9;
            this.SourceFilePathButton.Text = "Browse";
            this.SourceFilePathButton.UseVisualStyleBackColor = false;
            this.SourceFilePathButton.Click += new System.EventHandler(this.SourceFilePathButton_Click);
            // 
            // ReportFilePathButton
            // 
            this.ReportFilePathButton.BackColor = System.Drawing.Color.OldLace;
            this.ReportFilePathButton.Location = new System.Drawing.Point(611, 438);
            this.ReportFilePathButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ReportFilePathButton.Name = "ReportFilePathButton";
            this.ReportFilePathButton.Size = new System.Drawing.Size(87, 30);
            this.ReportFilePathButton.TabIndex = 9;
            this.ReportFilePathButton.Text = "Browse";
            this.ReportFilePathButton.UseVisualStyleBackColor = false;
            this.ReportFilePathButton.Click += new System.EventHandler(this.ReportFilePathButton_Click);
            // 
            // ListBoxForInvalidClientNumber
            // 
            this.ListBoxForInvalidClientNumber.BackColor = System.Drawing.Color.OldLace;
            this.ListBoxForInvalidClientNumber.FormattingEnabled = true;
            this.ListBoxForInvalidClientNumber.ItemHeight = 17;
            this.ListBoxForInvalidClientNumber.Location = new System.Drawing.Point(736, 15);
            this.ListBoxForInvalidClientNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ListBoxForInvalidClientNumber.Name = "ListBoxForInvalidClientNumber";
            this.ListBoxForInvalidClientNumber.Size = new System.Drawing.Size(353, 514);
            this.ListBoxForInvalidClientNumber.TabIndex = 10;
            // 
            // LockCustInput
            // 
            this.LockCustInput.BackColor = System.Drawing.Color.OldLace;
            this.LockCustInput.Location = new System.Drawing.Point(171, 15);
            this.LockCustInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LockCustInput.Name = "LockCustInput";
            this.LockCustInput.Size = new System.Drawing.Size(527, 216);
            this.LockCustInput.TabIndex = 13;
            this.LockCustInput.Text = "";
            // 
            // CB_ResultFile
            // 
            this.CB_ResultFile.AutoSize = true;
            this.CB_ResultFile.Location = new System.Drawing.Point(171, 394);
            this.CB_ResultFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CB_ResultFile.Name = "CB_ResultFile";
            this.CB_ResultFile.Size = new System.Drawing.Size(121, 21);
            this.CB_ResultFile.TabIndex = 14;
            this.CB_ResultFile.Text = "Get Default Path";
            this.CB_ResultFile.UseVisualStyleBackColor = true;
            this.CB_ResultFile.CheckedChanged += new System.EventHandler(this.CB_ResultFile_CheckedChanged);
            // 
            // CB_ReportFile
            // 
            this.CB_ReportFile.AutoSize = true;
            this.CB_ReportFile.Location = new System.Drawing.Point(171, 482);
            this.CB_ReportFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CB_ReportFile.Name = "CB_ReportFile";
            this.CB_ReportFile.Size = new System.Drawing.Size(121, 21);
            this.CB_ReportFile.TabIndex = 14;
            this.CB_ReportFile.Text = "Get Default Path";
            this.CB_ReportFile.UseVisualStyleBackColor = true;
            this.CB_ReportFile.CheckedChanged += new System.EventHandler(this.CB_ReportFile_CheckedChanged);
            // 
            // LinkToTheMainFolder
            // 
            this.LinkToTheMainFolder.AutoSize = true;
            this.LinkToTheMainFolder.LinkColor = System.Drawing.Color.DarkOrchid;
            this.LinkToTheMainFolder.Location = new System.Drawing.Point(831, 546);
            this.LinkToTheMainFolder.Name = "LinkToTheMainFolder";
            this.LinkToTheMainFolder.Size = new System.Drawing.Size(202, 17);
            this.LinkToTheMainFolder.TabIndex = 15;
            this.LinkToTheMainFolder.TabStop = true;
            this.LinkToTheMainFolder.Text = "Go to the Results and/or Reports";
            this.LinkToTheMainFolder.Visible = false;
            this.LinkToTheMainFolder.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkToTheMainFolder_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1137, 642);
            this.Controls.Add(this.LinkToTheMainFolder);
            this.Controls.Add(this.CB_ReportFile);
            this.Controls.Add(this.CB_ResultFile);
            this.Controls.Add(this.LockCustInput);
            this.Controls.Add(this.ListBoxForInvalidClientNumber);
            this.Controls.Add(this.SourceFilePathButton);
            this.Controls.Add(this.ReportFilePathButton);
            this.Controls.Add(this.ResultFilePathButton);
            this.Controls.Add(this.ReportFPInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ResultPathInput);
            this.Controls.Add(this.SourceInput);
            this.Controls.Add(this.ExtractButton);
            this.Controls.Add(this.ResultFPLabel);
            this.Controls.Add(this.SourceFPLabel);
            this.Controls.Add(this.LockedCustomerFPLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(1153, 681);
            this.MinimumSize = new System.Drawing.Size(1153, 681);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Locked Customer Extractor v1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LockedCustomerFPLabel;
        private System.Windows.Forms.Label SourceFPLabel;
        private System.Windows.Forms.Label ResultFPLabel;
        private System.Windows.Forms.Button ExtractButton;
        private System.Windows.Forms.TextBox SourceInput;
        private System.Windows.Forms.TextBox ResultPathInput;
        private System.Windows.Forms.TextBox ReportFPInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ResultFilePathButton;
        private System.Windows.Forms.Button SourceFilePathButton;
        private System.Windows.Forms.Button ReportFilePathButton;
        private System.Windows.Forms.ListBox ListBoxForInvalidClientNumber;
        private System.Windows.Forms.RichTextBox LockCustInput;
        private System.Windows.Forms.CheckBox CB_ResultFile;
        private System.Windows.Forms.CheckBox CB_ReportFile;
        private System.Windows.Forms.LinkLabel LinkToTheMainFolder;
    }
}


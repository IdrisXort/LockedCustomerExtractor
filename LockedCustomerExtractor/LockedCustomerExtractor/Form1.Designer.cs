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
            this.LockCustInput = new System.Windows.Forms.TextBox();
            this.SourceInput = new System.Windows.Forms.TextBox();
            this.ResultPathInput = new System.Windows.Forms.TextBox();
            this.ReportFPInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LockedCustomerFPLabel
            // 
            this.LockedCustomerFPLabel.AutoSize = true;
            this.LockedCustomerFPLabel.Location = new System.Drawing.Point(28, 32);
            this.LockedCustomerFPLabel.Name = "LockedCustomerFPLabel";
            this.LockedCustomerFPLabel.Size = new System.Drawing.Size(114, 13);
            this.LockedCustomerFPLabel.TabIndex = 0;
            this.LockedCustomerFPLabel.Text = "Lock customer filepath";
            // 
            // SourceFPLabel
            // 
            this.SourceFPLabel.AutoSize = true;
            this.SourceFPLabel.Location = new System.Drawing.Point(31, 97);
            this.SourceFPLabel.Name = "SourceFPLabel";
            this.SourceFPLabel.Size = new System.Drawing.Size(78, 13);
            this.SourceFPLabel.TabIndex = 1;
            this.SourceFPLabel.Text = "Source filepath";
            // 
            // ResultFPLabel
            // 
            this.ResultFPLabel.AutoSize = true;
            this.ResultFPLabel.Location = new System.Drawing.Point(33, 165);
            this.ResultFPLabel.Name = "ResultFPLabel";
            this.ResultFPLabel.Size = new System.Drawing.Size(74, 13);
            this.ResultFPLabel.TabIndex = 2;
            this.ResultFPLabel.Text = "Result filepath";
            // 
            // ExtractButton
            // 
            this.ExtractButton.Location = new System.Drawing.Point(604, 91);
            this.ExtractButton.Name = "ExtractButton";
            this.ExtractButton.Size = new System.Drawing.Size(136, 64);
            this.ExtractButton.TabIndex = 3;
            this.ExtractButton.Text = "Extract";
            this.ExtractButton.UseVisualStyleBackColor = true;
            this.ExtractButton.Click += new System.EventHandler(this.ExtractButton_Click);
            // 
            // LockCustInput
            // 
            this.LockCustInput.Location = new System.Drawing.Point(180, 29);
            this.LockCustInput.Name = "LockCustInput";
            this.LockCustInput.Size = new System.Drawing.Size(358, 20);
            this.LockCustInput.TabIndex = 4;
            // 
            // SourceInput
            // 
            this.SourceInput.Location = new System.Drawing.Point(180, 94);
            this.SourceInput.Name = "SourceInput";
            this.SourceInput.Size = new System.Drawing.Size(358, 20);
            this.SourceInput.TabIndex = 5;
            // 
            // ResultPathInput
            // 
            this.ResultPathInput.Location = new System.Drawing.Point(180, 162);
            this.ResultPathInput.Name = "ResultPathInput";
            this.ResultPathInput.Size = new System.Drawing.Size(358, 20);
            this.ResultPathInput.TabIndex = 6;
            // 
            // ReportFPInput
            // 
            this.ReportFPInput.Location = new System.Drawing.Point(180, 229);
            this.ReportFPInput.Name = "ReportFPInput";
            this.ReportFPInput.Size = new System.Drawing.Size(358, 20);
            this.ReportFPInput.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Report filepath";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 261);
            this.Controls.Add(this.ReportFPInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ResultPathInput);
            this.Controls.Add(this.SourceInput);
            this.Controls.Add(this.LockCustInput);
            this.Controls.Add(this.ExtractButton);
            this.Controls.Add(this.ResultFPLabel);
            this.Controls.Add(this.SourceFPLabel);
            this.Controls.Add(this.LockedCustomerFPLabel);
            this.Name = "Form1";
            this.Text = "Locked Customer Extractor v1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LockedCustomerFPLabel;
        private System.Windows.Forms.Label SourceFPLabel;
        private System.Windows.Forms.Label ResultFPLabel;
        private System.Windows.Forms.Button ExtractButton;
        private System.Windows.Forms.TextBox LockCustInput;
        private System.Windows.Forms.TextBox SourceInput;
        private System.Windows.Forms.TextBox ResultPathInput;
        private System.Windows.Forms.TextBox ReportFPInput;
        private System.Windows.Forms.Label label1;
    }
}


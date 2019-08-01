namespace LibsDataTransferTestApp
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
            this.requestMeasurementButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TransferTimeLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.OutputDirectoryTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // requestMeasurementButton
            // 
            this.requestMeasurementButton.Location = new System.Drawing.Point(22, 27);
            this.requestMeasurementButton.Name = "requestMeasurementButton";
            this.requestMeasurementButton.Size = new System.Drawing.Size(110, 50);
            this.requestMeasurementButton.TabIndex = 0;
            this.requestMeasurementButton.Text = "Request Measurement";
            this.requestMeasurementButton.UseVisualStyleBackColor = true;
            this.requestMeasurementButton.Click += new System.EventHandler(this.requestMeasurementButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Transfer Time";
            // 
            // TransferTimeLabel
            // 
            this.TransferTimeLabel.AutoSize = true;
            this.TransferTimeLabel.Location = new System.Drawing.Point(263, 44);
            this.TransferTimeLabel.Name = "TransferTimeLabel";
            this.TransferTimeLabel.Size = new System.Drawing.Size(18, 17);
            this.TransferTimeLabel.TabIndex = 2;
            this.TransferTimeLabel.Text = "--";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Trigger Lock";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(184, 94);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(165, 22);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "TSI";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 27);
            this.button1.TabIndex = 7;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // OutputDirectoryTextbox
            // 
            this.OutputDirectoryTextbox.Location = new System.Drawing.Point(80, 130);
            this.OutputDirectoryTextbox.Name = "OutputDirectoryTextbox";
            this.OutputDirectoryTextbox.Size = new System.Drawing.Size(558, 22);
            this.OutputDirectoryTextbox.TabIndex = 8;
            this.OutputDirectoryTextbox.Text = "C:\\Users\\Public\\TSI\\TransferTest";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 169);
            this.Controls.Add(this.OutputDirectoryTextbox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TransferTimeLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.requestMeasurementButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button requestMeasurementButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TransferTimeLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox OutputDirectoryTextbox;
    }
}


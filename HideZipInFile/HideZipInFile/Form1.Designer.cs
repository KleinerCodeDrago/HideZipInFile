namespace HideZipInFile
{
    partial class Form1
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
            this.ChooseZipLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ChooseZipLabel
            // 
            this.ChooseZipLabel.AllowDrop = true;
            this.ChooseZipLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChooseZipLabel.ForeColor = System.Drawing.Color.Red;
            this.ChooseZipLabel.Location = new System.Drawing.Point(113, 59);
            this.ChooseZipLabel.Name = "ChooseZipLabel";
            this.ChooseZipLabel.Size = new System.Drawing.Size(500, 300);
            this.ChooseZipLabel.TabIndex = 0;
            this.ChooseZipLabel.Text = "Choose zip file to hide";
            this.ChooseZipLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ChooseZipLabel.Click += new System.EventHandler(this.ChooseZipLabel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1883, 775);
            this.Controls.Add(this.ChooseZipLabel);
            this.Name = "Form1";
            this.Text = "HideZipFIle";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Label ChooseZipLabel;
    }
}
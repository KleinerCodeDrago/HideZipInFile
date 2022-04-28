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
            this.fileHideInLabel = new System.Windows.Forms.Label();
            this.CombineButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ChooseZipLabel
            // 
            this.ChooseZipLabel.AllowDrop = true;
            this.ChooseZipLabel.AutoSize = true;
            this.ChooseZipLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChooseZipLabel.ForeColor = System.Drawing.Color.Red;
            this.ChooseZipLabel.Location = new System.Drawing.Point(138, 102);
            this.ChooseZipLabel.Name = "ChooseZipLabel";
            this.ChooseZipLabel.Size = new System.Drawing.Size(420, 54);
            this.ChooseZipLabel.TabIndex = 0;
            this.ChooseZipLabel.Text = "Choose zip file to hide";
            this.ChooseZipLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ChooseZipLabel.Click += new System.EventHandler(this.ChooseZipLabel_Click);
            // 
            // fileHideInLabel
            // 
            this.fileHideInLabel.AllowDrop = true;
            this.fileHideInLabel.AutoSize = true;
            this.fileHideInLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fileHideInLabel.ForeColor = System.Drawing.Color.Red;
            this.fileHideInLabel.Location = new System.Drawing.Point(738, 111);
            this.fileHideInLabel.Name = "fileHideInLabel";
            this.fileHideInLabel.Size = new System.Drawing.Size(401, 54);
            this.fileHideInLabel.TabIndex = 1;
            this.fileHideInLabel.Text = "Choose file to hide in";
            this.fileHideInLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.fileHideInLabel.Click += new System.EventHandler(this.fileHideInLabel_Click);
            // 
            // CombineButton
            // 
            this.CombineButton.Location = new System.Drawing.Point(453, 282);
            this.CombineButton.Name = "CombineButton";
            this.CombineButton.Size = new System.Drawing.Size(354, 137);
            this.CombineButton.TabIndex = 2;
            this.CombineButton.Text = "Click to combine";
            this.CombineButton.UseVisualStyleBackColor = true;
            this.CombineButton.Click += new System.EventHandler(this.CombineButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 775);
            this.Controls.Add(this.CombineButton);
            this.Controls.Add(this.fileHideInLabel);
            this.Controls.Add(this.ChooseZipLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MinimumSize = new System.Drawing.Size(822, 0);
            this.Name = "Form1";
            this.Text = "HideZipFIle";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label ChooseZipLabel;
        private Label fileHideInLabel;
        private Button CombineButton;
    }
}
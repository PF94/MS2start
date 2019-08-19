namespace MShelp
{
    partial class MainApp
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
            this.logoText = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // logoText
            // 
            this.logoText.AutoSize = true;
            this.logoText.BackColor = System.Drawing.Color.White;
            this.logoText.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(161)))), ((int)(((byte)(196)))));
            this.logoText.Location = new System.Drawing.Point(125, 41);
            this.logoText.Name = "logoText";
            this.logoText.Size = new System.Drawing.Size(121, 37);
            this.logoText.TabIndex = 0;
            this.logoText.Text = "MS Help";
            // 
            // logo
            // 
            this.logo.Image = global::MShelp.Properties.Resources.SplashLogo;
            this.logo.Location = new System.Drawing.Point(97, 50);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(23, 26);
            this.logo.TabIndex = 1;
            this.logo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.label1.Location = new System.Drawing.Point(86, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(753, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "Access denied. See %temp%\\mshelp.log for details.";
            // 
            // MainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.logoText);
            this.Name = "MainApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label logoText;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label label1;
    }
}


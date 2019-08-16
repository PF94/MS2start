namespace MS2start
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
            this.version = new System.Windows.Forms.Label();
            this.Explorer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // version
            // 
            this.version.AutoSize = true;
            this.version.BackColor = System.Drawing.Color.Transparent;
            this.version.ForeColor = System.Drawing.Color.White;
            this.version.Location = new System.Drawing.Point(3, 9);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(97, 13);
            this.version.TabIndex = 0;
            this.version.Text = "MS2start Prototype";
            // 
            // Explorer
            // 
            this.Explorer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(218)))), ((int)(((byte)(131)))));
            this.Explorer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Explorer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Explorer.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Explorer.Location = new System.Drawing.Point(19, 59);
            this.Explorer.Name = "Explorer";
            this.Explorer.Size = new System.Drawing.Size(138, 138);
            this.Explorer.TabIndex = 1;
            this.Explorer.Text = "Windows Explorer";
            this.Explorer.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.Explorer.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MS2start.Properties.Resources.windows_8_m3_wallpaper1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Explorer);
            this.Controls.Add(this.version);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label version;
        private System.Windows.Forms.Button Explorer;
    }
}


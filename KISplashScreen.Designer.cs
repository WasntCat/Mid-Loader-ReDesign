namespace KIUIPaided
{
    partial class KISplashScreen
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
            this.components = new System.ComponentModel.Container();
            this.BottomTaskBar = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.Dot1 = new System.Windows.Forms.Label();
            this.Dot2 = new System.Windows.Forms.Label();
            this.Dot3 = new System.Windows.Forms.Label();
            this.LoadLogin = new System.Windows.Forms.Timer(this.components);
            this.Dgr1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.Drg2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.SuspendLayout();
            // 
            // BottomTaskBar
            // 
            this.BottomTaskBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomTaskBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.BottomTaskBar.Location = new System.Drawing.Point(0, 388);
            this.BottomTaskBar.Name = "BottomTaskBar";
            this.BottomTaskBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(55)))), ((int)(((byte)(227)))));
            this.BottomTaskBar.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(55)))), ((int)(((byte)(227)))));
            this.BottomTaskBar.Size = new System.Drawing.Size(324, 10);
            this.BottomTaskBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.BottomTaskBar.TabIndex = 0;
            this.BottomTaskBar.Text = "--";
            this.BottomTaskBar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // guna2ShadowForm1
            // 
            this.guna2ShadowForm1.BorderRadius = 3;
            this.guna2ShadowForm1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.guna2ShadowForm1.TargetForm = this;
            // 
            // Dot1
            // 
            this.Dot1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dot1.ForeColor = System.Drawing.Color.Honeydew;
            this.Dot1.Location = new System.Drawing.Point(74, 276);
            this.Dot1.Name = "Dot1";
            this.Dot1.Size = new System.Drawing.Size(54, 109);
            this.Dot1.TabIndex = 2;
            this.Dot1.Text = ".";
            this.Dot1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Dot1.Visible = false;
            // 
            // Dot2
            // 
            this.Dot2.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dot2.ForeColor = System.Drawing.Color.Honeydew;
            this.Dot2.Location = new System.Drawing.Point(134, 276);
            this.Dot2.Name = "Dot2";
            this.Dot2.Size = new System.Drawing.Size(54, 109);
            this.Dot2.TabIndex = 3;
            this.Dot2.Text = ".";
            this.Dot2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Dot2.Visible = false;
            // 
            // Dot3
            // 
            this.Dot3.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dot3.ForeColor = System.Drawing.Color.Honeydew;
            this.Dot3.Location = new System.Drawing.Point(194, 276);
            this.Dot3.Name = "Dot3";
            this.Dot3.Size = new System.Drawing.Size(54, 109);
            this.Dot3.TabIndex = 4;
            this.Dot3.Text = ".";
            this.Dot3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Dot3.Visible = false;
            // 
            // LoadLogin
            // 
            this.LoadLogin.Tick += new System.EventHandler(this.LoadLogin_Tick);
            // 
            // Dgr1
            // 
            this.Dgr1.DockIndicatorTransparencyValue = 0.6D;
            this.Dgr1.TargetControl = this;
            this.Dgr1.UseTransparentDrag = true;
            // 
            // Drg2
            // 
            this.Drg2.DockIndicatorTransparencyValue = 0.6D;
            this.Drg2.UseTransparentDrag = true;
            // 
            // KISplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(324, 398);
            this.Controls.Add(this.Dot3);
            this.Controls.Add(this.Dot2);
            this.Controls.Add(this.Dot1);
            this.Controls.Add(this.BottomTaskBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KISplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KISplashScreen";
            this.Load += new System.EventHandler(this.KISplashScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ProgressBar BottomTaskBar;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private System.Windows.Forms.Label Dot3;
        private System.Windows.Forms.Label Dot2;
        private System.Windows.Forms.Label Dot1;
        private System.Windows.Forms.Timer LoadLogin;
        private Guna.UI2.WinForms.Guna2DragControl Dgr1;
        private Guna.UI2.WinForms.Guna2DragControl Drg2;
    }
}
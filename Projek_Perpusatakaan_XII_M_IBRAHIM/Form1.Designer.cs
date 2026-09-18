
namespace Projek_Perpusatakaan_XII_M_IBRAHIM
{
    partial class FLogin
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.panelLeft = new System.Windows.Forms.Panel();
            this.lblIconBook = new System.Windows.Forms.Label();
            this.lblAppName = new System.Windows.Forms.Label();
            this.lblTagline = new System.Windows.Forms.Label();
            this.panelRight = new System.Windows.Forms.Panel();
            this.panelCard = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.lblFooter = new System.Windows.Forms.Label();
            this.panelLeft.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.panelCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(42)))), ((int)(((byte)(76)))));
            this.panelLeft.Controls.Add(this.lblIconBook);
            this.panelLeft.Controls.Add(this.lblAppName);
            this.panelLeft.Controls.Add(this.lblTagline);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(380, 560);
            this.panelLeft.TabIndex = 0;
            // 
            // lblIconBook
            // 
            this.lblIconBook.Font = new System.Drawing.Font("Segoe UI Emoji", 52F);
            this.lblIconBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.lblIconBook.Location = new System.Drawing.Point(0, 140);
            this.lblIconBook.Name = "lblIconBook";
            this.lblIconBook.Size = new System.Drawing.Size(380, 90);
            this.lblIconBook.TabIndex = 0;
            this.lblIconBook.Text = "📚";
            this.lblIconBook.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAppName
            // 
            this.lblAppName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblAppName.ForeColor = System.Drawing.Color.White;
            this.lblAppName.Location = new System.Drawing.Point(20, 240);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(340, 50);
            this.lblAppName.TabIndex = 1;
            this.lblAppName.Text = "Perpustakaan";
            this.lblAppName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTagline
            // 
            this.lblTagline.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTagline.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(200)))), ((int)(((byte)(240)))));
            this.lblTagline.Location = new System.Drawing.Point(20, 290);
            this.lblTagline.Name = "lblTagline";
            this.lblTagline.Size = new System.Drawing.Size(340, 50);
            this.lblTagline.TabIndex = 2;
            this.lblTagline.Text = "Sistem Informasi Perpustakaan";
            this.lblTagline.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(42)))));
            this.panelRight.Controls.Add(this.panelCard);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(380, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(500, 560);
            this.panelRight.TabIndex = 1;
            // 
            // panelCard
            // 
            this.panelCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(55)))));
            this.panelCard.Controls.Add(this.lblWelcome);
            this.panelCard.Controls.Add(this.lblSubtitle);
            this.panelCard.Controls.Add(this.lblUsername);
            this.panelCard.Controls.Add(this.txtUsername);
            this.panelCard.Controls.Add(this.lblPassword);
            this.panelCard.Controls.Add(this.txtPassword);
            this.panelCard.Controls.Add(this.btnLogin);
            this.panelCard.Controls.Add(this.lblFooter);
            this.panelCard.Location = new System.Drawing.Point(50, 90);
            this.panelCard.Name = "panelCard";
            this.panelCard.Size = new System.Drawing.Size(400, 390);
            this.panelCard.TabIndex = 0;
            // 
            // lblWelcome
            // 
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(20, 15);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(360, 55);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Selamat Datang";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(160)))), ((int)(((byte)(190)))));
            this.lblSubtitle.Location = new System.Drawing.Point(20, 70);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(360, 24);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Masuk ke akun Anda untuk melanjutkan";
            // 
            // lblUsername
            // 
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(200)))), ((int)(((byte)(240)))));
            this.lblUsername.Location = new System.Drawing.Point(20, 112);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(360, 20);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "USERNAME";
            // 
            // txtUsername
            // 
            this.txtUsername.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(70)))), ((int)(((byte)(100)))));
            this.txtUsername.BorderRadius = 8;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.DefaultText = "";
            this.txtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(70)))), ((int)(((byte)(100)))));
            this.txtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(48)))), ((int)(((byte)(68)))));
            this.txtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(120)))), ((int)(((byte)(150)))));
            this.txtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(120)))), ((int)(((byte)(150)))));
            this.txtUsername.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(48)))), ((int)(((byte)(68)))));
            this.txtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtUsername.ForeColor = System.Drawing.Color.White;
            this.txtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(130)))), ((int)(((byte)(200)))));
            this.txtUsername.Location = new System.Drawing.Point(20, 136);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(0);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(120)))), ((int)(((byte)(150)))));
            this.txtUsername.PlaceholderText = "Masukkan username...";
            this.txtUsername.SelectedText = "";
            this.txtUsername.Size = new System.Drawing.Size(360, 40);
            this.txtUsername.TabIndex = 3;
            // 
            // lblPassword
            // 
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(200)))), ((int)(((byte)(240)))));
            this.lblPassword.Location = new System.Drawing.Point(20, 196);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(360, 20);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "PASSWORD";
            // 
            // txtPassword
            // 
            this.txtPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(70)))), ((int)(((byte)(100)))));
            this.txtPassword.BorderRadius = 8;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(70)))), ((int)(((byte)(100)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(48)))), ((int)(((byte)(68)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(120)))), ((int)(((byte)(150)))));
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(120)))), ((int)(((byte)(150)))));
            this.txtPassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(48)))), ((int)(((byte)(68)))));
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(130)))), ((int)(((byte)(200)))));
            this.txtPassword.Location = new System.Drawing.Point(20, 220);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(0);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(120)))), ((int)(((byte)(150)))));
            this.txtPassword.PlaceholderText = "Masukkan password...";
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(360, 40);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Animated = true;
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.BorderRadius = 8;
            this.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.btnLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.btnLogin.Location = new System.Drawing.Point(20, 284);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(78)))), ((int)(((byte)(216)))));
            this.btnLogin.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnLogin.ShadowDecoration.Depth = 6;
            this.btnLogin.ShadowDecoration.Enabled = true;
            this.btnLogin.Size = new System.Drawing.Size(360, 46);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "MASUK";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblFooter
            // 
            this.lblFooter.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblFooter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(100)))), ((int)(((byte)(130)))));
            this.lblFooter.Location = new System.Drawing.Point(20, 348);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(360, 24);
            this.lblFooter.TabIndex = 7;
            this.lblFooter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(880, 560);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login — Sistem Perpustakaan";
            this.Load += new System.EventHandler(this.FLogin_Load);
            this.panelLeft.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            this.panelCard.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Label lblIconBook;
        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.Label lblTagline;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Panel panelCard;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblUsername;
        private Guna.UI2.WinForms.Guna2TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private System.Windows.Forms.Label lblFooter;
    }
}

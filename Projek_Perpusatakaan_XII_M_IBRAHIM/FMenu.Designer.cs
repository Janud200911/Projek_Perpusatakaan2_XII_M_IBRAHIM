
namespace Projek_Perpusatakaan_XII_M_IBRAHIM
{
    partial class FAdmin
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblHeaderIcon = new System.Windows.Forms.Label();
            this.lblHeaderTitle = new System.Windows.Forms.Label();
            this.lblHeaderSub = new System.Windows.Forms.Label();
            this.lblUserBadge = new System.Windows.Forms.Label();
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.lblMenuTitle = new System.Windows.Forms.Label();
            this.btnDashboard = new Guna.UI2.WinForms.Guna2Button();
            this.btnDataBuku = new Guna.UI2.WinForms.Guna2Button();
            this.btnKategori = new Guna.UI2.WinForms.Guna2Button();
            this.btnDataUser = new Guna.UI2.WinForms.Guna2Button();
            this.btnDataRole = new Guna.UI2.WinForms.Guna2Button();
            this.btnTransaksi = new Guna.UI2.WinForms.Guna2Button();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.panelContent = new Guna.UI2.WinForms.Guna2Panel();
            this.panelDivider = new System.Windows.Forms.Panel();
            this.panelHeader.SuspendLayout();
            this.panelSidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(42)))), ((int)(((byte)(76)))));
            this.panelHeader.Controls.Add(this.lblHeaderIcon);
            this.panelHeader.Controls.Add(this.lblHeaderTitle);
            this.panelHeader.Controls.Add(this.lblHeaderSub);
            this.panelHeader.Controls.Add(this.lblUserBadge);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1100, 64);
            this.panelHeader.TabIndex = 0;
            // 
            // lblHeaderIcon
            // 
            this.lblHeaderIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 22F);
            this.lblHeaderIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.lblHeaderIcon.Location = new System.Drawing.Point(16, 10);
            this.lblHeaderIcon.Name = "lblHeaderIcon";
            this.lblHeaderIcon.Size = new System.Drawing.Size(46, 42);
            this.lblHeaderIcon.TabIndex = 0;
            this.lblHeaderIcon.Text = "📚";
            this.lblHeaderIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblHeaderTitle.ForeColor = System.Drawing.Color.White;
            this.lblHeaderTitle.Location = new System.Drawing.Point(57, 0);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(327, 44);
            this.lblHeaderTitle.TabIndex = 1;
            this.lblHeaderTitle.Text = "Sistem Perpustakaan";
            // 
            // lblHeaderSub
            // 
            this.lblHeaderSub.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblHeaderSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(180)))), ((int)(((byte)(230)))));
            this.lblHeaderSub.Location = new System.Drawing.Point(70, 36);
            this.lblHeaderSub.Name = "lblHeaderSub";
            this.lblHeaderSub.Size = new System.Drawing.Size(280, 18);
            this.lblHeaderSub.TabIndex = 2;
            this.lblHeaderSub.Text = "Panel Administrator";
            // 
            // lblUserBadge
            // 
            this.lblUserBadge.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblUserBadge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.lblUserBadge.Location = new System.Drawing.Point(880, 22);
            this.lblUserBadge.Name = "lblUserBadge";
            this.lblUserBadge.Size = new System.Drawing.Size(200, 22);
            this.lblUserBadge.TabIndex = 3;
            this.lblUserBadge.Text = "👤  Administrator";
            this.lblUserBadge.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(32)))), ((int)(((byte)(52)))));
            this.panelSidebar.Controls.Add(this.lblMenuTitle);
            this.panelSidebar.Controls.Add(this.btnDashboard);
            this.panelSidebar.Controls.Add(this.btnDataBuku);
            this.panelSidebar.Controls.Add(this.btnKategori);
            this.panelSidebar.Controls.Add(this.btnDataUser);
            this.panelSidebar.Controls.Add(this.btnDataRole);
            this.panelSidebar.Controls.Add(this.btnTransaksi);
            this.panelSidebar.Controls.Add(this.btnLogout);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 64);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(200, 576);
            this.panelSidebar.TabIndex = 1;
            // 
            // lblMenuTitle
            // 
            this.lblMenuTitle.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblMenuTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(110)))), ((int)(((byte)(160)))));
            this.lblMenuTitle.Location = new System.Drawing.Point(16, 16);
            this.lblMenuTitle.Name = "lblMenuTitle";
            this.lblMenuTitle.Size = new System.Drawing.Size(168, 18);
            this.lblMenuTitle.TabIndex = 0;
            this.lblMenuTitle.Text = "NAVIGASI UTAMA";
            // 
            // btnDashboard
            // 
            this.btnDashboard.Animated = true;
            this.btnDashboard.BorderRadius = 8;
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDashboard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDashboard.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.btnDashboard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.btnDashboard.FillColor = System.Drawing.Color.Transparent;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(200)))), ((int)(((byte)(230)))));
            this.btnDashboard.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnDashboard.Location = new System.Drawing.Point(12, 44);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(176, 40);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "🏠   Dashboard";
            // 
            // btnDataBuku
            // 
            this.btnDataBuku.Animated = true;
            this.btnDataBuku.BorderRadius = 8;
            this.btnDataBuku.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDataBuku.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDataBuku.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDataBuku.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.btnDataBuku.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.btnDataBuku.FillColor = System.Drawing.Color.Transparent;
            this.btnDataBuku.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnDataBuku.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(200)))), ((int)(((byte)(230)))));
            this.btnDataBuku.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnDataBuku.Location = new System.Drawing.Point(12, 92);
            this.btnDataBuku.Name = "btnDataBuku";
            this.btnDataBuku.Size = new System.Drawing.Size(176, 40);
            this.btnDataBuku.TabIndex = 2;
            this.btnDataBuku.Text = "📖   Data Buku";
            this.btnDataBuku.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // btnKategori
            // 
            this.btnKategori.Animated = true;
            this.btnKategori.BorderRadius = 8;
            this.btnKategori.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKategori.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnKategori.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnKategori.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.btnKategori.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.btnKategori.FillColor = System.Drawing.Color.Transparent;
            this.btnKategori.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnKategori.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(200)))), ((int)(((byte)(230)))));
            this.btnKategori.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnKategori.Location = new System.Drawing.Point(12, 140);
            this.btnKategori.Name = "btnKategori";
            this.btnKategori.Size = new System.Drawing.Size(176, 40);
            this.btnKategori.TabIndex = 3;
            this.btnKategori.Text = "🗂   Kategori";
            // 
            // btnDataUser
            // 
            this.btnDataUser.Animated = true;
            this.btnDataUser.BorderRadius = 8;
            this.btnDataUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDataUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDataUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDataUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.btnDataUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.btnDataUser.FillColor = System.Drawing.Color.Transparent;
            this.btnDataUser.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnDataUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(200)))), ((int)(((byte)(230)))));
            this.btnDataUser.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnDataUser.Location = new System.Drawing.Point(12, 188);
            this.btnDataUser.Name = "btnDataUser";
            this.btnDataUser.Size = new System.Drawing.Size(176, 40);
            this.btnDataUser.TabIndex = 4;
            this.btnDataUser.Text = "👥   Data User";
            this.btnDataUser.Click += new System.EventHandler(this.guna2Button4_Click);
            // 
            // btnDataRole
            // 
            this.btnDataRole.Animated = true;
            this.btnDataRole.BorderRadius = 8;
            this.btnDataRole.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDataRole.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDataRole.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDataRole.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.btnDataRole.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.btnDataRole.FillColor = System.Drawing.Color.Transparent;
            this.btnDataRole.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnDataRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(200)))), ((int)(((byte)(230)))));
            this.btnDataRole.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnDataRole.Location = new System.Drawing.Point(12, 236);
            this.btnDataRole.Name = "btnDataRole";
            this.btnDataRole.Size = new System.Drawing.Size(176, 40);
            this.btnDataRole.TabIndex = 5;
            this.btnDataRole.Text = "🔐   Data Role";
            this.btnDataRole.Click += new System.EventHandler(this.guna2Button5_Click);
            // 
            // btnTransaksi
            // 
            this.btnTransaksi.Animated = true;
            this.btnTransaksi.BorderRadius = 8;
            this.btnTransaksi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTransaksi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTransaksi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTransaksi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.btnTransaksi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.btnTransaksi.FillColor = System.Drawing.Color.Transparent;
            this.btnTransaksi.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnTransaksi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(200)))), ((int)(((byte)(230)))));
            this.btnTransaksi.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnTransaksi.Location = new System.Drawing.Point(12, 284);
            this.btnTransaksi.Name = "btnTransaksi";
            this.btnTransaksi.Size = new System.Drawing.Size(176, 40);
            this.btnTransaksi.TabIndex = 7;
            this.btnTransaksi.Text = "📋   Transaksi";
            this.btnTransaksi.Click += new System.EventHandler(this.btnTransaksi_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Animated = true;
            this.btnLogout.BorderRadius = 8;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.btnLogout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnLogout.Location = new System.Drawing.Point(12, 510);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnLogout.Size = new System.Drawing.Size(176, 40);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "⏻   Logout";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(38)))));
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(200, 64);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(900, 576);
            this.panelContent.TabIndex = 2;
            // 
            // panelDivider
            // 
            this.panelDivider.Location = new System.Drawing.Point(0, 0);
            this.panelDivider.Name = "panelDivider";
            this.panelDivider.Size = new System.Drawing.Size(200, 100);
            this.panelDivider.TabIndex = 0;
            // 
            // FAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1100, 640);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelSidebar);
            this.Controls.Add(this.panelHeader);
            this.Name = "FAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistem Perpustakaan — Admin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FAdmin_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelSidebar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblHeaderIcon;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Label lblHeaderSub;
        private System.Windows.Forms.Label lblUserBadge;
        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Label lblMenuTitle;
        private Guna.UI2.WinForms.Guna2Button btnDashboard;
        private Guna.UI2.WinForms.Guna2Button btnDataBuku;
        private Guna.UI2.WinForms.Guna2Button btnKategori;
        private Guna.UI2.WinForms.Guna2Button btnDataUser;
        private Guna.UI2.WinForms.Guna2Button btnDataRole;
        private Guna.UI2.WinForms.Guna2Button btnTransaksi;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
        private Guna.UI2.WinForms.Guna2Panel panelContent;
        private System.Windows.Forms.Panel panelDivider;
    }
}

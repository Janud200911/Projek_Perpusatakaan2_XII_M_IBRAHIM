namespace Projek_Perpusatakaan_XII_M_IBRAHIM
{
    partial class Fdashboard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblJudul = new System.Windows.Forms.Label();
            this.lblTanggal = new System.Windows.Forms.Label();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.panelBuku = new System.Windows.Forms.Panel();
            this.lblBukuIcon = new System.Windows.Forms.Label();
            this.lblTotalBuku = new System.Windows.Forms.Label();
            this.lblBukuTitle = new System.Windows.Forms.Label();
            this.panelAnggota = new System.Windows.Forms.Panel();
            this.lblAnggotaIcon = new System.Windows.Forms.Label();
            this.lblTotalAnggota = new System.Windows.Forms.Label();
            this.lblAnggotaTitle = new System.Windows.Forms.Label();
            this.panelDipinjam = new System.Windows.Forms.Panel();
            this.lblDipinjamIcon = new System.Windows.Forms.Label();
            this.lblDipinjam = new System.Windows.Forms.Label();
            this.lblDipinjamTitle = new System.Windows.Forms.Label();
            this.panelDenda = new System.Windows.Forms.Panel();
            this.lblDendaIcon = new System.Windows.Forms.Label();
            this.lblTotalDenda = new System.Windows.Forms.Label();
            this.lblDendaTitle = new System.Windows.Forms.Label();
            this.lblTabelJudul = new System.Windows.Forms.Label();
            this.dgvPeminjamanAktif = new System.Windows.Forms.DataGridView();
            this.panelBuku.SuspendLayout();
            this.panelAnggota.SuspendLayout();
            this.panelDipinjam.SuspendLayout();
            this.panelDenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeminjamanAktif)).BeginInit();
            this.SuspendLayout();
            // 
            // lblJudul
            // 
            this.lblJudul.AutoSize = true;
            this.lblJudul.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblJudul.ForeColor = System.Drawing.Color.White;
            this.lblJudul.Location = new System.Drawing.Point(20, 18);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(175, 38);
            this.lblJudul.TabIndex = 0;
            this.lblJudul.Text = "  Dashboard";
            // 
            // lblTanggal
            // 
            this.lblTanggal.AutoSize = true;
            this.lblTanggal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTanggal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(200)))), ((int)(((byte)(240)))));
            this.lblTanggal.Location = new System.Drawing.Point(22, 50);
            this.lblTanggal.Name = "lblTanggal";
            this.lblTanggal.Size = new System.Drawing.Size(12, 25);
            this.lblTanggal.TabIndex = 1;
            this.lblTanggal.Text = "\r\n";
            this.lblTanggal.Click += new System.EventHandler(this.lblTanggal_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Animated = true;
            this.btnRefresh.BorderRadius = 8;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRefresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRefresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.btnRefresh.DisabledState.ForeColor = System.Drawing.Color.Gray;
            this.btnRefresh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.btnRefresh.Location = new System.Drawing.Point(760, 22);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(110, 36);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "🔄  Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // panelBuku
            // 
            this.panelBuku.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.panelBuku.Controls.Add(this.lblBukuIcon);
            this.panelBuku.Controls.Add(this.lblTotalBuku);
            this.panelBuku.Controls.Add(this.lblBukuTitle);
            this.panelBuku.Location = new System.Drawing.Point(20, 80);
            this.panelBuku.Name = "panelBuku";
            this.panelBuku.Size = new System.Drawing.Size(235, 113);
            this.panelBuku.TabIndex = 3;
            // 
            // lblBukuIcon
            // 
            this.lblBukuIcon.AutoSize = true;
            this.lblBukuIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 26F);
            this.lblBukuIcon.ForeColor = System.Drawing.Color.White;
            this.lblBukuIcon.Location = new System.Drawing.Point(10, 10);
            this.lblBukuIcon.Name = "lblBukuIcon";
            this.lblBukuIcon.Size = new System.Drawing.Size(0, 69);
            this.lblBukuIcon.TabIndex = 0;
            // 
            // lblTotalBuku
            // 
            this.lblTotalBuku.AutoSize = true;
            this.lblTotalBuku.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold);
            this.lblTotalBuku.ForeColor = System.Drawing.Color.White;
            this.lblTotalBuku.Location = new System.Drawing.Point(16, 10);
            this.lblTotalBuku.Name = "lblTotalBuku";
            this.lblTotalBuku.Size = new System.Drawing.Size(60, 70);
            this.lblTotalBuku.TabIndex = 1;
            this.lblTotalBuku.Text = "0";
            // 
            // lblBukuTitle
            // 
            this.lblBukuTitle.AutoSize = true;
            this.lblBukuTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblBukuTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.lblBukuTitle.Location = new System.Drawing.Point(61, 88);
            this.lblBukuTitle.Name = "lblBukuTitle";
            this.lblBukuTitle.Size = new System.Drawing.Size(93, 25);
            this.lblBukuTitle.TabIndex = 2;
            this.lblBukuTitle.Text = "Total Buku";
            // 
            // panelAnggota
            // 
            this.panelAnggota.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(140)))), ((int)(((byte)(100)))));
            this.panelAnggota.Controls.Add(this.lblAnggotaIcon);
            this.panelAnggota.Controls.Add(this.lblTotalAnggota);
            this.panelAnggota.Controls.Add(this.lblAnggotaTitle);
            this.panelAnggota.Location = new System.Drawing.Point(272, 80);
            this.panelAnggota.Name = "panelAnggota";
            this.panelAnggota.Size = new System.Drawing.Size(273, 113);
            this.panelAnggota.TabIndex = 4;
            // 
            // lblAnggotaIcon
            // 
            this.lblAnggotaIcon.AutoSize = true;
            this.lblAnggotaIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 26F);
            this.lblAnggotaIcon.ForeColor = System.Drawing.Color.White;
            this.lblAnggotaIcon.Location = new System.Drawing.Point(10, 10);
            this.lblAnggotaIcon.Name = "lblAnggotaIcon";
            this.lblAnggotaIcon.Size = new System.Drawing.Size(0, 69);
            this.lblAnggotaIcon.TabIndex = 0;
            // 
            // lblTotalAnggota
            // 
            this.lblTotalAnggota.AutoSize = true;
            this.lblTotalAnggota.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold);
            this.lblTotalAnggota.ForeColor = System.Drawing.Color.White;
            this.lblTotalAnggota.Location = new System.Drawing.Point(16, 8);
            this.lblTotalAnggota.Name = "lblTotalAnggota";
            this.lblTotalAnggota.Size = new System.Drawing.Size(60, 70);
            this.lblTotalAnggota.TabIndex = 1;
            this.lblTotalAnggota.Text = "0";
            // 
            // lblAnggotaTitle
            // 
            this.lblAnggotaTitle.AutoSize = true;
            this.lblAnggotaTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAnggotaTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(245)))), ((int)(((byte)(230)))));
            this.lblAnggotaTitle.Location = new System.Drawing.Point(70, 88);
            this.lblAnggotaTitle.Name = "lblAnggotaTitle";
            this.lblAnggotaTitle.Size = new System.Drawing.Size(124, 25);
            this.lblAnggotaTitle.TabIndex = 2;
            this.lblAnggotaTitle.Text = "Total Anggota";
            // 
            // panelDipinjam
            // 
            this.panelDipinjam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(119)))), ((int)(((byte)(6)))));
            this.panelDipinjam.Controls.Add(this.lblDipinjamIcon);
            this.panelDipinjam.Controls.Add(this.lblDipinjam);
            this.panelDipinjam.Controls.Add(this.lblDipinjamTitle);
            this.panelDipinjam.Location = new System.Drawing.Point(563, 80);
            this.panelDipinjam.Name = "panelDipinjam";
            this.panelDipinjam.Size = new System.Drawing.Size(234, 113);
            this.panelDipinjam.TabIndex = 5;
            // 
            // lblDipinjamIcon
            // 
            this.lblDipinjamIcon.AutoSize = true;
            this.lblDipinjamIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 26F);
            this.lblDipinjamIcon.ForeColor = System.Drawing.Color.White;
            this.lblDipinjamIcon.Location = new System.Drawing.Point(10, 10);
            this.lblDipinjamIcon.Name = "lblDipinjamIcon";
            this.lblDipinjamIcon.Size = new System.Drawing.Size(0, 69);
            this.lblDipinjamIcon.TabIndex = 0;
            // 
            // lblDipinjam
            // 
            this.lblDipinjam.AutoSize = true;
            this.lblDipinjam.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold);
            this.lblDipinjam.ForeColor = System.Drawing.Color.White;
            this.lblDipinjam.Location = new System.Drawing.Point(3, 8);
            this.lblDipinjam.Name = "lblDipinjam";
            this.lblDipinjam.Size = new System.Drawing.Size(60, 70);
            this.lblDipinjam.TabIndex = 1;
            this.lblDipinjam.Text = "0";
            // 
            // lblDipinjamTitle
            // 
            this.lblDipinjamTitle.AutoSize = true;
            this.lblDipinjamTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDipinjamTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(210)))));
            this.lblDipinjamTitle.Location = new System.Drawing.Point(42, 88);
            this.lblDipinjamTitle.Name = "lblDipinjamTitle";
            this.lblDipinjamTitle.Size = new System.Drawing.Size(148, 25);
            this.lblDipinjamTitle.TabIndex = 2;
            this.lblDipinjamTitle.Text = "Sedang Dipinjam";
            // 
            // panelDenda
            // 
            this.panelDenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panelDenda.Controls.Add(this.lblDendaIcon);
            this.panelDenda.Controls.Add(this.lblTotalDenda);
            this.panelDenda.Controls.Add(this.lblDendaTitle);
            this.panelDenda.Location = new System.Drawing.Point(813, 80);
            this.panelDenda.Name = "panelDenda";
            this.panelDenda.Size = new System.Drawing.Size(279, 113);
            this.panelDenda.TabIndex = 6;
            this.panelDenda.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDenda_Paint);
            // 
            // lblDendaIcon
            // 
            this.lblDendaIcon.AutoSize = true;
            this.lblDendaIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 26F);
            this.lblDendaIcon.ForeColor = System.Drawing.Color.White;
            this.lblDendaIcon.Location = new System.Drawing.Point(10, 10);
            this.lblDendaIcon.Name = "lblDendaIcon";
            this.lblDendaIcon.Size = new System.Drawing.Size(0, 69);
            this.lblDendaIcon.TabIndex = 0;
            // 
            // lblTotalDenda
            // 
            this.lblTotalDenda.AutoSize = true;
            this.lblTotalDenda.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTotalDenda.ForeColor = System.Drawing.Color.White;
            this.lblTotalDenda.Location = new System.Drawing.Point(3, 10);
            this.lblTotalDenda.Name = "lblTotalDenda";
            this.lblTotalDenda.Size = new System.Drawing.Size(88, 45);
            this.lblTotalDenda.TabIndex = 1;
            this.lblTotalDenda.Text = "Rp 0";
            // 
            // lblDendaTitle
            // 
            this.lblDendaTitle.AutoSize = true;
            this.lblDendaTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDendaTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.lblDendaTitle.Location = new System.Drawing.Point(92, 88);
            this.lblDendaTitle.Name = "lblDendaTitle";
            this.lblDendaTitle.Size = new System.Drawing.Size(106, 25);
            this.lblDendaTitle.TabIndex = 2;
            this.lblDendaTitle.Text = "Total Denda";
            // 
            // lblTabelJudul
            // 
            this.lblTabelJudul.AutoSize = true;
            this.lblTabelJudul.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTabelJudul.ForeColor = System.Drawing.Color.White;
            this.lblTabelJudul.Location = new System.Drawing.Point(20, 202);
            this.lblTabelJudul.Name = "lblTabelJudul";
            this.lblTabelJudul.Size = new System.Drawing.Size(208, 30);
            this.lblTabelJudul.TabIndex = 7;
            this.lblTabelJudul.Text = "  Peminjaman Aktif";
            // 
            // dgvPeminjamanAktif
            // 
            this.dgvPeminjamanAktif.AllowUserToAddRows = false;
            this.dgvPeminjamanAktif.AllowUserToDeleteRows = false;
            this.dgvPeminjamanAktif.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPeminjamanAktif.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(30)))), ((int)(((byte)(52)))));
            this.dgvPeminjamanAktif.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPeminjamanAktif.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPeminjamanAktif.ColumnHeadersHeight = 36;
            this.dgvPeminjamanAktif.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(225)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPeminjamanAktif.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPeminjamanAktif.EnableHeadersVisualStyles = false;
            this.dgvPeminjamanAktif.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(60)))), ((int)(((byte)(100)))));
            this.dgvPeminjamanAktif.Location = new System.Drawing.Point(20, 230);
            this.dgvPeminjamanAktif.Name = "dgvPeminjamanAktif";
            this.dgvPeminjamanAktif.ReadOnly = true;
            this.dgvPeminjamanAktif.RowHeadersVisible = false;
            this.dgvPeminjamanAktif.RowHeadersWidth = 62;
            this.dgvPeminjamanAktif.Size = new System.Drawing.Size(860, 275);
            this.dgvPeminjamanAktif.TabIndex = 0;
            // 
            // Fdashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1159, 540);
            this.Controls.Add(this.lblJudul);
            this.Controls.Add(this.lblTanggal);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.panelBuku);
            this.Controls.Add(this.panelAnggota);
            this.Controls.Add(this.panelDipinjam);
            this.Controls.Add(this.panelDenda);
            this.Controls.Add(this.lblTabelJudul);
            this.Controls.Add(this.dgvPeminjamanAktif);
            this.Name = "Fdashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Fdashboard_Load);
            this.panelBuku.ResumeLayout(false);
            this.panelBuku.PerformLayout();
            this.panelAnggota.ResumeLayout(false);
            this.panelAnggota.PerformLayout();
            this.panelDipinjam.ResumeLayout(false);
            this.panelDipinjam.PerformLayout();
            this.panelDenda.ResumeLayout(false);
            this.panelDenda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeminjamanAktif)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label              lblJudul;
        private System.Windows.Forms.Label              lblTanggal;
        private Guna.UI2.WinForms.Guna2Button           btnRefresh;

        private System.Windows.Forms.Panel              panelBuku;
        private System.Windows.Forms.Label              lblBukuIcon;
        private System.Windows.Forms.Label              lblBukuTitle;
        private System.Windows.Forms.Label              lblTotalBuku;

        private System.Windows.Forms.Panel              panelAnggota;
        private System.Windows.Forms.Label              lblAnggotaIcon;
        private System.Windows.Forms.Label              lblAnggotaTitle;
        private System.Windows.Forms.Label              lblTotalAnggota;

        private System.Windows.Forms.Panel              panelDipinjam;
        private System.Windows.Forms.Label              lblDipinjamIcon;
        private System.Windows.Forms.Label              lblDipinjamTitle;
        private System.Windows.Forms.Label              lblDipinjam;

        private System.Windows.Forms.Panel              panelDenda;
        private System.Windows.Forms.Label              lblDendaIcon;
        private System.Windows.Forms.Label              lblDendaTitle;
        private System.Windows.Forms.Label              lblTotalDenda;

        private System.Windows.Forms.Label              lblTabelJudul;
        private System.Windows.Forms.DataGridView       dgvPeminjamanAktif;
    }
}

namespace Projek_Perpusatakaan_XII_M_IBRAHIM
{
    partial class FTransaksi
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblPageTitle = new System.Windows.Forms.Label();
            this.lblPageSub = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPinjam = new System.Windows.Forms.TabPage();
            this.panelGridPinjam = new System.Windows.Forms.Panel();
            this.dgvPinjam = new System.Windows.Forms.DataGridView();
            this.colP1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colP2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colP3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colP4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colP5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colP6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelFormPinjam = new System.Windows.Forms.Panel();
            this.lblNamaPeminjam = new System.Windows.Forms.Label();
            this.txtNamaPeminjam = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblIdBuku = new System.Windows.Forms.Label();
            this.txtIdBuku = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnCekBuku = new Guna.UI2.WinForms.Guna2Button();
            this.lblJudulInfo = new System.Windows.Forms.Label();
            this.lblTglPinjam = new System.Windows.Forms.Label();
            this.dtpTglPinjam = new System.Windows.Forms.DateTimePicker();
            this.lblTglTempo = new System.Windows.Forms.Label();
            this.dtpTglTempo = new System.Windows.Forms.DateTimePicker();
            this.btnSimpanPinjam = new Guna.UI2.WinForms.Guna2Button();
            this.btnBersihPinjam = new Guna.UI2.WinForms.Guna2Button();
            this.tabKembali = new System.Windows.Forms.TabPage();
            this.panelGridKembali = new System.Windows.Forms.Panel();
            this.dgvKembali = new System.Windows.Forms.DataGridView();
            this.colK1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colK2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colK3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colK4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colK5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colK6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colK7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelFormKembali = new System.Windows.Forms.Panel();
            this.lblIdPinjam = new System.Windows.Forms.Label();
            this.txtIdPinjam = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnCekPinjam = new Guna.UI2.WinForms.Guna2Button();
            this.lblInfoNama = new System.Windows.Forms.Label();
            this.lblInfoBuku = new System.Windows.Forms.Label();
            this.lblInfoTempo = new System.Windows.Forms.Label();
            this.lblTglKembali = new System.Windows.Forms.Label();
            this.dtpTglKembali = new System.Windows.Forms.DateTimePicker();
            this.chkKerusakan = new System.Windows.Forms.CheckBox();
            this.btnHitung = new Guna.UI2.WinForms.Guna2Button();
            this.btnSimpanKembali = new Guna.UI2.WinForms.Guna2Button();
            this.panelTop.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPinjam.SuspendLayout();
            this.panelGridPinjam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPinjam)).BeginInit();
            this.panelFormPinjam.SuspendLayout();
            this.tabKembali.SuspendLayout();
            this.panelGridKembali.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKembali)).BeginInit();
            this.panelFormKembali.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(32)))), ((int)(((byte)(50)))));
            this.panelTop.Controls.Add(this.lblPageTitle);
            this.panelTop.Controls.Add(this.lblPageSub);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1100, 56);
            this.panelTop.TabIndex = 0;
            // 
            // lblPageTitle
            // 
            this.lblPageTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblPageTitle.ForeColor = System.Drawing.Color.White;
            this.lblPageTitle.Location = new System.Drawing.Point(11, 9);
            this.lblPageTitle.Name = "lblPageTitle";
            this.lblPageTitle.Size = new System.Drawing.Size(403, 41);
            this.lblPageTitle.TabIndex = 0;
            this.lblPageTitle.Text = "Transaksi Peminjaman Buku";
            // 
            // lblPageSub
            // 
            this.lblPageSub.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblPageSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(160)))), ((int)(((byte)(210)))));
            this.lblPageSub.Location = new System.Drawing.Point(411, 25);
            this.lblPageSub.Name = "lblPageSub";
            this.lblPageSub.Size = new System.Drawing.Size(409, 28);
            this.lblPageSub.TabIndex = 1;
            this.lblPageSub.Text = "Kelola peminjaman dan pengembalian buku";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPinjam);
            this.tabControl1.Controls.Add(this.tabKembali);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.tabControl1.Location = new System.Drawing.Point(0, 56);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1100, 544);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPinjam
            // 
            this.tabPinjam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(28)))), ((int)(((byte)(44)))));
            this.tabPinjam.Controls.Add(this.panelGridPinjam);
            this.tabPinjam.Controls.Add(this.panelFormPinjam);
            this.tabPinjam.Location = new System.Drawing.Point(4, 37);
            this.tabPinjam.Name = "tabPinjam";
            this.tabPinjam.Size = new System.Drawing.Size(1092, 503);
            this.tabPinjam.TabIndex = 0;
            this.tabPinjam.Text = "  Peminjaman  ";
            // 
            // panelGridPinjam
            // 
            this.panelGridPinjam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(28)))), ((int)(((byte)(44)))));
            this.panelGridPinjam.Controls.Add(this.dgvPinjam);
            this.panelGridPinjam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGridPinjam.Location = new System.Drawing.Point(0, 219);
            this.panelGridPinjam.Name = "panelGridPinjam";
            this.panelGridPinjam.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.panelGridPinjam.Size = new System.Drawing.Size(1092, 284);
            this.panelGridPinjam.TabIndex = 1;
            // 
            // dgvPinjam
            // 
            this.dgvPinjam.AllowUserToAddRows = false;
            this.dgvPinjam.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(32)))), ((int)(((byte)(52)))));
            this.dgvPinjam.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPinjam.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPinjam.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPinjam.ColumnHeadersHeight = 36;
            this.dgvPinjam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPinjam.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colP1,
            this.colP2,
            this.colP3,
            this.colP4,
            this.colP5,
            this.colP6});
            this.dgvPinjam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPinjam.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(55)))), ((int)(((byte)(85)))));
            this.dgvPinjam.Location = new System.Drawing.Point(10, 8);
            this.dgvPinjam.Name = "dgvPinjam";
            this.dgvPinjam.ReadOnly = true;
            this.dgvPinjam.RowHeadersVisible = false;
            this.dgvPinjam.RowHeadersWidth = 62;
            this.dgvPinjam.RowTemplate.Height = 30;
            this.dgvPinjam.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPinjam.Size = new System.Drawing.Size(1072, 268);
            this.dgvPinjam.TabIndex = 0;
            // 
            // colP1
            // 
            this.colP1.HeaderText = "ID";
            this.colP1.MinimumWidth = 8;
            this.colP1.Name = "colP1";
            this.colP1.ReadOnly = true;
            this.colP1.Width = 50;
            // 
            // colP2
            // 
            this.colP2.HeaderText = "Peminjam";
            this.colP2.MinimumWidth = 8;
            this.colP2.Name = "colP2";
            this.colP2.ReadOnly = true;
            this.colP2.Width = 180;
            // 
            // colP3
            // 
            this.colP3.HeaderText = "Judul Buku";
            this.colP3.MinimumWidth = 8;
            this.colP3.Name = "colP3";
            this.colP3.ReadOnly = true;
            this.colP3.Width = 220;
            // 
            // colP4
            // 
            this.colP4.HeaderText = "Tgl Pinjam";
            this.colP4.MinimumWidth = 8;
            this.colP4.Name = "colP4";
            this.colP4.ReadOnly = true;
            this.colP4.Width = 110;
            // 
            // colP5
            // 
            this.colP5.HeaderText = "Jatuh Tempo";
            this.colP5.MinimumWidth = 8;
            this.colP5.Name = "colP5";
            this.colP5.ReadOnly = true;
            this.colP5.Width = 110;
            // 
            // colP6
            // 
            this.colP6.HeaderText = "Status";
            this.colP6.MinimumWidth = 8;
            this.colP6.Name = "colP6";
            this.colP6.ReadOnly = true;
            this.colP6.Width = 150;
            // 
            // panelFormPinjam
            // 
            this.panelFormPinjam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(38)))), ((int)(((byte)(58)))));
            this.panelFormPinjam.Controls.Add(this.lblNamaPeminjam);
            this.panelFormPinjam.Controls.Add(this.txtNamaPeminjam);
            this.panelFormPinjam.Controls.Add(this.lblIdBuku);
            this.panelFormPinjam.Controls.Add(this.txtIdBuku);
            this.panelFormPinjam.Controls.Add(this.btnCekBuku);
            this.panelFormPinjam.Controls.Add(this.lblJudulInfo);
            this.panelFormPinjam.Controls.Add(this.lblTglPinjam);
            this.panelFormPinjam.Controls.Add(this.dtpTglPinjam);
            this.panelFormPinjam.Controls.Add(this.lblTglTempo);
            this.panelFormPinjam.Controls.Add(this.dtpTglTempo);
            this.panelFormPinjam.Controls.Add(this.btnSimpanPinjam);
            this.panelFormPinjam.Controls.Add(this.btnBersihPinjam);
            this.panelFormPinjam.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFormPinjam.Location = new System.Drawing.Point(0, 0);
            this.panelFormPinjam.Name = "panelFormPinjam";
            this.panelFormPinjam.Size = new System.Drawing.Size(1092, 219);
            this.panelFormPinjam.TabIndex = 0;
            this.panelFormPinjam.Paint += new System.Windows.Forms.PaintEventHandler(this.panelFormPinjam_Paint);
            // 
            // lblNamaPeminjam
            // 
            this.lblNamaPeminjam.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblNamaPeminjam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(230)))));
            this.lblNamaPeminjam.Location = new System.Drawing.Point(20, 11);
            this.lblNamaPeminjam.Name = "lblNamaPeminjam";
            this.lblNamaPeminjam.Size = new System.Drawing.Size(200, 19);
            this.lblNamaPeminjam.TabIndex = 0;
            this.lblNamaPeminjam.Text = "NAMA PEMINJAM";
            // 
            // txtNamaPeminjam
            // 
            this.txtNamaPeminjam.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(75)))), ((int)(((byte)(110)))));
            this.txtNamaPeminjam.BorderRadius = 8;
            this.txtNamaPeminjam.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNamaPeminjam.DefaultText = "";
            this.txtNamaPeminjam.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(75)))), ((int)(((byte)(110)))));
            this.txtNamaPeminjam.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(74)))));
            this.txtNamaPeminjam.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(120)))), ((int)(((byte)(150)))));
            this.txtNamaPeminjam.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(120)))), ((int)(((byte)(150)))));
            this.txtNamaPeminjam.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(74)))));
            this.txtNamaPeminjam.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.txtNamaPeminjam.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtNamaPeminjam.ForeColor = System.Drawing.Color.White;
            this.txtNamaPeminjam.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(130)))), ((int)(((byte)(200)))));
            this.txtNamaPeminjam.Location = new System.Drawing.Point(20, 32);
            this.txtNamaPeminjam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNamaPeminjam.Name = "txtNamaPeminjam";
            this.txtNamaPeminjam.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(115)))), ((int)(((byte)(150)))));
            this.txtNamaPeminjam.PlaceholderText = "Nama lengkap peminjam...";
            this.txtNamaPeminjam.SelectedText = "";
            this.txtNamaPeminjam.Size = new System.Drawing.Size(260, 36);
            this.txtNamaPeminjam.TabIndex = 1;
            // 
            // lblIdBuku
            // 
            this.lblIdBuku.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblIdBuku.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(230)))));
            this.lblIdBuku.Location = new System.Drawing.Point(300, 11);
            this.lblIdBuku.Name = "lblIdBuku";
            this.lblIdBuku.Size = new System.Drawing.Size(100, 19);
            this.lblIdBuku.TabIndex = 2;
            this.lblIdBuku.Text = "ID BUKU";
            // 
            // txtIdBuku
            // 
            this.txtIdBuku.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(75)))), ((int)(((byte)(110)))));
            this.txtIdBuku.BorderRadius = 8;
            this.txtIdBuku.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdBuku.DefaultText = "";
            this.txtIdBuku.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(75)))), ((int)(((byte)(110)))));
            this.txtIdBuku.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(74)))));
            this.txtIdBuku.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(120)))), ((int)(((byte)(150)))));
            this.txtIdBuku.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(120)))), ((int)(((byte)(150)))));
            this.txtIdBuku.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(74)))));
            this.txtIdBuku.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.txtIdBuku.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtIdBuku.ForeColor = System.Drawing.Color.White;
            this.txtIdBuku.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(130)))), ((int)(((byte)(200)))));
            this.txtIdBuku.Location = new System.Drawing.Point(300, 32);
            this.txtIdBuku.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIdBuku.Name = "txtIdBuku";
            this.txtIdBuku.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(115)))), ((int)(((byte)(150)))));
            this.txtIdBuku.PlaceholderText = "ID...";
            this.txtIdBuku.SelectedText = "";
            this.txtIdBuku.Size = new System.Drawing.Size(80, 36);
            this.txtIdBuku.TabIndex = 3;
            // 
            // btnCekBuku
            // 
            this.btnCekBuku.Animated = true;
            this.btnCekBuku.BorderRadius = 8;
            this.btnCekBuku.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCekBuku.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCekBuku.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this.btnCekBuku.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.btnCekBuku.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(90)))));
            this.btnCekBuku.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCekBuku.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(200)))), ((int)(((byte)(230)))));
            this.btnCekBuku.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(115)))));
            this.btnCekBuku.Location = new System.Drawing.Point(390, 32);
            this.btnCekBuku.Name = "btnCekBuku";
            this.btnCekBuku.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(78)))));
            this.btnCekBuku.Size = new System.Drawing.Size(70, 36);
            this.btnCekBuku.TabIndex = 4;
            this.btnCekBuku.Text = "Cek";
            this.btnCekBuku.Click += new System.EventHandler(this.btnCekBuku_Click);
            // 
            // lblJudulInfo
            // 
            this.lblJudulInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblJudulInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(200)))), ((int)(((byte)(120)))));
            this.lblJudulInfo.Location = new System.Drawing.Point(470, 38);
            this.lblJudulInfo.Name = "lblJudulInfo";
            this.lblJudulInfo.Size = new System.Drawing.Size(500, 24);
            this.lblJudulInfo.TabIndex = 5;
            // 
            // lblTglPinjam
            // 
            this.lblTglPinjam.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblTglPinjam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(230)))));
            this.lblTglPinjam.Location = new System.Drawing.Point(20, 80);
            this.lblTglPinjam.Name = "lblTglPinjam";
            this.lblTglPinjam.Size = new System.Drawing.Size(200, 26);
            this.lblTglPinjam.TabIndex = 6;
            this.lblTglPinjam.Text = "TANGGAL PINJAM";
            // 
            // dtpTglPinjam
            // 
            this.dtpTglPinjam.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dtpTglPinjam.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTglPinjam.Location = new System.Drawing.Point(20, 127);
            this.dtpTglPinjam.Name = "dtpTglPinjam";
            this.dtpTglPinjam.Size = new System.Drawing.Size(170, 33);
            this.dtpTglPinjam.TabIndex = 7;
            this.dtpTglPinjam.Value = new System.DateTime(2026, 9, 5, 12, 13, 59, 380);
            // 
            // lblTglTempo
            // 
            this.lblTglTempo.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblTglTempo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(230)))));
            this.lblTglTempo.Location = new System.Drawing.Point(226, 80);
            this.lblTglTempo.Name = "lblTglTempo";
            this.lblTglTempo.Size = new System.Drawing.Size(202, 26);
            this.lblTglTempo.TabIndex = 8;
            this.lblTglTempo.Text = "TANGGAL JATUH TEMPO";
            // 
            // dtpTglTempo
            // 
            this.dtpTglTempo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dtpTglTempo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTglTempo.Location = new System.Drawing.Point(230, 127);
            this.dtpTglTempo.Name = "dtpTglTempo";
            this.dtpTglTempo.Size = new System.Drawing.Size(170, 33);
            this.dtpTglTempo.TabIndex = 9;
            this.dtpTglTempo.Value = new System.DateTime(2026, 9, 12, 12, 13, 59, 386);
            // 
            // btnSimpanPinjam
            // 
            this.btnSimpanPinjam.Animated = true;
            this.btnSimpanPinjam.BackColor = System.Drawing.Color.Transparent;
            this.btnSimpanPinjam.BorderRadius = 8;
            this.btnSimpanPinjam.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSimpanPinjam.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSimpanPinjam.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this.btnSimpanPinjam.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.btnSimpanPinjam.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnSimpanPinjam.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSimpanPinjam.ForeColor = System.Drawing.Color.White;
            this.btnSimpanPinjam.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.btnSimpanPinjam.Location = new System.Drawing.Point(24, 175);
            this.btnSimpanPinjam.Name = "btnSimpanPinjam";
            this.btnSimpanPinjam.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(78)))), ((int)(((byte)(216)))));
            this.btnSimpanPinjam.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnSimpanPinjam.ShadowDecoration.Depth = 4;
            this.btnSimpanPinjam.ShadowDecoration.Enabled = true;
            this.btnSimpanPinjam.Size = new System.Drawing.Size(140, 38);
            this.btnSimpanPinjam.TabIndex = 10;
            this.btnSimpanPinjam.Text = "Simpan Pinjam";
            this.btnSimpanPinjam.Click += new System.EventHandler(this.btnSimpanPinjam_Click);
            // 
            // btnBersihPinjam
            // 
            this.btnBersihPinjam.Animated = true;
            this.btnBersihPinjam.BorderRadius = 8;
            this.btnBersihPinjam.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBersihPinjam.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBersihPinjam.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this.btnBersihPinjam.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.btnBersihPinjam.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(90)))));
            this.btnBersihPinjam.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnBersihPinjam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(200)))), ((int)(((byte)(230)))));
            this.btnBersihPinjam.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(115)))));
            this.btnBersihPinjam.Location = new System.Drawing.Point(238, 175);
            this.btnBersihPinjam.Name = "btnBersihPinjam";
            this.btnBersihPinjam.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(78)))));
            this.btnBersihPinjam.Size = new System.Drawing.Size(120, 38);
            this.btnBersihPinjam.TabIndex = 11;
            this.btnBersihPinjam.Text = "Bersihkan";
            this.btnBersihPinjam.Click += new System.EventHandler(this.btnBersihPinjam_Click);
            // 
            // tabKembali
            // 
            this.tabKembali.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(28)))), ((int)(((byte)(44)))));
            this.tabKembali.Controls.Add(this.panelGridKembali);
            this.tabKembali.Controls.Add(this.panelFormKembali);
            this.tabKembali.Location = new System.Drawing.Point(4, 37);
            this.tabKembali.Name = "tabKembali";
            this.tabKembali.Size = new System.Drawing.Size(1092, 503);
            this.tabKembali.TabIndex = 1;
            this.tabKembali.Text = "  Pengembalian  ";
            // 
            // panelGridKembali
            // 
            this.panelGridKembali.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(28)))), ((int)(((byte)(44)))));
            this.panelGridKembali.Controls.Add(this.dgvKembali);
            this.panelGridKembali.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGridKembali.Location = new System.Drawing.Point(0, 210);
            this.panelGridKembali.Name = "panelGridKembali";
            this.panelGridKembali.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.panelGridKembali.Size = new System.Drawing.Size(1092, 293);
            this.panelGridKembali.TabIndex = 1;
            // 
            // dgvKembali
            // 
            this.dgvKembali.AllowUserToAddRows = false;
            this.dgvKembali.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(32)))), ((int)(((byte)(52)))));
            this.dgvKembali.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvKembali.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvKembali.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvKembali.ColumnHeadersHeight = 36;
            this.dgvKembali.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvKembali.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colK1,
            this.colK2,
            this.colK3,
            this.colK4,
            this.colK5,
            this.colK6,
            this.colK7});
            this.dgvKembali.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKembali.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(55)))), ((int)(((byte)(85)))));
            this.dgvKembali.Location = new System.Drawing.Point(10, 8);
            this.dgvKembali.Name = "dgvKembali";
            this.dgvKembali.ReadOnly = true;
            this.dgvKembali.RowHeadersVisible = false;
            this.dgvKembali.RowHeadersWidth = 62;
            this.dgvKembali.RowTemplate.Height = 30;
            this.dgvKembali.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKembali.Size = new System.Drawing.Size(1072, 277);
            this.dgvKembali.TabIndex = 0;
            this.dgvKembali.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKembali_CellClick);
            // 
            // colK1
            // 
            this.colK1.HeaderText = "ID";
            this.colK1.MinimumWidth = 8;
            this.colK1.Name = "colK1";
            this.colK1.ReadOnly = true;
            this.colK1.Width = 50;
            // 
            // colK2
            // 
            this.colK2.HeaderText = "Peminjam";
            this.colK2.MinimumWidth = 8;
            this.colK2.Name = "colK2";
            this.colK2.ReadOnly = true;
            this.colK2.Width = 160;
            // 
            // colK3
            // 
            this.colK3.HeaderText = "Judul Buku";
            this.colK3.MinimumWidth = 8;
            this.colK3.Name = "colK3";
            this.colK3.ReadOnly = true;
            this.colK3.Width = 200;
            // 
            // colK4
            // 
            this.colK4.HeaderText = "Tgl Pinjam";
            this.colK4.MinimumWidth = 8;
            this.colK4.Name = "colK4";
            this.colK4.ReadOnly = true;
            this.colK4.Width = 150;
            // 
            // colK5
            // 
            this.colK5.HeaderText = "Jatuh Tempo";
            this.colK5.MinimumWidth = 8;
            this.colK5.Name = "colK5";
            this.colK5.ReadOnly = true;
            this.colK5.Width = 150;
            // 
            // colK6
            // 
            this.colK6.HeaderText = "Denda";
            this.colK6.MinimumWidth = 8;
            this.colK6.Name = "colK6";
            this.colK6.ReadOnly = true;
            this.colK6.Width = 150;
            // 
            // colK7
            // 
            this.colK7.HeaderText = "Status";
            this.colK7.MinimumWidth = 8;
            this.colK7.Name = "colK7";
            this.colK7.ReadOnly = true;
            this.colK7.Width = 150;
            // 
            // panelFormKembali
            // 
            this.panelFormKembali.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(38)))), ((int)(((byte)(58)))));
            this.panelFormKembali.Controls.Add(this.lblIdPinjam);
            this.panelFormKembali.Controls.Add(this.txtIdPinjam);
            this.panelFormKembali.Controls.Add(this.btnCekPinjam);
            this.panelFormKembali.Controls.Add(this.lblInfoNama);
            this.panelFormKembali.Controls.Add(this.lblInfoBuku);
            this.panelFormKembali.Controls.Add(this.lblInfoTempo);
            this.panelFormKembali.Controls.Add(this.lblTglKembali);
            this.panelFormKembali.Controls.Add(this.dtpTglKembali);
            this.panelFormKembali.Controls.Add(this.chkKerusakan);
            this.panelFormKembali.Controls.Add(this.btnHitung);
            this.panelFormKembali.Controls.Add(this.btnSimpanKembali);
            this.panelFormKembali.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFormKembali.Location = new System.Drawing.Point(0, 0);
            this.panelFormKembali.Name = "panelFormKembali";
            this.panelFormKembali.Size = new System.Drawing.Size(1092, 210);
            this.panelFormKembali.TabIndex = 0;
            // 
            // lblIdPinjam
            // 
            this.lblIdPinjam.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblIdPinjam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(230)))));
            this.lblIdPinjam.Location = new System.Drawing.Point(20, 14);
            this.lblIdPinjam.Name = "lblIdPinjam";
            this.lblIdPinjam.Size = new System.Drawing.Size(160, 16);
            this.lblIdPinjam.TabIndex = 0;
            this.lblIdPinjam.Text = "ID PEMINJAMAN";
            // 
            // txtIdPinjam
            // 
            this.txtIdPinjam.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(75)))), ((int)(((byte)(110)))));
            this.txtIdPinjam.BorderRadius = 8;
            this.txtIdPinjam.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdPinjam.DefaultText = "";
            this.txtIdPinjam.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(75)))), ((int)(((byte)(110)))));
            this.txtIdPinjam.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(74)))));
            this.txtIdPinjam.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(120)))), ((int)(((byte)(150)))));
            this.txtIdPinjam.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(120)))), ((int)(((byte)(150)))));
            this.txtIdPinjam.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(74)))));
            this.txtIdPinjam.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.txtIdPinjam.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtIdPinjam.ForeColor = System.Drawing.Color.White;
            this.txtIdPinjam.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(130)))), ((int)(((byte)(200)))));
            this.txtIdPinjam.Location = new System.Drawing.Point(20, 32);
            this.txtIdPinjam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIdPinjam.Name = "txtIdPinjam";
            this.txtIdPinjam.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(115)))), ((int)(((byte)(150)))));
            this.txtIdPinjam.PlaceholderText = "Masukkan ID...";
            this.txtIdPinjam.SelectedText = "";
            this.txtIdPinjam.Size = new System.Drawing.Size(100, 36);
            this.txtIdPinjam.TabIndex = 1;
            // 
            // btnCekPinjam
            // 
            this.btnCekPinjam.Animated = true;
            this.btnCekPinjam.BorderRadius = 8;
            this.btnCekPinjam.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCekPinjam.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCekPinjam.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this.btnCekPinjam.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.btnCekPinjam.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(90)))));
            this.btnCekPinjam.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCekPinjam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(200)))), ((int)(((byte)(230)))));
            this.btnCekPinjam.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(115)))));
            this.btnCekPinjam.Location = new System.Drawing.Point(130, 32);
            this.btnCekPinjam.Name = "btnCekPinjam";
            this.btnCekPinjam.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(78)))));
            this.btnCekPinjam.Size = new System.Drawing.Size(70, 36);
            this.btnCekPinjam.TabIndex = 2;
            this.btnCekPinjam.Text = "Cek";
            this.btnCekPinjam.Click += new System.EventHandler(this.btnCekPinjam_Click);
            // 
            // lblInfoNama
            // 
            this.lblInfoNama.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblInfoNama.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(200)))), ((int)(((byte)(230)))));
            this.lblInfoNama.Location = new System.Drawing.Point(220, 14);
            this.lblInfoNama.Name = "lblInfoNama";
            this.lblInfoNama.Size = new System.Drawing.Size(400, 20);
            this.lblInfoNama.TabIndex = 3;
            this.lblInfoNama.Text = "Peminjam  : -";
            // 
            // lblInfoBuku
            // 
            this.lblInfoBuku.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblInfoBuku.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(200)))), ((int)(((byte)(230)))));
            this.lblInfoBuku.Location = new System.Drawing.Point(220, 36);
            this.lblInfoBuku.Name = "lblInfoBuku";
            this.lblInfoBuku.Size = new System.Drawing.Size(400, 20);
            this.lblInfoBuku.TabIndex = 4;
            this.lblInfoBuku.Text = "Buku       : -";
            // 
            // lblInfoTempo
            // 
            this.lblInfoTempo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblInfoTempo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(60)))));
            this.lblInfoTempo.Location = new System.Drawing.Point(220, 58);
            this.lblInfoTempo.Name = "lblInfoTempo";
            this.lblInfoTempo.Size = new System.Drawing.Size(400, 20);
            this.lblInfoTempo.TabIndex = 5;
            this.lblInfoTempo.Text = "Jatuh Tempo: -";
            // 
            // lblTglKembali
            // 
            this.lblTglKembali.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblTglKembali.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(230)))));
            this.lblTglKembali.Location = new System.Drawing.Point(20, 82);
            this.lblTglKembali.Name = "lblTglKembali";
            this.lblTglKembali.Size = new System.Drawing.Size(200, 16);
            this.lblTglKembali.TabIndex = 6;
            this.lblTglKembali.Text = "TGL KEMBALI AKTUAL";
            // 
            // dtpTglKembali
            // 
            this.dtpTglKembali.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dtpTglKembali.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTglKembali.Location = new System.Drawing.Point(20, 100);
            this.dtpTglKembali.Name = "dtpTglKembali";
            this.dtpTglKembali.Size = new System.Drawing.Size(170, 33);
            this.dtpTglKembali.TabIndex = 7;
            this.dtpTglKembali.Value = new System.DateTime(2026, 9, 5, 12, 13, 59, 524);
            // 
            // chkKerusakan
            // 
            this.chkKerusakan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkKerusakan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(210)))), ((int)(((byte)(230)))));
            this.chkKerusakan.Location = new System.Drawing.Point(210, 100);
            this.chkKerusakan.Name = "chkKerusakan";
            this.chkKerusakan.Size = new System.Drawing.Size(230, 24);
            this.chkKerusakan.TabIndex = 8;
            this.chkKerusakan.Text = "Ada kerusakan buku (+Rp 20.000)";
            // 
            // btnHitung
            // 
            this.btnHitung.Animated = true;
            this.btnHitung.BackColor = System.Drawing.Color.Transparent;
            this.btnHitung.BorderRadius = 8;
            this.btnHitung.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHitung.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHitung.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this.btnHitung.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.btnHitung.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(83)))), ((int)(((byte)(9)))));
            this.btnHitung.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnHitung.ForeColor = System.Drawing.Color.White;
            this.btnHitung.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(119)))), ((int)(((byte)(6)))));
            this.btnHitung.Location = new System.Drawing.Point(20, 162);
            this.btnHitung.Name = "btnHitung";
            this.btnHitung.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(64)))), ((int)(((byte)(14)))));
            this.btnHitung.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))), ((int)(((byte)(9)))));
            this.btnHitung.ShadowDecoration.Depth = 4;
            this.btnHitung.ShadowDecoration.Enabled = true;
            this.btnHitung.Size = new System.Drawing.Size(140, 38);
            this.btnHitung.TabIndex = 11;
            this.btnHitung.Text = "Hitung Denda";
            this.btnHitung.Click += new System.EventHandler(this.btnHitung_Click);
            // 
            // btnSimpanKembali
            // 
            this.btnSimpanKembali.Animated = true;
            this.btnSimpanKembali.BackColor = System.Drawing.Color.Transparent;
            this.btnSimpanKembali.BorderRadius = 8;
            this.btnSimpanKembali.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSimpanKembali.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSimpanKembali.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this.btnSimpanKembali.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.btnSimpanKembali.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(128)))), ((int)(((byte)(61)))));
            this.btnSimpanKembali.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSimpanKembali.ForeColor = System.Drawing.Color.White;
            this.btnSimpanKembali.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(163)))), ((int)(((byte)(74)))));
            this.btnSimpanKembali.Location = new System.Drawing.Point(170, 162);
            this.btnSimpanKembali.Name = "btnSimpanKembali";
            this.btnSimpanKembali.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(83)))), ((int)(((byte)(45)))));
            this.btnSimpanKembali.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(21)))), ((int)(((byte)(128)))), ((int)(((byte)(61)))));
            this.btnSimpanKembali.ShadowDecoration.Depth = 4;
            this.btnSimpanKembali.ShadowDecoration.Enabled = true;
            this.btnSimpanKembali.Size = new System.Drawing.Size(150, 38);
            this.btnSimpanKembali.TabIndex = 12;
            this.btnSimpanKembali.Text = "Simpan Kembali";
            this.btnSimpanKembali.Click += new System.EventHandler(this.btnSimpanKembali_Click);
            // 
            // FTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(28)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panelTop);
            this.Name = "FTransaksi";
            this.Text = "Transaksi";
            this.Load += new System.EventHandler(this.FTransaksi_Load);
            this.panelTop.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPinjam.ResumeLayout(false);
            this.panelGridPinjam.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPinjam)).EndInit();
            this.panelFormPinjam.ResumeLayout(false);
            this.tabKembali.ResumeLayout(false);
            this.panelGridKembali.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKembali)).EndInit();
            this.panelFormKembali.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblPageTitle;
        private System.Windows.Forms.Label lblPageSub;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPinjam;
        private System.Windows.Forms.Panel panelFormPinjam;
        private System.Windows.Forms.Label lblNamaPeminjam;
        private Guna.UI2.WinForms.Guna2TextBox txtNamaPeminjam;
        private System.Windows.Forms.Label lblIdBuku;
        private Guna.UI2.WinForms.Guna2TextBox txtIdBuku;
        private Guna.UI2.WinForms.Guna2Button btnCekBuku;
        private System.Windows.Forms.Label lblJudulInfo;
        private System.Windows.Forms.Label lblTglPinjam;
        private System.Windows.Forms.DateTimePicker dtpTglPinjam;
        private System.Windows.Forms.Label lblTglTempo;
        private System.Windows.Forms.DateTimePicker dtpTglTempo;
        private Guna.UI2.WinForms.Guna2Button btnSimpanPinjam;
        private Guna.UI2.WinForms.Guna2Button btnBersihPinjam;
        private System.Windows.Forms.Panel panelGridPinjam;
        private System.Windows.Forms.DataGridView dgvPinjam;
        private System.Windows.Forms.DataGridViewTextBoxColumn colP1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colP2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colP3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colP4;
        private System.Windows.Forms.DataGridViewTextBoxColumn colP5;
        private System.Windows.Forms.DataGridViewTextBoxColumn colP6;
        private System.Windows.Forms.TabPage tabKembali;
        private System.Windows.Forms.Panel panelFormKembali;
        private System.Windows.Forms.Label lblIdPinjam;
        private Guna.UI2.WinForms.Guna2TextBox txtIdPinjam;
        private Guna.UI2.WinForms.Guna2Button btnCekPinjam;
        private System.Windows.Forms.Label lblInfoNama;
        private System.Windows.Forms.Label lblInfoBuku;
        private System.Windows.Forms.Label lblInfoTempo;
        private System.Windows.Forms.Label lblTglKembali;
        private System.Windows.Forms.DateTimePicker dtpTglKembali;
        private System.Windows.Forms.CheckBox chkKerusakan;
        private Guna.UI2.WinForms.Guna2Button btnHitung;
        private Guna.UI2.WinForms.Guna2Button btnSimpanKembali;
        private System.Windows.Forms.Panel panelGridKembali;
        private System.Windows.Forms.DataGridView dgvKembali;
        private System.Windows.Forms.DataGridViewTextBoxColumn colK1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colK2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colK3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colK4;
        private System.Windows.Forms.DataGridViewTextBoxColumn colK5;
        private System.Windows.Forms.DataGridViewTextBoxColumn colK6;
        private System.Windows.Forms.DataGridViewTextBoxColumn colK7;
    }
}


namespace Projek_Perpusatakaan_XII_M_IBRAHIM
{
    partial class FBuku
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
            this.panelForm = new System.Windows.Forms.Panel();
            this.lblJudul = new System.Windows.Forms.Label();
            this.txtjudul = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblPengarang = new System.Windows.Forms.Label();
            this.txtpengarang = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblPenerbit = new System.Windows.Forms.Label();
            this.txtpenerbit = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTahun = new System.Windows.Forms.Label();
            this.txttahun = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblStok = new System.Windows.Forms.Label();
            this.txtstok = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblKategori = new System.Windows.Forms.Label();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblHiddenId = new System.Windows.Forms.Label();
            this.btnSimpan = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.btnHapus = new Guna.UI2.WinForms.Guna2Button();
            this.btnTampil = new Guna.UI2.WinForms.Guna2Button();
            this.btnBersih = new Guna.UI2.WinForms.Guna2Button();
            this.panelGrid = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panelTop.SuspendLayout();
            this.panelForm.SuspendLayout();
            this.panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(32)))), ((int)(((byte)(50)))));
            this.panelTop.Controls.Add(this.lblPageTitle);
            this.panelTop.Controls.Add(this.lblPageSub);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(4);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1414, 75);
            this.panelTop.TabIndex = 0;
            // 
            // lblPageTitle
            // 
            this.lblPageTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblPageTitle.ForeColor = System.Drawing.Color.White;
            this.lblPageTitle.Location = new System.Drawing.Point(26, 11);
            this.lblPageTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPageTitle.Name = "lblPageTitle";
            this.lblPageTitle.Size = new System.Drawing.Size(437, 32);
            this.lblPageTitle.TabIndex = 0;
            this.lblPageTitle.Text = "Manajemen Data Buku";
            // 
            // lblPageSub
            // 
            this.lblPageSub.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblPageSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(160)))), ((int)(((byte)(210)))));
            this.lblPageSub.Location = new System.Drawing.Point(28, 45);
            this.lblPageSub.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPageSub.Name = "lblPageSub";
            this.lblPageSub.Size = new System.Drawing.Size(463, 21);
            this.lblPageSub.TabIndex = 1;
            this.lblPageSub.Text = "Tambah, ubah, dan hapus data buku perpustakaan";
            // 
            // panelForm
            // 
            this.panelForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(38)))), ((int)(((byte)(58)))));
            this.panelForm.Controls.Add(this.lblJudul);
            this.panelForm.Controls.Add(this.txtjudul);
            this.panelForm.Controls.Add(this.lblPengarang);
            this.panelForm.Controls.Add(this.txtpengarang);
            this.panelForm.Controls.Add(this.lblPenerbit);
            this.panelForm.Controls.Add(this.txtpenerbit);
            this.panelForm.Controls.Add(this.lblTahun);
            this.panelForm.Controls.Add(this.txttahun);
            this.panelForm.Controls.Add(this.lblStok);
            this.panelForm.Controls.Add(this.txtstok);
            this.panelForm.Controls.Add(this.lblKategori);
            this.panelForm.Controls.Add(this.guna2TextBox1);
            this.panelForm.Controls.Add(this.lblHiddenId);
            this.panelForm.Controls.Add(this.btnSimpan);
            this.panelForm.Controls.Add(this.btnUpdate);
            this.panelForm.Controls.Add(this.btnHapus);
            this.panelForm.Controls.Add(this.btnTampil);
            this.panelForm.Controls.Add(this.btnBersih);
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelForm.Location = new System.Drawing.Point(0, 75);
            this.panelForm.Margin = new System.Windows.Forms.Padding(4);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(1414, 293);
            this.panelForm.TabIndex = 1;
            // 
            // lblJudul
            // 
            this.lblJudul.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblJudul.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(230)))));
            this.lblJudul.Location = new System.Drawing.Point(51, 27);
            this.lblJudul.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(257, 21);
            this.lblJudul.TabIndex = 0;
            this.lblJudul.Text = "JUDUL BUKU";
            // 
            // txtjudul
            // 
            this.txtjudul.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(75)))), ((int)(((byte)(110)))));
            this.txtjudul.BorderRadius = 8;
            this.txtjudul.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtjudul.DefaultText = "";
            this.txtjudul.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(75)))), ((int)(((byte)(110)))));
            this.txtjudul.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(74)))));
            this.txtjudul.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(120)))), ((int)(((byte)(150)))));
            this.txtjudul.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(120)))), ((int)(((byte)(150)))));
            this.txtjudul.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(74)))));
            this.txtjudul.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.txtjudul.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtjudul.ForeColor = System.Drawing.Color.White;
            this.txtjudul.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(130)))), ((int)(((byte)(200)))));
            this.txtjudul.Location = new System.Drawing.Point(51, 51);
            this.txtjudul.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txtjudul.Name = "txtjudul";
            this.txtjudul.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(115)))), ((int)(((byte)(150)))));
            this.txtjudul.PlaceholderText = "Masukkan judul buku...";
            this.txtjudul.SelectedText = "";
            this.txtjudul.Size = new System.Drawing.Size(373, 48);
            this.txtjudul.TabIndex = 1;
            // 
            // lblPengarang
            // 
            this.lblPengarang.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblPengarang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(230)))));
            this.lblPengarang.Location = new System.Drawing.Point(51, 109);
            this.lblPengarang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPengarang.Name = "lblPengarang";
            this.lblPengarang.Size = new System.Drawing.Size(257, 21);
            this.lblPengarang.TabIndex = 2;
            this.lblPengarang.Text = "PENGARANG";
            // 
            // txtpengarang
            // 
            this.txtpengarang.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(75)))), ((int)(((byte)(110)))));
            this.txtpengarang.BorderRadius = 8;
            this.txtpengarang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpengarang.DefaultText = "";
            this.txtpengarang.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(75)))), ((int)(((byte)(110)))));
            this.txtpengarang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(74)))));
            this.txtpengarang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(120)))), ((int)(((byte)(150)))));
            this.txtpengarang.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(120)))), ((int)(((byte)(150)))));
            this.txtpengarang.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(74)))));
            this.txtpengarang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.txtpengarang.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtpengarang.ForeColor = System.Drawing.Color.White;
            this.txtpengarang.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(130)))), ((int)(((byte)(200)))));
            this.txtpengarang.Location = new System.Drawing.Point(51, 133);
            this.txtpengarang.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txtpengarang.Name = "txtpengarang";
            this.txtpengarang.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(115)))), ((int)(((byte)(150)))));
            this.txtpengarang.PlaceholderText = "Nama pengarang...";
            this.txtpengarang.SelectedText = "";
            this.txtpengarang.Size = new System.Drawing.Size(373, 48);
            this.txtpengarang.TabIndex = 3;
            // 
            // lblPenerbit
            // 
            this.lblPenerbit.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblPenerbit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(230)))));
            this.lblPenerbit.Location = new System.Drawing.Point(51, 192);
            this.lblPenerbit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPenerbit.Name = "lblPenerbit";
            this.lblPenerbit.Size = new System.Drawing.Size(257, 21);
            this.lblPenerbit.TabIndex = 4;
            this.lblPenerbit.Text = "PENERBIT";
            // 
            // txtpenerbit
            // 
            this.txtpenerbit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(75)))), ((int)(((byte)(110)))));
            this.txtpenerbit.BorderRadius = 8;
            this.txtpenerbit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpenerbit.DefaultText = "";
            this.txtpenerbit.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(75)))), ((int)(((byte)(110)))));
            this.txtpenerbit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(74)))));
            this.txtpenerbit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(120)))), ((int)(((byte)(150)))));
            this.txtpenerbit.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(120)))), ((int)(((byte)(150)))));
            this.txtpenerbit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(74)))));
            this.txtpenerbit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.txtpenerbit.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtpenerbit.ForeColor = System.Drawing.Color.White;
            this.txtpenerbit.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(130)))), ((int)(((byte)(200)))));
            this.txtpenerbit.Location = new System.Drawing.Point(51, 216);
            this.txtpenerbit.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txtpenerbit.Name = "txtpenerbit";
            this.txtpenerbit.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(115)))), ((int)(((byte)(150)))));
            this.txtpenerbit.PlaceholderText = "Nama penerbit...";
            this.txtpenerbit.SelectedText = "";
            this.txtpenerbit.Size = new System.Drawing.Size(373, 48);
            this.txtpenerbit.TabIndex = 5;
            this.txtpenerbit.TextChanged += new System.EventHandler(this.txtpenerbit_TextChanged);
            // 
            // lblTahun
            // 
            this.lblTahun.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblTahun.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(230)))));
            this.lblTahun.Location = new System.Drawing.Point(463, 27);
            this.lblTahun.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTahun.Name = "lblTahun";
            this.lblTahun.Size = new System.Drawing.Size(257, 21);
            this.lblTahun.TabIndex = 6;
            this.lblTahun.Text = "TAHUN TERBIT";
            // 
            // txttahun
            // 
            this.txttahun.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(75)))), ((int)(((byte)(110)))));
            this.txttahun.BorderRadius = 8;
            this.txttahun.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txttahun.DefaultText = "";
            this.txttahun.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(75)))), ((int)(((byte)(110)))));
            this.txttahun.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(74)))));
            this.txttahun.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(120)))), ((int)(((byte)(150)))));
            this.txttahun.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(120)))), ((int)(((byte)(150)))));
            this.txttahun.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(74)))));
            this.txttahun.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.txttahun.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txttahun.ForeColor = System.Drawing.Color.White;
            this.txttahun.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(130)))), ((int)(((byte)(200)))));
            this.txttahun.Location = new System.Drawing.Point(463, 51);
            this.txttahun.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txttahun.Name = "txttahun";
            this.txttahun.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(115)))), ((int)(((byte)(150)))));
            this.txttahun.PlaceholderText = "Contoh: 2023";
            this.txttahun.SelectedText = "";
            this.txttahun.Size = new System.Drawing.Size(373, 48);
            this.txttahun.TabIndex = 7;
            // 
            // lblStok
            // 
            this.lblStok.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblStok.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(230)))));
            this.lblStok.Location = new System.Drawing.Point(463, 109);
            this.lblStok.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStok.Name = "lblStok";
            this.lblStok.Size = new System.Drawing.Size(257, 21);
            this.lblStok.TabIndex = 8;
            this.lblStok.Text = "STOK BUKU";
            // 
            // txtstok
            // 
            this.txtstok.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(75)))), ((int)(((byte)(110)))));
            this.txtstok.BorderRadius = 8;
            this.txtstok.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtstok.DefaultText = "";
            this.txtstok.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(75)))), ((int)(((byte)(110)))));
            this.txtstok.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(74)))));
            this.txtstok.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(120)))), ((int)(((byte)(150)))));
            this.txtstok.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(120)))), ((int)(((byte)(150)))));
            this.txtstok.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(74)))));
            this.txtstok.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.txtstok.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtstok.ForeColor = System.Drawing.Color.White;
            this.txtstok.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(130)))), ((int)(((byte)(200)))));
            this.txtstok.Location = new System.Drawing.Point(463, 133);
            this.txtstok.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txtstok.Name = "txtstok";
            this.txtstok.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(115)))), ((int)(((byte)(150)))));
            this.txtstok.PlaceholderText = "Jumlah stok...";
            this.txtstok.SelectedText = "";
            this.txtstok.Size = new System.Drawing.Size(373, 48);
            this.txtstok.TabIndex = 9;
            // 
            // lblKategori
            // 
            this.lblKategori.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblKategori.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(230)))));
            this.lblKategori.Location = new System.Drawing.Point(463, 192);
            this.lblKategori.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(257, 21);
            this.lblKategori.TabIndex = 10;
            this.lblKategori.Text = "ID KATEGORI";
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(75)))), ((int)(((byte)(110)))));
            this.guna2TextBox1.BorderRadius = 8;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(75)))), ((int)(((byte)(110)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(74)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(120)))), ((int)(((byte)(150)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(120)))), ((int)(((byte)(150)))));
            this.guna2TextBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(74)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.guna2TextBox1.ForeColor = System.Drawing.Color.White;
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(130)))), ((int)(((byte)(200)))));
            this.guna2TextBox1.Location = new System.Drawing.Point(463, 216);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(115)))), ((int)(((byte)(150)))));
            this.guna2TextBox1.PlaceholderText = "ID kategori...";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(373, 48);
            this.guna2TextBox1.TabIndex = 11;
            // 
            // lblHiddenId
            // 
            this.lblHiddenId.Location = new System.Drawing.Point(0, 0);
            this.lblHiddenId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHiddenId.Name = "lblHiddenId";
            this.lblHiddenId.Size = new System.Drawing.Size(1, 1);
            this.lblHiddenId.TabIndex = 12;
            this.lblHiddenId.Visible = false;
            // 
            // btnSimpan
            // 
            this.btnSimpan.Animated = true;
            this.btnSimpan.BackColor = System.Drawing.Color.Transparent;
            this.btnSimpan.BorderRadius = 8;
            this.btnSimpan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSimpan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSimpan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this.btnSimpan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.btnSimpan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnSimpan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSimpan.ForeColor = System.Drawing.Color.White;
            this.btnSimpan.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.btnSimpan.Location = new System.Drawing.Point(850, 36);
            this.btnSimpan.Margin = new System.Windows.Forms.Padding(4);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(78)))), ((int)(((byte)(216)))));
            this.btnSimpan.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnSimpan.ShadowDecoration.Depth = 4;
            this.btnSimpan.ShadowDecoration.Enabled = true;
            this.btnSimpan.Size = new System.Drawing.Size(154, 51);
            this.btnSimpan.TabIndex = 13;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Animated = true;
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.BorderRadius = 8;
            this.btnUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this.btnUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.btnUpdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(83)))), ((int)(((byte)(9)))));
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(119)))), ((int)(((byte)(6)))));
            this.btnUpdate.Location = new System.Drawing.Point(1012, 36);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(64)))), ((int)(((byte)(14)))));
            this.btnUpdate.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))), ((int)(((byte)(9)))));
            this.btnUpdate.ShadowDecoration.Depth = 4;
            this.btnUpdate.ShadowDecoration.Enabled = true;
            this.btnUpdate.Size = new System.Drawing.Size(154, 51);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.Animated = true;
            this.btnHapus.BackColor = System.Drawing.Color.Transparent;
            this.btnHapus.BorderRadius = 8;
            this.btnHapus.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHapus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHapus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this.btnHapus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.btnHapus.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnHapus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnHapus.ForeColor = System.Drawing.Color.White;
            this.btnHapus.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnHapus.Location = new System.Drawing.Point(1012, 95);
            this.btnHapus.Margin = new System.Windows.Forms.Padding(4);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.btnHapus.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(153)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnHapus.ShadowDecoration.Depth = 4;
            this.btnHapus.ShadowDecoration.Enabled = true;
            this.btnHapus.Size = new System.Drawing.Size(154, 51);
            this.btnHapus.TabIndex = 15;
            this.btnHapus.Text = "Hapus";
            // 
            // btnTampil
            // 
            this.btnTampil.Animated = true;
            this.btnTampil.BackColor = System.Drawing.Color.Transparent;
            this.btnTampil.BorderRadius = 8;
            this.btnTampil.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTampil.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTampil.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this.btnTampil.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.btnTampil.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(128)))), ((int)(((byte)(61)))));
            this.btnTampil.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTampil.ForeColor = System.Drawing.Color.White;
            this.btnTampil.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(163)))), ((int)(((byte)(74)))));
            this.btnTampil.Location = new System.Drawing.Point(1012, 154);
            this.btnTampil.Margin = new System.Windows.Forms.Padding(4);
            this.btnTampil.Name = "btnTampil";
            this.btnTampil.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(83)))), ((int)(((byte)(45)))));
            this.btnTampil.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(21)))), ((int)(((byte)(128)))), ((int)(((byte)(61)))));
            this.btnTampil.ShadowDecoration.Depth = 4;
            this.btnTampil.ShadowDecoration.Enabled = true;
            this.btnTampil.Size = new System.Drawing.Size(154, 51);
            this.btnTampil.TabIndex = 16;
            this.btnTampil.Text = "Tampil";
            this.btnTampil.Click += new System.EventHandler(this.guna2Button5_Click);
            // 
            // btnBersih
            // 
            this.btnBersih.Animated = true;
            this.btnBersih.BorderRadius = 8;
            this.btnBersih.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBersih.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBersih.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this.btnBersih.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.btnBersih.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(90)))));
            this.btnBersih.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnBersih.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(200)))), ((int)(((byte)(230)))));
            this.btnBersih.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(115)))));
            this.btnBersih.Location = new System.Drawing.Point(1012, 213);
            this.btnBersih.Margin = new System.Windows.Forms.Padding(4);
            this.btnBersih.Name = "btnBersih";
            this.btnBersih.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(78)))));
            this.btnBersih.Size = new System.Drawing.Size(154, 51);
            this.btnBersih.TabIndex = 17;
            this.btnBersih.Text = "Bersihkan";
            this.btnBersih.Click += new System.EventHandler(this.btnBersih_Click);
            // 
            // panelGrid
            // 
            this.panelGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(28)))), ((int)(((byte)(44)))));
            this.panelGrid.Controls.Add(this.dataGridView1);
            this.panelGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGrid.Location = new System.Drawing.Point(0, 368);
            this.panelGrid.Margin = new System.Windows.Forms.Padding(4);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Padding = new System.Windows.Forms.Padding(15, 13, 15, 13);
            this.panelGrid.Size = new System.Drawing.Size(1414, 432);
            this.panelGrid.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(32)))), ((int)(((byte)(52)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeight = 36;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column5,
            this.Column4});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(55)))), ((int)(((byte)(85)))));
            this.dataGridView1.Location = new System.Drawing.Point(15, 13);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 32;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1384, 406);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 60;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Judul";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Pengarang";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 160;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Penerbit";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 160;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Tahun";
            this.Column7.MinimumWidth = 8;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 80;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Stok";
            this.Column8.MinimumWidth = 8;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 70;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Hapus";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 70;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Edit";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 70;
            // 
            // FBuku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(28)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(1414, 800);
            this.Controls.Add(this.panelGrid);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.panelTop);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FBuku";
            this.Text = "Data Buku";
            this.Load += new System.EventHandler(this.FBuku_Load);
            this.panelTop.ResumeLayout(false);
            this.panelForm.ResumeLayout(false);
            this.panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblPageTitle;
        private System.Windows.Forms.Label lblPageSub;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.Label lblPengarang;
        private System.Windows.Forms.Label lblPenerbit;
        private System.Windows.Forms.Label lblTahun;
        private System.Windows.Forms.Label lblStok;
        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.Label lblHiddenId;
        private Guna.UI2.WinForms.Guna2TextBox txtjudul;
        private Guna.UI2.WinForms.Guna2TextBox txtpengarang;
        private Guna.UI2.WinForms.Guna2TextBox txtpenerbit;
        private Guna.UI2.WinForms.Guna2TextBox txttahun;
        private Guna.UI2.WinForms.Guna2TextBox txtstok;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2Button btnSimpan;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2Button btnHapus;
        private Guna.UI2.WinForms.Guna2Button btnTampil;
        private Guna.UI2.WinForms.Guna2Button btnBersih;
        private System.Windows.Forms.Panel panelGrid;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewImageColumn Column5;
        private System.Windows.Forms.DataGridViewImageColumn Column4;
    }
}

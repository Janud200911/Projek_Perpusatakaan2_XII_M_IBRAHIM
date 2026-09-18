
namespace Projek_Perpusatakaan_XII_M_IBRAHIM
{
    partial class FRole
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
            this.lblNama = new System.Windows.Forms.Label();
            this.txtNama = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.txtRole = new Guna.UI2.WinForms.Guna2TextBox();
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
            this.lblPageTitle.Location = new System.Drawing.Point(13, 0);
            this.lblPageTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPageTitle.Name = "lblPageTitle";
            this.lblPageTitle.Size = new System.Drawing.Size(443, 45);
            this.lblPageTitle.TabIndex = 0;
            this.lblPageTitle.Text = "Manajemen Data Role";
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
            this.lblPageSub.Text = "Tambah, ubah, dan hapus data role petugas yang bisa akses";
            // 
            // panelForm
            // 
            this.panelForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(38)))), ((int)(((byte)(58)))));
            this.panelForm.Controls.Add(this.lblNama);
            this.panelForm.Controls.Add(this.txtNama);
            this.panelForm.Controls.Add(this.lblRole);
            this.panelForm.Controls.Add(this.txtRole);
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
            this.panelForm.Size = new System.Drawing.Size(1414, 197);
            this.panelForm.TabIndex = 1;
            // 
            // lblNama
            // 
            this.lblNama.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblNama.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(230)))));
            this.lblNama.Location = new System.Drawing.Point(51, 27);
            this.lblNama.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(257, 21);
            this.lblNama.TabIndex = 0;
            this.lblNama.Text = "NAMA ROLE";
            // 
            // txtNama
            // 
            this.txtNama.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(75)))), ((int)(((byte)(110)))));
            this.txtNama.BorderRadius = 8;
            this.txtNama.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNama.DefaultText = "";
            this.txtNama.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(75)))), ((int)(((byte)(110)))));
            this.txtNama.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(74)))));
            this.txtNama.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(120)))), ((int)(((byte)(150)))));
            this.txtNama.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(120)))), ((int)(((byte)(150)))));
            this.txtNama.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(74)))));
            this.txtNama.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.txtNama.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtNama.ForeColor = System.Drawing.Color.White;
            this.txtNama.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(130)))), ((int)(((byte)(200)))));
            this.txtNama.Location = new System.Drawing.Point(51, 51);
            this.txtNama.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txtNama.Name = "txtNama";
            this.txtNama.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(115)))), ((int)(((byte)(150)))));
            this.txtNama.PlaceholderText = "Nama role...";
            this.txtNama.SelectedText = "";
            this.txtNama.Size = new System.Drawing.Size(373, 48);
            this.txtNama.TabIndex = 1;
            // 
            // lblRole
            // 
            this.lblRole.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(230)))));
            this.lblRole.Location = new System.Drawing.Point(463, 27);
            this.lblRole.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(257, 21);
            this.lblRole.TabIndex = 2;
            this.lblRole.Text = "DESKRIPSI ROLE";
            // 
            // txtRole
            // 
            this.txtRole.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(75)))), ((int)(((byte)(110)))));
            this.txtRole.BorderRadius = 8;
            this.txtRole.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRole.DefaultText = "";
            this.txtRole.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(75)))), ((int)(((byte)(110)))));
            this.txtRole.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(74)))));
            this.txtRole.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(120)))), ((int)(((byte)(150)))));
            this.txtRole.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(120)))), ((int)(((byte)(150)))));
            this.txtRole.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(74)))));
            this.txtRole.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.txtRole.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtRole.ForeColor = System.Drawing.Color.White;
            this.txtRole.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(130)))), ((int)(((byte)(200)))));
            this.txtRole.Location = new System.Drawing.Point(463, 51);
            this.txtRole.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txtRole.Name = "txtRole";
            this.txtRole.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(115)))), ((int)(((byte)(150)))));
            this.txtRole.PlaceholderText = "Deskripsi role...";
            this.txtRole.SelectedText = "";
            this.txtRole.Size = new System.Drawing.Size(373, 48);
            this.txtRole.TabIndex = 3;
            // 
            // lblHiddenId
            // 
            this.lblHiddenId.Location = new System.Drawing.Point(0, 0);
            this.lblHiddenId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHiddenId.Name = "lblHiddenId";
            this.lblHiddenId.Size = new System.Drawing.Size(1, 1);
            this.lblHiddenId.TabIndex = 4;
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
            this.btnSimpan.Location = new System.Drawing.Point(51, 128);
            this.btnSimpan.Margin = new System.Windows.Forms.Padding(4);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(78)))), ((int)(((byte)(216)))));
            this.btnSimpan.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnSimpan.ShadowDecoration.Depth = 4;
            this.btnSimpan.ShadowDecoration.Enabled = true;
            this.btnSimpan.Size = new System.Drawing.Size(154, 51);
            this.btnSimpan.TabIndex = 5;
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
            this.btnUpdate.Location = new System.Drawing.Point(219, 128);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(64)))), ((int)(((byte)(14)))));
            this.btnUpdate.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))), ((int)(((byte)(9)))));
            this.btnUpdate.ShadowDecoration.Depth = 4;
            this.btnUpdate.ShadowDecoration.Enabled = true;
            this.btnUpdate.Size = new System.Drawing.Size(154, 51);
            this.btnUpdate.TabIndex = 6;
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
            this.btnHapus.Location = new System.Drawing.Point(386, 128);
            this.btnHapus.Margin = new System.Windows.Forms.Padding(4);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.btnHapus.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(153)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnHapus.ShadowDecoration.Depth = 4;
            this.btnHapus.ShadowDecoration.Enabled = true;
            this.btnHapus.Size = new System.Drawing.Size(154, 51);
            this.btnHapus.TabIndex = 7;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.Click += new System.EventHandler(this.guna2Button2_Click);
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
            this.btnTampil.Location = new System.Drawing.Point(556, 128);
            this.btnTampil.Margin = new System.Windows.Forms.Padding(4);
            this.btnTampil.Name = "btnTampil";
            this.btnTampil.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(83)))), ((int)(((byte)(45)))));
            this.btnTampil.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(21)))), ((int)(((byte)(128)))), ((int)(((byte)(61)))));
            this.btnTampil.ShadowDecoration.Depth = 4;
            this.btnTampil.ShadowDecoration.Enabled = true;
            this.btnTampil.Size = new System.Drawing.Size(154, 51);
            this.btnTampil.TabIndex = 8;
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
            this.btnBersih.Location = new System.Drawing.Point(718, 128);
            this.btnBersih.Margin = new System.Windows.Forms.Padding(4);
            this.btnBersih.Name = "btnBersih";
            this.btnBersih.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(78)))));
            this.btnBersih.Size = new System.Drawing.Size(154, 51);
            this.btnBersih.TabIndex = 9;
            this.btnBersih.Text = "Bersihkan";
            this.btnBersih.Click += new System.EventHandler(this.btnBersih_Click);
            // 
            // panelGrid
            // 
            this.panelGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(28)))), ((int)(((byte)(44)))));
            this.panelGrid.Controls.Add(this.dataGridView1);
            this.panelGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGrid.Location = new System.Drawing.Point(0, 272);
            this.panelGrid.Margin = new System.Windows.Forms.Padding(4);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Padding = new System.Windows.Forms.Padding(15, 13, 15, 13);
            this.panelGrid.Size = new System.Drawing.Size(1414, 528);
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
            this.dataGridView1.Size = new System.Drawing.Size(1384, 502);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
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
            this.Column2.HeaderText = "Nama";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Role";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 200;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Edit";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 70;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Hapus";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 70;
            // 
            // FRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(28)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(1414, 800);
            this.Controls.Add(this.panelGrid);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.panelTop);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FRole";
            this.Text = "Data Role";
            this.Load += new System.EventHandler(this.FRole_Load);
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
        private System.Windows.Forms.Label lblNama;
        private Guna.UI2.WinForms.Guna2TextBox txtNama;
        private System.Windows.Forms.Label lblRole;
        private Guna.UI2.WinForms.Guna2TextBox txtRole;
        private System.Windows.Forms.Label lblHiddenId;
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
        private System.Windows.Forms.DataGridViewImageColumn Column5;
        private System.Windows.Forms.DataGridViewImageColumn Column4;
    }
}

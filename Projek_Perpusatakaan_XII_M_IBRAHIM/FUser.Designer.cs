
namespace Projek_Perpusatakaan_XII_M_IBRAHIM
{
    partial class FUser
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
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnSimpan = new Guna.UI2.WinForms.Guna2Button();
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
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1100, 56);
            this.panelTop.TabIndex = 0;
            // 
            // lblPageTitle
            // 
            this.lblPageTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblPageTitle.ForeColor = System.Drawing.Color.White;
            this.lblPageTitle.Location = new System.Drawing.Point(20, 0);
            this.lblPageTitle.Name = "lblPageTitle";
            this.lblPageTitle.Size = new System.Drawing.Size(351, 34);
            this.lblPageTitle.TabIndex = 0;
            this.lblPageTitle.Text = "Manajemen Data User";
            // 
            // lblPageSub
            // 
            this.lblPageSub.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblPageSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(160)))), ((int)(((byte)(210)))));
            this.lblPageSub.Location = new System.Drawing.Point(311, 24);
            this.lblPageSub.Name = "lblPageSub";
            this.lblPageSub.Size = new System.Drawing.Size(373, 41);
            this.lblPageSub.TabIndex = 1;
            this.lblPageSub.Text = "Tambah dan kelola akun petugas perpustakaan";
            // 
            // panelForm
            // 
            this.panelForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(38)))), ((int)(((byte)(58)))));
            this.panelForm.Controls.Add(this.lblNama);
            this.panelForm.Controls.Add(this.txtNama);
            this.panelForm.Controls.Add(this.lblPassword);
            this.panelForm.Controls.Add(this.txtPassword);
            this.panelForm.Controls.Add(this.lblUsername);
            this.panelForm.Controls.Add(this.txtUsername);
            this.panelForm.Controls.Add(this.lblRole);
            this.panelForm.Controls.Add(this.guna2ComboBox1);
            this.panelForm.Controls.Add(this.btnSimpan);
            this.panelForm.Controls.Add(this.btnTampil);
            this.panelForm.Controls.Add(this.btnBersih);
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelForm.Location = new System.Drawing.Point(0, 56);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(1100, 186);
            this.panelForm.TabIndex = 1;
            // 
            // lblNama
            // 
            this.lblNama.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblNama.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(230)))));
            this.lblNama.Location = new System.Drawing.Point(40, 20);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(200, 16);
            this.lblNama.TabIndex = 0;
            this.lblNama.Text = "NAMA LENGKAP";
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
            this.txtNama.Location = new System.Drawing.Point(40, 38);
            this.txtNama.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNama.Name = "txtNama";
            this.txtNama.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(115)))), ((int)(((byte)(150)))));
            this.txtNama.PlaceholderText = "Nama lengkap...";
            this.txtNama.SelectedText = "";
            this.txtNama.Size = new System.Drawing.Size(290, 36);
            this.txtNama.TabIndex = 1;
            // 
            // lblPassword
            // 
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(230)))));
            this.lblPassword.Location = new System.Drawing.Point(40, 82);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(200, 16);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "PASSWORD";
            // 
            // txtPassword
            // 
            this.txtPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(75)))), ((int)(((byte)(110)))));
            this.txtPassword.BorderRadius = 8;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(75)))), ((int)(((byte)(110)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(74)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(120)))), ((int)(((byte)(150)))));
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(120)))), ((int)(((byte)(150)))));
            this.txtPassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(74)))));
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(130)))), ((int)(((byte)(200)))));
            this.txtPassword.Location = new System.Drawing.Point(40, 100);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(115)))), ((int)(((byte)(150)))));
            this.txtPassword.PlaceholderText = "Password...";
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(290, 36);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lblUsername
            // 
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(230)))));
            this.lblUsername.Location = new System.Drawing.Point(360, 20);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(200, 16);
            this.lblUsername.TabIndex = 4;
            this.lblUsername.Text = "USERNAME";
            // 
            // txtUsername
            // 
            this.txtUsername.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(75)))), ((int)(((byte)(110)))));
            this.txtUsername.BorderRadius = 8;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.DefaultText = "";
            this.txtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(75)))), ((int)(((byte)(110)))));
            this.txtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(74)))));
            this.txtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(120)))), ((int)(((byte)(150)))));
            this.txtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(120)))), ((int)(((byte)(150)))));
            this.txtUsername.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(74)))));
            this.txtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtUsername.ForeColor = System.Drawing.Color.White;
            this.txtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(130)))), ((int)(((byte)(200)))));
            this.txtUsername.Location = new System.Drawing.Point(360, 38);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(115)))), ((int)(((byte)(150)))));
            this.txtUsername.PlaceholderText = "Username login...";
            this.txtUsername.SelectedText = "";
            this.txtUsername.Size = new System.Drawing.Size(290, 36);
            this.txtUsername.TabIndex = 5;
            // 
            // lblRole
            // 
            this.lblRole.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(230)))));
            this.lblRole.Location = new System.Drawing.Point(360, 82);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(200, 16);
            this.lblRole.TabIndex = 6;
            this.lblRole.Text = "ROLE / JABATAN";
            // 
            // guna2ComboBox1
            // 
            this.guna2ComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox1.BorderRadius = 8;
            this.guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.guna2ComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(200)))), ((int)(((byte)(230)))));
            this.guna2ComboBox1.ItemHeight = 30;
            this.guna2ComboBox1.Items.AddRange(new object[] {
            "admin",
            "petugas"});
            this.guna2ComboBox1.Location = new System.Drawing.Point(360, 100);
            this.guna2ComboBox1.Name = "guna2ComboBox1";
            this.guna2ComboBox1.Size = new System.Drawing.Size(290, 36);
            this.guna2ComboBox1.TabIndex = 7;
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
            this.btnSimpan.Location = new System.Drawing.Point(40, 148);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(78)))), ((int)(((byte)(216)))));
            this.btnSimpan.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnSimpan.ShadowDecoration.Depth = 4;
            this.btnSimpan.ShadowDecoration.Enabled = true;
            this.btnSimpan.Size = new System.Drawing.Size(120, 38);
            this.btnSimpan.TabIndex = 8;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.Click += new System.EventHandler(this.guna2Button1_Click);
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
            this.btnTampil.Location = new System.Drawing.Point(170, 148);
            this.btnTampil.Name = "btnTampil";
            this.btnTampil.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(83)))), ((int)(((byte)(45)))));
            this.btnTampil.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(21)))), ((int)(((byte)(128)))), ((int)(((byte)(61)))));
            this.btnTampil.ShadowDecoration.Depth = 4;
            this.btnTampil.ShadowDecoration.Enabled = true;
            this.btnTampil.Size = new System.Drawing.Size(120, 38);
            this.btnTampil.TabIndex = 9;
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
            this.btnBersih.Location = new System.Drawing.Point(300, 148);
            this.btnBersih.Name = "btnBersih";
            this.btnBersih.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(78)))));
            this.btnBersih.Size = new System.Drawing.Size(120, 38);
            this.btnBersih.TabIndex = 10;
            this.btnBersih.Text = "Bersihkan";
            this.btnBersih.Click += new System.EventHandler(this.btnBersih_Click);
            // 
            // panelGrid
            // 
            this.panelGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(28)))), ((int)(((byte)(44)))));
            this.panelGrid.Controls.Add(this.dataGridView1);
            this.panelGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGrid.Location = new System.Drawing.Point(0, 242);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Padding = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.panelGrid.Size = new System.Drawing.Size(1100, 358);
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 10);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 32;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1076, 338);
            this.dataGridView1.TabIndex = 0;
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
            this.Column2.HeaderText = "Username";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 180;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Password";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 180;
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
            // FUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(28)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.panelGrid);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.panelTop);
            this.Name = "FUser";
            this.Text = "Data User";
            this.Load += new System.EventHandler(this.FUser_Load);
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
        private System.Windows.Forms.Label lblPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private System.Windows.Forms.Label lblUsername;
        private Guna.UI2.WinForms.Guna2TextBox txtUsername;
        private System.Windows.Forms.Label lblRole;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private Guna.UI2.WinForms.Guna2Button btnSimpan;
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

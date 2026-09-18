using System;
using System.Drawing;
using System.Windows.Forms;

namespace Projek_Perpusatakaan_XII_M_IBRAHIM
{
    public partial class FAdmin : Form
    {
        private int _idPetugas;
        private string _nama;
        private Guna.UI2.WinForms.Guna2Button _activeBtn = null;

        public FAdmin(int idPetugas, string nama)
        {
            InitializeComponent();
            _idPetugas = idPetugas;
            _nama = nama;
        }

        private void OpenForm(Form form)
        {
            panelContent.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panelContent.Controls.Add(form);
            form.Show();
        }

        private void SetActiveNav(Guna.UI2.WinForms.Guna2Button btn)
        {
            if (_activeBtn != null)
            {
                _activeBtn.FillColor = Color.Transparent;
                _activeBtn.ForeColor = Color.FromArgb(180, 200, 230);
            }
            btn.FillColor = Color.FromArgb(37, 99, 235);
            btn.ForeColor = Color.White;
            _activeBtn = btn;
        }

        private void FAdmin_Load(object sender, EventArgs e)
        {
            lblUserBadge.Text = "👤  " + _nama;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            SetActiveNav(btnDataBuku);
            OpenForm(new FBuku());
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            SetActiveNav(btnDataUser);
            OpenForm(new FUser());
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            SetActiveNav(btnDataRole);
            OpenForm(new FRole());
        }

        private void btnTransaksi_Click(object sender, EventArgs e)
        {
            SetActiveNav(btnTransaksi);
            OpenForm(new FTransaksi(_idPetugas));
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var hasil = MessageBox.Show("Yakin ingin keluar?", "Konfirmasi Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (hasil == DialogResult.Yes)
            {
                new FLogin().Show();
                this.Close();
            }
        }
    }
}

using System;
using System.Windows.Forms;
using System.Drawing;

namespace Projek_Perpusatakaan_XII_M_IBRAHIM
{
    public partial class FPetugas : Form
    {
        private int _idPetugas;
        private string _nama;
        private Guna.UI2.WinForms.Guna2Button _activeBtn = null;

        public FPetugas(int idPetugas, string nama)
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

        private void FPetugas_Load(object sender, EventArgs e)
        {
            lblUserBadge.Text = "👤  " + _nama;
            SetActiveNav(btnDashboard);
            OpenForm(new Fdashboard());
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            SetActiveNav(btnDashboard);
            OpenForm(new Fdashboard());
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

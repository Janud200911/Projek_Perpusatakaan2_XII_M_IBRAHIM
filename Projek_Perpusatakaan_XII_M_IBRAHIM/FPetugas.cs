using System;
using System.Windows.Forms;
using System.Drawing;

namespace Projek_Perpusatakaan_XII_M_IBRAHIM
{
    public partial class FPetugas : Form
    {
        private int _idPetugas;
        private string _nama;

        public FPetugas(int idPetugas, string nama)
        {
            InitializeComponent();
            _idPetugas = idPetugas;
            _nama = nama;
        }

        private void FPetugas_Load(object sender, EventArgs e)
        {
            lblUserBadge.Text = "👤  " + _nama;
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

        private void btnTransaksi_Click(object sender, EventArgs e)
        {
            btnTransaksi.FillColor = Color.FromArgb(37, 99, 235);
            btnTransaksi.ForeColor = Color.White;
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

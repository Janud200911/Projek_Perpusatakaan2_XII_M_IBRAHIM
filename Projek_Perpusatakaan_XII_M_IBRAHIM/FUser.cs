using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Projek_Perpusatakaan_XII_M_IBRAHIM
{
    public partial class FUser : Form
    {
        public FUser()
        {
            InitializeComponent();
        }

        private void FUser_Load(object sender, EventArgs e)
        {
            tampildataa();
        }

        private void guna2Button1_Click(object sender, EventArgs e)   // Simpan
        {
            if (!ValidasiInput()) return;

            string nm  = txtNama.Text.Trim();
            string pw  = txtPassword.Text;
            string rl  = guna2ComboBox1.Text;
            string usr = txtUsername.Text.Trim();

            DB.crud($"INSERT INTO t_petugas VALUES (null,'{nm}','{usr}','{pw}','{rl}')");
            tampildataa();
            BersihkanForm();
        }

        private void guna2Button5_Click(object sender, EventArgs e)   // Tampil
        {
            tampildataa();
        }

        private void btnBersih_Click(object sender, EventArgs e)
        {
            BersihkanForm();
        }

        public void tampildataa()
        {
            dataGridView1.Rows.Clear();
            DB.crud("SELECT * FROM t_petugas");
            foreach (DataRow baris in DB.ds.Tables[0].Rows)
            {
                string id       = baris["id_petugas"].ToString();
                string username = baris["username"].ToString();
                string password = baris["password"].ToString();
                dataGridView1.Rows.Add(id, username, password);
            }
        }

        private void BersihkanForm()
        {
            txtNama.Text     = "";
            txtPassword.Text = "";
            txtUsername.Text = "";
            if (guna2ComboBox1.Items.Count > 0)
                guna2ComboBox1.SelectedIndex = -1;
            txtNama.Focus();
        }

        private bool ValidasiInput()
        {
            if (string.IsNullOrWhiteSpace(txtNama.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text) ||
                string.IsNullOrWhiteSpace(txtUsername.Text) ||
                guna2ComboBox1.SelectedIndex < 0)
            {
                MessageBox.Show("Semua field wajib diisi dan role harus dipilih.",
                    "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
    }
}

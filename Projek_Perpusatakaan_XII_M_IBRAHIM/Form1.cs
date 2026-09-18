using System;
using System.Data;
using System.Windows.Forms;

namespace Projek_Perpusatakaan_XII_M_IBRAHIM
{
    public partial class FLogin : Form
    {
        public FLogin()
        {
            InitializeComponent();
        }

        private void FLogin_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            //Asep
            if (username == "" || password == "")
            {
                MessageBox.Show("Username dan password tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DB.crud("SELECT * FROM t_petugas WHERE username='" + username + "' AND password='" + password + "'");

            if (DB.ds.Tables[0].Rows.Count == 1)
            {
                string level    = DB.ds.Tables[0].Rows[0]["level"].ToString();
                int idPetugas   = Convert.ToInt32(DB.ds.Tables[0].Rows[0]["id_petugas"]);
                string nama     = DB.ds.Tables[0].Rows[0]["nama"].ToString();

                if (level == "admin")
                {
                    FAdmin admin = new FAdmin(idPetugas, nama);
                    admin.Show();
                    this.Hide();
                }
                else if (level == "petugas")
                {
                    FPetugas petugas = new FPetugas(idPetugas, nama);
                    petugas.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Level akun tidak dikenali!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Username atau password salah!", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Text = "";
                txtUsername.Focus();
            }
        }
    }
}

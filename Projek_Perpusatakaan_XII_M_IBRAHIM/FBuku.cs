using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Projek_Perpusatakaan_XII_M_IBRAHIM
{
    public partial class FBuku : Form
    {
        public FBuku()
        {
            InitializeComponent();
        }

        private void FBuku_Load(object sender, EventArgs e)
        {
            tampildataa();
        }

        // ── CRUD ─────────────────────────────────────────────────────────────

        private void guna2Button1_Click(object sender, EventArgs e)   // Simpan
        {
            if (!ValidasiInput()) return;

            string jd    = txtjudul.Text.Trim();
            string pn    = txtpengarang.Text.Trim();
            string pener = txtpenerbit.Text.Trim();
            string th    = txttahun.Text.Trim();
            string stk   = txtstok.Text.Trim();
            string kateg = guna2TextBox1.Text.Trim();

            DB.crud($"INSERT INTO t_buku VALUES (null,'{jd}','{pn}','{pener}','{th}','{stk}','{kateg}')");
            tampildataa();
            BersihkanForm();
        }

        private void guna2Button3_Click(object sender, EventArgs e)   // Update
        {
            if (string.IsNullOrWhiteSpace(lblHiddenId.Text))
            {
                MessageBox.Show("Pilih buku dari tabel terlebih dahulu.", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!ValidasiInput()) return;

            string id     = lblHiddenId.Text;
            string judul  = txtjudul.Text.Trim();
            string peng   = txtpengarang.Text.Trim();
            string pener  = txtpenerbit.Text.Trim();
            string tahun  = txttahun.Text.Trim();
            string stok   = txtstok.Text.Trim();
            string idkat  = guna2TextBox1.Text.Trim();

            DB.crud($"UPDATE t_buku SET judul='{judul}', pengarang='{peng}', penerbit='{pener}', " +
                    $"tahun='{tahun}', stok='{stok}', id_kategori='{idkat}' WHERE id_buku='{id}'");
            tampildataa();
            BersihkanForm();
        }

        private void guna2Button5_Click(object sender, EventArgs e)   // Tampil/Refresh
        {
            tampildataa();
        }

        // ── DataGridView cell click ───────────────────────────────────────────

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string idnya = dataGridView1.Rows[e.RowIndex].Cells[0].Value?.ToString();
            if (string.IsNullOrEmpty(idnya)) return;

            // Kolom 7 = Edit → isi form
            if (e.ColumnIndex == 7)
            {
                DB.crud($"SELECT * FROM t_buku WHERE id_buku='{idnya}'");
                foreach (DataRow row in DB.ds.Tables[0].Rows)
                {
                    lblHiddenId.Text       = row["id_buku"].ToString();
                    txtjudul.Text          = row["judul"].ToString();
                    txtpengarang.Text      = row["pengarang"].ToString();
                    txtpenerbit.Text       = row["penerbit"].ToString();
                    txttahun.Text          = row["tahun"].ToString();
                    txtstok.Text           = row["stok"].ToString();
                    guna2TextBox1.Text     = row["id_kategori"].ToString();
                }

                // Highlight baris yang dipilih jelas
                dataGridView1.Rows[e.RowIndex].Selected = true;
            }

            // Kolom 6 = Hapus → konfirmasi lalu delete
            if (e.ColumnIndex == 6)
            {
                var setuju = MessageBox.Show(
                    $"Yakin ingin menghapus buku dengan ID {idnya}?",
                    "Konfirmasi Hapus",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );
                if (setuju == DialogResult.Yes)
                {
                    DB.crud($"DELETE FROM t_buku WHERE id_buku='{idnya}'");
                    tampildataa();
                    BersihkanForm();
                }
            }
        }

        // ── Bersihkan form ────────────────────────────────────────────────────

        private void btnBersih_Click(object sender, EventArgs e)
        {
            BersihkanForm();
        }

        private void BersihkanForm()
        {
            lblHiddenId.Text   = "";
            txtjudul.Text      = "";
            txtpengarang.Text  = "";
            txtpenerbit.Text   = "";
            txttahun.Text      = "";
            txtstok.Text       = "";
            guna2TextBox1.Text = "";
            txtjudul.Focus();
        }

        // ── Tampil data ───────────────────────────────────────────────────────

        public void tampildataa()
        {
            dataGridView1.Rows.Clear();
            DB.crud("SELECT * FROM t_buku");
            foreach (DataRow row in DB.ds.Tables[0].Rows)
            {
                dataGridView1.Rows.Add(
                    row["id_buku"].ToString(),
                    row["judul"].ToString(),
                    row["pengarang"].ToString(),
                    row["penerbit"].ToString(),
                    row["tahun"].ToString(),
                    row["stok"].ToString(),
                    row["id_kategori"].ToString()
                );
            }
        }

        // ── Validasi ──────────────────────────────────────────────────────────

        private bool ValidasiInput()
        {
            if (string.IsNullOrWhiteSpace(txtjudul.Text) ||
                string.IsNullOrWhiteSpace(txtpengarang.Text) ||
                string.IsNullOrWhiteSpace(txtpenerbit.Text) ||
                string.IsNullOrWhiteSpace(txttahun.Text) ||
                string.IsNullOrWhiteSpace(txtstok.Text))
            {
                MessageBox.Show("Judul, Pengarang, Penerbit, Tahun, dan Stok wajib diisi.",
                    "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        // ── Event handlers lain ───────────────────────────────────────────────

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }

        private void txtpenerbit_TextChanged(object sender, EventArgs e) { }
    }
}

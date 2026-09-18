using System;
using System.Data;
using System.Windows.Forms;

namespace Projek_Perpusatakaan_XII_M_IBRAHIM
{
    public partial class FRole : Form
    {
        public FRole()
        {
            InitializeComponent();
        }

        private void FRole_Load(object sender, EventArgs e)
        {
            tampildataa();
        }

        // ── Simpan ───────────────────────────────────────────────────────────
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (!ValidasiInput()) return;

            string nm = txtNama.Text.Trim();
            string rl = txtRole.Text.Trim();
            DB.crud($"INSERT INTO t_role VALUES (null,'{nm}','{rl}')");
            tampildataa();
            BersihkanForm();
        }

        // ── Update ───────────────────────────────────────────────────────────
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(lblHiddenId.Text))
            {
                MessageBox.Show("Pilih data role dari tabel terlebih dahulu.",
                    "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!ValidasiInput()) return;

            string id = lblHiddenId.Text;
            string nm = txtNama.Text.Trim();
            string rl = txtRole.Text.Trim();
            DB.crud($"UPDATE t_role SET Nama='{nm}', Role='{rl}' WHERE id_role='{id}'");
            tampildataa();
            BersihkanForm();
        }

        // ── Hapus (tombol di baris kolom 4) ──────────────────────────────────
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            // tombol Hapus di panel — hapus baris yang sedang dipilih di grid
            if (dataGridView1.CurrentRow == null) return;
            string idnya = dataGridView1.CurrentRow.Cells[0].Value?.ToString();
            if (string.IsNullOrEmpty(idnya)) return;

            var setuju = MessageBox.Show(
                $"Yakin ingin menghapus role dengan ID {idnya}?",
                "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (setuju == DialogResult.Yes)
            {
                DB.crud($"DELETE FROM t_role WHERE id_role='{idnya}'");
                tampildataa();
                BersihkanForm();
            }
        }

        // ── Tampil ───────────────────────────────────────────────────────────
        private void guna2Button5_Click(object sender, EventArgs e)
        {
            tampildataa();
        }

        // ── Bersih ───────────────────────────────────────────────────────────
        private void btnBersih_Click(object sender, EventArgs e)
        {
            BersihkanForm();
        }

        // ── CellClick di grid ─────────────────────────────────────────────────
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string idnya = dataGridView1.Rows[e.RowIndex].Cells[0].Value?.ToString();
            if (string.IsNullOrEmpty(idnya)) return;

            // Kolom 3 = Edit → isi form
            if (e.ColumnIndex == 3)
            {
                DB.crud($"SELECT * FROM t_role WHERE id_role='{idnya}'");
                foreach (DataRow row in DB.ds.Tables[0].Rows)
                {
                    lblHiddenId.Text = row["id_role"].ToString();
                    txtNama.Text     = row["Nama"].ToString();
                    txtRole.Text     = row["Role"].ToString();
                }
                dataGridView1.Rows[e.RowIndex].Selected = true;
            }

            // Kolom 4 = Hapus
            if (e.ColumnIndex == 4)
            {
                var setuju = MessageBox.Show(
                    $"Yakin ingin menghapus role dengan ID {idnya}?",
                    "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (setuju == DialogResult.Yes)
                {
                    DB.crud($"DELETE FROM t_role WHERE id_role='{idnya}'");
                    tampildataa();
                    BersihkanForm();
                }
            }
        }

        // ── Helpers ──────────────────────────────────────────────────────────
        public void tampildataa()
        {
            dataGridView1.Rows.Clear();
            DB.crud("SELECT * FROM t_role");
            foreach (DataRow baris in DB.ds.Tables[0].Rows)
            {
                dataGridView1.Rows.Add(
                    baris["id_role"].ToString(),
                    baris["Nama"].ToString(),
                    baris["Role"].ToString()
                );
            }
        }

        private void BersihkanForm()
        {
            lblHiddenId.Text = "";
            txtNama.Text     = "";
            txtRole.Text     = "";
            txtNama.Focus();
        }

        private bool ValidasiInput()
        {
            if (string.IsNullOrWhiteSpace(txtNama.Text) ||
                string.IsNullOrWhiteSpace(txtRole.Text))
            {
                MessageBox.Show("Nama dan Role wajib diisi.",
                    "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
    }
}

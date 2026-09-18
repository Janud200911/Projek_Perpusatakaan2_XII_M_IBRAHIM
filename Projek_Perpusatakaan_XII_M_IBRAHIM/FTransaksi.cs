using System;
using System.Data;
using System.Windows.Forms;

namespace Projek_Perpusatakaan_XII_M_IBRAHIM
{
    public partial class FTransaksi : Form
    {
        private int _idPetugas;

        public FTransaksi(int idPetugas)
        {
            InitializeComponent();
            _idPetugas = idPetugas;
        }

        private void FTransaksi_Load(object sender, EventArgs e)
        {
            TampilPeminjaman();
            TampilPengembalian();
        }

        // ── TAB PEMINJAMAN ────────────────────────────────────────────────────

        private void btnCekBuku_Click(object sender, EventArgs e)
        {
            string idBuku = txtIdBuku.Text.Trim();
            if (idBuku == "")
            {
                MessageBox.Show("Masukkan ID buku terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DB.crud("SELECT * FROM t_buku WHERE id_buku='" + idBuku + "'");

            if (DB.ds.Tables[0].Rows.Count == 1)
            {
                string judul = DB.ds.Tables[0].Rows[0]["judul"].ToString();
                int stok = Convert.ToInt32(DB.ds.Tables[0].Rows[0]["stok"]);

                if (stok <= 0)
                {
                    lblJudulInfo.ForeColor = System.Drawing.Color.FromArgb(255, 100, 100);
                    lblJudulInfo.Text = "Stok habis! Buku tidak tersedia.";
                    return;
                }

                lblJudulInfo.ForeColor = System.Drawing.Color.FromArgb(100, 200, 120);
                lblJudulInfo.Text = "✔  " + judul + "  (Stok: " + stok + ")";
            }
            else
            {
                lblJudulInfo.ForeColor = System.Drawing.Color.FromArgb(255, 100, 100);
                lblJudulInfo.Text = "Buku dengan ID tersebut tidak ditemukan!";
            }
        }

        private void btnSimpanPinjam_Click(object sender, EventArgs e)
        {
            string nama = txtNamaPeminjam.Text.Trim();
            string idBuku = txtIdBuku.Text.Trim();

            if (nama == "" || idBuku == "")
            {
                MessageBox.Show("Nama peminjam dan ID buku wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Cek buku ada dan stoknya
            DB.crud("SELECT * FROM t_buku WHERE id_buku='" + idBuku + "' AND stok > 0");
            if (DB.ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("Buku tidak ditemukan atau stok habis!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string tglPinjam = dtpTglPinjam.Value.ToString("yyyy-MM-dd");
            string tglTempo = dtpTglTempo.Value.ToString("yyyy-MM-dd");

            // Simpan transaksi
            DB.crud("INSERT INTO t_peminjaman (tgl_pinjam, tgl_jatuh_tempo, nama_peminjam, id_buku, id_anggota, id_petugas, status, denda, keterangan) " +
                    "VALUES ('" + tglPinjam + "', '" + tglTempo + "', '" + nama + "', '" + idBuku + "', 0, '" + _idPetugas + "', 'di pinjam', 0, '')");

            // Kurangi stok buku
            DB.crud("UPDATE t_buku SET stok = stok - 1 WHERE id_buku='" + idBuku + "'");

            MessageBox.Show("Peminjaman berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            BersihkanFormPinjam();
            TampilPeminjaman();
        }

        private void btnBersihPinjam_Click(object sender, EventArgs e)
        {
            BersihkanFormPinjam();
        }

        private void BersihkanFormPinjam()
        {
            txtNamaPeminjam.Text = "";
            txtIdBuku.Text = "";
            lblJudulInfo.Text = "";
            dtpTglPinjam.Value = DateTime.Now;
            dtpTglTempo.Value = DateTime.Now.AddDays(7);
        }

        public void TampilPeminjaman()
        {
            dgvPinjam.Rows.Clear();
            DB.crud("SELECT p.id_pinjam, p.nama_peminjam, b.judul, p.tgl_pinjam, p.tgl_jatuh_tempo, p.status " +
                    "FROM t_peminjaman p JOIN t_buku b ON p.id_buku = b.id_buku " +
                    "WHERE p.status = 'di pinjam' ORDER BY p.id_pinjam DESC");

            foreach (DataRow row in DB.ds.Tables[0].Rows)
            {
                dgvPinjam.Rows.Add(
                    row["id_pinjam"].ToString(),
                    row["nama_peminjam"].ToString(),
                    row["judul"].ToString(),
                    row["tgl_pinjam"].ToString(),
                    row["tgl_jatuh_tempo"].ToString(),
                    row["status"].ToString()
                );
            }
        }

        // ── TAB PENGEMBALIAN ──────────────────────────────────────────────────

        private void btnCekPinjam_Click(object sender, EventArgs e)
        {
            string idPinjam = txtIdPinjam.Text.Trim();
            if (idPinjam == "")
            {
                MessageBox.Show("Masukkan ID peminjaman terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DB.crud("SELECT p.id_pinjam, p.nama_peminjam, b.judul, p.tgl_pinjam, p.tgl_jatuh_tempo, p.status " +
                    "FROM t_peminjaman p JOIN t_buku b ON p.id_buku = b.id_buku " +
                    "WHERE p.id_pinjam='" + idPinjam + "'");

            if (DB.ds.Tables[0].Rows.Count == 1)
            {
                string status = DB.ds.Tables[0].Rows[0]["status"].ToString();
                if (status == "selesai")
                {
                    MessageBox.Show("Buku ini sudah dikembalikan sebelumnya!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                lblInfoNama.Text  = "Peminjam  : " + DB.ds.Tables[0].Rows[0]["nama_peminjam"].ToString();
                lblInfoBuku.Text  = "Buku       : " + DB.ds.Tables[0].Rows[0]["judul"].ToString();
                lblInfoTempo.Text = "Jatuh Tempo: " + Convert.ToDateTime(DB.ds.Tables[0].Rows[0]["tgl_jatuh_tempo"]).ToString("dd/MM/yyyy");

                // Warnai merah kalau sudah lewat jatuh tempo
                DateTime jatuhTempo = Convert.ToDateTime(DB.ds.Tables[0].Rows[0]["tgl_jatuh_tempo"]);
                if (DateTime.Now.Date > jatuhTempo.Date)
                {
                    lblInfoTempo.ForeColor = System.Drawing.Color.FromArgb(255, 100, 100);
                    lblInfoTempo.Text += "  ⚠ TELAT!";
                }
                else
                {
                    lblInfoTempo.ForeColor = System.Drawing.Color.FromArgb(255, 180, 60);
                }

              
                chkKerusakan.Checked = false;
            }
            else
            {
                MessageBox.Show("ID peminjaman tidak ditemukan!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                BersihkanFormKembali();
            }
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            string idPinjam = txtIdPinjam.Text.Trim();
            if (idPinjam == "")
            {
                MessageBox.Show("Cek ID peminjaman dulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DB.crud("SELECT tgl_jatuh_tempo FROM t_peminjaman WHERE id_pinjam='" + idPinjam + "'");
            if (DB.ds.Tables[0].Rows.Count == 0) return;

            DateTime jatuhTempo = Convert.ToDateTime(DB.ds.Tables[0].Rows[0]["tgl_jatuh_tempo"]);
            DateTime tglKembali = dtpTglKembali.Value.Date;

            int dendaTelat = 0;
            int dendaKerusakan = 0;

            // Denda keterlambatan: Rp 1.000 per hari
            if (tglKembali > jatuhTempo.Date)
            {
                int hariTelat = (tglKembali - jatuhTempo.Date).Days;
                dendaTelat = hariTelat * 1000;
            }

            // Denda kerusakan: Rp 20.000
            if (chkKerusakan.Checked)
            {
                dendaKerusakan = 20000;
            }

            int totalDenda = dendaTelat + dendaKerusakan;
          
        }

        private void btnSimpanKembali_Click(object sender, EventArgs e)
        {
            string idPinjam = txtIdPinjam.Text.Trim();
            if (idPinjam == "")
            {
                MessageBox.Show("Cek ID peminjaman dulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Hitung denda final
            DB.crud("SELECT tgl_jatuh_tempo, id_buku FROM t_peminjaman WHERE id_pinjam='" + idPinjam + "'");
            if (DB.ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("Data peminjaman tidak ditemukan!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime jatuhTempo = Convert.ToDateTime(DB.ds.Tables[0].Rows[0]["tgl_jatuh_tempo"]);
            string idBuku = DB.ds.Tables[0].Rows[0]["id_buku"].ToString();
            DateTime tglKembali = dtpTglKembali.Value.Date;

            int dendaTelat = 0;
            int dendaKerusakan = 0;

            if (tglKembali > jatuhTempo.Date)
            {
                int hariTelat = (tglKembali - jatuhTempo.Date).Days;
                dendaTelat = hariTelat * 1000;
            }

            if (chkKerusakan.Checked)
            {
                dendaKerusakan = 20000;
            }

            int totalDenda = dendaTelat + dendaKerusakan;
            string keterangan = "";

            if (dendaTelat > 0 && dendaKerusakan > 0)
                keterangan = "Telat " + (tglKembali - jatuhTempo.Date).Days + " hari + kerusakan buku";
            else if (dendaTelat > 0)
                keterangan = "Telat " + (tglKembali - jatuhTempo.Date).Days + " hari";
            else if (dendaKerusakan > 0)
                keterangan = "Kerusakan buku";
            else
                keterangan = "Tepat waktu";

            // Update status peminjaman
            DB.crud("UPDATE t_peminjaman SET status='selesai', denda=" + totalDenda + ", keterangan='" + keterangan + "' WHERE id_pinjam='" + idPinjam + "'");

            // Tambah stok buku kembali
            DB.crud("UPDATE t_buku SET stok = stok + 1 WHERE id_buku='" + idBuku + "'");

            if (totalDenda > 0)
                MessageBox.Show("Pengembalian berhasil!\nTotal denda: Rp " + totalDenda.ToString("N0") + "\nKeterangan: " + keterangan, "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Pengembalian berhasil! Tidak ada denda.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

            BersihkanFormKembali();
            TampilPengembalian();
            TampilPeminjaman();
        }

        private void dgvKembali_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            string idPinjam = dgvKembali.Rows[e.RowIndex].Cells[0].Value?.ToString();
            if (!string.IsNullOrEmpty(idPinjam))
            {
                txtIdPinjam.Text = idPinjam;
                tabControl1.SelectedIndex = 1;
                btnCekPinjam_Click(null, null);
            }
        }

        private void BersihkanFormKembali()
        {
            txtIdPinjam.Text = "";
            lblInfoNama.Text  = "Peminjam  : -";
            lblInfoBuku.Text  = "Buku       : -";
            lblInfoTempo.Text = "Jatuh Tempo: -";
            lblInfoTempo.ForeColor = System.Drawing.Color.FromArgb(255, 180, 60);
         
            chkKerusakan.Checked = false;
            dtpTglKembali.Value = DateTime.Now;
        }

        public void TampilPengembalian()
        {
            dgvKembali.Rows.Clear();
            DB.crud("SELECT p.id_pinjam, p.nama_peminjam, b.judul, p.tgl_pinjam, p.tgl_jatuh_tempo, p.denda, p.status " +
                    "FROM t_peminjaman p JOIN t_buku b ON p.id_buku = b.id_buku " +
                    "ORDER BY p.id_pinjam DESC");

            foreach (DataRow row in DB.ds.Tables[0].Rows)
            {
                dgvKembali.Rows.Add(
                    row["id_pinjam"].ToString(),
                    row["nama_peminjam"].ToString(),
                    row["judul"].ToString(),
                    row["tgl_pinjam"].ToString(),
                    row["tgl_jatuh_tempo"].ToString(),
                    "Rp " + Convert.ToInt32(row["denda"]).ToString("N0"),
                    row["status"].ToString()
                );
            }
        }

        private void panelFormPinjam_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

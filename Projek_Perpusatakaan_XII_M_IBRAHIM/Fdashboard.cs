using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Projek_Perpusatakaan_XII_M_IBRAHIM
{
    public partial class Fdashboard : Form
    {
        public Fdashboard()
        {
            InitializeComponent();
        }

        private void Fdashboard_Load(object sender, EventArgs e)
        {
            MuatStatistik();
            MuatPeminjamanAktif();
        }

        private void MuatStatistik()
        {
            try
            {
                // Total Buku
                DB.crud("SELECT COUNT(*) AS total FROM t_buku");
                lblTotalBuku.Text = DB.ds.Tables[0].Rows[0]["total"].ToString();

                // Total Anggota
                DB.crud("SELECT COUNT(*) AS total FROM t_anggota");
                lblTotalAnggota.Text = DB.ds.Tables[0].Rows[0]["total"].ToString();

                // Sedang Dipinjam
                DB.crud("SELECT COUNT(*) AS total FROM t_peminjaman WHERE status = 'di pinjam'");
                lblDipinjam.Text = DB.ds.Tables[0].Rows[0]["total"].ToString();

                // Total Denda
                DB.crud("SELECT IFNULL(SUM(denda), 0) AS total FROM t_peminjaman");
                long denda = Convert.ToInt64(DB.ds.Tables[0].Rows[0]["total"]);
                lblTotalDenda.Text = "Rp " + denda.ToString("N0");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat statistik: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MuatPeminjamanAktif()
        {
            try
            {
                DB.crud(@"SELECT p.id_pinjam AS 'ID',
                                 p.nama_peminjam AS 'Nama Peminjam',
                                 b.judul AS 'Judul Buku',
                                 p.tgl_pinjam AS 'Tgl Pinjam',
                                 p.tgl_jatuh_tempo AS 'Jatuh Tempo',
                                 p.status AS 'Status'
                          FROM t_peminjaman p
                          LEFT JOIN t_buku b ON p.id_buku = b.id_buku
                          WHERE p.status = 'di pinjam'
                          ORDER BY p.tgl_jatuh_tempo ASC");

                dgvPeminjamanAktif.DataSource = DB.ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data peminjaman: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            MuatStatistik();
            MuatPeminjamanAktif();
        }

        private void lblTanggal_Click(object sender, EventArgs e)
        {

        }

        private void panelDenda_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

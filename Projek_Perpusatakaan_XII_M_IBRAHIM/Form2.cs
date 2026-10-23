using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace Projek_Perpusatakaan_XII_M_IBRAHIM
{
    public partial class Form2 : Form
    {
        private string reportFileName;

        public Form2() : this("LAPORAN DATA PETUGAS.rpt")
        {

        }
        public Form2(string filename)
        {
            InitializeComponent();
            this.reportFileName = filename;
            this.Load += Form2_Load;
        }
        public Form2(ReportDocument rpt)
        {
            InitializeComponent();
            SetReport(rpt);
        }
        public void SetReport(ReportDocument rpt)
        {
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.Refresh();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(reportFileName))
            {
                TampilReport(reportFileName);
            }
        }
        public void TampilReport(string namaFile)
        {
            try
            {
                string reportPath = Path.Combine(Application.StartupPath, namaFile);
                if (!File.Exists(reportPath))
                {
                    string alternatifPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\" + namaFile);
                    if (File.Exists(alternatifPath))
                    {
                        reportPath = Path.GetFullPath(alternatifPath);
                    }
                }
                if (!File.Exists(reportPath))
                {
                    MessageBox.Show("File Laporan tidak di temukan");
                    return;
                }
                ReportDocument rpt = new ReportDocument();
                rpt.Load(reportPath);

                ConnectionInfo crConn = new ConnectionInfo();
                crConn.ServerName = "localhost";
                crConn.DatabaseName = "db_perpustakaan";
                crConn.UserID = "root";
                crConn.Password = "";

                foreach (Table crTabel in rpt.Database.Tables)
                {
                    TableLogOnInfo crlogon = crTabel.LogOnInfo;
                    crlogon.ConnectionInfo = crConn;
                    crTabel.ApplyLogOnInfo(crlogon);
                }
                SetReport(rpt);
            }
            catch (Exception e)
            {
                MessageBox.Show("Gagal Menampilkan Laporan : " + e.Message);
            }
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}

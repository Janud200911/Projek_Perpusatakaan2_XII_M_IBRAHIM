using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Projek_Perpusatakaan_XII_M_IBRAHIM
{
    class DB
    {
        public static MySqlConnection koneksi = new MySqlConnection("server=127.0.0.1; username='root'; password=''; database='db_perpustakaan'");
        public static DataSet ds = new DataSet();
        public static MySqlDataAdapter da;
        public static MySqlCommand perintah;

        public static void crud(string naonquerina)
        {
            Console.WriteLine(naonquerina);
            ds.Tables.Clear();
            perintah = new MySqlCommand(naonquerina, koneksi);
            da = new MySqlDataAdapter(perintah);
            da.Fill(ds);
        }   

    }
}

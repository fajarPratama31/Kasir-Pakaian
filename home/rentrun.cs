using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace home
{
    public partial class rentrun : Form
    {
        public rentrun()
        {
            InitializeComponent();
        }

        private void rentrun_Load(object sender, EventArgs e)
        {
            Koneksi.conn.Open();
            //MessageBox.Show("Koneksi Sukses");
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM `tblpelanggan`", Koneksi.conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dgret.DataSource = ds.Tables[0];

            Koneksi.conn.Close();
        }
    }
}

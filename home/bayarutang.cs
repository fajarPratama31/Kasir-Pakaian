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
    public partial class bayarutang : Form
    {
        public bayarutang()
        {
            InitializeComponent();
        }

        private void bayarutang_Load(object sender, EventArgs e)
        {
            Koneksi.conn.Open();
            //MessageBox.Show("Koneksi Sukses");
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM `tblhutang", Koneksi.conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dguta.DataSource = ds.Tables[0];

            Koneksi.conn.Close();
        }
    }
}

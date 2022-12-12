using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace home
{
    public partial class penjualan : Form
    {
        Koneksi koneksi = new Koneksi();

        public void Tampil()
        {
            //Query Database
            Table1.DataSource = koneksi.ShowData("SELECT * FROM tbldetailjual");
        }
        public penjualan()
        {
            InitializeComponent();
        }

        private void penjualan_Load(object sender, EventArgs e)
        {
            Tampil();
        }

        private void Table1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Table1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

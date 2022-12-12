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
    public partial class transaksi : Form
    {
        public transaksi()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            penjualan penjualan = new penjualan();
            penjualan.ShowDialog();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Hide();
            bayarutang bayarutang = new bayarutang();
            bayarutang.ShowDialog();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Hide();
            rentrun rentrun = new rentrun();
            rentrun.ShowDialog();  
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

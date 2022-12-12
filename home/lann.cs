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
    public partial class lann : Form
    {
        public lann()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            indentitas indentitas = new indentitas();
            indentitas.ShowDialog();
        }

       
            
        

        private void button12_Click(object sender, EventArgs e)
            {
                this.Hide();
                barang barang = new barang();
                barang.ShowDialog();
            }

            private void button1_Click(object sender, EventArgs e)
            {
                this.Hide();
                pelanggan pelanggan = new pelanggan();
                pelanggan.ShowDialog();
            }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Hide();
            kategori kategori = new kategori();
            kategori.ShowDialog();

        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            barang br = new barang();
            br.ShowDialog();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            pelanggan az = new pelanggan();
            az.ShowDialog();
            this.Hide();
                
                
        }
    }
}

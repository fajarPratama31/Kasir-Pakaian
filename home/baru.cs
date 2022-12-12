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
    public partial class baru : Form
    {
        public baru()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        { 
            this.Hide();
            lann ln = new lann();
            ln.ShowDialog();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void baru_Load(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        { 
            this.Hide();
            transaksi transaksi = new transaksi();
            transaksi.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try

            {

                Koneksi.conn.Open();

                MessageBox.Show("Koneksi Database Berhasil");

            }

            catch (Exception)

            {

                 MessageBox.Show("Koneksi Gagal");

            }
        }
    }
}

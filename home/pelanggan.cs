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
    public partial class pelanggan : Form
    {
        public pelanggan()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            indentitas indentitas = new indentitas();
            indentitas.Show();  
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Hide();
            kategori kategori = new kategori();
            kategori.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Hide();
            barang barang = new barang();
            barang.Show();
        }

        void Tampil()
        {
            try
            {
                Koneksi.conn.Open();
                //MessageBox.Show("Koneksi Sukses");
                MySqlDataAdapter Adapter = new MySqlDataAdapter("SELECT * FROM `tblidentitas`", Koneksi.conn);
                DataSet ds = new DataSet();
                Adapter.Fill(ds);
                dgpelang.DataSource = ds.Tables[0];

                Koneksi.conn.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Terjadi Kesalahan");
            }
        }


        private void pelanggan_Load(object sender, EventArgs e)
        {
            Tampil();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

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
using Org.BouncyCastle.Crypto.Tls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace home
{
    public partial class barang : Form
    {
        private MySqlCommand cmd;

        public barang()
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            pelanggan pelanggan = new pelanggan();
            pelanggan.Show();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        void lihat()
        {
            try
            {
                Koneksi.conn.Open();
                //MessageBox.Show("Koneksi Sukses");
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM `tblbarang`", Koneksi.conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dgbars.DataSource = ds.Tables[0];

                Koneksi.conn.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("error");
            }
        }

        private void barang_Load(object sender, EventArgs e)
        {
            lihat();
        }

        private void combobarang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi.conn.Open();
                cmd = new MySqlCommand("INSERT INTO `tblbarang` (`idbarang`, `idkategori`, `namabarang`, `deskripsi`, `harga`, `stock`, `ukuran`) VALUES (NULL, '" + combobarang.SelectedItem + "', '" + textbrng.Text + "', '" + textdeks.Text + "', '" + texthrga.Text + "', '" + textstk.Text + "', '" + textukr.Text + "');", Koneksi.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Talah Di Tambahkan");
                Koneksi.conn.Close();
                lihat();
            }
            catch (Exception)
            {

                MessageBox.Show("Datanya Gagal Di Tambahkan");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi.conn.Open();
                cmd = new MySqlCommand("UPDATE `tblbarang` SET `idkategori` = '" + combobarang.SelectedItem + "', `namabarang` = '" + textbrng.Text + "', `deskripsi` = '" + textdeks.Text + "', `harga` = '" + texthrga.Text + "', `stock` = '" + textstk.Text + "', `ukuran` = '" + textukr.Text + "' WHERE `tblbarang`.`idbarang` = '" + lblIDS + "';", Koneksi.conn);
                cmd.ExecuteNonQuery();
                Koneksi.conn.Close();
                lihat();
            }
            catch (Exception)
            {

                MessageBox.Show("Update Gagal");
            }
        }

        private void dgbar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int baris = dgbars.CurrentCell.RowIndex;
            lblIDS.Text = dgbars.Rows[baris].Cells[0].Value.ToString();
            // MessageBox.Show(baris.ToString());
            textbrng.Text = dgbars.Rows[baris].Cells[1].Value.ToString();
            textdeks.Text = dgbars.Rows[baris].Cells[2].Value.ToString();
            textukr.Text = dgbars.Rows[baris].Cells[3].Value.ToString();
            texthrga.Text = dgbars.Rows[baris].Cells[4].Value.ToString();
            textstk.Text = dgbars.Rows[baris].Cells[5].Value.ToString();
            btnbrngdlt.Enabled = true;
            btnbrngedt.Enabled = true;
            btnsimpanbrng.Enabled = false;
            btnbrngtmbh.Enabled = false;
            btncncelbrng.Enabled = true;
            textbrng.Enabled = true;
            textdeks.Enabled = true;
            textukr.Enabled = true;
            texthrga.Enabled = true;
            textstk.Enabled = true;
        }

        private void texthrga_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

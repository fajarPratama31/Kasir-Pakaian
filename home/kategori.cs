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
using Org.BouncyCastle.Utilities.Collections;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace home
{
    public partial class kategori : Form
    {
        private MySqlCommand cmd;

        public kategori()
        {
            InitializeComponent();
        }


        private void kategori_Load(object sender, EventArgs e)
        {

            tampil();
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Hide();
            pelanggan pelanggan = new pelanggan();
            pelanggan.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Hide();
            barang barang = new barang();
            barang.ShowDialog();
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            indentitas indentitas = new indentitas();
            indentitas.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        void tampil()
        {
            try
            {
                Koneksi.conn.Open();
                //MessageBox.Show("Koneksi Sukses");
                MySqlDataAdapter Adapter = new MySqlDataAdapter("SELECT * FROM `tblkategori`", Koneksi.conn);
                DataSet ds = new DataSet();
                Adapter.Fill(ds);
                dgkates.DataSource = ds.Tables[0];

                Koneksi.conn.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Terjadi Kesalahan");
            }


        }

        private void btubah_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi.conn.Open();
                cmd = new MySqlCommand("UPDATE `tblkategori` SET `namakategori` = '" + tbkategori.Text + "' WHERE `tblkategori`.`idkategori` = '" + idlabel.Text + "'; ", Koneksi.conn);
                cmd.ExecuteNonQuery();
                Koneksi.conn.Close();
                tampil();
            }
            catch (Exception)

            {

                MessageBox.Show("Update Gagal");
            }
        }

        private void btsimpan_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi.conn.Open();
                cmd = new MySqlCommand("UPDATE `tblkategori` SET `namakategori` = '" + tbkategori.Text + "' WHERE `tblkategori`.`idkategori` = '" + idlabel.Text + "'; ", Koneksi.conn);
                cmd.ExecuteNonQuery();
                Koneksi.conn.Close();
                tampil();
            }
            catch (Exception)
            {

                MessageBox.Show("Update Gagal");
            }
        }

        private void btcancel_Click(object sender, EventArgs e)
        {
            tbkategori.Enabled = false;
            tbkategori.Text = null;
            btsimpan.Enabled = false;
            btubah.Enabled = false;
            btsumbit.Enabled = true;
            btdel.Enabled = false;
            btcancel.Enabled = false;
        }

        private void btsumbit_Click(object sender, EventArgs e)
        {
            tbkategori.Enabled = true;
            btcancel.Enabled = true;
            btsimpan.Enabled = true;
        }

        private void dgkate_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int baris = dgkates.CurrentCell.RowIndex;
            idlabel.Text = dgkates.Rows[baris].Cells[0].Value.ToString();
            // MessageBox.Show(baris.ToString());
            tbkategori.Text = dgkates.Rows[baris].Cells[1].Value.ToString();
            btdel.Enabled = true;
            btubah.Enabled = true;
            btsimpan.Enabled = false;
            btsumbit.Enabled = false;
            btcancel.Enabled = true;
            tbkategori.Enabled = true;
        }

        private void tbkategori_TextChanged(object sender, EventArgs e)
        {

        }

        private void idlabel_Click(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void btSearchkt_Click(object sender, EventArgs e)
        {
            Koneksi.conn.Open();
            //MessageBox.Show("Koneksi Sukses");
            MySqlDataAdapter Adapter = new MySqlDataAdapter("SELECT * FROM `tblkategori` WHERE `namakategori` LIKE '%" + seackt.Text + "%'", Koneksi.conn);
            DataSet ds = new DataSet();
            Adapter.Fill(ds);
            dgkates.DataSource = ds.Tables[0];
            // w3school wildcard sql server
            Koneksi.conn.Close();
        }
    }
}

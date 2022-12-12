using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Collections;

namespace home
{
    public partial class indentitas : Form
    {
        private MySqlCommand cmd;


        public indentitas()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Hide();
            kategori kategori = new kategori();
            kategori.ShowDialog();
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

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
                dgiden.DataSource = ds.Tables[0];

                Koneksi.conn.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Terjadi Kesalahan");
            }
}

        private void indentitas_Load(object sender, EventArgs e)
        {
            Tampil();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }

        private void dgiden_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int baris = dgiden.CurrentCell.RowIndex;
            idLabel.Text = dgiden.Rows[baris].Cells[0].Value.ToString();
            // MessageBox.Show(baris.ToString());
            textBox8.Text = dgiden.Rows[baris].Cells[1].Value.ToString();
            textBox3.Text = dgiden.Rows[baris].Cells[2].Value.ToString();
            textBox10.Text = dgiden.Rows[baris].Cells[3].Value.ToString();
            textBox11.Text = dgiden.Rows[baris].Cells[4].Value.ToString();
            textBox12.Text = dgiden.Rows[baris].Cells[5].Value.ToString();
            textBox13.Text = dgiden.Rows[baris].Cells[6].Value.ToString();
            textBox8.Enabled = true;
            textBox3.Enabled = true;
            textBox10.Enabled = true;
            textBox11.Enabled = true;
            textBox12.Enabled = true;
            textBox13.Enabled = true;
            btdel.Enabled = true;
            btubah.Enabled = true;
            btsimpan.Enabled = false;
            btsumbit.Enabled = false;
            btcancel.Enabled = true;



        }

        private void button10_Click(object sender, EventArgs e)
        {
            button10.Enabled = false;
        }

        private void btdel_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi.conn.Open();
                cmd = new MySqlCommand("DELETE FROM tblidentitas WHERE `tblidentitas`.`ididentitas` = '" + idLabel.Text + "'", Koneksi.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Berhasil Hapus Data Siswa");
                Koneksi.conn.Close();
                Tampil();
            }
            catch (Exception)
            {

                MessageBox.Show("HAPUS Data Gagal");
            }
        }

        private void btsumbit_Click(object sender, EventArgs e)
        {
            textBox8.Enabled = true;
            textBox3.Enabled = true;
            textBox10.Enabled = true;
            textBox11.Enabled = true;
            textBox12.Enabled = true;
            textBox13.Enabled = true;
            btcancel.Enabled = true;
            btsimpan.Enabled = true;
            btsumbit.Enabled = false;
        }

        private void btsimpan_Click_1(object sender, EventArgs e)
        {
           
            try
            {
                Koneksi.conn.Open();
                cmd = new MySqlCommand("INSERT INTO `tblidentitas` (`ididentitas`, `namatoko`, `alamattoko`, `notelp`, `captionpertama`, `captionkedua`, `captionketiga`) VALUES(NULL, '"+textBox8.Text+"', '"+textBox3.Text+"', '"+textBox10.Text+"', '"+textBox11.Text+"', '"+textBox12.Text+"', '"+textBox13.Text+"');", Koneksi.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Talah Di Tambahkan");
                Koneksi.conn.Close();
                Tampil();
            }
            catch (Exception)
            {

                MessageBox.Show("Datanya Gagal Di Tambahkan");
            }
        }

        private void btubah_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi.conn.Open();
                cmd = new MySqlCommand("UPDATE `tblidentitas` SET `namatoko` = '"+textBox8.Text+"', `alamattoko` = '"+textBox3.Text+"', `notelp` = '"+textBox10.Text+ "', `captionpertama` = '"+textBox11.Text+ "', `captionkedua` = '"+textBox12.Text+ "', `captionketiga` = '"+textBox13.Text+"' WHERE `tblidentitas`.`ididentitas` = '"+idLabel.Text+"'; ", Koneksi.conn);
                cmd.ExecuteNonQuery();
                Koneksi.conn.Close();
                Tampil();
            }
            catch (Exception)
            {

                MessageBox.Show("Update Gagal");
            }
        }

        private void btcancel_Click(object sender, EventArgs e)
        {
            textBox8.Enabled = false;
            textBox8.Text = null;
            textBox3.Enabled = false;
            textBox3.Text = null;
            textBox10.Enabled = false;
            textBox10.Text = null;
            textBox11.Enabled = false;
            textBox11.Text = null;
            textBox12.Enabled = false;
            textBox12.Text = null;
            textBox13.Enabled = false;
            textBox13.Text = null;
            btsimpan.Enabled = false;
            btubah.Enabled = false;
            btsumbit.Enabled = true;
            btdel.Enabled = false;
            btcancel.Enabled = false;
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
               
        }


        private void btSearch_Click(object sender, EventArgs e)
        {
             Koneksi.conn.Open();
            //MessageBox.Show("Koneksi Sukses");
            MySqlDataAdapter Adapter = new MySqlDataAdapter("SELECT * FROM `tblidentitas` WHERE `namatoko` LIKE '%" +tbSearch.Text+ "%'", Koneksi.conn);
            DataSet ds = new DataSet();
            Adapter.Fill(ds);
            dgiden.DataSource = ds.Tables[0];
            // w3school wildcard sql server
            Koneksi.conn.Close();
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

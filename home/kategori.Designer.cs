using System.Windows.Forms;

namespace home
{
    partial class kategori
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kategori));
            this.button8 = new System.Windows.Forms.Button();
            this.seackt = new System.Windows.Forms.TextBox();
            this.dgkates = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button12 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button13 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button10 = new System.Windows.Forms.Button();
            this.tbkategori = new System.Windows.Forms.TextBox();
            this.btsimpan = new System.Windows.Forms.Button();
            this.btcancel = new System.Windows.Forms.Button();
            this.btubah = new System.Windows.Forms.Button();
            this.btdel = new System.Windows.Forms.Button();
            this.btsumbit = new System.Windows.Forms.Button();
            this.idlabel = new System.Windows.Forms.Label();
            this.btSearchkt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgkates)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.SteelBlue;
            this.button8.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(385, -1);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(982, 61);
            this.button8.TabIndex = 129;
            this.button8.Text = "KATEGORI";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // seackt
            // 
            this.seackt.Location = new System.Drawing.Point(1040, 312);
            this.seackt.Multiline = true;
            this.seackt.Name = "seackt";
            this.seackt.Size = new System.Drawing.Size(287, 27);
            this.seackt.TabIndex = 128;
            this.seackt.TextChanged += new System.EventHandler(this.textBox14_TextChanged);
            // 
            // dgkates
            // 
            this.dgkates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgkates.Location = new System.Drawing.Point(449, 353);
            this.dgkates.Name = "dgkates";
            this.dgkates.Size = new System.Drawing.Size(878, 228);
            this.dgkates.TabIndex = 127;
            this.dgkates.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgkate_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(481, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 22);
            this.label1.TabIndex = 115;
            this.label1.Text = "Nama Kategori :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.textBox7);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.textBox6);
            this.panel1.Controls.Add(this.button12);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.button13);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.button10);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(386, 749);
            this.panel1.TabIndex = 108;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.IndianRed;
            this.button2.Enabled = false;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(78, 601);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(230, 64);
            this.button2.TabIndex = 140;
            this.button2.Text = "KEMBALI";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SlateGray;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(36, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(317, 21);
            this.label2.TabIndex = 138;
            this.label2.Text = "Kelola toko dimana saja dan kapan saja ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.SlateGray;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(2, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(383, 42);
            this.label3.TabIndex = 137;
            this.label3.Text = "KASIR TOKO PAKAIAN";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(387, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(430, 87);
            this.panel2.TabIndex = 64;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(239, 486);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(68, 70);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 57;
            this.pictureBox4.TabStop = false;
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.SteelBlue;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.ForeColor = System.Drawing.Color.White;
            this.textBox7.Location = new System.Drawing.Point(54, 505);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(165, 39);
            this.textBox7.TabIndex = 56;
            this.textBox7.Text = "Pelanggan";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.Location = new System.Drawing.Point(23, 477);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(332, 88);
            this.button1.TabIndex = 55;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(74, 364);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(58, 69);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 54;
            this.pictureBox3.TabStop = false;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.SteelBlue;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.ForeColor = System.Drawing.Color.White;
            this.textBox6.Location = new System.Drawing.Point(169, 380);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(146, 39);
            this.textBox6.TabIndex = 53;
            this.textBox6.Text = "Barang ";
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.SteelBlue;
            this.button12.Location = new System.Drawing.Point(23, 353);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(332, 88);
            this.button12.TabIndex = 52;
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(243, 237);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(61, 78);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 51;
            this.pictureBox2.TabStop = false;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.SteelBlue;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.ForeColor = System.Drawing.Color.White;
            this.textBox5.Location = new System.Drawing.Point(54, 256);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(183, 39);
            this.textBox5.TabIndex = 50;
            this.textBox5.Text = "Kategori";
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.SteelBlue;
            this.button13.Location = new System.Drawing.Point(23, 231);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(332, 88);
            this.button13.TabIndex = 49;
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(89, 120);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.SteelBlue;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.Color.White;
            this.textBox4.Location = new System.Drawing.Point(184, 138);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(122, 36);
            this.textBox4.TabIndex = 46;
            this.textBox4.Text = "Identitas";
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.SteelBlue;
            this.button10.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button10.Location = new System.Drawing.Point(23, 113);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(332, 88);
            this.button10.TabIndex = 42;
            this.button10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click_1);
            // 
            // tbkategori
            // 
            this.tbkategori.Enabled = false;
            this.tbkategori.Location = new System.Drawing.Point(485, 121);
            this.tbkategori.Multiline = true;
            this.tbkategori.Name = "tbkategori";
            this.tbkategori.Size = new System.Drawing.Size(542, 29);
            this.tbkategori.TabIndex = 116;
            this.tbkategori.TextChanged += new System.EventHandler(this.tbkategori_TextChanged);
            // 
            // btsimpan
            // 
            this.btsimpan.BackColor = System.Drawing.Color.SteelBlue;
            this.btsimpan.Enabled = false;
            this.btsimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btsimpan.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsimpan.ForeColor = System.Drawing.Color.White;
            this.btsimpan.Location = new System.Drawing.Point(1167, 601);
            this.btsimpan.Name = "btsimpan";
            this.btsimpan.Size = new System.Drawing.Size(166, 64);
            this.btsimpan.TabIndex = 134;
            this.btsimpan.Text = "SIMPAN";
            this.btsimpan.UseVisualStyleBackColor = false;
            this.btsimpan.Click += new System.EventHandler(this.btsimpan_Click);
            // 
            // btcancel
            // 
            this.btcancel.BackColor = System.Drawing.Color.SteelBlue;
            this.btcancel.Enabled = false;
            this.btcancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btcancel.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcancel.ForeColor = System.Drawing.Color.White;
            this.btcancel.Location = new System.Drawing.Point(978, 601);
            this.btcancel.Name = "btcancel";
            this.btcancel.Size = new System.Drawing.Size(178, 64);
            this.btcancel.TabIndex = 133;
            this.btcancel.Text = "BATAL";
            this.btcancel.UseVisualStyleBackColor = false;
            this.btcancel.Click += new System.EventHandler(this.btcancel_Click);
            // 
            // btubah
            // 
            this.btubah.BackColor = System.Drawing.Color.SteelBlue;
            this.btubah.Enabled = false;
            this.btubah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btubah.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btubah.ForeColor = System.Drawing.Color.White;
            this.btubah.Location = new System.Drawing.Point(598, 601);
            this.btubah.Name = "btubah";
            this.btubah.Size = new System.Drawing.Size(178, 64);
            this.btubah.TabIndex = 132;
            this.btubah.Text = "UBAH";
            this.btubah.UseVisualStyleBackColor = false;
            this.btubah.Click += new System.EventHandler(this.btubah_Click);
            // 
            // btdel
            // 
            this.btdel.BackColor = System.Drawing.Color.SteelBlue;
            this.btdel.Enabled = false;
            this.btdel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btdel.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdel.ForeColor = System.Drawing.Color.White;
            this.btdel.Location = new System.Drawing.Point(788, 601);
            this.btdel.Name = "btdel";
            this.btdel.Size = new System.Drawing.Size(178, 64);
            this.btdel.TabIndex = 131;
            this.btdel.Text = "HAPUS";
            this.btdel.UseVisualStyleBackColor = false;
            // 
            // btsumbit
            // 
            this.btsumbit.BackColor = System.Drawing.Color.SteelBlue;
            this.btsumbit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btsumbit.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsumbit.ForeColor = System.Drawing.Color.White;
            this.btsumbit.Location = new System.Drawing.Point(408, 601);
            this.btsumbit.Name = "btsumbit";
            this.btsumbit.Size = new System.Drawing.Size(178, 64);
            this.btsumbit.TabIndex = 130;
            this.btsumbit.Text = "TAMBAH";
            this.btsumbit.UseVisualStyleBackColor = false;
            this.btsumbit.Click += new System.EventHandler(this.btsumbit_Click);
            // 
            // idlabel
            // 
            this.idlabel.AutoSize = true;
            this.idlabel.Location = new System.Drawing.Point(449, 334);
            this.idlabel.Name = "idlabel";
            this.idlabel.Size = new System.Drawing.Size(18, 13);
            this.idlabel.TabIndex = 135;
            this.idlabel.Text = "ID";
            this.idlabel.Click += new System.EventHandler(this.idlabel_Click);
            // 
            // btSearchkt
            // 
            this.btSearchkt.BackColor = System.Drawing.Color.SteelBlue;
            this.btSearchkt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSearchkt.ForeColor = System.Drawing.Color.Transparent;
            this.btSearchkt.Location = new System.Drawing.Point(952, 316);
            this.btSearchkt.Name = "btSearchkt";
            this.btSearchkt.Size = new System.Drawing.Size(75, 23);
            this.btSearchkt.TabIndex = 136;
            this.btSearchkt.Text = "Search";
            this.btSearchkt.UseVisualStyleBackColor = false;
            this.btSearchkt.Click += new System.EventHandler(this.btSearchkt_Click);
            // 
            // kategori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.btSearchkt);
            this.Controls.Add(this.idlabel);
            this.Controls.Add(this.btsimpan);
            this.Controls.Add(this.btcancel);
            this.Controls.Add(this.btubah);
            this.Controls.Add(this.btdel);
            this.Controls.Add(this.btsumbit);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.seackt);
            this.Controls.Add(this.dgkates);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbkategori);
            this.Name = "kategori";
            this.Text = "kategori";
            this.Load += new System.EventHandler(this.kategori_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgkates)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox seackt;
        private System.Windows.Forms.DataGridView dgkates;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.TextBox tbkategori;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btsimpan;
        private System.Windows.Forms.Button btcancel;
        private System.Windows.Forms.Button btubah;
        private System.Windows.Forms.Button btdel;
        private System.Windows.Forms.Button btsumbit;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label idlabel;
        private DataGridViewCellEventHandler dgkate_CellClick;
        private Button btSearchkt;
    }
}
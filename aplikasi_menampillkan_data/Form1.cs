﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aplikasi_menampillkan_data
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String user = nama.Text;
            String makananFav = makanan.Text;
            String warnaFav = warna.Text;
            kesimpulan.Text = "Selamat datang "+user +"\n" +
                "Makanan favorite : "+ makananFav + "\n" +
                "Warna favorite : "+ warnaFav;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nama.Text = "";
            makanan.Text = "";
            warna.Text = "";
            kesimpulan.Text = "";
        }
    }
}

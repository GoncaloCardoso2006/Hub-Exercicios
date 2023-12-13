﻿using Hub_Exercicios.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hub_Exercicios
{
    public partial class Ex6 : Form
    {
        public Ex6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int comp = Convert.ToInt32(textBox1.Text);
            int larg = Convert.ToInt32(textBox2.Text);
            int altura = Convert.ToInt32(textBox3.Text);

            int area = comp * larg;
            int perimetro = 2 * (comp + larg);
            int volume = area * altura;

            listBox1.Items.Add("Area " + area);
            listBox1.Items.Add("Perimetro " + perimetro);
            listBox1.Items.Add("Volume " + volume);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            listBox1.Items.Clear();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            label4.Text = Utilizador.nome;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hub frm_1 = new Hub();
            frm_1.Show();
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

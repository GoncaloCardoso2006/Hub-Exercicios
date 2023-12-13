using Hub_Exercicios.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hub_Exercicios
{
    public partial class Ex3 : Form
    {
        public Ex3()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Isto é uma caixa de texto";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BackColor = Color.Red;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = (Color.Red);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BackColor = Color.Black;
            textBox1.ForeColor = default(Color);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Hub frm_1 = new Hub();
            frm_1.Show();
            this.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            label2.Text = Utilizador.nome;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

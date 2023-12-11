using Hub_Exercicios.Class;
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
    public partial class F_Ex16 : Form
    {

        public F_Ex16()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hub frm_1 = new Hub();
            frm_1.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Utilizador.nome = "Utilizador : " + textBox1.Text; 
            label4.Text = Utilizador.nome;
            MessageBox.Show("Dados iseridos foram guardados com sucesso! :)");
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox3.UseSystemPasswordChar = false;
            }
            else
            {
                textBox3.UseSystemPasswordChar = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        { }

        private void textBox2_TextChanged(object sender, EventArgs e)
        { }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.UseSystemPasswordChar = true;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
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
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }

        private void Form15_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(textBox1.Text);
            Class_VG.resultado = num1 + Class_VG.resultado;
            textBox1.Text = Convert.ToString(Class_VG.resultado);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form16 frm16 = new Form16();
            frm16.Show();
            this.Hide();
        }
    }
}

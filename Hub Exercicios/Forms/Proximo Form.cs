using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hub_Exercicios.Class;

namespace Hub_Exercicios
{
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            F_Ex14 frm15 = new F_Ex14();
            frm15.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(textBox1.Text);
            Class_VG.resultado = num1 + Class_VG.resultado;
            textBox1.Text = Convert.ToString(Class_VG.resultado);
        }

        private void Form16_Load(object sender, EventArgs e)
        {
            label1.Text = Utilizador.nome;
        }
    }
}

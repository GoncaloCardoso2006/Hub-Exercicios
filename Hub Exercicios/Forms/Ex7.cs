using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hub_Exercicios
{
    public partial class Ex7 : Form
    {
        public Ex7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hub frm_1 = new Hub();
            frm_1.Show();
            this.Close();
        }

        private void Form8_Load(object sender, EventArgs e)
        { }

        private void button2_Click(object sender, EventArgs e)
        {
            int numero1 = Convert.ToInt32(Interaction.InputBox("Inserir 1 numero", "Input Box", "Insere um valor na seguinte textbox."));
            int numero2 = Convert.ToInt32(Interaction.InputBox("Inserir 2 numero", "Input Box", "Insere um valor na seguinte textbox."));
            textBox1.Text = "Valor da soma: " + (numero1 + numero2);
        }
    }
}

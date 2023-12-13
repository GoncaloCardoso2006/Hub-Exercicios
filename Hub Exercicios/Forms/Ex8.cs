using Hub_Exercicios.Class;
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

namespace Hub_Exercicios
{
    public partial class Ex8 : Form
    {
        public Ex8()
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
            int numero1 = Convert.ToInt32(Interaction.InputBox("Inserir 1 número", "Input Box", "Insira um valor na seguinte textbox."));
            int numero2 = Convert.ToInt32(Interaction.InputBox("Inserir 2 número", "Input Box", "Insira um valor na seguinte textbox."));

            int resultado = 0;

            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    resultado = numero1 + numero2;
                    break;
                case 1:
                    resultado = numero1 - numero2;
                    break;
                case 2:
                    resultado = numero1 * numero2;
                    break;
                case 3:
                    resultado = numero1 / numero2;
                    break;
                default:
                    break;

            }

            textBox1.Text = "Resultado: " + resultado;
        }

        private void Ex8_Load(object sender, EventArgs e)
        {
            label1.Text = Utilizador.nome;
        }
    }
}

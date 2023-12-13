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
    public partial class F_Ex10 : Form
    {
        public F_Ex10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pass = Interaction.InputBox("", "Input Box", "password");
            if (pass == "coisas21")
                MessageBox.Show("Bem vindo");
            else
                MessageBox.Show("Password não está correta");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hub frm_1 = new Hub();
            frm_1.Show();
            this.Close();
        }

        private void F_Ex10_Load(object sender, EventArgs e)
        {
            label3.Text = Utilizador.nome;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

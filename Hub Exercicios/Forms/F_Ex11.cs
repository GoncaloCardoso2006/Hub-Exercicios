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
    public partial class F_Ex11 : Form
    {
        public F_Ex11()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hub frm_1 = new Hub();
            frm_1.Show();
            this.Close();
        }

        private void formatarToolStripMenuItem_Click(object sender, EventArgs e)
        { }

        private void corETipoDeLetraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cor = new ColorDialog();
            if (cor.ShowDialog() == DialogResult.OK)
            {
                label1.ForeColor = cor.Color;
            }
            FontDialog letra = new FontDialog();
            if (letra.ShowDialog() == DialogResult.OK)
            {
                label1.Font = letra.Font;
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        { }

        private void F_Ex11_Load(object sender, EventArgs e)
        {
            label1.Text = Utilizador.nome;
        }
    }
}

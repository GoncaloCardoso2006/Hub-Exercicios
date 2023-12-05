using Hub_Exercicios.Class;

namespace Hub_Exercicios
{
    public partial class Hub : Form
    {
        public Hub()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    Ex1 frm_2 = new Ex1();
                    frm_2.Show();
                    this.Hide();
                    break;
                case 1:
                    Ex2 frm_3 = new Ex2();
                    frm_3.Show();
                    this.Hide();
                    break;
                case 2:
                    Ex3 frm_4 = new Ex3();
                    frm_4.Show();
                    this.Hide();
                    break;
                case 3:
                    Ex4 frm_5 = new Ex4();
                    frm_5.Show();
                    this.Hide();
                    break;
                case 4:
                    Ex5 frm_6 = new Ex5();
                    frm_6.Show();
                    this.Hide();
                    break;
                case 5:
                    Ex6 frm_7 = new Ex6();
                    frm_7.Show();
                    this.Hide();
                    break;
                case 6:
                    Ex7 frm_8 = new Ex7();
                    frm_8.Show();
                    this.Hide();
                    break;
                case 7:
                    Ex8 frm_9 = new Ex8();
                    frm_9.Show();
                    this.Hide();
                    break;
                case 8:
                    Ex9 frm_10 = new Ex9();
                    frm_10.Show();
                    this.Hide();
                    break;
                case 9:
                    F_Ex10 frm_11 = new F_Ex10();
                    frm_11.Show();
                    this.Hide();
                    break;
                case 10:
                    F_Ex11 frm12 = new F_Ex11();
                    frm12.Show();
                    this.Hide();
                    break;
                case 11:
                    F_Ex12 frm13 = new F_Ex12();
                    frm13.Show();
                    this.Hide();
                    break;
                case 12:
                    F_Ex13 frm14 = new F_Ex13();
                    frm14.Show();
                    this.Hide();
                    break;
                case 13:
                    F_Ex14 frm15 = new F_Ex14();
                    frm15.Show();
                    this.Hide();
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        { }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        { }

        private void button2_Click(object sender, EventArgs e)
        {
            FecharTudo.FecharFormularios();
        }
    }
}
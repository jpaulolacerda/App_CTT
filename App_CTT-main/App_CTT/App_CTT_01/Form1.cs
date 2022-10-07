namespace App_CTT_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)//Gasolina
        {
            double G;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)//Alcool
        {
            double A;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)//Ra
        {
            double Ra;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)//Rg
        {
            double Rg;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double A, G, Rg, Ra, mG, mA;

            A = double.Parse(textBox1.Text);
            G = double.Parse(textBox2.Text);
            Ra = 7; //double.Parse(textBox3.Text);
            Rg = 10; //double.Parse(textBox4.Text);

            mA = A / Ra;
            mG = G / Rg;


            if (mG <= mA)
            {
                label1.Text = "Gasolina";
            }
            else
            {
                label1.Text = "Alcool";
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
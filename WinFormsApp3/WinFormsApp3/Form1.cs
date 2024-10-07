namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Veuiller entrer des valeurs pour tous les champs");
            }
            else
            {
                double a = Convert.ToDouble(textBox1.Text);
                double b = Convert.ToDouble(textBox2.Text);
                double c = Convert.ToDouble(textBox3.Text);

                equationDegre(a, b, c);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            label4.Text = "";
        }

        void equationDegre(double i, double j, double k)
        {
            double l;
            l = (j * j) - 4 * i * k;

            if (l < 0)
            {
                label4.Text = "Pas de racine pour ces valeurs";
            }
            else if (l == 0)
            {
                double m;
                m = -j / (2 * i);
                label4.Text = "la valeur de x = " + m.ToString();
            }
            else
            {
                double n, o;
                n = (-j + Math.Sqrt(l)) / (2 * i);
                o = (-j - Math.Sqrt(l)) / (2 * i);

                label4.Text = "la valeur x1 = " + n.ToString() + " \n et \n la valeur de x2 = " + o.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
    }
}

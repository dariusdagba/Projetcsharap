using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Veuillez entrer une valeur comprise entre 1 et 6 ");
            }
            else
            {
                int c = Convert.ToInt32(textBox1.Text);
                tirageNombre(c);
            }

        }
        void tirageNombre(int r)
        {
            Random random = new Random();
            int nbr = random.Next(1, 6);


            if (r == nbr)
            {
                label2.Text = "Bravo, vous avez gagné";
            }
            else
            {
                label2.Text = "Meilleure chance la prochaine fois";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
           Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }
    }
}

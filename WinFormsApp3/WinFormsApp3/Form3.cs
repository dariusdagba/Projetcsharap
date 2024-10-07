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

namespace WinFormsApp3
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int p = Convert.ToInt32(textBox1.Text);
            if (textBox1.Text=="")
            {
                MessageBox.Show("Saisir un entier svp");
            }
            else if(p<2 ||p >20)
            {
                MessageBox.Show("Veuillez entrer une valeur entre 2-20 ");
            }
            else
            {
                listBox1.Items.Clear();

                listBox1.Items.Add(p + "\n");
                afficheMultiplication(p);
            }
            
           
        }
        void afficheMultiplication(int nb)
        {
            for (int i = 1; i <= nb; i++)
            {
                listBox1.Items.Add(i + "\t");
                for (int j = 1; j <=nb; j++) 
                {
                    listBox1.Items.Add(j + "\t");
                    int c = i * j;
                    listBox1.Items.Add(c + "\t");
                }
                listBox1.Items.Add("\t");
               
            }
        }
    }
}

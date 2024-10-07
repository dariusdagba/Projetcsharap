using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormApp2
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            listBox1.Items.Remove(listBox1.SelectedItem);

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == " ")
            {
                MessageBox.Show("Saisir svp une chaine de caractères");
            }
            else
            {
                listBox1.Items.AddRange(textBox1.Text.Split(' '));
            }


            /*  string texte =textBox1.Text;

              string[] mots = texte.Split(' ');
           foreach (string s in mots)
          {
              listBox1.Items.Add(s);
          }*/




        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

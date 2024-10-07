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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();

        }

        int nextId = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="" || textBox2.Text==""||textBox3.Text=="")
            {
                MessageBox.Show("Entrer votre nom, prenom et sexe");
            }
            else
            {
                
                
                dataGridView1.ColumnCount=4;
                dataGridView1.Columns[0].Name = "ID";
                dataGridView1.Columns[1].Name = "Nom";
                dataGridView1.Columns[2].Name = "Prenom";
                dataGridView1.Columns[3].Name = "Sexe";

                
                
                dataGridView1.Rows.Add(nextId, textBox1.Text, textBox2.Text, textBox3.Text);
                nextId++;
                
                


            }
        }
    }
}

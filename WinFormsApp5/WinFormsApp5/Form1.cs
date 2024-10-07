using System.Security.Cryptography.X509Certificates;

namespace WinFormsApp5
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            //ajout des soupes
            comboBox1.Items.Add("Soupe aux légumes");
            comboBox1.Items.Add("Soupe aux pois");
            comboBox1.Items.Add("Soupe aux gourganes");
            comboBox1.Items.Add("Soupe aux boulettes de boeufs");
            comboBox1.Items.Add("Potage aux champignons");


            // ajout des plats d'entrée
            comboBox2.Items.Add("Chaudrée de seiches");
            comboBox2.Items.Add("Pétoncles aux basilic");
            comboBox2.Items.Add("Tartare aux tomates");
            comboBox2.Items.Add("Chaudrée du pêcheur");
            comboBox2.Items.Add("Mozzarella aux bacon");


            //ajout des plats principaux
            comboBox3.Items.Add("Spagettis à la crème de poivrons");
            comboBox3.Items.Add("Riz cantonais aux crevettes");
            comboBox3.Items.Add("Cari de boeuf massalé");
            comboBox3.Items.Add("Tajine de poulet marocain aux légumes");
            comboBox3.Items.Add("Cari de dorade au combava");

            listBox2.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                comboBox1.Text = "Aucune";
            }
            if (comboBox2.SelectedItem == null)
            {
                comboBox2.Text = "Aucune";
            }
            if (comboBox3.SelectedItem == null)
            {
                comboBox3.Text = "Aucune";
            }

            if (comboBox1.SelectedItem == null && comboBox2.SelectedItem == null && comboBox3.SelectedItem == null && !checkBox1.Checked && !checkBox2.Checked && !checkBox3.Checked && !checkBox4.Checked)
            {
                listBox1.Items.Add("Vente vide");
            }
            else
            {
                double prixSoupe=0, prixEntree = 0, prixPlat = 0, prixDessert = 0, prixDessert2 = 0,prixDessert3 = 0, prixDessert4 = 0;
                if (comboBox1.Text == "Soupe aux légumes")
                {
                    prixSoupe = 4.75;

                }
                else if (comboBox1.Text == "Soupe aux pois")
                {
                    prixSoupe = 4.75;
                }
                else if (comboBox1.Text == "Soupe aux gourganes")
                {
                    prixSoupe = 4.75;
                }
                else if (comboBox1.Text == "Soupe aux boulettes de boeufs")
                {
                    prixSoupe = 6.75;
                }
                else if (comboBox1.Text == "Potage aux champignons")
                {
                    prixSoupe = 4.75;
                }
                else
                {
                    prixSoupe = 0;
                }

                if (comboBox2.Text == "Chaudrée de seiches")
                {
                    prixEntree = 8.75;
                }
                else if (comboBox2.Text == "Pétoncle aux basilic")
                {
                    prixEntree = 10.75;
                }
                else if (comboBox2.Text == "Tartare aux tomates")
                {
                    prixEntree = 9.75;
                }
                else if (comboBox2.Text == "Chaudrée du pêcheur")
                {
                    prixEntree = 9.75;
                }
                else if (comboBox2.Text == "Mozzarella aux bacon")
                {
                    prixEntree = 8.75;
                }
                else
                {
                    prixEntree = 0;
                }

                if (comboBox3.Text == "Spaghettis à la crème de poivrons")
                {
                    prixPlat = 14.75;
                }
                else if (comboBox3.Text == "Riz cantonais aux crevettes")
                {
                    prixPlat = 22.75;
                }
                else if (comboBox3.Text == "Cari de boeuf massalé")
                {
                    prixPlat = 19.75;
                }
                else if (comboBox3.Text == "Tajine de poulet marocain aux légumes")
                {
                    prixPlat = 18.75;
                }
                else if (comboBox3.Text == "Cari de dorade au combava")
                {
                    prixPlat = 19.75;
                }
                else
                {
                    prixPlat = 0;
                }

                string nomDessert, nomDessert2, nomDessert3,nomDessert4 ;

                if (checkBox1.Checked)
                {
                    prixDessert = 5.75;
                    nomDessert = checkBox1.Text;
                }
                else
                {
                    prixDessert = 0;
                    nomDessert = "";
                }

                if (checkBox2.Checked)
                {
                    prixDessert2 = 4.75;
                    nomDessert2 = checkBox2.Text;
                }
                else
                {
                    prixDessert2= 0;
                    nomDessert2 ="";
                }

                if (checkBox3.Checked)
                {
                    prixDessert3 = 6.75;
                    nomDessert3 = checkBox3.Text;
                }
                else
                {
                    prixDessert3 = 0;
                    nomDessert3 = "";
                }

                if (checkBox4.Checked)
                {
                    prixDessert4 = 4.75;
                    nomDessert4 = checkBox4.Text;
                }
                else
                {
                    prixDessert4 = 0;
                    nomDessert4 ="";
                }
                double prixTotal=sommeTotal(prixPlat, prixDessert,prixDessert2,prixDessert3,prixDessert4,prixEntree,prixSoupe);

                double prixRed;
                if (radioButton4.Checked) 
                {
                    if (radioButton2.Checked)
                    {
                        prixRed = prixTotal * (0.1+0.02);
                    }
                    else if (radioButton3.Checked)
                    {
                        prixRed = prixTotal * (0.12+0.02);
                    }
                    else
                    {
                        prixRed = prixTotal*0.02;
                    }
                }
                else
                {
                    if (radioButton2.Checked)
                    {
                        prixRed = prixTotal * (0.1 + 0.02);
                    }
                    else if (radioButton3.Checked)
                    {
                        prixRed = prixTotal * (0.12 + 0.02);
                    }
                    else
                    {
                        prixRed = 0;
                    }
                }
                
                double prixFact=prixTotal-prixRed;
                double montantTaxe=prixFact*(0.05+0.09975);

                listBox2.Show();
                listBox2.Items.Clear();
                listBox2.Items.Add("Total de la facture : "+prixFact);
                listBox2.Items.Add("Montant des taxes : "+montantTaxe);
                if(comboBox1.SelectedItem== null && comboBox2.SelectedItem==null && comboBox3.SelectedItem==null)
                {
                    listBox1.Items.Add(nomDessert + " " + nomDessert2 + " " + nomDessert3 + " " + nomDessert4 + " Total " + prixFact);
                }
                else
                {
                    listBox1.Items.Add(comboBox1.SelectedItem + " " + comboBox2.SelectedItem + " " + comboBox3.SelectedItem);
                    listBox1.Items.Add(nomDessert + " " + nomDessert2 + " " + nomDessert3 + " " + nomDessert4 + " Total " + prixFact);
                }
               
                
            }

            double sommeTotal(double a, double b, double c, double d,double e, double f,double g)
            {
                double p=a+b+c+d+e+f+g;
                return p;
            }





        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

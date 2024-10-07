using System.Diagnostics;
using System.IO;
using static WinFormsApp4.Form1;

namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        Voiture[] tab = new Voiture[100];
        int nextId = 1;
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox2.Text == "")
            {
                MessageBox.Show("Veuillez entrer la marque et l'immatriculation");
            }
            else
            {
                if (int.TryParse(textBox3.Text, out int an) && double.TryParse(textBox4.Text, out double kilo) && double.TryParse(textBox5.Text, out double p))
                {
                    Voiture v1 = new Voiture(textBox1.Text, textBox2.Text, an, kilo, p);
                    tab[Voiture.nbvoiture - 1] = v1;
                    textBox6.Text = Voiture.nbvoiture.ToString();
                    dataGridView1.ColumnCount = 6;
                    dataGridView1.Columns[0].Name = "ID";
                    dataGridView1.Columns[1].Name = "Marque";
                    dataGridView1.Columns[2].Name = "Immatriculation";
                    dataGridView1.Columns[3].Name = "Année";
                    dataGridView1.Columns[4].Name = "Kilomètrage";
                    dataGridView1.Columns[5].Name = "Prix";

                    dataGridView1.Rows.Add(nextId, textBox1.Text, textBox2.Text, an, kilo, p);
                    nextId++;
                }
                else
                {
                    MessageBox.Show("Veuillez entrer des entiers");
                }
            }

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked! && !radioButton4.Checked && !radioButton5.Checked)
            {
                MessageBox.Show("Veuiller faire un choix pour la recherche");
            }
            else
            {
                if (radioButton1.Checked)
                {
                    listBox1.Items.Clear();
                    foreach (Voiture v in tab)
                    {
                        if (v.getMarque() == textBox7.Text)
                        {
                            listBox1.Items.Add(v.getMarque());
                            listBox1.Items.Add(v.getImmatriculation());
                            listBox1.Items.Add(v.getAnnee());
                            listBox1.Items.Add(v.getKilometrage());
                            listBox1.Items.Add(v.getPrix());
                        }
                    }
                }
                else if (radioButton2.Checked)
                {
                    listBox1.Items.Clear();
                    foreach (Voiture v in tab)
                    {
                        if (v.getImmatriculation() == textBox7.Text)
                        {
                            listBox1.Items.Add(v.getMarque());
                            listBox1.Items.Add(v.getImmatriculation());
                            listBox1.Items.Add(v.getAnnee());
                            listBox1.Items.Add(v.getKilometrage());
                            listBox1.Items.Add(v.getPrix());
                        }
                    }
                }
                else if (radioButton3.Checked)
                {
                    int a = Convert.ToInt32(textBox7.Text);

                    listBox1.Items.Clear();
                    foreach (Voiture v in tab)
                    {
                        if (v.getAnnee() == a)
                        {
                            listBox1.Items.Add(v.getMarque());
                            listBox1.Items.Add(v.getImmatriculation());
                            listBox1.Items.Add(v.getAnnee());
                            listBox1.Items.Add(v.getKilometrage());
                            listBox1.Items.Add(v.getPrix());
                        }

                    }

                }
                else if (radioButton4.Checked)
                {
                    double k = Convert.ToDouble(textBox7.Text);

                    listBox1.Items.Clear();
                    foreach (Voiture v in tab)
                    {
                        if (v.getKilometrage() == k)
                        {
                            listBox1.Items.Add(v.getMarque());
                            listBox1.Items.Add(v.getImmatriculation());
                            listBox1.Items.Add(v.getAnnee());
                            listBox1.Items.Add(v.getKilometrage());
                            listBox1.Items.Add(v.getPrix());
                        }

                    }

                }
                else
                {
                    double price = Convert.ToDouble(textBox7.Text);

                    listBox1.Items.Clear();
                    foreach (Voiture v in tab)
                    {
                        if (v.getPrix() == price)
                        {
                            listBox1.Items.Add(v.getMarque());
                            listBox1.Items.Add(v.getImmatriculation());
                            listBox1.Items.Add(v.getAnnee());
                            listBox1.Items.Add(v.getKilometrage());
                            listBox1.Items.Add(v.getPrix());
                        }

                    }

                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Savefile(tab, "./voiture.txt");
        }

        public struct Voiture
        {
            public string marque;
            public string immatriculation;
            public int annee;
            public double kilometrage;
            public double prix;
            public static int nbvoiture = 0;

            public Voiture(string marque, string immatriculation, int annee, double kilometrage, double prix)
            {
                this.marque = marque;
                this.immatriculation = immatriculation;
                this.annee = annee;
                this.kilometrage = kilometrage;
                this.prix = prix;
                nbvoiture++;

            }
            public string getMarque()
            {
                return this.marque;
            }
            public string getImmatriculation()
            {
                return this.immatriculation;
            }
            public double getAnnee()
            {
                return this.annee;
            }
            public double getKilometrage()
            {
                return this.kilometrage;
            }
            public double getPrix()
            {
                return this.prix;
            }

            public void setMarque(string marque)
            {
                this.marque = marque;
            }
            public void setImmatriculation(string immatriculation)
            {
                this.immatriculation = immatriculation;
            }
            public void setAnnee(int annee)
            {
                this.annee = annee;
            }
            public void setKilometrage(double kilometrage)
            {
                this.kilometrage = kilometrage;
            }

            public void setPrix(double prix)
            {
                this.prix = prix;
            }

        }

        public void Savefile(Voiture[] T, string path)
        {
            int index = 1;
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine($"id\tMarque\tImmatriculation" + $"\tAnnee\tKm\tPrix");
                foreach (Voiture x in T)
                {
                    if (x.getMarque() != null)
                    {
                        sw.WriteLine(index + "\t" + x.getMarque() + "\t" + x.getImmatriculation() + "\t" + x.getAnnee() + "\t" + x.getKilometrage() + "\t" + x.getPrix());
                        index++;
                    }
                }
                sw.Close();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            List<Voiture> list = new List<Voiture>();
            using (StreamReader rd = new StreamReader("./voiture.txt"))
            {
                string[] mots;
                string line = rd.ReadLine();
                while (line != null)
                {
                    mots = line.Split("\t");
                    dataGridView1.Rows.Add(mots[1], mots[2], mots[3], mots[4], mots[5]);

                    Voiture v=new Voiture(mots[1], mots[2], Convert.ToInt32(mots[3]), Convert.ToDouble(mots[4]), Convert.ToDouble(mots[5]));
                    
                    
                }
                rd.Close();
            }


        }

        private void button7_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog op=new OpenFileDialog())
            {
                if(op.ShowDialog()==DialogResult.OK)
                {

                }
            }
        }
    }
}

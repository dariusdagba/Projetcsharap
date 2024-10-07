namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (button1.Text == "Afficher")
            {
                label1.Text = "Bienvenue dans mon application";
                button1.Text = "Effacer";

            }
            else
            {
                label1.Text = " ";
                button1.Text = "Afficher";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
    }
}

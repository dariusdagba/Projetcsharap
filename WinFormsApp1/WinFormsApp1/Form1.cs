namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*label1.Text = "Bonjour";
            if (button1.Text=="button1")
            {
               
                button1.Text = "Cancel";
            }
            else 
            {
                label1.Text = "X= ";
                button1.Text = "button1";
            }*/
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double c = a + b;
            textBox3.Text=c.ToString();
        }
    }
}

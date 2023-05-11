namespace Gustav___Projekt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Datorn = new Random().Next(1,10);
            int Mtal = int.Parse(textBox2.Text);
            if (Mtal == Datorn)
            {
                string s = Datorn.ToString();
                textBox3.Text = "Rätt: " + s;
            }
            else
            {
                textBox3.Text = "Fel, Gissa igen";
            }

        }
    }
}
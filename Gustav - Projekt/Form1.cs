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
            int Datorn = new Random().Next(1,3);
            int Mtal = int.Parse(textBox2.Text);
            if (Mtal == Datorn)
            {
                string s = Datorn.ToString();
                textBox3.Text = "Rätt, talet var " + s;
                BackColor = Color.LimeGreen;
            }
            else
            {

                textBox3.Text = "Fel, Gissa igen";
                BackColor = Color.Red;
                
                
            }
            textBox1.Text = "" + Datorn;
            

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
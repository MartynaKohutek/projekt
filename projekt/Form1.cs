namespace projekt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Cena_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Komputer komputer = new Komputer(this);
            komputer.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 monitor = new Form3(this);
            monitor.Show();
        }
    }
}

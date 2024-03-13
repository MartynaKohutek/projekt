namespace projekt
{
    public partial class Form1 : Form
    {
        public double cena_komputera = 0;
        public double cena_monitora = 0;
        public Form1()
        {
            InitializeComponent();
            textBox1.ReadOnly = true;
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

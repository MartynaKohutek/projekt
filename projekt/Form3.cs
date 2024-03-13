using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projekt
{
    public partial class Form3 : Form
    {
        Form1 parent;
        double cena_monitora;
        public Form3()
        {
            InitializeComponent();
        }

        public Form3(Form1 god)
        {
            InitializeComponent();
            parent = god;
            textBox1.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            parent.textBox1.Text = (cena_monitora + parent.cena_komputera).ToString();
            parent.cena_monitora = cena_monitora;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                foreach (ListViewItem selectedItem in listView1.SelectedItems)
                {
                    if (selectedItem.Text == "24") cena_monitora = 300;
                    if (selectedItem.Text == "27") cena_monitora = 600;
                    if (selectedItem.Text == "32") cena_monitora = 900;
                }
                textBox1.Text = cena_monitora.ToString();
            }
        }

    }
}

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
    public partial class Komputer : Form
    {
        Form1 parent;
        double cena_procesora = 0;
        double cena_dysku = 0;
        public Komputer()
        {
            InitializeComponent();

        }

        public Komputer(Form1 god)
        {
            InitializeComponent();
            parent = god;
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            parent.textBox1.Text = (cena_procesora + cena_dysku + parent.cena_monitora).ToString();
            parent.cena_komputera = cena_procesora + cena_dysku;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                if (comboBox1.SelectedItem.ToString() == "procesor 1") cena_procesora = 1000;
                if (comboBox1.SelectedItem.ToString() == "procesor 2") cena_procesora = 2000;
                if (comboBox1.SelectedItem.ToString() == "procesor 3") cena_procesora = 3000;
                textBox1.Text = cena_procesora.ToString();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                cena_dysku = 1000;
                textBox2.Text = cena_dysku.ToString();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                cena_dysku = 2000;
                textBox2.Text = cena_dysku.ToString();
            }

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                cena_dysku = 3000;
                textBox2.Text = cena_dysku.ToString();
            }

        }



    }

}

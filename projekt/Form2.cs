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
        public Komputer()
        {
            InitializeComponent();

        }

        public Komputer(Form1 god)
        {
            InitializeComponent();
            parent = god;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

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
        public Form3()
        {
            InitializeComponent();
        }

        public Form3(Form1 god)
        {
            InitializeComponent();
            parent = god;
        }
    }
}

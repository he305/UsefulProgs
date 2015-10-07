using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuitarTabGUI
{
    public partial class Tabs : Form
    {
        string tabs;
        public Tabs(string tabs)
        {
            InitializeComponent();
            this.tabs = tabs;
        }

        private void Tabs_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox1.Text = tabs;
            textBox1.Enabled = true;
        }
    }
}

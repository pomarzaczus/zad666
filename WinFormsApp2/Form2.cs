using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Form1 var;
        public Form2(Form1 test)
        {
            var = test;
            InitializeComponent();
        }
        
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            var.czas = Int32.Parse(czas.Text);
        }

        private void szopy_TextChanged(object sender, EventArgs e)
        {
            var.szopy = Int32.Parse(szopy.Text);
        }

        private void kroxy_TextChanged(object sender, EventArgs e)
        {
            var.kroxy = Int32.Parse(kroxy.Text);
        }

        private void dydunie_TextChanged(object sender, EventArgs e)
        {
            var.dyd = Int32.Parse(dydunie.Text);
        }

        private void x_TextChanged(object sender, EventArgs e)
        {
            var.x = Int32.Parse(x.Text);
        }

        private void y_TextChanged(object sender, EventArgs e)
        {
            var.y = Int32.Parse(y.Text);
        }
    }
}

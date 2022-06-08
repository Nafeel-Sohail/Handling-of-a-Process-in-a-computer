using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OS_PROJECT
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        Form4 result = new Form4();
        public int op;
        private void button1_Click(object sender, EventArgs e)
        {
            op = 1;
            result.optp = op;
            MessageBox.Show("ALL INPUTS HAVE BEEN SUBMITTED");
            this.Hide();
            result.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            op = 2;
            result.optp = op;
            MessageBox.Show("ALL INPUTS HAVE BEEN SUBMITTED");
            this.Hide();
            result.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            op = 3;
            result.optp = op;
            MessageBox.Show("ALL INPUTS HAVE BEEN SUBMITTED");
            this.Hide();
            result.Show();
        }
    }
}

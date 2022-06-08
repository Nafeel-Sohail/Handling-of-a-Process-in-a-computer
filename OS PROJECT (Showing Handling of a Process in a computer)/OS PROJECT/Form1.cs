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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "OS PROJECT";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int process_number = Convert.ToInt32(textBox1.Text);
            MessageBox.Show("INFORMATION HAS BEEN SUBMITTED!!");
            this.Hide();
            Form5 input_form = new Form5();
            input_form.Show();
            //if(process_number>5)
            //{
            //    input_form.p_number = 5;
            //    input_form.total_process = process_number - 5;
            //}
            input_form.p_number = process_number;
        } 
    }
}

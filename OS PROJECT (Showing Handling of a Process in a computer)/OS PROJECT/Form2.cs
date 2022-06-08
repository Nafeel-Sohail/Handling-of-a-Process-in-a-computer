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
   
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public int p_number = 0;
        public const int size = 100;
        public int i = 0;
        public struct INFO
        {
            public string name;
            public int arrival_time;
            public int burst_time;
            public int process_size;
        }
        public INFO[] storage = new INFO[size];
        private void button1_Click(object sender, EventArgs e)
        {
            if ((p_number-1) > i)
            {
                storage[i].name = "P" + (i+1) ;
                storage[i].arrival_time = Convert.ToInt32(textBox1.Text);
                storage[i].burst_time= Convert.ToInt32(textBox2.Text);
                storage[i].process_size = Convert.ToInt32(textBox3.Text);
                i++;
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                label2.Text = "ENTER THE ARRIVAL TIME OF PROCESS " + (i + 1) + " : ";
                label3.Text = "ENTER THE BURST TIME OF PROCESS " + (i + 1) + " : ";
                label4.Text = "ENTER THE SIZE OF PROCESS " + (i + 1) + " : ";
                textBox4.Text = i.ToString();
            }
            else
            {
                storage[i].name = "P" + (i + 1);
                storage[i].arrival_time = Convert.ToInt32(textBox1.Text);
                storage[i].burst_time = Convert.ToInt32(textBox2.Text);
                storage[i].process_size = Convert.ToInt32(textBox3.Text);
                i++;
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                MessageBox.Show("ALL INPUTS HAVE BEEN SUBMITTED");
                this.Hide();
                Form3 option = new Form3();
                option.Show();
            }
        }
    }
}

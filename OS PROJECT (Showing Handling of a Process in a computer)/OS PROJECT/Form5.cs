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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            button2.Hide();
            button3.Hide();
            button4.Hide();
            button5.Hide();
            button6.Hide();
            label5.Hide();
            textBox6.Hide();
            button7.Hide();
            button8.Hide();
            dataGridView1.Hide();
            label6.Hide();
            label7.Hide();
            label8.Hide();
            textBox5.Hide();
            textBox7.Hide();
            label10.Hide();
            label11.Hide();
            textBox8.Hide();
            button9.Hide();
            button10.Hide();
            button11.Hide();
            button12.Hide();
            dataGridView2.Hide();
            dataGridView3.Hide();
            this.Text = "OS PROJECT";
        }
        public int total_process;
        public int p_number = 0;
        public const int size = 5;
        public int z = 0;
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
            if ((p_number - 1) > z)
            {
                storage[z].name = "P" + (z + 1);
                storage[z].arrival_time = Convert.ToInt32(textBox1.Text);
                storage[z].burst_time = Convert.ToInt32(textBox2.Text);
                storage[z].process_size = Convert.ToInt32(textBox3.Text);
                z++;
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                label2.Text = "ENTER THE ARRIVAL TIME OF PROCESS " + (z + 1) + " : ";
                label3.Text = "ENTER THE BURST TIME OF PROCESS " + (z + 1) + " : ";
                label4.Text = "ENTER THE SIZE OF PROCESS " + (z + 1) + " : ";
                textBox4.Text = z.ToString();
            }
            else
            {
                storage[z].name = "P" + (z + 1);
                storage[z].arrival_time = Convert.ToInt32(textBox1.Text);
                storage[z].burst_time = Convert.ToInt32(textBox2.Text);
                storage[z].process_size = Convert.ToInt32(textBox3.Text);
                z = 0;
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                MessageBox.Show("ALL INPUTS HAVE BEEN SUBMITTED");
                label2.Hide();
                label3.Hide();
                label4.Hide();
                label9.Hide();
                textBox1.Hide();
                textBox2.Hide();
                textBox3.Hide();
                textBox4.Hide();
                button1.Hide();
                label6.Show();
                button2.Show();
                button3.Show();
                button4.Show();
                button6.Show();
            }
        }

        public int op;
        private void button4_Click(object sender, EventArgs e)
        {
            op = 1;
            MessageBox.Show("CPU HAS BEEN SCHEDULED ACCORDING TO THE SELECTED OPTION");
            button2.Hide();
            button3.Hide();
            button4.Hide();
            button6.Hide();
            button5.Show();
            label6.Hide();
            label9.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            op = 2;
            MessageBox.Show("CPU HAS BEEN SCHEDULED ACCORDING TO THE SELECTED OPTION");
            button2.Hide();
            button3.Hide();
            button4.Hide();
            button6.Hide();
            button5.Show();
            label6.Hide();
            label9.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            op = 3;
            MessageBox.Show("CPU HAS BEEN SCHEDULED ACCORDING TO THE SELECTED OPTION");
            button2.Hide();
            button3.Hide();
            button4.Hide();
            button6.Hide();
            button5.Show();
            label6.Hide();
            label9.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            op = 4;
            MessageBox.Show("CPU HAS BEEN SCHEDULED ACCORDING TO THE SELECTED OPTION");
            button2.Hide();
            button3.Hide();
            button4.Hide();
            button6.Hide();
            label5.Show();
            textBox6.Show();
            button7.Show();
            label6.Hide();
            label9.Hide();
        }
        public int[] piority = new int[size];
        public int l = 0;
        private void button7_Click(object sender, EventArgs e)
        {
            if ((p_number - 1) > l)
            {
                piority[l] = Convert.ToInt32(textBox6.Text);
                l++;
                textBox6.Clear();
                label5.Text = "ENTER THE PIORITY OF PROCESS " + (l + 1) + " : ";
            }
            else
            {
                piority[l] = Convert.ToInt32(textBox6.Text);
                MessageBox.Show("ALL INPUTS HAVE BEEN SUBMITTED");
                label5.Hide();
                textBox6.Hide();
                button7.Hide();
                label6.Hide();
                button5.Show();
                label9.Hide();
            }
        }

        public int sz = 10000;
        public INFO[] store = new INFO[size];
        public int[] completion_time = new int[size];
        public int[] turn_around_time = new int[size];
        public int[] waiting_time = new int[size];
        public double average_turnaround_time = 0, average_waiting_time = 0;
        DataTable table = new DataTable("table");
        public int[] piority_2 = new int[size];

        private void button5_Click(object sender, EventArgs e)
        {
            if (op == 1)
            {
                for (int i = 0; i < p_number; i++)
                {
                    int min = storage[0].arrival_time;
                    int index = 0;
                    for (int j = 0; j < p_number; j++)
                    {
                        if (min > storage[j].arrival_time)
                        {
                            min = storage[j].arrival_time;
                            index = j;
                        }
                    }
                    store[i].name = storage[index].name;
                    store[i].arrival_time = storage[index].arrival_time;
                    store[i].burst_time = storage[index].burst_time;
                    store[i].process_size = storage[index].process_size;
                    storage[index].arrival_time = sz;
                }
            }
            if (op == 2)
            {
                for (int i = 0; i < p_number; i++)
                {
                    int min = storage[0].burst_time;
                    int index = 0;
                    for (int j = 0; j < p_number; j++)
                    {
                        if (min > storage[j].burst_time)
                        {
                            min = storage[j].burst_time;
                            index = j;
                        }
                    }
                    store[i].name = storage[index].name;
                    store[i].arrival_time = storage[index].arrival_time;
                    store[i].burst_time = storage[index].burst_time;
                    store[i].process_size = storage[index].process_size;
                    storage[index].burst_time = sz;
                }
            }
            if (op == 3)
            {
                int time = storage[0].arrival_time;
                int turn_limit = 5;
                int rem_time = 0;
                int max = storage[0].burst_time;
                int index = 0;
                for (int j = 0; j < p_number; j++)
                {
                    if (max < storage[j].burst_time)
                    {
                        max = storage[j].burst_time;
                        index = j;
                    }
                }

                for (int i = 0; i < p_number; i++)
                {
                    store[i].name = storage[i].name;
                    store[i].arrival_time = storage[i].arrival_time;
                    store[i].burst_time = storage[i].burst_time;
                    store[i].process_size = storage[i].process_size;
                }
                for (int t = 0; t < 100; t++)
                {
                    for (int i = 0; i < p_number; i++)
                    {
                        if (storage[i].arrival_time > time)
                        {
                            time = storage[i].arrival_time;
                        }
                        if (storage[i].burst_time == 0)
                        {
                        
                        }
                        else if (storage[i].burst_time >= turn_limit)
                        {
                            storage[i].burst_time -= turn_limit;
                            time += turn_limit;
                            if (storage[i].burst_time == 0)
                            {
                                completion_time[i] = time;
                            }
                        }
                        else if (storage[i].burst_time < turn_limit)
                        {
                            rem_time = storage[i].burst_time;
                            storage[i].burst_time -= rem_time;
                            time += rem_time;
                            completion_time[i] = time;
                        }
                    }
                    if (storage[index].burst_time == 0)
                   {
                        break;
                   }
                }
            }
            if (op == 4)
            {
                for (int i = 0; i < p_number; i++)
                {
                    int min = piority[0];
                    int index = 0;
                    for (int j = 0; j < p_number; j++)
                    {
                        if (min > piority[j])
                        {
                            min = piority[j];
                            index = j;
                        }
                    }
                    store[i].name = storage[index].name;
                    store[i].arrival_time = storage[index].arrival_time;
                    store[i].burst_time = storage[index].burst_time;
                    store[i].process_size = storage[index].process_size;
                    piority_2[i] = min;
                    piority[index] = sz;
                }
            }
            if (op == 1 || op == 2 || op == 4)
            {
                for (int i = 0; i < p_number; i++)
                {
                    if (i == 0)
                    {
                        completion_time[i] = store[i].arrival_time + store[i].burst_time;
                    }
                    else if (store[i].arrival_time <= completion_time[i - 1])
                    {
                        completion_time[i] = completion_time[i - 1] + store[i].burst_time;
                    }
                    else if (store[i].arrival_time > completion_time[i - 1])
                    {
                        completion_time[i] = store[i].arrival_time + store[i].burst_time;
                    }
                }
            }
            for (int i = 0; i < p_number; i++)
            {
                turn_around_time[i] = completion_time[i] - store[i].arrival_time;
                waiting_time[i] = turn_around_time[i] - store[i].burst_time;
                average_turnaround_time += turn_around_time[i];
                average_waiting_time += waiting_time[i];
            }
            average_turnaround_time = average_turnaround_time / p_number;
            average_waiting_time = average_waiting_time / p_number;

            if (op == 1 || op == 2 || op == 3)
            {
                table.Columns.Add("PROCESS NO", Type.GetType("System.String"));
                table.Columns.Add("ARRIVAL TIME", Type.GetType("System.Int32"));
                table.Columns.Add("BURST TIME", Type.GetType("System.Int32"));
                table.Columns.Add("COMPLETION TIME", Type.GetType("System.Int32"));
                table.Columns.Add("TURNAROUND TIME", Type.GetType("System.Int32"));
                table.Columns.Add("WAITING TIME", Type.GetType("System.Int32"));
                dataGridView1.DataSource = table;
                for (int i = 0; i < p_number; i++)
                {
                    table.Rows.Add(store[i].name, store[i].arrival_time, store[i].burst_time, completion_time[i], turn_around_time[i], waiting_time[i]);
                }
            }
            else if (op == 4)
            {
                table.Columns.Add("PROCESS NO", Type.GetType("System.String"));
                table.Columns.Add("ARRIVAL TIME", Type.GetType("System.Int32"));
                table.Columns.Add("BURST TIME", Type.GetType("System.Int32"));
                table.Columns.Add("PRIORITY SEQUENCE", Type.GetType("System.Int32"));
                table.Columns.Add("COMPLETION TIME", Type.GetType("System.Int32"));
                table.Columns.Add("TURNAROUND TIME", Type.GetType("System.Int32"));
                table.Columns.Add("WAITING TIME", Type.GetType("System.Int32"));
                dataGridView1.DataSource = table;
                for (int i = 0; i < p_number; i++)
                {
                    table.Rows.Add(store[i].name, store[i].arrival_time, store[i].burst_time,piority_2[i] ,completion_time[i], turn_around_time[i], waiting_time[i]);
                }
            }
            textBox5.Text = average_turnaround_time.ToString();
            textBox7.Text = average_waiting_time.ToString();
            dataGridView1.Show();
            button8.Show();
            label9.Hide();
            label7.Show();
            label8.Show();
            textBox5.Show();
            textBox7.Show();
            //if (total_process == 0)
            //{

            //}
            //else if (total_process > 5)
            //{
            //    total_process -= 5;
            //    goto again;
            //}
            //else if (total_process < 5)
            //{
            //    p_number = total_process;
            //    goto again;
            //}
        }
        public const int process_storing_array_size = 10;
        public int[] array_to_store_process = new int[process_storing_array_size];
        public int[] array_to_store_process_original = new int[process_storing_array_size];
        public int q = 0;
        public int u = 1;
        public int[] process_allocation = new int[process_storing_array_size];
        private void button8_Click(object sender, EventArgs e)
        {
            array_to_store_process[0] = 49;
            array_to_store_process[1] = 52;
            array_to_store_process[2] = 10;
            array_to_store_process[3] = 7;
            array_to_store_process[4] = 5;
            array_to_store_process[5] = 68;
            array_to_store_process[6] = 91;
            array_to_store_process[7] = 23;
            array_to_store_process[8] = 71;
            array_to_store_process[9] = 100;
            for (int i = 0; i < process_storing_array_size; i++)
            {
                array_to_store_process_original[i] = array_to_store_process[i];
            }
            dataGridView1.Hide();
            button8.Hide();
            button5.Hide();
            label7.Hide();
            label8.Hide();
            label9.Hide();
            textBox5.Hide();
            textBox7.Hide();
            label10.Show();
            label11.Show();
            textBox8.Show();
            button9.Show();
            button10.Show();
            button11.Show();
            textBox8.Text = u.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int best_fit_index = -1;
            for (int i = 0; i < process_storing_array_size; i++)
            {
                if (array_to_store_process[i] == store[q].process_size)
                {
                    best_fit_index = i;
                    break;
                }
                else if (array_to_store_process[i] > store[q].process_size)
                {
                    if (best_fit_index == -1) 
                    {
                        best_fit_index = i;
                    }
                    else if (array_to_store_process[best_fit_index] > array_to_store_process[i])
                    {
                        best_fit_index = i;
                    }
                }
                else if (array_to_store_process[i] < store[q].process_size)
                {

                }
            }
            array_to_store_process[best_fit_index] -= store[q].process_size;
            process_allocation[q] = best_fit_index;
            if (u < p_number)
            {
                u++;
                q++;
                textBox8.Text = u.ToString();
            }
            else
            {
                button12.Show();
            }
        }
        private void button10_Click(object sender, EventArgs e)
        {
            int worst_fit_index = -1;
            for (int i = 0; i < process_storing_array_size; i++)
            {
                if (array_to_store_process[i] >= store[q].process_size)
                {
                    if (worst_fit_index == -1)
                    {
                        worst_fit_index = i;
                    }
                    else if (array_to_store_process[worst_fit_index] < array_to_store_process[i])
                    {
                        worst_fit_index = i;
                    }
                }
                else if (array_to_store_process[i] < store[q].process_size)
                {

                }
            }
            array_to_store_process[worst_fit_index] -= store[q].process_size;
            process_allocation[q] = worst_fit_index;
            if (u < p_number)
            {
                q++;
                u++;
                textBox8.Text = u.ToString();
            }
            else
            {
                button12.Show();
            }
           
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int first_fit_index = -1;
            for (int i = 0; i < process_storing_array_size; i++)
            {
                if (array_to_store_process[i] >= store[q].process_size)
                {
                    first_fit_index = i;
                    break;
                }
                else if (array_to_store_process[i] < store[q].process_size)
                {

                }
            }
            array_to_store_process[first_fit_index] -= store[q].process_size;
            process_allocation[q] = first_fit_index;
            if (u < p_number)
            {
                q++;
                u++;
                textBox8.Text = u.ToString();
            }
            else
            {
                button12.Show();
            }
        }
        DataTable memory_allocation_1 = new DataTable("memory_allocation_1");
        DataTable memory_allocation_2 = new DataTable("memory_allocation_2");
        private void button12_Click(object sender, EventArgs e)
        {
            label10.Hide();
            label11.Hide();
            textBox8.Hide();
            button9.Hide();
            button10.Hide();
            button11.Hide();
            button12.Hide();
            memory_allocation_1.Columns.Add("PROCESS NO", Type.GetType("System.String"));
            memory_allocation_1.Columns.Add("ALLOCATION INDEX", Type.GetType("System.Int32"));
            memory_allocation_1.Columns.Add("PROCESS SIZE", Type.GetType("System.Int32"));
            memory_allocation_2.Columns.Add("ORIGINAL MEMORY SIZE", Type.GetType("System.Int32"));
            memory_allocation_2.Columns.Add("AFTER ALLOCATION MEMORY SIZE", Type.GetType("System.Int32"));
            dataGridView2.DataSource = memory_allocation_1;
            for (int i = 0; i < p_number; i++)
            {
                memory_allocation_1.Rows.Add(store[i].name,process_allocation[i],store[i].process_size);
            }
            dataGridView3.DataSource = memory_allocation_2;
            for (int i = 0; i < process_storing_array_size; i++)
            {
                memory_allocation_2.Rows.Add(array_to_store_process_original[i], array_to_store_process[i]);
            }
            dataGridView2.Show();
            dataGridView3.Show();
        }
    }
}

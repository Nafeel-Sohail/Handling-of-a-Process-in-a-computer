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
	public partial class Form4 : Form
	{
		public Form4()
		{
			InitializeComponent();
		}
		public struct COPY_INFO
		{
			public string name;
			public int arrival_time;
			public int burst_time;
			public int process_size;
		}
		Form2 input = new Form2();
		public int optp;
		public const int size = 100;
		public int sz=10000;
		public COPY_INFO[] store = new COPY_INFO[size];
		public int[] completion_time = new int[size];
		public int[] turn_aroud_time = new int[size];
		public int[] waiting_time = new int[size];
		public double average_turnaround_time = 0, avgerage_waiting_time = 0;
		private void button1_Click(object sender, EventArgs e)
        {
            if (optp == 1)
			{
                for (int i = 0; i < input.p_number; i++)
                {
					int min = input.storage[0].arrival_time;
					int index = 0;
					for (int j = 0; j < input.p_number; j++)
                    {
                        if (min < input.storage[j].arrival_time)
                        {
                            min = input.storage[j].arrival_time;
                            index = j;
                        }
                    }
                    store[i].name = input.storage[index].name;
                    store[i].arrival_time = input.storage[index].arrival_time;
                    store[i].burst_time = input.storage[index].burst_time;
                    store[i].process_size = input.storage[index].process_size;
					input.storage[index].arrival_time = sz;
				}
				
                for (int i = 0; i < input.p_number; i++)
                {
					completion_time[i] = input.storage[i].arrival_time + input.storage[i].burst_time;
                }
				textBox1.Text=((+store[1].arrival_time).ToString());
				//int flag = 0, time = 0;
				//for (i = 0; i < job_number; i++)
				//{
				//	if (flag < arrival_time[i])
				//	{
				//		time = arrival_time[i] - flag;
				//	}

				//	flag = flag + burst_time[i] + time;
				//	time = 0;
				//	completion_time[i] = flag;
				//	turnaround_time[i] = completion_time[i] - arrival_time[i];
				//	avg_turnaround_time = avg_turnaround_time + turnaround_time[i];
				//	waiting_time[i] = turnaround_time[i] - burst_time[i];
				//	avg_waiting_time = avg_waiting_time + waiting_time[i];
				//}
				//printf("\n-------------------------------------------\n");
				//printf("After Calculations The following Results have been found\n");
				//printf("  AT BT CT TAT WT\n");

				//for (i = 0; i < job_number; i++)
				//{
				//	printf("J%d-%d %d %d %d %d\n", i + 1, arrival_time[i], burst_time[i], completion_time[i],
				//	turnaround_time[i], waiting_time[i]);
				//}

				//printf("Average Turnaround Time=%f ", avg_turnaround_time / job_number);
				//printf("\nAverage Waiting Time=%f", avg_waiting_time / job_number);
				//printf("\n");
			}
            if (optp == 2)
            {

            }
            if (optp == 3)
            {

            }
        }
    }
}

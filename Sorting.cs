using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sorting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i, j, temp;
            int comps = 0, swap = 0;
            List<string> array = new List<string>();
            List<int> arrayInt = new List<int>();

            array.AddRange(textBox1.Text.Split(' ').Select(txt => txt.Trim()).ToArray());
            arrayInt = array.Select(s => int.Parse(s)).ToList();

            for (i = 1; i < array.Count(); i++)
            {
                comps++;

                for (j = i; j > 0 && arrayInt[j - 1] > arrayInt[j]; j--)
                {
                    temp = arrayInt[j];
                    arrayInt[j] = arrayInt[j - 1];
                    arrayInt[j - 1] = temp;
                    swap++;
                }
            }

            for (i = 0; i < array.Count(); i++)
            {
                textBox2.Text += arrayInt[i] + " ";
            }

            //Console.WriteLine(comps);
            //Console.WriteLine(swap);
            textBox3.Text = comps + "";
            textBox4.Text = swap + "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i, j, temp;
            int comps = 0, swap = 0;
            List<string> array = new List<string>();
            List<int> arrayInt = new List<int>();

            array.AddRange(textBox1.Text.Split(' ').Select(txt => txt.Trim()).ToArray());
            arrayInt = array.Select(s => int.Parse(s)).ToList(); //Converting string array to int array

            for (i = 0; i < array.Count() - 1; i++)
            {
                comps++;
                for (j = 0; j < array.Count() - i - 1; j++)
                {
                    if (arrayInt[j + 1] < arrayInt[j])
                    {
                        temp = arrayInt[j + 1];
                        arrayInt[j + 1] = arrayInt[j];
                        arrayInt[j] = temp;
                    }
                    swap++;
                }

            }

            for (i = 0; i < array.Count(); i++)
            {
                textBox2.Text += arrayInt[i] + " ";
            }
            textBox3.Text = comps + "";
            textBox4.Text = swap + "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i, j, temp;
            int comps = 0, swap = 0;
            List<string> array = new List<string>();
            List<int> arrayInt = new List<int>();

            array.AddRange(textBox1.Text.Split(' ').Select(txt => txt.Trim()).ToArray());
            arrayInt = array.Select(s => int.Parse(s)).ToList(); //Converting string array to int array

            for (i = 0; i < array.Count() - 1; i++)
            {
                comps++;
                for (j = i + 1; j < array.Count(); j++)
                {
                    if (arrayInt[j] < arrayInt[i])
                    {
                        temp = arrayInt[i];
                        arrayInt[i] = arrayInt[j];
                        arrayInt[j] = temp;
                    }
                    swap++;
                }
            }

            for (i = 0; i < array.Count(); i++)
            {
                textBox2.Text += arrayInt[i] + " ";
            }
            textBox3.Text = comps + "";
            textBox4.Text = swap + "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox2.Text = String.Empty;
            textBox3.Text = String.Empty;
            textBox4.Text = String.Empty;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int i, j, temp;
            int comps = 0, swap = 0;
            List<string> array = new List<string>();
            List<int> arrayInt = new List<int>();

            array.AddRange(textBox1.Text.Split(' ').Select(txt => txt.Trim()).ToArray());
            arrayInt = array.Select(s => int.Parse(s)).ToList();

            int minValue = arrayInt[0];
            int maxValue = arrayInt[0];
            int k = 0;

            for (i = array.Count() - 1; i >= 1; i--)
            {
                comps++;
                if (arrayInt[i] > maxValue) maxValue = arrayInt[i];
                if (arrayInt[i] < minValue) minValue = arrayInt[i];
                swap++;
            }

            List<int>[] bucket = new List<int>[maxValue - minValue + 1];

            for (i = bucket.Count() - 1; i >= 0; i--)
            {
                bucket[i] = new List<int>();
            }

            foreach (int p in arrayInt)
            {
                bucket[p - minValue].Add(p);
            }

            foreach (List<int> b in bucket)
            {
                //comps++;
                if (b.Count() > 0)
                {
                    foreach (int t in b)
                    {
                        arrayInt[k] = t;
                        k++;
                    }
                    //swap++;   
                }
            }

            for (i = 0; i < array.Count(); i++)
            {
                textBox2.Text += arrayInt[i] + " ";
            }
            textBox3.Text = comps + "";
            textBox4.Text = swap + "";
        }
    }
}

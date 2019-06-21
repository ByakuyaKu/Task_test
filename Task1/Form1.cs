using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<int> array = new List<int>();
        
        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox3.Clear();
            SelectionSort(array);
            for (int i = 0; i < array.Count; i++) 
            {
                richTextBox3.Text += Convert.ToString(array[i]) + " ";
            }
        }

        void SelectionSort(List<int> arr) //можно использовать list.sort
        {
            int index, temp;
             for (int i = 0; i < arr.Count; ++i)
            {
                index = i;
                temp = arr[i];
                for (int j = i + 1; j < arr.Count; ++j)
                {
                    if (arr[j] < temp)
                    {
                        index = j;
                        temp = arr[j];
                    }
                }
                arr[index] = arr[i];
                arr[i] = temp;
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    array.Add(Convert.ToInt32(textBox1.Text));
                    textBox2.Text += textBox1.Text + " ";
                    textBox1.Clear();
                }
                catch(FormatException)
                {
                    MessageBox.Show("Можно вводить только целые чиса");
                    textBox1.Clear();
                }
            }
        }
    }
}

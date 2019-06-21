using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        long Factorial(int z)
        {
            long res = 1;
            for (int i = 2; i <= z; i++)
                res *= i;
            return res;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int n = Convert.ToInt32(textBox1.Text);
                richTextBox1.Text = Convert.ToString(Factorial(n));
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите число");
            }
        }
    }
}

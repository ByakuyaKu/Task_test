using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        void SecCheck(string s)
        {
            bool check = true;
            Stack<char> OpenedBrackeds = new Stack<char>();

            if (s.Length % 2 > 0) //правильная последовательность должна иметь четное кол-во скобок
                MessageBox.Show("Неправильная последовательность");
            else
            {
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] == '(' || s[i] == '[' || s[i] == '{')
                    {
                        OpenedBrackeds.Push(s[i]); //стек с открывающ скобками
                    }
                    else
                    {
                        if (OpenedBrackeds.Count == 0) //если закр скобок больше
                        {
                            MessageBox.Show("Неправильная последовательность");
                            check = false;
                        }
                        else //проверка скобок
                        {
                            if (OpenedBrackeds.Peek() == '(' && s[i] != ')') 
                            {
                                    MessageBox.Show("Неправльная последовательность");
                                    check = false;
                            }
                            if (OpenedBrackeds.Peek() == '[' && s[i] != ']')
                            {
                                    MessageBox.Show("Неправльная последовательность");
                                    check = false;
                            }
                            if (OpenedBrackeds.Peek() == '{' && s[i] != '}')
                            {
                                    MessageBox.Show("Неправльная последовательность");
                                    check = false;
                            }
                            else
                            {
                                OpenedBrackeds.Pop();
                            }
                        }
                    }
                }
                if (check)
                    MessageBox.Show("Правильная последовательность");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            bool tmp = true;
            string seq = textBox1.Text;
            for (int i = 0; i < seq.Length; i++)
            {
                if (seq[i] != '(' && seq[i] != ')' &&
                    seq[i] != '{' && seq[i] != '}' &&
                    seq[i] != '[' && seq[i] != ']')
                {
                    tmp = false;
                    MessageBox.Show("Можно вводить только скобки");
                    textBox1.Clear();
                }
            }
            if(tmp)
                SecCheck(seq);
        }
    }
}

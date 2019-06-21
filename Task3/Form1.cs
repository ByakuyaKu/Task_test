using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string EnteredWords;
        List<string> SplitWords = new List<string>();

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            EnteredWords = richTextBox2.Text;
            SplitString(EnteredWords, SplitWords);
            Equal(SplitWords);
            EnteredWords = "";
        }

        string tmp;
        void SplitString(string s, List<string> arr) // можно использовать String.Split
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ' || s[i] == '.' || 
                    s[i] == ',' || s[i] == '?' || 
                    s[i] == '!' || s[i] == ':' || 
                    s[i] == '.' || s[i] == ';')
                {
                    arr.Add(tmp);
                    tmp = "";
                    continue;
                }
                tmp += s[i];
            }
            if (s[s.Length - 1] != ' ' || s[s.Length - 1] != '.' || s[s.Length - 1] != ',' || //для добавление последнего слова в строке если в конце нет знака препинания
                s[s.Length - 1] != '?' || s[s.Length - 1] != '!' || s[s.Length - 1] != ':' ||
                s[s.Length - 1] != ';')
            {
                arr.Add(tmp);
            }
        }

        void Equal(List<string> array) // можно использовать String.Equals
        {
            for (int i = 0; i < array.Count; i++)
            {
                bool z = true;
                for (int j = 0; j < array.Count; j++)
                {
                    if (array[i] == array[j] && i != j)
                    {
                        z = false;
                    }

                }
                if (z)
                {
                    richTextBox1.Text += array[i] + ' ';
                }
            }
        }
    }
}

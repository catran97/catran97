using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Буква_т
{
    public partial class Form1 : Form
    {
        public static object Instance { get; set; }

        public Form1()
        {
            InitializeComponent();
            textBox1.Select();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 'a' && e.KeyChar <= 'z'))
            {
                e.Handled = true;
                label2.Text = "Введите руский текст";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text.ToLower();
            int n = Found_count_T(str);
            Form2 newfrm = new Form2(n);//Form2 -- вторая форма
            newfrm.ShowDialog();
        }

        public static int Found_count_T(string str)
        {
            int n = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'т')
                {
                    n++;
                }
            }

            return n;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
    }
}

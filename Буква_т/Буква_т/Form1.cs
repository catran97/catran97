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
        public Form1()
        {
            InitializeComponent();
            textBox1.Select();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] mass;
            int n = 0;
            string str;
            //Console.WriteLine("Введите текст");
            //string str = Console.ReadLine();
            str = textBox1.Text;
            mass = str.Split(' ');
            if (str.Length < 100)
            {
                for (int i = 0; i < mass.Length; i++)
                {
                    for (int j = 0; j < mass[i].Length; j++)
                    {
                        if (mass[i][j].ToString().Equals("Т") == true || mass[i][j].ToString().Equals("т") == true) n += 1;
                    }
                }
                Form2 newfrm = new Form2(n);//Form2 -- вторая форма
                newfrm.ShowDialog();
            }
            else
            {
               label2.Text = "Ошибка: Введено больше 100 символов " + str.Length;
            }
         }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //private void textBox1_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Enter) button1_Click;
        //}

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
    }
}

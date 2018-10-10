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
    public partial class Form2 : Form
    {
        public Form2(int n)
        {
            InitializeComponent();
            this.n = n;
            label1.Text = "Количество букв т " + n;
        }
        int n;

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Faktoryel_Ornek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int i = 1;
        int faktoryel = 1;
        private void Button1_Click(object sender, EventArgs e)
        {
            for (i = 1; i <=7; i++)
            {
                faktoryel = faktoryel * i;
                listBox1.Items.Add(faktoryel);
                label1.Text = faktoryel.ToString();
            }
        }
    }
}

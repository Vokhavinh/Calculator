using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCong_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textA.Text);
            double b = double.Parse(textB.Text);
            double c = a + b;
            textKetqua.Text = c.ToString();
        }
    }
}

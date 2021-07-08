using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            symbol.Text = "+";
            int a = Int32.Parse(num1.Text);
            int b = Int32.Parse(num2.Text);
            int r = a + b;
            result.Text = r.ToString();
        }

        private void sub_Click(object sender, EventArgs e)
        {
            symbol.Text = "-";
            int a = Int32.Parse(num1.Text);
            int b = Int32.Parse(num2.Text);
            int r = a - b;
            result.Text = r.ToString();
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            symbol.Text = "*";
            int a = Int32.Parse(num1.Text);
            int b = Int32.Parse(num2.Text);
            int r = a * b;
            result.Text = r.ToString();
        }

        private void divide_Click(object sender, EventArgs e)
        {
            symbol.Text = "/";
            int a = Int32.Parse(num1.Text);
            int b = Int32.Parse(num2.Text);
            int r = a / b;
            result.Text = r.ToString();
        }

        private void result_Click(object sender, EventArgs e)
        {

        }
    }
}

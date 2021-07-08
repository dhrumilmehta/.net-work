using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDIdemo
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics dc = e.Graphics;
            Pen p = new Pen(Color.Black);
            dc.DrawLine(p, 10, 10, 100, 100);
            Pen thickbluepen = new Pen(Color.Blue, 10);
            dc.DrawEllipse(thickbluepen, 100, 100, 200, 200);
            Pen thickredpen = new Pen(Color.Red, 10);
            dc.DrawRectangle(thickredpen, 100, 100, 200, 200);
        }
        }
    }

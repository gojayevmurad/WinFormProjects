using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnclickableButton
{
    public partial class Form1 : Form
    {

        Point[] points =
        {
            new Point(100,100),
            new Point(700,100),
            new Point(100,400),
            new Point(700,400),
        };
        int index = 0;
        public Form1()
        {
            InitializeComponent();
            hoverBtn.Location = points[index];
        }

        private void hoverBtn_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Button b)
            {
                b.Location = new Point(50, 50);
                if (index == points.Length)
                {
                    index = 0;
                }

                b.Location = points[index];

                index++;

            }
        }
    }
}

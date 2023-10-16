using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RGB
{
    public partial class Form1 : Form
    {
        public int Red { get; set; } = 0;
        public int Green { get; set; } = 0;
        public int Blue { get; set; } = 0;

        public Form1()
        {
            InitializeComponent();
            SetBackColor();
        }

        private void trackBarRed_Scroll(object sender, EventArgs e)
        {
            if(sender is TrackBar trackBar)
            {
                int value = trackBar.Value;
                Red = value;
                redValue.Text = value.ToString();
            }
            SetBackColor();
        }

        private void trackBarGreen_Scroll(object sender, EventArgs e)
        {
            if (sender is TrackBar trackBar)
            {
                int value = trackBar.Value;
                Green = value;
                greenValue.Text = value.ToString();
            }
            SetBackColor();
        }

        private void trackBarBlue_Scroll(object sender, EventArgs e)
        {
            if (sender is TrackBar trackBar)
            {
                int value = trackBar.Value;
                Blue = value;
                blueValue.Text = value.ToString();
            }
            SetBackColor();
        }

        private void SetBackColor()
        {
            this.BackColor = Color.FromArgb(Red, Green, Blue);
        }
    }
}

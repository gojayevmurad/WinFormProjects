using changeBack_Time.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace changeBack_Time
{

    public partial class Form1 : Form
    {
        string city = "Baku";
        public Form1()
        {
            InitializeComponent();
            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
            bakuBtn_Click(this, EventArgs.Empty);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            DateTime displayTime = DateTime.Now;
            if (city == "London")
            {
                displayTime = displayTime.AddHours(-3);
            }
            this.dateTimeLabel.Text = displayTime.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void londonBtn_Click(object sender, EventArgs e)
        {
            city = "London";
            titleCity.Text = "London";
            this.BackgroundImage = Resources.london;
        }

        private void bakuBtn_Click(object sender, EventArgs e)
        {
            city = "Baku";
            titleCity.Text = "Baku";
            this.BackgroundImage = Resources.bak;
        }
    }

}

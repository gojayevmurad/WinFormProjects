using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyStat_Clone
{
    public partial class Form1 : Form
    {
        StudentShowControl studentShowControl = new StudentShowControl();
        public Form1()
        {
            InitializeComponent();
            studentShowControl.Location = new Point(-50, 0);
            studentShowControl.Width = 500;
            contentPanel.Controls.Add(studentShowControl);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductManager
{
    public partial class Form2 : Form
    {
        public string PrName { get => nameTxtbox.Name; set => nameTxtbox.Text = value; }
        public string Model { get => modelTxtbox.Name; set => modelTxtbox.Text = value; }
        public string Price { get => priceTxtbox.Name; set => priceTxtbox.Text = value; }

        public Product product { get; set; }

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            nameTxtbox.Text = product.Name;
            modelTxtbox.Text =product.Model;
            priceTxtbox.Text =product.Price;
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            product.Name = nameTxtbox.Text;
            product.Model = modelTxtbox.Text;
            product.Price = priceTxtbox.Text;
            this.DialogResult = DialogResult.OK;
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}

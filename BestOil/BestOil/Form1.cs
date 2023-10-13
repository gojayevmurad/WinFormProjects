using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BestOil
{
    public partial class Form1 : Form
    {

        public double selectedFuelUnitPrice { get; set; }

        List<Fuel> fuels = new List<Fuel>
        {
            new Fuel{Title="AI-92",Price=1.01 },
            new Fuel{Title="AI-95",Price= 2.03 },
            new Fuel{Title="AI-98",Price=2.33 },
            new Fuel{Title="Diesel",Price=0.81 }
        };

        List<Food> foods = new List<Food>
        {
            new Food {Title = "Hot-Dog" , Price = 4 },
            new Food {Title = "Gamburger" , Price = 5.4 },
            new Food {Title = "French fries" , Price = 7 },
            new Food {Title = "Coca-Cola" , Price = 4.4 },
        };



        public Form1()
        {
            InitializeComponent();
            comboBxFuel.Items.AddRange(fuels.ToArray());
            comboBxFuel.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBxFuel_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = comboBxFuel.SelectedItem as Fuel;
            if (item == null) return;
            fuelLiterPrice.Text = item.Price.ToString();
            selectedFuelUnitPrice = item.Price;
        }

        private void fuel_radiobtn_changed(object sender, EventArgs e)
        {
            var radioBtn = sender as RadioButton;
            if(radioBtn.Text == "Liter")
            {
                priceTxtBox.Enabled = false;
                literTxtBox.Enabled = true;
            }
            if (radioBtn.Text == "Price")
            {
                priceTxtBox.Enabled = true;
                literTxtBox.Enabled = false;
            }
        }

        private void literTxtBox_TextChanged(object sender, EventArgs e)
        {

            string value = literTxtBox.Text;
            if (value == String.Empty)
            {
                priceTxtBox.Text = string.Empty;
                setFuelAmountLbl("0,00");
                return;
            }
            string fuelAmoubtLblData = (selectedFuelUnitPrice * Convert.ToDouble(value)).ToString();
            priceTxtBox.Text = fuelAmoubtLblData;
            setFuelAmountLbl(fuelAmoubtLblData);
        }

        private void priceTxtBox_TextChanged(object sender, EventArgs e)
        {
            string value = priceTxtBox.Text;
            if (value == String.Empty)
            {
                literTxtBox.Text = string.Empty;
                setFuelAmountLbl("0,00");
                return;
            }
            literTxtBox.Text = (Convert.ToDouble(value) / selectedFuelUnitPrice).ToString();
            setFuelAmountLbl(value);
        }

        private void setFuelAmountLbl(string value)
        {
            fuelAmountLbl.Text = value;
        }
    }
}

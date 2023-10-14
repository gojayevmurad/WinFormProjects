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

        public Form1()
        {
            InitializeComponent();

            comboBxFuel.Items.AddRange(fuels.ToArray());
            comboBxFuel.SelectedIndex = 0;

            hotdogPriceTbox.Text = Cafe.Foods.Find(food => food.Title == "Hot-Dog").Price + " USD";
            gamburgerPriceTbox.Text = Cafe.Foods.Find(food => food.Title == "Gamburger").Price + " USD";
            cocacolaPriceTbox.Text = Cafe.Foods.Find(food => food.Title == "Coca-Cola").Price + " USD";
            spritePriceTbox.Text = Cafe.Foods.Find(food => food.Title == "Sprite").Price + " USD";
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

        private void cafeCboxChanged(object sender, EventArgs e)
        {
            if(sender is CheckBox cBox)
            {

                    switch (cBox.Text)
                    {
                        case "Hot-Dog":
                            hotdogCountTbox.Text = hotdogCBox.Checked ? "1" : "0";
                            hotdogCountDecrease.Enabled = !hotdogCountDecrease.Enabled;
                            hotdogCountIncrease.Enabled = !hotdogCountIncrease.Enabled;
                            break;
                        case "Gamburger":
                            gamburgerCountTbox.Text = gamburgerCBox.Checked ? "1" : "0";
                            gamburgerCountDecrease.Enabled = !gamburgerCountDecrease.Enabled;
                            gamburgerCountIncrease.Enabled = !gamburgerCountIncrease.Enabled;
                            break;
                        case "Coca-Cola":
                            cocacolaCountTbox.Text = cocacolaCBox.Checked ? "1" : "0";
                            cocacolaCountDecrease.Enabled = !cocacolaCountDecrease.Enabled;
                            cocacolaCountIncrease.Enabled = !cocacolaCountIncrease.Enabled;
                            break;
                        case "Sprite":
                            spriteCountTbox.Text = spriteCBox.Checked ? "1" : "0";
                            spriteCountDecrease.Enabled = !spriteCountDecrease.Enabled;
                            spriteCountIncrease.Enabled = !spriteCountIncrease.Enabled;
                            break;
                        default:
                            break;
                    }
            }
        }

        private void foodCountChanged(object sender, EventArgs e)
        {
            if(sender is TextBox txtBox)
            {
                if (txtBox.Text == String.Empty) txtBox.Text = "0";
                switch(txtBox.Name)
                {
                    case "hotdogCountTbox":

                        int countHotdog = Convert.ToInt32(hotdogCountTbox.Text);

                        if (Cafe.Cart.ContainsKey("Hot-Dog")) Cafe.Cart["Hot-Dog"] = countHotdog;
                        else Cafe.Cart.Add("Hot-Dog", countHotdog);

                        break;
                    case "gamburgerCountTbox":

                        int countGamburger = Convert.ToInt32(gamburgerCountTbox.Text);

                        if (Cafe.Cart.ContainsKey("Gamburger")) Cafe.Cart["Gamburger"] = countGamburger;
                        else Cafe.Cart.Add("Gamburger", countGamburger);

                        break;
                    case "cocacolaCountTbox":

                        int countCola = Convert.ToInt32(cocacolaCountTbox.Text);

                        if (Cafe.Cart.ContainsKey("Coca-Cola")) Cafe.Cart["Coca-Cola"] = countCola;
                        else Cafe.Cart.Add("Coca-Cola", countCola);

                        break;
                    case "spriteCountTbox":
                        
                        int countSprite = Convert.ToInt32(spriteCountTbox.Text);

                        if (Cafe.Cart.ContainsKey("Sprite")) Cafe.Cart["Sprite"] = countSprite;
                        else Cafe.Cart.Add("Sprite", Convert.ToInt32(spriteCountTbox.Text));

                        break;
                    default:
                        break;
                }
                Cafe.CalculateTotalPrice();
                cafeAmountLbl.Text = Cafe.TotalPrice.ToString();
            }
        }

        private void hotdogCountBtnClicked(object sender, EventArgs e)
        {
            if(sender is Button btn)
            {
                if (btn.Text == "+")
                {
                    //if (Cafe.Cart["Hot-Dog"] == 0) hotdogCBox.Checked = false;
                    Cafe.Cart["Hot-Dog"] += 1;
                }
                else
                {
                    if (Cafe.Cart["Hot-Dog"] == 1) hotdogCBox.Checked = false;
                    else Cafe.Cart["Hot-Dog"] -= 1;
                }
                hotdogCountTbox.Text = Cafe.Cart["Hot-Dog"].ToString();

            }
        }

        private void gamburgerCountBtnClicked(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                if (btn.Text == "+")
                {
                    Cafe.Cart["Gamburger"] += 1;
                }
                else
                {
                    if (Cafe.Cart["Gamburger"] == 1) gamburgerCBox.Checked = false;
                    else Cafe.Cart["Gamburger"] -= 1;
                }
                gamburgerCountTbox.Text = Cafe.Cart["Gamburger"].ToString();

            }
        }

        private void colaCountBtnClicked(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                if (btn.Text == "+")
                {
                    Cafe.Cart["Coca-Cola"] += 1;
                }
                else
                {
                    if (Cafe.Cart["Coca-Cola"] == 1) cocacolaCBox.Checked = false;
                    else Cafe.Cart["Coca-Cola"] -= 1;
                }
                cocacolaCountTbox.Text = Cafe.Cart["Coca-Cola"].ToString();
            }
        }

        private void spriteCountBtnClicked(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                if (btn.Text == "+")
                {
                    Cafe.Cart["Sprite"] += 1;
                }
                else
                {
                    if (Cafe.Cart["Sprite"] == 1) spriteCBox.Checked = false;
                    else Cafe.Cart["Sprite"] -= 1;
                }
                spriteCountTbox.Text = Cafe.Cart["Sprite"].ToString();
            }
        }

        private void fuelOrCafeAmountChanged(object sender, EventArgs e)
        {
            totalPriceTbox.Text = (Convert.ToDouble(fuelAmountLbl.Text) + Cafe.TotalPrice).ToString(); 
        }
    }
}

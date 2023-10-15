using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace BestOil
{
    public partial class Form1 : Form
    {

        public double selectedFuelUnitPrice { get; set; }

        public Form1()
        {
            try
            {
                InitializeComponent();

                comboBxFuel.Items.AddRange(OilStation.Fuels.ToArray());
                OilStation.SelectedFuel = OilStation.Fuels[0];
                comboBxFuel.SelectedIndex = 0;

                hotdogPriceTbox.Text = Cafe.Foods.Find(food => food.Title == "Hot-Dog").Price + " USD";
                gamburgerPriceTbox.Text = Cafe.Foods.Find(food => food.Title == "Gamburger").Price + " USD";
                cocacolaPriceTbox.Text = Cafe.Foods.Find(food => food.Title == "Coca-Cola").Price + " USD";
                spritePriceTbox.Text = Cafe.Foods.Find(food => food.Title == "Sprite").Price + " USD";
            }
            catch (Exception ex)
            {
                FileHandler.ErrorLog(ex);
            }
        }

        private void comboBxFuel_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                OilStation.SelectedFuel = comboBxFuel.SelectedItem as Fuel;
                fuelLiterPrice.Text = OilStation.SelectedFuel.Price.ToString() + " USD";
            }
            catch (Exception ex)
            {
                FileHandler.ErrorLog(ex);
            }
        }

        private void fuel_radiobtn_changed(object sender, EventArgs e)
        {
            try
            {
                if(sender is RadioButton rb)
                {
                    OilStation.WithAmount = rb.Text == "Price";
                    literTxtBox.Enabled = !OilStation.WithAmount;
                    priceTxtBox.Enabled = OilStation.WithAmount;
                }
            }
            catch (Exception ex)
            { 
                FileHandler.ErrorLog(ex);
            }
            
        }


        private void literTxtBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string value = literTxtBox.Text;
                if (value != "" && value[value.Length-1] == '.')
                {
                    return;
                }

                if (value == "")
                {
                    OilStation.Liter = 0;
                    priceTxtBox.Text = "";
                }
                else
                {
                    OilStation.Liter = Convert.ToDouble(value);
                    priceTxtBox.Text = OilStation.Amount.ToString();
                }
                OilStation.Calculate();
                setFuelAmountLbl();
            }
            catch (Exception ex)
            {
                FileHandler.ErrorLog(ex);
            }
        }

        private void priceTxtBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string value = priceTxtBox.Text;
                if (value != "" && value[value.Length - 1] == '.')
                {
                    return;
                }

                if (value == "")
                {
                    OilStation.Amount = 0;
                    literTxtBox.Text = "";
                }
                else
                {
                    OilStation.Amount = Convert.ToDouble(value);
                    literTxtBox.Text = OilStation.Liter.ToString();
                }
                OilStation.Calculate();
                setFuelAmountLbl();
            }
            catch (Exception ex)
            {
                FileHandler.ErrorLog(ex);
            }
        }

        private void setFuelAmountLbl()
        {
            try
            {
                double value = OilStation.Amount;
                fuelAmountLbl.Text = value == 0 ? "0,00" : value.ToString();
            }
            catch (Exception ex)
            {
                FileHandler.ErrorLog(ex);
            }
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void cafeCboxChanged(object sender, EventArgs e)
        {
            try
            {
                if (sender is CheckBox cBox)
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
            catch (Exception ex)
            {
                FileHandler.ErrorLog(ex);
            }
        }

        private void foodCountChanged(object sender, EventArgs e)
        {
            try
            {
                if (sender is TextBox txtBox)
                {
                    if (txtBox.Text == String.Empty) txtBox.Text = "0";
                    switch (txtBox.Name)
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
            catch (Exception ex)
            {
                FileHandler.ErrorLog(ex);
            }
        }

        private void hotdogCountBtnClicked(object sender, EventArgs e)
        {
            try
            {
                if (sender is Button btn)
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
            catch (Exception ex)
            {
                FileHandler.ErrorLog(ex);
            }
        }

        private void gamburgerCountBtnClicked(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                FileHandler.ErrorLog(ex);
            }
        }

        private void colaCountBtnClicked(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                FileHandler.ErrorLog(ex);
            }
        }

        private void spriteCountBtnClicked(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                FileHandler.ErrorLog(ex);
            }
        }

        private void fuelOrCafeAmountChanged(object sender, EventArgs e)
        {
            try
            {
                totalPriceTbox.Text = (Convert.ToDouble(fuelAmountLbl.Text) + Cafe.TotalPrice).ToString();
            }
            catch (Exception ex)
            {
                FileHandler.ErrorLog(ex);
            }
        }

        private void btnPayAmount_Click(object sender, EventArgs e)
        {
            try
            {
                if (totalPriceTbox.Text == "0,00")
                {
                    MessageBox.Show("You haven't purchased anything yet, there is no amount to pay. Please choose the product you want to buy.",
                        "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    using (PdfWriter writer = new PdfWriter("CHECK.pdf"))
                    {
                        using(PdfDocument pdf = new PdfDocument(writer.SetSmartMode(true)))
                        {
                            Document document = new Document(pdf);
                            Table table = new Table(4);

                            Cell cell1 = new Cell().Add(new Paragraph("Product Title"));
                            Cell cell2 = new Cell().Add(new Paragraph("Count"));
                            Cell cell3 = new Cell().Add(new Paragraph("Unit Price"));
                            Cell cell4 = new Cell().Add(new Paragraph("Total Price"));

                            table.AddCell(cell1);
                            table.AddCell(cell2);
                            table.AddCell(cell3);
                            table.AddCell(cell4);

                            foreach (var cartItem in Cafe.Cart)
                            {
                                if (cartItem.Value == 0) continue;
                                table.AddCell(new Cell().Add(new Paragraph(cartItem.Key)));
                                table.AddCell(new Cell().Add(new Paragraph(cartItem.Value.ToString())));

                                foreach (var food in Cafe.Foods)
                                {
                                    if(food.Title == cartItem.Key)
                                    {
                                        table.AddCell(new Cell().Add(new Paragraph(food.Price.ToString())));
                                        table.AddCell(new Cell().Add(new Paragraph((food.Price * cartItem.Value) + " USD")));
                                    }
                                }
                            }

                            if(fuelAmountLbl.Text != "0,00")
                            {
                                table.AddCell(new Cell().Add(new Paragraph(OilStation.SelectedFuel.Title)));
                                table.AddCell(new Cell().Add(new Paragraph(OilStation.Liter + " L")));
                                table.AddCell(new Cell().Add(new Paragraph(OilStation.SelectedFuel.Price + " USD / L.")));
                                table.AddCell(new Cell().Add(new Paragraph(OilStation.Amount + " USD")));
                            }

                            table.AddCell(new Cell().Add(new Paragraph(" ")));
                            table.AddCell(new Cell().Add(new Paragraph(" ")));
                            table.AddCell(new Cell().Add(new Paragraph(" ")));
                            table.AddCell(new Cell().Add(new Paragraph(" ")));


                            table.AddCell(new Cell().Add(new Paragraph(" ")));
                            table.AddCell(new Cell().Add(new Paragraph(" ")));
                            table.AddCell(new Cell().Add(new Paragraph("Total Price : ")));
                            table.AddCell(new Cell().Add(new Paragraph(totalPriceTbox.Text + " USD")));


                            document.Add(table);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                FileHandler.ErrorLog(ex);
            }

        }

    }
}

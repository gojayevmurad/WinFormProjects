using ProductManager.Controllers;
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
    public partial class Form1 : Form
    {
        List<Product> products = new List<Product>
        {
            new Product
            {
                Name = "Apple",
                Model = "11 Pro Max",
                Price = "900"
            },
            new Product
            {
                Name = "Nokia",
                Model = "6300",
                Price = "1000"
            },
            new Product
            {
                Name = "Samsung",
                Model = "Galaxy S21",
                Price = "700"
            }
        };

        EventHandler<EventArgs> handler;

        Form2 form2 = new Form2();

        public Form1()
        {
            InitializeComponent();
            handler += changeItem;
            renderProducts();
        }

        void changeItem(object sender, EventArgs e)
        {
            if(sender is ShowProductUC productControl)
            {
                products.ForEach(item =>
                {
                    if(item.Model == productControl.Model)
                    {
                        form2.product = item;
                        if(DialogResult.OK == form2.ShowDialog()) renderProducts();
                    }
                });
            }
        }

        void createItem(object sender, EventArgs e)
        {
            Product newProduct = new Product();
            form2.product = newProduct;
            DialogResult dialogResult = form2.ShowDialog();

            if(DialogResult.OK == dialogResult)
            {
                products.Add(newProduct);
                renderProducts();
            }
        }


        void renderProducts()
        {
            panel1.Controls.Clear();
            int X = 0;
            int Y = 0;
            Point location;
            foreach (Product product in products)
            {
                ShowProductUC showProductUC = new ShowProductUC();
                location = new Point(X, Y);
                showProductUC.Name = product.Name;
                showProductUC.Model = product.Model;
                showProductUC.Price = product.Price;
                showProductUC.Location = location;
                showProductUC.handler = handler;
                panel1.Controls.Add(showProductUC);
                Y += 55;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductManager.Controllers
{
    public partial class ShowProductUC : UserControl
    {
        public EventHandler<EventArgs> handler;

        public string Name {
            get => nameLbl.Text;
            set => nameLbl.Text = value;
        }

        public string Model
        {
            get => modelLbl.Text;
            set => modelLbl.Text = value;
        }

        public string Price
        {
            get => priceLbl.Text;
            set => priceLbl.Text = value + " $";
        }


        public ShowProductUC()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            handler.Invoke(this, e);
        }
    }
}

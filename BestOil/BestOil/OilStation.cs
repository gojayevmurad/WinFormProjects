using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestOil
{
    static public class OilStation
    {
        static public List<Fuel> Fuels { get; set; } = new List<Fuel>
        {
            new Fuel{Title="AI-92",Price=1.01 },
            new Fuel{Title="AI-95",Price= 2.03 },
            new Fuel{Title="AI-98",Price=2.33 },
            new Fuel{Title="Diesel",Price=0.81 }
        };
        static public double Amount { get; set; } = 0;
        static public double Liter { get; set; } = 0;
        static public bool WithAmount { get; set; } = false;
        static public Fuel SelectedFuel { get; set; } = null;
        static public void Calculate()
        {
            if (SelectedFuel == null) return;
            if (WithAmount && Amount >= 0)
            {
                Liter = Amount / SelectedFuel.Price;
            }
            else if(!WithAmount && Liter >= 0)
            {
                Amount = Liter * SelectedFuel.Price;
            }
        }

        public static void Reset()
        {
            Amount = 0;
            Liter = 0;
            WithAmount = false;
            SelectedFuel = null;
        }


    }
}

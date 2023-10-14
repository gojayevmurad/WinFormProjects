using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestOil
{
    static public class Cafe
    {
        static public Dictionary<string, int> Cart { get; set; } = new Dictionary<string, int>();
        static public double TotalPrice { get; set; } = 0;

        static public List<Food> Foods { get; set; } = new List<Food>
        {
            new Food {Title = "Hot-Dog" , Price = 4 },
            new Food {Title = "Gamburger" , Price = 5.4 },
            new Food {Title = "Sprite" , Price = 7 },
            new Food {Title = "Coca-Cola" , Price = 4.4 },
        };

        static public void ResetCart()
        {
            Cart = new Dictionary<string, int>();
            TotalPrice = 0;
        }

        static public void CalculateTotalPrice()
        {
            TotalPrice = 0;
            foreach (var cartItem in Cart)
            {
                foreach (var food in Foods)
                {
                    if(cartItem.Key == food.Title)
                    {
                        TotalPrice += (cartItem.Value * food.Price);   
                    }
                }
            }
        }

    }
}

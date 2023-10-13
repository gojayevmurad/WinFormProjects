using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestOil
{
    internal class Food
    {
        public string Title { get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
            return this.Title;
        }
    }
}

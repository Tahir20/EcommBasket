using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewAbstract
{
    public class TShirt : Shirt
    {
        public TShirt() : base()
        {
        }

        public TShirt(string name, ProductSizes size) : base(name, size)
        {
        }

        public override double CalcPrice()
        {
            double total = base.CalcPrice();  //Because the price of TShirt is default we can just use the method from Tshirt's base class(Shirt)
            return total;
        }

    }
}

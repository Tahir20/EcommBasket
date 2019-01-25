using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewAbstract
{
    public class Jeans : Pants
    {
        public Jeans()
        {
        }

        public Jeans(string name, ProductSizes size) : base(name, size)
        {
        }
        


        public override double CalcPrice()
        {
            double total = base.CalcPrice();  //Because the price of Jeans is default we can just use the method from Jeans base class(Pants)
            return total;
        }
    }

}

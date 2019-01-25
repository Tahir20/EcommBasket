using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewAbstract
{
    public class Golfer : Shirt
    {
        public Golfer() : base()
        {
        }

        public Golfer(string name, ProductSizes size) : base(name, size)
        {
        }
        

        public override double CalcPrice()
        {
            double total = (base.CalcPrice()) * 2;  //Price of Golfer is twice that of the default price
            return total;
        }


    }
}

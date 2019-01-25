using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewAbstract
{
    public class FormalPants : Pants
    {
        public FormalPants()
        {
        }

        public FormalPants(string name, ProductSizes size) : base(name, size)
        {
        }
      



        public override double CalcPrice()
        {
            double total = (base.CalcPrice()) + 30;  //Price of Formal Pants is R30 extra on the default price
            return total;
        }
    }

}

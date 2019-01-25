using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewAbstract
{
    public class Pants : Product
    {
        public Pants()
        {
        }

        protected Pants(string name, ProductSizes size)
        {
            Name = name;
            Size = size;
        }
        //I have used the keyword protected above as a protected member is accessible within its class and by derived class instances.

        public override double CalcPrice()
        {           
            double total = (double)Size;//Pulls the price from ProductSizes
            return total;
        }

    }

}


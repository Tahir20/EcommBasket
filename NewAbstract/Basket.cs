using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewAbstract
{
    public class Basket
    {
        //public List<Shirt> Shirts { get; set; }
        //public List<Pants> Pants { get; set; }
        public List<Product> Products { get; set; }

        ///I have chosen to add the objects into a Products list that I have created in the Basket class instead
        ///of the seperate Shirts and Pants List as using one Products class would be more polymorphic because
        ///although Shirts and Pants maybe be different they are still Products.
        
        public Basket()
        {
            Products = new List<Product>();
        }

        public double GetTotalPrice()
        {
            double total = 0;
          
            total = Products.Sum(x => x.CalcPrice());//I used the Sum operator to calculate the total of the products in the Basket.
            return total;
        }
    }
}

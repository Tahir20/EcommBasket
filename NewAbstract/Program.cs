using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewAbstract
{
    class Program
    {
            static void Main(string[] args)
            {
                var basket = new Basket();

                var tshirt = new TShirt();
                tshirt.Name = "Gucci";
                tshirt.Size = ProductSizes.Medium; //Size is called using the enum ProductSizes
                //tshirt.Size = "m"; //If the user makes a spelling error,the shirt will not be found as there would be no shirt in that size
                //basket.Shirts.Add(tshirt);
                Product test = tshirt;
                basket.Products.Add(tshirt);
               ///I have chosen to add the objects into a Products list that I have created in the Basket class instead
               ///of the seperate Shirts and Pants List as using one Products class would be more polymorphic because
               ///although Shirts and Pants maybe be different they are still Products.

                var golfer = new Golfer();
                golfer.Name = "Polo";
                golfer.Size = ProductSizes.Small;
                //basket.Shirts.Add(golfer);
                basket.Products.Add(golfer);
                       
                var formalPants = new Jeans();
                formalPants.Name = "Calvin Klein";
                formalPants.Size = ProductSizes.Medium;
                //basket.Pants.Add(formalPants);
                basket.Products.Add(formalPants);

                var jeans = new FormalPants();
                jeans.Name = "Louis Vuitton";
                jeans.Size = ProductSizes.Large;
                //basket.Pants.Add(jeans);
                basket.Products.Add(jeans);

                Console.WriteLine($"Your total price is {basket.GetTotalPrice()}");
                Console.Read();
                //The expected total price is 120
            }
        }
    }

    


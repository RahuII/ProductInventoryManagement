using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class AddProduct
    {
        // Adding 10 product item which is load before running.
        public static void addDefaultProduct(List<Product> productList)
        {
            productList.Add(new Product("lettuce", "10.5 RS", 50, "Leafy green"));
            productList.Add(new Product("cabbage", "20 RS", 100, "Cruciferous"));
            productList.Add(new Product("pumpkin", "30 RS", 30, "Marrow"));
            productList.Add(new Product("cauliflower", "10 RS", 25, "Cruciferous"));
            productList.Add(new Product("zucchini", "20.5 RS", 50, "Marrow"));
            productList.Add(new Product("yam", "30 RS", 50, "Root"));
            productList.Add(new Product("spinach", "10 RS", 100, "Leafy green"));
            productList.Add(new Product("broccoli", "20.2 RS", 75, "Cruciferous"));
            productList.Add(new Product("garlic", "30 RS", 20, "Leafy green"));
            productList.Add(new Product("silverbeet", "10 RS", 50, "Marrow"));
        }


        // Taking product input from user.
        public static void takeInputProduct(List<Product> productList)
        {
            Console.WriteLine("Enter the product details......");

            Console.Write("Name: ");
            var name = Console.ReadLine();

            Console.Write("Price: ");
            var price = Console.ReadLine();

            Console.Write("Quantity: ");
            var quantity = Int16.Parse(Console.ReadLine());

            Console.Write("Type: ");
            var type = Console.ReadLine();

            Product p = new Product(name, price, quantity, type);


            // checking name of the product if cabbage and quantity is 50 then it will print total no of cabbage in the list.
            if (p.name.Equals("cabbage") && p.quantity == 50)
            {
                Console.WriteLine("Total no of cabbage in the list: " + (Product.GetQuantity(productList, "cabbage") + 50));
            }
            productList.Add(p);
        }
    }
}
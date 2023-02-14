using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Product
    {

        public string name { get; set; }
        public string price { get; set; }
        public int quantity { get; set; }
        public string type { get; set; }

        // making constructor for Product class.
        public Product(string name, string price, int quantity, string type)
        {
            this.name = name;
            this.price = price;
            this.quantity = quantity;
            this.type = type;
        }

        // GetQuantity method it will return quantity of the product using name.
        public static int GetQuantity(List<Product> productList, string productName)
        {
            foreach (var product in productList)
            {
                if (product.name.Equals(productName))
                {
                    return product.quantity;
                }
            }
            return 0;
        }

    }
}

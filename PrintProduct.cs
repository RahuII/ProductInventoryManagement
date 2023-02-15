using System;
namespace Assignment2
{
    class PrintProduct
    {
        // printing all product form the list.
        public static void PrintAllProduct(List<Product> productList)
        {
            Console.WriteLine("**************************************************************");
            foreach (var product in productList)
            {
                Console.WriteLine(product.name + ", " + product.price + ", " + product.quantity + ", " + product.type);
            }
        }


        // printing all the product by product type.
        public static void PrintByType(String productType, List<Product> productList)
        {
            foreach (Product product in productList)
            {
                if (product.type.Equals(productType))
                {
                    Console.WriteLine(product.name + ", " + product.price + ", " + product.quantity + ", " + product.type);
                }
            }
        }

    }
}
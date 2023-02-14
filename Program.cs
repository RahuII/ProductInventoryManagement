using System;
namespace Assignment2
{
    class Program
    {
        public static List<Product> productList = new List<Product>();
        public static void Main(string[] args)
        {
            AddProduct.addDefaultProduct(productList);
            Console.WriteLine("Total number of products in the list: " + productList.Count);

            AddProduct.takeInputProduct(productList);

            PrintProduct.PrintAllProduct(productList);
            Console.WriteLine("Total number of products in the list: " + productList.Count);

            Console.WriteLine("Printing all Leafy Green type product........");
            PrintProduct.PrintByType("Leafy green", productList);

            RemoveProduct.removeGarlic(productList);
            PrintProduct.PrintAllProduct(productList);
            Console.WriteLine("Total number of products in the list: " + productList.Count);

            PriceCalculate.calculatePrice(productList, "lettuce", 1, "zucchini", 2, "broccoli", 1);
        }

    }
}
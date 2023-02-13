using System;
namespace Assignment2
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Product> productList = new List<Product>();

            productList.Add(new Product() { name = "Rahul", price = 10.5, quantity = 50, type = "Leafy green" });
        }

        public static void addProduct()
        {

        }
    }
}
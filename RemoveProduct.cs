using System;
namespace Assignment2
{
    class RemoveProduct
    {
        // removing garlic from the list.
        public static void removeGarlic(List<Product> productList)
        {
            for (var i = 0; i < productList.Count; i++)
            {
                if (productList[i].name.Equals("garlic"))
                {
                    productList.RemoveAt(i);
                    Console.WriteLine("Garlic removed from list........");
                }
                i++;
            }
        }
    }
}
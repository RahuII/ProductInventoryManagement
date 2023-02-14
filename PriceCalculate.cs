namespace Assignment2
{
    class PriceCalculate
    {
        // calculating total price of the purchases of three product with taking quantity of the product.
        public static void calculatePrice(List<Product> productList, string productName1, int quantity1, string productName2, int quantity2, string productName3, int quantity3)
        {
            double price = 0;
            foreach (var product in productList)
            {
                if (product.name.Equals(productName1))
                {
                    price += trimPrice(product.price) * quantity1;
                }
                if (product.name.Equals(productName2))
                {
                    price += trimPrice(product.price) * quantity2;
                }
                if (product.name.Equals(productName3))
                {
                    price += trimPrice(product.price) * quantity3;
                }
            }

            // taking round off value using Math function. 
            Console.WriteLine("Total price of your purchases: " + Math.Round(price));
        }

        // trimming actual price in double.    ex:   10.5 RS -> 10.5
        public static double trimPrice(string price)
        {
            return double.Parse(price.Substring(0, price.Length - 3));
        }

    }
}
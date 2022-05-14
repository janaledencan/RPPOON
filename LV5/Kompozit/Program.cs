using System;

namespace Kompozit
{
    class Program
    {
        static void Main(string[] args)
        {
            Product bread = new Product("White bread", 4.50, 0.5);
            Product milk = new Product("Cow milk", 10, 1);
            Product candy = new Product("Strawberry candy", 11, 0.45);

            Box dailyCart = new Box("ShoppingCart");

            dailyCart.Add(bread);
            dailyCart.Add(milk);
            dailyCart.Add(candy);

            Box chocolateBox = new Box("Chocolate");
            chocolateBox.Add(new Product("Ferrero Rocher", 12, 0.3));
            chocolateBox.Add(new Product("Raffaelo", 8, 0.3));

            dailyCart.Add(chocolateBox);

            Console.WriteLine(dailyCart.Description());
            Console.WriteLine(dailyCart.Weight);

            Console.WriteLine(new ShippingService(1.2).CalculatePacketPrice(chocolateBox));
        }
    }
}

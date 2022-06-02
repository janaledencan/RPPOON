using System;

namespace Visitant
{
    class Program
    {
        static void Main(string[] args)
        {
            //5.

            VHS vhs = new VHS("HI", 6.5);
            DVD dvd = new DVD("Mj favourite film",DVDType.MOVIE, 8.99);
            Book book = new Book("Crime and Punishment", 7.59 );

            BuyVisitor buyVisitor = new BuyVisitor();

            Console.WriteLine(vhs.Accept(buyVisitor));
            Console.WriteLine(book.Accept(buyVisitor));

            //6.

            RentVisitor rentVisitor = new RentVisitor();
            Console.WriteLine(vhs.Accept(rentVisitor));
            Console.WriteLine(dvd.Accept(rentVisitor));
            Console.WriteLine(book.Accept(rentVisitor));

            DVD dvd2 = new DVD("Windows", DVDType.SOFTWARE, 3000);
            Console.WriteLine(dvd2.Accept(rentVisitor));

            //7.
            Cart cart = new Cart();
            cart.Add(vhs);
            cart.Add(dvd);
            cart.Add(book);
            cart.Add(dvd2);

            Console.WriteLine(cart.Accept(rentVisitor));

        }
    }
}

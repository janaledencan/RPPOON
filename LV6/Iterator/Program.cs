using System;
using Cursor.Task2;

namespace Cursor
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.

            Notebook notebook = new Notebook();

            notebook.AddNote(new Note("Hello World!", "We are soo happy."));
            notebook.AddNote(new Note("Flower", "You are my sunshine, my only sunshine..."));
            notebook.AddNote(new Note("Happy", "Are you happy?"));

            IAbstractIterator iterator = notebook.GetIterator();

            for (Note note = iterator.First(); iterator.IsDone == false; note = iterator.Next())
            {
                note.Show();
            }


            //2.

            Box box = new Box();

            box.AddProduct(new Product("Pineapple", 23.40));
            box.AddProduct(new Product("Flower", 8.99));
            box.AddProduct(new Product("Candy", 7.89));

            Cursor.Task2.IAbstractIterator productIterator = box.GetIterator(); //Not the best idea

            for (Product product = productIterator.First(); productIterator.IsDone == false; product = productIterator.Next())
            {
                product.ToString();
            }
            
        }
    }
}

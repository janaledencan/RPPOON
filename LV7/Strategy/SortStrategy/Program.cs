using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array = { 5, 7, 3, 8, 4, 1, 5, 3, 2, 9 };

            NumberSequence numberSequence = new NumberSequence(array);
            Console.WriteLine(numberSequence);

            numberSequence.SetSortStrategy(new BubbleSort());
            numberSequence.Sort();
            Console.WriteLine(numberSequence);

            //2.
            numberSequence.SetSearchStrategy(new LinearSearch());
            Console.WriteLine(numberSequence.Search(6));


        }
    }
}

using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = { 5, 7, 3, 8, 4, 1, 5, 3, 2, 9 };

            NumberSequence numberSequence = new NumberSequence(numbers);
            Console.WriteLine(numberSequence);

            numberSequence.SetSortStrategy(new BubbleSort());
            numberSequence.Sort();
            Console.WriteLine(numberSequence);

            //2.
            numberSequence.SetSearchStrategy(new LinearSearch());
            Console.WriteLine(numberSequence.Search(6));

            NumberSequence numSeq = new NumberSequence(new BubbleSort(), numbers);
            numSeq.Sort();
            Console.WriteLine(numSeq);

        }
    }
}

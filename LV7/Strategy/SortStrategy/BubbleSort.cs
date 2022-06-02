using System;
using System.Collections.Generic;
using System.Text;


namespace Strategy
{
    class BubbleSort : SortStrategy
    {
        public override void Sort(double[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (array[j] > array[j+1])
                    {
                        Swap(ref array[j], ref array[j+1]);
                    }
                }
            }
        }
    }
}

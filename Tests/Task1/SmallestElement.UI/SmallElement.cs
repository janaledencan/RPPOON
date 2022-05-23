using System;

namespace SmallestElement.Core
{
    public class SmallElement
    {
        public int FindTheSmallestElement(int[] numbers)
        {
            int smallestNumber = numbers[0];

            if(numbers.Length == 0)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                for(int i=0; i<numbers.Length; i++)
                {
                    if(numbers[i] < smallestNumber)
                    {
                        smallestNumber = numbers[i];
                    }
                }
            }
            
            return smallestNumber;
        }
    }
}

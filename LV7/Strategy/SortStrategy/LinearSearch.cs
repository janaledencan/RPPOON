using System;
using System.Collections.Generic;
using System.Text;


namespace Strategy
{
    class LinearSearch : ISearchStrategy
    {
        public bool Search(double[] array, double number)
        {
              int n = array.Length;
              for (int i = 0; i < n; i++)
              {
                  if (array[i] == number)
                      return true;
              }
              return false;
           
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    interface ISearchStrategy
    {
        bool Search(double[] array, double number);
    }
}

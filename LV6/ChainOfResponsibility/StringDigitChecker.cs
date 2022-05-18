using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    class StringDigitChecker : StringChecker
    {
        protected override bool PerformCheck(string stringToCheck)
        {
            for(int i=0; i<stringToCheck.Length; i++)
            {
                if (stringToCheck[i] >= 48 && stringToCheck[i] <= 57)
                {
                    return true;
                }
            }
              return false;
            
        }
    }
}

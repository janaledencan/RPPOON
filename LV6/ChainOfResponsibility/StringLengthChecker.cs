using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    class StringLengthChecker : StringChecker
    {
        protected override bool PerformCheck(string stringToCheck)
        {
            if(stringToCheck == null) //stringToCheck.Length=0
            {
                return false;
            }
            return true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    class StringLowerCaseChecker : StringChecker
    {
        protected override bool PerformCheck(string stringToCheck)
        {
            for (int i = 0; i < stringToCheck.Length; i++)
            {
                if (stringToCheck[i] >= 97 && stringToCheck[i] <= 122)
                {
                    return true;
                }
            }
            return false;
        }
    }
}

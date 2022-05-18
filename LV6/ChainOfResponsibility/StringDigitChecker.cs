using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    class StringDigitChecker : StringChecker
    {
        protected override bool PerformCheck(string stringToCheck)
        {
            if (stringToCheck.Contains('1') || stringToCheck.Contains('2'))

                return false;
            return true;
        }
    }
}

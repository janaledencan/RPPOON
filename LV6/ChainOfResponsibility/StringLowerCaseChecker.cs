using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    class StringLowerCaseChecker : StringChecker
    {
        protected override bool PerformCheck(string stringToCheck)
        {
            char[] newString = stringToCheck.ToCharArray();
            char[] lowerCaseString = stringToCheck.ToLower().ToCharArray();

            for (int i = 0; i < stringToCheck.Length; i++)
            {
                if (newString[i] == lowerCaseString[i])
                {
                    return true;
                }
            }
            return false;
        }
    }
}

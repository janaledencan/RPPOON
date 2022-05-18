using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    class StringUpperCaseChecker : StringChecker
    {
        protected override bool PerformCheck(string stringToCheck)
        {
            char[] newString = stringToCheck.ToCharArray();
            char[] upperCaseString = stringToCheck.ToUpper().ToCharArray();
            
            for(int i=0; i<stringToCheck.Length; i++)
            {
                if (newString[i] == upperCaseString[i])
                {
                    return true;
                }
            }
            return false;
                
        }
    }
}

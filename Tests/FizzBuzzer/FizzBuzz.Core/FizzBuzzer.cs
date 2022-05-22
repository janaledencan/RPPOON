using System;

namespace FizzBuzz.Core
{
    public class FizzBuzzer
    {
        public string Convert(int number)
        {
            string convertedNumber = "";

            if (number % 3 == 0)
            {
                convertedNumber +="Fizz";
            }
            if (number % 5 == 0)
            {
                convertedNumber += "Buzz";
            }
            if(String.IsNullOrEmpty(convertedNumber))
            {
                convertedNumber = number.ToString();
            }
            return convertedNumber;
        }
    }
}

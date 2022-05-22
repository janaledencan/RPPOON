using NUnit.Framework;
using FizzBuzz.Core;

namespace FizzBuzz.Test
{
    public class Tests
    {
        [Test]
        public void FizzBuzzConvert_When1_Returns1()
        {
            //Arrange
            int input = 1;
            FizzBuzzer FizzBuzzer = new FizzBuzzer();
            string expected = "1";

            //Act
            string actual = FizzBuzzer.Convert(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
using NUnit.Framework;
using FizzBuzz.Core;

namespace FizzBuzz.Test
{
    public class Tests
    {
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(7)]

        public void FizzBuzzerConvert_WhenNotDivisible_ReturnsInput(int input)
        {
            //Arrange
            FizzBuzzer FizzBuzzer = new FizzBuzzer();
            string expected = $"{input}";  //input.ToString();

            //Act
            string actual = FizzBuzzer.Convert(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(3)]
        [TestCase(6)]
        [TestCase(12)]
        public void FizzBuzzerConvert_WhenDivisibleBy3_ReturnsFizz(int input)
        {
            //Arrange
            FizzBuzzer FizzBuzzer = new FizzBuzzer();
            string expected = "Fizz";

            //Act
            string actual = FizzBuzzer.Convert(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(5)]
        [TestCase(10)]
        [TestCase(20)]
        public void FizzBuzzerConvert_WhenDivisibleBy5_ReturnsBuzz(int input)
        {
            //Arrange
            FizzBuzzer FizzBuzzer = new FizzBuzzer();
            string expected = "Buzz";

            //Act
            string actual = FizzBuzzer.Convert(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(15)]
        [TestCase(30)]
        [TestCase(45)]
        public void FizzBuzzerConvert_WhenDivisibleBy3And5_ReturnsFizzBuzz(int input)
        {
            //Arrange
            FizzBuzzer FizzBuzzer = new FizzBuzzer();
            string expected = "FizzBuzz";

            //Act
            string actual = FizzBuzzer.Convert(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
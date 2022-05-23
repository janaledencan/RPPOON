using NUnit.Framework;
using SmallestElement.Core;
using System;

namespace SmallestElement.Test
{
    public class Tests
    {
        [Test]
        public void FindingSmallestElementInArray_WithDifferentElements_Returns1()
        {
            //Arrange
            int[] input = { 9, 3, 5, 2, 7, 8, 1, 9 };
            int expected = 1;
            SmallElement element = new SmallElement();

            //Act
            int actual = element.FindTheSmallestElement(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void FindingSmallestElementInArray_WithSameElements_Returns9()
        {
            //Arrange
            int[] input = { 9 , 9 , 9 , 9 };
            int expected = 9;
            SmallElement element = new SmallElement();

            //Act
            int actual = element.FindTheSmallestElement(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void FindingSmallestElementInArray_EmptyArray_ReturnsNull()
        {
            //Arrange
            int[] input = {};
            SmallElement element = new SmallElement();


            // Act/Assert
            Assert.Throws<IndexOutOfRangeException>(() => element.FindTheSmallestElement(input));
        }

    }
}
using System;
using Xunit;
using Lab03_SystemIO;

namespace lab03tests
{
    public class UnitTest1
    {
        //--------challenge 01 tests
        [Fact]
        public void HappyPath1()
        {
            decimal result = Program.ProductOfThree("1 12 2");
            Assert.Equal(24, result);
        }
        [Fact]
        public void SadPath1()
        {
            decimal result = Program.ProductOfThree("5");
            Assert.NotEqual(1, result);
        }
        //------challenge 02 tests
        [Fact]
        public void HappyPath2()
        {
            decimal[] array = new decimal[] { 1, 2, 3 };
            decimal result = Program.AverageOfNumbers(array);
            Assert.Equal(2, result);
        }
        [Fact]
        public void SadPath2()
        {
            decimal[] array = new decimal[] { -1, -2, -3 };
            decimal result = Program.AverageOfNumbers(array);
            Assert.NotEqual(2, result);
        }
    }
}

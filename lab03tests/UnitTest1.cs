using System;
using Xunit;
using Lab03_SystemIO;

namespace lab03tests
{
    public class UnitTest1
    {
        [Fact]
        public void HappyPath()
        {
            decimal result = Program.ProductOfThree("1 12 2");
            Assert.Equal(24, result);
        }
    }
}

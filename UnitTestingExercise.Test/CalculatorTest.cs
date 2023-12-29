using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestingExercise.Test
{
    public class CalculatorTest
    {
        [Theory]
        [InlineData(0, 1, 1,2)]
        [InlineData(0, 0, 0, 0)]
        [InlineData(-1, -1, -1, -3)]
        [InlineData(-2, 1, 1, 0)]
        public void Add_Test(int num1, int num2, int num3, int Expected)
        {
            // Arrange
            var c = new Calculator();
            //Act
            var actual = c.Add(num1, num2, num3);
            //assert
            Assert.Equal(Expected, actual);
        }

        [Theory]
        [InlineData(1, 1, 0)]
        [InlineData( 0, 0, 0)]
        [InlineData(-1, -1, 0)]
        [InlineData(-2, 1, -3)]
        public void Subtract_Test(int num1, int num2, int Expected)
        {
            // Arrange
            var c = new Calculator();
            //Act
            var actual = c.Subtract(num1, num2);
            //assert
            Assert.Equal(Expected, actual);
        }

        [Theory]
        [InlineData(1, 1, 1)]
        [InlineData(0, 0, 0)]
        [InlineData(1, -1, -1)]
        [InlineData(-2, 1, -2)]
        public void Multiple_Test(int num1, int num2, int Expected)
        {
            // Arrange
            var c = new Calculator();
            //Act
            var actual = c.Multiple(num1, num2);
            //assert
            Assert.Equal(Expected, actual);
        }

        [Theory]
        [InlineData(1, 1, 1)]
        [InlineData(8, 2, 4)]
        [InlineData(-8, -1, 8)]
        [InlineData(36, 6, 6)]
        public void Division_Test(int num1, int num2, int Expected)
        {
            // Arrange
            var c = new Calculator();
            //Act
            var actual = c.Division(num1, num2);
            //assert
            Assert.Equal(Expected, actual);
        }



    }
}

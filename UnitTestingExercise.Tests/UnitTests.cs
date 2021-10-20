using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(1,1,2, 4)]
        [InlineData(2,2,3,7)]
        [InlineData(1,1,1,3)]
        public void Add(int num1, int num2, int num3, int expected)
        {
            //Arrange
            var test1 = new UnitTestMethods();
            //Act
            var actual = test1.Add(num1, num2, num3);
            //Assert
            Assert.Equal(actual, expected);
        }

        [Theory]
        [InlineData(6,2,4)]
        [InlineData(5,2,3)]
        [InlineData(4,2,2)]
        public void Subtract(int minuend, int subtrhend, int expected)
        {
            //Arrange
            var test2 = new UnitTestMethods();
            //Act
            var actual = test2.Subtract(minuend, subtrhend);
            //Assert
            Assert.Equal(actual, expected);
        }

        [Theory]
        [InlineData(2,2,4)]
        [InlineData(3,2,6)]
        [InlineData(1,1,1)]
        public void Multiply(int num1, int num2, int expected)
        {
            //Arrange
            var test3 = new UnitTestMethods();
            //Act
            var actual = test3.Multiply(num1, num2);
            //Assert
            Assert.Equal(actual, expected);
        }

        [Theory]
        [InlineData(9,3,3)]
        [InlineData(10,2,5)]
        public void Divide(int num1, int num2, int expected)
        {
            //Arrange
            var test4 = new UnitTestMethods();
            //Act
            var actual = test4.Divide(num1, num2);
            //Assert
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void SayHello()
        {
            //Arrange
            var hello1 = new UnitTestMethods();
            
            //Act
            var actual = hello1.SayHello();

            //Assert
            Assert.Equal("Hello World!", actual);
        }

        [Fact]
        public void MethodName2()
        {
            //Arrange
            var hello2 = new UnitTestMethods();
            //Act
            var actual = hello2.MethodName2();
            //Assert
            Assert.Equal("this doesnt work!", actual);
        }
    }
}

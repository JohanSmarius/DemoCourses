using System;
using DemoApp;
using Xunit;

namespace UnitTests
{
    public class TestStudent
    {
        [Fact]
        public void FullName_Given_First_And_Last_Should_Return_Catenation()
        {
            // Arrange


            // Act
            var sut = new student("John", "Smith");

            // Assert
            Assert.Equal("John Smith", sut.FullName);
        }
        [Fact]
        public void FullName_Given_Empty_First_Name_Should_Throw_ArgumentException()
        {
            // Act
            Assert.Throws<ArgumentNullException>(() => new student("", "Smith"));
        }
    }
}

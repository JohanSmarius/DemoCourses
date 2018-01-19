using System;
using CourseDomain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CourseTests
{
    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void FullName_Given_First_And_Last_Should_Return_Catenation()
        {
            // Arrange


            // Act
            var sut = new student("John", "Smith");

            // Assert
            Assert.AreEqual("John Smith", sut.FullName);
        }
        [TestMethod]
        public void FullName_Given_Empty_First_Name_Should_Throw_ArgumentException()
        {
            // Act
            try
            {
                new student("", "Smith");
                Assert.Fail("Unreachable");
            }
            catch (ArgumentNullException)
            {
                
            }
        }
    }
}

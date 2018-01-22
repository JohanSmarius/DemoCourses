using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CourseDomain;

namespace CourseTests
{

    [TestClass]
    public class CoursesTests
    {
 
        [TestMethod]
        public void AddStudents_Given_Exchange_Student_Should_Set_Should_Be_Given_In_English()
        {
            // Arrange
            var students = new List<student>();
            students.Add(new student("Jane", "Doe"));
            students.Add(new ExchangeStudent("Bill", "Gates", 
                new Country() { Name = "The Netherlands", Language = "Dutch" }));


            // Act
            var sut = new Course();
            sut.AddStudents(students);

            // Assert
            Assert.IsTrue(sut.ShouldBeGivenInEnglish);
        }
    }
}

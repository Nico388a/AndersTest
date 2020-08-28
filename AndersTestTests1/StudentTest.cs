using Microsoft.VisualStudio.TestTools.UnitTesting;
using AndersTest;
using System;
using System.Collections.Generic;
using System.Text;

namespace AndersTest.Tests
{
    [TestClass()]
    public class StudentTest
    {
        private Student _student;

            [TestInitialize]
        public void Init()
        {
            _student = new Student("Gin", "Rødby", 3, GenderType.Woman);
        }


        //Semester Test
        [TestMethod()]
        public void SemesterTest()
        {
            //Arrange
            _student.Semester = 1;
            //Act

            //Assert
            Assert.AreEqual(1, _student.Semester);
            Assert.ThrowsException<ArgumentOutOfRangeException>(()=>_student.Semester = 0);

            _student.Semester = 8;
            Assert.AreEqual(8, _student.Semester);
        }


        



    }
}
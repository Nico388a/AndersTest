using Microsoft.VisualStudio.TestTools.UnitTesting;
using AndersTest;
using System;
using System.Collections.Generic;
using System.Text;

namespace AndersTest.Tests
{
    [TestClass()]
    public class StudentTests
    {
        [TestInitialize]
        public void Init()
        {

        }

        //Name Test
        [TestMethod()]
        public void NameTest()
        {
            //Arrange
            Student st1 = new Student("Bo", "BuleVard 23", 4, GenderType.Man);

            //Assert
            Assert.AreEqual("Bo", st1.Name);
        }


        //Adress Test
        [TestMethod()]
        public void AdressTest()
        {
            //Arrange
            Student st2 = new Student("Ki", "Roskilde", 3, GenderType.Woman);
            //Act

            //Assert
            Assert.AreEqual("Roskilde", st2.Adress);

        }
        [TestMethod()]
        public void AdressNullTest()
        {
            //Arrange
            Student st2 = new Student("Ki", "Roskilde", 3, GenderType.Woman);
            //Act

            //Assert
            Assert.ThrowsException<ArgumentNullException>(() => st2.Adress = null);

        }


        //Semester Test
        [TestMethod()]
        public void SemesterTest()
        {
            //Arrange
            Student st2 = new Student("LU", "Roskilde", 3, GenderType.Woman);
            //Act

            //Assert
            Assert.AreEqual(3, st2.Semester);
        }


        //Gender Test
        [TestMethod()]
        public void GenderTest()
            //Arrange
        {
            Student st3 = new Student("Mo", "Roskilde", 3, GenderType.Man);

            //Assert
            Assert.AreEqual(GenderType.Man, st3);
        }


    }
}
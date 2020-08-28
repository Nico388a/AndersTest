using System;
using System.Collections.Generic;
using System.Text;
using AndersTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AndersTestTests1
{
    [TestClass]
    public class PersonTest
    {
        private Person _person;

        [TestInitialize]
        public void Init()
        {
            _person = new Person("Svend", "Valby", GenderType.Man);
        }

        //Name Test
        [TestMethod()]
        public void NameTest()
        {
            //Arrange
            _person.Name = "Bo";

            //Assert
            Assert.AreEqual("Bo", _person.Name);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => _person.Name = "Q");
        }

        
        //Adress Test
        [TestMethod()]
        public void AdressTest()
        {
            //Arrange
            _person.Adress = "Havdrup";
            //Act

            //Assert
            Assert.AreEqual("Havdrup", _person.Adress);

            Assert.ThrowsException<ArgumentNullException>(() => _person.Adress = null);
        }
        //[TestMethod()]
        //public void AdressNullTest()
        //{
        //    //Arrange
        //    Student st2 = new Student("Ki", "Roskilde", 3, GenderType.Woman);
        //    //Act

        //    //Assert
        //    Assert.ThrowsException<ArgumentNullException>(() => st2.Adress = null);

        //}

        //Gender Test
        [TestMethod()]
        public void GenderTest()
            //Arrange
        {
            Student st3 = new Student("Mo", "Roskilde", 3, GenderType.Man);

            //Assert
            Assert.AreEqual(GenderType.Man, st3.Gender);
        }
    }
}

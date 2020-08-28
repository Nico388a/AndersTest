using System;
using System.Collections.Generic;
using System.Text;
using AndersTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AndersTestTests1
{
    [TestClass]
    public class TeacherTest
    {
        private Teacher _teacher;
        [TestInitialize]
        public void Init()
        {
            _teacher = new Teacher("Poul", "Roskilde", GenderType.Man, 250);
        }

        [TestMethod]
        public void SalaryTest()
        {
            

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => _teacher.Salary = -1);

            _teacher.Salary = 0;

            Assert.AreEqual(0, _teacher.Salary);


        }

    }
}

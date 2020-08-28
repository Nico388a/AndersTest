using System;
using System.Collections.Generic;
using System.Text;

namespace AndersTest
{
    
    public class Teacher: Person
    {

        //private string _name;

        //public string Name
        //{
        //    get { return _name; }
        //    set
        //    {
        //        if (value.Length > 1)
        //        {
        //            _name = value;
        //        }
        //        else
        //        {
        //            new ArgumentOutOfRangeException();
        //        }


        //    }
        //}


        //private string _adress;
        //public string Adress
        //{
        //    get { return _adress; }
        //    set
        //    {
        //        if (value != null)
        //        {
        //            _adress = value;
        //        }
        //        else
        //        {
        //            throw new ArgumentNullException();
        //        }
        //    }

        //}

        private int _salary;

        public int Salary
        {
            get { return _salary; }
            set
            {
                if (value >= 0)
                {
                    _salary = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }

            }
        }

        //private GenderTypeTeacher _genderTypeTeacher;

        //public GenderTypeTeacher Gen
        //{
        //    get { return _genderTypeTeacher; }
        //    set { _genderTypeTeacher = value; }
        //}

        //public Teacher(string name, string adress, int salary, GenderTypeTeacher genderTypeTeacher)
        //{
        //    _name = name;
        //    _adress = adress;
        //    _salary = salary;
        //    _genderTypeTeacher = genderTypeTeacher;
        //}

        public Teacher(string name, string adress, GenderType genderType, int salary) : base(name, adress, genderType)
        {
            _salary = salary;
        }
    }
}

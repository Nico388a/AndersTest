using System;
using System.Collections.Generic;
using System.Text;

namespace AndersTest
{
    
    /// <summary>
    /// Student klasse
    /// </summary>
    public class Student: Person
    {

        ////Name
        //private string _name;

        //public string Name
        //{
        //    get { return _name; }
        //    set {
        //        if (value.Length > 1) 
        //        {
        //            _name = value;
        //        }
        //        else
        //        {
        //            throw new ArgumentOutOfRangeException();
        //        }

        //    }
        //}

        ////Adress

        //private string _adress;
        //public string Adress
        //{
        //    get { return _adress; }
        //    set {
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


        //Semester
        private int _semester;

        public int Semester
        {
            get { return _semester; }
            set
            {
                if (1 <= value && value <= 8)
                {
                    _semester = value;
                }

                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }

        }

        ////Gender
        //private GenderType _genderType;

        //public GenderType Gender
        //{
        //    get { return _genderType; }
        //    set {
        //        if (value != GenderType.Man || value != GenderType.Woman)
        //        {
        //            _genderType = value;
        //        }
        //        else
        //        {
        //            throw new ArgumentOutOfRangeException();
        //        }
        //    }
        //}


        ////Constructor
        //public Student(string name, string adress, int semester, GenderType genderType)
        //{
        //    _name = name;
        //    _adress = adress;
        //    _semester = semester;
        //    _genderType = genderType;
        //}

        ////ToString metode
        //public override string ToString()
        //{
        //    return base.ToString();
        //}
        public Student(string name, string adress, int semester,GenderType genderType) : base(name, adress, genderType)
        {
            _semester = semester;
        }
    }
}

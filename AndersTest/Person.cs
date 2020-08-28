using System;
using System.Collections.Generic;
using System.Text;

namespace AndersTest
{
    //Enumtype køn
    public enum GenderType
    {
        Man,
        Woman
    };
   public class Person
    {
        //Name
        private string _name;

        public string Name
        {
            get { return _name; }
            set
            {
                if (value.Length > 1)
                {
                    _name = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                    
                }

            }
        }

        //Adress

        private string _adress;
        public string Adress
        {
            get { return _adress; }
            set
            {
                if (value != null)
                {
                    _adress = value;
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
        }



        //Gender
        private GenderType _genderType;

        public GenderType Gender
        {
            get { return _genderType; }
            set { _genderType = value; }
        }


        //Constructor
        public Person(string name, string adress, GenderType genderType)
        {
            _name = name;
            _adress = adress;
            _genderType = genderType;
        }

        //ToString metode
        public override string ToString()
        {
            return base.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesApp
{
    public class Person
    {
        private string _firstName;
        private string _lastName;
        private int _age;

        public Address Address { get; set; }
        public Person() { }
        public Person(string fName, string lName, Address address = null)
        {
            _firstName = fName;
            _lastName = lName;
            Address = address;
        }

        public int Age
        {
            get { return _age; }
            set { if (value >= 0) _age = value; }
        }

        public string GetFullName()
        {
            return $"{_firstName} {_lastName}";
        }

        public string Move()
        {
            return "Walking along";
        }

        public string Move(int times)
        {
            return $"Walking along {times} times";
        }

        public string GetAddress()
        {
            return $"{Address.GetAddress()}";
        }

        public override string ToString()
        {
            return $"{base.ToString()} Name: {GetFullName()} Age: {Age}. {GetAddress()}";
        }

    }
}

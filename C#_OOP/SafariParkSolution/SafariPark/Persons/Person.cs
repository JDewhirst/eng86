using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariPark
{
    public class Person : IMoveable
    {
        private string _firstName;
        private string _lastName;

        private int _age;

        public int Age { get => _age; set => _age = value >= 0 ? value : 0; }

        public Person() { }
        public Person(string fName, string lName )
        {
            _firstName = fName;
            _lastName = lName;
        }

        public string GetFullName()
        {
            return $"{_firstName} {_lastName}";
        }

        public override string ToString()
        {
            return $"{base.ToString()} Name: {GetFullName()} Age: {Age}";
        }

        public virtual string Move()
        {
            return $"Walking along";
        }

        public virtual string Move(int times)
        {
            return $"Walking along {times} times";
        }


    }
}

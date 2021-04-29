using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace ComparingObjects
{
    public class Program
    {
        static void Main(string[] args)
        {
            var bob1 = new Person("Bob", "Builder") { Age = 25 };
            var bob2 = bob1;
            var bob3 = new Person("Bob", "Builder");
            //var areSame = bob1.Equals(bob3);
            var pat = new Person("Postman", "Pat") { Age = 40 };
            Person nish = null;

            var compare = bob1.CompareTo(pat);

            var personList = new List<Person>
            {
                new Person("Cath","Cookson")
                , new Person("Tommy", "Andrews") {Age = 32}
                , new Person("Bob", "Builder") {Age = 25 }
                , new Person("Bob", "Builder") {Age = 33 }
                , new Person("Dan","Dare")
                , new Person ("Amy", "Andrews") {Age = 32}
                , nish
            };
            personList.Sort();
            //var hasBob = personList.Contains(bob1);
        }
    }


    public class Person : IEquatable<Person>, IComparable<Person>
    {
        private string _firstName;
        private string _lastName;
        public int Age { get; set; }

        public Person(string fName, string lName)
        {
            _firstName = fName;
            _lastName = lName;
        }

        public override string ToString() => $"{_firstName} {_lastName}";

        public override bool Equals(object obj)
        {
            return Equals(obj as Person);
        }

        public bool Equals(Person other)
        {
            return other != null &&
                   _firstName == other._firstName &&
                   _lastName == other._lastName &&
                   Age == other.Age;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_firstName, _lastName, Age);
        }

        public int CompareTo([AllowNull] Person other)
        {
            if (other == null) return 1;
            if (this._lastName != other._lastName)
            {
                return this._lastName.CompareTo(other._lastName);
            }
            else if (this._firstName != other._firstName)
            {
                return this._firstName.CompareTo(other._firstName);
            }
            else
            {
                return this.Age.CompareTo(other.Age);
            }
        }

        public static bool operator ==(Person left, Person right)
        {
            return EqualityComparer<Person>.Default.Equals(left, right);
        }

        public static bool operator !=(Person left, Person right)
        {
            return !(left == right);
        }
    }
}

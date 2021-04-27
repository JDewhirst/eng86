using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariPark
{
    public class Vehicle
    {
        protected int _capacity;
        protected int _numPassengers;
        protected int _speed = 10;

        public int NumPassengers 
        {
            get { return _numPassengers; }
            set
            {
                if (value < 0)
                {
                    _numPassengers = 0;
                }
                else if (value > _capacity)
                {
                    _numPassengers = _capacity;
                }
                else
                {
                    _numPassengers = value;
                }
            }
        }
        public int Position { get; protected set; }

        public Vehicle(){}

        public Vehicle(int capacity, int speed = 10 )
        {
            _speed = speed;
            _capacity = capacity;
        }

        public virtual string Move()
        {
            Position += _speed;
            return $"Moving along";

        }

        public virtual string Move(int times)
        {
            Position += times * _speed;
            return $"Moving along {times} times";
        }


        public override string ToString()
        {
            return base.ToString();
        }


    }
}

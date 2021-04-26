using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariPark
{
    public class Vehicle
    {
        private int _capacity = 4;
        private int _numPassengers;
        private int _speed;

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
        public int Position { get; private set; }

        public Vehicle()
        {
            _speed = 10;

        }

        public Vehicle(int capacity, int speed = 10 )
        {
            _speed = speed;
            _capacity = capacity;
        }

        public string Move()
        {
            Position += _speed;
            return $"Moving along";

        }

        public string Move(int times)
        {
            Position += times * _speed;
            return $"Moving along {times} times";
        }



    }
}

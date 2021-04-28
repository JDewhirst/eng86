﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariPark
{
    public class Vehicle : IMoveable
    {
        private int _capacity;
        private int _numPassengers;
        public int Speed { get; private set; } = 10;
        public int NumPassengers 
        {
            get { return _numPassengers; }
            set
            {
                _numPassengers = value < 0 ? 0 : value > _capacity ? _capacity : value;
            }
        }
        public int Position { get; protected set; }

        public Vehicle(){}

        public Vehicle(int capacity, int speed = 10 )
        {
            Speed = speed;
            _capacity = capacity;
        }

        public virtual string Move()
        {
            Position += Speed;
            return $"Moving along";

        }

        public virtual string Move(int times)
        {
            Position += times * Speed;
            return $"Moving along {times} times";
        }


        public override string ToString()
        {
            return $"{ base.ToString()} capacity: { _capacity} passengers: { NumPassengers} speed: { Speed} position: { Position}";
        }


    }
}

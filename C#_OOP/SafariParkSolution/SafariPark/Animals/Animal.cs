﻿using System;

namespace SafariPark
{
    public abstract class Animal : IMoveable, IStartleable
    {
        Random rnd = new Random();

        private string _name = "Animal";
        public int Position { get; protected set; }
        public int Speed { get; private set; } = 18;
        public int Startle { get; private set; } = 10;
        public int Aggression { get; private set; } = 2;
        public bool Isstartled { get; protected set; } = false;
        public Animal() { }

        public Animal(int position, int speed, string name = "Animal")
        {
            Speed = speed;
            Position = position;
            _name = name;
        }
        public abstract string Move();

        public abstract string Move(int times);

        public virtual string FightOrFlight(int volume)
        {
            if (rnd.Next(1,20) < Startle)
            {
                Isstartled = true;
                if (rnd.Next(1,20) < Aggression)
                {
                    return $"{_name} is charging!";
                }
                return $"{_name} bolts!";
            }
            else
            {
                return $"{_name} doesn't react";
            }
        }

        public override string ToString()
        {
            return $"{base.ToString()} {_name}";
        }
    }
}

using System;

namespace SafariPark
{
    public abstract class Animal : IMoveable, IStartleable
    {
        Random rnd = new Random();

        private string _name = "Animal";
        public int Position { get; protected set; }
        public int Speed { get; private set; } = 10;
        public int Startle { get; private set; } = 10;
        public int Aggression { get; private set; } = 2;
        public bool Isstartled { get; protected set; } = false;
        public Animal() { }

        public Animal(int position, int speed, int startle = 10, string name = "Animal")
        {
            Speed = speed;
            Position = position;
            Startle = startle;
            _name = name;
        }
        public virtual string Move()
        {
            Position += Speed;
            return $"{_name} is moving along.";
        }

        public virtual string Move(int times)
        {
            Position += Speed * times;
            return $"{_name} is moving along {times} times.";
        }

        public virtual string FightOrFlight(int volume)
        {
            if (rnd.Next(1,20) < Startle + volume)
            {
                Isstartled = true;
                if (rnd.Next(1,20) < Aggression)
                {
                    return $"{_name} is charging!";
                }
                Console.WriteLine(this.Move());
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

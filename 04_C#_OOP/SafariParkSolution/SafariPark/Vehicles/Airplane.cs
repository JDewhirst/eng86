using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariPark
{
    public class Airplane : Vehicle
    {
        public string Airline { get; private set; }
        public int Altitude { get; private set; }

        public Airplane(int capacity) : base(capacity)
        {
        }

        public Airplane( int capacity, int speed, string airline) : base(capacity, speed)
        {
            Airline = airline;
        }

        public void Ascend(int distance)
        {
            Altitude += distance;
        }

        public void Descend(int distance)
        {
            if (Altitude - distance < 0)
            {
                throw new ArgumentException("The plane crashes!");
            }
            else
            {
                Altitude -= distance;
            }
        }

        public override string Move()
        {
            Position += Speed;
            return $"{base.Move()} at an altitude of {Altitude} metres.";
        }

        public override string Move(int times)
        {
            Position += times * Speed;
            return $"{base.Move(times)} at an altitude of {Altitude} metres.";
        }

        public override string ToString()
        {
            return $"Thank you for flying {Airline}: {base.ToString()} altitude: {Altitude}.";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariPark
{
    class Bufallo : Animal
    {
        public Bufallo() { }

        public Bufallo(int position, int speed = 10, int startle = 5, string name = "Bufallo") : base(position, speed, startle, name) { }


    }
}

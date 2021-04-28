using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariPark
{
    public class Hunter : Person, IShootable
    {
        // private string _camera;
        public IShootable Shooter {get; set; }

        public Hunter() { }

        public Hunter(string fName, string lName, IShootable shooter) : base(fName, lName)
        {
            Shooter = shooter;
        }

        public string Shoot()
        {
            return $"{GetFullName()} {Shooter.Shoot()}." ;
        }

        public override string ToString()
        {
            return $"{base.ToString()} Shooter: {Shooter}";
        }
    }
}

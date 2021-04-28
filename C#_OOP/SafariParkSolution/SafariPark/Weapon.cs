using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariPark
{
    public abstract class Weapon : IShootable
    {
        public string _brand;

        public Weapon(string brand)
        {
            _brand = brand;
        }

        public virtual string Shoot() 
        {
            return $"Shot by a {_brand} weapon.";
        }

        public override string ToString()
        {
            return $"{base.ToString()}: {_brand}";
        }

    }

    public class LaserGun : Weapon
    {
        public override string Shoot()
        {
            return $"Zing!! {base.Shoot()}";
        }

        public LaserGun(string brand) : base(brand) { }
    }

    public class WaterPistol : Weapon
    {
        public override string Shoot()
        {
            return $"Splash!! {base.Shoot()}";
        }

        public WaterPistol(string brand) : base(brand) { }
    }


}
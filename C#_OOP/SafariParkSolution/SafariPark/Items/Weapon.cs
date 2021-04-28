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
            return $"{_brand}";
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
            return $"Zing!! with {base.Shoot()}";
        }

        public LaserGun(string brand) : base(brand) { }
    }

    public class WaterPistol : Weapon
    {
        public override string Shoot()
        {
            return $"Splash!! with {base.Shoot()}";
        }

        public WaterPistol(string brand) : base(brand) { }
    }


}
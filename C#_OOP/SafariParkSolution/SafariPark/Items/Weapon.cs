using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariPark
{
    public abstract class Weapon : IShootable
    {
        private string _brand;
        public int Volume { get; set; }

        public Weapon(string brand, int volume)
        {
            _brand = brand;
            Volume = volume;
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
        public LaserGun(string brand, int volume = 10) : base(brand, volume) { }
        public override string Shoot()
        {
            return $"Zing!! with {base.Shoot()}";
        }

    }

    public class WaterPistol : Weapon
    {
        public WaterPistol(string brand, int volume = 5) : base(brand, volume) { }
        public override string Shoot()
        {
            return $"Splash!! with {base.Shoot()}";
        }

        
    }


}
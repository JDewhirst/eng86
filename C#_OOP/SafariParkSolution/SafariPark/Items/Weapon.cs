using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariPark
{
    public abstract class Weapon : IShootable, ILoadable
    {
        private readonly string _brand;
        public int Volume { get; set; }

        public int Capacity { get; set; }

        public int Ammunition { get; set; }

        public Weapon(string brand, int volume, int capacity)
        {
            _brand = brand;
            Volume = volume;
            Capacity = capacity;
            Ammunition = capacity;
        }

        public virtual void Reload()
        {
            Ammunition = Capacity;
        }

        public virtual string Shoot() 
        {
            if (Ammunition > 0) {
                Ammunition--;
                return $"{_brand} shoots!";
            }
            else
            {
                return $"{_brand} is empty!";
            }
            
        }

        public override string ToString()
        {
            return $"{base.ToString()}: {_brand}";
        }

    }

    public class LaserGun : Weapon
    {
        public LaserGun(string brand, int volume = 10, int capacity = 50) : base(brand, volume, capacity) { }
        public override string Shoot()
        {
            return $"Zing! {base.Shoot()}";
        }

    }

    public class WaterPistol : Weapon
    {
        public WaterPistol(string brand, int volume = 5, int capacity = 3) : base(brand, volume, capacity) { }
        public override string Shoot()
        {
            return $"Splash! {base.Shoot()}";
        }

        
    }


}
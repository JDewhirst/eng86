using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariPark
{
    public class Camera : IShootable
    {
        private string _brand;
        public int Volume { get; set; }

        public Camera(string brand, int volume = 2)
        {
            _brand = brand;
            Volume = volume;
        }

        public string Shoot()
        {
            return $"Flash from {_brand} camera.";
        }
    }
}

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

        public Camera(string brand)
        {
            _brand = brand;
        }

        public string Shoot()
        {
            return $"Flash from {_brand} camera.";
        }
    }
}

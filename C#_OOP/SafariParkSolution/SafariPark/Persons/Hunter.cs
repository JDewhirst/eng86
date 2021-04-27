using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariPark
{
    public class Hunter : Person
    {
        private string _camera;

        public Hunter() { }

        public Hunter(string fName, string lName, string camera = "") : base(fName, lName)
        {
            _camera = camera;
        }

        public string Shoot()
        {
            return $"{GetFullName()} has taken a photo with their {_camera}." ;
        }

        public override string ToString()
        {
            return $"{base.ToString()} Camera: {_camera}"; //Name: {GetFullName()} Age: {Age} 
        }
    }
}

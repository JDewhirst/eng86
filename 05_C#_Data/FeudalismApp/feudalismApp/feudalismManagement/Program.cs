using System;
using System.Linq;
using feudalismData;

namespace feudalismManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            var _terrainManager = new TerrainManager();
            var _provinceManager = new ProvinceManager();

            //_terrainManager.CreateTerrain("Plain", 1);
            //_terrainManager.CreateTerrain("Forest", 2);
            //_terrainManager.CreateTerrain("Hill", 2);
            //_terrainManager.CreateTerrain("Mountain", 3);

            //_terrainManager.ListAllTerrain().ForEach(t => Console.WriteLine(t));
            //_provinceManager.CreateProvince(1, 500, "Gisthorpe");
            //_provinceManager.CreateProvince(1, 1000, "Wellbethton");
            //_provinceManager.CreateProvince(3, 20000);
            //_provinceManager.CreateProvince(4, 0, "Big Mountain");

            _provinceManager.ListAllProvinces().ForEach(p => Console.WriteLine(p));
        }
    }
}

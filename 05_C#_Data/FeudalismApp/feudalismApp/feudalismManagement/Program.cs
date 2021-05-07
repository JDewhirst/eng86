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

            //_terrainManager.CreateTerrain("Plain", 1);
            //_terrainManager.CreateTerrain("Forest", 2);
            //_terrainManager.CreateTerrain("Hill", 2);
            //_terrainManager.CreateTerrain("Mountain", 3);

            //using (var db = new FeudalismContext())
            //{
            //    var terrainQuery = db.TerrainDetails.Where(td => td.TravelSpeed == 2);
            //    terrainQuery.ToList().ForEach(tq => Console.WriteLine($"Terrain with speed 2 {tq.TerrainDescription}"));
            //}
            
        }
    }
}

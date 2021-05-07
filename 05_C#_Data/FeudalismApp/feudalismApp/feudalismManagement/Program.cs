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
            var _characterManager = new CharacterManager();
            //_terrainManager.CreateTerrain("Plain", 1);
            //_terrainManager.CreateTerrain("Forest", 2);
            //_terrainManager.CreateTerrain("Hill", 2);
            //_terrainManager.CreateTerrain("Mountain", 3);

            //_terrainManager.ListAllTerrain().ForEach(t => Console.WriteLine(t));

            //_provinceManager.CreateProvince("Plain", 500, "Gisthorpe");
            //_provinceManager.CreateProvince("Plain", 1000, "Wellbethton");
            //_provinceManager.CreateProvince("Forest", 20000);
            //_provinceManager.CreateProvince("Mountain", 0, "Big Mountain");

            //_provinceManager.ListAllProvinces().ForEach(p => Console.WriteLine(p));
            //_terrainManager.UpdateTerrain("forest", 2, " A forest, also referred to as a wood or the woods, is an area with a high density of trees.");

            //_characterManager.CreateCharacter("WdNKE", "William", "de Normandie", "His Grace");
            using (var db = new FeudalismContext())
            {
                var character = db.Characters.Where(c => c.CharacterId == "WdNKE").FirstOrDefault();
                Console.WriteLine(character);
            }
        }
    }
}

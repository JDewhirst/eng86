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
            //_terrainManager.CreateTerrain("Plain", 1, "A sea of verdant grass extended from the peaks in the east down to the lapping azure waters of the Caspain");
            //_terrainManager.CreateTerrain("Forest", 2);
            //_terrainManager.CreateTerrain("Hill", 2);
            //_terrainManager.CreateTerrain("Mountain", 3);

            //_terrainManager.ListAllTerrain().ForEach(t => Console.WriteLine(t));

            //_provinceManager.CreateProvince("Plain", 500, "Gisthorpe");
            //_provinceManager.CreateProvince("Plain", 1000, "Wellbethton");
            //_provinceManager.CreateProvince("Plain", 1500, "Westberry");
            //_provinceManager.CreateProvince("Forest", 50, "Kingswood");
            //_provinceManager.CreateProvince("Hill", 600, "Leadsbury");
            //_provinceManager.CreateProvince("Hill", 0);
            //_provinceManager.CreateProvince("Mountain", 0, "Kero Fin");

            //_provinceManager.ListAllProvinces().ForEach(p => Console.WriteLine(p));

            //_characterManager.CreateCharacter("WdNKE", "William", "de Normandie", "His Highness",3);
            //_characterManager.CreateCharacter("JKDY", "John", "Kristothenum", "His Grace", 2, "WdNKE");
            //_characterManager.CreateCharacter("RdNDL", "Richard", "de Normandie", "His Grace", 4, "WdNKE");
            //_characterManager.CreateCharacter("BSBG", "Boris", "Sakinov", "His Lordship", 1, "JKDY");
            _characterManager.CreateCharacter("JLk", "James", "Lancaster", "Sir", 0, "JKDY");
            _characterManager.CreateCharacter("LVk", "Lousie", "Vitillean", "Sir", 0);

            //_characterManager.ListAllCharacters().ForEach(c => Console.WriteLine(c));
           

            var directSubordinatesOfKingWill = _characterManager.ListCharacterDirectSubordinates("WdNKE");
            var directSuborddinatesOfDukeJohn = _characterManager.ListCharacterDirectSubordinates("JKDY");
            Console.WriteLine($"Subordinates of King William");
            directSubordinatesOfKingWill.ForEach(s => Console.WriteLine($"      {s}"));
            Console.WriteLine($"Subordinates of Duke John");
            directSuborddinatesOfDukeJohn.ForEach(s => Console.WriteLine($"     {s}"));

            Console.WriteLine("Unlanded characters");
            var unlanded = _characterManager.ListUnlandedCharacters();
            unlanded.ForEach(ul => Console.WriteLine($"     {ul}"));
        }

    }
}

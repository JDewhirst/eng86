using NUnit.Framework;
using feudalismData;
using feudalismManagement;
using System.Linq;

namespace FeudalismTests
{
    public class Tests
    {
        TerrainManager _terrainManager;
        [SetUp]
        public void Setup()
        {
            _terrainManager = new TerrainManager();
            // remove test entry in DB if present
            using (var db = new FeudalismContext())
            {
                var selectedTerrain =
                    from td in db.TerrainDetails
                    where td.TerrainDescription == "Lava flow"
                    select td;

                db.TerrainDetails.RemoveRange(selectedTerrain);
                db.SaveChanges();
            }
        }

        [Test]
        public void WhenANewTerrainIsAdded_TheNumberOfTerrainsIncreasesBy1()
        {
            using (var db = new FeudalismContext())
            {
                var numTerrains = db.TerrainDetails.Count();
                _terrainManager.CreateTerrain("Lava flow", 10);
                var result = db.TerrainDetails.Count();
                Assert.AreEqual(1, result - numTerrains);
            }
        }

        [Test]
        public void WhenATerrainIsRemoved_ItIsNoLongerInTheDatabase()
        {
            using (var db = new FeudalismContext())
            {
                var newTerrain = new TerrainDetail() {TerrainDescription = "Lava Flow", TravelSpeed = 10 };
                db.TerrainDetails.Add(newTerrain);
                db.SaveChanges();
                var terrainID = db.TerrainDetails.Where(td => td.TerrainDescription == "Lava Flow").FirstOrDefault().TerrainDetailId;
                _terrainManager.DeleteTerrain(terrainID);
                var LAVACount = db.TerrainDetails.Where(td => td.TerrainDescription == "Lava Flow").Count();
                Assert.AreEqual(0, LAVACount);
            }
        }

        [TearDown]
        public void TearDown()
        {
            _terrainManager = new TerrainManager();
            // remove test entry in DB if present
            using (var db = new FeudalismContext())
            {
                var selectedTerrain =
                    from td in db.TerrainDetails
                    where td.TerrainDescription == "Lava flow"
                    select td;

                db.TerrainDetails.RemoveRange(selectedTerrain);
                db.SaveChanges();
            }
        }
    }
}
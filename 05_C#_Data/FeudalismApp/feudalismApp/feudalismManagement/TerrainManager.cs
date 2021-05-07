using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using feudalismData;

namespace feudalismManagement
{
    public class TerrainManager
    {

        public TerrainDetail SelectedTerrain { get; set; }

        public void CreateTerrain(string terrainDetailId, int travelSpeed, string terrainDescription = "")
        {
            var newTerrain = new TerrainDetail() {TerrainDetailId= terrainDetailId, TerrainDescription = terrainDescription, TravelSpeed = travelSpeed };
            using (var db = new FeudalismContext())
            {
                db.TerrainDetails.Add(newTerrain);
                db.SaveChanges();
            }
        }

        public void DeleteTerrain(string terrainId)
        {
            using (var db = new FeudalismContext())
            {
                SelectedTerrain = db.TerrainDetails.Where(td => td.TerrainDetailId == terrainId).FirstOrDefault();
                db.TerrainDetails.RemoveRange(SelectedTerrain);
                db.SaveChanges();
            }
        }

        public void UpdateTerrain(string terrainId, int travelSpeed, string terrainDescription)
        {
            using (var db = new FeudalismContext())
            {
                SelectedTerrain = db.TerrainDetails.Where(td => td.TerrainDetailId == terrainId).FirstOrDefault();
                SelectedTerrain.TerrainDescription = terrainDescription;
                SelectedTerrain.TravelSpeed = travelSpeed;
                db.SaveChanges();
            }
        }

        public List<TerrainDetail> ListAllTerrain()
        {
            using (var db = new FeudalismContext())
            {
                return db.TerrainDetails.ToList();
            }
        }

    }
}

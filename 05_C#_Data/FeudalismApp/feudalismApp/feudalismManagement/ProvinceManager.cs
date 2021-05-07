using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using feudalismData;

namespace feudalismManagement
{
    public class ProvinceManager
    {
        public Province SelectedProvince { get; set; }

        public void CreateProvince(int terrainId, int population, string provinceName = null)
        {
            var newProvince = new Province() { TerrainId = terrainId, ProvinceName = provinceName, Population = population };
            using (var db = new FeudalismContext())
            {
                db.Provinces.Add(newProvince);
                db.SaveChanges();
            }
        }

        public void DeleteProvince(int ProvinceId)
        {
            using (var db = new FeudalismContext())
            {
                SelectedProvince = db.Provinces.Where(p => p.ProvinceId == ProvinceId).FirstOrDefault();
                db.Provinces.RemoveRange(SelectedProvince);
                db.SaveChanges();
            }
        }

        public void UpdateProvince(int provinceId, int terrainId, string provinceName, int population)
        {
            using (var db = new FeudalismContext())
            {
                SelectedProvince = db.Provinces.Where(p => p.ProvinceId == provinceId).FirstOrDefault();
                SelectedProvince.TerrainId = terrainId;
                SelectedProvince.ProvinceName = provinceName;
                SelectedProvince.Population = population;
                db.SaveChanges();
            }
        }

        public List<Province>ListAllProvinces()
        {
            using (var db = new FeudalismContext())
            {
                return db.Provinces.ToList();
            }
        }

    }
}

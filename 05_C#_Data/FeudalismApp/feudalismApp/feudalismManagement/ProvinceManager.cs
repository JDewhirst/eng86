﻿using System;
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

        public void CreateProvince(string terrainId, int population, string provinceName = null)
        {
            var newProvince = new Province() { TerrainDetailId = terrainId, ProvinceName = provinceName, Population = population };
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

        public void UpdateProvince(int provinceId, string terrainId, string provinceName, int population)
        {
            using (var db = new FeudalismContext())
            {
                SelectedProvince = db.Provinces.Where(p => p.ProvinceId == provinceId).FirstOrDefault();
                SelectedProvince.TerrainDetailId = terrainId;
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

        public List<Province>ListPopulatedProvinces()
        {
            using (var db = new FeudalismContext())
            {
                return db.Provinces.Where(p => p.Population != 0).ToList();
            }
        }

        public List<Province>ListUninhabitedProvinces()
        {
            using (var db = new FeudalismContext())
            {
                return db.Provinces.Where(p => p.Population == 0).ToList();
            }
        }

        public List<Province>ListProvinceOwner()
        {
            using (var db = new FeudalismContext())
            {
                return db.Provinces.ToList();
            }
        }

    }
}

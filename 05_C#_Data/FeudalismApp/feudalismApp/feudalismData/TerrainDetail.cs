﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace feudalismData
{
    public partial class TerrainDetail
    {
        public TerrainDetail()
        {
            Provinces = new HashSet<Province>();
        }
        public string TerrainDetailId { get; set; }
        public string TerrainDescription { get; set; }
        public int TravelSpeed { get; set; }


        public virtual ICollection<Province> Provinces { get; set; }

        public override string ToString()
        {
            return $"{TerrainDetailId} - {TravelSpeed} {(TravelSpeed > 1 ? "hexes" : "hex")} per watch - {TerrainDescription}";
        }
    }
}

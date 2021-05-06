namespace feudalismData
{
    public partial class Province
    {
        public Province()
        {
        }

        public int ProvinceID { get; set; }
        public int TerrainID { get; set; }
        public string ProvinceName { get; set; }
        public int Population { get; set; }

        public virtual TerrainDetail TerrainDetails { get; set; }
        public virtual Character Characters { get; set; }

    }
}
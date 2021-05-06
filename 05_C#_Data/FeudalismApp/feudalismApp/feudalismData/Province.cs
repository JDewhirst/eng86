namespace feudalismData
{
    public partial class Province
    {
        public Province()
        {
        }

        public int ProvinceId { get; set; }
        public int TerrainId { get; set; }
        public string ProvinceName { get; set; }
        public int Population { get; set; }

        public virtual TerrainDetail TerrainDetails { get; set; }
        public virtual Character Characters { get; set; }

    }
}
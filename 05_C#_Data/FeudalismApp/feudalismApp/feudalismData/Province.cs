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

        public int CharacterID { get; set }

        public virtual TerrainDetail TerrainDetail { get; set; }
        public virtual Character Character { get; set; }

        public override string ToString()
        {
            return $"{ProvinceId}: {(ProvinceName is null ? "Un-named" : ProvinceName)} Population {Population} ";
        }
    }
}
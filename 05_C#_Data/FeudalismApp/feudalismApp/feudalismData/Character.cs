using System.Collections.Generic;

namespace feudalismData
{
    public partial class Character
    {
        public Character()
        {
            Provinces = new HashSet<Province>();
        }

        public string CharacterId { get; set; }
        public string CharacterName { get; set; }
        public string Dynasty { get; set; }
        public string CourtesyTitle { get; set; }
        public int ProvinceId { get; set; }
        public virtual ICollection<Province> Provinces { get; set; }

    }
}
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace feudalismData
{
    public partial class Character
    {
        public Character()
        {
            Provinces = new HashSet<Province>();
            Subordinates = new HashSet<Character>();
        }

        public string CharacterId { get; set; }
        public string CharacterName { get; set; }
        public string Dynasty { get; set; }
        public string CourtesyTitle { get; set; }
        public int ProvinceId { get; set; }
        public virtual ICollection<Province> Provinces { get; set; }

        [ForeignKey("OverlordId")]
        public string OverlordId { get; set; }
        public virtual Character Overlord {get; set; }
        public virtual ICollection<Character> Subordinates { get; set; }



        public override string ToString()
        {
            return $"{CourtesyTitle} {CharacterName} {Dynasty}";
        }

    }
}
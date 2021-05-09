using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using feudalismData;

namespace feudalismManagement
{
    public class CharacterManager
    {
        public Character SelectedCharacter { get; set; }

        public void SetSelectedCharacter(object selectedCharacter)
        {
            SelectedCharacter = (Character)selectedCharacter;
        }
        public void CreateCharacter(string charId, string charName, string dynasty, string courtseyTitle, int? provinceId = null, string? overlordId = null )
        {
            var newCharacter = new Character()
            {
                CharacterId = charId,
                CharacterName = charName,
                Dynasty = dynasty,
                CourtesyTitle = courtseyTitle
            };
            if (provinceId is not null) { newCharacter.ProvinceId = (int)provinceId; }
            if (overlordId is not null) { newCharacter.OverlordId = (string)overlordId; }

                using (var db = new FeudalismContext())
            {
                db.Characters.Add(newCharacter);
                db.SaveChanges();
            }
        }

        public void DeleteCharacter(string charId)
        {
            using (var db = new FeudalismContext())
            {
                SelectedCharacter = db.Characters.Where(c => c.CharacterId == charId).FirstOrDefault();
                db.Characters.RemoveRange(SelectedCharacter);
                db.SaveChanges();
            }
        }
        public List<Character> ListAllCharacters()
        {
            using (var db = new FeudalismContext())
            {
                return db.Characters.ToList();
            }
        }

        public List<Character> ListUnlandedCharacters()
        {
            using (var db = new FeudalismContext())
            {
                return db.Characters.Where(c => c.ProvinceId == 0).ToList();
            }
        }

        public List<Character> ListLandedCharacters()
        {
            using (var db = new FeudalismContext())
            {
                return db.Characters.Where(c => c.ProvinceId != 0).ToList();
            }
        }

        //public List<Character> ListLandedIndependentCharacters()
        //{
        //    using (var db = new FeudalismContext())
        //    {
        //        return db.Characters.Where(c => c.ProvinceId == !0 && c.LordId != null).ToList();
        //    }
        //}

        public List<Character> ListCharacterDirectSubordinates(string charId)
        {
            using (var db = new FeudalismContext())
            {
                return db.Characters.Where(c => c.OverlordId == charId).ToList();
            }
        }


}
}

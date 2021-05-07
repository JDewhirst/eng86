using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using feudalismData;

namespace feudalismManagement
{
    class CharacterManager
    {
        public Character SelectedCharacter { get; set; }

        public void CreateCharacter(string charId, string charName, string dynasty, string courtseyTitle, int? provinceId = null)
        {
            var newCharacter = new Character()
            {
                CharacterId = charId,
                CharacterName = charName,
                Dynasty = dynasty,
                CourtesyTitle = courtseyTitle
            };
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
    }
}

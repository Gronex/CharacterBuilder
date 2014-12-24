using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterModel
{
    public class Character
    {
        public int Str { get; set; }
        public int Sta { get; set; }
        public int Dex { get; set; }
        public int Int { get; set; }
        public int Wis { get; set; }
        public int Cha { get; set; }

        public Character()
        {
            Str = 0;
            Sta = 0;
            Dex = 0;
            Int = 0;
            Wis = 0;
            Cha = 0;
        }

        public Character(int strength, int stamina, int dexterity, int intelect, int wisdom, int charisma)
        {
            Str = strength;
            Sta = stamina;
            Dex = dexterity;
            Int = intelect;
            Wis = wisdom;
            Cha = charisma;
        }
    }
}

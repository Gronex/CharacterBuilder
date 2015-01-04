using DiceRoller;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterBuilder.Commands
{
    class DiceCommand
    {
        public int Stat{get; private set;}
        public void StatRoll()
        {
            var stats = Roller.Roll(4, 6);

            stats.Sort();
            stats.RemoveAt(0);
            Stat = stats.Sum();
            Debug.WriteLine("Roll:" + Stat);
        }
    }
}

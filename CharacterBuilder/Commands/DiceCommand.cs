using DiceRoller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterBuilder.Commands
{
    class DiceCommand
    {
        public void StatRoll()
        {
            var stats = Roller.Roll(4, 6);

            stats.Sort();
            stats.RemoveAt(3);
            int stat = stats.Sum();
            Console.WriteLine("Roll:" + stat);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller
{
    public class Roller
    {
        public static int AddRoll(int numOfDice, int sides)
        {
            var die = new Die(sides);
            var result = 0;
            for (int i = 0; i < numOfDice; i++)
            {
                result += die.Roll();
            }
            return result;
        }
    }
}

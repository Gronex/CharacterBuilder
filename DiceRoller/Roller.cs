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

        public static int Roll(int sides)
        {
            var die = new Die(sides);
            return die.Roll();
        }

        public static List<int> Roll(int numOfDice, int sides)
        {
            var die = new Die(sides);
            var results = new List<int>(numOfDice);

            for (int i = 0; i < numOfDice; i++)
            {
                results.Add(die.Roll());
            }
            return results;
        }
    }
}

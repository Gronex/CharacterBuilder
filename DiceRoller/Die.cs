using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller
{
    public class Die
    {
        //TODO: Fix so two dice don't get the same seed if created right after one another
        private Random rand = new Random();
        private int sides;

        public Die(int sides)
        {
            this.sides = sides;
        }

        public int Roll()
        {
            //Roll the die and get a number greater or equal to 1 and less than sides +1
            return rand.Next(1, sides + 1);
        }
    }
}

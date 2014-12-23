using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DiceRoller;

namespace CharacterBuilderTests
{
    [TestClass]
    public class DiceRollerUnitTests
    {
        [TestMethod]
        public void OneDieBoundsTest()
        {
            for(int i = 0; i < 10000; i++)
            {
                var result = Roller.AddRoll(1, 6);
                Assert.IsTrue(result > 0 && result <= 6);
            }
        }

        [TestMethod]
        public void TwoDieBoundsTest()
        {
            for (int i = 0; i < 10000; i++)
            {
                var result = Roller.AddRoll(2, 6);
                Assert.IsTrue(result > 1 && result <= 12);
            }
        }

        /// <summary>
        /// Test to see if two seperate dice can get two different results.
        /// Statisticly this test can fail, even though the result is correct,
        /// but this is so unlikely that it is not considered
        /// </summary>
        [TestMethod]
        public void TwoDieNotEqualTest()
        {
            bool equal = true;

            for (int i = 0; i < 10000; i++)
            {
                //Console.WriteLine(die.Roll() + "; " + die.Roll());
                if (Roller.AddRoll(1, 6) != Roller.AddRoll(1,6)) equal = false;
            }

            Assert.IsFalse(equal);
        }
    }
}

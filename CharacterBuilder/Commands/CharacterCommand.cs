using CharacterModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterBuilder.Commands
{
    class CharacterCommand
    {

        public void CreateNew(Character character)
        {
            character = new Character();
            Console.WriteLine("New Character");
            //TODO: Open new window
        }

        public void LoadCharacter()
        {
            Console.WriteLine("Open Character");
            //TODO: Loading logic
        }
    }
}

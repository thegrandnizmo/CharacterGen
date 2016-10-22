using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGen
{
    class Program
    {
        static void Main(string[] args)
        {
            Character PlayerCharacter = new Character(); //Instantiate new character
            
            int[] PlayerCharacterStats = new int[6]; //Create character stats array

            Console.WriteLine("Please enter a character name");
            PlayerCharacter.Name = Console.ReadLine();

            Console.WriteLine("Please enter the following stats:");
            Console.WriteLine("Strength:");
            PlayerCharacterStats[0] = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Dexterity:");
            PlayerCharacterStats[1] = int.Parse(Console.ReadLine());

            Console.WriteLine("Constitution:");
            PlayerCharacterStats[2] = int.Parse(Console.ReadLine());

            Console.WriteLine("Intelligence:");
            PlayerCharacterStats[3] = int.Parse(Console.ReadLine());

            Console.WriteLine("Wisdom:");
            PlayerCharacterStats[4] = int.Parse(Console.ReadLine());

            Console.WriteLine("Charisma:");
            PlayerCharacterStats[5] = int.Parse(Console.ReadLine());

            //Pass character stats array to Character class for storage
            PlayerCharacter.UpdateStats(PlayerCharacterStats);
        }
    }
}

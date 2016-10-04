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
            //Instantiate new character
            Character PlayerCharacter = new Character();

            //Create character stats array
            double[] PlayerCharacterStats = new double[6];

            Console.WriteLine("Please entera character name");
            String CharacterName = Console.ReadLine();

            Console.WriteLine("Strength:");
            PlayerCharacterStats[0] = double.Parse(Console.ReadLine());

            Console.WriteLine("Dexterity:");
            PlayerCharacterStats[1] = double.Parse(Console.ReadLine());

            Console.WriteLine("Constitution:");
            PlayerCharacterStats[2] = double.Parse(Console.ReadLine());

            Console.WriteLine("Intelligence:");
            PlayerCharacterStats[3] = double.Parse(Console.ReadLine());

            Console.WriteLine("Wisdom:");
            PlayerCharacterStats[4] = double.Parse(Console.ReadLine());

            Console.WriteLine("Charisma:");
            PlayerCharacterStats[5] = double.Parse(Console.ReadLine());

            //Pass character stats array to Character class for storage
            PlayerCharacter.UpdateStats(PlayerCharacterStats);
        }
    }
}

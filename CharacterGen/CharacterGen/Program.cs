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
            //Create new character
            Character Char1 = new Character();

            //Create character stats array
            double[] Char1Stats = new double[6];

            Console.WriteLine("Please entera character name");
            String CharacterName = Console.ReadLine();

            Console.WriteLine("Strength:");
            Char1Stats[0] = double.Parse(Console.ReadLine());

            Console.WriteLine("Dexterity:");
            Char1Stats[1] = double.Parse(Console.ReadLine());

            Console.WriteLine("Constitution:");
            Char1Stats[2] = double.Parse(Console.ReadLine());

            Console.WriteLine("Intelligence:");
            Char1Stats[3] = double.Parse(Console.ReadLine());

            Console.WriteLine("Wisdom:");
            Char1Stats[4] = double.Parse(Console.ReadLine());

            Console.WriteLine("Charisma:");
            Char1Stats[5] = double.Parse(Console.ReadLine());

            //Pass character stats array to Character class for storage
            Char1.UpdateStats(Char1Stats);

            Console.WriteLine(Char1.StrMod);
        }
    }
}

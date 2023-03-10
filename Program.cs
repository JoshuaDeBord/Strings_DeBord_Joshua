 using System;

namespace Strings_DeBord_Joshua
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a character");
            char myChar = Console.ReadKey().KeyChar;

            bool isLetter = Char.IsLetter(myChar);

            Console.WriteLine($"\n {myChar} is a letter: {isLetter}.");
        } 
    }
}

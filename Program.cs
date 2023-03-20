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

            Console.WriteLine("Why do you like video games?");
            string videoGameQuestion = Console.ReadLine();

            Console.WriteLine("Please input a word.");
            string word = Console.ReadLine();

            bool isIn = videoGameQuestion.Contains(word);

            Console.WriteLine($"{word} exists in {videoGameQuestion}, {isIn}!");

        } 
    }
}

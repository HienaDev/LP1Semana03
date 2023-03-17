using System;

namespace ChangeString
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user for a string
            Console.WriteLine("Give me a string!");
            string phrase = Console.ReadLine();

            // Ask the user for a character
            Console.WriteLine("Give me a character!");
            char character = char.Parse(Console.ReadLine());

            // For each character in the string, compared it with
            // the user's character, if it's different from that character,
            // print it
            foreach(char c in phrase)
                if (c != character)
                    Console.Write(c);
        }
    }
}

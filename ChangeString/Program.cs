using System;

namespace ChangeString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a string!");

            string phrase = Console.ReadLine();

            Console.WriteLine("Give me a character!");

            char character = char.Parse(Console.ReadLine());

            foreach(char c in phrase)
            {
                if (c != character)
                {
                    Console.WriteLine(c);
                }
            }
        }
    }
}

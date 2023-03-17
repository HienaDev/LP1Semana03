using System;
using PerksToUse;

namespace PlayerPerks
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initalized perks variable to save user's perks
            perks myPerks = 0;
            
            // Check if there are any arguments passed to the program
            // if not, skips the for loop
            if (args.Length > 0)
                // Goes through each character of the string args[0]
                foreach (char c in args[0])
                {
                    if ( c == 'w')
                    {
                        myPerks ^= perks.WaterBreathing;
                    }
                    else if ( c == 'a')
                    {
                        myPerks ^= perks.AutoHeal;
                    }
                    else if ( c == 's')
                    {
                        myPerks ^= perks.Stealth;
                    }
                    else if ( c == 'd')
                    {
                        myPerks ^= perks.DoubleJump;
                    }
                    else
                    {
                        Console.WriteLine("Unknown perk!");
                        return;
                    }
                }

            if ((int) myPerks == 0)
                Console.WriteLine("No perks at all!");
            else
                Console.WriteLine(myPerks);

            if ((int) (myPerks & (perks.Stealth | perks.DoubleJump)) == 10)
                Console.WriteLine("Silent jumper!");

            if ((int) (myPerks & (perks.AutoHeal)) == 0)
                Console.WriteLine("Not gonna make it!");
            
            

        }
    }
}

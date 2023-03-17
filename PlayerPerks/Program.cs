using System;
// Using the enum from the namespace PerksToUse
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
                    // Checks if the character is wasd, and if it is
                    // toggles the specific perk
                    // If its none of those, stops the program and 
                    // pritns Unkown perk!
                    if ( c == 'w')
                        myPerks ^= perks.WaterBreathing;
                
                    else if ( c == 'a')
                        myPerks ^= perks.AutoHeal;
                    
                    else if ( c == 's')
                        myPerks ^= perks.Stealth;
                    
                    else if ( c == 'd')
                        myPerks ^= perks.DoubleJump;
                    
                    else
                    {
                        Console.WriteLine("Unknown perk!");
                        return;
                    }
                }

            // If the user has no perks selected
            if ((int) myPerks == 0)
                Console.WriteLine("No perks at all!");
            // If the user has perks, they are printed
            else
                Console.WriteLine(myPerks);

            // If the user has stealth and double jump
            if ((int) (myPerks & (perks.Stealth | perks.DoubleJump)) == 10)
                Console.WriteLine("Silent jumper!");

            // If the user doesn't have autoheal
            if ((int) (myPerks & (perks.AutoHeal)) == 0)
                Console.WriteLine("Not gonna make it!");
        }
    }
}

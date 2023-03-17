using System;
using PerksToUse;

namespace PlayerPerks
{
    class Program
    {
        static void Main(string[] args)
        {
            perks myPerks;

            myPerks = 0;

            foreach (char c in args[0])
            {
                if ( c == "w")
                {
                    myPerks ^= perks.WaterBreathing;
                }
                else if ( c == "a")
                {
                    myPerks ^= perks.AutoHeal;
                }
                else if ( c == "s")
                {
                    myPerks ^= perks.Stealth;
                }
                else if ( c == "d")
                {
                    myPerks ^= perks.DoubleJump;
                }
                else
                {
                    Console.WriteLine("Unknown perk!");
                    return;
                }
            }

            if (myPerks == 0)
            {
                Console.WriteLine("No perks at all!");
            }
            else 
            {
                if ((myPerks & (perks.Stealth | perks.DoubleJump)) == 10)
                {
                    Console.WriteLine("Silent jumper!");
                }
            }

        }
    }
}

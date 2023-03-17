using System;
using playerAchievementTable;

namespace PlayerAchievements
{
    class Program
    {
        static void Main(string[] args)
        {
            // Asks the user how many players and receives that input
            Console.WriteLine("How many players are there?");
            int n = int.Parse(Console.ReadLine());

            // Initalizing variables to save achievements for each player
            achievements achievementsTable;
            achievements[] player_list = new achievements[n];

            // Save answer if the player has an achievement or not
            string answer;

            // Go through the player list and ask if each player 
            // has each achievement
            for (int i = 0; i < n; i++)
            {
                // Reset the value back for each player
                achievementsTable = 0;

                Console.WriteLine($"\nAchievements for player {i + 1}:");
                Console.WriteLine
                ("Has the player defeated the optional boss? (Y/N) \n");
                answer = Console.ReadLine().ToUpper();
                if (answer == "Y")
                    achievementsTable ^= achievements.DefeatOptionalBoss;

                Console.WriteLine
                ("Has the player found the hidden level? (Y/N) \n");
                answer = Console.ReadLine().ToUpper();
                if (answer == "Y")
                    achievementsTable ^= achievements.FindHiddenLevel;

                Console.WriteLine
                ("Has the player finished the game? (Y/N) \n");
                answer = Console.ReadLine().ToUpper();
                if (answer == "Y")
                    achievementsTable ^= achievements.FinishGame;

                // Save achievements in the player's slot
                player_list[i] = achievementsTable;
            }

            // Print a new line on cmd
            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                // Prints player's name
                Console.WriteLine($"Player {i + 1} achievements:");
                
                // Checks if the player has any achievements, and if he does
                // prints which achievement he has
                if ((int)player_list[i] > 0)
                {
                    Console.WriteLine(player_list[i]);

                    // If the player has every achievement
                    if ((int)player_list[i] == 7)
                        Console.WriteLine("Completionist!");

                    // Print a new line on cmd
                    Console.WriteLine();
                }
            }
        }

        
    }
}

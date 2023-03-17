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

            achievements achievementsTable;

            achievements[] player_list = new achievements[n];

            string answer;

            for (int i = 0; i < n; i++)
            {
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

                player_list[i] = achievementsTable;
            }

            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {

                Console.WriteLine($"Player {i + 1} achievements:");
                
                if ((int)player_list[i] > 0)
                {
                    Console.WriteLine(player_list[i]);
                    if ((int)player_list[i] == 7)
                        Console.WriteLine("Completionist!");

                    Console.WriteLine();
                }
            }
        }

        
    }
}

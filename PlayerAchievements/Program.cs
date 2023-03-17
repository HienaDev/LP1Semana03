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

            int[] player_list = new int[n];

            string answer;

            for (int i = 0; i < n; i++)
            {
                achievementsTable = 0;
                Console.WriteLine($"Achievements for player {i}:");
                Console.WriteLine
                ("Has the player defeated the optional boss? (Y/N)");
                answer = Console.ReadLine().ToUpper();
                if (answer == "Y")
                    achievementsTable ^= achievements.DefeatOptionalBoss;

                Console.WriteLine
                ("Has the player found the hidden level? (Y/N)");
                answer = Console.ReadLine().ToUpper();
                if (answer == "Y")
                    achievementsTable ^= achievements.FindHiddenLevel;

                Console.WriteLine
                ("Has the player finished the game? (Y/N)");
                answer = Console.ReadLine().ToUpper();
                if (answer == "Y")
                    achievementsTable ^= achievements.FinishGame;
            }

        }

        
    }
}

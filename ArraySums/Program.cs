using System;

namespace ArraySums
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask user for horizontal size
            Console.WriteLine("What's the horizontal size? ");
            int horizontal_size = int.Parse(Console.ReadLine());

            // Ask user for vertical size
            Console.WriteLine("What's the vertical size? ");
            int vertical_size = int.Parse(Console.ReadLine());

            float sum_of_line = 0;

            // Initalize matrix of real numbers with the user's size
            float[,] matrix_reals = new float [vertical_size, horizontal_size];

            float[] sum_of_columns = new float[horizontal_size];

            // Print a new line on cmd
            Console.WriteLine();

            // Go through each column
            for (int i = 0; i < matrix_reals.GetLength(0); i++)
            {   
                // Go through each line
                for (int j = 0; j < matrix_reals.GetLength(1); j++)
                {   
                    Console.Write
                    ($"What's the value for the ({i + 1}, {j + 1}) position?");

                    matrix_reals[i, j] = float.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }

            // Go through each column
            for (int i = 0; i < matrix_reals.GetLength(0); i++)
            {
                sum_of_line = 0;
                // Go through each line
                for (int j = 0; j < matrix_reals.GetLength(1); j++)
                {
                    sum_of_line += matrix_reals[i, j];
                    sum_of_columns[j] += matrix_reals[i, j];
                }
                Console.WriteLine($"The sum of line {i + 1} is {sum_of_line}");
                Console.WriteLine();
            }

            for (int i = 0; i < sum_of_columns.Length; i++)
            {
                Console.WriteLine($"The sum of column {i + 1} is {sum_of_columns[i]}");
            }
        }
    }
}

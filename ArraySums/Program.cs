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

            // Initalize the variable to save the sum of lines
            float sum_of_line = 0;

            // Initalize matrix of real numbers with the user's size
            float[,] matrix_reals = new float [vertical_size, horizontal_size];

            // Initalize array to save the value of every column
            float[] sum_of_columns = new float[horizontal_size];

            // Print a new line on cmd
            Console.WriteLine();

            // Go through each column
            for (int i = 0; i < matrix_reals.GetLength(0); i++)
            {   
                // Go through each line
                for (int j = 0; j < matrix_reals.GetLength(1); j++)
                {   
                    // Ask the user for the value of each cell
                    Console.Write
                    ($"What's the value for the ({i + 1}, {j + 1}) position?");
                    matrix_reals[i, j] = float.Parse(Console.ReadLine());
                }
                // Print a new line on cmd
                Console.WriteLine();
            }

            // Go through each column
            for (int i = 0; i < matrix_reals.GetLength(0); i++)
            {
                // Reset value of the sum of a line everytime we change line
                sum_of_line = 0;

                // Go through each line
                for (int j = 0; j < matrix_reals.GetLength(1); j++)
                {
                    // Add the value of every cell in line i to sum_of_line
                    sum_of_line += matrix_reals[i, j];

                    // Add the value of each number in column j to an 
                    // array where the position j is also the position of the
                    // sum of that column in the array sum_of_columns
                    sum_of_columns[j] += matrix_reals[i, j];
                }
                // Print the sum of line i
                Console.WriteLine($"The sum of line {i + 1} is {sum_of_line}");
                // Print a new line on cmd
                Console.WriteLine();
            }

            // Prints the sum of every column in sum_of_columns
            for (int i = 0; i < sum_of_columns.Length; i++)
            {
                Console.WriteLine($"The sum of column {i + 1} is {sum_of_columns[i]}");
            }
        }
    }
}

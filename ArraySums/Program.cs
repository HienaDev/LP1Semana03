using System;

namespace ArraySums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o tamanho horizontal?");

            int horizontal_size = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual o tamanho vertical?");

            int vertical_size = int.Parse(Console.ReadLine());

            float[,] matrix_reals = new float [horizontal_size, vertical_size];

            
        }
    }
}

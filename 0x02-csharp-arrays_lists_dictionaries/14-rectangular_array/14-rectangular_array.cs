using System;

namespace _14_rectangular_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[5, 5];
            matrix[2,2] = 1;
            for (int i = 0; i<5; i++)
            {
                for (int j = 0; j<5; j++)
                {
                    Console.Write("{0}", matrix[i,j]);
                    if (j == 4)
                        Console.WriteLine();
                    else
                        Console.Write(" ");
                }
            }
        }
    }
}

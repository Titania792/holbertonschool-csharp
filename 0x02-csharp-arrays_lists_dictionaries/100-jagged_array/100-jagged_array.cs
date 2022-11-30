using System;

namespace _100_jagged_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[] { 0, 1, 2, 3 };
            jaggedArray[1] = new int[] { 0, 1, 2, 3, 4, 5, 6 };
            jaggedArray[2] = new int[] { 0, 1 };

            for (int row = 0; row < jaggedArray.Length; row++)
            {
                for (int item = 0; item < jaggedArray[row].Length; item++)
                {
                    Console.Write(jaggedArray[row][item]);
                    if (item != jaggedArray[row].Length-1)
                        Console.Write(' ');
                }
                Console.WriteLine();
            } 
        }
    }
}

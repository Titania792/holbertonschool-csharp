using System;

class Array
{
    public static int[] CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        else if (size == 0)
        {
            int[] array = new int[] {};
            Console.WriteLine();
            return array;
        }
        else
        {
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = i;
            }
            foreach (var item in array)
            {
                Console.Write("{0} ", item);
            }
            Console.Write("\n");
            return array;
        }
    }
}

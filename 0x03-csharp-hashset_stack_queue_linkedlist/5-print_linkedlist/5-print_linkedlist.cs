using System;
using System.Collections.Generic;
using System.Linq;

class LList
{
    public static LinkedList<int> CreatePrint(int size)
    {
        List<int> numbers = new List<int>();
        if (size < 0)
        {
            LinkedList<int> empty = new LinkedList<int>();
            return empty;
        }
        for (int i = 0; i < size; i++)
        {
            numbers.Add(i);
            Console.WriteLine(i);
        }
        LinkedList<int> newLlist = new LinkedList<int>(numbers);
        return newLlist;
    }
}

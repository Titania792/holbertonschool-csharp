using System;
using System.Linq;
using System.Collections.Generic;

class Dictionary
{
    public static void PrintSorted(Dictionary<string, string> myDict)
    {
        // access the Keys property. Then use the ToList extension method and the Sort instance method.
        var list = myDict.Keys.ToList();
        list.Sort();
        foreach (var key in list)
        {
            Console.WriteLine("{0}: {1}", key, myDict[key]);
        }
    }
}


using System;
using System.Collections.Generic;

class Dictionary
{
    public static Dictionary<string, int> MultiplyBy2(Dictionary<string, int> myDict)
    {
        var newDict = new Dictionary<string, int>();
        foreach (KeyValuePair<string, int> pair in myDict)
        {
            var val = pair.Value * 2;
            newDict.Add(pair.Key, val);
        }
        return newDict;
    }
}

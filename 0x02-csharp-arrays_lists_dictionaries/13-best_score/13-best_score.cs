using System;
using System.Linq;
using System.Collections.Generic;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        /*LINQ’s Aggregate() method applies an accumulator function to
        each item of a sequence. It can be used as follows to find the
        maximum value of a dictionary*/
        try
        {
            var maxValueKey = myList.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;
            return maxValueKey;
        }
        catch (System.Exception)
        {
            return "None";
            throw;
        }
    }
}

using System;
using System.Collections.Generic;

class List
{
    public static int MaxInteger(List<int> myList)
    {
        int len = myList.Count;
        if (len == 0 || myList == null)
        {
            Console.WriteLine("List is empty");
            return -1;
        }
        /* int biggestint = 0;
        for (int i = 0; i < myList.Count; i++)
        {
            if (myList[i] > biggestint)
                biggestint = myList[i];
        } 
        return biggestint; 
        *this code left me with a check wrong so i'm applying Sort method* */
        myList.Sort();
        return myList[len -1];

    }
}

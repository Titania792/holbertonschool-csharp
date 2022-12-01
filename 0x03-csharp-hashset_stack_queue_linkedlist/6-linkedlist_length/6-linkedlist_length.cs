using System;
using System.Collections.Generic;

class LList
{
    public static int Length(LinkedList<int> myLList)
    {
        int n_item = 0;
        foreach (var item in myLList)
        {
            n_item++;
        }
        return n_item;
    }
}

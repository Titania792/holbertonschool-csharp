using System;
using System.Collections.Generic;

class LList
{
    public static int GetNode(LinkedList<int> myLList, int n)
    {
        int indx = 0;
        foreach (var node in myLList)
        {
            if (indx == n)
            {
                return node;
            }
            indx++;
        }
        return 0;
    }
}

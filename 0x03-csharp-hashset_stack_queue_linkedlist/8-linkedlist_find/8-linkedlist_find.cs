using System;
using System.Collections.Generic;

class LList
{
    public static int FindNode(LinkedList<int> myLList, int value)
    {
        int indx = 0;
        foreach (var node_value in myLList)
        {
            if (node_value == value)
            {
                return indx;
            }
            else
            {
                indx++;
            }
        }
        return -1;
    }
}

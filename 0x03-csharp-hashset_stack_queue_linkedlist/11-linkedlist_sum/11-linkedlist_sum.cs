using System;
using System.Collections.Generic;

class LList
{
    public static int Sum(LinkedList<int> myLList)
    {
        int total_data = 0;
        foreach (var node_value in myLList)
        {
            total_data = total_data + node_value;
        }
        return total_data;
    }
}

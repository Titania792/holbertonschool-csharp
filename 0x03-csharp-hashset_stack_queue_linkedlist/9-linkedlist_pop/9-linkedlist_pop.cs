using System;
using System.Collections.Generic;

class LList
{
    public static int Pop(LinkedList<int> myLList)
    {
        try
        {
            var data = myLList.First.Value;
            myLList.RemoveFirst();
            return data;
        }
        catch (System.Exception)
        {
            return 0;
            throw;
        }
    }
}

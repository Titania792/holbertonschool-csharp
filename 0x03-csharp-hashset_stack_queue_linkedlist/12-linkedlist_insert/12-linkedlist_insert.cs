using System;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> helper = myLList.First;
        if (helper.Value > n)
        {
            myLList.AddFirst(n);
            helper = myLList.First;
            return helper;
        }
        while (helper != null)
        {
            if (n < helper.Value)
            {
                LinkedListNode<int> new_node = myLList.AddBefore(helper, n);
                return new_node;
            }
            helper = helper.Next;
        }
        LinkedListNode<int> n_node = myLList.AddLast(n);
        return n_node;
    }
}

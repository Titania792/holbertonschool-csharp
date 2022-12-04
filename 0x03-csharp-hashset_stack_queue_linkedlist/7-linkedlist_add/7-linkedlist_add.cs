using System;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Add(LinkedList<int> myLList, int n)
    {
        myLList.AddFirst(n);
        var first_node = myLList.First; //LinkedList<T>.First property is used to get the first node of the LinkedList<T>
        return first_node;
    }
}

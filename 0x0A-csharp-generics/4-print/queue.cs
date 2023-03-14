﻿using System;

/// <summary> Queue Class </summary>
/// <typeparam name="T"> Template/Type of elements </typeparam>
class Queue<T>
{
    public int count;
    public Node tail { get; set; }
    public Node head { get; set; }

    /// <summary> returns the Queue’s type </summary>
    public Type CheckType()
    {
        return typeof(T);
    }

    /// <summary> Method that creates a new Node and adds it to the end of the queue </summary>
    public void Enqueue(T element)
    {
        Node node = new Node(element);

        node.value = element;

        if (head == null)
        {
            node.next = null;
            head = node;
            tail = node;
        }
        else
        {
            node.next = head;
            head = node;
        }
        count += 1;
    }

    /// <summary> Method Count </summary>
    /// <returns> Number of nodes in the queue </returns>
    public int Count()
    {
        return count;
    }

    /// <summary> Node Class </summary>
    public class Node
    {
        public T value { get; set; }
        public Node next { get; set; }

        public Node(T value)
        {
            this.value = value;
            this.next = null;
        }
    }

    public T Dequeue()
    {
        if (head == null && tail == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }
        
        Node node = head;
        T Fvalue;
        if (node.next == null)
        {
            Fvalue = node.value;
            count -= 1;
            head = null;
            tail = null;
        }
        else
        {
            while (node.next != tail)
            {
                node = node.next;
            }
            Fvalue = tail.value;
            count -= 1;
            tail = node;
            node.next = null;
        }

        return Fvalue;
    }

    public T Peek()
    {
        if (head == null && tail == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }
        Node node = tail;
        return node.value;

    }

    public void Print()
    {
        if (head == null && tail == null)
        {
            Console.WriteLine("Queue is empty");
            return;
        }

        Node node = head;
        while (node.next != null)
        {
            Console.WriteLine(node.value);
            node = node.next;
        }
        Console.WriteLine(node.value);
    }
}

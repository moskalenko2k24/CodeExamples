using System;

public class Deque<T>
{
    private class Node
    {
        public T value;
        public Node next, prev;
        public Node(T value, Node next = null, Node prev = null)
        {
            this.value = value;
            this.next = next; this.prev = prev;
        }
    }
    private int cnt = 0;
    private Node head = null;
    private Node tail = null;
    public void PushBack(T x)
    {
        if (++cnt == 1)
        {
            head = tail = new Node(x);
            return;
        }
        var newTail = new Node(x, null, tail);
        tail.next = newTail;
        tail = newTail;
    }
    public void PopBack()
    {
        tail = tail.prev;
        if (--cnt > 0)
        {
            tail.next = null;
        }
        else
        {
            head = null;
        }
    }
    public void PushFront(T x)
    {
        if (++cnt == 1)
        {
            head = tail = new Node(x);
            return;
        }
        var newHead = new Node(x, head, null);
        head.prev = newHead;
        head = newHead;

    }
    public void PopFront()
    {
        head = head.next; 
        if (--cnt > 0) 
        {
            head.prev = null;
        }
        else 
        {
            tail = null;
        }
    }
    public T Front() { return head.value; }
    public T Back() { return tail.value; }
    public void Print()
    {
        Node current = head;
        if (current == null)
            Console.Write("empty");
        while (current != null)
        {
            Console.Write(current.value + " ");
            current = current.next;
        }
        Console.WriteLine();
    }
    public int Size() { return cnt; }
    public bool Empty() { return Size() == 0; }
}

public class Program
{
    public static void Main()
    {
        // 1
        var L = new Deque <int>();
        for (int i = 0; i < 6; i++)
        {
            L.PushBack(i);
        }
        Console.WriteLine("Оригинальная очередь");
        L.Print();
        
        // 2
        Console.WriteLine("После вызовов PopBack() и PopFront()");
        L.PopBack(); L.PopFront(); L.Print();

        // 3
        Console.WriteLine("После удаления всех элементов");
        while (!L.Empty())
        {
            L.PopFront();
        }
        L.Print();
        Console.ReadLine();
    }
}
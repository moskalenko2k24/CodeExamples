using System;
using System.Collections; // IEnumerable
using System.Collections.Generic;

public class ArrList<T>: IEnumerable<T>
{
    private T[] arr;
    public int Size
    {
        get;
        private set;
    }

    public ArrList(int size)
    {
        this.Size = size;
        arr = new T[size];
    }
    
    public T this[int i]
    {
        get { return arr[i]; }
        set { arr[i] = value; }
    }
    
    public IEnumerator<T> GetEnumerator()
    {
        for (int i = 0; i < Size; i++)
        {
            yield return arr[i];
        }
    }
    
    IEnumerator IEnumerable.GetEnumerator()
    {  
        return GetEnumerator();  
    }  
  
}

public class Program
{
    public static void Main()
    {
        ArrList<int> a = new ArrList<int>(10);
        a[0] = 10;
        foreach (var x in a)
        {
            Console.Write(x + " ");
        }
    }
}
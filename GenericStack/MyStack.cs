using System;

public class MyStack<T>
{
    private T[] stack;
    private int _count;

    public int Count { get { return _count; } }
    public bool IsEmpty { get { return _count == 0; } }

    public MyStack(int capacity)
    {
        stack = new T[capacity]; 
        _count = 0;
    }

    public void Push(T item)
    {
        stack[_count++] = item;
    }

    public T Pop()
    {
        return stack[--_count];
    }

    public T Peek()
    {
        return stack[_count - 1];
    }
}
using System;

public class Registry<TKey, TValue> where TKey : IEquatable<TKey>
{
    TKey[] keys;
    TValue[] values;
    int _count;

    public int Count { get { return _count-1; } }

    public Registry(int capacity)
    {
        keys = new TKey[capacity];
        values = new TValue[capacity];
        _count = 0;
    }

    public void Register(TKey key, TValue value)
    {
        for (int i = 0; i < _count; i++)
        {
            if (key.Equals(keys[i]))
            {
                values[i] = value;
                _count++;
                return;
            }
        }
        keys[_count] = key;
        values[_count] = value;
        _count++;
    }

    public TValue Find(TKey key)
    {
        for (int i = 0; i < _count; i++)
        {
            if (key.Equals(keys[i]))
            {
                return values[i];
            }
        }
        return default(TValue);
    }

    public bool Contains(TKey key)
    {
        for (int i = 0; i < _count; i++)
        {
            if (key.Equals(keys[i]))
            {
                return true;
            }
        }
        return false;
    }

    public void PrintAll()
    {
        for(int i =0; i<_count; i++)
        {
            Console.WriteLine($"[{keys[i]}] {values[i]}");
        }
    }
}
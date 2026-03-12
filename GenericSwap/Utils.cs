using System;

public class Utils
{
    public static void Swap<T>(ref T a, ref T b)
    {
        T temp = a;
        a = b;
        b = temp;
    }

    public static void SwapInArray<T>(T[] array, int index1, int index2)
    {
        T temp = array[index1];
        array[index1] = array[index2];
        array[index2] = temp;
    }

    public static T FindMin<T>(T[] array) where T : IComparable<T>
    {
        T min = array[0];
        foreach (T temp in array)
        {
            if (min.CompareTo(temp) > 0)
            {
                min = temp;
            }
        }
        return min;
    }

    public static T FindMax<T>(T[] array) where T : IComparable<T>
    {
        T max = array[0];
        foreach (T temp in array)
        {
            if (max.CompareTo(temp) < 0)
            {
                max = temp;
            }
        }
        return max;
    }

    public static void Reverse<T>(T[] array)
    {
        for(int i =0; i < array.Length / 2; i++)
        {
            Utils.Swap(ref array[i], ref array[array.Length - 1 - i]);
        }
    }
}
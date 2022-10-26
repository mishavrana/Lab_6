using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;

namespace Lab_6;

public static class MyListExtension
{
    public static T[] GetArray<T>(this MyList<T> list)
    {
        T[] elements = new T[list.Size];
        int index = 0; 
        for (int i = 0; i < list.Capacity; i++)
        {
            if (list.Data[i] != null)
            {
                elements[index] = list.Data[i];
                Console.WriteLine(list.Data[i]);
                if (index < list.Size)
                {
                    index += 1;  
                }
            }
        }
        return elements;
    }
}






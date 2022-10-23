namespace Lab_6;

/*
 * MyList<T> must implement such features:
 *  - Append element
 *  - Remove element
 *  - Indexation mechanism
 *  - Get element
 *  - Get amount of elements in array
 * 
 */

public class MyList<T>
{
    private T[] data;
    private int size = 0; // amount of items
    private int capacity; // amount of slots

    // Constructors with capacity option. By default is 8
    public MyList(int capacity = 8)
    { 
        if (capacity < 1) 
        { 
            capacity = 1;
        }
        this.capacity = capacity; 
        data = new T[capacity];
    }

    // Append element. Appends the new element on the 'index' position with overwriting
    public void AppendAt(T element, int index)
    {
        CheckIndexOutOfRange(index);
        data[index] = element;
        size++;
    }

    // Insert element. Puts the new element on the 'index' position without overwriting
    public void InsertAt(T element, int index) 
    { 
        CheckIndexOutOfRange(index); 
        if(size == capacity) 
        { 
            Resize();
        }
        for(int i = size; i > index; i--) 
        { 
            data[i] = data[i - 1];
        }
        data[index] = element;
        size++; 
    }

    // Remove element
    public void RemoveAt(int index)
    {
        CheckIndexOutOfRange(index);
        for (int i = index; i < size - 1; i++)
        {
            data[i] = data[i + 1]; 
        }
        data[size - 1] = default(T)!;
        size--;
    }

    // Get amount of elements in the List
    public int Count 
    { 
        get { return size; }
    }
    
    // Get the element of the list
    public T GetAt(int index)
    {
        CheckIndexOutOfRange(index);
        return data[index];
    }

    // Checking if the index is out of range
    private void CheckIndexOutOfRange(int index) 
    { 
        if(index > size - 1 || index < 0) 
        { 
            throw new IndexOutOfRangeException(string.Format($"Index is outside the array, which size is {size}"));
        }
    }

    // Indexation mechanism 
    private void Resize()
    { 
        T[] resizedData = new T[capacity * 2];
        for(int i = 0; i < size; i++) 
        { 
            resizedData[i] = data[i];
        }
        data = resizedData; // We just assign the reference to the information in heap 
        capacity = capacity * 2; 
    }
}
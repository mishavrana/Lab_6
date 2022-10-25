using System.Net.Security;

namespace Lab_6;

public class MyDictionary<TKey, TValue>
{
     // Capacity of the hash table/
     private static int capacity = 16;
     
      // Holds the 'MyLinkedList' of 'Element<TKey, TValue>' as 'data' 
    private MyLinkedList<TKey, TValue>[] buckets = new MyLinkedList<TKey, TValue>[capacity];
     
     // Returns the amount of elements in dictionary
     public int Count
     {
          get
          {
               int elements = 0;
               for (int i = 0; i < capacity; i++)
               {
                    if(buckets[i] != null) 
                    { 
                         elements += buckets[i].Count;
                    }
               }
               return elements;
          }
     }
     
     // Indexer to return the value for the key
     public object this[TKey key]    
     {    
          get { return GetValue(key); }
     }

    // Adding new items to 'buckets'
    public void Add(TKey key, TValue value)
    {
         int keyPosition = (key!.GetHashCode() & 0x7fffffff) % capacity;
         if (buckets[keyPosition] == null)
         {
              buckets[keyPosition] = new MyLinkedList<TKey, TValue>();
              buckets[keyPosition].Add(key, value);
         }
         else
         {
              buckets[keyPosition].Add(key, value);
              // Resizes the array if if the amount of collisions is greater or iquall than 50
              if (buckets[keyPosition].Count >= 50)
              {
                   Resize();
              }
         }
    }

    // Removing elements from 'buckets'
     public void Remove(TKey key)
     {
          int keyPosition = (key!.GetHashCode() & 0x7fffffff) % capacity;
          buckets[keyPosition].Remove(key); 
     }
     
     
     // Getting value
     private TValue GetValue(TKey key)
     {
          int keyPosition = (key!.GetHashCode() & 0x7fffffff) % capacity;
          return buckets[keyPosition].Read(key);
     }
     
     // The resizing mechanism
     private void Resize()
     {
          int newCapacity = capacity * 2; 
          MyLinkedList<TKey, TValue>[] newBuckets = new MyLinkedList<TKey, TValue>[capacity];
          for (int i = 0; i < capacity; i++)
          {
               if (buckets[i] != null)
               {
                    Node<TKey, TValue> current = buckets[i].Head;
                    while (current.next != null)
                    {
                         int keyPosition = (current.key!.GetHashCode() & 0x7fffffff) % capacity;
          
                         if(newBuckets[keyPosition] == null)
                         { 
                              newBuckets[keyPosition] = new MyLinkedList<TKey, TValue>();
                              newBuckets[keyPosition].Add(current.key, current.data);
                         }
                         else
                         {
                              newBuckets[keyPosition].Add(current.key, current.data);
                         }
                    }
               }
          }

          buckets = newBuckets;
          capacity = newCapacity;
     }
}
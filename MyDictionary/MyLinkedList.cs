using System.Collections;

namespace Lab_6;

// Generic linked list; 
public class MyLinkedList<TKey, TValue>
{
    private Node<TKey, TValue>? head = null;
    private Node<TKey, TValue> tail = null;

    public Node<TKey, TValue>? Head
    {
        get { return head; }
    }

    // Creating a node
    public Node<TKey, TValue> CreateNode(TKey key, TValue data, Node<TKey, TValue> next)
    {
        Node<TKey, TValue> newNode = new Node<TKey, TValue>();
        newNode.data = data;
        newNode.key = key;
        newNode.next = null;
        return newNode;
    }

    // Adding nodes to the linkedList. 
    public void Add(TKey key, TValue data)
    {
        if (head == null)
        {
            head = CreateNode(key, data, null);
            tail = head;
        }
        else
        {
            tail.next = CreateNode(key, data, null);
            tail = tail.next;
        }
    }

    // Removing node with specific data
    public void Remove(TKey key)
    {
        if (head.data.Equals(key))
        {
            head = head.next;
        }
        else
        {
            Remove(key, head.next);
        }
    }

    // Removing node
    public Node<TKey, TValue> Remove(TKey key, Node<TKey, TValue> current)
    {
        if (current != null)
        {
            if (current.data.Equals(key))
            {
                current = current.next;
            }
            else
            {
                current.next = Remove(key, current.next);
            }
        }
        return current;
    }

    // Reading value
    public TValue Read(TKey key)
    {
        Node<TKey, TValue> current = head;
        do
        {
            if (current.key!.Equals(key))
            {
                return current!.data;
            }
        } while (current.next != null);
        throw new Exception("Not found");
    }

    // Reading values 
    public void ReadAll()
    {
        Node<TKey, TValue> current = head;
        while (current.next != null)
        {
            Console.WriteLine(current.data); // Outputs the data in the last node 
        }
    }

    // Get the amount of values 
    public int Count
    {
        get
        {
            int elements = 0;
            Node<TKey, TValue> current = head;
            while (current.next != null)
            {
                elements += 1; 
            }
             //+1 is used because while loop doesn't calculate the last element bacause the 'next' is null
             return elements + 1; 
        }
    }
}


// Holds the information and the link to the next node in 'LinkedList'
public class Node<TKey, TValue>
{
    public TKey key;
    public TValue data;
    public Node<TKey, TValue>? next = null;
}
using System;

public class Node
{
    public int Value;
    public Node? Next;

    public Node(int value)
    {
        Value = value;
        Next = null;
    }

    public override bool Equals(object? obj)
    {
        return obj is Node node &&
               Value == node.Value &&
               Next == node.Next;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Value, Next);
    }
}

public class LinkedList
{
    private Node? head;

    public void InsertLast(int value)
    {
        Node newNode = new(value);

        if (head == null)
        {
            head = newNode;

            return;
        }

        Node current = head;
        while (current.Next != null)
        {
            current = current.Next;
        }
        current.Next = newNode;
    }

    public void InsertAt(int index, int value)
    {
        Node node = new(value);

        if (head == null)
        {
            InsertLast(node.Value);
            return;
        }

        if (index == 0)
        {
            node.Next = head;
            head = node;
            return;
        }

        Node current = head;

        Console.WriteLine($"Entrou no for.... =-=-=-=-=-=-=-");


        for (int i = 0; i < index; i++)
        {
            if (current?.Next == null)
            {
                current.Next = node;
                break;
            }

            int prevIndex = index - 1;

            Console.WriteLine($"index:: {i} prevIndex:: {prevIndex}");

            if (current?.Next != null)
            {
                Console.WriteLine($"current?.Next:: {current?.Next.Value}");
                if (i != prevIndex)
                {
                    current = current.Next;
                }

                if (i == prevIndex)
                {
                    Console.WriteLine($"current:: {current?.Value} || current.Next:: {current?.Next?.Value}");

                    node.Next = current.Next;
                    current.Next = node;
                }
            }
        }
    }

    public void RemoveFirst()
    {
        if (head == null) return;

        head = head.Next;
    }

    public void DeleteAt(int index)
    {
        if (head == null)
        {
            return;
        }

        if (index == 0)
        {
            RemoveFirst();
            return;
        }

        Node current = head;

        Node? prevCurrent = null;

        for (int i = 0; i < index + 1; i++)
        {
            if (i == index - 1)
            {
                prevCurrent = current;
            }

            if (i == index)
            {
                if (prevCurrent != null)
                {
                    prevCurrent.Next = current?.Next;
                }
            }

            if (current?.Next != null)
            {
                current = current.Next;
            }
        }
    }

    public int SearchAt(int index)
    {
        if (head == null)
        {
            return -1;
        }

        if (index == 0)
        {
            return head.Value;
        }

        Node? current = head;
        int count = 0;

        while (current?.Next != null && count < index)
        {
            count++;
            current = current?.Next;
        }

        if (current?.Value != null)
        {
            return current.Value;
        }

        return -1;
    }

    public int IndexOf(Node node)
    {
        Node? current = head;
        int count = -1;
        bool founded = false;

        while (!founded)
        {
            if (current?.Value == node.Value)
            {
                founded = true;
            }

            current = current?.Next;
            count++;
        }

        return count;
    }

    public int[] GetList()
    {
        if (head == null)
        {
            return [];
        }

        Node current = head;
        List<int> result = [current.Value];

        while (current.Next != null)
        {
            result.Add(current.Next.Value);

            current = current.Next;
        }
        return result.ToArray();
    }
}

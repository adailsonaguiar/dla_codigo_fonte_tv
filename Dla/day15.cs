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

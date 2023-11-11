using System;

namespace Linked_List_Homework
{
    public class LinkedList
    {
        public Node First { get; set; }

        public void Print()
        {
            Node move = First;
            while (move != null)
            {
                Console.Write(move.Data + "\t");
                move = move.Next;
            }
            Console.WriteLine();
        }

        // methods
        public void Add(int val)
        {
            // TODO: add item to the end of the list
            // consider when the list is empty

            // create a new node with the given data
            Node temp_node = new Node(val);
            if (First == null) { First = temp_node; }
            else
            {
                Node move = First;
                while (move.Next != null)
                {
                    move = move.Next;
                }
                move.Next = temp_node;
            }
        }
        public void RemoveKey(int key)
        {
            // TODO: search for the key and remove it from the list
            // consider when the key does not exist and when the list is empty
            if (First == null)
            {
                Console.WriteLine("list is empty >_*");
            }
            if (First.Data == key)
            {
                Node t = First;
                First = First.Next;
                t.Next = null;
            }
            Node move = First;
            while (move.Next != null && move.Next.Data != key)
            {
                move = move.Next;
            }

            Node r = move.Next;
            if (move.Next != null)
            {
                move.Next = move.Next.Next;
                r.Next = null;
            }
        }
        public void Merge(LinkedList other_list)
        {
            // TODO: merge this list with the other list
            Node move = First;
            while (move.Next != null)
            {
                move = move.Next;
            }
            move.Next = other_list.First;
        }
        public void Reverse()
        {
            // TODO: revers the nodes of this list
            // initialize three pointers: prev, curr, and next
            if (First != null)
            {
                Node prevNode = First;
                Node tempNode = First;
                Node curNode = First.Next;
                prevNode.Next = null;
                while (curNode != null)
                {
                    tempNode = curNode.Next;
                    curNode.Next = prevNode;
                    prevNode = curNode;
                    curNode = tempNode;
                }
                First = prevNode;
            }
        }
    }
}

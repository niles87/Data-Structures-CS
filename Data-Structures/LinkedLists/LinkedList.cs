using System;

namespace Data_Structures.LinkedList
{
    public class LinkedList<T>
    {
        private int size = 0;
        private Node<T> head = null;
        private Node<T> tail = null;

        //Internal Node to represent data
        private class Node<T>
        {
            public T data;
            public Node<T> prev, next;

            public Node(T data, Node<T> prev, Node<T> next)
            {
                this.data = data;
                this.prev = prev;
                this.next = next;
            }
        }

        // Clear the linked list
        public void Clear()
        {
            Node<T> trav = head;
            while (trav != null)
            {
                Node<T> next = trav.next;
                trav.prev = trav.next = null;
                trav.data = default;
                trav = next;
            }

            head = tail = trav = null;
            size = 0;
        }

        // view size of linked list
        public int Size()
        {
            return size;
        }

        public bool IsEmpty()
        {
            return this.Size() == 0;
        }

        public void Add(T item)
        {
            this.AddLast(item);
        }

        // add an element to the tail of the linked list
        public void AddLast(T item)
        {
            if (this.IsEmpty())
            {
                head = tail = new Node<T>(item, null, null);
            }
            else
            {
                tail.next = new Node<T>(item, tail, null);
                tail = tail.next;
            }
            size += 1;
        }

        // add an element to the head of the linked list
        public void AddFirst(T item)
        {
            if (this.IsEmpty())
            {
                head = tail = new Node<T>(item, null, null);
            }
            else
            {
                head.prev = new Node<T>(item, null, head);
                head = head.prev;
            }

            size += 1;
        }

        public T ViewFirst()
        {
            if (this.IsEmpty())
                throw new Exception("Empty List");
            return head.data;
        }

        public T ViewLast()
        {
            if (this.IsEmpty())
                throw new Exception("Empty List");
            return tail.data;
        }

        // remove node from head of the linked list
        public T RemoveFirst()
        {
            if (this.IsEmpty())
                throw new Exception("Empty List");

            T data = head.data;
            head = head.next;
            size -= 1;

            if (this.IsEmpty())
                tail = null;
            else
                head.prev = null;

            return data;
        }

        // remove node from tail of the linked list
        public T RemoveLast()
        {
            if (this.IsEmpty())
                throw new Exception("Empty List");

            T data = tail.data;
            tail = tail.prev;
            size -= 1;

            if (this.IsEmpty())
                head = null;
            else
                tail.next = null;

            return data;
        }

        private T Remove(Node<T> node)
        {
            if (node.prev == null)
                return this.RemoveFirst();
            if (node.next == null)
                return this.RemoveLast();

            node.next.prev = node.prev;
            node.prev.next = node.next;

            T data = node.data;

            node.data = default;
            node = node.prev = node.next = null;

            size -= 1;

            return data;
        }

        // remove node at a specific "index" of linked list
        public T RemoveAt(int index)
        {
            if (index < 0 || index >= size)
                throw new ArgumentException();

            int i;
            Node<T> trav;

            if (index < size / 2)
            {
                trav = head;
                for (i = 0; i != index; i++)
                {
                    trav = trav.next;
                }
            }
            else
            {
                trav = tail;
                for (i = size; i != index; i--)
                {
                    trav = trav.prev;
                }
            }

            return this.Remove(trav);
        }

        // remove a value from linked list
        public bool Remove(Object obj)
        {
            Node<T> trav = head;

            if (obj == null)
            {
                for (; trav != null; trav = trav.next)
                {
                    if (trav.data == null)
                    {
                        this.Remove(trav);
                        return true;
                    }
                }
            }
            else
            {
                for (; trav != null; trav = trav.next)
                {
                    if (obj.Equals(trav.data))
                    {
                        this.Remove(trav);
                        return true;
                    }
                }
            }

            return false;
        }

        // returns an index of the linked list
        public int IndexOf(Object obj)
        {
            int index = 0;
            Node<T> trav = head;

            if (obj == null)
            {
                for (; trav != null; trav = trav.next, index++)
                {
                    if (trav.data == null)
                        return index;
                }
            }
            else
            {
                for (; trav != null; trav = trav.next, index++)
                {
                    if (obj.Equals(trav.data))
                        return index;
                }
            }

            return -1;
        }

        public bool Contains(Object obj)
        {
            return this.IndexOf(obj) != -1;
        }

        public override string ToString()
        {
            string s = "";
            s += "[ ";
            Node<T> trav = head;
            while (trav != null)
            {
                s += $"{trav.data}, ";
                trav = trav.next;
            }

            s += " ]";

            return s;
        }
    }
}

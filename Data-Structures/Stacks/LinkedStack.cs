using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures.Stacks
{
    class LinkedStack<T>
    {
        private LinkedList.LinkedList<T> list = new();

        public LinkedStack() { }

        public LinkedStack(T firstEl)
        {
            this.Push(firstEl);
        }

        public int Size()
        {
            return this.list.Size();
        }

        public bool IsEmpty()
        {
            return this.Size() == 0;
        }

        public void Push(T el)
        {
            list.AddLast(el);
        }

        public T Pop()
        {
            if (this.IsEmpty())
                throw new Exception("Stack is already empty");
            return list.RemoveLast();
        }

        public T Peek()
        {
            if (this.IsEmpty())
                throw new Exception("Stack is empty");
            return list.ViewLast();
        }
    }
}

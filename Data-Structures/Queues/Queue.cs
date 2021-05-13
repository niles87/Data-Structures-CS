using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures.Queues
{
    class Queue<T>
    {
        private LinkedList.LinkedList<T> list = new();

        public Queue() { }

        public Queue(T firstEl)
        {
            this.Enqueue(firstEl);
        }

        public int Size()
        {
            return list.Size();
        }

        public bool IsEmpty()
        {
            return this.Size() == 0;
        }

        public T ViewFirst()
        {
            if (this.IsEmpty())
                throw new Exception("The Queue is empty!");
            return list.ViewFirst();
        }

        public T Dequeue()
        {
            if (this.IsEmpty())
                throw new Exception("The Queue is empty!");
            return list.RemoveFirst();
        }

        public void Enqueue(T el)
        {
            list.AddLast(el);
        }
    }
}

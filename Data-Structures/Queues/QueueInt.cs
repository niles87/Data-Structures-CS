using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures.Queues
{
    class QueueInt
    {
        private int[] arr;
        private int front, end, size;

        public QueueInt(int maxSize)
        {
            this.front = 0;
            this.end = 0;
            this.size = maxSize + 1;
            this.arr = new int[this.size];

        }

        public bool IsEmpty()
        {
            return this.front == this.end;
        }

        public int Size()
        {
            if (this.front > this.end)
                return (this.end + this.size - this.front);

            return end - front;
        }

        public int Peek()
        {
            return this.arr[front];
        }

        public void Enqueue(int num)
        {
            this.arr[this.end] = num;
            if (++this.end == this.size)
                this.end = 0;
            if (this.end == this.front)
                throw new Exception("Queue size is too small dequeue first");
        }

        public int Dequeue()
        {
            int num = this.arr[this.front];
            if (++this.front == this.size)
                front = 0;
            return num;
        }
    }
}

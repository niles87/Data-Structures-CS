using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures.Stacks
{
    // Stack with a max length ints only
    class Stack
    {
        private int[] arr;
        private int pos = 0;

        public Stack (int maxSize)
        {
            this.arr = new int[maxSize];
        }

        public int Size()
        {
            return this.pos;
        }

        public bool isEmpty()
        {
            return this.pos == 0;
        }

        public int Peek()
        {
            return this.arr[this.pos - 1];
        }

        public void Push(int val)
        {
            this.arr[this.pos++] = val;
        }

        public int Pop()
        {
            return this.arr[--this.pos];
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures.Queues
{
    // Binary Heap
    class PriorityQueue<T> where T : IComparable
    {
        private int heapSize = 0;

        private int heapCapacity = 0;

        private List<T> heap = null;

        public PriorityQueue() { }

        public PriorityQueue(T[] els)
        {
            heapSize = heapCapacity = els.Length;
            heap = new List<T>(heapCapacity);

            for (int i = 0; i < heapSize; i++)
            {
                heap.Add(els[i]);
            }

            for (int i = Math.Max(0, (heapSize / 2) - 1); i >= 0; i--)
            {
                Sink(i);
            }
        }

        public bool IsEmpty()
        {
            return Size() == 0;
        }

        public int Size()
        {
            return heap.Count();
        }

        public void EmptyQueue()
        {
            heap.Clear();
        }

        public T Peek()
        {
            if (IsEmpty())
                return default;
            return this.heap.ElementAt(0);
        }

        public T Poll()
        {
            return RemoveAt(0);
        }

        public bool Contains(T el)
        {
            for (int i = 0; i < Size(); i++)
                if (this.heap.ElementAt(i).Equals(el))
                    return true;
            return false;
        }

        public void Add(T el)
        {
            if (el == null)
                throw new ArgumentException();

            heap.Add(el);

            int indexOfLast = Size() - 1;
            Swim(indexOfLast);
        }

        private bool Less(int i, int j)
        {
            T node1 = this.heap.ElementAt(i);
            T node2 = this.heap.ElementAt(j);

            return node1.CompareTo(node2) <= 0;
        }

        // Bottom up bubbling up
        private void Swim(int k)
        {
            int parent = (k - 1) / 2;

            while (k > 0 && Less(k, parent))
            {
                Swap(parent, k);
                k = parent;

                parent = (k - 1) / 2;
            }
        }

        // Top down bubbling down
        private void Sink(int k)
        {
            int heapSize = Size();

            while (true)
            {
                int left = 2 * k + 1;
                int right = 2 * k + 2;
                int smallest = left;

                if (right < heapSize && Less(right, left))
                    smallest = right;

                if (left >= heapSize || Less(k, smallest))
                    break;

                Swap(smallest, k);
                k = smallest;
            }
        }

        private void Swap(int i, int j)
        {
            T el_i = this.heap.ElementAt(i);
            T el_j = this.heap.ElementAt(j);
            
            heap[i] = el_j;
            heap[j] = el_i;
        }

        public bool Remove(T el)
        {
            if (el == null)
                return false;
            for (int i = 0; i < Size(); i++)
            {
                if (el.Equals(this.heap.ElementAt(i)))
                {
                    RemoveAt(i);
                    return true;
                }
            }

            return false;
        }

        private T RemoveAt(int i)
        {
            if (IsEmpty())
                return default;

            heapSize--;

            int indexOfLastEl = Size() - 1;
            T removedData = this.heap.ElementAt(i);
            Swap(i, indexOfLastEl);

            heap.RemoveAt(indexOfLastEl);

            if (i == indexOfLastEl)
                return removedData;

            T el = this.heap.ElementAt(i);

            Sink(i);

            if (this.heap.ElementAt(i).Equals(el))
                Swim(i);

            return removedData;
        }

        // for testing to ensure heap is invariant is maintained
        public bool IsMinHeap(int k)
        {
            int heapSize = Size();
            if (k >= heapSize)
                return true;

            int left = 2 * k + 1;
            int right = 2 * k + 2;

            if (left < heapSize && !Less(k, left))
                return false;
            if (right < heapSize && !Less(k, right))
                return false;

            return IsMinHeap(left) && IsMinHeap(right);
        }

        public override string ToString()
        {
            return heap.ToString();
        }
    }
}

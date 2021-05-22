using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures.Union
{
    class UnionFind
    {
        private int size;

        private int[] compSize;

        private int[] id;

        private int numComp;

        public UnionFind(int sz)
        {
            if (sz <= 0)
                throw new ArgumentException("Arg of 0 or less is not allowed");

            this.size = sz;
            this.numComp = sz;

            this.compSize = new int[size];
            this.id = new int[size];

            for (int i = 0; i < size; i++)
            {
                id[i] = i;
                compSize[i] = 1;
            }

        }

        public int Find(int p)
        {
            int root = p;
            while (root != id[root])
                root = id[root];

            while (p != root)
            {
                int next = id[p];
                id[p] = root;
                p = next;
            }

            return root;
        }

        public bool Connected(int p, int q)
        {
            return Find(p) == Find(q);
        }

        public int ComponentSize(int p)
        {
            return compSize[Find(p)];
        }

        public int Size()
        {
            return this.size;
        }

        public int Components()
        {
            return this.numComp;
        }

        public void Unify(int p, int q)
        {
            if (Connected(p, q))
                return;
            int root1 = Find(p);
            int root2 = Find(q);

            if (compSize[root1] < compSize[root2])
            {
                compSize[root2] += compSize[root1];
                id[root1] = root2;
            }
            else
            {
                compSize[root1] += compSize[root2];
                id[root2] = root1;
            }

            numComp--;
        }
    }
}

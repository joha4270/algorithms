using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class Heap
    {
        public static void MaxHeapify<T>(IList<T> list) where T : IComparable<T>
        {
            for (int i = (list.Count -1) / 2; i >= 0; i--)
            {
                MaxHeapify(list, i);
            }
        }

        private static void MaxHeapify<T>(IList<T> list, int pos) where T: IComparable<T>
        {
            int l = Left(pos);
            int r = Right(pos);
            int largest = pos;

            if (l < list.Count && list[l].CompareTo(list[pos]) > 0)
            {
                largest = l;
            }
            if (r < list.Count && list[r].CompareTo(list[largest]) > 0)
            {
                largest = r;
            }

            if (largest != pos)
            {
                Swarp(list, largest, pos);
                MaxHeapify(list, largest);
            }

        }

        public static bool IsMaxHeap<T>(IList<T> list) where T : IComparable<T>
        {
            return IsMaxHeap<T>(list, 0);
        }

        private static bool IsMaxHeap<T>(IList<T> list, int n) where T : IComparable<T>
        {
            //if (n >= list.Count) return true;
            int l = Left(n), r = Right(n);
            bool left = l >= list.Count || list[n].CompareTo(list[l]) >= 0;

            bool right = r >= list.Count || list[n].CompareTo(list[r]) >= 0;

            if (left && right)
            {
                bool left2 = true, right2 = true;
                if (l < list.Count)
                {
                    left2 = IsMaxHeap(list, l);
                }

                if (r < list.Count)
                {
                    right2 = IsMaxHeap(list, r);
                }
                return (right2 && left2);
            }
            return false;
        }

        private static int Left(int n) => 2*n + 1;

        private static int Right(int n) => 2*n + 2;

        private static int Parrent(int n) => (n-1)/2;

        private static void Swarp<T>(IList<T> list, int a, int b)
        {
            T temp = list[a];
            list[a] = list[b];
            list[b] = temp;
        }
    }
}

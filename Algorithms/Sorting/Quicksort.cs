using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms
{
    public class Quicksort
    {
        public static void Sort<T>(IList<T> array) where T : IComparable<T>
        {
            Sort(array, (T x, T y) => x.CompareTo(y));
        }

        public static void Sort<T>(IList<T> array, Comparison<T> compare)
        {
            QuickSort(array, compare, 0, array.Count);
        }

        private static void QuickSort<T>(IList<T> array, Comparison<T> compare, int beginning, int afterLast)
        {
            if (beginning < afterLast-1)
            {
                int pivot = Partition(array, compare, beginning, afterLast);
                QuickSort(array, compare, beginning, pivot);
                QuickSort(array, compare, pivot+1, afterLast);

            }
        }

        private static int Partition<T>(IList<T> array, Comparison<T> compare, int beginning, int afterLast)
        {
            T temp;
            T middle = array[afterLast - 1];
            int pivot = beginning;

            for (int i = beginning; i < afterLast; i++)
            {
                if (compare(array[i],middle) < 0)
                {
                    Swarp(array, pivot, i);

                    pivot++;
                }
            }

            Swarp(array, pivot, afterLast-1);

            return pivot;
        }

        private static void Swarp<T>(IList<T> array, int pivot, int i)
        {
            T temp;
            temp = array[pivot];
            array[pivot] = array[i];
            array[i] = temp;
        }
    }
}
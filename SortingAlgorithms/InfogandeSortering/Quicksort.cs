using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfogandeSortering
{
    class Quicksort
    {
        public static void QuickSort(int[] a)
        {
            QuickSort(a, 0, a.Length - 1);
        }

        private static void QuickSort(int[] a, int start, int end)
        {
            if (start >= end)
            {
                return;
            }

            int num = a[start];

            int i = start, j = end;

            while (i < j)
            {
                while (i < j && a[j] > num)
                {
                    j--;
                }

                a[i] = a[j];

                while (i < j && a[i] < num)
                {
                    i++;
                }

                a[j] = a[i];
            }

            a[i] = num;
            QuickSort(a, start, i - 1);
            QuickSort(a, i + 1, end);
        }
    }
}

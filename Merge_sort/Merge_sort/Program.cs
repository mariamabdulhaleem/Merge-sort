using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merge_sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[6];
            Console.WriteLine("Enter the first element");
            arr[0] = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second element");
            arr[1] = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the third element");
            arr[2] = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the fourth element");
            arr[3] = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the fifth element");
            arr[4] = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the sixth element");
            arr[5] = int.Parse(Console.ReadLine());

            Console.WriteLine("**Array**");
            printArray(arr);
            sort(arr, 0, arr.Length - 1);
            Console.WriteLine("\n**Sorted array**");
            printArray(arr);
            Console.WriteLine("\nTime complexty = O(NlogN)");
            Console.ReadKey();
        }



        static void printArray(int[] arr)
        {

            for (int i = 0; i < 6; ++i)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }

        static void merge(int[] arr, int l, int m, int r)
        {
            int n1 = m - l + 1;
            int n2 = r - m;

            int[] L = new int[n1];
            int[] R = new int[n2];
            int i, j;

            for (i = 0; i < n1; ++i)
                L[i] = arr[l + i];
            for (j = 0; j < n2; ++j)
                R[j] = arr[m + 1 + j];

            i = 0;
            j = 0;

            int k = l;
            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    arr[k] = L[i];
                    i++;
                }
                else
                {
                    arr[k] = R[j];
                    j++;
                }
                k++;
            }

            while (i < n1)
            {
                arr[k] = L[i];
                i++;
                k++;
            }

            while (j < n2)
            {
                arr[k] = R[j];
                j++;
                k++;
            }
        }

        static void sort(int[] arr, int l, int r)
        {
            if (l < r)
            {

                int m = l + (r - l) / 2;

                sort(arr, l, m);
                sort(arr, m + 1, r);

                merge(arr, l, m, r);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Algorithms
{
        static class Algorithm
        {
            public static void selectionSort(int[] arr, int n)
            {
                for (int i = 0; i < n; ++i)
                {
                    int temp = arr[0];
                    for (int j = i + 1; j < n; ++j)
                    {
                        if (arr[i] > arr[j])
                        {
                            temp = arr[i];
                            arr[i] = arr[j];
                            arr[j] = temp;
                        }
                    }
                }
            }

            public static void insertionSort(int[] array)
            {
                int length = array.Length;

                for (int i = 1; i < length; i++)
                {
                    int j = i;

                    while ((j > 0) && (array[j] < array[j - 1]))
                    {
                        int k = j - 1;
                        int temp = array[k];
                        array[k] = array[j];
                        array[j] = temp;

                        j--;
                    }
                }
            }
            public static void bubbleSort(int[] a, int n)
            {
                for (int j = n - 1; j > 0; --j)
                {
                    for (int i = 0; i < j; ++i)
                    {
                        if (a[i] > a[i + 1])
                        {
                            int toSwap = a[i];
                            a[i] = a[i + 1];
                            a[i + 1] = toSwap;
                        }
                    }
                }
            }
        }
        class MainClass
        {
            public static void Main(string[] args)
            {
                int[] arr = new int[] { -12, 5, 2, 12, 6, 1, 1, 0, 0, 7, 18 };
            }
        }
    }


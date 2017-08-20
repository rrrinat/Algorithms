using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    class SelectionArray
    {
        private long[] array;
        private int size;

        public SelectionArray(int max)
        {
            array = new long[max];
        }

        public void Display()
        {
            for (int i = 0; i < size; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }

        public void Insert(long value)
        {
            array[size++] = value;
        }

        public void Sort()
        {
            int min;
            for (int i = 0; i < size - 1; i++)
            {
                min = i;
                for (int j = i + 1; j < size; j++)
                {
                    if (array[min] > array[j])
                    {
                        min = j;
                    }
                }
                Swap(i, min);
            }
        }

        private void Swap(int first, int second)
        {
            var buf = array[first];
            array[first] = array[second];
            array[second] = buf;
        }
    }
}

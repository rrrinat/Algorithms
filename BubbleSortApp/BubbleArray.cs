using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSortApp
{
    class BubbleArray
    {
        private long[] array;
        private int count;

        public BubbleArray(int length)
        {
            array = new long[length];
        }

        public void Display()
        {
            for (int i = 0; i < count; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }

        public void Insert(long value)
        {
            array[count++] = value;
        }

        public void Sort()
        {
            for (int i = 0; i < count - 1; i++)
            {
                for (int j = i + 1; j < count; j++)
                {
                    if (array[i] > array[j])
                    {
                        Swap(i, j);
                    }
                }
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

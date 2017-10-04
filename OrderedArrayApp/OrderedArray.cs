using System;

namespace OrderedArrayApp
{
    class OrderedArray
    {
        private long[] array;
        private int count;

        public OrderedArray(int length)
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

        public int BinarySearch(long key)
        {
            int lower = 0;
            int upper = count - 1;

            int current;

            while(lower <= upper)
            {
                current = (lower + upper) / 2;

                if (array[current] == key)
                {
                    return current;
                }
                else if (array[current] > key)
                {
                    upper = current - 1;
                }
                else
                {
                    lower = current + 1;
                }
            }

            return -1;
        }
    }
}

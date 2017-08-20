using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertSortApp
{
    class InsertArray
    {
        private long[] array;
        private int size;

        public InsertArray(int max)
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
            //outer - разделительный маркер
            int inner, outer;
            for (outer = 1; outer < size; outer++)
            {
                long buf = array[outer];
                inner = outer;
                while (inner > 0 && array[inner - 1] >= buf)
                {
                    array[inner] = array[inner - 1];
                    inner--;
                }
                array[inner] = buf;
            }
        }
    }
}

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
        private int count;

        public InsertArray(int length)
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
            //outer - разделительный маркер
            int inner, outer;
            for (outer = 1; outer < count; outer++)
            {
                long buf = array[outer];
                inner = outer;
                while (inner > 0 && array[inner - 1] >= buf)
                {
                    array[inner] = array[inner - 1];
                    inner--;
                }
                array[inner] = buf;
                Display();
            }
        }
    }
}

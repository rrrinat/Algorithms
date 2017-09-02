using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temp
{
    class TempApp
    {
        static void Main(string[] args)
        {
            TestArray1();
        }

        private static void TestArray1()
        {
            int count = 0;
            long[] array = new long[100];

            array[count++] = 77;
            array[count++] = 99;
            array[count++] = 44;
            array[count++] = 55;
            array[count++] = 22;
            array[count++] = 88;
            array[count++] = 11;
            array[count++] = 0;
            array[count++] = 66;
            array[count++] = 33;

            for (int i = 0; i < count; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
            //
            int min;
            for (int i = 0; i < count; i++)
            {
                min = i;
                for (int j = i; j < count; j++)
                {
                    if (array[min] > array[j])
                    {
                        var buf = array[min];
                        array[min] = array[j];
                        array[j] = buf;
                    }
                }
            }
            //
            for (int i = 0; i < count; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
            
            Console.ReadLine();
        }

        private static void TestArray2()
        {
            int count = 0;
            long[] array = new long[100];

            array[count++] = 77;
            array[count++] = 99;
            array[count++] = 44;
            array[count++] = 55;
            array[count++] = 22;
            array[count++] = 88;
            array[count++] = 11;
            array[count++] = 0;
            array[count++] = 66;
            array[count++] = 33;

            for (int i = 0; i < count; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
            //
            int min;
            for (int i = 0; i < count; i++)
            {
                min = i;
                for (int j = i; j < count; j++)
                {
                    if (array[min] > array[j])
                    {
                        var buf = array[min];
                        array[min] = array[j];
                        array[j] = buf;
                    }
                }
            }
            //
            for (int i = 0; i < count; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();

            Console.ReadLine();
        }

        /*
        private void Swap(int first, int second)
        {
            var buf = array[first];
            array[first] = array[second];
            array[second] = buf;
        }
        */
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertSortApp
{
    class InsertSortApp
    {
        static void Main(string[] args)
        {
            int length = 100;

            InsertArray insertArray = new InsertArray(length);

            insertArray.Insert(77);
            insertArray.Insert(99);
            insertArray.Insert(44);
            insertArray.Insert(55);
            insertArray.Insert(22);
            insertArray.Insert(88);
            insertArray.Insert(11);
            insertArray.Insert(0);
            insertArray.Insert(66);
            insertArray.Insert(33);

            insertArray.Display();

            insertArray.Sort();

            insertArray.Display();

            Console.ReadLine();
        }
    }
}

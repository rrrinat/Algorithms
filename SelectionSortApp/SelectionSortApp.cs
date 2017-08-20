using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    class SelectionSortApp
    {
        static void Main(string[] args)
        {
            int length = 100;

            SelectionArray selectionArray = new SelectionArray(length);

            selectionArray.Insert(77);
            selectionArray.Insert(99);
            selectionArray.Insert(44);
            selectionArray.Insert(55);
            selectionArray.Insert(22);
            selectionArray.Insert(88);
            selectionArray.Insert(11);
            selectionArray.Insert(0);
            selectionArray.Insert(66);
            selectionArray.Insert(33);

            selectionArray.Display();

            selectionArray.Sort();

            selectionArray.Display();

            Console.ReadLine();

        }
    }
}

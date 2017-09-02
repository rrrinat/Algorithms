using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSortApp
{
    class BubbleSortApp
    {
        static void Main(string[] args)
        {
            int length = 100;

            BubbleArray bubbleArray = new BubbleArray(length);

            bubbleArray.Insert(77);
            bubbleArray.Insert(99);
            bubbleArray.Insert(44);
            bubbleArray.Insert(55);
            bubbleArray.Insert(22);
            bubbleArray.Insert(88);
            bubbleArray.Insert(11);
            bubbleArray.Insert(0);
            bubbleArray.Insert(66);
            bubbleArray.Insert(33);

            bubbleArray.Display();

            bubbleArray.Sort();

            //bubbleArray.Display();

            Console.ReadLine();
        }
    }
}

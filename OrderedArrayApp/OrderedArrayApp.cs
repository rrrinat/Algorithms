using System;

namespace OrderedArrayApp
{
    class OrderedArrayApp
    {
        static void Main(string[] args)
        {
            int length = 100;

            OrderedArray orderedArray = new OrderedArray(length);
            orderedArray.Insert(1);
            orderedArray.Insert(3);
            orderedArray.Insert(5);
            orderedArray.Insert(7);
            orderedArray.Insert(9);

            orderedArray.Display();

            var result = orderedArray.BinarySearch(3);
            Console.WriteLine("Result is " + result);

            Console.ReadLine();
        }
    }
}

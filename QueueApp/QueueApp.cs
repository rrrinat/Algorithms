using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueApp
{
    class QueueApp
    {
        static void Main(string[] args)
        {
            //SimpleQueue();
            CycleQueue();
        }

        public static void SimpleQueue()
        {
            Queue queue = new Queue(5);

            queue.Insert(10);
            queue.Insert(20);
            queue.Insert(30);
            queue.Insert(40);

            queue.Remove();
            queue.Remove();
            queue.Remove();
            /*
            queue.Insert(50);
            queue.Insert(60);
            queue.Insert(70);
            queue.Insert(80);
            */
            while (!queue.IsEmpty())
            {
                var temp = queue.Remove();
                Console.Write("{0} ", temp);
            }
            Console.WriteLine();

            Console.ReadLine();
        }

        public static void CycleQueue()
        {
            CycleQueue cycleQueue = new CycleQueue(5);

            cycleQueue.Insert(10);
            cycleQueue.Insert(20);
            cycleQueue.Insert(30);
            cycleQueue.Insert(40);

            cycleQueue.Remove();
            cycleQueue.Remove();
            cycleQueue.Remove();

            cycleQueue.Insert(50);
            cycleQueue.Insert(60);
            cycleQueue.Insert(70);
            cycleQueue.Insert(80);

            while (!cycleQueue.IsEmpty())
            {
                var temp = cycleQueue.Remove();
                Console.Write("{0} ", temp);
            }
            Console.WriteLine();

            Console.ReadLine();
        }
        //
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackApp
{
    class StackApp
    {
        static void Main(string[] args)
        {
            int length = 100;

            Stack stack = new Stack(length);

            stack.Push(77);
            stack.Push(99);
            stack.Push(44);
            stack.Push(55);
            stack.Push(22);
            stack.Push(88);
            stack.Push(11);
            stack.Push(0);
            stack.Push(66);
            stack.Push(33);

            while(!stack.IsEmpty())
            {
                long value = stack.Pop();
                Console.Write(value + " ");
            }
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}

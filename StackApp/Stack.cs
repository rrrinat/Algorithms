using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackApp
{
    class Stack
    {
        private long[] array;
        private int count;
        private int top = -1;

        public Stack(int length)
        {
            array = new long[length];
        }

        public void Push(long value)
        {
            array[++top] = value;
        }

        public long Pop()
        {
            return array[top--];
        }

        public long Peek()
        {
            return array[top];
        }

        public bool IsEmpty()
        {
            return (top == -1);
        }
    }
}

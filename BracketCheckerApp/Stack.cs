using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BracketCheckerApp
{
    class Stack
    {
        private char[] array;
        private int count;
        private int top = -1;

        public Stack(int length)
        {
            array = new char[length];
        }

        public void Push(char value)
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

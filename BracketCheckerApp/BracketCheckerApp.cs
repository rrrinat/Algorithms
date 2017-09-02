using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BracketCheckerApp
{
    class BracketCheckerApp
    {
        static void Main(string[] args)
        {
            //string text = "()[]([])";
            string text = "([]]()";
            Console.WriteLine(IsBalanced(text));

            Console.ReadLine();
        }

        private static bool IsBalanced(string str)
        {
            int length = 100;
            Stack stack = new Stack(length);
            foreach(var ch in str)
            {
                if (ch.Equals('(') || ch.Equals('['))
                {
                    stack.Push(ch);
                }
                else if (stack.IsEmpty())
                {
                    return false;
                }
                else
                {
                    var top = stack.Pop();
                    if (top.Equals('[') && !ch.Equals(']'))
                    {
                        return false;
                    }
                    else if (top.Equals('(') && !ch.Equals(')'))
                    {
                        return false;
                    }
                }                
            }
            return stack.IsEmpty();
        }
    }
}

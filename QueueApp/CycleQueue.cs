using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueApp
{
    /// <summary>
    /// Очередь с циклическим переносом
    /// </summary>
    class CycleQueue
    {
        private long[] array;
        private int max; //максимальное количество элементов
        private int count = 0; //текущеее количество элементов
        private int front = 0;
        private int rear = -1;

        public CycleQueue(int max)
        {
            array = new long[max];
            this.max = max;
        }

        public void Insert(long value)
        {
            if (rear == (max - 1))
            {
                rear = -1;
            }
            //
            array[++rear] = value;
            count++;
        }

        public long Remove()
        {
            var temp = array[front++];
            if (front == max)
            {
                front = 0;
            }
            //
            count--;
            return temp;
        }

        public long Peek()
        {
            return array[front];
        }

        public bool IsEmpty()
        {
            return (count == 0);
        }

        public bool IsFull()
        {
            return (count == max);
        }

        public long Count()
        {
            return count;
        }
    }
}

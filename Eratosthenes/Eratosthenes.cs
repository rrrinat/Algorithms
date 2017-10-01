using System;
using System.IO;
using System.Linq;
using System.Text;

namespace Eratosthenes
{
    class Eratosthenes
    {
        static void Main(string[] args)
        {
            Console.Write("Введите конец диапазона: ");

            var n = Convert.ToInt32(Console.ReadLine());
            Primes(n);

            Console.ReadLine();
        }

        private static void Primes(Int32 n)
        {
            //формируем массив натуральных чисел 2..n:
            var numbers = new Int32[n];
            for (int i = 2; i < numbers.Count(); i++)
            {
                numbers[i] = i;
            }

            //просеивание

            //начинаем просеивать с двойки
            var prime = 2;

            do
            {
                //просеиваем
                for (int i = prime * prime; i < numbers.Count(); i += prime)
                {
                    numbers[i] = 0;
                }
                //ищем следующее просто число для просеивания
                do
                {
                    prime++;
                }
                while (numbers[prime] != 0 && prime <= Math.Sqrt(n));
            }
            while (prime <= Math.Sqrt(n));

            //выводим результаты
            /*
            Console.WriteLine();
            for (int i = 0; i < numbers.Count(); i++)
            {
                if (numbers[i] != 0)
                {
                    Console.Write(" " + numbers[i]);
                }
            }
            */
            WriteResults(numbers);
        }

        private static void WriteResults(Int32[] numbers)
        {
            using (FileStream fileStream = new FileStream("eratosthenes.txt", FileMode.Append))
            {
                using (StreamWriter streamWriter = new StreamWriter(fileStream, Encoding.UTF8))
                {
                    for (int i = 0; i < numbers.Count(); i++)
                    {
                        if (numbers[i] != 0)
                        {
                            streamWriter.Write(" " + numbers[i]);
                        }
                    }
                }
            }
        }
    }
}

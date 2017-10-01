using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagram
{
    class Anagram
    {
        static void Main(string[] args)
        {
            //string parket = "паркет";  
            string parket = "паркет";
            string buffer = parket.Substring(0, 2) + parket.Substring(2 + 1, 3);
            Console.WriteLine(buffer);

            //string raketa = "ракета";
            string raketa = "ракетп";
            if (IsAnagram(parket, raketa))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
            
            Console.ReadLine();          
        }

        private static bool IsAnagram(string word, string anagram)
        {
            if (word.Length != anagram.Length)
            {
                return false;
            }

            //
            int count = word.Length;

            char[] chars = word.ToCharArray();
            foreach (var c in chars)
            {
                var index = anagram.IndexOf(c);
                if (index == -1)
                {
                    return false;    
                }
                //вычеркиваем по одному одиннаковые символы
                anagram = anagram.Remove(index, 1);
            }

            return string.IsNullOrEmpty(anagram);
        }
    }
}

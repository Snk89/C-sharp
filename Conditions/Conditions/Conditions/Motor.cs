using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditions
{
    internal class Motor
    {
        public Motor()
        {
            ReadInt();
        }

        private void ReadString()
        {
            Console.WriteLine("Escreve uma palavra:");
            string word1 = Console.ReadLine();
            Console.WriteLine("Escreve outra palavra");
            string word2 = Console.ReadLine();



            Console.WriteLine(ConcatString(word1, word2));
        }

        private void ReadInt()
        {
            Console.WriteLine("Escreve um número :");
            string word1 = Console.ReadLine();
            Console.WriteLine("Escreve outro número");
            string word2 = Console.ReadLine();

            Sum(word1, word2);
        }

        private string ConcatString(string word1, string word2)
        {
            if (String.IsNullOrEmpty(word1) || String.IsNullOrEmpty(word2))
            {
                throw new Exception("Valores vazios");
            }
            return word1 + " " + word2;
        }

        private int Sum(string one, string two)
        {
            if(String.IsNullOrEmpty(one) || String.IsNullOrEmpty(two))
            {
                throw new Exception("Valores vazios");
            }

            int oneInt = Int32.Parse(one);
            int oneTwo = Int32.Parse(two);

            return oneInt + oneTwo;
        }

        private void WriteList(List<string> list)
        {
            string final = "";

            if (list.Count == 0 || list == null)
            {
                throw new Exception("Valores vazios");
            }

            for (int i = 0; i != list.Count; i++)
            {
                
                final += list[i];
            }
        }
    }
}
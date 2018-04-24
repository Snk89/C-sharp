using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());

            Console.Write("Escreve um numero");
            if (number < 0)
                Console.Write("Numero Negativo");
            else
                Console.Write("Numero Positivo");


        
        }
    }
}

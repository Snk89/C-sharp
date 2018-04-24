using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {


            {

                int Sum = 0;
                int Number = -1;

                while (Number != 0)
                {
                    Console.WriteLine("Number?");
                    Number = Convert.ToInt32(Console.ReadLine());
                    Sum = Sum + Number;


                    if (Number != 0)
                        Console.WriteLine("Total:" + Sum);

                }

                Console.Write("Fim");
                Console.ReadKey();
            }
        }
        
    }

}
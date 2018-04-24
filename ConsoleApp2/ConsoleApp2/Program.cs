using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{


    public class Test
    {
        public string Title;
        public Boolean Evaluation;
        public DateTime Date;
        
    }
    internal class Project
    {  
        static void Main(string[] args)
            {

            List<Test> list = new List<Test>()
            {
            new Test() { Title = "One", Evaluation = true, Date = DateTime.Now },
            new Test() { Title = "Two", Evaluation = false, Date = new DateTime(2020, 05, 01) },
            new Test() { Title = "Maybe", Evaluation = true, Date = new DateTime(2010, 05, 01) },
            new Test() { Title = "Nothing", Evaluation = false, Date = new DateTime(2020, 05, 01) },
            new Test() { Title = "Something", Evaluation = false, Date = new DateTime(2001, 05, 10) },
            };
            //PARA O PROJETO
            //1 - Inserir os objetos dados numa pilha e numa fila respetivamente

            Stack<Test> stack = new Stack<Test>(list);
            Queue<Test> queue = new Queue<Test>(list);

            //2 - Imprimir essas estruturas de dados

            foreach (Test t in stack)
            {
                Console.WriteLine(stack.Peek());
                stack.Push(t);
            }
            foreach (Test t in queue)
            {
                Console.WriteLine(queue.Peek());
                queue.Enqueue(t);
            }
            Console.ReadKey();

            //3 - Filtrar as estruturas de dados se necessário (Date < ultimos 30 dias)

            foreach(Test t in stack)
            {
                if (Convert.ToInt32(stack.Peek().Date) >= (DateTimeOffset.Now.Day - 30))
                    {
                    stack.Pop();
                    } 
            }

            //4 - Copiar as estruturas de dados para um Array

            Test[] array = new Test[stack.Count];
            stack.CopyTo(array, 0);
            Test[] array2 = new Test[queue.Count];
            array = queue.ToArray();

            //5 - Assegurar que a lista original só tem os dados que não foram enviados para o Array
            int i=0;
            foreach(Test t in list)
            {
                if (list[i] == array[i])
                {
                    list.Remove(t);
                }
                i++;
            }

            //6 - Voltar a guardar os dados dos arrays nas respetivas estruturas de dados

            Stack<Test> stack2 = new Stack<Test>(array);
            Queue<Test> queue2 = new Queue<Test>(array);

            //7 - Imprimir os dados finais, ordenados
            int j = 0;
            list.OrderBy(t => t);
            foreach(Test t in list)
            {
                Console.WriteLine(list[j].Title);
                Console.WriteLine(list[j].Evaluation);
                Console.WriteLine(list[j].Date);
                j++;
            }

        }
    }

}
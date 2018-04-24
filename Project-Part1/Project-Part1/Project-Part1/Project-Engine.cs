using System;
using System.Collections.Generic;
using System.Linq;

namespace Project_Part1
{
    internal class Project_Engine
    {
        private List<Archive> archives = new List<Archive>()
        {
            new Archive(){Name="2017Dec", ArchivedDate = new DateTime(2017, 12, 22), IdentificationNumber = 5965},
            new Archive(){Name="2016Dec", ArchivedDate = new DateTime(2016, 12, 21), IdentificationNumber = 3065},
            new Archive(){Name="2017Nov", ArchivedDate = new DateTime(2017, 11, 30), IdentificationNumber = 5635},
            new Archive(){Name="2017Dec-2", ArchivedDate = new DateTime(2017, 12, 29), IdentificationNumber = 5995},
            new Archive(){Name="2017Out", ArchivedDate = new DateTime(2017, 11, 02), IdentificationNumber = 5105},
            new Archive(){Name="2015Dec", ArchivedDate = new DateTime(2015, 12, 31), IdentificationNumber = 1569},
            new Archive(){Name="2017Out-2", ArchivedDate = new DateTime(2017, 11, 15), IdentificationNumber = 5166},
        };

        //Criar um atributo -> uma nova pilha (stack) vazia
       
        
        Stack<Archive> stack = new Stack<Archive>();
        

        //Criar um atributo -> uma nova fila (queue) vazia

        Queue<Archive> queue = new Queue<Archive>();

        //Criar dois Arrays como atributos

        Archive[] array = new Archive[6];
        
        Archive[] array2 = new Archive[6];

        Archive[] array3 = new Archive[6];


        //Construtor -> Inicia os métodos de construção das pilhas e fila, e respetivos comportamentos
        public Project_Engine()
        {
            Run();
            foreach (Archive t in archives)
            {
                queue.Enqueue(t);
                stack.Push(t);
            }
        }

        //Método responsável por correr os restantes métodos pela ordem pretendida ( pode ser necessário efetuar ajustes)
        private void Run()
        {
            SaveStack();
            SaveQueue();
            PrintDataStructures();
            CopyTo("queue");
            CopyTo("stack");
            FilterData();
            PrintAllData();
            Console.ReadKey();
        }

        //Método que guarda os valores da lista "archives" na pilha criada nos atributos

        private void SaveStack()
        {
            foreach (Archive t in archives)
                stack.Push(t);
        }

        //Método que guarda os valores da lista "archives" na fila criada nos atributos

        private void SaveQueue()
        {
            foreach (Archive t in archives)
                queue.Enqueue(t);
        }

        //Método responsável por imprimir os dados que estão na fila e na pilha
        //O resultado da consola deve respeitar as respetivas regras de FIFO e FILO
        private void PrintDataStructures()
        {
            foreach (Archive t in stack)
            {
                Console.WriteLine(t.Name);
               
            }
            foreach (Archive t in queue)
            {
                Console.WriteLine(queue.Peek());
            
            }
        }

        //Método para copiar para os Arrays
        //Pode ser necessário ajustar/apagar/editar este método, além de acrescentar informação
        //ATENÇÃO: Assegurar que a lista original só tem os dados que não foram enviados para o Array
        private void CopyTo(string type)
        {
            if (type.Equals("queue"))
            {
                Queue<Archive> filterQueue = FilterData();
                filterQueue.CopyTo(array, 0);

            }
            else if (type.Equals("stack"))
            {

            }

            
        }

        //Método para filtrar a queue, deve devolver uma queue que tenha apenas os arquivos dos ultimos 3 meses
        private Queue<Archive> FilterData()
        {
            DateTime a = DateTime.Now - DateTime.Now.Month(3);
            foreach (Archive t in queue)
            {
                if ((queue.Peek().ArchivedDate) >= a)
                {
                    queue.Enqueue(t);
                }
                else
                {
                    queue.Dequeue();
                }
            }
            return queue;
        }

        // Método responsável por imprimir os arrays na sua versão final (dados ordenados por IdentificationNumber)
        // Devem escrever informação ao utilizador, p.e. Stack: {1, 2 , 5}
        private void PrintAllData()
        {
            array.OrderBy(t => t.IdentificationNumber);
            foreach (Archive t in array)
            {
                Console.WriteLine(t);

            }
            array2.OrderBy(a => a.IdentificationNumber);
            Console.WriteLine("");
            foreach (Archive a in array2)
            {
                Console.WriteLine(a);

            }
        }

        //-----------------------------------------------------A PARTIR DAQUI, ENTREGA PARA DIA 5/01 -----------------------------------------------------------
        // Necessário alterar as classes que estão na pasta Sort

        //Método responsável por correr os métodos de Sort pela ordem pretendida
        private void RunSort()
        {
            CopyListToArray(archives);
            SortArray(array3);
        }

        //Método responsável por copiar a lista original para um Array e guardá-lo nos dos arrays dos atributos
        private void CopyListToArray(List<Archive> list)
        {   
            list.CopyTo(array3);
        }

        // método responsável por chamar o algoritmo de BubbleSort e o Comparable -> Imprime na consola ambos os Arrays
        private void SortArray(Archive[] array3)
        {
            
            SortAlgorithm.BubbleSort(array3, array3.Length);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerSoftware.CoreEngine
{
    internal class Salesman : Employee
    {
        Stack<Archive> stack = new Stack<Archive>();
        Archive[] array = new Archive[list.count];

        public Salesman(string name, string email, string contact) : base(name,email,contact)
        {
            this.name = name;
            this.email = email;
            this.contact = contact;
        }


        //Save a estrutura de dados (recebe uma lista)
        public SaveData(List<Archive> list)
        {
            foreach (Archive a in archives)
            {
                stack.Push(a);
            }

        }

        //Reset da estrutura de dados
        public ResetData()
        {
            stack.Clear();

        }

        //Get da Estrutura de dados
        public GetData(List<Archive> list)
        {
            this.list = list;
        }

        //Ordena por id (ascendente)  - Utilizar o BubbleSort
        // É necessário converter os dados para um array, usar o BubbleSort e passá-los novamente (já ordenados) para uma lista
        public SortData()
        {
            list.CopyTo(array);
            SortAlgorithm.Bubblesort(array, array.Length);
            return List<Archive> list.ToList(array);
        }

        //Método envio dos dados em forma de Lista
        public SetData()
        {
            return Stack < Archive > newQueue.ToList();
        }
    }
}
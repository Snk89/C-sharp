using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerSoftware.CoreEngine
{
    internal class Salesman : Employee
    {
        private Stack<Archive> stack = new Stack<Archive>();

        
        public Salesman(string name, string email, string contact) : base(name, email, contact)
        {

        }


        //Save a estrutura de dados (recebe uma lista)
        public override void Save(List<Archive> list)
        {
            foreach (Archive a in list)
            {
                stack.Push(a);
            }

        }

        //Reset da estrutura de dados
        public override void Reset()
        {
            stack.Clear();
        }

        //Get da Estrutura de dados
        public Stack<Archive> GetData()
        {
            return stack;
        }

        //Ordena por id (ascendente)  - Utilizar o BubbleSort
        // É necessário converter os dados para um array, usar o BubbleSort e passá-los novamente (já ordenados) para uma lista
        private List<Archive> SortData(List<Archive> list)
        {
            Archive[] array = new Archive[list.Count];

            list.CopyTo(array);

            SortAlgorithm.Bubblesort(array, array.Length);

            return list;
        }
        //Método envio dos dados em forma de Lista
        public override List<Archive> Send()
        {
            return stack.ToList();
        }
    }
}
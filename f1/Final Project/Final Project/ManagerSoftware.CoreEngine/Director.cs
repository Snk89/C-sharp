using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerSoftware.CoreEngine
{
    internal class Director : Employee
    {
        List<Archive> list = new List<Archive>();
        Queue<Archive> queu = new Queue<Archive>();

        public Director(string name, string email, string contact) : base(name, email, contact)
        {
            this.name = name;
            this.email = email;
            this.contact = contact;

        }

        //Save a estrutura de dados (recebe uma lista)
        public SaveData(List<Archive> list)
        {
            this.list = list;
        }
        //Reset da estrutura de dados
        public List<Archive> ResetData()
        {
            return list.clear;
        }

        //Get da Estrutura de dados
        public GetStructure()
        {
            Queue<Archive> filteredQueue = FilterData();
            myqueue = (Queue<Archive>)myqueue.Except(filteredQueue);
        }
        //filtra os mais recentes (desde 01/nov/2017)
        //List<Archive> filteredList = myqueue.Where(a => .......).ToList();
        private Queue<Archive> FilterData()
        {
            Queue<Archive> newQueue = new Queue<Archive>(queue1.Where(e => e.ArchivedData >= "01/nov/2017" )).ToList();
            return newQueue;
        }

        //ordena a lista filtrada por nome - implementa o IComparable
        internal class Archive : IComparable<Archive>
        {
            public String Name { get; set; }


            public int CompareTo(Archive other)
            {
                throw new NotImplementedException();
            }
        }

        //Método envio dos dados em forma de Lista
        public SetData()
        {
            return Queue < Archive > newQueue.ToList();
        }
    }
}
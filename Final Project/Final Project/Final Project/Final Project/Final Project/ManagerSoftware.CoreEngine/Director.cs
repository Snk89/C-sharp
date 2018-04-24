using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerSoftware.CoreEngine
{
    internal class Director : Employee
    {
        Queue<Archive> queu = new Queue<Archive>();
        Queue<Archive> newQueue;

        public Director(string name, string email, string contact) : base(name, email, contact)
        {
            
        }


        //Save a estrutura de dados (recebe uma lista)
        public override void Save(List<Archive> list)
        {
            queu = new Queue<Archive>(list);
        }

        //Reset da estrutura de dados
        public override void Reset()
        {
            queu.Clear();
        }

        //Get da Estrutura de dados
        public Queue<Archive> GetStructure()
        {
            return queu;
        }
        //filtra os mais recentes (desde 01/nov/2017)

        private Queue<Archive> FilterData(Queue<Archive> queue1)
        {
            DateTime a = new DateTime(2017,10,01);

            newQueue = new Queue<Archive>(queue1.Where(e => e.ArchiveDate >= a).ToList());
            return newQueue;
        }

        private List<Archive> Comparer(List<Archive> list)
        {
             list.Sort();
             return list;
        }

        //Método envio dos dados em forma de Lista
        public override List<Archive> Send()
        {
            return newQueue.ToList();
        }
    }
}
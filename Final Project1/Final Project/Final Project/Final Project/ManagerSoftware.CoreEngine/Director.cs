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

      

        public Director(string name, string email, string contact) : base(name, email, contact)
        {
        }

        //Save a estrutura de dados (recebe uma lista)
        public override void Save(List<Archive> list)
        {
            queu = new Queue<Archive>(list);
        }



        //Reset da estrutura de dados
        public void ResetData()
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
            DateTime a = new DateTime(01/09/2017);

            Queue<Archive> newQueue = new Queue<Archive>(queue1.Where(e => e.ArchiveDate >= a).ToList());
            return newQueue;
        }

        //ordena a lista filtrada por nome - implementa o IComparable
        internal class Archive : IComparable<Archive>
        {
            public String Name { get; set; }
            public DateTime ArchiveDate { get; set; }
            public int Id { get; set; }

            public int CompareTo(Archive other)
            {
                if (other == null)
                {
                    return 1;
                }
                else
                {
                    return this.Name.CompareTo(other.Name);
                }
            }
        }

        //Método envio dos dados em forma de Lista
        public List<Archive> SetData(Queue<Archive> newQueue)
        {
            return newQueue.ToList();
        }

       
    }
}
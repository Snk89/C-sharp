using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerSoftware.CoreEngine
{
    abstract class Employee
    {

        public string name { get; set; }
        public string email { get; set; }
        public string contact { get; set; }

        public Employee(string name, string email, string contact)
        {
            this.name = name;
            this.email = email;
            this.contact = contact;

        }

        //Métodos comuns às classes que a vão herdar
        public abstract List<Archive> Send();
        public abstract void Save(List<Archive> list);
        public abstract void Reset();
    }
}
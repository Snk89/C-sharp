using System;
using System.Collections.Generic;
using System.Text;

namespace ManagerSoftware.CoreEngine
{
    class Engine
    {
        public Engine()
        {

        }

        private Employee funcionario;

        public Queue<Archive> InsertQueue(string name, string email, string contact, List<Archive> list)
        {
            funcionario = new Director(name,email,contact);
            funcionario.Save(list);

            // devolve a estrutura de dados de Archive associada ao funcionario (p.e. funcionario.GetList())

            return (Director) funcionario).GetStructure();
        }

        public Stack<Archive> InsertStack(string name, string email, string contact, List<Archive> list)
        {
            funcionario = new Salesman(name, email, contact);
            funcionario.Send(list);

            // devolve a estrutura de dados de Archive associada ao funcionaario (p.e. funcionario.GetList())

            ((Salesman)funcionario).SaveData(list);

            return new Stack<Archive>(list);
        }

        public List<Archive> Send()
        {
            //chama o método send do funcionario e devolve a lista retomada
            List<Archive> list = funcionario.Send();
            return new List<Archive>();
        }

        public void Reset()
        {
            funcionario = null;
            //Limpa a informação armazenada (i.e. atributos no Engine e no Funcionário)
        }
    }
}
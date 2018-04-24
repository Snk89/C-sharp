using System;
using System.Collections.Generic;
using System.Text;

namespace ManagerSoftware.CoreEngine
{
    class Engine
    {
        private Employee funcionario;

        public Queue<Archive> InsertQueue(string name, string email, string contact, List<Archive> list)
        {
            CreateDirector(name,email,contact);

            // devolve a estrutura de dados de Archive associada ao funcionario (p.e. funcionario.GetList())

            ((Director)funcionario).Save(list);

            return ((Director)funcionario).GetStructure();
        }

        public Stack<Archive> InsertStack(string name, string email, string contact, List<Archive> list)
        {
            CreateSalesman(name, email, contact);

            // devolve a estrutura de dados de Archive associada ao funcionaario (p.e. funcionario.GetList())

            ((Salesman)funcionario).Save(list);

            return new Stack<Archive>(list);
        }

        //Create Director
        private void CreateDirector(string name, string email, string contact)
        {
            funcionario = new Director(name,email,contact);
        }
        //Create Salesman
        private void CreateSalesman(string name, string email, string contact)
        {
            funcionario = new Salesman(name,email,contact);
        }

        //chama o método send do funcionario e devolve a lista retomada
        private List<Archive> Send()
        {
            List<Archive> list = funcionario.Send();
            return new List<Archive>();
        }


        //Limpa a informação armazenada (i.e. atributos no Engine e no Funcionário)
        public void Reset()
        {
            funcionario.Reset();
            funcionario = null;
        }
    }
}
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
            CreateDir();

            ((Director)funcionario).SaveData(list);
            // devolve a estrutura de dados de Archive associada ao funcionario (p.e. funcionario.GetList())
            return new Queue<Archive>(list);
        }

        public Stack<Archive> InsertStack(string name, string email, string contact, List<Archive> list)
        {
            CreateOp();

            // devolve a estrutura de dados de Archive associada ao funcionaario (p.e. funcionario.GetList())
            return new Stack<Archive>(list);
        }

        public void CreateDir()
        {
            Director director = new Director(funcionario.name,funcionario.email,funcionario.contact);
        }

        public void CreateOp()
        {
            Salesman salesman = new Salesman(funcionario.name, funcionario.email, funcionario.contact);
        }

        public List<Archive> Send()
        {
            //chama o método send do funcionario e devolve a lista retomada
            return new List<Archive>();
        }

        public void Reset()
        {
            //Limpa a informação armazenada (i.e. atributos no Engine e no Funcionário)
        }
    }
}
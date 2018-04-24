using System;

namespace Project_Part1
{
    internal class Archive
    {
        public String Name { get; set; }
        public DateTime ArchivedDate { get; set; }
        public int IdentificationNumber { get; set; }


        //Método que vai definir a Comparação
        public int CompareTo(Archive other)
        {
            throw new NotImplementedException();
        }
    }
}
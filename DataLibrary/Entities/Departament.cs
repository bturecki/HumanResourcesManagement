using DataLibrary.Abstract;
using System;

namespace DataLibrary.Entities
{
    class Departament : IDepartament
    {
        public Departament(string pName)
        {
            Name = pName ?? throw new ArgumentNullException(nameof(pName));
        }
        public Departament()
        {
        }
        public int ID { get; }
        public string Name { get; set; }
    }
}

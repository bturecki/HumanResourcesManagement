using DataLibrary.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Entities
{
    class Departament : IDepartament
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}

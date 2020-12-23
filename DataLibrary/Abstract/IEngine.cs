﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Abstract
{
    public interface IEngine
    {
        List<IPersonModel> GetAllPeople();
        List<IDepartament> GetAllDepartaments();
        void SavePerson(IPersonModel pPersonModel);
        void UpdatePerson(IPersonModel pPersonModel);
        void SaveDepartament(IDepartament pDepartament);
        void UpdateDepartament(IDepartament pDepartament);
    }
}

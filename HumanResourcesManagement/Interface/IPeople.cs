using DataLibrary.Abstract;
using System;
using System.Collections.Generic;

namespace HumanResourcesManagement.Interface
{
    interface IPeople
    {
        event Action FrmShown;
        event Action AddNewPersonBtnClick;
        event Action PersonEdited;

        void FillGridPeople(List<IPersonModel> pPeople);
        void OpenAddingNewPerson(IPersonModel pPersonModel);
    }
}

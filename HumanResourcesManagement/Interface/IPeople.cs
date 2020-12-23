using DataLibrary.Abstract;
using System;
using System.Collections.Generic;

namespace HumanResourcesManagement.Interface
{
    interface IPeople
    {
        IPersonModel SelectedRow { get; }

        event Action FrmShown;
        event Action AddNewPersonBtnClick;
        event Action PersonEdited;
        event Action EditBtnClick;

        void FillGridPeople(List<IPersonModel> pPeople);
        void OpenAddingNewPerson(IPersonModel pPersonModel);
    }
}

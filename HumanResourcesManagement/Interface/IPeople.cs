using DataLibrary.Abstract;
using System;
using System.Collections.Generic;

namespace HumanResourcesManagement.Interface
{
    interface IPeople : IBaseForm
    {
        IPersonModel SelectedRow { get; }

        event Action FrmShown;
        event Action AddNewPersonBtnClick;
        event Action PersonEdited;
        event Action EditBtnClick;
        event Action DeleteBtnClick;

        void FillGridPeople(List<IPersonModel> pPeople);
        void OpenAddingNewPerson(IPersonModel pPersonModel);
    }
}

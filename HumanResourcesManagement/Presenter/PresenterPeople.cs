using DataLibrary;
using DataLibrary.Abstract;
using HumanResourcesManagement.Interface;

namespace HumanResourcesManagement.Presenter
{
    class PresenterPeople
    {
        IPeople View { get; set; }
        IEngine Engine { get; set; }

        public PresenterPeople(IPeople pView)
        {
            View = pView;
            Engine = Factory.GetEngine();
            View.FrmShown += View_FrmShown;
            View.AddNewPersonBtnClick += View_AddNewPersonBtnClick;
            View.PersonEdited += View_PersonEdited;
        }

        private void View_PersonEdited()
        {
            FillAllPeople();
        }
        private void View_AddNewPersonBtnClick()
        {
            View.OpenAddingNewPerson(null);
        }
        private void View_FrmShown()
        {
            FillAllPeople();
        }
        private void FillAllPeople()
        {
            View.FillGridPeople(Engine.GetAllPeople());
        }
    }
}

using DataLibrary;
using DataLibrary.Abstract;
using HumanResourcesManagement.Interface;

namespace HumanResourcesManagement.Presenter
{
    class PresenterAddEditDepartament
    {
        IEngine Engine { get; set; }
        IDepartament Departament { get; set; }
        IAddEditDepartament View { get; set; }

        public PresenterAddEditDepartament(IAddEditDepartament pView, IDepartament pDepartament)
        {
            Departament = pDepartament;
            View = pView;
            Engine = Factory.GetEngine();

            if (Departament != null)
                View.DepartamentName = Departament.Name;

            View.SaveBtnClick += View_SaveBtnClick;
        }
        private void View_SaveBtnClick()
        {
            if (string.IsNullOrEmpty(View.DepartamentName))
            {
                View.ShowMessageBox("Departament name can not be null or empty!");
                return;
            }
            Engine.SaveDepartament(Factory.GetDepartament(View.DepartamentName));
            View.SetDialogResultOK();
        }
    }
}

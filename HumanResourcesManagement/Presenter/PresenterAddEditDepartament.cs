using DataLibrary;
using DataLibrary.Abstract;
using HumanResourcesManagement.Interface;

namespace HumanResourcesManagement.Presenter
{
    class PresenterAddEditDepartament
    {
        readonly IEngine engine;
        readonly IDepartament departament;
        readonly IAddEditDepartament view;

        public PresenterAddEditDepartament(IAddEditDepartament pView, IDepartament pDepartament)
        {
            departament = pDepartament;
            view = pView;
            engine = Factory.GetEngine();
            view.FrmText = departament == null ? "Adding new departament" : "Departament edit";
            if (departament != null)
                view.DepartamentName = departament.Name;

            view.SaveBtnClick += View_SaveBtnClick;
        }

        private void View_SaveBtnClick()
        {
            if (string.IsNullOrEmpty(view.DepartamentName))
            {
                view.ShowMessageBox("Departament name can not be null or empty!");
                return;
            }
            if (departament == null)
                engine.SaveDepartament(Factory.GetDepartament(view.DepartamentName));
            else
            {
                if (departament.Name == view.DepartamentName)
                {
                    view.ShowMessageBox("New departament name can not be equal to the old departament name.");
                    return;
                }
                departament.Name = view.DepartamentName;
                engine.UpdateDepartament(departament);
            }
            view.SetDialogResultOK();
        }
    }
}

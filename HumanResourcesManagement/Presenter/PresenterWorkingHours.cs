using DataLibrary;
using DataLibrary.Abstract;
using HumanResourcesManagement.Interface;

namespace HumanResourcesManagement.Presenter
{
    class PresenterWorkingHours
    {
        IWorkingHours View { get; set; }
        IEngine Engine { get; set; }
        public PresenterWorkingHours(IWorkingHours pView)
        {
            View = pView;
            Engine = Factory.GetEngine();
            View.FrmShown += View_FrmShown;
            View.EditBtnClick += View_EditBtnClick;
        }
        private void View_EditBtnClick(IPersonWorkingHours pPersonWorkingHours)
        {
            View.OpenChangeWorkingHours(pPersonWorkingHours);
        }
        private void View_FrmShown()
        {
            View.FillGrid(Engine.GetAllWorkingHours());
        }
    }
}

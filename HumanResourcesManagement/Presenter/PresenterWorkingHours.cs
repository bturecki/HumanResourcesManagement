using DataLibrary;
using DataLibrary.Abstract;
using HumanResourcesManagement.Interface;

namespace HumanResourcesManagement.Presenter
{
    class PresenterWorkingHours
    {
        readonly IWorkingHours view;
        readonly IEngine engine;
        public PresenterWorkingHours(IWorkingHours pView)
        {
            view = pView;
            engine = Factory.GetEngine();
            view.FrmShown += View_FrmShown;
            view.EditBtnClick += View_EditBtnClick;
        }
        private void View_EditBtnClick(IPersonWorkingHours pPersonWorkingHours)
        {
            view.OpenChangeWorkingHours(pPersonWorkingHours);
        }
        private void View_FrmShown()
        {
            view.FillGrid(engine.GetAllWorkingHours());
        }
    }
}

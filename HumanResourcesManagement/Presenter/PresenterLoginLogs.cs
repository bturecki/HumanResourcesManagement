using DataLibrary;
using DataLibrary.Abstract;

namespace HumanResourcesManagement.Presenter
{
    internal class PresenterLoginLogs
    {
        readonly Interface.ILoginLogs view;
        readonly IEngine engine;

        public PresenterLoginLogs(Interface.ILoginLogs pView)
        {
            view = pView;
            engine = Factory.GetEngine();
            view.FrmShown += View_FrmShown;
        }

        private void View_FrmShown()
        {
            view.FillLogs(engine.GetAllLoginLogs());
        }
    }
}

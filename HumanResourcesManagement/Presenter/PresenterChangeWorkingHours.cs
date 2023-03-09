using DataLibrary;
using DataLibrary.Abstract;
using HumanResourcesManagement.Interface;

namespace HumanResourcesManagement.Presenter
{
    class PresenterChangeWorkingHours
    {
        readonly IChangeWorkingHours iew;
        readonly IEngine engine;
        readonly IPersonWorkingHours personWorkingHours;

        public PresenterChangeWorkingHours(IChangeWorkingHours pView, IPersonWorkingHours pPersonWorkingHours)
        {
            iew = pView;
            personWorkingHours = pPersonWorkingHours;
            engine = Factory.GetEngine();
            iew.FrmText = $"{personWorkingHours.FirstName} {personWorkingHours.LastName}";
            iew.TimeFrom = personWorkingHours.HourFrom;
            iew.TimeTo = personWorkingHours.HourTo;
            iew.SaveBtnClick += View_SaveBtnClick;
        }

        private void View_SaveBtnClick()
        {
            engine.SavePersonWorkingHours(personWorkingHours, iew.TimeFrom, iew.TimeTo);
            iew.SetDialogResultOK();
        }
    }
}

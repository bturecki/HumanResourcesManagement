using DataLibrary;
using DataLibrary.Abstract;
using HumanResourcesManagement.Interface;

namespace HumanResourcesManagement.Presenter
{
    class PresenterChangeWorkingHours
    {
        IChangeWorkingHours View { get; set; }
        IEngine Engine { get; set; }
        IPersonWorkingHours PersonWorkingHours { get; set; }

        public PresenterChangeWorkingHours(IChangeWorkingHours pView, IPersonWorkingHours pPersonWorkingHours)
        {
            View = pView;
            PersonWorkingHours = pPersonWorkingHours;
            Engine = Factory.GetEngine();
            View.FrmText = $"{PersonWorkingHours.FirstName} {PersonWorkingHours.LastName}";
            View.TimeFrom = PersonWorkingHours.HourFrom;
            View.TimeTo = PersonWorkingHours.HourTo;
            View.SaveBtnClick += View_SaveBtnClick;
        }
        private void View_SaveBtnClick()
        {
            Engine.SavePersonWorkingHours(PersonWorkingHours, View.TimeFrom, View.TimeTo);
        }
    }
}

using HumanResourcesManagement.Interface;
using System;

namespace HumanResourcesManagement.Presenter
{
    class PresenterMain
    {
        IMain View { get; set; }

        public PresenterMain(IMain pView)
        {
            View = pView;
            View.LabelCreator = $"Bartosz Turecki JiPP {DateTime.Now.Year}";
            View.PeopleBtnClick += View_PeopleBtnClick;
            View.DepartamentsBtnClick += View_DepartamentsBtnClick;
            View.VacationsBtnClick += View_VacationsBtnClick;
        }

        private void View_VacationsBtnClick()
        {
            View.OpenVacationsView();
        }
        private void View_DepartamentsBtnClick()
        {
            View.OpenDepartamentsView();
        }
        private void View_PeopleBtnClick()
        {
            View.OpenPeopleView();
        }
    }
}

using HumanResourcesManagement.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourcesManagement.Presenter
{
    class PresenterMain
    {
        IMain View { get; set; }

        public PresenterMain(IMain pView)
        {
            View = pView;
            View.PeopleBtnClick += View_PeopleBtnClick;
            View.DepartamentsBtnClick += View_DepartamentsBtnClick;
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

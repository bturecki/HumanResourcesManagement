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
        }

        private void View_PeopleBtnClick()
        {
            View.OpenPeopleView();
        }
    }
}

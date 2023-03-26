using DataLibrary.Abstract;
using HumanResourcesManagement.Interface;
using HumanResourcesManagement.Presenter;
using System;

namespace HumanResourcesManagement.View
{
    public partial class FrmChangeWorkingHours : BaseForm, IChangeWorkingHours
    {
        public FrmChangeWorkingHours(IPersonWorkingHours pWorkingHours)
        {
            InitializeComponent();
            new PresenterChangeWorkingHours(this, pWorkingHours);
        }

        public TimeSpan TimeFrom { get => dateTimePickerFrom.Value.TimeOfDay; set { DateTime _now = new DateTime(1753, 1, 1); _now = _now.Date + value; dateTimePickerFrom.Value = _now; } }
        public TimeSpan TimeTo { get => dateTimePickerTo.Value.TimeOfDay; set { DateTime _now = new DateTime(1753, 1, 1); _now = _now.Date + value; dateTimePickerTo.Value = _now; } }
        public string FrmText { set => this.Text = value; }

        public event Action SaveBtnClick;

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveBtnClick();
        }
    }
}

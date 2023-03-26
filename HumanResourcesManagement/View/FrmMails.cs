using DataLibrary.Abstract;
using HumanResourcesManagement.Interface;
using HumanResourcesManagement.Presenter;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HumanResourcesManagement.View
{
    public partial class FrmMails : BaseForm, IMails
    {
        public FrmMails()
        {
            InitializeComponent();
            new PresenterMails(this);
        }

        public List<IPersonModel> SelectedPeople
        {
            get
            {
                List<IPersonModel> _people = new List<IPersonModel>(gridPeople.SelectedRows.Count);

                for (int index = 0; index < gridPeople.SelectedRows.Count; index++)
                {
                    DataGridViewRow selectedRow = gridPeople.SelectedRows[index];
                    IPersonModel pilot = (IPersonModel)selectedRow.DataBoundItem;

                    _people.Add(pilot);
                }
                return _people;
            }
        }

        public string EmailSubject { get => emailSubject.Text; set => emailSubject.Text = value; }
        public string EmailContent { get => emailContent.Text; set => emailContent.Text = value; }

        public event Action SendBtnClick;
        public event Action FrmShown;

        public void ClearGridSelection()
        {
            gridPeople.ClearSelection();
        }
        public void FillGridPeople(List<IPersonModel> pList)
        {
            iPersonModelBindingSource.DataSource = pList;
        }
        private void btnSend_Click(object sender, System.EventArgs e)
        {
            SendBtnClick();
        }
        private void FrmMails_Shown(object sender, EventArgs e)
        {
            FrmShown();
        }
    }
}

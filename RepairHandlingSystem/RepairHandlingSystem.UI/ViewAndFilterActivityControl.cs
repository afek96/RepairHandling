﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RepairHandlingSystem.DAL;
using RepairHandlingSystem.Managers;
using RepairHandlingSystem.Common;

namespace RepairHandlingSystem.UI
{
    public partial class ViewAndFilterActivityControl : UserControl
    {
        private RequestManager _requestManager;
        private PersonelManager _personelManager;
        private Request _currentRequest;
        private Personel _currentWorker;

        public Personel CurrentWorker
        {
            get => _currentWorker;
            set
            {
                _currentWorker = value;
                cbxWorker.DataSource = new List<Personel>() { value };
                cbxWorker.DisplayMember = "DisplayName";
                cbxWorker.Enabled = false;
                btnFilterSearch.Enabled = true;
                dgvActivities.DataSource = null;
            }
        }

        public Request CurrentRequest
        {
            get
            {
                return _currentRequest;
            }
            set
            {
                _currentRequest = value;
                btnActivityAdd.Enabled = btnFilterSearch.Enabled = value != null;
            }
        }

        public ViewAndFilterActivityControl()
        {
            InitializeComponent();
            dtrpCreateDate.Text = "Create Date:";
            dtrpEndDate.Text = "End Date:";
        }

        public void Initialize(RequestManager requestManager, PersonelManager personelManager)
        {
            _requestManager = requestManager;
            _personelManager = personelManager;

            cbxStatus.DataSource = Enum.GetValues(typeof(StatusEnum));
            cbxStatus.SelectedIndex = -1;
        }

        private void btnFilterSearch_Click(object sender, EventArgs e)
        {
            Activity searchCriteria = new Activity()
            {
                CreateDateFrom = dtrpCreateDate.From,
                CreateDateTo = dtrpCreateDate.To,
                EndDateFrom = dtrpEndDate.From,
                EndDateTo = dtrpEndDate.To,
                Description = txbDescription.Text,
                Result = txbResult.Text,
                Personel = (Personel)cbxWorker.SelectedItem,
                Status = cbxStatus.SelectedItem?.ToString(),
                ActivityType = (ActivityType)cbxActivityType.SelectedItem,
                Request = CurrentRequest,
                SequenceNo = (int)nudSequenceNo.Value
            };

            dgvActivities.SelectionChanged -= new EventHandler(dgvActivities_SelectionChanged);
            dgvActivities.DataSource = _requestManager.GetActivities(searchCriteria);
            dgvActivities.SelectionChanged += new EventHandler(dgvActivities_SelectionChanged);

            dgvActivities.Columns["IdPersonel"].Visible = false;
            dgvActivities.Columns["IdActivity"].Visible = false;
            dgvActivities.Columns["IdRequest"].Visible = false;
            dgvActivities.Columns["Type"].Visible = false;
            dgvActivities.Columns["CreateDateFrom"].Visible = false;
            dgvActivities.Columns["CreateDateTo"].Visible = false;
            dgvActivities.Columns["EndDateFrom"].Visible = false;
            dgvActivities.Columns["EndDateTo"].Visible = false;

            btnActivityEdit.Enabled = btnActivityShow.Enabled = dgvActivities?.CurrentRow?.DataBoundItem != null;
        }

        private void btnFilterClear_Click(object sender, EventArgs e)
        {
            if(CurrentWorker == null)
              cbxWorker.SelectedIndex = -1;
            cbxStatus.SelectedIndex = -1;
            txbDescription.Text = string.Empty;
            txbResult.Text = string.Empty;
            nudSequenceNo.Value = 0;
            cbxActivityType.SelectedIndex = -1;
            dtrpCreateDate.Restart();
            dtrpEndDate.Restart();
        }

        private void dgvActivities_SelectionChanged(object sender, EventArgs e)
        {
            btnActivityEdit.Enabled = btnActivityShow.Enabled = dgvActivities?.CurrentRow?.DataBoundItem != null;
        }

        private void cbxActivityType_Click(object sender, EventArgs e)
        {
            var activityTypes = _requestManager.GetActivityTypes(null);
            cbxActivityType.DataSource = activityTypes;
            cbxActivityType.DisplayMember = "ActType";
        }

        private void cbxWorker_Click(object sender, EventArgs e)
        {
            Personel searchCriteria = new Personel()
            {
                Role = RoleEnum.WOR.ToString()
            };

            var workers = _personelManager.GetPersonel(searchCriteria);
            cbxWorker.DataSource = workers;
            cbxWorker.DisplayMember = "DisplayName";
        }

        private void btnActivityAdd_Click(object sender, EventArgs e)
        {
            ActivityRequestForm activityRequestForm = new ActivityRequestForm(FormModeEnum.Create, false, CurrentRequest);
            activityRequestForm.OnActivityTypesNeeded += ActivityRequestForm_OnActivityTypesNeeded;
            activityRequestForm.OnWorkersNeeded += ActivityRequestForm_OnWorkersNeeded;

            if (activityRequestForm.ShowDialog() != DialogResult.OK)
                return;

            _requestManager.AddActivity(activityRequestForm.Activity);
        }

        private void btnActivityEdit_Click(object sender, EventArgs e)
        {
            ActivityRequestForm activityRequestForm = new ActivityRequestForm(FormModeEnum.Edit, false, CurrentRequest, forWorker: CurrentWorker != null);
            activityRequestForm.Activity = (Activity)dgvActivities.CurrentRow.DataBoundItem;
            activityRequestForm.OnActivityTypesNeeded += ActivityRequestForm_OnActivityTypesNeeded;
            activityRequestForm.OnWorkersNeeded += ActivityRequestForm_OnWorkersNeeded;

            if (activityRequestForm.ShowDialog() != DialogResult.OK)
                return;

            _requestManager.EditActivity(activityRequestForm.Activity);
        }

        private IQueryable<Personel> ActivityRequestForm_OnWorkersNeeded()
        {
            return _personelManager.GetPersonel(new Personel() { Role = RoleEnum.WOR.ToString() });
        }

        private IQueryable<ActivityType> ActivityRequestForm_OnActivityTypesNeeded()
        {
            return _requestManager.GetActivityTypes(null);
        }

        private void btnActivityShow_Click(object sender, EventArgs e)
        {
            ActivityRequestForm activityRequestForm = new ActivityRequestForm(FormModeEnum.View, false, CurrentRequest);

            activityRequestForm.Activity = (Activity)dgvActivities.CurrentRow.DataBoundItem;

            activityRequestForm.ShowDialog();
        }
    }
}

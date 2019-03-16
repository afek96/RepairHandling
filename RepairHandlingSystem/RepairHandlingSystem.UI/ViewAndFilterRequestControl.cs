using System;
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
    public partial class ViewAndFilterRequestControl : UserControl
    {
        private RequestManager _requestManager;

        public Personel CurrentUser { get; set; }

        public event Action<Request> OnRequestSelected;

        private void CallOnRequestSelected(Request selectedRequest)
        {
            try
            {
                OnRequestSelected?.Invoke(selectedRequest);
            }
            catch (Exception ex) {}
        }

        public ViewAndFilterRequestControl()
        {
            InitializeComponent();
            dtrpCreateDate.Text = "Create Date:";
            dtrpEndDate.Text = "End Date:";
        }

        public void Initialize(RequestManager requestManager)
        {
            _requestManager = requestManager;

            cbxStatus.DataSource = Enum.GetValues(typeof(StatusEnum));
            cbxStatus.SelectedIndex = -1;
        }

        private void btnFilterClear_Click(object sender, EventArgs e)
        {
            cbxObject.SelectedIndex = -1;
            txbDescription.Text = string.Empty;
            txbResult.Text = string.Empty;
            cbxStatus.SelectedIndex = -1;
            dtrpCreateDate.Restart();
            dtrpEndDate.Restart();
        }

        private void btnFilterSearch_Click(object sender, EventArgs e)
        {
            Request searchCriteria = new Request()
            {
                CreateDateFrom = dtrpCreateDate.From,
                CreateDateTo = dtrpCreateDate.To,
                EndDateFrom = dtrpEndDate.From,
                EndDateTo = dtrpEndDate.To,
                Object = (DAL.Object)cbxObject.SelectedItem,
                Description = txbDescription.Text,
                Result = txbResult.Text,
                Personel = CurrentUser,
                Status = cbxStatus.SelectedText
            };

            dgvRequests.SelectionChanged -= new EventHandler(dgvRequests_SelectionChanged);
            dgvRequests.DataSource = _requestManager.GetRequests(searchCriteria);
            dgvRequests.SelectionChanged += new EventHandler(dgvRequests_SelectionChanged);

            dgvRequests.Columns["IdPersonel"].Visible = false;
            dgvRequests.Columns["IdObject"].Visible = false;
            dgvRequests.Columns["IdRequest"].Visible = false;
            dgvRequests.Columns["CreateDateFrom"].Visible = false;
            dgvRequests.Columns["CreateDateTo"].Visible = false;
            dgvRequests.Columns["EndDateFrom"].Visible = false;
            dgvRequests.Columns["EndDateTo"].Visible = false;

            CallOnRequestSelected((Request)dgvRequests?.CurrentRow?.DataBoundItem);
            btnRequestEdit.Enabled = btnRequestShow.Enabled = dgvRequests?.CurrentRow?.DataBoundItem != null;
        }

        private void dgvRequests_SelectionChanged(object sender, EventArgs e)
        {
            CallOnRequestSelected((Request)dgvRequests?.CurrentRow?.DataBoundItem);
            btnRequestEdit.Enabled = btnRequestShow.Enabled = dgvRequests?.CurrentRow?.DataBoundItem != null;
        }

        private void cbxObject_Click(object sender, EventArgs e)
        {
            var objects = _requestManager.GetObjects(null);
            cbxObject.DataSource = objects;
            cbxObject.DisplayMember = "DisplayName";
        }

        private void btnRequestEdit_Click(object sender, EventArgs e)
        {
            //TODO
        }

        private void btnRequestShow_Click(object sender, EventArgs e)
        {

        }
    }
}

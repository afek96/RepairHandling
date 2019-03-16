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

namespace RepairHandlingSystem.UI
{
    public partial class ViewAndFilterActivityControl : UserControl
    {
        private RequestManager _requestManager;

        public Request CurrentRequest { get; set; }

        public ViewAndFilterActivityControl()
        {
            InitializeComponent();
            dtrpCreateDate.Text = "Create Date:";
            dtrpEndDate.Text = "End Date:";
        }

        public void Initialize(RequestManager requestManager)
        {
            _requestManager = requestManager;
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
                Status = cbxStatus.SelectedText,
                ActivityType = (ActivityType)cbxActivityType.SelectedItem,
                Request = CurrentRequest,
                SequenceNo = (int)nudSequenceNo.Value
            };

            dgvActivities.SelectionChanged -= new EventHandler(dgvActivities_SelectionChanged);
            dgvActivities.DataSource = _requestManager.GetActivities(searchCriteria);
            dgvActivities.SelectionChanged += new EventHandler(dgvActivities_SelectionChanged);
        }

        private void btnFilterClear_Click(object sender, EventArgs e)
        {
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

        }
    }
}

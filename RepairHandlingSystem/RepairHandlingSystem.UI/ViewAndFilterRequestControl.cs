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
    public partial class ViewAndFilterRequestControl : UserControl
    {
        private RequestManager _requestManager;

        public Personel CurrentUser { get; set; }

        public ViewAndFilterRequestControl()
        {
            InitializeComponent();
            dtrpCreateDate.Text = "Create Date:";
            dtrpEndDate.Text = "End Date:";
        }

        public void Initialize(RequestManager requestManager)
        {
            _requestManager = requestManager;
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
        }

        private void dgvRequests_SelectionChanged(object sender, EventArgs e)
        {

        }
    }
}

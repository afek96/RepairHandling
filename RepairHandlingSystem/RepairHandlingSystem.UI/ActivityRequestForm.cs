using RepairHandlingSystem.Common;
using RepairHandlingSystem.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RepairHandlingSystem.UI
{
    public partial class ActivityRequestForm : Form
    {
        #region Private Fields

        private FormModeEnum _mode;
        private bool _forRequest;

        private int[] _rowsUnnecessaryForActivity = new int[] { 2, 1 };
        private int[] _rowsUnnecessaryForRequest = new int[] { 9, 8, 5, 4, 3, 2 };
        private int[] _rowsUnnecessaryForCreate = new int[] { 17, 16, 13, 12, 11, 10 };
        private int[] _rowsUnnecessaryForEdit = new int[] { 13, 12, 11, 10 };

        private int _rowsRemoved = 0;

        private Request _currentRequestForActivity = null;
        private Personel _currentUser;

        #endregion

        #region Events

        public event Func<IQueryable<DAL.Object>> OnObjectsNeeded;

        private IQueryable<DAL.Object> CallOnObjectsNeeded()
        {
            try
            {
                return OnObjectsNeeded?.Invoke();
            }
            catch (Exception)
            {
            }
            return null;
        }

        public event Func<IQueryable<Personel>> OnWorkersNeeded;

        private IQueryable<Personel> CallOnWorkersNeeded()
        {
            try
            {
                return OnWorkersNeeded?.Invoke();
            }
            catch (Exception)
            {
            }
            return null;
        }

        public event Func<IQueryable<ActivityType>> OnActivityTypesNeeded;

        private IQueryable<ActivityType> CallOnActivityTypesNeeded()
        {
            try
            {
                return OnActivityTypesNeeded?.Invoke();
            }
            catch (Exception)
            {
            }
            return null;
        }

        #endregion

        #region Properties

        private Activity _activity = new Activity();

        public Activity Activity
        {
            get => _activity;
            set
            {
                _activity = value;
                if (_mode != FormModeEnum.Create)
                    FillActivityData();
            }
        }

        private Request _request = new Request();

        public Request Request
        {
            get => _request;
            set
            {
                _request = value;
                if (_mode != FormModeEnum.Create)
                    FillRequestData();
            }
        }

        #endregion

        #region Constructors & Initialization

        public ActivityRequestForm()
        {
            InitializeComponent();
        }

        public ActivityRequestForm(FormModeEnum mode, bool forRequest, Request currentRequestForActivity = null, Personel currentUser = null)
        {
            _mode = mode;
            _forRequest = forRequest;
            _currentRequestForActivity = currentRequestForActivity;
            _currentUser = currentUser;
            InitializeComponent();

            if (_forRequest)
            {
                cbxPersonel.Enabled = false;
                Text = "RequestForm";
            }
            else
            {
                Text = "ActivityForm";
            }

            cbxStatus.DataSource = Enum.GetValues(typeof(StatusEnum));
            cbxStatus.SelectedIndex = -1;

            switch (_mode)
            {
                case FormModeEnum.Create:
                    InitCreateMode();
                    break;
                case FormModeEnum.Edit:
                    InitEditMode();
                    break;
                case FormModeEnum.View:
                    InitViewMode();
                    break;
            }

            InitTableLayoutPanel();

            if (currentRequestForActivity != null)
                txbRequest.Text = currentRequestForActivity.ToString();

            if (currentUser != null)
            {
                cbxPersonel.DataSource = new List<Personel>() { currentUser };
                cbxPersonel.DisplayMember = "DisplayName";
                cbxPersonel.Enabled = false;
            }
        }

        private void InitCreateMode()
        {
            btnAccept.Enabled = false;
            cbxStatus.SelectedIndex = cbxStatus.Items.IndexOf(StatusEnum.OPN);
            cbxStatus.Enabled = false;
        }

        private void InitEditMode()
        {
            btnAccept.Text = "Edit";
        }

        private void InitViewMode()
        {
            foreach (Control control in tlpMain.Controls)
            {
                if (control is Label || control is Button)
                    continue;

                control.Enabled = false;
            }

            btnAccept.Text = "Exit";
            btnCancel.Visible = false;
            tlpMain.SetColumnSpan(btnAccept, 3);
        }

        private void InitTableLayoutPanel()
        {
            if (_forRequest)
                HideRows(_rowsUnnecessaryForRequest);
            else
                HideRows(_rowsUnnecessaryForActivity);

            switch (_mode)
            {
                case FormModeEnum.Create:
                    HideRows(_rowsUnnecessaryForCreate);
                    break;
                case FormModeEnum.Edit:
                    HideRows(_rowsUnnecessaryForEdit);
                    break;
            }

            /** Wyjaśnienie poniższej linii kodu
             * tableLayoutPanel[tlpMain] ma jednen wiersz o wysokości 10px, a drugi wiersz ma domyślnie wielkość 44px razem mają 54px 
             * (2 usunięte wiersze[_rowsRemoved] mają 54px) 
             * skoro te wiersze stają się niewidoczne to możemy odjąć ich wysokość od wysokości kontorlki
             */
            Height -= _rowsRemoved / 2 * 54;
        }

        #endregion

        #region Event Handling

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (_mode == FormModeEnum.View)
                return;

            if (_forRequest)
            {
                Request.IdObject = ((DAL.Object)cbxObject.SelectedItem).IdObject;
                Request.IdPersonel = _currentUser.IdPersonel;
                Request.Description = txbDescription.Text;
                Request.Result = txbResult.Text;
                Request.Status = cbxStatus.SelectedText;
            }
            else
            {
                Activity.IdRequest = _currentRequestForActivity.IdRequest;
                Activity.SequenceNo = (int)nudSequenceNo.Value;
                Activity.IdPersonel = (cbxPersonel.SelectedItem as Personel)?.IdPersonel;
                Activity.Type = (cbxActivityType.SelectedItem as ActivityType).ActType;
                Activity.Description = txbDescription.Text;
                Activity.Result = txbResult.Text;
                Activity.Status = cbxStatus.SelectedItem.ToString();
            }
        }

        private void cbxObject_Click(object sender, EventArgs e)
        {
            if (!cbxObject.Enabled || cbxObject.Tag != null)
                return;

            cbxObject.DataSource = CallOnObjectsNeeded();
            cbxObject.DisplayMember = "DisplayName";
            cbxObject.Tag = true;
        }

        private void cbxPersonel_Click(object sender, EventArgs e)
        {
            if (!cbxPersonel.Enabled || cbxPersonel.Tag != null)
                return;

            cbxPersonel.DataSource = CallOnWorkersNeeded();
            cbxPersonel.DisplayMember = "DisplayName";
            cbxPersonel.Tag = true;
        }

        private void cbxActivityType_Click(object sender, EventArgs e)
        {
            if (!cbxActivityType.Enabled || cbxActivityType.Tag != null)
                return;

            cbxActivityType.DataSource = CallOnActivityTypesNeeded();
            cbxActivityType.DisplayMember = "ActType";
            cbxActivityType.Tag = true;
        }

        private void OnUserInputChanged(object sender, EventArgs e)
        {
            btnAccept.Enabled = IsNecessaryDataFilled() && IsStatusOrResultEditCorrect();
        }

        #endregion

        #region Private Methods

        private void FillActivityData()
        {
            cbxStatus.SelectedIndex = cbxStatus.Items.IndexOf((StatusEnum)Enum.Parse(typeof(StatusEnum), Activity.Status));
            txbRequest.Text = Activity.Request.ToString();
            nudSequenceNo.Value = Activity.SequenceNo ?? 0;
            cbxPersonel.DataSource = new List<Personel>() { Activity.Personel };
            cbxPersonel.DisplayMember = "DisplayName";
            cbxActivityType.DataSource = new List<ActivityType>() { Activity.ActivityType };
            cbxActivityType.DisplayMember = "ActType";
            txbStartDate.Text = Activity.CreateDate.ToString("dd/MM/yyyy HH:mm");
            txbEndDate.Text = Activity.EndDate?.ToString("dd/MM/yyyy HH:mm");
            txbDescription.Text = Activity.Description;
            txbResult.Text = Activity.Result;
        }

        private void FillRequestData()
        {
            cbxStatus.SelectedIndex = cbxStatus.Items.IndexOf((StatusEnum)Enum.Parse(typeof(StatusEnum), Request.Status));
            cbxObject.DataSource = new List<DAL.Object>() { Request.Object }; //cbxObject.Items.IndexOf(Request.Object);
            cbxObject.DisplayMember = "DisplayName";
            cbxPersonel.DataSource = new List<Personel>() { Request.Personel };
            cbxPersonel.DisplayMember = "DisplayName";
            txbStartDate.Text = Request.CreateDate.ToString("dd/MM/yyyy HH:mm");
            txbEndDate.Text = Request.EndDate?.ToString("dd/MM/yyyy HH:mm");
            txbDescription.Text = Request.Description;
            txbResult.Text = Request.Result;
            
        }

        private void HideRows(int[] rowArray)
        {
            foreach (var row in rowArray)
            {
                var tempControl = tlpMain.GetControlFromPosition(1, row);
                tempControl?.Hide();
                tempControl = tlpMain.GetControlFromPosition(3, row);
                tempControl?.Hide();
                var rowStyle = tlpMain.RowStyles[row];
                rowStyle.Height = 0;
            }

            _rowsRemoved += rowArray.Length;
        }

        private StatusEnum GetInitialStatus()
        {
            if (_mode == FormModeEnum.Create)
                return StatusEnum.OPN;

            return _forRequest ? (StatusEnum)Enum.Parse(typeof(StatusEnum), Request.Status) : (StatusEnum)Enum.Parse(typeof(StatusEnum), Activity.Status);
        }

        private bool IsStatusOrResultEditCorrect()
        {
            if (_mode != FormModeEnum.Edit)
                return true;

            bool result = false;

            switch ((StatusEnum)cbxStatus.SelectedItem)
            {
                case StatusEnum.OPN:
                    result = string.IsNullOrWhiteSpace(txbResult.Text);
                    break;
                case StatusEnum.PRO:
                    result = string.IsNullOrWhiteSpace(txbResult.Text);
                    break;
                case StatusEnum.CAN:
                    result = !string.IsNullOrWhiteSpace(txbResult.Text);
                    break;
                case StatusEnum.FIN:
                    result = true;
                    break;
            }

            return result && (int)GetInitialStatus() <= (int)cbxStatus.SelectedItem;
        }

        private bool IsNecessaryDataFilled()
        {
            return ((_forRequest && cbxObject.SelectedIndex != -1) || (!_forRequest && cbxActivityType.SelectedIndex != -1)) && !string.IsNullOrWhiteSpace(txbDescription.Text);
        }

        #endregion
    }
}

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
        private int[] _rowsUnnecessaryForCreate = new int[] { 19, 18, 17, 16, 13, 12, 11, 10 };
        private int[] _rowsUnnecessaryForEdit = new int[] { 13, 12, 11, 10 };

        private int _rowsRemoved = 0;

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

        public ActivityRequestForm(FormModeEnum mode, bool forRequest)
        {
            _mode = mode;
            _forRequest = forRequest;
            InitializeComponent();

            if (_forRequest)
                cbxPersonel.Enabled = false;

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
        }

        private void InitCreateMode() {}

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

        #region Private Methods

        private void FillActivityData()
        {
            txbRequest.Text = Activity.Request.ToString();
            nudSequenceNo.Value = Activity.SequenceNo ?? 0;
            cbxPersonel.SelectedIndex = cbxPersonel.Items.IndexOf(Activity.Personel);
            cbxActivityType.SelectedIndex = cbxActivityType.Items.IndexOf(Activity.Type);
            txbStartDate.Text = Activity.CreateDate.ToString("dd/MM/yyyy HH:mm");
            txbEndDate.Text = Activity.EndDate?.ToString("dd/MM/yyyy HH:mm");
            txbDescription.Text = Activity.Description;
            txbResult.Text = Activity.Result;
            cbxStatus.SelectedIndex = cbxStatus.Items.IndexOf((StatusEnum)Enum.Parse(typeof(StatusEnum), Activity.Status));
        }

        private void FillRequestData()
        {
            cbxObject.SelectedIndex = cbxObject.Items.IndexOf(Request.Object);
            cbxPersonel.SelectedIndex = cbxPersonel.Items.IndexOf(Request.Personel);
            txbStartDate.Text = Request.CreateDate.ToString("dd/MM/yyyy HH:mm");
            txbEndDate.Text = Request.EndDate?.ToString("dd/MM/yyyy HH:mm");
            txbDescription.Text = Request.Description;
            txbResult.Text = Request.Result;
            cbxStatus.SelectedIndex = cbxStatus.Items.IndexOf((StatusEnum)Enum.Parse(typeof(StatusEnum), Request.Status));
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

        #endregion
    }
}

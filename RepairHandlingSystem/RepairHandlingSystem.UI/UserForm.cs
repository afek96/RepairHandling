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
    public partial class UserForm : Form
    {
        #region Private Fields

        private FormModeEnum _mode;
        private bool _forPersonel;

        private int[] _rowsUnnecessaryForPersonel = new int[] { 19, 18, 17, 16, 7, 6 };
        private int[] _rowsUnnecessaryForPersonelInViewMode = new int[] { 5, 4, 3, 2 };
        private int[] _rowsUnnecessaryForClient = new int[] { 15, 14, 13, 12, 5, 4, 3, 2, 1, 0 };

        private int _rowsRemoved = 0;

        private AddressForm _addressForm;

        #endregion

        #region Properties

        private Client _client = new Client();

        public Client Client
        {
            get
            {
                return _client;
            }
            set
            {
                _client = value;
                if(_mode != FormModeEnum.Create)
                    FillClientData();
            }
        }

        private Personel _personel = new Personel();

        public Personel Personel
        {
            get
            {
                return _personel;
            }
            set
            {
                _personel = value;
                if (_mode != FormModeEnum.Create)
                    FillPersonelData();
            }
        }

        #endregion

        #region Constructors & Initialization

        public UserForm()
        {
            InitializeComponent();
        }

        public UserForm(FormModeEnum mode, bool forPersonel)
        {
            _mode = mode;
            _forPersonel = forPersonel;
            InitializeComponent();

            cbxRole.DataSource = Enum.GetValues(typeof(RoleEnum));
            cbxRole.SelectedIndex = -1;

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

            InitAddressForm();
        }

        private void InitCreateMode() {}

        private void InitEditMode()
        {
            txbUserName.Enabled = false;
            btnAccept.Text = "Edit";
            btnAddress.Text = "Edit Address Form";
        }

        private void InitViewMode()
        {
            btnAddress.Text = "Show Address Form";

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
            if (_forPersonel)
            {
                HideRows(_rowsUnnecessaryForPersonel);

                if (_mode == FormModeEnum.View)
                {
                    HideRows(_rowsUnnecessaryForPersonelInViewMode);
                }
            }
            else
            {
                HideRows(_rowsUnnecessaryForClient);
            }

            /** Wyjaśnienie poniższej linii kodu
             * tableLayoutPanel[tlpMain] ma jednen wiersz o wysokości 10px, a drugi wiersz ma domyślnie wielkość 41px razem mają 51px 
             * (2 usunięte wiersze[_rowsRemoved] mają 51px) 
             * skoro te wiersze stają się niewidoczne to możemy odjąć ich wysokość od wysokości kontorlki
             */
            Height -= _rowsRemoved / 2 * 51;
        }

        private void InitAddressForm()
        {
            if (_forPersonel)
                return;

            _addressForm = new AddressForm(_mode);
            _addressForm.Address = Client?.Address;
        }

        internal void DisableRoleChange()
        {
            cbxRole.Enabled = false;
        }

        #endregion

        #region Event Handling

        private void UserForm_Load(object sender, EventArgs e)
        {
            if(_mode != FormModeEnum.View)
                btnAccept.Enabled = AreAllVisibleTextBoxesFilled();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (_mode == FormModeEnum.View)
                return;

            if (_forPersonel)
            {
                Personel.UserName = txbUserName.Text;
                Personel.Password = txbPassword.Text;
                Personel.FirstName = txbFirstName.Text;
                Personel.LastName = txbLastName.Text;
                Personel.ExpiryDate = dtpExpiaryDate.Value;
                Personel.Role = cbxRole.SelectedValue.ToString();
            }
            else
            {
                Client.Name = txbName.Text;
                Client.FirstName = txbFirstName.Text;
                Client.LastName = txbLastName.Text;
                Client.PhoneNumber = txbPhoneNumber.Text;
            }
        }

        private void btnAddress_Click(object sender, EventArgs e)
        {
            if (_addressForm.ShowDialog() == DialogResult.OK)
                Client.Address = _addressForm.Address;
            else
                _addressForm.Address = Client.Address;
        }

        private void OnUserInputChanged(object sender, EventArgs e)
        {
            if (!(sender as Control).Visible)
                return;

            if (_forPersonel)
                btnAccept.Enabled = AreAllVisibleTextBoxesFilled() && txbPassword.Text == txbPasswordConfirm.Text && cbxRole.SelectedIndex != -1;
            else
                btnAccept.Enabled = ((!string.IsNullOrEmpty(txbFirstName.Text) && !string.IsNullOrEmpty(txbLastName.Text)) || !string.IsNullOrEmpty(txbName.Text)) && !string.IsNullOrEmpty(txbPhoneNumber.Text);
        }

        #endregion

        #region Private Methods

        private void FillPersonelData()
        {
            txbUserName.Text = Personel.UserName;
            txbFirstName.Text = Personel.FirstName;
            txbLastName.Text = Personel.LastName;
            dtpExpiaryDate.Value = Personel.ExpiryDate.HasValue ? Personel.ExpiryDate.Value : dtpExpiaryDate.MaxDate;
            cbxRole.SelectedIndex = cbxRole.Items.IndexOf((RoleEnum)Enum.Parse(typeof(RoleEnum), Personel.Role));
        }

        private void FillClientData()
        {
            txbName.Text = Client.Name;
            txbFirstName.Text = Client.FirstName;
            txbLastName.Text = Client.LastName;
            txbPhoneNumber.Text = Client.PhoneNumber;
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

        private bool AreAllVisibleTextBoxesFilled()
        {
            bool result = true;
            foreach (var txb in tlpMain.Controls.OfType<TextBox>())
            {
                if (!txb.Visible)
                    continue;

                if (string.IsNullOrEmpty(txb.Text))
                {
                    result = false;
                    break;
                }
            }
            return result;
        }

        #endregion
    }
}

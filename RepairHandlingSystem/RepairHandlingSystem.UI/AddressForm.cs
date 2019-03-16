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
    public partial class AddressForm : Form
    {
        #region Properties

        private Address _address = null;

        private FormModeEnum _mode;

        public Address Address
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
                if (_mode != FormModeEnum.Create)
                    FillAddressData();
            }
        }

        #endregion

        #region Constructors & Initalization

        public AddressForm()
        {
            InitializeComponent();
        }

        public AddressForm(FormModeEnum mode)
        {
            _mode = mode;
            InitializeComponent();

            switch (_mode)
            {
                case FormModeEnum.Create:
                    btnAccept.Enabled = false;
                    break;
                case FormModeEnum.Edit:
                    btnAccept.Text = "Edit";
                    btnAccept.Enabled = AreAllTextBoxFilled();
                    break;
                case FormModeEnum.View:
                    foreach (Control control in tlpMain.Controls)
                    {
                        if (control is Label || control is Button)
                            continue;

                        control.Enabled = false;
                    }

                    btnAccept.Text = "Exit";
                    btnCancel.Visible = false;
                    tlpMain.SetColumnSpan(btnAccept, 3);
                    break;
            }
        }

        #endregion

        #region Event Handling

        private void OnTextChanged(object sender, EventArgs e)
        {
            btnAccept.Enabled = AreAllTextBoxFilled();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            Address = new Address()
            {
                City = txbCity.Text,
                Street = txbStreet.Text,
                HouseNumber = txbHouseNumber.Text,
                PostalCode = txbPostalCode.Text
            };
        }

        #endregion

        #region Private Methods

        private bool AreAllTextBoxFilled()
        {
            bool result = true;
            foreach (var txb in tlpMain.Controls.OfType<TextBox>())
            {
                if (string.IsNullOrEmpty(txb.Text))
                {
                    result = false;
                    break;
                }
            }
            return result;
        }

        private void FillAddressData()
        {
            if (Address == null)
                return;

            txbCity.Text = Address.City;
            txbStreet.Text = Address.Street;
            txbHouseNumber.Text = Address.HouseNumber;
            txbPostalCode.Text = Address.PostalCode;
        }

        #endregion
    }
}

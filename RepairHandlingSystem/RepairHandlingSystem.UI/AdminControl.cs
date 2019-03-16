using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RepairHandlingSystem.Managers;
using static RepairHandlingSystem.DAL.Role;
using RepairHandlingSystem.DAL;
using RepairHandlingSystem.Common;

namespace RepairHandlingSystem.UI
{
    public partial class AdminControl : UserControl
    {
        private PersonelManager _personelManager = null;

        public Personel CurrentUser { get; set; }

        public AdminControl()
        {
            InitializeComponent();
            dtrpExpiryDate.Text = "Expiry Date:";
        }

        public void Initialize(PersonelManager personelManager)
        {
            _personelManager = personelManager;
            var allPersonel = _personelManager.GetPersonel(null);

            AutoCompleteStringCollection firstNameCollection = new AutoCompleteStringCollection();
            firstNameCollection.AddRange(allPersonel.Select(p => p.FirstName).Distinct().ToArray());
            cbxFirstName.AutoCompleteCustomSource = firstNameCollection;

            AutoCompleteStringCollection lastNameCollection = new AutoCompleteStringCollection();
            lastNameCollection.AddRange(allPersonel.Select(p => p.LastName).Distinct().ToArray());
            cbxLastName.AutoCompleteCustomSource = lastNameCollection;

            AutoCompleteStringCollection userNameCollection = new AutoCompleteStringCollection();
            userNameCollection.AddRange(allPersonel.Select(p => p.UserName).Distinct().ToArray());
            cbxUserName.AutoCompleteCustomSource = userNameCollection;

            cbxRole.DataSource = Enum.GetValues(typeof(RoleEnum));
            cbxRole.SelectedIndex = -1;
        }

        private void btnFilterSearch_Click(object sender, EventArgs e)
        {
            Personel searchCriteria = new Personel()
            {
                UserName = cbxUserName.Text,
                FirstName = cbxFirstName.Text,
                LastName = cbxLastName.Text,
                ExpiryDateTo = dtrpExpiryDate.To,
                ExpiryDateFrom = dtrpExpiryDate.From,
                Role = cbxRole.Text
            };

            dgvUsers.SelectionChanged -= new EventHandler(dgvUsers_SelectionChanged);
            dgvUsers.DataSource = _personelManager.GetPersonel(searchCriteria);
            dgvUsers.SelectionChanged += new EventHandler(dgvUsers_SelectionChanged);

            dgvUsers.Columns["DisplayName"].Visible = false;
            dgvUsers.Columns["IdPersonel"].Visible = false;
            dgvUsers.Columns["Password"].Visible = false;
            dgvUsers.Columns["Role1"].Visible = false;
            dgvUsers.Columns["ExpiryDateFrom"].Visible = false;
            dgvUsers.Columns["ExpiryDateTo"].Visible = false;

            btnUserEdit.Enabled = btnUserShowInfo.Enabled = dgvUsers.CurrentRow != null;
        }
        
        private void btnFilterClear_Click(object sender, EventArgs e)
        {
            cbxUserName.Text = string.Empty;
            cbxFirstName.Text = string.Empty;
            cbxLastName.Text = string.Empty;
            cbxRole.SelectedIndex = -1;
            dtrpExpiryDate.Restart();
        }

        private void btnUserAdd_Click(object sender, EventArgs e)
        {
            UserForm userForm = new UserForm(FormModeEnum.Create, true);

            if (userForm.ShowDialog() != DialogResult.OK)
                return;

            _personelManager.AddPersonel(userForm.Personel);
        }

        private void btnUserEdit_Click(object sender, EventArgs e)
        {
            UserForm userForm = new UserForm(FormModeEnum.Edit, true);

            userForm.Personel = (Personel)dgvUsers.CurrentRow.DataBoundItem;

            if (CurrentUser.IdPersonel == userForm.Personel.IdPersonel)
                userForm.DisableRoleChange();

            if (userForm.ShowDialog() != DialogResult.OK)
                return;

            _personelManager.EditPersonel(userForm.Personel);
        }

        private void btnUserShowInfo_Click(object sender, EventArgs e)
        {
            UserForm userForm = new UserForm(FormModeEnum.View, true);

            userForm.Personel = (Personel)dgvUsers.CurrentRow.DataBoundItem;

            userForm.ShowDialog();
        }

        private void dgvUsers_SelectionChanged(object sender, EventArgs e)
        {
            btnUserEdit.Enabled = btnUserShowInfo.Enabled = dgvUsers.CurrentRow != null;
        }
    }
}

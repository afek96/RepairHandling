using RepairHandlingSystem.Common;
using RepairHandlingSystem.DAL;
using RepairHandlingSystem.Managers;
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
    public partial class ObjectForm : Form
    {
        private RequestManager _requestManager;

        public ObjectForm()
        {
            InitializeComponent();
        }

        public ObjectForm(RequestManager requestManager)
        {
            InitializeComponent();
            _requestManager = requestManager;
        }

        private void cbxClient_Click(object sender, EventArgs e)
        {
            if (cbxClient.DataSource != null)
                return;

            var clients = _requestManager.GetClients(null);
            cbxClient.DataSource = clients;
            cbxClient.DisplayMember = "DisplayName";
        }

        private void cbxObjectType_Click(object sender, EventArgs e)
        {
            if (cbxObjectType.DataSource != null)
                return;

            var objectTypes = _requestManager.GetObjectTypes(null);
            cbxObjectType.DataSource = objectTypes;
            cbxObjectType.DisplayMember = "ObjType";
        }

        private void btnAddObject_Click(object sender, EventArgs e)
        {
            _requestManager.AddObject((Client)cbxClient.SelectedItem, (ObjectType)cbxObjectType.SelectedItem, txbDescription.Text);
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            UserForm userForm = new UserForm(FormModeEnum.Create, false);

            if (userForm.ShowDialog() != DialogResult.OK)
                return;

            _requestManager.AddClient(userForm.Client);
        }

        private void btnAddObjectType_Click(object sender, EventArgs e)
        {
            ObjectTypeForm objectTypeForm = new ObjectTypeForm();

            if (objectTypeForm.ShowDialog() != DialogResult.OK)
                return;

            _requestManager.AddObjectType(objectTypeForm.ObjectType);
        }

        private void OnUserValueInputChanged(object sender, EventArgs e)
        {
            btnAddObject.Enabled = cbxClient.SelectedIndex != -1 && cbxObjectType.SelectedIndex != -1 && txbDescription.Text.Length < 256;
        }
    }
}

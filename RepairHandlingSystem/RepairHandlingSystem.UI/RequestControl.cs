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
using RepairHandlingSystem.DAL;

namespace RepairHandlingSystem.UI
{
    public partial class RequestControl : UserControl
    {
        private RequestManager _requestManager;

        public RequestControl()
        {
            InitializeComponent();
        }

        public void Initialize(RequestManager requestManager)
        {
            _requestManager = requestManager;
        }

        private void cbxObject_Click(object sender, EventArgs e)
        {
            var objects = _requestManager.GetObjects(null);
            cbxObject.DataSource = objects;
            cbxObject.DisplayMember = "DisplayName";
        }

        private void cbxClient_Click(object sender, EventArgs e)
        {
            var clients = _requestManager.GetClients(null);
            cbxClient.DataSource = clients;
            cbxClient.DisplayMember = "DisplayName";
        }

        private void cbxObjectType_Click(object sender, EventArgs e)
        {
            var objectTypes = _requestManager.GetObjectTypes(null);
            cbxObjectType.DataSource = objectTypes;
            cbxObjectType.DisplayMember = "ObjType";
        }

        private void RequestControl_FontChanged(object sender, EventArgs e)
        {
            foreach (Control control in tlpMain.Controls)
            {
                control.Font = Font;
            }
        }

        private void btnAddObject_Click(object sender, EventArgs e)
        {
            _requestManager.AddObject((Client)cbxClient.SelectedItem, (ObjectType)cbxObjectType.SelectedItem, txbDescription.Text);
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            UserForm userForm = new UserForm(FormModeEnum.Create, false);

            if(userForm.ShowDialog() != DialogResult.OK)
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

        private void SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAddObject.Enabled = cbxClient.SelectedIndex != -1 && cbxObjectType.SelectedIndex != -1;
        }

        
    }
}

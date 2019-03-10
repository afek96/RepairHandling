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
    public partial class ObjectTypeForm : Form
    {
        public ObjectType ObjectType { get; private set; }

        public ObjectTypeForm()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            ObjectType = new ObjectType()
            {
                ObjType = txbObjectType.Text,
                Name = txbName.Text
            };
        }

        private void OnTextChanged(object sender, EventArgs e)
        {
            btnCreate.Enabled = AreAllTextBoxFilled();
        }

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
    }
}

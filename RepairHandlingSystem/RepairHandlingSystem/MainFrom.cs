using RepairHandlingSystem.DAL;
using RepairHandlingSystem.Managers;
using RepairHandlingSystem.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static RepairHandlingSystem.DAL.Role;

namespace RepairHandlingSystem
{
    public partial class MainFrom : Form
    {
        private PersonelManager _personelManager = null;
        private RequestManager _requestManager = null;

        public MainFrom()
        {
            InitializeComponent();

            _personelManager = new PersonelManager();

            _requestManager = new RequestManager();

            InitLoginControl(_personelManager);

            InitAdminControl(_personelManager);

            InitManagerControl(_requestManager);
        }

        private void InitManagerControl(RequestManager requestManager)
        {
            managerControl.Initialize(requestManager);
        }

        private void InitAdminControl(PersonelManager personelManager)
        {
            adminControl.Initialize(personelManager);
        }

        private void InitLoginControl(PersonelManager personelManager)
        {
            loginControl.Initialize(personelManager);
            loginControl.OnUserLoggedIn += LoginControl_OnUserLoggedIn;
            loginControl.OnUserLoggedOut += LoginControl_OnUserLoggedOut;
        }

        private void LoginControl_OnUserLoggedOut()
        {
            tcMain.Visible = false;
        }

        private void LoginControl_OnUserLoggedIn(Personel user)
        {
            var role = (RoleEnum)Enum.Parse(typeof(RoleEnum), user.Role);

            tcMain.Visible = true;
            switch (role)
            {
                case RoleEnum.ADM:
                    tcMain.SelectTab("tpAdmin");
                    adminControl.CurrentUser = user;
                    break;
                case RoleEnum.MAN:
                    tcMain.SelectTab("tpManager");
                    break;
                case RoleEnum.WOR:
                    tcMain.SelectTab("tpWorker");
                    break;
                default:
                    break;
            }
        }
     
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

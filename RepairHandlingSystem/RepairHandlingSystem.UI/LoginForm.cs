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
    public partial class LoginForm : Form
    {
        public string Login { get; set; }

        public string Password { get; set; }

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login = txbUserName.Text;
            Password = txbPassword.Text;
        }
    }
}

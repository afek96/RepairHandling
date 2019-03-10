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
using static RepairHandlingSystem.DAL.Role;

namespace RepairHandlingSystem.UI
{
    public partial class LoginControl : UserControl
    {
        private PersonelManager _personelManager = null;

        private Personel _currentUser;
        
        public Personel CurrentUser
        {
            get
            {
                return _currentUser;
            }
            set
            {
                _currentUser = value;

                if (value != null)
                {
                    btnLogin.Text = value.DisplayName;
                    CallOnUserLoggedIn(value);
                }
                else
                {
                    btnLogin.Text = "Zaloguj się";
                    CallOnUserLoggedOut();
                }
            }
        }

        public event Action<Personel> OnUserLoggedIn;

        private void CallOnUserLoggedIn(Personel user)
        {
            try
            {
                OnUserLoggedIn?.Invoke(user);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public event Action OnUserLoggedOut;

        private void CallOnUserLoggedOut()
        {
            try
            {
                OnUserLoggedOut?.Invoke();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public LoginControl()
        {
            InitializeComponent();
        }

        public void Initialize(PersonelManager personelManager)
        {
            _personelManager = personelManager;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (_personelManager == null)
                throw new Exception("Login Control is not initialized");

            if (CurrentUser != null)
            {
                CurrentUser = null;
                return;
            }

            LoginForm loginForm = new LoginForm();

            if (loginForm.ShowDialog() != DialogResult.OK)
                return;

            var personel = _personelManager.GetPersonelByUserName(loginForm.Login);
            if (_personelManager.CheckPassword(personel, loginForm.Password))
            {
                CurrentUser = personel;
            }
        }

        private void LoginControl_FontChanged(object sender, EventArgs e)
        {
            btnLogin.Font = Font;
        }
    }
}

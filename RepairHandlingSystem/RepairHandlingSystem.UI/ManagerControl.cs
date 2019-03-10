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

namespace RepairHandlingSystem.UI
{
    public partial class ManagerControl : UserControl
    {
        private RequestManager _requestManager;

        public ManagerControl()
        {
            InitializeComponent();
        }

        public void Initialize(RequestManager requestManager)
        {
            _requestManager = requestManager;
            requestControl.Initialize(requestManager);
        }
    }
}

﻿using System;
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
    public partial class ManagerControl : UserControl
    {
        private RequestManager _requestManager;

        public ManagerControl()
        {
            InitializeComponent();
        }

        public void Initialize(RequestManager requestManager, PersonelManager personelManager)
        {
            _requestManager = requestManager;
            vafRequestControl.OnRequestSelected += VafRequestControl_OnRequestSelected;
            vafRequestControl.Initialize(requestManager);
            vafActivityControl.Initialize(requestManager, personelManager);
        }

        private void VafRequestControl_OnRequestSelected(Request selectedRequest)
        {
            vafActivityControl.CurrentRequest = selectedRequest;
        }

        public void SetCurrentUser(Personel currentUser)
        {
            vafRequestControl.CurrentUser = currentUser;
        }
    }
}

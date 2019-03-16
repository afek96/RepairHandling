namespace RepairHandlingSystem.UI
{
    partial class ManagerControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvRequests = new System.Windows.Forms.DataGridView();
            this.dgvActivities = new System.Windows.Forms.DataGridView();
            this.requestControl = new RepairHandlingSystem.UI.RequestControl();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpAddRequest = new System.Windows.Forms.TabPage();
            this.tpActivity = new System.Windows.Forms.TabPage();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblObject = new System.Windows.Forms.Label();
            this.cbxStatus = new System.Windows.Forms.ComboBox();
            this.txbResult = new System.Windows.Forms.TextBox();
            this.txbDescription = new System.Windows.Forms.TextBox();
            this.cbxObject = new System.Windows.Forms.ComboBox();
            this.dateRangePickerControl1 = new RepairHandlingSystem.UI.DateTimeRangePickerControl();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivities)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tpAddRequest.SuspendLayout();
            this.tpActivity.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvRequests
            // 
            this.dgvRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRequests.Location = new System.Drawing.Point(6, 6);
            this.dgvRequests.Name = "dgvRequests";
            this.dgvRequests.Size = new System.Drawing.Size(240, 150);
            this.dgvRequests.TabIndex = 6;
            // 
            // dgvActivities
            // 
            this.dgvActivities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActivities.Location = new System.Drawing.Point(470, 6);
            this.dgvActivities.Name = "dgvActivities";
            this.dgvActivities.Size = new System.Drawing.Size(240, 150);
            this.dgvActivities.TabIndex = 7;
            // 
            // requestControl
            // 
            this.requestControl.CurrentUser = null;
            this.requestControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.requestControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.requestControl.Location = new System.Drawing.Point(3, 3);
            this.requestControl.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.requestControl.Name = "requestControl";
            this.requestControl.Size = new System.Drawing.Size(710, 366);
            this.requestControl.TabIndex = 8;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpAddRequest);
            this.tabControl1.Controls.Add(this.tpActivity);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(724, 398);
            this.tabControl1.TabIndex = 9;
            // 
            // tpAddRequest
            // 
            this.tpAddRequest.Controls.Add(this.requestControl);
            this.tpAddRequest.Location = new System.Drawing.Point(4, 22);
            this.tpAddRequest.Name = "tpAddRequest";
            this.tpAddRequest.Padding = new System.Windows.Forms.Padding(3);
            this.tpAddRequest.Size = new System.Drawing.Size(716, 372);
            this.tpAddRequest.TabIndex = 0;
            this.tpAddRequest.Text = "Add Request";
            this.tpAddRequest.UseVisualStyleBackColor = true;
            // 
            // tpActivity
            // 
            this.tpActivity.Controls.Add(this.dateRangePickerControl1);
            this.tpActivity.Controls.Add(this.lblStatus);
            this.tpActivity.Controls.Add(this.lblResult);
            this.tpActivity.Controls.Add(this.lblDescription);
            this.tpActivity.Controls.Add(this.lblObject);
            this.tpActivity.Controls.Add(this.cbxStatus);
            this.tpActivity.Controls.Add(this.txbResult);
            this.tpActivity.Controls.Add(this.txbDescription);
            this.tpActivity.Controls.Add(this.cbxObject);
            this.tpActivity.Controls.Add(this.dgvRequests);
            this.tpActivity.Controls.Add(this.dgvActivities);
            this.tpActivity.Location = new System.Drawing.Point(4, 22);
            this.tpActivity.Name = "tpActivity";
            this.tpActivity.Padding = new System.Windows.Forms.Padding(3);
            this.tpActivity.Size = new System.Drawing.Size(716, 372);
            this.tpActivity.TabIndex = 1;
            this.tpActivity.Text = "Manage";
            this.tpActivity.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(65, 254);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(40, 13);
            this.lblStatus.TabIndex = 15;
            this.lblStatus.Text = "Status:";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(65, 225);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(40, 13);
            this.lblResult.TabIndex = 14;
            this.lblResult.Text = "Result:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(65, 199);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(63, 13);
            this.lblDescription.TabIndex = 13;
            this.lblDescription.Text = "Description:";
            // 
            // lblObject
            // 
            this.lblObject.AutoSize = true;
            this.lblObject.Location = new System.Drawing.Point(65, 175);
            this.lblObject.Name = "lblObject";
            this.lblObject.Size = new System.Drawing.Size(41, 13);
            this.lblObject.TabIndex = 12;
            this.lblObject.Text = "Object:";
            // 
            // cbxStatus
            // 
            this.cbxStatus.FormattingEnabled = true;
            this.cbxStatus.Location = new System.Drawing.Point(125, 251);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(121, 21);
            this.cbxStatus.TabIndex = 11;
            // 
            // txbResult
            // 
            this.txbResult.Location = new System.Drawing.Point(146, 225);
            this.txbResult.Name = "txbResult";
            this.txbResult.Size = new System.Drawing.Size(100, 20);
            this.txbResult.TabIndex = 10;
            // 
            // txbDescription
            // 
            this.txbDescription.Location = new System.Drawing.Point(146, 199);
            this.txbDescription.Name = "txbDescription";
            this.txbDescription.Size = new System.Drawing.Size(100, 20);
            this.txbDescription.TabIndex = 9;
            // 
            // cbxObject
            // 
            this.cbxObject.FormattingEnabled = true;
            this.cbxObject.Location = new System.Drawing.Point(125, 172);
            this.cbxObject.Name = "cbxObject";
            this.cbxObject.Size = new System.Drawing.Size(121, 21);
            this.cbxObject.TabIndex = 8;
            // 
            // dateRangePickerControl1
            // 
            this.dateRangePickerControl1.Location = new System.Drawing.Point(6, 278);
            this.dateRangePickerControl1.Name = "dateRangePickerControl1";
            this.dateRangePickerControl1.Size = new System.Drawing.Size(240, 58);
            this.dateRangePickerControl1.TabIndex = 16;
            // 
            // ManagerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "ManagerControl";
            this.Size = new System.Drawing.Size(724, 398);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivities)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tpAddRequest.ResumeLayout(false);
            this.tpActivity.ResumeLayout(false);
            this.tpActivity.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvRequests;
        private System.Windows.Forms.DataGridView dgvActivities;
        private RequestControl requestControl;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpAddRequest;
        private System.Windows.Forms.TabPage tpActivity;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblObject;
        private System.Windows.Forms.ComboBox cbxStatus;
        private System.Windows.Forms.TextBox txbResult;
        private System.Windows.Forms.TextBox txbDescription;
        private System.Windows.Forms.ComboBox cbxObject;
        private DateTimeRangePickerControl dateRangePickerControl1;
    }
}

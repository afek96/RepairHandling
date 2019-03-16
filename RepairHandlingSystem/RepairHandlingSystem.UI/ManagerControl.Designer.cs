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
            this.dgvActivities = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpAddRequest = new System.Windows.Forms.TabPage();
            this.requestControl = new RepairHandlingSystem.UI.RequestControl();
            this.tpActivity = new System.Windows.Forms.TabPage();
            this.viewAndFilterRequestControl1 = new RepairHandlingSystem.UI.ViewAndFilterRequestControl();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivities)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tpAddRequest.SuspendLayout();
            this.tpActivity.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvActivities
            // 
            this.dgvActivities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActivities.Location = new System.Drawing.Point(582, 26);
            this.dgvActivities.Name = "dgvActivities";
            this.dgvActivities.Size = new System.Drawing.Size(240, 150);
            this.dgvActivities.TabIndex = 7;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpAddRequest);
            this.tabControl1.Controls.Add(this.tpActivity);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(986, 538);
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
            // requestControl
            // 
            this.requestControl.CurrentUser = null;
            this.requestControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.requestControl.Location = new System.Drawing.Point(3, 3);
            this.requestControl.Name = "requestControl";
            this.requestControl.Size = new System.Drawing.Size(710, 366);
            this.requestControl.TabIndex = 0;
            // 
            // tpActivity
            // 
            this.tpActivity.Controls.Add(this.viewAndFilterRequestControl1);
            this.tpActivity.Controls.Add(this.dgvActivities);
            this.tpActivity.Location = new System.Drawing.Point(4, 22);
            this.tpActivity.Name = "tpActivity";
            this.tpActivity.Padding = new System.Windows.Forms.Padding(3);
            this.tpActivity.Size = new System.Drawing.Size(978, 512);
            this.tpActivity.TabIndex = 1;
            this.tpActivity.Text = "Manage";
            this.tpActivity.UseVisualStyleBackColor = true;
            // 
            // viewAndFilterRequestControl1
            // 
            this.viewAndFilterRequestControl1.CurrentUser = null;
            this.viewAndFilterRequestControl1.Location = new System.Drawing.Point(6, 6);
            this.viewAndFilterRequestControl1.Name = "viewAndFilterRequestControl1";
            this.viewAndFilterRequestControl1.Size = new System.Drawing.Size(570, 444);
            this.viewAndFilterRequestControl1.TabIndex = 8;
            // 
            // ManagerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "ManagerControl";
            this.Size = new System.Drawing.Size(986, 538);
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivities)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tpAddRequest.ResumeLayout(false);
            this.tpActivity.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvActivities;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpAddRequest;
        private System.Windows.Forms.TabPage tpActivity;
        private RequestControl requestControl;
        private ViewAndFilterRequestControl viewAndFilterRequestControl1;
    }
}

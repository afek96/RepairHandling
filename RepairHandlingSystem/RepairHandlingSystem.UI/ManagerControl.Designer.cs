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
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvRequests;
        private System.Windows.Forms.DataGridView dgvActivities;
        private RequestControl requestControl;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpAddRequest;
        private System.Windows.Forms.TabPage tpActivity;
    }
}

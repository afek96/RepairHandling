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
            this.tlpSplit = new System.Windows.Forms.TableLayoutPanel();
            this.gbRequest = new System.Windows.Forms.GroupBox();
            this.vafRequestControl = new RepairHandlingSystem.UI.ViewAndFilterRequestControl();
            this.gbActivity = new System.Windows.Forms.GroupBox();
            this.vafActivityControl = new RepairHandlingSystem.UI.ViewAndFilterActivityControl();
            this.tlpSplit.SuspendLayout();
            this.gbRequest.SuspendLayout();
            this.gbActivity.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpSplit
            // 
            this.tlpSplit.ColumnCount = 2;
            this.tlpSplit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpSplit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpSplit.Controls.Add(this.gbRequest, 0, 0);
            this.tlpSplit.Controls.Add(this.gbActivity, 1, 0);
            this.tlpSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSplit.Location = new System.Drawing.Point(0, 0);
            this.tlpSplit.Name = "tlpSplit";
            this.tlpSplit.RowCount = 1;
            this.tlpSplit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpSplit.Size = new System.Drawing.Size(1175, 486);
            this.tlpSplit.TabIndex = 11;
            // 
            // gbRequest
            // 
            this.gbRequest.Controls.Add(this.vafRequestControl);
            this.gbRequest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbRequest.Location = new System.Drawing.Point(3, 3);
            this.gbRequest.Name = "gbRequest";
            this.gbRequest.Size = new System.Drawing.Size(581, 480);
            this.gbRequest.TabIndex = 10;
            this.gbRequest.TabStop = false;
            this.gbRequest.Text = "Request";
            // 
            // vafRequestControl
            // 
            this.vafRequestControl.CurrentUser = null;
            this.vafRequestControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vafRequestControl.Location = new System.Drawing.Point(3, 16);
            this.vafRequestControl.Name = "vafRequestControl";
            this.vafRequestControl.Size = new System.Drawing.Size(575, 461);
            this.vafRequestControl.TabIndex = 9;
            // 
            // gbActivity
            // 
            this.gbActivity.Controls.Add(this.vafActivityControl);
            this.gbActivity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbActivity.Location = new System.Drawing.Point(590, 3);
            this.gbActivity.Name = "gbActivity";
            this.gbActivity.Size = new System.Drawing.Size(582, 480);
            this.gbActivity.TabIndex = 11;
            this.gbActivity.TabStop = false;
            this.gbActivity.Text = "Activity";
            // 
            // vafActivityControl
            // 
            this.vafActivityControl.CurrentRequest = null;
            this.vafActivityControl.CurrentWorker = null;
            this.vafActivityControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vafActivityControl.Location = new System.Drawing.Point(3, 16);
            this.vafActivityControl.Name = "vafActivityControl";
            this.vafActivityControl.Size = new System.Drawing.Size(576, 461);
            this.vafActivityControl.TabIndex = 10;
            // 
            // ManagerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpSplit);
            this.Name = "ManagerControl";
            this.Size = new System.Drawing.Size(1175, 486);
            this.tlpSplit.ResumeLayout(false);
            this.gbRequest.ResumeLayout(false);
            this.gbActivity.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpSplit;
        private System.Windows.Forms.GroupBox gbRequest;
        private ViewAndFilterRequestControl vafRequestControl;
        private System.Windows.Forms.GroupBox gbActivity;
        private ViewAndFilterActivityControl vafActivityControl;
    }
}

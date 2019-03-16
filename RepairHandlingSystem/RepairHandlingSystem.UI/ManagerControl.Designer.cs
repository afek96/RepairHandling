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
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpAddRequest = new System.Windows.Forms.TabPage();
            this.requestControl = new RepairHandlingSystem.UI.RequestControl();
            this.tpActivity = new System.Windows.Forms.TabPage();
            this.tlpSplit = new System.Windows.Forms.TableLayoutPanel();
            this.vafActivityControl = new RepairHandlingSystem.UI.ViewAndFilterActivityControl();
            this.vafRequestControl = new RepairHandlingSystem.UI.ViewAndFilterRequestControl();
            this.tcMain.SuspendLayout();
            this.tpAddRequest.SuspendLayout();
            this.tpActivity.SuspendLayout();
            this.tlpSplit.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tpAddRequest);
            this.tcMain.Controls.Add(this.tpActivity);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.Location = new System.Drawing.Point(0, 0);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(1175, 486);
            this.tcMain.TabIndex = 9;
            // 
            // tpAddRequest
            // 
            this.tpAddRequest.Controls.Add(this.requestControl);
            this.tpAddRequest.Location = new System.Drawing.Point(4, 22);
            this.tpAddRequest.Name = "tpAddRequest";
            this.tpAddRequest.Padding = new System.Windows.Forms.Padding(3);
            this.tpAddRequest.Size = new System.Drawing.Size(1167, 460);
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
            this.requestControl.Size = new System.Drawing.Size(1161, 454);
            this.requestControl.TabIndex = 0;
            // 
            // tpActivity
            // 
            this.tpActivity.Controls.Add(this.tlpSplit);
            this.tpActivity.Location = new System.Drawing.Point(4, 22);
            this.tpActivity.Name = "tpActivity";
            this.tpActivity.Padding = new System.Windows.Forms.Padding(3);
            this.tpActivity.Size = new System.Drawing.Size(1167, 460);
            this.tpActivity.TabIndex = 1;
            this.tpActivity.Text = "Manage";
            this.tpActivity.UseVisualStyleBackColor = true;
            // 
            // tlpSplit
            // 
            this.tlpSplit.ColumnCount = 2;
            this.tlpSplit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpSplit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpSplit.Controls.Add(this.vafActivityControl, 1, 0);
            this.tlpSplit.Controls.Add(this.vafRequestControl, 0, 0);
            this.tlpSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSplit.Location = new System.Drawing.Point(3, 3);
            this.tlpSplit.Name = "tlpSplit";
            this.tlpSplit.RowCount = 1;
            this.tlpSplit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpSplit.Size = new System.Drawing.Size(1161, 454);
            this.tlpSplit.TabIndex = 10;
            // 
            // vafActivityControl
            // 
            this.vafActivityControl.CurrentRequest = null;
            this.vafActivityControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vafActivityControl.Location = new System.Drawing.Point(583, 3);
            this.vafActivityControl.Name = "vafActivityControl";
            this.vafActivityControl.Size = new System.Drawing.Size(575, 448);
            this.vafActivityControl.TabIndex = 9;
            // 
            // vafRequestControl
            // 
            this.vafRequestControl.CurrentUser = null;
            this.vafRequestControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vafRequestControl.Location = new System.Drawing.Point(3, 3);
            this.vafRequestControl.Name = "vafRequestControl";
            this.vafRequestControl.Size = new System.Drawing.Size(574, 448);
            this.vafRequestControl.TabIndex = 8;
            // 
            // ManagerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tcMain);
            this.Name = "ManagerControl";
            this.Size = new System.Drawing.Size(1175, 486);
            this.tcMain.ResumeLayout(false);
            this.tpAddRequest.ResumeLayout(false);
            this.tpActivity.ResumeLayout(false);
            this.tlpSplit.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tpAddRequest;
        private System.Windows.Forms.TabPage tpActivity;
        private RequestControl requestControl;
        private ViewAndFilterRequestControl vafRequestControl;
        private ViewAndFilterActivityControl vafActivityControl;
        private System.Windows.Forms.TableLayoutPanel tlpSplit;
    }
}

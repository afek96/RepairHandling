namespace RepairHandlingSystem
{
    partial class MainFrom
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.loginControl = new RepairHandlingSystem.UI.LoginControl();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpAdmin = new System.Windows.Forms.TabPage();
            this.adminControl = new RepairHandlingSystem.UI.AdminControl();
            this.tpManager = new System.Windows.Forms.TabPage();
            this.tpWorker = new System.Windows.Forms.TabPage();
            this.btnExit = new System.Windows.Forms.Button();
            this.managerControl = new RepairHandlingSystem.UI.ManagerControl();
            this.tlpMain.SuspendLayout();
            this.tcMain.SuspendLayout();
            this.tpAdmin.SuspendLayout();
            this.tpManager.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 9;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpMain.Controls.Add(this.loginControl, 1, 1);
            this.tlpMain.Controls.Add(this.tcMain, 1, 3);
            this.tlpMain.Controls.Add(this.btnExit, 7, 1);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 9;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.Size = new System.Drawing.Size(933, 550);
            this.tlpMain.TabIndex = 4;
            // 
            // loginControl
            // 
            this.tlpMain.SetColumnSpan(this.loginControl, 3);
            this.loginControl.CurrentUser = null;
            this.loginControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loginControl.Location = new System.Drawing.Point(18, 17);
            this.loginControl.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.loginControl.Name = "loginControl";
            this.loginControl.Size = new System.Drawing.Size(434, 111);
            this.loginControl.TabIndex = 3;
            // 
            // tcMain
            // 
            this.tcMain.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tlpMain.SetColumnSpan(this.tcMain, 7);
            this.tcMain.Controls.Add(this.tpAdmin);
            this.tcMain.Controls.Add(this.tpManager);
            this.tcMain.Controls.Add(this.tpWorker);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.ItemSize = new System.Drawing.Size(0, 1);
            this.tcMain.Location = new System.Drawing.Point(13, 148);
            this.tcMain.Name = "tcMain";
            this.tlpMain.SetRowSpan(this.tcMain, 5);
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(904, 389);
            this.tcMain.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tcMain.TabIndex = 5;
            this.tcMain.Visible = false;
            // 
            // tpAdmin
            // 
            this.tpAdmin.Controls.Add(this.adminControl);
            this.tpAdmin.Location = new System.Drawing.Point(4, 5);
            this.tpAdmin.Name = "tpAdmin";
            this.tpAdmin.Padding = new System.Windows.Forms.Padding(3);
            this.tpAdmin.Size = new System.Drawing.Size(896, 380);
            this.tpAdmin.TabIndex = 0;
            this.tpAdmin.Text = "Admin";
            this.tpAdmin.UseVisualStyleBackColor = true;
            // 
            // adminControl
            // 
            this.adminControl.CurrentUser = null;
            this.adminControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adminControl.Location = new System.Drawing.Point(3, 3);
            this.adminControl.Name = "adminControl";
            this.adminControl.Size = new System.Drawing.Size(890, 374);
            this.adminControl.TabIndex = 4;
            // 
            // tpManager
            // 
            this.tpManager.Controls.Add(this.managerControl);
            this.tpManager.Location = new System.Drawing.Point(4, 5);
            this.tpManager.Name = "tpManager";
            this.tpManager.Padding = new System.Windows.Forms.Padding(3);
            this.tpManager.Size = new System.Drawing.Size(896, 380);
            this.tpManager.TabIndex = 1;
            this.tpManager.Text = "Manager";
            this.tpManager.UseVisualStyleBackColor = true;
            // 
            // tpWorker
            // 
            this.tpWorker.Location = new System.Drawing.Point(4, 5);
            this.tpWorker.Name = "tpWorker";
            this.tpWorker.Size = new System.Drawing.Size(896, 374);
            this.tpWorker.TabIndex = 2;
            this.tpWorker.Text = "Worker";
            this.tpWorker.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnExit.Location = new System.Drawing.Point(703, 13);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(214, 119);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Wyjście";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // managerControl
            // 
            this.managerControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.managerControl.Location = new System.Drawing.Point(3, 3);
            this.managerControl.Name = "managerControl";
            this.managerControl.Size = new System.Drawing.Size(890, 374);
            this.managerControl.TabIndex = 0;
            // 
            // MainFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 550);
            this.ControlBox = false;
            this.Controls.Add(this.tlpMain);
            this.Name = "MainFrom";
            this.ShowIcon = false;
            this.Text = "RepairHandlingSystem";
            this.tlpMain.ResumeLayout(false);
            this.tcMain.ResumeLayout(false);
            this.tpAdmin.ResumeLayout(false);
            this.tpManager.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private UI.LoginControl loginControl;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private UI.AdminControl adminControl;
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tpAdmin;
        private System.Windows.Forms.TabPage tpManager;
        private System.Windows.Forms.TabPage tpWorker;
        private System.Windows.Forms.Button btnExit;
        private UI.ManagerControl managerControl;
    }
}


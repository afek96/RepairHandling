namespace RepairHandlingSystem.UI
{
    partial class AdminControl
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
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.tlpFilter = new System.Windows.Forms.TableLayoutPanel();
            this.gbUserName = new System.Windows.Forms.GroupBox();
            this.cbxUserName = new System.Windows.Forms.ComboBox();
            this.gbFirstName = new System.Windows.Forms.GroupBox();
            this.cbxFirstName = new System.Windows.Forms.ComboBox();
            this.gbLastName = new System.Windows.Forms.GroupBox();
            this.cbxLastName = new System.Windows.Forms.ComboBox();
            this.gbRole = new System.Windows.Forms.GroupBox();
            this.cbxRole = new System.Windows.Forms.ComboBox();
            this.btnFilterSearch = new System.Windows.Forms.Button();
            this.btnFilterClear = new System.Windows.Forms.Button();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.tlpButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnUserAdd = new System.Windows.Forms.Button();
            this.btnUserEdit = new System.Windows.Forms.Button();
            this.btnUserShowInfo = new System.Windows.Forms.Button();
            this.dtrpExpiryDate = new RepairHandlingSystem.UI.DateTimeRangePickerControl();
            this.tlpMain.SuspendLayout();
            this.gbFilter.SuspendLayout();
            this.tlpFilter.SuspendLayout();
            this.gbUserName.SuspendLayout();
            this.gbFirstName.SuspendLayout();
            this.gbLastName.SuspendLayout();
            this.gbRole.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.tlpButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.Controls.Add(this.gbFilter, 0, 0);
            this.tlpMain.Controls.Add(this.dgvUsers, 0, 2);
            this.tlpMain.Controls.Add(this.tlpButtons, 0, 4);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 6;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.Size = new System.Drawing.Size(813, 394);
            this.tlpMain.TabIndex = 1;
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.tlpFilter);
            this.gbFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbFilter.Location = new System.Drawing.Point(3, 3);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(807, 106);
            this.gbFilter.TabIndex = 5;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Filter";
            // 
            // tlpFilter
            // 
            this.tlpFilter.ColumnCount = 5;
            this.tlpFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpFilter.Controls.Add(this.gbUserName, 0, 0);
            this.tlpFilter.Controls.Add(this.gbFirstName, 1, 0);
            this.tlpFilter.Controls.Add(this.gbLastName, 2, 0);
            this.tlpFilter.Controls.Add(this.gbRole, 3, 0);
            this.tlpFilter.Controls.Add(this.btnFilterSearch, 0, 1);
            this.tlpFilter.Controls.Add(this.btnFilterClear, 3, 1);
            this.tlpFilter.Controls.Add(this.dtrpExpiryDate, 4, 0);
            this.tlpFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpFilter.Location = new System.Drawing.Point(3, 16);
            this.tlpFilter.Name = "tlpFilter";
            this.tlpFilter.RowCount = 2;
            this.tlpFilter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFilter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpFilter.Size = new System.Drawing.Size(801, 87);
            this.tlpFilter.TabIndex = 0;
            // 
            // gbUserName
            // 
            this.gbUserName.Controls.Add(this.cbxUserName);
            this.gbUserName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbUserName.Location = new System.Drawing.Point(3, 3);
            this.gbUserName.Name = "gbUserName";
            this.gbUserName.Size = new System.Drawing.Size(127, 51);
            this.gbUserName.TabIndex = 0;
            this.gbUserName.TabStop = false;
            this.gbUserName.Text = "UserName";
            // 
            // cbxUserName
            // 
            this.cbxUserName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbxUserName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbxUserName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxUserName.FormattingEnabled = true;
            this.cbxUserName.Location = new System.Drawing.Point(3, 16);
            this.cbxUserName.Name = "cbxUserName";
            this.cbxUserName.Size = new System.Drawing.Size(121, 21);
            this.cbxUserName.TabIndex = 0;
            // 
            // gbFirstName
            // 
            this.gbFirstName.Controls.Add(this.cbxFirstName);
            this.gbFirstName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbFirstName.Location = new System.Drawing.Point(136, 3);
            this.gbFirstName.Name = "gbFirstName";
            this.gbFirstName.Size = new System.Drawing.Size(127, 51);
            this.gbFirstName.TabIndex = 1;
            this.gbFirstName.TabStop = false;
            this.gbFirstName.Text = "FirstName";
            // 
            // cbxFirstName
            // 
            this.cbxFirstName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbxFirstName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbxFirstName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxFirstName.FormattingEnabled = true;
            this.cbxFirstName.Location = new System.Drawing.Point(3, 16);
            this.cbxFirstName.Name = "cbxFirstName";
            this.cbxFirstName.Size = new System.Drawing.Size(121, 21);
            this.cbxFirstName.TabIndex = 0;
            // 
            // gbLastName
            // 
            this.gbLastName.Controls.Add(this.cbxLastName);
            this.gbLastName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbLastName.Location = new System.Drawing.Point(269, 3);
            this.gbLastName.Name = "gbLastName";
            this.gbLastName.Size = new System.Drawing.Size(127, 51);
            this.gbLastName.TabIndex = 2;
            this.gbLastName.TabStop = false;
            this.gbLastName.Text = "LastName";
            // 
            // cbxLastName
            // 
            this.cbxLastName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbxLastName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbxLastName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxLastName.FormattingEnabled = true;
            this.cbxLastName.Location = new System.Drawing.Point(3, 16);
            this.cbxLastName.Name = "cbxLastName";
            this.cbxLastName.Size = new System.Drawing.Size(121, 21);
            this.cbxLastName.TabIndex = 0;
            // 
            // gbRole
            // 
            this.gbRole.Controls.Add(this.cbxRole);
            this.gbRole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbRole.Location = new System.Drawing.Point(402, 3);
            this.gbRole.Name = "gbRole";
            this.gbRole.Size = new System.Drawing.Size(127, 51);
            this.gbRole.TabIndex = 3;
            this.gbRole.TabStop = false;
            this.gbRole.Text = "Role";
            // 
            // cbxRole
            // 
            this.cbxRole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxRole.FormattingEnabled = true;
            this.cbxRole.Location = new System.Drawing.Point(3, 16);
            this.cbxRole.Name = "cbxRole";
            this.cbxRole.Size = new System.Drawing.Size(121, 21);
            this.cbxRole.TabIndex = 0;
            // 
            // btnFilterSearch
            // 
            this.tlpFilter.SetColumnSpan(this.btnFilterSearch, 3);
            this.btnFilterSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFilterSearch.Location = new System.Drawing.Point(3, 60);
            this.btnFilterSearch.Name = "btnFilterSearch";
            this.btnFilterSearch.Size = new System.Drawing.Size(393, 24);
            this.btnFilterSearch.TabIndex = 5;
            this.btnFilterSearch.Text = "Search";
            this.btnFilterSearch.UseVisualStyleBackColor = true;
            this.btnFilterSearch.Click += new System.EventHandler(this.btnFilterSearch_Click);
            // 
            // btnFilterClear
            // 
            this.tlpFilter.SetColumnSpan(this.btnFilterClear, 2);
            this.btnFilterClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFilterClear.Location = new System.Drawing.Point(402, 60);
            this.btnFilterClear.Name = "btnFilterClear";
            this.btnFilterClear.Size = new System.Drawing.Size(396, 24);
            this.btnFilterClear.TabIndex = 6;
            this.btnFilterClear.Text = "Clear";
            this.btnFilterClear.UseVisualStyleBackColor = true;
            this.btnFilterClear.Click += new System.EventHandler(this.btnFilterClear_Click);
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsers.Location = new System.Drawing.Point(3, 125);
            this.dgvUsers.MultiSelect = false;
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.Size = new System.Drawing.Size(807, 218);
            this.dgvUsers.TabIndex = 6;
            // 
            // tlpButtons
            // 
            this.tlpButtons.ColumnCount = 5;
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpButtons.Controls.Add(this.btnUserAdd, 0, 0);
            this.tlpButtons.Controls.Add(this.btnUserEdit, 2, 0);
            this.tlpButtons.Controls.Add(this.btnUserShowInfo, 4, 0);
            this.tlpButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpButtons.Location = new System.Drawing.Point(3, 359);
            this.tlpButtons.Name = "tlpButtons";
            this.tlpButtons.RowCount = 1;
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpButtons.Size = new System.Drawing.Size(807, 31);
            this.tlpButtons.TabIndex = 7;
            // 
            // btnUserAdd
            // 
            this.btnUserAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUserAdd.Location = new System.Drawing.Point(3, 3);
            this.btnUserAdd.Name = "btnUserAdd";
            this.btnUserAdd.Size = new System.Drawing.Size(249, 25);
            this.btnUserAdd.TabIndex = 0;
            this.btnUserAdd.Text = "Add User";
            this.btnUserAdd.UseVisualStyleBackColor = true;
            this.btnUserAdd.Click += new System.EventHandler(this.btnUserAdd_Click);
            // 
            // btnUserEdit
            // 
            this.btnUserEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUserEdit.Enabled = false;
            this.btnUserEdit.Location = new System.Drawing.Point(278, 3);
            this.btnUserEdit.Name = "btnUserEdit";
            this.btnUserEdit.Size = new System.Drawing.Size(249, 25);
            this.btnUserEdit.TabIndex = 1;
            this.btnUserEdit.Text = "Edit User";
            this.btnUserEdit.UseVisualStyleBackColor = true;
            this.btnUserEdit.Click += new System.EventHandler(this.btnUserEdit_Click);
            // 
            // btnUserShowInfo
            // 
            this.btnUserShowInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUserShowInfo.Enabled = false;
            this.btnUserShowInfo.Location = new System.Drawing.Point(553, 3);
            this.btnUserShowInfo.Name = "btnUserShowInfo";
            this.btnUserShowInfo.Size = new System.Drawing.Size(251, 25);
            this.btnUserShowInfo.TabIndex = 2;
            this.btnUserShowInfo.Text = "Show User Info";
            this.btnUserShowInfo.UseVisualStyleBackColor = true;
            this.btnUserShowInfo.Click += new System.EventHandler(this.btnUserShowInfo_Click);
            // 
            // dtrpExpiryDate
            // 
            this.dtrpExpiryDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtrpExpiryDate.Location = new System.Drawing.Point(535, 3);
            this.dtrpExpiryDate.Name = "dtrpExpiryDate";
            this.dtrpExpiryDate.Size = new System.Drawing.Size(263, 51);
            this.dtrpExpiryDate.TabIndex = 7;
            // 
            // AdminControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpMain);
            this.Name = "AdminControl";
            this.Size = new System.Drawing.Size(813, 394);
            this.tlpMain.ResumeLayout(false);
            this.gbFilter.ResumeLayout(false);
            this.tlpFilter.ResumeLayout(false);
            this.gbUserName.ResumeLayout(false);
            this.gbFirstName.ResumeLayout(false);
            this.gbLastName.ResumeLayout(false);
            this.gbRole.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.tlpButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.TableLayoutPanel tlpFilter;
        private System.Windows.Forms.GroupBox gbUserName;
        private System.Windows.Forms.GroupBox gbFirstName;
        private System.Windows.Forms.GroupBox gbLastName;
        private System.Windows.Forms.GroupBox gbRole;
        private System.Windows.Forms.ComboBox cbxUserName;
        private System.Windows.Forms.ComboBox cbxFirstName;
        private System.Windows.Forms.ComboBox cbxLastName;
        private System.Windows.Forms.ComboBox cbxRole;
        private System.Windows.Forms.Button btnFilterSearch;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.TableLayoutPanel tlpButtons;
        private System.Windows.Forms.Button btnUserAdd;
        private System.Windows.Forms.Button btnUserEdit;
        private System.Windows.Forms.Button btnUserShowInfo;
        private System.Windows.Forms.Button btnFilterClear;
        private DateTimeRangePickerControl dtrpExpiryDate;
    }
}

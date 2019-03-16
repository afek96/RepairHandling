namespace RepairHandlingSystem.UI
{
    partial class ViewAndFilterRequestControl
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
            this.lblDescription = new System.Windows.Forms.Label();
            this.txbResult = new System.Windows.Forms.TextBox();
            this.dgvRequests = new System.Windows.Forms.DataGridView();
            this.cbxObject = new System.Windows.Forms.ComboBox();
            this.txbDescription = new System.Windows.Forms.TextBox();
            this.cbxStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblObject = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.dtrpCreateDate = new RepairHandlingSystem.UI.DateTimeRangePickerControl();
            this.dtrpEndDate = new RepairHandlingSystem.UI.DateTimeRangePickerControl();
            this.btnFilterSearch = new System.Windows.Forms.Button();
            this.btnFilterClear = new System.Windows.Forms.Button();
            this.tlpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequests)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 5;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 11F));
            this.tlpMain.Controls.Add(this.lblDescription, 1, 5);
            this.tlpMain.Controls.Add(this.txbResult, 3, 7);
            this.tlpMain.Controls.Add(this.dgvRequests, 1, 1);
            this.tlpMain.Controls.Add(this.cbxObject, 3, 3);
            this.tlpMain.Controls.Add(this.txbDescription, 3, 5);
            this.tlpMain.Controls.Add(this.cbxStatus, 3, 9);
            this.tlpMain.Controls.Add(this.lblStatus, 1, 9);
            this.tlpMain.Controls.Add(this.lblObject, 1, 3);
            this.tlpMain.Controls.Add(this.lblResult, 1, 7);
            this.tlpMain.Controls.Add(this.dtrpCreateDate, 1, 11);
            this.tlpMain.Controls.Add(this.dtrpEndDate, 3, 11);
            this.tlpMain.Controls.Add(this.btnFilterSearch, 1, 13);
            this.tlpMain.Controls.Add(this.btnFilterClear, 3, 13);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 16;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.2963F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.407407F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.407407F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.407407F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.407407F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.407407F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.Size = new System.Drawing.Size(575, 444);
            this.tlpMain.TabIndex = 0;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDescription.Location = new System.Drawing.Point(13, 224);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(266, 26);
            this.lblDescription.TabIndex = 24;
            this.lblDescription.Text = "Description:";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txbResult
            // 
            this.txbResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbResult.Location = new System.Drawing.Point(295, 263);
            this.txbResult.MaxLength = 1024;
            this.txbResult.Name = "txbResult";
            this.txbResult.Size = new System.Drawing.Size(266, 20);
            this.txbResult.TabIndex = 21;
            // 
            // dgvRequests
            // 
            this.dgvRequests.AllowUserToAddRows = false;
            this.dgvRequests.AllowUserToDeleteRows = false;
            this.dgvRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tlpMain.SetColumnSpan(this.dgvRequests, 3);
            this.dgvRequests.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRequests.Location = new System.Drawing.Point(13, 13);
            this.dgvRequests.MultiSelect = false;
            this.dgvRequests.Name = "dgvRequests";
            this.dgvRequests.ReadOnly = true;
            this.dgvRequests.Size = new System.Drawing.Size(548, 162);
            this.dgvRequests.TabIndex = 18;
            this.dgvRequests.SelectionChanged += new System.EventHandler(this.dgvRequests_SelectionChanged);
            // 
            // cbxObject
            // 
            this.cbxObject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxObject.FormattingEnabled = true;
            this.cbxObject.Location = new System.Drawing.Point(295, 191);
            this.cbxObject.Name = "cbxObject";
            this.cbxObject.Size = new System.Drawing.Size(266, 21);
            this.cbxObject.TabIndex = 19;
            // 
            // txbDescription
            // 
            this.txbDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbDescription.Location = new System.Drawing.Point(295, 227);
            this.txbDescription.MaxLength = 1024;
            this.txbDescription.Name = "txbDescription";
            this.txbDescription.Size = new System.Drawing.Size(266, 20);
            this.txbDescription.TabIndex = 20;
            // 
            // cbxStatus
            // 
            this.cbxStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxStatus.FormattingEnabled = true;
            this.cbxStatus.Location = new System.Drawing.Point(295, 299);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(266, 21);
            this.cbxStatus.TabIndex = 22;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStatus.Location = new System.Drawing.Point(13, 296);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(266, 26);
            this.lblStatus.TabIndex = 26;
            this.lblStatus.Text = "Status:";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblObject
            // 
            this.lblObject.AutoSize = true;
            this.lblObject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblObject.Location = new System.Drawing.Point(13, 188);
            this.lblObject.Name = "lblObject";
            this.lblObject.Size = new System.Drawing.Size(266, 26);
            this.lblObject.TabIndex = 23;
            this.lblObject.Text = "Object:";
            this.lblObject.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblResult.Location = new System.Drawing.Point(13, 260);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(266, 26);
            this.lblResult.TabIndex = 25;
            this.lblResult.Text = "Result:";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtrpCreateDate
            // 
            this.dtrpCreateDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtrpCreateDate.Location = new System.Drawing.Point(13, 335);
            this.dtrpCreateDate.Name = "dtrpCreateDate";
            this.dtrpCreateDate.Size = new System.Drawing.Size(266, 54);
            this.dtrpCreateDate.TabIndex = 27;
            // 
            // dtrpEndDate
            // 
            this.dtrpEndDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtrpEndDate.Location = new System.Drawing.Point(295, 335);
            this.dtrpEndDate.Name = "dtrpEndDate";
            this.dtrpEndDate.Size = new System.Drawing.Size(266, 54);
            this.dtrpEndDate.TabIndex = 28;
            // 
            // btnFilterSearch
            // 
            this.btnFilterSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFilterSearch.Location = new System.Drawing.Point(13, 405);
            this.btnFilterSearch.Name = "btnFilterSearch";
            this.btnFilterSearch.Size = new System.Drawing.Size(266, 20);
            this.btnFilterSearch.TabIndex = 29;
            this.btnFilterSearch.Text = "Search";
            this.btnFilterSearch.UseVisualStyleBackColor = true;
            this.btnFilterSearch.Click += new System.EventHandler(this.btnFilterSearch_Click);
            // 
            // btnFilterClear
            // 
            this.btnFilterClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFilterClear.Location = new System.Drawing.Point(295, 405);
            this.btnFilterClear.Name = "btnFilterClear";
            this.btnFilterClear.Size = new System.Drawing.Size(266, 20);
            this.btnFilterClear.TabIndex = 30;
            this.btnFilterClear.Text = "Clear";
            this.btnFilterClear.UseVisualStyleBackColor = true;
            this.btnFilterClear.Click += new System.EventHandler(this.btnFilterClear_Click);
            // 
            // ViewAndFilterRequestControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpMain);
            this.Name = "ViewAndFilterRequestControl";
            this.Size = new System.Drawing.Size(575, 444);
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequests)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private DateTimeRangePickerControl dtrpEndDate;
        private DateTimeRangePickerControl dtrpCreateDate;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblObject;
        private System.Windows.Forms.ComboBox cbxStatus;
        private System.Windows.Forms.TextBox txbResult;
        private System.Windows.Forms.TextBox txbDescription;
        private System.Windows.Forms.ComboBox cbxObject;
        private System.Windows.Forms.DataGridView dgvRequests;
        private System.Windows.Forms.Button btnFilterSearch;
        private System.Windows.Forms.Button btnFilterClear;
    }
}

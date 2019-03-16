namespace RepairHandlingSystem.UI
{
    partial class ViewAndFilterActivityControl
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
            this.dgvActivities = new System.Windows.Forms.DataGridView();
            this.cbxWorker = new System.Windows.Forms.ComboBox();
            this.txbDescription = new System.Windows.Forms.TextBox();
            this.lblWorker = new System.Windows.Forms.Label();
            this.btnFilterSearch = new System.Windows.Forms.Button();
            this.btnFilterClear = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.txbResult = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cbxStatus = new System.Windows.Forms.ComboBox();
            this.nudSequenceNo = new System.Windows.Forms.NumericUpDown();
            this.lblSequenceNo = new System.Windows.Forms.Label();
            this.lblActivityType = new System.Windows.Forms.Label();
            this.cbxActivityType = new System.Windows.Forms.ComboBox();
            this.btnActivityAdd = new System.Windows.Forms.Button();
            this.btnActivityEdit = new System.Windows.Forms.Button();
            this.dtrpEndDate = new RepairHandlingSystem.UI.DateTimeRangePickerControl();
            this.dtrpCreateDate = new RepairHandlingSystem.UI.DateTimeRangePickerControl();
            this.tlpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivities)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSequenceNo)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 10;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpMain.Controls.Add(this.lblDescription, 1, 5);
            this.tlpMain.Controls.Add(this.dgvActivities, 1, 1);
            this.tlpMain.Controls.Add(this.cbxWorker, 3, 3);
            this.tlpMain.Controls.Add(this.txbDescription, 3, 5);
            this.tlpMain.Controls.Add(this.lblWorker, 1, 3);
            this.tlpMain.Controls.Add(this.btnFilterSearch, 1, 11);
            this.tlpMain.Controls.Add(this.btnFilterClear, 3, 11);
            this.tlpMain.Controls.Add(this.lblResult, 5, 5);
            this.tlpMain.Controls.Add(this.txbResult, 7, 5);
            this.tlpMain.Controls.Add(this.lblStatus, 5, 3);
            this.tlpMain.Controls.Add(this.cbxStatus, 7, 3);
            this.tlpMain.Controls.Add(this.dtrpEndDate, 5, 9);
            this.tlpMain.Controls.Add(this.dtrpCreateDate, 1, 9);
            this.tlpMain.Controls.Add(this.nudSequenceNo, 3, 7);
            this.tlpMain.Controls.Add(this.lblSequenceNo, 1, 7);
            this.tlpMain.Controls.Add(this.lblActivityType, 5, 7);
            this.tlpMain.Controls.Add(this.cbxActivityType, 7, 7);
            this.tlpMain.Controls.Add(this.btnActivityAdd, 5, 11);
            this.tlpMain.Controls.Add(this.btnActivityEdit, 7, 11);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 14;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.999999F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.999999F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.999999F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.999999F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.Size = new System.Drawing.Size(576, 444);
            this.tlpMain.TabIndex = 1;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDescription.Location = new System.Drawing.Point(13, 246);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(125, 29);
            this.lblDescription.TabIndex = 24;
            this.lblDescription.Text = "Description:";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgvActivities
            // 
            this.dgvActivities.AllowUserToAddRows = false;
            this.dgvActivities.AllowUserToDeleteRows = false;
            this.dgvActivities.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvActivities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tlpMain.SetColumnSpan(this.dgvActivities, 7);
            this.dgvActivities.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvActivities.Location = new System.Drawing.Point(13, 13);
            this.dgvActivities.MultiSelect = false;
            this.dgvActivities.Name = "dgvActivities";
            this.dgvActivities.ReadOnly = true;
            this.dgvActivities.Size = new System.Drawing.Size(548, 181);
            this.dgvActivities.TabIndex = 18;
            this.dgvActivities.SelectionChanged += new System.EventHandler(this.dgvActivities_SelectionChanged);
            // 
            // cbxWorker
            // 
            this.cbxWorker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxWorker.FormattingEnabled = true;
            this.cbxWorker.Location = new System.Drawing.Point(154, 210);
            this.cbxWorker.Name = "cbxWorker";
            this.cbxWorker.Size = new System.Drawing.Size(125, 21);
            this.cbxWorker.TabIndex = 19;
            this.cbxWorker.Click += new System.EventHandler(this.cbxWorker_Click);
            // 
            // txbDescription
            // 
            this.txbDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbDescription.Location = new System.Drawing.Point(154, 249);
            this.txbDescription.MaxLength = 1024;
            this.txbDescription.Name = "txbDescription";
            this.txbDescription.Size = new System.Drawing.Size(125, 20);
            this.txbDescription.TabIndex = 20;
            // 
            // lblWorker
            // 
            this.lblWorker.AutoSize = true;
            this.lblWorker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWorker.Location = new System.Drawing.Point(13, 207);
            this.lblWorker.Name = "lblWorker";
            this.lblWorker.Size = new System.Drawing.Size(125, 29);
            this.lblWorker.TabIndex = 23;
            this.lblWorker.Text = "Worker:";
            this.lblWorker.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnFilterSearch
            // 
            this.btnFilterSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFilterSearch.Enabled = false;
            this.btnFilterSearch.Location = new System.Drawing.Point(13, 404);
            this.btnFilterSearch.Name = "btnFilterSearch";
            this.btnFilterSearch.Size = new System.Drawing.Size(125, 23);
            this.btnFilterSearch.TabIndex = 29;
            this.btnFilterSearch.Text = "Search";
            this.btnFilterSearch.UseVisualStyleBackColor = true;
            this.btnFilterSearch.Click += new System.EventHandler(this.btnFilterSearch_Click);
            // 
            // btnFilterClear
            // 
            this.btnFilterClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFilterClear.Location = new System.Drawing.Point(154, 404);
            this.btnFilterClear.Name = "btnFilterClear";
            this.btnFilterClear.Size = new System.Drawing.Size(125, 23);
            this.btnFilterClear.TabIndex = 30;
            this.btnFilterClear.Text = "Clear";
            this.btnFilterClear.UseVisualStyleBackColor = true;
            this.btnFilterClear.Click += new System.EventHandler(this.btnFilterClear_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblResult.Location = new System.Drawing.Point(295, 246);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(125, 29);
            this.lblResult.TabIndex = 25;
            this.lblResult.Text = "Result:";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txbResult
            // 
            this.txbResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbResult.Location = new System.Drawing.Point(436, 249);
            this.txbResult.MaxLength = 1024;
            this.txbResult.Name = "txbResult";
            this.txbResult.Size = new System.Drawing.Size(125, 20);
            this.txbResult.TabIndex = 21;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStatus.Location = new System.Drawing.Point(295, 207);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(125, 29);
            this.lblStatus.TabIndex = 26;
            this.lblStatus.Text = "Status:";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxStatus
            // 
            this.cbxStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxStatus.FormattingEnabled = true;
            this.cbxStatus.Location = new System.Drawing.Point(436, 210);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(125, 21);
            this.cbxStatus.TabIndex = 22;
            // 
            // nudSequenceNo
            // 
            this.nudSequenceNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudSequenceNo.Location = new System.Drawing.Point(154, 288);
            this.nudSequenceNo.Name = "nudSequenceNo";
            this.nudSequenceNo.Size = new System.Drawing.Size(125, 20);
            this.nudSequenceNo.TabIndex = 31;
            // 
            // lblSequenceNo
            // 
            this.lblSequenceNo.AutoSize = true;
            this.lblSequenceNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSequenceNo.Location = new System.Drawing.Point(13, 285);
            this.lblSequenceNo.Name = "lblSequenceNo";
            this.lblSequenceNo.Size = new System.Drawing.Size(125, 29);
            this.lblSequenceNo.TabIndex = 32;
            this.lblSequenceNo.Text = "Sequence No:";
            this.lblSequenceNo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblActivityType
            // 
            this.lblActivityType.AutoSize = true;
            this.lblActivityType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblActivityType.Location = new System.Drawing.Point(295, 285);
            this.lblActivityType.Name = "lblActivityType";
            this.lblActivityType.Size = new System.Drawing.Size(125, 29);
            this.lblActivityType.TabIndex = 33;
            this.lblActivityType.Text = "Activity Type:";
            this.lblActivityType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxActivityType
            // 
            this.cbxActivityType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxActivityType.FormattingEnabled = true;
            this.cbxActivityType.Location = new System.Drawing.Point(436, 288);
            this.cbxActivityType.Name = "cbxActivityType";
            this.cbxActivityType.Size = new System.Drawing.Size(125, 21);
            this.cbxActivityType.TabIndex = 34;
            this.cbxActivityType.Click += new System.EventHandler(this.cbxActivityType_Click);
            // 
            // btnActivityAdd
            // 
            this.btnActivityAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnActivityAdd.Enabled = false;
            this.btnActivityAdd.Location = new System.Drawing.Point(295, 404);
            this.btnActivityAdd.Name = "btnActivityAdd";
            this.btnActivityAdd.Size = new System.Drawing.Size(125, 23);
            this.btnActivityAdd.TabIndex = 35;
            this.btnActivityAdd.Text = "Add Activity";
            this.btnActivityAdd.UseVisualStyleBackColor = true;
            // 
            // btnActivityEdit
            // 
            this.btnActivityEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnActivityEdit.Enabled = false;
            this.btnActivityEdit.Location = new System.Drawing.Point(436, 404);
            this.btnActivityEdit.Name = "btnActivityEdit";
            this.btnActivityEdit.Size = new System.Drawing.Size(125, 23);
            this.btnActivityEdit.TabIndex = 36;
            this.btnActivityEdit.Text = "Edit Activity";
            this.btnActivityEdit.UseVisualStyleBackColor = true;
            // 
            // dtrpEndDate
            // 
            this.tlpMain.SetColumnSpan(this.dtrpEndDate, 3);
            this.dtrpEndDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtrpEndDate.Location = new System.Drawing.Point(295, 327);
            this.dtrpEndDate.Name = "dtrpEndDate";
            this.dtrpEndDate.Size = new System.Drawing.Size(266, 61);
            this.dtrpEndDate.TabIndex = 28;
            // 
            // dtrpCreateDate
            // 
            this.tlpMain.SetColumnSpan(this.dtrpCreateDate, 3);
            this.dtrpCreateDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtrpCreateDate.Location = new System.Drawing.Point(13, 327);
            this.dtrpCreateDate.Name = "dtrpCreateDate";
            this.dtrpCreateDate.Size = new System.Drawing.Size(266, 61);
            this.dtrpCreateDate.TabIndex = 27;
            // 
            // ViewAndFilterActivityControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpMain);
            this.Name = "ViewAndFilterActivityControl";
            this.Size = new System.Drawing.Size(576, 444);
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivities)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSequenceNo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txbResult;
        private System.Windows.Forms.DataGridView dgvActivities;
        private System.Windows.Forms.ComboBox cbxWorker;
        private System.Windows.Forms.TextBox txbDescription;
        private System.Windows.Forms.ComboBox cbxStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblWorker;
        private System.Windows.Forms.Label lblResult;
        private DateTimeRangePickerControl dtrpCreateDate;
        private DateTimeRangePickerControl dtrpEndDate;
        private System.Windows.Forms.Button btnFilterSearch;
        private System.Windows.Forms.Button btnFilterClear;
        private System.Windows.Forms.NumericUpDown nudSequenceNo;
        private System.Windows.Forms.Label lblSequenceNo;
        private System.Windows.Forms.Label lblActivityType;
        private System.Windows.Forms.ComboBox cbxActivityType;
        private System.Windows.Forms.Button btnActivityAdd;
        private System.Windows.Forms.Button btnActivityEdit;
    }
}

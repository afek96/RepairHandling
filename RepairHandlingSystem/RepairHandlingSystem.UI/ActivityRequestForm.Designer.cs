namespace RepairHandlingSystem.UI
{
    partial class ActivityRequestForm
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
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblObject = new System.Windows.Forms.Label();
            this.lblRequest = new System.Windows.Forms.Label();
            this.lblSequenceNo = new System.Windows.Forms.Label();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txbRequest = new System.Windows.Forms.TextBox();
            this.lblActivityType = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblPersonel = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txbResult = new System.Windows.Forms.TextBox();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.cbxObject = new System.Windows.Forms.ComboBox();
            this.nudSequenceNo = new System.Windows.Forms.NumericUpDown();
            this.cbxPersonel = new System.Windows.Forms.ComboBox();
            this.cbxActivityType = new System.Windows.Forms.ComboBox();
            this.txbDescription = new System.Windows.Forms.TextBox();
            this.cbxStatus = new System.Windows.Forms.ComboBox();
            this.txbStartDate = new System.Windows.Forms.TextBox();
            this.txbEndDate = new System.Windows.Forms.TextBox();
            this.tlpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSequenceNo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblEndDate.Location = new System.Drawing.Point(13, 334);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblEndDate.Size = new System.Drawing.Size(213, 44);
            this.lblEndDate.TabIndex = 12;
            this.lblEndDate.Text = "End Date:";
            this.lblEndDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblObject
            // 
            this.lblObject.AutoSize = true;
            this.lblObject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblObject.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblObject.Location = new System.Drawing.Point(13, 10);
            this.lblObject.Name = "lblObject";
            this.lblObject.Size = new System.Drawing.Size(213, 44);
            this.lblObject.TabIndex = 0;
            this.lblObject.Text = "Object:";
            this.lblObject.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRequest
            // 
            this.lblRequest.AutoSize = true;
            this.lblRequest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblRequest.Location = new System.Drawing.Point(13, 64);
            this.lblRequest.Name = "lblRequest";
            this.lblRequest.Size = new System.Drawing.Size(213, 44);
            this.lblRequest.TabIndex = 1;
            this.lblRequest.Text = "Request:";
            this.lblRequest.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSequenceNo
            // 
            this.lblSequenceNo.AutoSize = true;
            this.lblSequenceNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSequenceNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSequenceNo.Location = new System.Drawing.Point(13, 118);
            this.lblSequenceNo.Name = "lblSequenceNo";
            this.lblSequenceNo.Size = new System.Drawing.Size(213, 44);
            this.lblSequenceNo.TabIndex = 2;
            this.lblSequenceNo.Text = "Squence No:";
            this.lblSequenceNo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnAccept
            // 
            this.btnAccept.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAccept.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAccept.Location = new System.Drawing.Point(13, 553);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(213, 38);
            this.btnAccept.TabIndex = 11;
            this.btnAccept.Text = "Add";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Pink;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCancel.Location = new System.Drawing.Point(242, 553);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(213, 38);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // txbRequest
            // 
            this.txbRequest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbRequest.Enabled = false;
            this.txbRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txbRequest.Location = new System.Drawing.Point(242, 67);
            this.txbRequest.Name = "txbRequest";
            this.txbRequest.Size = new System.Drawing.Size(213, 31);
            this.txbRequest.TabIndex = 2;
            this.txbRequest.Tag = "";
            // 
            // lblActivityType
            // 
            this.lblActivityType.AutoSize = true;
            this.lblActivityType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblActivityType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblActivityType.Location = new System.Drawing.Point(13, 226);
            this.lblActivityType.Name = "lblActivityType";
            this.lblActivityType.Size = new System.Drawing.Size(213, 44);
            this.lblActivityType.TabIndex = 8;
            this.lblActivityType.Text = "Activity Type:";
            this.lblActivityType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblStartDate.Location = new System.Drawing.Point(13, 280);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(213, 44);
            this.lblStartDate.TabIndex = 9;
            this.lblStartDate.Text = "Start Date:";
            this.lblStartDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDescription.Location = new System.Drawing.Point(13, 388);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(213, 44);
            this.lblDescription.TabIndex = 14;
            this.lblDescription.Text = "Description:";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPersonel
            // 
            this.lblPersonel.AutoSize = true;
            this.lblPersonel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPersonel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPersonel.Location = new System.Drawing.Point(13, 172);
            this.lblPersonel.Name = "lblPersonel";
            this.lblPersonel.Size = new System.Drawing.Size(213, 44);
            this.lblPersonel.TabIndex = 16;
            this.lblPersonel.Text = "Personel:";
            this.lblPersonel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblResult.Location = new System.Drawing.Point(13, 442);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(213, 44);
            this.lblResult.TabIndex = 17;
            this.lblResult.Text = "Result:";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblStatus.Location = new System.Drawing.Point(13, 496);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(213, 44);
            this.lblStatus.TabIndex = 18;
            this.lblStatus.Text = "Status:";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txbResult
            // 
            this.txbResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txbResult.Location = new System.Drawing.Point(242, 445);
            this.txbResult.MaxLength = 1024;
            this.txbResult.Name = "txbResult";
            this.txbResult.Size = new System.Drawing.Size(213, 31);
            this.txbResult.TabIndex = 9;
            this.txbResult.Tag = "";
            this.txbResult.TextChanged += new System.EventHandler(this.OnUserInputChanged);
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 6;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpMain.Controls.Add(this.lblEndDate, 1, 13);
            this.tlpMain.Controls.Add(this.lblObject, 1, 1);
            this.tlpMain.Controls.Add(this.lblRequest, 1, 3);
            this.tlpMain.Controls.Add(this.lblSequenceNo, 1, 5);
            this.tlpMain.Controls.Add(this.btnAccept, 1, 21);
            this.tlpMain.Controls.Add(this.btnCancel, 3, 21);
            this.tlpMain.Controls.Add(this.txbRequest, 3, 3);
            this.tlpMain.Controls.Add(this.lblActivityType, 1, 9);
            this.tlpMain.Controls.Add(this.lblStartDate, 1, 11);
            this.tlpMain.Controls.Add(this.lblDescription, 1, 15);
            this.tlpMain.Controls.Add(this.lblPersonel, 1, 7);
            this.tlpMain.Controls.Add(this.lblResult, 1, 17);
            this.tlpMain.Controls.Add(this.lblStatus, 1, 19);
            this.tlpMain.Controls.Add(this.txbResult, 3, 17);
            this.tlpMain.Controls.Add(this.cbxObject, 3, 1);
            this.tlpMain.Controls.Add(this.nudSequenceNo, 3, 5);
            this.tlpMain.Controls.Add(this.cbxPersonel, 3, 7);
            this.tlpMain.Controls.Add(this.cbxActivityType, 3, 9);
            this.tlpMain.Controls.Add(this.txbDescription, 3, 15);
            this.tlpMain.Controls.Add(this.cbxStatus, 3, 19);
            this.tlpMain.Controls.Add(this.txbStartDate, 3, 11);
            this.tlpMain.Controls.Add(this.txbEndDate, 3, 13);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 24;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090075F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090073F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090075F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.089855F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.089852F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.092837F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.092836F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.091666F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.Size = new System.Drawing.Size(468, 605);
            this.tlpMain.TabIndex = 1;
            // 
            // cbxObject
            // 
            this.cbxObject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxObject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxObject.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbxObject.FormattingEnabled = true;
            this.cbxObject.Location = new System.Drawing.Point(242, 13);
            this.cbxObject.Name = "cbxObject";
            this.cbxObject.Size = new System.Drawing.Size(213, 33);
            this.cbxObject.TabIndex = 19;
            this.cbxObject.SelectedIndexChanged += new System.EventHandler(this.OnUserInputChanged);
            this.cbxObject.Click += new System.EventHandler(this.cbxObject_Click);
            // 
            // nudSequenceNo
            // 
            this.nudSequenceNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudSequenceNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nudSequenceNo.Location = new System.Drawing.Point(242, 121);
            this.nudSequenceNo.Name = "nudSequenceNo";
            this.nudSequenceNo.Size = new System.Drawing.Size(213, 31);
            this.nudSequenceNo.TabIndex = 20;
            this.nudSequenceNo.ValueChanged += new System.EventHandler(this.OnUserInputChanged);
            // 
            // cbxPersonel
            // 
            this.cbxPersonel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxPersonel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPersonel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbxPersonel.FormattingEnabled = true;
            this.cbxPersonel.Location = new System.Drawing.Point(242, 175);
            this.cbxPersonel.Name = "cbxPersonel";
            this.cbxPersonel.Size = new System.Drawing.Size(213, 33);
            this.cbxPersonel.TabIndex = 21;
            this.cbxPersonel.SelectedIndexChanged += new System.EventHandler(this.OnUserInputChanged);
            this.cbxPersonel.Click += new System.EventHandler(this.cbxPersonel_Click);
            // 
            // cbxActivityType
            // 
            this.cbxActivityType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxActivityType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxActivityType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbxActivityType.FormattingEnabled = true;
            this.cbxActivityType.Location = new System.Drawing.Point(242, 229);
            this.cbxActivityType.Name = "cbxActivityType";
            this.cbxActivityType.Size = new System.Drawing.Size(213, 33);
            this.cbxActivityType.TabIndex = 22;
            this.cbxActivityType.SelectedIndexChanged += new System.EventHandler(this.OnUserInputChanged);
            this.cbxActivityType.Click += new System.EventHandler(this.cbxActivityType_Click);
            // 
            // txbDescription
            // 
            this.txbDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txbDescription.Location = new System.Drawing.Point(242, 391);
            this.txbDescription.MaxLength = 1024;
            this.txbDescription.Name = "txbDescription";
            this.txbDescription.Size = new System.Drawing.Size(213, 31);
            this.txbDescription.TabIndex = 25;
            this.txbDescription.TextChanged += new System.EventHandler(this.OnUserInputChanged);
            // 
            // cbxStatus
            // 
            this.cbxStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbxStatus.FormattingEnabled = true;
            this.cbxStatus.Location = new System.Drawing.Point(242, 499);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(213, 33);
            this.cbxStatus.TabIndex = 26;
            this.cbxStatus.SelectedIndexChanged += new System.EventHandler(this.OnUserInputChanged);
            // 
            // txbStartDate
            // 
            this.txbStartDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbStartDate.Enabled = false;
            this.txbStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txbStartDate.Location = new System.Drawing.Point(242, 283);
            this.txbStartDate.Name = "txbStartDate";
            this.txbStartDate.Size = new System.Drawing.Size(213, 31);
            this.txbStartDate.TabIndex = 27;
            // 
            // txbEndDate
            // 
            this.txbEndDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbEndDate.Enabled = false;
            this.txbEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txbEndDate.Location = new System.Drawing.Point(242, 337);
            this.txbEndDate.Name = "txbEndDate";
            this.txbEndDate.Size = new System.Drawing.Size(213, 31);
            this.txbEndDate.TabIndex = 28;
            // 
            // ActivityRequestForm
            // 
            this.AcceptButton = this.btnAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(468, 605);
            this.ControlBox = false;
            this.Controls.Add(this.tlpMain);
            this.Name = "ActivityRequestForm";
            this.Text = "ActivityRequestForm";
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSequenceNo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblObject;
        private System.Windows.Forms.Label lblRequest;
        private System.Windows.Forms.Label lblSequenceNo;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txbRequest;
        private System.Windows.Forms.Label lblActivityType;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblPersonel;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txbResult;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.ComboBox cbxObject;
        private System.Windows.Forms.NumericUpDown nudSequenceNo;
        private System.Windows.Forms.ComboBox cbxPersonel;
        private System.Windows.Forms.ComboBox cbxActivityType;
        private System.Windows.Forms.TextBox txbDescription;
        private System.Windows.Forms.ComboBox cbxStatus;
        private System.Windows.Forms.TextBox txbStartDate;
        private System.Windows.Forms.TextBox txbEndDate;
    }
}
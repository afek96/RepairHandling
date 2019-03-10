namespace RepairHandlingSystem.UI
{
    partial class AddressForm
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
            this.lblCity = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblHouseNumber = new System.Windows.Forms.Label();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txbHouseNumber = new System.Windows.Forms.TextBox();
            this.txbStreet = new System.Windows.Forms.TextBox();
            this.txbCity = new System.Windows.Forms.TextBox();
            this.lblPostalCode = new System.Windows.Forms.Label();
            this.txbPostalCode = new System.Windows.Forms.TextBox();
            this.tlpMain.SuspendLayout();
            this.SuspendLayout();
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
            this.tlpMain.Controls.Add(this.lblCity, 1, 1);
            this.tlpMain.Controls.Add(this.lblStreet, 1, 3);
            this.tlpMain.Controls.Add(this.lblHouseNumber, 1, 5);
            this.tlpMain.Controls.Add(this.btnAccept, 1, 9);
            this.tlpMain.Controls.Add(this.btnCancel, 3, 9);
            this.tlpMain.Controls.Add(this.txbHouseNumber, 3, 5);
            this.tlpMain.Controls.Add(this.txbStreet, 3, 3);
            this.tlpMain.Controls.Add(this.txbCity, 3, 1);
            this.tlpMain.Controls.Add(this.lblPostalCode, 1, 7);
            this.tlpMain.Controls.Add(this.txbPostalCode, 3, 7);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 12;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.9994F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.9994F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.9994F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.99891F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0029F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.Size = new System.Drawing.Size(453, 247);
            this.tlpMain.TabIndex = 1;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCity.Location = new System.Drawing.Point(13, 10);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(205, 37);
            this.lblCity.TabIndex = 0;
            this.lblCity.Text = "City:";
            this.lblCity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblStreet.Location = new System.Drawing.Point(13, 57);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(205, 37);
            this.lblStreet.TabIndex = 1;
            this.lblStreet.Text = "Street:";
            this.lblStreet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblHouseNumber
            // 
            this.lblHouseNumber.AutoSize = true;
            this.lblHouseNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHouseNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblHouseNumber.Location = new System.Drawing.Point(13, 104);
            this.lblHouseNumber.Name = "lblHouseNumber";
            this.lblHouseNumber.Size = new System.Drawing.Size(205, 37);
            this.lblHouseNumber.TabIndex = 2;
            this.lblHouseNumber.Text = "HouseNumber:";
            this.lblHouseNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnAccept
            // 
            this.btnAccept.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAccept.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAccept.Location = new System.Drawing.Point(13, 201);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(205, 31);
            this.btnAccept.TabIndex = 5;
            this.btnAccept.Text = "Confirm";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCancel.Location = new System.Drawing.Point(234, 201);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(205, 31);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // txbHouseNumber
            // 
            this.txbHouseNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbHouseNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txbHouseNumber.Location = new System.Drawing.Point(234, 107);
            this.txbHouseNumber.MaxLength = 8;
            this.txbHouseNumber.Name = "txbHouseNumber";
            this.txbHouseNumber.Size = new System.Drawing.Size(205, 31);
            this.txbHouseNumber.TabIndex = 3;
            this.txbHouseNumber.TextChanged += new System.EventHandler(this.OnTextChanged);
            // 
            // txbStreet
            // 
            this.txbStreet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txbStreet.Location = new System.Drawing.Point(234, 60);
            this.txbStreet.MaxLength = 50;
            this.txbStreet.Name = "txbStreet";
            this.txbStreet.Size = new System.Drawing.Size(205, 31);
            this.txbStreet.TabIndex = 2;
            this.txbStreet.TextChanged += new System.EventHandler(this.OnTextChanged);
            // 
            // txbCity
            // 
            this.txbCity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txbCity.Location = new System.Drawing.Point(234, 13);
            this.txbCity.MaxLength = 50;
            this.txbCity.Name = "txbCity";
            this.txbCity.Size = new System.Drawing.Size(205, 31);
            this.txbCity.TabIndex = 1;
            this.txbCity.TextChanged += new System.EventHandler(this.OnTextChanged);
            // 
            // lblPostalCode
            // 
            this.lblPostalCode.AutoSize = true;
            this.lblPostalCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPostalCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPostalCode.Location = new System.Drawing.Point(13, 151);
            this.lblPostalCode.Name = "lblPostalCode";
            this.lblPostalCode.Size = new System.Drawing.Size(205, 37);
            this.lblPostalCode.TabIndex = 3;
            this.lblPostalCode.Text = "PostalCode:";
            this.lblPostalCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txbPostalCode
            // 
            this.txbPostalCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbPostalCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txbPostalCode.Location = new System.Drawing.Point(234, 154);
            this.txbPostalCode.MaxLength = 6;
            this.txbPostalCode.Name = "txbPostalCode";
            this.txbPostalCode.Size = new System.Drawing.Size(205, 31);
            this.txbPostalCode.TabIndex = 4;
            this.txbPostalCode.TextChanged += new System.EventHandler(this.OnTextChanged);
            // 
            // AddressForm
            // 
            this.AcceptButton = this.btnAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(453, 247);
            this.ControlBox = false;
            this.Controls.Add(this.tlpMain);
            this.Name = "AddressForm";
            this.Text = "AddressForm";
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblHouseNumber;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txbHouseNumber;
        private System.Windows.Forms.TextBox txbStreet;
        private System.Windows.Forms.TextBox txbCity;
        private System.Windows.Forms.Label lblPostalCode;
        private System.Windows.Forms.TextBox txbPostalCode;
    }
}
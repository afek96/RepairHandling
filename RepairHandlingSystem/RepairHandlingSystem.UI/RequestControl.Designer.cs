namespace RepairHandlingSystem.UI
{
    partial class RequestControl
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
            this.lblObject = new System.Windows.Forms.Label();
            this.lblClient = new System.Windows.Forms.Label();
            this.lblObjectType = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.txbDescription = new System.Windows.Forms.TextBox();
            this.cbxObjectType = new System.Windows.Forms.ComboBox();
            this.cbxClient = new System.Windows.Forms.ComboBox();
            this.cbxObject = new System.Windows.Forms.ComboBox();
            this.btnAddObject = new System.Windows.Forms.Button();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.btnAddObjectType = new System.Windows.Forms.Button();
            this.btnAddRequest = new System.Windows.Forms.Button();
            this.tlpMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblObject
            // 
            this.lblObject.AutoSize = true;
            this.lblObject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblObject.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblObject.Location = new System.Drawing.Point(13, 10);
            this.lblObject.Name = "lblObject";
            this.lblObject.Size = new System.Drawing.Size(138, 39);
            this.lblObject.TabIndex = 0;
            this.lblObject.Text = "Object:";
            this.lblObject.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblClient.Location = new System.Drawing.Point(13, 59);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(138, 39);
            this.lblClient.TabIndex = 1;
            this.lblClient.Text = "Client:";
            this.lblClient.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblObjectType
            // 
            this.lblObjectType.AutoSize = true;
            this.lblObjectType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblObjectType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblObjectType.Location = new System.Drawing.Point(13, 108);
            this.lblObjectType.Name = "lblObjectType";
            this.lblObjectType.Size = new System.Drawing.Size(138, 39);
            this.lblObjectType.TabIndex = 2;
            this.lblObjectType.Text = "Object Type:";
            this.lblObjectType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDescription.Location = new System.Drawing.Point(13, 157);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(138, 39);
            this.lblDescription.TabIndex = 16;
            this.lblDescription.Text = "Description:";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 8;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpMain.Controls.Add(this.lblObject, 1, 1);
            this.tlpMain.Controls.Add(this.lblClient, 1, 3);
            this.tlpMain.Controls.Add(this.lblObjectType, 1, 5);
            this.tlpMain.Controls.Add(this.lblDescription, 1, 7);
            this.tlpMain.Controls.Add(this.txbDescription, 3, 7);
            this.tlpMain.Controls.Add(this.cbxObjectType, 3, 5);
            this.tlpMain.Controls.Add(this.cbxClient, 3, 3);
            this.tlpMain.Controls.Add(this.cbxObject, 3, 1);
            this.tlpMain.Controls.Add(this.btnAddObject, 5, 1);
            this.tlpMain.Controls.Add(this.btnAddClient, 5, 3);
            this.tlpMain.Controls.Add(this.btnAddObjectType, 5, 5);
            this.tlpMain.Controls.Add(this.btnAddRequest, 5, 7);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 10;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.99943F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.99942F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.99943F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00172F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.Size = new System.Drawing.Size(616, 207);
            this.tlpMain.TabIndex = 2;
            // 
            // txbDescription
            // 
            this.txbDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txbDescription.Location = new System.Drawing.Point(167, 160);
            this.txbDescription.MaxLength = 1024;
            this.txbDescription.Name = "txbDescription";
            this.txbDescription.Size = new System.Drawing.Size(195, 31);
            this.txbDescription.TabIndex = 17;
            this.txbDescription.TextChanged += new System.EventHandler(this.OnUserValueInputChanged);
            // 
            // cbxObjectType
            // 
            this.cbxObjectType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxObjectType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbxObjectType.FormattingEnabled = true;
            this.cbxObjectType.Location = new System.Drawing.Point(167, 111);
            this.cbxObjectType.Name = "cbxObjectType";
            this.cbxObjectType.Size = new System.Drawing.Size(195, 33);
            this.cbxObjectType.TabIndex = 18;
            this.cbxObjectType.SelectedIndexChanged += new System.EventHandler(this.OnUserValueInputChanged);
            this.cbxObjectType.Click += new System.EventHandler(this.cbxObjectType_Click);
            // 
            // cbxClient
            // 
            this.cbxClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbxClient.FormattingEnabled = true;
            this.cbxClient.Location = new System.Drawing.Point(167, 62);
            this.cbxClient.Name = "cbxClient";
            this.cbxClient.Size = new System.Drawing.Size(195, 33);
            this.cbxClient.TabIndex = 19;
            this.cbxClient.SelectedIndexChanged += new System.EventHandler(this.OnUserValueInputChanged);
            this.cbxClient.Click += new System.EventHandler(this.cbxClient_Click);
            // 
            // cbxObject
            // 
            this.cbxObject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxObject.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbxObject.FormattingEnabled = true;
            this.cbxObject.Location = new System.Drawing.Point(167, 13);
            this.cbxObject.Name = "cbxObject";
            this.cbxObject.Size = new System.Drawing.Size(195, 33);
            this.cbxObject.TabIndex = 20;
            this.cbxObject.SelectedIndexChanged += new System.EventHandler(this.OnUserValueInputChanged);
            this.cbxObject.Click += new System.EventHandler(this.cbxObject_Click);
            // 
            // btnAddObject
            // 
            this.btnAddObject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddObject.Enabled = false;
            this.btnAddObject.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAddObject.Location = new System.Drawing.Point(378, 13);
            this.btnAddObject.Name = "btnAddObject";
            this.btnAddObject.Size = new System.Drawing.Size(224, 33);
            this.btnAddObject.TabIndex = 21;
            this.btnAddObject.Text = "Add Object";
            this.btnAddObject.UseVisualStyleBackColor = true;
            this.btnAddObject.Click += new System.EventHandler(this.btnAddObject_Click);
            // 
            // btnAddClient
            // 
            this.btnAddClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAddClient.Location = new System.Drawing.Point(378, 62);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(224, 33);
            this.btnAddClient.TabIndex = 22;
            this.btnAddClient.Text = "Add Client";
            this.btnAddClient.UseVisualStyleBackColor = true;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // btnAddObjectType
            // 
            this.btnAddObjectType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddObjectType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAddObjectType.Location = new System.Drawing.Point(378, 111);
            this.btnAddObjectType.Name = "btnAddObjectType";
            this.btnAddObjectType.Size = new System.Drawing.Size(224, 33);
            this.btnAddObjectType.TabIndex = 23;
            this.btnAddObjectType.Text = "Add Object Type";
            this.btnAddObjectType.UseVisualStyleBackColor = true;
            this.btnAddObjectType.Click += new System.EventHandler(this.btnAddObjectType_Click);
            // 
            // btnAddRequest
            // 
            this.btnAddRequest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddRequest.Enabled = false;
            this.btnAddRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAddRequest.Location = new System.Drawing.Point(378, 160);
            this.btnAddRequest.Name = "btnAddRequest";
            this.btnAddRequest.Size = new System.Drawing.Size(224, 33);
            this.btnAddRequest.TabIndex = 24;
            this.btnAddRequest.Text = "Add Request";
            this.btnAddRequest.UseVisualStyleBackColor = true;
            this.btnAddRequest.Click += new System.EventHandler(this.btnAddRequest_Click);
            // 
            // RequestControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpMain);
            this.Name = "RequestControl";
            this.Size = new System.Drawing.Size(616, 207);
            this.FontChanged += new System.EventHandler(this.RequestControl_FontChanged);
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblObject;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.Label lblObjectType;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.TextBox txbDescription;
        private System.Windows.Forms.ComboBox cbxObjectType;
        private System.Windows.Forms.ComboBox cbxClient;
        private System.Windows.Forms.ComboBox cbxObject;
        private System.Windows.Forms.Button btnAddObject;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.Button btnAddObjectType;
        private System.Windows.Forms.Button btnAddRequest;
    }
}

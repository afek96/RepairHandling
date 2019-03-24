namespace RepairHandlingSystem.UI
{
    partial class ObjectForm
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
      this.lblClient = new System.Windows.Forms.Label();
      this.lblObjectType = new System.Windows.Forms.Label();
      this.lblName = new System.Windows.Forms.Label();
      this.txbDescription = new System.Windows.Forms.TextBox();
      this.cbxObjectType = new System.Windows.Forms.ComboBox();
      this.cbxClient = new System.Windows.Forms.ComboBox();
      this.btnAddObject = new System.Windows.Forms.Button();
      this.btnAddClient = new System.Windows.Forms.Button();
      this.btnAddObjectType = new System.Windows.Forms.Button();
      this.btnClose = new System.Windows.Forms.Button();
      this.tlpMain.SuspendLayout();
      this.SuspendLayout();
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
      this.tlpMain.Controls.Add(this.lblClient, 1, 1);
      this.tlpMain.Controls.Add(this.lblObjectType, 1, 3);
      this.tlpMain.Controls.Add(this.lblName, 1, 5);
      this.tlpMain.Controls.Add(this.txbDescription, 3, 5);
      this.tlpMain.Controls.Add(this.cbxObjectType, 3, 3);
      this.tlpMain.Controls.Add(this.cbxClient, 3, 1);
      this.tlpMain.Controls.Add(this.btnAddObject, 5, 5);
      this.tlpMain.Controls.Add(this.btnAddClient, 5, 1);
      this.tlpMain.Controls.Add(this.btnAddObjectType, 5, 3);
      this.tlpMain.Controls.Add(this.btnClose, 1, 7);
      this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tlpMain.Location = new System.Drawing.Point(0, 0);
      this.tlpMain.Name = "tlpMain";
      this.tlpMain.RowCount = 10;
      this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
      this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
      this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
      this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
      this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
      this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tlpMain.Size = new System.Drawing.Size(761, 215);
      this.tlpMain.TabIndex = 3;
      // 
      // lblClient
      // 
      this.lblClient.AutoSize = true;
      this.lblClient.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lblClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.lblClient.Location = new System.Drawing.Point(13, 10);
      this.lblClient.Name = "lblClient";
      this.lblClient.Size = new System.Drawing.Size(174, 41);
      this.lblClient.TabIndex = 1;
      this.lblClient.Text = "Client:";
      this.lblClient.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // lblObjectType
      // 
      this.lblObjectType.AutoSize = true;
      this.lblObjectType.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lblObjectType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.lblObjectType.Location = new System.Drawing.Point(13, 61);
      this.lblObjectType.Name = "lblObjectType";
      this.lblObjectType.Size = new System.Drawing.Size(174, 41);
      this.lblObjectType.TabIndex = 2;
      this.lblObjectType.Text = "Object Type:";
      this.lblObjectType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // lblName
      // 
      this.lblName.AutoSize = true;
      this.lblName.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.lblName.Location = new System.Drawing.Point(13, 112);
      this.lblName.Name = "lblName";
      this.lblName.Size = new System.Drawing.Size(174, 41);
      this.lblName.TabIndex = 16;
      this.lblName.Text = "Name:";
      this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // txbDescription
      // 
      this.txbDescription.Dock = System.Windows.Forms.DockStyle.Fill;
      this.txbDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.txbDescription.Location = new System.Drawing.Point(203, 115);
      this.txbDescription.MaxLength = 1024;
      this.txbDescription.Name = "txbDescription";
      this.txbDescription.Size = new System.Drawing.Size(246, 31);
      this.txbDescription.TabIndex = 17;
      this.txbDescription.TextChanged += new System.EventHandler(this.OnUserValueInputChanged);
      // 
      // cbxObjectType
      // 
      this.cbxObjectType.Dock = System.Windows.Forms.DockStyle.Fill;
      this.cbxObjectType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbxObjectType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.cbxObjectType.FormattingEnabled = true;
      this.cbxObjectType.Location = new System.Drawing.Point(203, 64);
      this.cbxObjectType.Name = "cbxObjectType";
      this.cbxObjectType.Size = new System.Drawing.Size(246, 33);
      this.cbxObjectType.TabIndex = 18;
      this.cbxObjectType.SelectedIndexChanged += new System.EventHandler(this.OnUserValueInputChanged);
      this.cbxObjectType.Click += new System.EventHandler(this.cbxObjectType_Click);
      // 
      // cbxClient
      // 
      this.cbxClient.Dock = System.Windows.Forms.DockStyle.Fill;
      this.cbxClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbxClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.cbxClient.FormattingEnabled = true;
      this.cbxClient.Location = new System.Drawing.Point(203, 13);
      this.cbxClient.Name = "cbxClient";
      this.cbxClient.Size = new System.Drawing.Size(246, 33);
      this.cbxClient.TabIndex = 19;
      this.cbxClient.SelectedIndexChanged += new System.EventHandler(this.OnUserValueInputChanged);
      this.cbxClient.Click += new System.EventHandler(this.cbxClient_Click);
      // 
      // btnAddObject
      // 
      this.btnAddObject.Dock = System.Windows.Forms.DockStyle.Fill;
      this.btnAddObject.Enabled = false;
      this.btnAddObject.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.btnAddObject.Location = new System.Drawing.Point(465, 115);
      this.btnAddObject.Name = "btnAddObject";
      this.btnAddObject.Size = new System.Drawing.Size(282, 35);
      this.btnAddObject.TabIndex = 21;
      this.btnAddObject.Text = "Add Object";
      this.btnAddObject.UseVisualStyleBackColor = true;
      this.btnAddObject.Click += new System.EventHandler(this.btnAddObject_Click);
      // 
      // btnAddClient
      // 
      this.btnAddClient.Dock = System.Windows.Forms.DockStyle.Fill;
      this.btnAddClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.btnAddClient.Location = new System.Drawing.Point(465, 13);
      this.btnAddClient.Name = "btnAddClient";
      this.btnAddClient.Size = new System.Drawing.Size(282, 35);
      this.btnAddClient.TabIndex = 22;
      this.btnAddClient.Text = "Add Client";
      this.btnAddClient.UseVisualStyleBackColor = true;
      this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
      // 
      // btnAddObjectType
      // 
      this.btnAddObjectType.Dock = System.Windows.Forms.DockStyle.Fill;
      this.btnAddObjectType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.btnAddObjectType.Location = new System.Drawing.Point(465, 64);
      this.btnAddObjectType.Name = "btnAddObjectType";
      this.btnAddObjectType.Size = new System.Drawing.Size(282, 35);
      this.btnAddObjectType.TabIndex = 23;
      this.btnAddObjectType.Text = "Add Object Type";
      this.btnAddObjectType.UseVisualStyleBackColor = true;
      this.btnAddObjectType.Click += new System.EventHandler(this.btnAddObjectType_Click);
      // 
      // btnClose
      // 
      this.btnClose.BackColor = System.Drawing.Color.Pink;
      this.tlpMain.SetColumnSpan(this.btnClose, 5);
      this.btnClose.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.btnClose.Dock = System.Windows.Forms.DockStyle.Fill;
      this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.btnClose.Location = new System.Drawing.Point(13, 166);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new System.Drawing.Size(734, 35);
      this.btnClose.TabIndex = 24;
      this.btnClose.Text = "Close";
      this.btnClose.UseVisualStyleBackColor = false;
      // 
      // ObjectForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(761, 215);
      this.ControlBox = false;
      this.Controls.Add(this.tlpMain);
      this.Name = "ObjectForm";
      this.Text = "ObjectForm";
      this.tlpMain.ResumeLayout(false);
      this.tlpMain.PerformLayout();
      this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.Label lblObjectType;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txbDescription;
        private System.Windows.Forms.ComboBox cbxObjectType;
        private System.Windows.Forms.ComboBox cbxClient;
        private System.Windows.Forms.Button btnAddObject;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.Button btnAddObjectType;
        private System.Windows.Forms.Button btnClose;
    }
}
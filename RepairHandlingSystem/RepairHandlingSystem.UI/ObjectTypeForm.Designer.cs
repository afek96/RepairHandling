namespace RepairHandlingSystem.UI
{
    partial class ObjectTypeForm
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
      this.lblObjectType = new System.Windows.Forms.Label();
      this.lblName = new System.Windows.Forms.Label();
      this.btnCreate = new System.Windows.Forms.Button();
      this.btnCancel = new System.Windows.Forms.Button();
      this.txbName = new System.Windows.Forms.TextBox();
      this.txbObjectType = new System.Windows.Forms.TextBox();
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
      this.tlpMain.Controls.Add(this.lblObjectType, 1, 1);
      this.tlpMain.Controls.Add(this.lblName, 1, 3);
      this.tlpMain.Controls.Add(this.btnCreate, 1, 5);
      this.tlpMain.Controls.Add(this.btnCancel, 3, 5);
      this.tlpMain.Controls.Add(this.txbName, 3, 3);
      this.tlpMain.Controls.Add(this.txbObjectType, 3, 1);
      this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tlpMain.Location = new System.Drawing.Point(0, 0);
      this.tlpMain.Name = "tlpMain";
      this.tlpMain.RowCount = 8;
      this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
      this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33139F));
      this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
      this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33139F));
      this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
      this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33722F));
      this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
      this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tlpMain.Size = new System.Drawing.Size(402, 164);
      this.tlpMain.TabIndex = 7;
      // 
      // lblObjectType
      // 
      this.lblObjectType.AutoSize = true;
      this.lblObjectType.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lblObjectType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.lblObjectType.Location = new System.Drawing.Point(13, 10);
      this.lblObjectType.Name = "lblObjectType";
      this.lblObjectType.Size = new System.Drawing.Size(180, 41);
      this.lblObjectType.TabIndex = 0;
      this.lblObjectType.Text = "Object Type:";
      this.lblObjectType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // lblName
      // 
      this.lblName.AutoSize = true;
      this.lblName.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.lblName.Location = new System.Drawing.Point(13, 61);
      this.lblName.Name = "lblName";
      this.lblName.Size = new System.Drawing.Size(180, 41);
      this.lblName.TabIndex = 2;
      this.lblName.Text = "Name:";
      this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // btnCreate
      // 
      this.btnCreate.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.btnCreate.Dock = System.Windows.Forms.DockStyle.Fill;
      this.btnCreate.Enabled = false;
      this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.btnCreate.Location = new System.Drawing.Point(13, 115);
      this.btnCreate.Name = "btnCreate";
      this.btnCreate.Size = new System.Drawing.Size(180, 35);
      this.btnCreate.TabIndex = 4;
      this.btnCreate.Text = "Create";
      this.btnCreate.UseVisualStyleBackColor = true;
      this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
      // 
      // btnCancel
      // 
      this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.btnCancel.Location = new System.Drawing.Point(209, 115);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(180, 35);
      this.btnCancel.TabIndex = 5;
      this.btnCancel.Text = "Cancel";
      this.btnCancel.UseVisualStyleBackColor = true;
      // 
      // txbName
      // 
      this.txbName.Dock = System.Windows.Forms.DockStyle.Fill;
      this.txbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.txbName.Location = new System.Drawing.Point(209, 64);
      this.txbName.MaxLength = 256;
      this.txbName.Name = "txbName";
      this.txbName.Size = new System.Drawing.Size(180, 31);
      this.txbName.TabIndex = 3;
      this.txbName.TextChanged += new System.EventHandler(this.OnTextChanged);
      // 
      // txbObjectType
      // 
      this.txbObjectType.Dock = System.Windows.Forms.DockStyle.Fill;
      this.txbObjectType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.txbObjectType.Location = new System.Drawing.Point(209, 13);
      this.txbObjectType.MaxLength = 8;
      this.txbObjectType.Name = "txbObjectType";
      this.txbObjectType.Size = new System.Drawing.Size(180, 31);
      this.txbObjectType.TabIndex = 1;
      this.txbObjectType.TextChanged += new System.EventHandler(this.OnTextChanged);
      // 
      // ObjectTypeForm
      // 
      this.AcceptButton = this.btnCreate;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.btnCancel;
      this.ClientSize = new System.Drawing.Size(402, 164);
      this.ControlBox = false;
      this.Controls.Add(this.tlpMain);
      this.Name = "ObjectTypeForm";
      this.Text = "ObjectTypeForm";
      this.tlpMain.ResumeLayout(false);
      this.tlpMain.PerformLayout();
      this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.Label lblObjectType;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.TextBox txbObjectType;
    }
}
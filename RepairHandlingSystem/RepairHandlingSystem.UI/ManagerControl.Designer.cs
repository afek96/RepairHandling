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
            this.btnClientAdd = new System.Windows.Forms.Button();
            this.btnObjectAdd = new System.Windows.Forms.Button();
            this.btnRequestAdd = new System.Windows.Forms.Button();
            this.btnAddActivity = new System.Windows.Forms.Button();
            this.gbRequest = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.gbActivities = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dgvRequests = new System.Windows.Forms.DataGridView();
            this.dgvActivities = new System.Windows.Forms.DataGridView();
            this.gbRequest.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.gbActivities.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivities)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClientAdd
            // 
            this.btnClientAdd.Location = new System.Drawing.Point(13, 50);
            this.btnClientAdd.Name = "btnClientAdd";
            this.btnClientAdd.Size = new System.Drawing.Size(29, 21);
            this.btnClientAdd.TabIndex = 0;
            this.btnClientAdd.Text = "Add Client";
            this.btnClientAdd.UseVisualStyleBackColor = true;
            // 
            // btnObjectAdd
            // 
            this.btnObjectAdd.Location = new System.Drawing.Point(58, 50);
            this.btnObjectAdd.Name = "btnObjectAdd";
            this.btnObjectAdd.Size = new System.Drawing.Size(29, 21);
            this.btnObjectAdd.TabIndex = 1;
            this.btnObjectAdd.Text = "Add Object";
            this.btnObjectAdd.UseVisualStyleBackColor = true;
            // 
            // btnRequestAdd
            // 
            this.btnRequestAdd.Location = new System.Drawing.Point(103, 13);
            this.btnRequestAdd.Name = "btnRequestAdd";
            this.btnRequestAdd.Size = new System.Drawing.Size(29, 21);
            this.btnRequestAdd.TabIndex = 2;
            this.btnRequestAdd.Text = "Add Request";
            this.btnRequestAdd.UseVisualStyleBackColor = true;
            // 
            // btnAddActivity
            // 
            this.btnAddActivity.Location = new System.Drawing.Point(6, 235);
            this.btnAddActivity.Name = "btnAddActivity";
            this.btnAddActivity.Size = new System.Drawing.Size(75, 56);
            this.btnAddActivity.TabIndex = 3;
            this.btnAddActivity.Text = "Add Activity to Open Request";
            this.btnAddActivity.UseVisualStyleBackColor = true;
            // 
            // gbRequest
            // 
            this.gbRequest.Controls.Add(this.tableLayoutPanel1);
            this.gbRequest.Location = new System.Drawing.Point(3, 3);
            this.gbRequest.Name = "gbRequest";
            this.gbRequest.Size = new System.Drawing.Size(153, 103);
            this.gbRequest.TabIndex = 4;
            this.gbRequest.TabStop = false;
            this.gbRequest.Text = "Request";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.Controls.Add(this.comboBox1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.comboBox2, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnRequestAdd, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnObjectAdd, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnClientAdd, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(147, 84);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(13, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(29, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(58, 13);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(29, 21);
            this.comboBox2.TabIndex = 1;
            // 
            // gbActivities
            // 
            this.gbActivities.Controls.Add(this.tableLayoutPanel2);
            this.gbActivities.Location = new System.Drawing.Point(6, 112);
            this.gbActivities.Name = "gbActivities";
            this.gbActivities.Size = new System.Drawing.Size(121, 117);
            this.gbActivities.TabIndex = 5;
            this.gbActivities.TabStop = false;
            this.gbActivities.Text = "Activities";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 7;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.Controls.Add(this.comboBox3, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.comboBox4, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.button1, 5, 1);
            this.tableLayoutPanel2.Controls.Add(this.button2, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.button3, 1, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(115, 98);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(13, 13);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(18, 21);
            this.comboBox3.TabIndex = 0;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(47, 13);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(18, 21);
            this.comboBox4.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(81, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(18, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add Request";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(47, 57);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(18, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Add Object";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(13, 57);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(18, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "Add Client";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // dgvRequests
            // 
            this.dgvRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRequests.Location = new System.Drawing.Point(484, 0);
            this.dgvRequests.Name = "dgvRequests";
            this.dgvRequests.Size = new System.Drawing.Size(240, 150);
            this.dgvRequests.TabIndex = 6;
            // 
            // dgvActivities
            // 
            this.dgvActivities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActivities.Location = new System.Drawing.Point(484, 248);
            this.dgvActivities.Name = "dgvActivities";
            this.dgvActivities.Size = new System.Drawing.Size(240, 150);
            this.dgvActivities.TabIndex = 7;
            // 
            // ManagerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvActivities);
            this.Controls.Add(this.dgvRequests);
            this.Controls.Add(this.gbActivities);
            this.Controls.Add(this.gbRequest);
            this.Controls.Add(this.btnAddActivity);
            this.Name = "ManagerControl";
            this.Size = new System.Drawing.Size(724, 398);
            this.gbRequest.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.gbActivities.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivities)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClientAdd;
        private System.Windows.Forms.Button btnObjectAdd;
        private System.Windows.Forms.Button btnRequestAdd;
        private System.Windows.Forms.Button btnAddActivity;
        private System.Windows.Forms.GroupBox gbRequest;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.GroupBox gbActivities;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dgvRequests;
        private System.Windows.Forms.DataGridView dgvActivities;
    }
}

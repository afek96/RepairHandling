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
            this.tlpSplit = new System.Windows.Forms.TableLayoutPanel();
            this.vafActivityControl = new RepairHandlingSystem.UI.ViewAndFilterActivityControl();
            this.vafRequestControl = new RepairHandlingSystem.UI.ViewAndFilterRequestControl();
            this.tlpSplit.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpSplit
            // 
            this.tlpSplit.ColumnCount = 2;
            this.tlpSplit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpSplit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpSplit.Controls.Add(this.vafActivityControl, 1, 0);
            this.tlpSplit.Controls.Add(this.vafRequestControl, 0, 0);
            this.tlpSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSplit.Location = new System.Drawing.Point(0, 0);
            this.tlpSplit.Name = "tlpSplit";
            this.tlpSplit.RowCount = 1;
            this.tlpSplit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpSplit.Size = new System.Drawing.Size(1175, 486);
            this.tlpSplit.TabIndex = 11;
            // 
            // vafActivityControl
            // 
            this.vafActivityControl.CurrentRequest = null;
            this.vafActivityControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vafActivityControl.Location = new System.Drawing.Point(590, 3);
            this.vafActivityControl.Name = "vafActivityControl";
            this.vafActivityControl.Size = new System.Drawing.Size(582, 480);
            this.vafActivityControl.TabIndex = 9;
            // 
            // vafRequestControl
            // 
            this.vafRequestControl.CurrentUser = null;
            this.vafRequestControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vafRequestControl.Location = new System.Drawing.Point(3, 3);
            this.vafRequestControl.Name = "vafRequestControl";
            this.vafRequestControl.Size = new System.Drawing.Size(581, 480);
            this.vafRequestControl.TabIndex = 8;
            // 
            // ManagerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpSplit);
            this.Name = "ManagerControl";
            this.Size = new System.Drawing.Size(1175, 486);
            this.tlpSplit.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpSplit;
        private ViewAndFilterActivityControl vafActivityControl;
        private ViewAndFilterRequestControl vafRequestControl;
    }
}

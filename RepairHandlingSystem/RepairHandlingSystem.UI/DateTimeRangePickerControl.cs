using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RepairHandlingSystem.UI
{
    public partial class DateTimeRangePickerControl : UserControl
    {
        private bool _blockDtpValueChangedEvent = false;

        [Browsable(true)]
        public override string Text { get => cbEnabled.Text; set => cbEnabled.Text = value; }

        public DateTime? From
        {
            get
            {
                return cbEnabled.Checked ? (DateTime?)dtpFrom.Value : null;
            }
        }

        public DateTime? To
        {
            get
            {
                return cbEnabled.Checked ? (DateTime?)dtpTo.Value : null;
            }
        }

        public DateTimeRangePickerControl()
        {
            InitializeComponent();
        }

        public void Initialize(string text)
        {
            cbEnabled.Text = text;
        }

        public void Restart()
        {
            cbEnabled.Checked = false;
            dtpFrom.Value = DateTime.Now;
            dtpTo.Value = dtpFrom.Value;
        }

        private void dtpFrom_ValueChanged(object sender, EventArgs e)
        {
            if (_blockDtpValueChangedEvent)
                return;

            _blockDtpValueChangedEvent = true;

            if (dtpTo.Value < dtpFrom.Value)
                dtpTo.Value = dtpFrom.Value.AddDays(1);

            _blockDtpValueChangedEvent = false;
        }

        private void dtpTo_ValueChanged(object sender, EventArgs e)
        {
            if (_blockDtpValueChangedEvent)
                return;

            _blockDtpValueChangedEvent = true;

            if (dtpTo.Value < dtpFrom.Value)
                dtpFrom.Value = dtpTo.Value.AddDays(-1);

            _blockDtpValueChangedEvent = false;
        }
    }
}

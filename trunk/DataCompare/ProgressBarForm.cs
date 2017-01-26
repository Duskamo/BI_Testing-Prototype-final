using System;
using System.Windows.Forms;

namespace DataCompare
{
    public partial class ProgressBarForm : Form
    {
        private bool _srcFinished;
        private bool _trgFinished;
        private bool _isCanceled;

        public ProgressBarForm(int minSrc, int maxSrc, int minTrg, int maxTrg)
        {
            InitializeComponent();

            pbSrcProcessed.Maximum = maxSrc;
            pbSrcProcessed.Minimum = minSrc;
            pbSrcProcessed.Value = minSrc;

            pbTrgProcessed.Maximum = maxTrg;
            pbTrgProcessed.Minimum = minTrg;
            pbSrcProcessed.Value = minSrc;
        }

        public bool IsCanceled
        {
            get { return _isCanceled; }
        }

        public void SetPosSrc(int value)
        {
            SetPos(value, true);
        }

        public void SetPosTrg(int value)
        {
            SetPos(value, false);
        }

        private void SetPos(int value, bool isSrc)
        {
            var processed = isSrc ? pbSrcProcessed : pbTrgProcessed;
            var percentage = isSrc ? lblSrcPercentage : lblTrgPercentage;
            var count = isSrc ? lblSrcCount : lblTrgCount;

            if (value <= processed.Maximum)
            {
                processed.Value = value;
                percentage.Text = (processed.Maximum == 0) ? "100%" : ((value * 100 / processed.Maximum) + "%");
                count.Text = value + "/" + processed.Maximum;
            }

            if (value == processed.Maximum)
            {
                if (isSrc)
                    _srcFinished = true;
                else
                    _trgFinished = true;
            }

            if (_srcFinished && _trgFinished)
                btnFinish.Text = "Finish";

            Application.DoEvents();
        }

        private void ProgressBarForm_Load(object sender, EventArgs e)
        {
            Owner.Enabled = false;
        }

        private void ProgressBarForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Enabled = true;
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            if (btnFinish.Text == "Cancel")
                _isCanceled = true;

            Close();
        }
    }
}

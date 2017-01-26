using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DataCompare.Properties;

namespace DataCompare.Controls
{
    [ToolboxBitmap(typeof(WaitingLayer))]
    class WaitingLayer : Control
    {
        private bool _transparent = true;
        private int _alpha;

        public WaitingLayer(int alpha = 125, bool showImage = true)
        {
            SetStyle(ControlStyles.Opaque, true);
            CreateControl();

            _alpha = alpha;

            if (!showImage) return;

            var pictureBox = new PictureBox();

            Controls.Add(pictureBox);

            pictureBox.BackColor = Color.White;
            pictureBox.Image = Resources.Loading;
            pictureBox.Name = "pbLoading";
            pictureBox.Size = new Size(42, 42);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            int locationX = Location.X + (Width - pictureBox.Width) / 2;
            int locationY = Location.Y + (Height - pictureBox.Height) / 2;

            pictureBox.Location = new Point(locationX, locationY);
            pictureBox.Anchor = AnchorStyles.None;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var color = _transparent ? Color.FromArgb(_alpha, BackColor) : BackColor;

            var pictureBox = Controls["pbLoading"] as PictureBox;

            var pen = new Pen(color, 0);
            var brush = new SolidBrush(color);

            if (pictureBox != null) pictureBox.BackColor = Color.Transparent;

            base.OnPaint(e);

            e.Graphics.DrawRectangle(pen, 0, 0, Size.Width, Size.Height);
            e.Graphics.FillRectangle(brush, 0, 0, Size.Width, Size.Height);
        }

        protected override CreateParams CreateParams
        {
            get
            {
                var cp = base.CreateParams;
                cp.ExStyle |= 0x00000020; //WS_EX_TRANSPARENT
                return cp;
            }
        }

        [Category("WaitingLayer"), Description("Transparent")]
        public bool Transparent
        {
            get { return _transparent; }
            set { _transparent = value; Invalidate(); }
        }

        [Category("WaitingLayer"), Description("Alpha")]
        public int Alpha
        {
            get { return _alpha; }
            set { _alpha = value; Invalidate(); }
        }
    }
}

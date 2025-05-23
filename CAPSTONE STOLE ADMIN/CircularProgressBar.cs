using System;
using System.Drawing;
using System.Windows.Forms;

namespace CAPSTONE_STOLE_ADMIN
{
    public partial class CircularProgressBar : UserControl
    {
        private int progress = 0;
        private int thickness = 10;
        private Color progressColor = Color.DodgerBlue;
        private Color backgroundColor = Color.LightGray;

        public CircularProgressBar()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        public int Progress
        {
            get { return progress; }
            set
            {
                progress = Math.Max(0, Math.Min(100, value));
                Invalidate();
            }
        }

        public int Thickness
        {
            get { return thickness; }
            set
            {
                thickness = value;
                Invalidate();
            }
        }

        public Color ProgressColor
        {
            get { return progressColor; }
            set
            {
                progressColor = value;
                Invalidate();
            }
        }

        public Color BackgroundColor
        {
            get { return backgroundColor; }
            set
            {
                backgroundColor = value;
                Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            using (Pen backgroundPen = new Pen(backgroundColor, thickness))
            {
                e.Graphics.DrawArc(
                    backgroundPen, thickness, thickness, Width - 2 * thickness, Height - 2 * thickness, 0, 360);
            }

            using (Pen progressPen = new Pen(progressColor, thickness))
            {
                int sweepAngle = (int)(360.0 * progress / 100);
                e.Graphics.DrawArc(
                    progressPen, thickness, thickness, Width - 2 * thickness, Height - 2 * thickness, -90, sweepAngle);
            }
        }
    }
}

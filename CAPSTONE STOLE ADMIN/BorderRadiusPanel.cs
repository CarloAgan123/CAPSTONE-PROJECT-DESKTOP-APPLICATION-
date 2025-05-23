using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace CAPSTONE_STOLE_ADMIN
{
    public class BorderRadiusPanel : Panel
    {
        public int BorderRadius { get; set; } = 10;
        public Color BorderColor { get; set; } = Color.White;
        public int BorderSize { get; set; } = 4;

        protected override void OnPaint(PaintEventArgs e)
        {
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddArc(0, 0, BorderRadius, BorderRadius, 180, 90);
                path.AddArc(Width - BorderRadius, 0, BorderRadius, BorderRadius, 270, 90);
                path.AddArc(Width - BorderRadius, Height - BorderRadius, BorderRadius, BorderRadius, 0, 90);
                path.AddArc(0, Height - BorderRadius, BorderRadius, BorderRadius, 90, 90);
                path.CloseFigure();
                this.Region = new Region(path);
            }

            base.OnPaint(e);
            using (Pen pen = new Pen(BorderColor, BorderSize))
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.DrawPath(pen, GetRoundedRectanglePath(ClientRectangle, BorderRadius));
            }
        }

        private GraphicsPath GetRoundedRectanglePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;

            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();

            return path;
        }
    }
}

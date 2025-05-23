using System;
using System.Drawing;
using System.Windows.Forms;

namespace CAPSTONE_STOLE_ADMIN
{
    public class BorderedPictureBox : PictureBox
    {
        private int borderRadius = 20; // Fixed border radius

        protected override void OnPaint(System.Windows.Forms.PaintEventArgs pe)
        {
            // Create a graphics path for the rounded rectangle
            var path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(0, 0, borderRadius, borderRadius, 180, 90);
            path.AddArc(this.Width - borderRadius, 0, borderRadius, borderRadius, 270, 90);
            path.AddArc(this.Width - borderRadius, this.Height - borderRadius, borderRadius, borderRadius, 0, 90);
            path.AddArc(0, this.Height - borderRadius, borderRadius, borderRadius, 90, 90);
            path.CloseFigure();

            // Set the region of the PictureBox to the rounded rectangle
            this.Region = new Region(path);

            // Optionally, you can draw a border
            using (Pen borderPen = new Pen(Color.Black, 2)) // Customize border color and thickness
            {
                pe.Graphics.DrawPath(borderPen, path);
            }

            // Call the base class's OnPaint method
            base.OnPaint(pe);
        }
    }
}

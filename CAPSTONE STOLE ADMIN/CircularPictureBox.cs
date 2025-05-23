using System;
using System.Drawing;
using System.Windows.Forms;

namespace CAPSTONE_STOLE_ADMIN
{
    public class CircularPictureBox : PictureBox
    {
        protected override void OnPaint(System.Windows.Forms.PaintEventArgs pe)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, this.Width, this.Height);
            this.Region = new Region(path);

            base.OnPaint(pe);
        }
    }
}

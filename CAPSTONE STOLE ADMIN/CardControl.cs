using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace CAPSTONE_STOLE_ADMIN
{
    public partial class CardControl : UserControl
    {
        public CardControl()
        {
            InitializeComponent();
            this.Size = new Size(300, 150);
            this.BackColor = Color.White;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            using (GraphicsPath path = new GraphicsPath())
            {
                int radius = 4; // Radius for the corners
                path.AddArc(0, 0, radius, radius, 180, 90); // Top-left corner
                path.AddArc(Width - radius, 0, radius, radius, 270, 90); // Top-right corner
                path.AddArc(Width - radius, Height - radius, radius, radius, 0, 90); // Bottom-right corner
                path.AddArc(0, Height - radius, radius, radius, 90, 90); // Bottom-left corner
                path.CloseFigure();

                this.Region = new Region(path);
                e.Graphics.FillPath(new SolidBrush(this.BackColor), path);
            }
        }
    }
}

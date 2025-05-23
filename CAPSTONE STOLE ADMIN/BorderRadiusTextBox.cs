using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace CAPSTONE_STOLE_ADMIN
{
    public class BorderRadiusTextBox : UserControl
    {
        private TextBox innerTextBox;
        public int BorderRadius { get; set; } = 10;
        public Color BorderColor { get; set; } = Color.White;
        public int BorderSize { get; set; } = 2;

        public BorderRadiusTextBox()
        {
            // Initialize inner TextBox
            innerTextBox = new TextBox
            {
                BorderStyle = BorderStyle.None,
                Multiline = false,
                BackColor = this.BackColor,
                ForeColor = this.ForeColor,
                Dock = DockStyle.Fill,
                Padding = new Padding(5)
            };

            this.Padding = new Padding(BorderSize);
            this.Controls.Add(innerTextBox);
            this.Size = new Size(200, 30);
            this.BackColor = Color.Transparent;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            using (Graphics g = e.Graphics)
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;

                // Draw the rounded rectangle border
                using (Pen pen = new Pen(BorderColor, BorderSize))
                {
                    g.DrawPath(pen, GetRoundedRectanglePath(ClientRectangle, BorderRadius));
                }

                // Fill the background of the rounded rectangle
                using (SolidBrush brush = new SolidBrush(this.BackColor))
                {
                    g.FillPath(brush, GetRoundedRectanglePath(ClientRectangle, BorderRadius));
                }
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

        // Accessor to modify inner TextBox properties
        public override string Text
        {
            get { return innerTextBox.Text; }
            set { innerTextBox.Text = value; }
        }

        public Color InnerTextBoxBackColor
        {
            get { return innerTextBox.BackColor; }
            set { innerTextBox.BackColor = value; }
        }

        public Color InnerTextBoxForeColor
        {
            get { return innerTextBox.ForeColor; }
            set { innerTextBox.ForeColor = value; }
        }
    }
}

using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace CAPSTONE_STOLE_ADMIN
{
    public class BorderRadiusDataGridView : UserControl
    {
        private DataGridView innerDataGridView;
        public int BorderRadius { get; set; } = 10;
        public Color BorderColor { get; set; } = Color.White;
        public int BorderSize { get; set; } = 2;

        public BorderRadiusDataGridView()
        {
            // Initialize inner DataGridView
            innerDataGridView = new DataGridView
            {
                BorderStyle = BorderStyle.None,
                Dock = DockStyle.Fill,
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                AllowUserToResizeColumns = true,
                AllowUserToResizeRows = false,
                ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize,
                BackgroundColor = this.BackColor,
                ForeColor = this.ForeColor
            };

            this.Padding = new Padding(BorderSize);
            this.Controls.Add(innerDataGridView);
            this.Size = new Size(400, 300);
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

        // Accessors for the embedded DataGridView
        public DataGridView DataGridView
        {
            get { return innerDataGridView; }
        }

        public Color InnerDataGridViewBackColor
        {
            get { return innerDataGridView.BackgroundColor; }
            set { innerDataGridView.BackgroundColor = value; }
        }

        public Color InnerDataGridViewForeColor
        {
            get { return innerDataGridView.ForeColor; }
            set { innerDataGridView.ForeColor = value; }
        }

        // Expose DataGridView columns
        public DataGridViewColumnCollection Columns
        {
            get { return innerDataGridView.Columns; }
        }

        // Add rows directly to the embedded DataGridView
        public void AddRow(params object[] values)
        {
            innerDataGridView.Rows.Add(values);
        }
    }
}

using System;
using System.Drawing;
using System.Windows.Forms;

namespace CAPSTONE_STOLE_ADMIN
{
    public class FlatDataGridView : DataGridView
    {
        public FlatDataGridView()
        {
            // Remove the row header (the extra space on the left side)
            this.RowHeadersVisible = false;

            // Remove the border styles to make it flat
            this.BorderStyle = BorderStyle.None;

            // Customize cell border style for flat look
            this.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

            // Set background color for a clean look
            this.BackgroundColor = Color.White;
            this.EnableHeadersVisualStyles = false;

            // Flat UI style for the header
            this.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 45, 48);
            this.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            this.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(45, 45, 48);
            this.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Flat UI style for the rows
            this.DefaultCellStyle.SelectionBackColor = Color.FromArgb(50, 50, 50);
            this.DefaultCellStyle.SelectionForeColor = Color.White;
            this.DefaultCellStyle.BackColor = Color.White;
            this.DefaultCellStyle.ForeColor = Color.Black;

            // Remove the extra bottom space by setting AutoSizeRowsMode to None
            this.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

            // Adjust the row height to remove extra white spaces at the bottom
            this.RowTemplate.Height = 30; // Set a fixed height, adjust as needed

            // Disable row resizing to prevent unwanted spacing
            this.AllowUserToResizeRows = false;

            // Set grid color for a flat, clean look
            this.GridColor = Color.LightGray;
        }

        protected override void OnRowPrePaint(DataGridViewRowPrePaintEventArgs e)
        {
            base.OnRowPrePaint(e);

            // Remove extra padding by setting it to zero
            this.Rows[e.RowIndex].DefaultCellStyle.Padding = new Padding(0);
        }

        // Optionally, override the painting of the grid to ensure no extra space at the bottom
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Check if there is extra space at the bottom and fill it with background color
            Rectangle rect = this.ClientRectangle;
            int headerHeight = this.ColumnHeadersHeight;
            int rowHeight = this.Rows.GetRowsHeight(DataGridViewElementStates.Visible);
            int emptySpaceHeight = rect.Height - (headerHeight + rowHeight);

            if (emptySpaceHeight > 0)
            {
                using (Brush brush = new SolidBrush(this.BackgroundColor))
                {
                    e.Graphics.FillRectangle(brush, new Rectangle(0, rect.Height - emptySpaceHeight, rect.Width, emptySpaceHeight));
                }
            }
        }
    }
}

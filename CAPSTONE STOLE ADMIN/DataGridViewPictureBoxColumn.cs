using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAPSTONE_STOLE_ADMIN
{
    public class DataGridViewPictureBoxColumn : DataGridViewColumn
    {
        public DataGridViewPictureBoxColumn() : base(new DataGridViewPictureBoxCell())
        {
        }
    }

    public class DataGridViewPictureBoxCell : DataGridViewTextBoxCell
    {
        public override Type EditType => typeof(BorderRadiusPictureBox);

        public override Type ValueType => typeof(Image);

        public override object DefaultNewRowValue => null;

        protected override void Paint(Graphics graphics, Rectangle clipBounds, Rectangle cellBounds, int rowIndex, DataGridViewElementStates cellState, object value, object formattedValue, string errorText, DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle advancedBorderStyle, DataGridViewPaintParts paintParts)
        {
            base.Paint(graphics, clipBounds, cellBounds, rowIndex, cellState, value, formattedValue, errorText, cellStyle, advancedBorderStyle, paintParts);

            // Cast the value to an image (what we expect for the profile picture)
            if (value is Image img)
            {
                // Create a BorderRadiusPictureBox control and use its drawing logic here
                using (BorderRadiusPictureBox picBox = new BorderRadiusPictureBox())
                {
                    picBox.Image = img;
                    picBox.BorderStyle = BorderStyle.FixedSingle;
                    picBox.BorderRadius = 10;  // Set the border radius for rounded corners
                    picBox.Width = cellBounds.Width;
                    picBox.Height = cellBounds.Height;

                    // Draw the picture box inside the cell
                    picBox.DrawToBitmap((Bitmap)formattedValue, new Rectangle(0, 0, picBox.Width, picBox.Height));
                    graphics.DrawImage((Bitmap)formattedValue, cellBounds.Location);
                }
            }
        }
    }

}

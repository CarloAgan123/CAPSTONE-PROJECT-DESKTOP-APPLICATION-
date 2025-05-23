using MaterialSkin.Controls;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace CAPSTONE_STOLE_ADMIN
{
    [Designer("System.Windows.Forms.Design.ControlDesigner, System.Design", typeof(System.ComponentModel.Design.IDesigner))]
    public class CustomMaterialLabel : MaterialLabel
    {
        private Color _textColor = Color.Black;
        private Color _backgroundColor = Color.Transparent;

        public CustomMaterialLabel()
        {
            // Ensure default values for the designer
            _textColor = Color.Black;
            _backgroundColor = Color.Transparent;
        }

        [Category("Appearance")]
        [Description("The color of the text.")]
        public Color TextColor
        {
            get { return _textColor; }
            set { _textColor = value; Invalidate(); }
        }

        [Category("Appearance")]
        [Description("The background color of the label.")]
        public Color BackgroundColor
        {
            get { return _backgroundColor; }
            set { _backgroundColor = value; Invalidate(); }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.Clear(_backgroundColor);
            TextRenderer.DrawText(e.Graphics, Text, Font, ClientRectangle, _textColor);
        }

        protected override void OnPaintBackground(PaintEventArgs pevent)
        {
            // Prevent the base class from painting the default background
        }
    }
}

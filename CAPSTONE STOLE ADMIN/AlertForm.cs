using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAPSTONE_STOLE_ADMIN
{
    public partial class AlertForm : Form
    {
        public AlertForm()
        {
            InitializeComponent();
        }
        public Color BackColorAlrtBox
        {
            get { return this.BackColor; }
            set { this.BackColor = value; }
        }
        public Color ColorAlertBox
        {
            get { return this.panelAlertBox.BackColor; }
            set { panelAlertBox.BackColor = textAlertTitle.ForeColor = textAlertMessage.ForeColor = value; }

        }
        public Image IconeAlertBox
        {
            get { return picAlertBox.Image; }
            set { picAlertBox.Image = value; }
        }
        public string TitleAlertBox
        {
            get { return textAlertMessage.Text; }
            set { textAlertMessage.Text = value;}
        }
        public string TextAlertBox
        {
            get { return textAlertTitle.Text; }
            set { textAlertTitle.Text = value; }
        }

        private void positionAlertBox()
        {
            int xPos = 0; int yPos = 0;
            xPos = Screen.GetWorkingArea(this).Width;
            yPos = Screen.GetWorkingArea(this).Height;
            this.Location = new Point(xPos - this.Width, yPos - this.Height);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panelAlertBox.Width += 2;
            if (panelAlertBox.Width >= 500)
            {
                timer1.Stop(); 
                this.Close();
            }
        }

        private void AlertForm_Load(object sender, EventArgs e)
        {
            positionAlertBox();
            timer1.Start(); 
        }


        private void panelAlertBox_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textAlertMessage_Click(object sender, EventArgs e)
        {

        }

        private void textAlertTitle_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

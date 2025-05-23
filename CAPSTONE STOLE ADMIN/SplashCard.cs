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
    public partial class SplashCard : Form
    {
        public SplashCard()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 3;
            if (panel2.Width > 702)
            {
                timer1.Stop();
                LoginStallForm login = new LoginStallForm();
                login.Show();
                this.Hide();
            }
        }
    }
}

using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using MaterialSkin.Controls;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAPSTONE_STOLE_ADMIN
{
    public partial class ModalSignUpForm : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "KXRrGtSOtbGJPkIKyfP8s2tpfvSSYXuzbvL61Qyx",
            BasePath = "https://admin-825a9-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;
        public ModalSignUpForm()
        {
            InitializeComponent();
            InitializeFirebaseClient();
        }

        private void InitializeFirebaseClient()
        {
            try
            {
                client = new FireSharp.FirebaseClient(config);
                if (client == null)
                {
                    MessageBox.Show("Failed to connect to the Firebase server", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to connect to the Firebase server {ex}");
            }
        }

        void AlertBox(Color backColor, Color color, string title, string text, Image icon)
        {
            AlertForm frm = new AlertForm
            {
                BackColor = backColor,
                ColorAlertBox = color,
                TitleAlertBox = title,
                TextAlertBox = text,
                IconeAlertBox = icon
            };
            frm.ShowDialog();
        }

        private void modalEffect_Timer_Tick(object sender, EventArgs e)
        {
            if (Opacity >= 1)
            {
                modalEffect_Timer.Stop();
            }
            else
            {
                Opacity += .03;
            }

            int y = Stall_Registration_Form.parentY += 3;
            this.Location = new Point(Stall_Registration_Form.parentX + 220, y);
            if (y >= i)
            {
                modalEffect_Timer.Stop();
            }
        }
        int i;
        private void ModalSignUpForm_Load(object sender, EventArgs e)
        {
            i = Stall_Registration_Form.parentX + 150;
            this.Location = new Point(Stall_Registration_Form.parentX + 220, Stall_Registration_Form.parentY + 150);
        }

        private void BackStepButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void ShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPasswordCheckBox.Checked)
            {
                passwordtxtb.PasswordChar = '\0';
                cnfpasstxtb.PasswordChar = '\0';
            }
            else
            {
                passwordtxtb.PasswordChar = '*';
                cnfpasstxtb.PasswordChar = '*';
            }
        }

        private void passwordtxtb_MouseDown(object sender, MouseEventArgs e)
        {
            /*if (!Regex.IsMatch(passwordtxtb.Text, @"[A-Z]") || !Regex.IsMatch(passwordtxtb.Text, @"[a-z]") ||
                !Regex.IsMatch(passwordtxtb.Text, @"[0-9]") || !Regex.IsMatch(passwordtxtb.Text, @"[\W_]") || passwordtxtb.TextLength < 8)
            {
                PasswordTextCheckerLabel.Text = "Password must be 8 characters long and contain at least one upper case character, one lower case\r\none number, and one symbol '@#^/'";

            }
            else
            {
                PasswordTextCheckerLabel.Text = "";
            }*/
        }

        private void cnfpasstxtb_MouseDown(object sender, MouseEventArgs e)
        {

            /*if (cnfpasstxtb.TextLength >= 8)
            {
                if (cnfpasstxtb.Text == passwordtxtb.Text)
                {
                    PasswordTextCheckerLabel.Text = "Password match! ✔";
                    SignUpButton.Enabled = true;
                }
                if (cnfpasstxtb.Text != passwordtxtb.Text)
                {
                    PasswordTextCheckerLabel.Text = "Password did not match!";
                }
                else
                {
                    PasswordTextCheckerLabel.Text = "";
                }
            }*/
        }

        private void emailtxtb_MouseDown(object sender, MouseEventArgs e)
        {
            /*if (!Regex.IsMatch(emailtxtb.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                EmailTextCheckerLabel.Text = "Email must constain valid @gmail.com. It must be valid";
            }
            else
            {
                EmailTextCheckerLabel.Text = "";
            }*/
        }

        public string InpuEmail
        {
            get {return emailtxtb.Text; }
        }
        public string InputPassword
        {
            get { return passwordtxtb.Text;}
        }

        private async void SignUpButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(emailtxtb.Text) || string.IsNullOrWhiteSpace(passwordtxtb.Text) ||
                !Regex.IsMatch(passwordtxtb.Text, @"[A-Z]") || !Regex.IsMatch(passwordtxtb.Text, @"[a-z]") ||
                !Regex.IsMatch(passwordtxtb.Text, @"[0-9]") || !Regex.IsMatch(passwordtxtb.Text, @"[\W_]") ||
                cnfpasstxtb.Text != passwordtxtb.Text)
            {
                AlertBox(Color.Coral, Color.SeaGreen, "Error", "Please ensure all fields are filled correctly and password is strong!", Properties.Resources.icons8_error_48);
                return;
            }

            if (await IsEmailRegistered(emailtxtb.Text))
            {
                AlertBox(Color.Coral, Color.SeaGreen, "Error", "The email is already registered. Please use a different email.", Properties.Resources.icons8_error_48);
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private async Task<bool> IsEmailRegistered(string email)
        {
            FirebaseResponse getResponse = await client.GetAsync($"adminInformation/");
            if (getResponse.StatusCode == System.Net.HttpStatusCode.OK && getResponse.Body != "null")
            {
                var existingData = JsonConvert.DeserializeObject<Dictionary<string, dynamic>>(getResponse.Body);
                foreach (var item in existingData)
                {
                    if (item.Value.email == email)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private void emailtxtb_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(emailtxtb.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                EmailTextCheckerLabel.Text = "Email must constain valid @gmail.com. It must be valid";
            }
            else
            {
                EmailTextCheckerLabel.Text = "";
            }
        }

        private void passwordtxtb_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(passwordtxtb.Text, @"[A-Z]") || !Regex.IsMatch(passwordtxtb.Text, @"[a-z]") ||
                !Regex.IsMatch(passwordtxtb.Text, @"[0-9]") || !Regex.IsMatch(passwordtxtb.Text, @"[\W_]") || passwordtxtb.TextLength < 8)
            {
                PasswordTextCheckerLabel.Text = "Password must be 8 characters long and contain at least one upper case character, one lower case\r\none number, and one symbol '@#^/'";

            }
            else
            {
                PasswordTextCheckerLabel.Text = "";
            }
        }

        private void cnfpasstxtb_TextChanged(object sender, EventArgs e)
        {
            if (cnfpasstxtb.TextLength >= 8)
            {
                if (cnfpasstxtb.Text == passwordtxtb.Text)
                {
                    PasswordTextCheckerLabel.Text = "Password match! ✔";
                    SignUpButton.Enabled = true;
                }
                if (cnfpasstxtb.Text != passwordtxtb.Text)
                {
                    PasswordTextCheckerLabel.Text = "Password did not match!";
                }
                else
                {
                    PasswordTextCheckerLabel.Text = "";
                }
            }
        }
    }
}

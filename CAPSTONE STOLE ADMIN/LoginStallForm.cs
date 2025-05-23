using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using FireSharp.Config;
using FireSharp.Interfaces;
using Google.Apis.Auth.OAuth2;
using System.IO;
using Newtonsoft.Json;
using System.Net.Http;
using static System.Windows.Forms.AxHost;
using FireSharp.Response;

namespace CAPSTONE_STOLE_ADMIN
{
    public partial class LoginStallForm : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "KXRrGtSOtbGJPkIKyfP8s2tpfvSSYXuzbvL61Qyx",
            BasePath = "https://admin-825a9-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;

        private readonly string apiKey = "AIzaSyCaIpD2cyU_YQeNfy_zJ9-dQ-BSuAYo2CI";
        private string userUID;


        public static int parentX, parentY;


        private int borderRadius = 10;
        private int borderSize = 5;
        private Color borderColor = Color.White;

        private int finalY;
        private int startY;
        private int animationStep = 10;

        public LoginStallForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Padding = new Padding(borderSize);
            this.BackColor = borderColor;

            client = new FireSharp.FirebaseClient(config);
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

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private GraphicsPath GetRoundedPath(Rectangle rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }

        private void FormRegionAndBorder(Form form, float radius, Graphics graph, Color borderColor, float borderSize)
        {
            if (this.WindowState != FormWindowState.Minimized)
            {
                using (GraphicsPath roundPath = GetRoundedPath(form.ClientRectangle, radius))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                using (Matrix transform = new Matrix())
                {
                    graph.SmoothingMode = SmoothingMode.AntiAlias;
                    form.Region = new Region(roundPath);
                    if (borderSize >= 1)
                    {
                        Rectangle rect = form.ClientRectangle;
                        float scaleX = 1.0F - ((borderSize + 1) / rect.Width);
                        float scaleY = 1.0F - ((borderSize + 1) / rect.Height);

                        transform.Scale(scaleX, scaleY);
                        transform.Translate(borderSize / 1.6F, borderSize / 1.6F);

                        graph.Transform = transform;
                        graph.DrawPath(penBorder, roundPath);
                    }
                }
            }
        }

        private void DrawPath(Rectangle rect, Graphics graph, Color color)
        {
            using (GraphicsPath roundPath = GetRoundedPath(rect, borderRadius))
            using (Pen penBorder = new Pen(color, 3))
            {
                graph.DrawPath(penBorder, roundPath);
            }

        }

        private struct FormBoundsColors
        {
            public Color TopLeftColor;
            public Color TopRightColor;
            public Color BottomLeftColor;
            public Color BottomRightColor;
        }
        private FormBoundsColors GetFormBoundsColors()
        {
            var fbColor = new FormBoundsColors();
            using (var bmp = new Bitmap(1, 1))
            using (Graphics graph = Graphics.FromImage(bmp))
            {
                Rectangle rectBmp = new Rectangle(0, 0, 1, 1);

                //Top Left
                rectBmp.X = this.Bounds.X - 1;
                rectBmp.Y = this.Bounds.Y;
                graph.CopyFromScreen(rectBmp.Location, Point.Empty, rectBmp.Size);
                fbColor.TopLeftColor = bmp.GetPixel(0, 0);

                //Top Right
                rectBmp.X = this.Bounds.Right;
                rectBmp.Y = this.Bounds.Y;
                graph.CopyFromScreen(rectBmp.Location, Point.Empty, rectBmp.Size);
                fbColor.TopRightColor = bmp.GetPixel(0, 0);

                //Bottom Left
                rectBmp.X = this.Bounds.X;
                rectBmp.Y = this.Bounds.Bottom;
                graph.CopyFromScreen(rectBmp.Location, Point.Empty, rectBmp.Size);
                fbColor.BottomLeftColor = bmp.GetPixel(0, 0);

                //Bottom Right
                rectBmp.X = this.Bounds.Right;
                rectBmp.Y = this.Bounds.Bottom;
                graph.CopyFromScreen(rectBmp.Location, Point.Empty, rectBmp.Size);
                fbColor.BottomRightColor = bmp.GetPixel(0, 0);
            }
            return fbColor;
        }
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            Rectangle rectForm = this.ClientRectangle;
            int mWidht = rectForm.Width / 2;
            int mHeight = rectForm.Height / 2;
            var fbColors = GetFormBoundsColors();

            DrawPath(rectForm, e.Graphics, fbColors.TopLeftColor);

            Rectangle rectTopRight = new Rectangle(mWidht, rectForm.Y, mWidht, mHeight);
            DrawPath(rectTopRight, e.Graphics, fbColors.TopRightColor);

            Rectangle rectBottomLeft = new Rectangle(rectForm.X, rectForm.X + mWidht, mWidht, mHeight);
            DrawPath(rectBottomLeft, e.Graphics, fbColors.BottomLeftColor);

            Rectangle rectBottomRight = new Rectangle(mWidht, rectForm.Y + mHeight, mWidht, mHeight);
            DrawPath(rectBottomRight, e.Graphics, fbColors.BottomRightColor);


        }

        private void LoginStallForm_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            Rectangle rectForm = this.ClientRectangle;
            int mWidht = rectForm.Width / 2;
            int mHeight = rectForm.Height / 2;
            var fbColors = GetFormBoundsColors();
            DrawPath(rectForm, e.Graphics, fbColors.TopLeftColor);
            //Top Right
            Rectangle rectTopRight = new Rectangle(mWidht, rectForm.Y, mWidht, mHeight);
            DrawPath(rectTopRight, e.Graphics, fbColors.TopRightColor);
            //Bottom Left
            Rectangle rectBottomLeft = new Rectangle(rectForm.X, rectForm.X + mHeight, mWidht, mHeight);
            DrawPath(rectBottomLeft, e.Graphics, fbColors.BottomLeftColor);
            //Bottom Right
            Rectangle rectBottomRight = new Rectangle(mWidht, rectForm.Y + mHeight, mWidht, mHeight);
            DrawPath(rectBottomRight, e.Graphics, fbColors.BottomRightColor);
            //-> SET ROUNDED REGION AND BORDER
            FormRegionAndBorder(this, borderRadius, e.Graphics, borderColor, borderSize);
        }

        private void LoginStallForm_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private async void LoginButton_Click(object sender, EventArgs e)
        {
            using (var loadingDialog = new LoadingDialog())
            {
                loadingDialog.Show();
                if (string.IsNullOrWhiteSpace(EmailTextBox.Text) || string.IsNullOrWhiteSpace(PasswordTextBox.Text))
                {
                    loadingDialog.Close();
                    AlertBox(Color.Coral, Color.SeaGreen, "Please enter both email and password.", "ERROR", Properties.Resources.icons8_error_48);
                    return;
                }

                if (await IsEmailInDatabase(EmailTextBox.Text))
                {
                    if (await SignInWithFirebase(EmailTextBox.Text, PasswordTextBox.Text))
                    {
                        loadingDialog.Close();
                        AlertBox(Color.SeaGreen, Color.White, "Login successful!", "SUCCESS", Properties.Resources.icons8_success_48);
                        this.Hide();
                        Main_DashBoard dashboard = new Main_DashBoard(userUID);
                        dashboard.Show();
                    }
                    else
                    {
                        loadingDialog.Close();
                        AlertBox(Color.Coral, Color.SeaGreen, "Login failed. Please check your email and password.", "ERROR", Properties.Resources.icons8_error_48);
                    }
                }
                else
                {
                    loadingDialog.Close();
                    AlertBox(Color.Coral, Color.SeaGreen, "This email is not registered. Please sign up first.", "ERROR", Properties.Resources.icons8_error_48);
                }
            }
        }


        private async Task<bool> IsEmailInDatabase(string email)
        {
            FirebaseResponse getResponse = await client.GetAsync("adminInformation/");
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

        private async Task<bool> SignInWithFirebase(string email, string password)
        {
            using (var httpClient = new HttpClient())
            {
                var requestBody = new
                {
                    email,
                    password,
                    returnSecureToken = true
                };

                var json = JsonConvert.SerializeObject(requestBody);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await httpClient.PostAsync($"https://identitytoolkit.googleapis.com/v1/accounts:signInWithPassword?key={apiKey}", content);

                var responseBody = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    dynamic authResponse = JsonConvert.DeserializeObject(responseBody);
                    userUID = authResponse.localId;
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        private void GotoSignUpButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Stall_Registration_Form STF = new Stall_Registration_Form();
            STF.Show();
        }

        private void ShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!ShowPasswordCheckBox.Checked)
            {
                PasswordTextBox.PasswordChar = '*';
            }
            if (ShowPasswordCheckBox.Checked)
            {
                PasswordTextBox.PasswordChar = '\0';
            }
        }

        private void ForgotPasswordLabel_Click(object sender, EventArgs e)
        {
            Form modalBackground = new Form();
            using (ForgotPasswordDialogForm modal = new ForgotPasswordDialogForm())
            {
                modalBackground.StartPosition = FormStartPosition.Manual;
                modalBackground.FormBorderStyle = FormBorderStyle.None;
                modalBackground.Opacity = .50d;
                modalBackground.BackColor = Color.Black;
                modalBackground.Size = this.Size;
                modalBackground.Location = this.Location;
                modalBackground.ShowInTaskbar = false;
                modalBackground.Show();
                modal.Owner = modalBackground;

                parentX = this.Location.X;
                parentY = this.Location.Y;

                DialogResult result = modal.ShowDialog();
                modalBackground.Dispose();
            }
        }


    }
}

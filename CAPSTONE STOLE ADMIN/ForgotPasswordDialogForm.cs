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

namespace CAPSTONE_STOLE_ADMIN
{
    public partial class ForgotPasswordDialogForm : Form
    {
        private int borderRadius = 10;
        private int borderSize = 5;
        private Color borderColor = Color.White;

        private static readonly string FirebaseApiKey = "AIzaSyCaIpD2cyU_YQeNfy_zJ9-dQ-BSuAYo2CI";

        private int finalY;
        private int startY;
        private int animationStep = 10;

        public ForgotPasswordDialogForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Padding = new Padding(borderSize);
            this.BackColor = borderColor;
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

        private void ForgotPasswordDialogForm_MouseDown(object sender, MouseEventArgs e)
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

            Rectangle rectTopRight = new Rectangle(mWidht,rectForm.Y,mWidht,mHeight);
            DrawPath(rectTopRight, e.Graphics, fbColors.TopRightColor);

            Rectangle rectBottomLeft = new Rectangle(rectForm.X,rectForm.X + mWidht, mWidht, mHeight);
            DrawPath(rectBottomLeft, e.Graphics, fbColors.BottomLeftColor);

            Rectangle rectBottomRight = new Rectangle(mWidht,rectForm.Y + mHeight, mWidht, mHeight);
            DrawPath(rectBottomRight, e.Graphics, fbColors.BottomRightColor);


        }
        private void ForgotPasswordDialogForm_Paint(object sender, PaintEventArgs e)
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

        private void ForgotPasswordDialogForm_ResizeEnd(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void ForgotPasswordDialogForm_SizeChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void ForgotPasswordDialogForm_Activated(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private async void SendEmailButton_Click(object sender, EventArgs e)
        {
            string email = EmailTextbox.Text;
            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Please enter a valid email.");
                return;
            }
            if (!EmailTextbox.Text.Contains("@gmail.com"))
            {
                MessageBox.Show("Invalid Gmail address!");
            }
            await SendPasswordResetEmailAsync(email);
        }
        private async Task SendPasswordResetEmailAsync(string email)
        {
            using (var client = new HttpClient())
            {
                var url = $"https://identitytoolkit.googleapis.com/v1/accounts:sendOobCode?key={FirebaseApiKey}";
                var data = new
                {
                    requestType = "PASSWORD_RESET",
                    email = email
                };

                var jsonData = JsonConvert.SerializeObject(data);
                var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

                try
                {
                    var response = await client.PostAsync(url, content);
                    response.EnsureSuccessStatusCode();

                    MessageBox.Show("Password reset email sent successfully.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }

        private void modalEffect_Timer_Tick(object sender, EventArgs e)
        {
            if (this.Location.Y < finalY)
            {
                this.Location = new Point(this.Location.X, this.Location.Y + animationStep);
            }

            if (Opacity < 1)
            {
                Opacity += 0.03;
            }

            if (this.Location.Y >= finalY && Opacity >= 1)
            {
                modalEffect_Timer.Stop();
            }
        }
        int i;
        private void ForgotPasswordDialogForm_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.Manual;

            startY = -this.Height;
            finalY = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;

            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2, startY);

            modalEffect_Timer.Interval = 15;
            modalEffect_Timer.Tick += modalEffect_Timer_Tick;
            modalEffect_Timer.Start();
        }

        private void BackLoginButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}

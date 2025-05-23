using Emgu.CV;
using Firebase.Storage;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAPSTONE_STOLE_ADMIN
{
    public partial class PaymentMethodGCash : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "KXRrGtSOtbGJPkIKyfP8s2tpfvSSYXuzbvL61Qyx",
            BasePath = "https://admin-825a9-default-rtdb.firebaseio.com/"
        };
        private readonly string apiKey = "AIzaSyCaIpD2cyU_YQeNfy_zJ9-dQ-BSuAYo2CI";
        private const string FirebaseStorageUrl = "admin-825a9.appspot.com";
        private string selectedImagePath = "";
        IFirebaseClient client;

        public string userUID;

        private int finalY;
        private int startY;
        private int animationStep = 10;

        public PaymentMethodGCash(string UserUID)
        {
            InitializeComponent();
            InitializeFirebaseClient();
            userUID = UserUID;
            LoadImageFromFirebase(UserUID);
        }

        private void AlertBox(Color backColor, Color color, string title, string text, Image icon)
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
        private void InitializeFirebaseClient()
        {
            try
            {
                client = new FireSharp.FirebaseClient(config);
                if (client == null)
                {
                    AlertBox(Color.Coral, Color.SeaGreen,"ERROR", "Failed to connect to the Firebase server", Properties.Resources.icons8_error_48);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to connect to the Firebase server {ex}");
            }
        }

        private async void LoadImageFromFirebase(string UserUID)
        {
            FirebaseResponse response = await client.GetAsync($"StallPaymentMethods/{UserUID}");
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var userData = JsonConvert.DeserializeObject<StallPaymentMethods>(response.Body);
                if (userData != null)
                {
                    var image = await LoadImageFromUrl(userData.stallGCashQRCode);
                    if (image != null)
                    {
                        GCashImage.Image = image;
                    }
                }
            }
        }

        
        private async Task<Image> LoadImageFromUrl(string imageUrl)
        {
            try
            {
                using (var httpClient = new HttpClient())
                {
                    var imageBytes = await httpClient.GetByteArrayAsync(imageUrl);
                    using (var ms = new MemoryStream(imageBytes))
                    {
                        return Image.FromStream(ms);
                    }
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        private void BrowseImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                GCashImage.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async Task<string> UploadImageToFirebaseAsync(Image image, string fileName)
        {
            try
            {
                using (var stream = new MemoryStream())
                {
                    image.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                    stream.Position = 0;

                    var storage = new FirebaseStorage(FirebaseStorageUrl);
                    var uploadTask = storage
                        .Child("StallProfile")
                        .Child(fileName)
                        .PutAsync(stream);

                    string downloadUrl = await uploadTask;
                    return downloadUrl;
                }
            }
            catch (IOException ioEx)
            {
                Console.WriteLine($"I/O Error: {ioEx.Message}");
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while uploading the image: {ex.Message}");
                return null;
            }
        }

        private async void SaveGCashImageButton_Click(object sender, EventArgs e)
        {
            using (var loading = new LoadingDialog())
            {
                loading.Show();
                string imageUrl = await UploadImageToFirebaseAsync(GCashImage.Image, $"{userUID}_{Guid.NewGuid()}.png");
                if (imageUrl == null)
                {
                    MessageBox.Show("Please select an image file");
                }

                var stallPaymentMethods = new
                {
                    stallGCashQRCode = imageUrl
                };

                FirebaseResponse response = await client.UpdateAsync($"StallPaymentMethods/{userUID}", stallPaymentMethods);
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    loading.Close();
                    this.Close();
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
        private void PaymentMethodGCash_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.Manual;

            startY = -this.Height;
            finalY = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;

            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2, startY);

            modalEffect_Timer.Interval = 15;
            modalEffect_Timer.Tick += modalEffect_Timer_Tick;
            modalEffect_Timer.Start();
        }
    }
}

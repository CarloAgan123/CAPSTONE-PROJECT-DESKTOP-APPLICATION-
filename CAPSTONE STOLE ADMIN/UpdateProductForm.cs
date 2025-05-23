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
    public partial class UpdateProductForm : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "KXRrGtSOtbGJPkIKyfP8s2tpfvSSYXuzbvL61Qyx",
            BasePath = "https://admin-825a9-default-rtdb.firebaseio.com/"
        };
        private readonly string apiKey = "AIzaSyCaIpD2cyU_YQeNfy_zJ9-dQ-BSuAYo2CI";
        private const string FirebaseStorageUrl = "admin-825a9.appspot.com";
        IFirebaseClient client;
        private string selectedImagePath = "";
        private string existingProductImageUrl = "";
        private string productId;

        private int finalY;
        private int startY;
        private int animationStep = 10;


        public UpdateProductForm(string productId)
        {
            InitializeComponent();
            InitializeFirebaseClient();
            this.productId = productId;
            FetchProductFromFirebase(productId);
        }
        private void InitializeFirebaseClient()
        {
            try
            {
                client = new FireSharp.FirebaseClient(config);
                if (client == null)
                {
                    MessageBox.Show("Failed to connect. Check your connection", "FAILED", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to connect to the Firebase server {ex}");
            }
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
        private async void FetchProductFromFirebase(string productId)
        {
            FirebaseResponse response = await client.GetAsync($"Products/{productId}");
            if (response.Body == "null")
            {
                MessageBox.Show("No product found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                ProductData productData = null;

                try
                {
                    productData = JsonConvert.DeserializeObject<ProductData>(response.Body);
                }
                catch (JsonSerializationException)
                {
                    var productDictionary = JsonConvert.DeserializeObject<Dictionary<string, ProductData>>(response.Body);
                    productData = productDictionary?.Values.FirstOrDefault();
                }

                if (productData != null)
                {
                    existingProductImageUrl = productData.productImage;
                    TBAddProductName.Text = productData.productName;
                    TBAddProductPrice.Text = productData.productPrice;
                    TBAddProductCategory.Text = productData.productCategory;
                    TBAddProductStocks.Text = productData.productQuantity;
                    TBAddProductQualification.Text = productData.productIdentity;
                    TBAddProductDescription.Text = productData.productDescription;

                    if (!string.IsNullOrWhiteSpace(productData.productImage))
                    {
                        var image = await LoadImageFromUrl(productData.productImage);
                        if (image != null)
                        {
                            AddProductImage.Image = image;
                        }
                        else
                        {
                            MessageBox.Show("Failed to load image.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
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

        private void BrowseProductPicture_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Select an Image";
                openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedImagePath = openFileDialog.FileName;
                    try
                    {

                        AddProductImage.Image = Image.FromFile(selectedImagePath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred while displaying the image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
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
                MessageBox.Show($"I/O Error: {ioEx.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while uploading the image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private async void UpdateProductButton_Click(object sender, EventArgs e)
        {
            using (var loading = new LoadingDialog())
            {
                loading.Show();
                string imageUrl = null;
                if (selectedImagePath != "")
                {
                    imageUrl = await UploadImageToFirebaseAsync(AddProductImage.Image, $"{productId}_{Guid.NewGuid()}.png");
                    if (imageUrl == null)
                    {
                        MessageBox.Show("Failed to upload the image. Please try again.", "Image Upload Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                var product = new
                {
                    productImage = imageUrl ?? existingProductImageUrl,
                    productName = TBAddProductName.Text,
                    productPrice = TBAddProductPrice.Text,
                    productQuantity = TBAddProductStocks.Text,
                    productIdentity = TBAddProductQualification.Text,
                    productCategory = TBAddProductCategory.Text,
                    productDescription = TBAddProductDescription.Text
                };

                try
                {
                    FirebaseResponse response = await client.UpdateAsync($"Products/{productId}", product);
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        loading.Close();
                        AlertBox(Color.Green, Color.Blue, "Success", "Product successfully updated!", Properties.Resources.icons8_success_48);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        loading.Close();
                        MessageBox.Show("Failed to update product. Please try again.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    loading.Close();
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }
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
        }
        int i;
        private void UpdateProductForm_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;

            modalEffect_Timer.Start();
        }
    }
}

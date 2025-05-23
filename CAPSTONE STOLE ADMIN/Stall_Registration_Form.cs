using Firebase.Storage;
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
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAPSTONE_STOLE_ADMIN
{
    public partial class Stall_Registration_Form : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "KXRrGtSOtbGJPkIKyfP8s2tpfvSSYXuzbvL61Qyx",
            BasePath = "https://admin-825a9-default-rtdb.firebaseio.com/"
        };

        private const string FirebaseStorageUrl = "admin-825a9.appspot.com";
        IFirebaseClient client;
        private string selectedImagePath = "";
        private static readonly string apiKey = "AIzaSyCaIpD2cyU_YQeNfy_zJ9-dQ-BSuAYo2CI";

        private static readonly string FirebaseApiKey = "AIzaSyCaIpD2cyU_YQeNfy_zJ9-dQ-BSuAYo2CI";

        public static int parentX, parentY;
        public Stall_Registration_Form()
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
                MessageBox.Show($"Failed to connect to the Firebase server {ex}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void BrowseStallImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                picbox.Image = Image.FromFile(openFileDialog.FileName);
                selectedImagePath = openFileDialog.FileName;
            }
        }

        private async Task<bool> IsStallNumberRegistered(string stallNumber)
        {
            try
            {
                FirebaseResponse getResponse = await client.GetAsync("adminInformation/");

                if (getResponse.StatusCode == System.Net.HttpStatusCode.OK && getResponse.Body != "null")
                {
                    var existingData = JsonConvert.DeserializeObject<Dictionary<string, dynamic>>(getResponse.Body);

                    foreach (var item in existingData)
                    {
                        if (item.Value != null && item.Value.stallNumber == stallNumber)
                        {
                            return true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while checking stall number: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        private List<string> GetSelectedDays()
        {
            var selectedDays = new List<string>();
            if (mondaychckb.Checked) selectedDays.Add("Monday");
            if (tuesdaychckb.Checked) selectedDays.Add("Tuesday");
            if (wednesdaychckb.Checked) selectedDays.Add("Wednesday");
            if (thursdaychckb.Checked) selectedDays.Add("Thursday");
            if (fridaychckb.Checked) selectedDays.Add("Friday");
            if (saturdaychckb.Checked) selectedDays.Add("Saturday");
            if (sundaychckb.Checked) selectedDays.Add("Sunday");
            return selectedDays;
        }

        private async Task<string> UploadImageAsync(string filePath)
        {
            try
            {
                using (var stream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    var storage = new FirebaseStorage(FirebaseStorageUrl);
                    var imageUrl = await storage
                        .Child("images")
                        .Child(Path.GetFileName(filePath))
                        .PutAsync(stream);

                    var downloadUrl = await storage
                        .Child("images")
                        .Child(Path.GetFileName(filePath))
                        .GetDownloadUrlAsync();

                    return downloadUrl;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while uploading the image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private async void NextStepButton_Click(object sender, EventArgs e)
        {
            using (var loading = new LoadingDialog())
            {
                loading.Show();

                // Initial validations
                if (lastnametxtb.Text == "" || firstnametxtb.Text == "" ||
                    contactnotxtb.Text == "" || stallnametxtb.Text == "" || stallnumbertxtb.Text == "" ||
                    picbox.Image == null || (!mondaychckb.Checked && !tuesdaychckb.Checked &&
                    !wednesdaychckb.Checked && !thursdaychckb.Checked && !fridaychckb.Checked &&
                    !saturdaychckb.Checked && !sundaychckb.Checked))
                {
                    loading.Close();
                    AlertBox(Color.Coral, Color.SeaGreen, "Error", "Please fill out all required fields!", Properties.Resources.icons8_error_48);
                    return;
                }

                // Stall number validations
                if (!Regex.IsMatch(stallnumbertxtb.Text, @"[0-9]"))
                {
                    loading.Close();
                    AlertBox(Color.Coral, Color.SeaGreen, "Error", "Stall Number must be number and starts at zero!", Properties.Resources.icons8_error_48);
                    return;
                }

                if (Regex.IsMatch(stallnumbertxtb.Text, @"[A-Z]") || Regex.IsMatch(stallnumbertxtb.Text, @"[a-z]") || Regex.IsMatch(stallnumbertxtb.Text, @"[\W_]"))
                {
                    loading.Close();
                    AlertBox(Color.Coral, Color.SeaGreen, "Error", "Stall Number has invalid characters!", Properties.Resources.icons8_error_48);
                    return;
                }

                // Image selection validation
                if (string.IsNullOrEmpty(selectedImagePath))
                {
                    loading.Close();
                    AlertBox(Color.Coral, Color.SeaGreen, "Error", "Please select an image to upload!", Properties.Resources.icons8_error_48);
                    return;
                }
            }

            Form modalBackground = new Form();
            using (ModalSignUpForm modal = new ModalSignUpForm())
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

                if (result == DialogResult.OK)
                {
                    using (var loading = new LoadingDialog())
                    {
                        loading.Show();

                        if (await IsStallNumberRegistered(stallnumbertxtb.Text))
                        {
                            loading.Close();
                            AlertBox(Color.Coral, Color.SeaGreen, "Error", "Stall Number is already registered!", Properties.Resources.icons8_error_48);
                            return;
                        }

                        string StallImageUrl = await UploadImageAsync(selectedImagePath);
                        if (string.IsNullOrEmpty(StallImageUrl))
                        {
                            loading.Close();
                            AlertBox(Color.Coral, Color.SeaGreen, "Error", "Failed to upload image. Please try again.", Properties.Resources.icons8_error_48);
                            return;
                        }

                        string _email = modal.InpuEmail;
                        string password = modal.InputPassword;
                        string userUID = await SignUpWithFirebase(_email, password);

                        if (userUID == null)
                        {
                            AlertBox(Color.Coral, Color.SeaGreen, "Error", "Failed to register your account. Please try again later.", Properties.Resources.icons8_error_48);
                            return;
                        }

                        /*// Wait for the email verification status
                        bool isVerified = await IsEmailVerified(userUID);
                        if (!isVerified)
                        {
                            loading.Close();
                            AlertBox(Color.Orange, Color.White, "Verification Pending", "Please verify your email before proceeding.", Properties.Resources.icons8_information_48);
                            return;
                        }*/
                        var data = new
                        {
                            user_UID = userUID,
                            stallNumber = stallnumbertxtb.Text,
                            email = _email,
                            lastName = lastnametxtb.Text,
                            firstName = firstnametxtb.Text,
                            middlename = "",
                            contactNumber = contactnotxtb.Text,
                            timein = ophrsStartCmbb.SelectedItem.ToString(),
                            timeout = ophrsClseCmbb.SelectedItem.ToString(),
                            stallName = stallnametxtb.Text,
                            selectedDays = GetSelectedDays(),
                            Img = StallImageUrl
                        };

                        SetResponse response = await client.SetAsync($"adminInformation/{userUID}", data);
                        if (response.StatusCode == System.Net.HttpStatusCode.OK)
                        {
                            loading.Close();
                            AlertBox(Color.SeaGreen, Color.White, "Success", "Your account has been successfully registered!", Properties.Resources.icons8_success_48);

                            this.Hide();
                            Main_DashBoard dashboard = new Main_DashBoard(userUID);
                            dashboard.Show();
                        }
                        else
                        {
                            loading.Close();
                            AlertBox(Color.Coral, Color.SeaGreen, "Error", "Failed to save additional information. Please try again later.", Properties.Resources.icons8_error_48);
                        }
                    }
                }
                else
                {
                    AlertBox(Color.Gray, Color.White, "UNSUCCESS", "The Signup was cancelled.", Properties.Resources.icons8_bell_48);
                }
            }
        }


        private async Task<string> SignUpWithFirebase(string email, string password)
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

                var response = await httpClient.PostAsync($"https://identitytoolkit.googleapis.com/v1/accounts:signUp?key={apiKey}", content);
                var responseBody = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    dynamic authResponse = JsonConvert.DeserializeObject(responseBody);
                    string userUID = authResponse.localId; 
                    string idToken = authResponse.idToken; 

                    await SendVerificationEmailAsync(email, idToken);

                    bool isEmailVerified = await CheckEmailVerificationStatus(idToken);
                    MessageBox.Show("Your account has been successfully registered.");

                    return userUID;
                }
                else
                {
                    AlertBox(Color.Coral, Color.SeaGreen, "Error", "Email is already registered!", Properties.Resources.icons8_error_48);
                    return null;
                }
            }
        }


        private async Task SendVerificationEmailAsync(string email, string idToken)
        {
            using (var httpClient = new HttpClient())
            {
                var verifyUrl = $"https://identitytoolkit.googleapis.com/v1/accounts:sendOobCode?key={apiKey}";

                var verifyData = new
                {
                    requestType = "VERIFY_EMAIL",
                    idToken = idToken 
                };

                var jsonVerifyData = JsonConvert.SerializeObject(verifyData);
                var verifyContent = new StringContent(jsonVerifyData, Encoding.UTF8, "application/json");

                try
                {
                    var verifyResponse = await httpClient.PostAsync(verifyUrl, verifyContent);
                    var verifyResponseBody = await verifyResponse.Content.ReadAsStringAsync();

                    if (verifyResponse.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Verification email sent successfully.");
                    }
                    else
                    {
                        Console.WriteLine($"Error sending verification email: {verifyResponse.StatusCode} - {verifyResponseBody}");
                        MessageBox.Show($"Failed to send verification email. Response: {verifyResponseBody}");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Exception: {ex.Message}");
                    MessageBox.Show($"An error occurred while sending the verification email: {ex.Message}");
                }
            }
        }

        private async Task<bool> IsEmailVerified(string idToken)
        {
            using (var httpClient = new HttpClient())
            {
                var checkVerificationUrl = $"https://identitytoolkit.googleapis.com/v1/accounts:lookup?key={apiKey}";

                var requestBody = new
                {
                    idToken = idToken
                };

                var json = JsonConvert.SerializeObject(requestBody);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await httpClient.PostAsync(checkVerificationUrl, content);
                var responseBody = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    dynamic authResponse = JsonConvert.DeserializeObject(responseBody);
                    bool emailVerified = authResponse.users[0].emailVerified;
                    return emailVerified;
                }
                else
                {
                    Console.WriteLine($"Error checking email verification: {responseBody}");
                    return false;
                }
            }
        }

        private async Task<bool> CheckEmailVerificationStatus(string idToken)
        {
            using (var httpClient = new HttpClient())
            {
                var verifyUrl = $"https://identitytoolkit.googleapis.com/v1/accounts:lookup?key={apiKey}";

                var lookupData = new
                {
                    idToken = idToken 
                };

                var jsonLookupData = JsonConvert.SerializeObject(lookupData);

                try
                {
                    var lookupContent = new StringContent(jsonLookupData, Encoding.UTF8, "application/json");
                    var lookupResponse = await httpClient.PostAsync(verifyUrl, lookupContent);
                    var lookupResponseBody = await lookupResponse.Content.ReadAsStringAsync();

                    if (lookupResponse.IsSuccessStatusCode)
                    {
                        dynamic lookupResponseJson = JsonConvert.DeserializeObject(lookupResponseBody);
                        bool isEmailVerified = lookupResponseJson.users[0].emailVerified;

                        while (!isEmailVerified)
                        {
                            await Task.Delay(5000); 

                            lookupContent = new StringContent(jsonLookupData, Encoding.UTF8, "application/json");
                            lookupResponse = await httpClient.PostAsync(verifyUrl, lookupContent);
                            lookupResponseBody = await lookupResponse.Content.ReadAsStringAsync();

                            if (lookupResponse.IsSuccessStatusCode)
                            {
                                lookupResponseJson = JsonConvert.DeserializeObject(lookupResponseBody);
                                isEmailVerified = lookupResponseJson.users[0].emailVerified;
                            }
                        }

                        MessageBox.Show("Email verified successfully!");

                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Error while checking email verification status.");
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error while checking email verification status: {ex.Message}");
                    return false;
                }
            }
        }



        private void LoginButton_Click(object sender, EventArgs e)
        {
            LoginStallForm login = new LoginStallForm();
            login.Show();
            this.Close();
        }
    }
}

using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using MaterialSkin;
using MaterialSkin.Controls;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CAPSTONE_STOLE_ADMIN
{
    public partial class DialogForm : MaterialForm
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

        private int finalY; 
        private int startY;
        private int animationStep = 10;

        public string UserName { get; set; }

        private string currentUserUID;
        private string _userUID => currentUserUID;

        public DialogForm(string UserUID)
        {
            InitializeComponent();
            //InitializeMaterialSkin();
            InitializeFirebaseClient();
            currentUserUID = UserUID;

            this.FormBorderStyle = FormBorderStyle.None;
            this.Load += DialogForm_Load;
            LoadStallInfo();
        }
/*
        private void InitializeMaterialSkin()
        {
            var skin = MaterialSkinManager.Instance;
            skin.AddFormToManage(this);
            skin.Theme = MaterialSkinManager.Themes.DARK;
            skin.ColorScheme = new ColorScheme(
                Primary.Green800,
                Primary.Green900,
                Primary.Green500,
                Accent.Green200,
                TextShade.WHITE
            );
        }*/

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
                    AlertBox(Color.Coral, Color.SeaGreen, "Error", "Failed to connect to the Firebase server!", Properties.Resources.icons8_error_48);
                }
            }
            catch (Exception ex)
            {
                AlertBox(Color.Coral, Color.SeaGreen, "Error", $"Firebase initialization error: {ex.Message}", Properties.Resources.icons8_error_48);
            }
        }

        private async void btnOK_Click(object sender, EventArgs e)
        {
            using (var loading = new LoadingDialog())
            {
                loading.Show();
                if (string.IsNullOrWhiteSpace(StallFirstNameTextBox.Text) ||
                string.IsNullOrWhiteSpace(StallLastNameTextBox.Text) ||
                string.IsNullOrWhiteSpace(StallNumberTextBox.Text) ||
                string.IsNullOrWhiteSpace(StallStartOperatingHours.Text) ||
                string.IsNullOrWhiteSpace(StallEndOperatingHours.Text) ||
                string.IsNullOrWhiteSpace(StallNameTextBox.Text) ||
                string.IsNullOrWhiteSpace(StallContactNumber.Text))
                {
                    loading.Close();
                    AlertBox(Color.Coral, Color.SeaGreen, "Error", "Fill all input fields", Properties.Resources.icons8_error_48);
                    return;
                }

                if (!mondaychckb.Checked && !tuesdaychckb.Checked && !wednesdaychckb.Checked &&
                    !thursdaychckb.Checked && !fridaychckb.Checked && !saturdaychckb.Checked &&
                    !sundaychckb.Checked)
                {
                    loading.Close();
                    AlertBox(Color.Coral, Color.SeaGreen, "Error", "At least one checkbox must be checked!", Properties.Resources.icons8_error_48);
                    return;
                }

                var updatedData = new
                {
                    stallNumber = StallNumberTextBox.Text,
                    firstName = StallFirstNameTextBox.Text,
                    lastName = StallLastNameTextBox.Text,
                    contactNumber = StallContactNumber.Text,
                    stallName = StallNameTextBox.Text,
                    timein = StallStartOperatingHours.SelectedItem.ToString(),
                    timeout = StallEndOperatingHours.SelectedItem.ToString(),
                    Img = ImgURL,
                    selectedDays = new List<string>()
                };

                if (mondaychckb.Checked) updatedData.selectedDays.Add("Monday");
                if (tuesdaychckb.Checked) updatedData.selectedDays.Add("Tuesday");
                if (wednesdaychckb.Checked) updatedData.selectedDays.Add("Wednesday");
                if (thursdaychckb.Checked) updatedData.selectedDays.Add("Thursday");
                if (fridaychckb.Checked) updatedData.selectedDays.Add("Friday");
                if (saturdaychckb.Checked) updatedData.selectedDays.Add("Saturday");
                if (sundaychckb.Checked) updatedData.selectedDays.Add("Sunday");

                try
                {
                    FirebaseResponse response = await client.UpdateAsync($"adminInformation/{currentUserUID}", updatedData);
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        loading.Close();
                        AlertBox(Color.SeaGreen, Color.White, "Success", "Data updated successfully!", Properties.Resources.icons8_success_48);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        loading.Close();
                        AlertBox(Color.Coral, Color.SeaGreen, "Error", "Failed to update data.", Properties.Resources.icons8_error_48);
                    }
                }
                catch (Exception ex)
                {
                    loading.Close();
                    AlertBox(Color.Coral, Color.SeaGreen, "Error", $"An error occurred while updating: {ex.Message}", Properties.Resources.icons8_error_48);
                }
                finally
                {
                    loading.Close();
                    this.Close();
                }
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;

            this.Close();
        }

        private void DialogForm_Load(object sender, EventArgs e)
        {
            int borderRadius = 10;
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, borderRadius, borderRadius));

            this.StartPosition = FormStartPosition.Manual;

            startY = -this.Height; 
            finalY = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2; 

            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2, startY);

            modalEffect_Timer.Interval = 15; 
            modalEffect_Timer.Tick += modalEffect_Timer_Tick;
            modalEffect_Timer.Start();
        }

        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,    
            int nTopRect,      
            int nRightRect,   
            int nBottomRect,  
            int nWidthEllipse, 
            int nHeightEllipse 
        );


        private string _imageUrl;
        private string ImgURL => _imageUrl;

        private async void LoadStallInfo()
        {
            try
            {
                FirebaseResponse response = await client.GetAsync($"adminInformation/{currentUserUID}");

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var userData = JsonConvert.DeserializeObject<StallInfo>(response.Body);

                    if (userData != null)
                    {

                        _imageUrl = userData.Img;

                        StallNumberTextBox.Text = userData.stallNumber;
                        StallFirstNameTextBox.Text = userData.firstName;
                        StallLastNameTextBox.Text = userData.lastName;
                        StallContactNumber.Text = userData.contactNumber;
                        StallNameTextBox.Text = userData.stallName;

                        StallStartOperatingHours.Items.AddRange(new object[] {
                            "12:00 AM", "1:00 AM", "2:00 AM", "3:00 AM", "4:00 AM", "5:00 AM", "6:00 AM",
                            "7:00 AM", "8:00 AM", "9:00 AM", "10:00 AM", "11:00 AM", "12:00 PM", "1:00 PM",
                            "2:00 PM", "3:00 PM", "4:00 PM", "5:00 PM", "6:00 PM", "7:00 PM", "8:00 PM",
                            "9:00 PM", "10:00 PM", "11:00 PM"
                        });

                        StallEndOperatingHours.Items.AddRange(new object[] {
                            "12:00 AM", "1:00 AM", "2:00 AM", "3:00 AM", "4:00 AM", "5:00 AM", "6:00 AM",
                            "7:00 AM", "8:00 AM", "9:00 AM", "10:00 AM", "11:00 AM", "12:00 PM", "1:00 PM",
                            "2:00 PM", "3:00 PM", "4:00 PM", "5:00 PM", "6:00 PM", "7:00 PM", "8:00 PM",
                            "9:00 PM", "10:00 PM", "11:00 PM"
                        });


                        if (!string.IsNullOrEmpty(userData.timein))
                        {
                            StallStartOperatingHours.SelectedItem = userData.timein;
                        }

                        if (!string.IsNullOrEmpty(userData.timeout))
                        {
                            StallEndOperatingHours.SelectedItem = userData.timeout;
                        }

                        List<string> daysSelected = userData.selectedDays;

                        mondaychckb.Checked = false;
                        tuesdaychckb.Checked = false;
                        wednesdaychckb.Checked = false;
                        thursdaychckb.Checked = false;
                        fridaychckb.Checked = false;
                        saturdaychckb.Checked = false;
                        sundaychckb.Checked = false;

                        foreach (var day in daysSelected)
                        {
                            if (day == "Monday")
                            {
                                mondaychckb.Checked = true;
                            }
                            else if (day == "Tuesday")
                            {
                                tuesdaychckb.Checked = true;
                            }
                            else if (day == "Wednesday")
                            {
                                wednesdaychckb.Checked = true;
                            }
                            else if (day == "Thursday")
                            {
                                thursdaychckb.Checked = true;
                            }
                            else if (day == "Friday")
                            {
                                fridaychckb.Checked = true;
                            }
                            else if (day == "Saturday")
                            {
                                saturdaychckb.Checked = true;
                            }
                            else if (day == "Sunday")
                            {
                                sundaychckb.Checked = true;
                            }
                        }


                    }
                }
                else
                {
                    AlertBox(Color.Coral, Color.SeaGreen, "Error", "Failed to retrieve user data.", Properties.Resources.icons8_error_48);
                }
            }
            catch (Exception ex)
            {
                AlertBox(Color.Coral, Color.SeaGreen, "Error", $"An error occurred: {ex.Message}", Properties.Resources.icons8_error_48);
            }
        }
        int i;
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
    }

}

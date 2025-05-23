using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Mail;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAPSTONE_STOLE_ADMIN
{
    public partial class ViewOrderDialog : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "KXRrGtSOtbGJPkIKyfP8s2tpfvSSYXuzbvL61Qyx",
            BasePath = "https://admin-825a9-default-rtdb.firebaseio.com/"
        };
        private readonly string apiKey = "AIzaSyCaIpD2cyU_YQeNfy_zJ9-dQ-BSuAYo2CI";
        private const string FirebaseStorageUrl = "admin-825a9.appspot.com";
        IFirebaseClient client;

        private readonly int borderRadius = 20; 
        private readonly int borderSize = 5; 
        private readonly Color backgroundColor = Color.White;

        private string currentOrderID;
        public string OrderID => currentOrderID;
        public ViewOrderDialog(string orderID)
        {
            InitializeComponent();
            InitializeFirebaseClient();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Padding = new Padding(borderSize);
            this.BackColor = backgroundColor; 
            this.Paint += ViewOrderDialog_Paint; 
            InitializeBackColor();
            currentOrderID = orderID;
            LoadOrderDetails();

            OrderedProducts.Items.Clear();
            CustomerOtherDetails.Items.Clear();
            DateTimeListView.Items.Clear();
            PaymentListView.Items.Clear();
        }

        private void InitializeBackColor()
        {
            this.BackColor = ColorTranslator.FromHtml("#0b97d4");
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

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0); 
            }
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= 0x20000; 
                return cp;
            }
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

        private Color GetColorAt(Point point)
        {
            
            using (Bitmap bmp = new Bitmap(1, 1))
            {
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    g.CopyFromScreen(point, Point.Empty, new Size(1, 1));
                }
                return bmp.GetPixel(0, 0);
            }
        }

        private void FormRegionAndBorder(Form form, Graphics graph)
        {
            if (this.WindowState != FormWindowState.Minimized)
            {
                using (GraphicsPath roundPath = GetRoundedPath(form.ClientRectangle, borderRadius))
                {
                    graph.SmoothingMode = SmoothingMode.AntiAlias;
                    form.Region = new Region(roundPath);

                    
                    Color topLeftColor = GetColorAt(new Point(this.Location.X, this.Location.Y));
                    Color topRightColor = GetColorAt(new Point(this.Location.X + this.Width, this.Location.Y));
                    Color bottomRightColor = GetColorAt(new Point(this.Location.X + this.Width, this.Location.Y + this.Height));
                    Color bottomLeftColor = GetColorAt(new Point(this.Location.X, this.Location.Y + this.Height));

                    
                    using (Pen penTop = new Pen(ColorBlend(topLeftColor, topRightColor, 0.5f), borderSize))
                    {
                        graph.DrawPath(penTop, roundPath);
                    }

                    
                    using (Pen penBottom = new Pen(ColorBlend(bottomLeftColor, bottomRightColor, 0.5f), borderSize))
                    {
                        graph.DrawPath(penBottom, roundPath);
                    }
                }
            }
        }

        private void ViewOrderDialog_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            FormRegionAndBorder(this, e.Graphics);
        }

        private void ViewOrderDialog_ResizeEnd(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void ViewOrderDialog_SizeChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void ViewOrderDialog_Activated(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private Color ColorBlend(Color color1, Color color2, float ratio)
        {
            int r = (int)(color1.R * (1 - ratio) + color2.R * ratio);
            int g = (int)(color1.G * (1 - ratio) + color2.G * ratio);
            int b = (int)(color1.B * (1 - ratio) + color2.B * ratio);
            return Color.FromArgb(r, g, b);
        }


        public static string MaskEmail(string email)
        {
            string domain = "@gmail.com";
            if (email.EndsWith(domain))
            {
                string localPart = email.Substring(0, email.IndexOf('@'));
                string maskedLocalPart = localPart.Length > 2
                    ? localPart.Substring(0, 2) + new string('*', localPart.Length - 2)
                    : localPart;

                return $"{maskedLocalPart}{domain}";
            }
            else
            {
                return email;
            }
        }

        private async void LoadOrderDetails()
        {
            try
            {
                FirebaseResponse response = await client.GetAsync($"customerTransaction/{OrderID}");
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var customerTrans = JsonConvert.DeserializeObject<customerTransaction>(response.Body);
                    if (customerTrans != null)
                    {
                        var nameItem = new ListViewItem("Customer Name");
                        nameItem.SubItems.Add(customerTrans.customerName);
                        CustomerOtherDetails.Items.Add(nameItem);

                        var idItem = new ListViewItem("Customer ID");
                        idItem.SubItems.Add(customerTrans.customerID);
                        CustomerOtherDetails.Items.Add(idItem);

                        var emailItem = new ListViewItem("Email");
                        string maskedEmail = MaskEmail(customerTrans.customerEmail);
                        emailItem.SubItems.Add(maskedEmail);
                        CustomerOtherDetails.Items.Add(emailItem);

                        FirebaseResponse userResponse = await client.GetAsync("users");
                        if (userResponse.StatusCode == HttpStatusCode.OK)
                        {
                            var allUsers = JsonConvert.DeserializeObject<Dictionary<string, users>>(userResponse.Body);
                            if (allUsers != null && allUsers.Values.Any())
                            {
                                var user = allUsers.Values.FirstOrDefault(u => u.email == customerTrans.customerEmail);
                                if (user != null)
                                {
                                    CustomerNameLabel.Text = $"{user.firstName} {user.lastName}";
                                    var image = await LoadImageFromUrl(user.imagePath);
                                    if (image != null)
                                    {
                                        customerPictureBox.Image = image;
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("User not found with the provided email.");
                                }
                            }
                        }

                        FirebaseResponse orderResponse = await client.GetAsync($"OrderDetails/{OrderID}");
                        if (orderResponse.StatusCode == HttpStatusCode.OK)
                        {
                            var orderData = JsonConvert.DeserializeObject<OrderDetails>(orderResponse.Body);
                            if (orderData != null && orderData.products != null)
                            {
                                foreach (var product in orderData.products)
                                {
                                    var item = new ListViewItem(product.name);
                                    item.SubItems.Add($"   {product.quantity.ToString()}");
                                    item.SubItems.Add($"₱{product.price.ToString()}");
                                    item.SubItems.Add($"₱{product.subTotalPrice.ToString()}");
                                    OrderedProducts.Items.Add(item);
                                }

                                var typeItem = new ListViewItem("Type");
                                typeItem.SubItems.Add(orderData.type);
                                CustomerOtherDetails.Items.Add(typeItem);

                                var statusItem = new ListViewItem("Status");
                                statusItem.SubItems.Add(orderData.orderStatus);
                                CustomerOtherDetails.Items.Add(statusItem);

                                ReadyOrderButton.Enabled = true;
                                FinishOrderButton.Enabled = true;
                                DeclineOrderButton.Enabled = true;
                                AcceptOrderButton.Enabled = true;

                                if (orderData.orderStatus == "Pending")
                                {
                                    ReadyOrderButton.Enabled = false;
                                    FinishOrderButton.Enabled = false;
                                }
                                else if (orderData.orderStatus == "Finished")
                                {
                                    ReadyOrderButton.Enabled = false;
                                    DeclineOrderButton.Enabled = false;
                                    AcceptOrderButton.Enabled = false;
                                    FinishOrderButton.Enabled = false;
                                }
                                else if (orderData.orderStatus == "Declined")
                                {
                                    ReadyOrderButton.Enabled = false;
                                    DeclineOrderButton.Enabled = false;
                                    FinishOrderButton.Enabled = false;
                                }
                                else if (orderData.orderStatus == "Processing")
                                {
                                    FinishOrderButton.Enabled = false;
                                    AcceptOrderButton.Enabled = false;
                                }

                                var orderDateItem = new ListViewItem("Order Created");
                                orderDateItem.SubItems.Add(orderData.orderDate);
                                DateTimeListView.Items.Add(orderDateItem);

                                var timeOrderItem = new ListViewItem("Order Time");
                                timeOrderItem.SubItems.Add(orderData.orderTime);
                                DateTimeListView.Items.Add(timeOrderItem);

                                var paymentItem = new ListViewItem("Payment Method");
                                paymentItem.SubItems.Add(orderData.paymentMethod);
                                PaymentListView.Items.Add(paymentItem);

                                var isPaidItem = new ListViewItem("Payment Status");
                                isPaidItem.SubItems.Add(orderData.paid);
                                PaymentListView.Items.Add(isPaidItem);

                                OverallTotalPrice.Text = $"₱{orderData.totalPrice}";

                                if (orderData.paymentMethod == "GCash")
                                {
                                    GCashImage.Visible = true;
                                    GCashLabel.Visible = true;
                                    CheckPayment();
                                } else
                                {
                                    GCashImage.Visible = false;
                                    GCashLabel.Visible = false;
                                }
                            }
                            else
                            {
                                MessageBox.Show("No products found in the order.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deserializing the data: {ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void CheckPayment()
        {
            FirebaseResponse response = await client.GetAsync($"customerTransaction/{OrderID}");
            if (response != null)
            {
                var customerTrans = JsonConvert.DeserializeObject<customerTransaction>(response.Body);
                if (customerTrans != null)
                {
                    var image = await LoadImageFromUrl(customerTrans.customerPaymentScreenShot);
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

        private async void AcceptOrderButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to accept this order?",
                "Accept Order",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2
                );

            using (var loading = new LoadingDialog())
            {
                loading.Show();
                if (result == DialogResult.OK)
                {

                    var acceptStatus = "Processing";

                    var updateStatus = new
                    {
                        orderStatus = acceptStatus
                    };
                    FirebaseResponse newestResponse = await client.UpdateAsync($"OrderDetails/{OrderID}", updateStatus);
                    if (newestResponse.StatusCode == HttpStatusCode.OK)
                    {
                        loading.Close();
                        MessageBox.Show("Order Accept Successfully, the customer will be notify to get its order in 5 minutes!", "ACCEPTED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
        }

        private async void DeclineOrderButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to decline this order?",
                "Decline Order",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2
                );

            using (var loading = new LoadingDialog())
            {
                loading.Show();
                if (result == DialogResult.OK)
                {
                    var acceptStatus = "Declined";

                    var updateStatus = new
                    {
                        orderStatus = acceptStatus
                    };
                    FirebaseResponse newestResponse = await client.UpdateAsync($"OrderDetails/{OrderID}", updateStatus);
                    if (newestResponse.StatusCode == HttpStatusCode.OK)
                    {
                        MessageBox.Show("Order Declined, the customer will be notify about its order being declined!", "DECLINED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
        }

        private async void ReadyOrderButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure the Order is ready to serve?",
                "Ready Order",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2
                );

            using (var loading = new LoadingDialog())
            {
                loading.Show();
                if (result == DialogResult.OK)
                {

                    var acceptStatus = "Ready";

                    var updateStatus = new
                    {
                        orderStatus = acceptStatus
                    };
                    FirebaseResponse newestResponse = await client.UpdateAsync($"OrderDetails/{OrderID}", updateStatus);
                    if (newestResponse.StatusCode == HttpStatusCode.OK)
                    {
                        loading.Close();
                        MessageBox.Show("Order Ready, the customer will be notify to get its order now!", "READY", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
        }

        private async void FinishOrderButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure the Order is served to the customer?",
                "Finish",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2
                );

            using (var loading = new LoadingDialog())
            {
                loading.Show();
                if (result == DialogResult.OK)
                {

                    var acceptStatus = "Finished";

                    var updateStatus = new
                    {
                        orderStatus = acceptStatus
                    };
                    FirebaseResponse newestResponse = await client.UpdateAsync($"OrderDetails/{OrderID}", updateStatus);
                    if (newestResponse.StatusCode == HttpStatusCode.OK)
                    {
                        loading.Close();
                        MessageBox.Show("Finish, an order has been purchased, what a greet day!", "FINISH", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
        }
    }
}

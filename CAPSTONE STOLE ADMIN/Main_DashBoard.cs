using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Emgu.CV.Aruco;
using Firebase.Storage;
using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using LiveCharts.Wpf;
using LiveCharts;
using MaterialSkin.Controls;
using Newtonsoft.Json;
using static Google.Apis.Requests.BatchRequest;
using System.Globalization;
using System.IO.Ports;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace CAPSTONE_STOLE_ADMIN
{
    public partial class Main_DashBoard : MaterialForm
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

        private string currentUserUID;
        private string StallNameOf;
        public string UserUID => currentUserUID;

        public static int parentX, parentY;

        public string StallNameOfMenu => StallNameOf;
        private System.Windows.Forms.Timer orderCheckTimer;
        private int lastOrderCount = 0;
        private NotifyIcon notifyIcon;
        public Main_DashBoard(string userUID)
        {
            InitializeComponent();
            InitializeDataGridViewForOrders();
            InitializeFirebaseClient();
            InitializeNotifyIcon();
            currentUserUID = userUID;
            LoadStallInformation();
            LoadMenus();
            LoadOrders();
            LoadProducts();
            InitializeDesign();
            previousButton.Click += PreviousButton_Click;
            nextButton.Click += NextButton_Click;
            InitializeDate();
            LoadTransactions();
            LoadSales();
            LoadStallInfo();
            DeleteMenus();
        }

        private void InitializeDesign()
        {
            AllLabelHighlighter1.Visible = false;
            TodayLabelHighlighter1.Visible = false;
            WeekLabelHighlighter1.Visible = false;
            MonthLabelHighlighter1.Visible = false;
            AllLabelHighlighter.Visible = false;
            TodayLabelHighlighter.Visible = false;
            WeekLabelHighlighter.Visible = false;
            PayOnPickupButton.Checked = true;
            OrderedProducts.Visible = false;
        }
        private void InitializeDataGridViewForOrders()
        {
            OrderList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            OrderList.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            OrderList.RowHeadersVisible = false;
            OrderList.AllowUserToResizeRows = false;
            OrderList.AllowUserToAddRows = false;
            OrderList.EnableHeadersVisualStyles = false;
            OrderList.RowTemplate.Height = 55;

            DataGridViewTextBoxColumn hiddenColumn = new DataGridViewTextBoxColumn();
            hiddenColumn.Name = "HiddenColumn";
            hiddenColumn.HeaderText = "Hidden Data";
            hiddenColumn.Visible = false;
            OrderList.Columns.Add(hiddenColumn);

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
                    AlertBox(Color.Coral, Color.SeaGreen, "Error", "Failed to connect to the Firebase server!", Properties.Resources.icons8_error_48);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error. Firebase initialization error: {ex.Message}");
            }
        }


        //HOME TAB


        private void InitializeNotifyIcon()
        {
            notifyIcon = new NotifyIcon
            {
                Icon = this.Icon,
                Visible = true
            };
        }

        private void ShowNotification(string title, string message)
        {
            notifyIcon.BalloonTipTitle = title;
            notifyIcon.BalloonTipText = message;
            notifyIcon.Visible = true;
            notifyIcon.ShowBalloonTip(3000);
        }

        private void InitializeOrderCheckTimer()
        {
            orderCheckTimer = new System.Windows.Forms.Timer
            {
                Interval = 3000 
            };
            orderCheckTimer.Tick += OrderCheckTimer_Tick;
            orderCheckTimer.Start();
        }

        private async void OrderCheckTimer_Tick(object sender, EventArgs e)
        {
            orderCheckTimer.Stop();
            if (InvokeRequired)
            {
                Invoke(new MethodInvoker(async () => await CheckForNewOrders()));
            }
            else
            {
                await CheckForNewOrders();
            }
            orderCheckTimer.Start();
        }

        private async Task CheckForNewOrders()
        {
            try
            {
                FirebaseResponse response = await client.GetAsync("OrderDetails");
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var ordersData = JsonConvert.DeserializeObject<Dictionary<string, OrderDetails>>(response.Body);
                    if (ordersData != null)
                    {
                        int currentOrderCount = ordersData.Values.Count(order => order.stallID == currentUserUID && order.orderStatus != "Finished" && order.orderStatus != "Declined" && order.orderStatus != "Received");

                        int lastOrderCount = await GetStallOrderCount();

                        if (currentOrderCount > lastOrderCount)
                        {
                            int newOrders = currentOrderCount - lastOrderCount; 
                            await UpdateStallOrderCount(currentOrderCount);  
                            ShowNotification("New Orders Received", $"{newOrders} new orders have been placed.");
                            LoadOrders();
                        }
                        else if (currentOrderCount < lastOrderCount)
                        {
                            await UpdateStallOrderCount(currentOrderCount);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Failed to retrieve data from the database.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving data: {ex.Message}");
            }
        }

        private async Task<int> GetStallOrderCount()
        {
            try
            {
                FirebaseResponse response = await client.GetAsync($"StallOrderCounts/{currentUserUID}");
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var currentCount = JsonConvert.DeserializeObject<int>(response.Body);
                    return currentCount;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving order count: {ex.Message}");
            }
            return 0;
        }

        private async Task UpdateStallOrderCount(int newCount)
        {
            try
            {
                await client.SetAsync($"StallOrderCounts/{currentUserUID}", newCount);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating order count: {ex.Message}");
            }
        }

        private async void LoadOrders(DateTime? filterDate = null)
        {
            try
            {
                if (InvokeRequired)
                {
                    Invoke(new MethodInvoker(() => LoadOrders(filterDate)));
                    return;
                }

                InitializeOrderCheckTimer();
                OrderList.Rows.Clear();
                FirebaseResponse response = await client.GetAsync("OrderDetails");
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var ordersData = JsonConvert.DeserializeObject<Dictionary<string, OrderDetails>>(response.Body);
                    if (ordersData != null)
                    {
                        int declinedOrderCount = 0;

                        var sortedOrders = ordersData
                            .Where(o => o.Value.stallID == currentUserUID &&
                                        o.Value.orderStatus != "Finished" &&
                                        o.Value.orderStatus != "Declined" &&
                                        o.Value.orderStatus != "Cancelled" &&
                                        o.Value.orderStatus != "Received")
                            .Select(o => o.Value)
                            .OrderByDescending(o => DateTime.ParseExact(o.orderDate, "ddd, MMMM d, yyyy", null))
                            .ThenByDescending(o => DateTime.ParseExact(o.orderTime, "h:mm tt", null))
                            .ToList();

                        foreach (var order in sortedOrders)
                        {
                            string productsInfo = string.Join(", ", order.products.Select(p => $"{p.name} (x{p.quantity})"));
                            OrderList.Rows.Add(order.orderTime, productsInfo, order.type, order.orderDate, order.orderStatus,
                                order.paid, ($"₱{order.totalPrice}"), order.paymentMethod, order.orderId);

                            if (order.orderStatus == "Declined" && order.stallID == UserUID)
                            {
                                declinedOrderCount++;
                            }
                        }

                        OrderList.ClearSelection();
                        TotalOrdersLabel.Text = OrderList.Rows.Count.ToString();

                        double totalSales = await GetTotalSales(filterDate);
                        TotalSalesLabel.Text = totalSales.ToString("C2");
                    }
                }
                else
                {
                    Console.WriteLine("Failed to retrieve data from the database.");
                }

                if (filterDate.HasValue)
                {
                    var filteredRows = OrderList.Rows.Cast<DataGridViewRow>()
                        .Where(row => !row.IsNewRow)
                        .Select(row => new
                        {
                            Row = row,
                            Date = DateTime.ParseExact(row.Cells[3].Value.ToString(), "ddd, MMMM d, yyyy", null),
                            Time = DateTime.ParseExact(row.Cells[0].Value.ToString(), "h:mm tt", null)
                        })
                        .Where(order => order.Date.Date == filterDate.Value.Date)
                        .OrderByDescending(order => order.Date)
                        .ThenByDescending(order => order.Time)
                        .ToList();

                    OrderList.Rows.Clear();
                    foreach (var item in filteredRows)
                    {
                        OrderList.Rows.Add(item.Row.Cells[0].Value, item.Row.Cells[1].Value,
                                           item.Row.Cells[2].Value, item.Row.Cells[3].Value,
                                           item.Row.Cells[4].Value, item.Row.Cells[5].Value,
                                           item.Row.Cells[6].Value, item.Row.Cells[7].Value,
                                           item.Row.Cells[8].Value);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving data: {ex.Message}");
            }
        }


        private async Task<double> GetTotalSales(DateTime? filterDate = null)
        {
            try
            {
                FirebaseResponse response = await client.GetAsync("OrderDetails");
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var ordersData = JsonConvert.DeserializeObject<Dictionary<string, OrderDetails>>(response.Body);
                    if (ordersData != null)
                    {
                        double totalSales = 0;
                        foreach (var orderEntry in ordersData)
                        {
                            var order = orderEntry.Value;
                            if (order.stallID == currentUserUID && order.orderStatus == "Received")
                            {
                                totalSales += Convert.ToDouble(order.totalPrice);
                            }
                        }
                        return totalSales;
                    }
                }
                else
                {
                    Console.WriteLine("Failed to retrieve data from the database.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error calculating total sales: {ex.Message}");
            }

            return 0;
        }


        private void OrderList_MouseClick(object sender, MouseEventArgs e)
        {
            if (OrderList.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = OrderList.SelectedRows[0];
                string OrderStatus = selectedRow.Cells["Status"].Value.ToString();
                ReadyOrderButton.Enabled = true;
                FinishOrderButton.Enabled = true;
                DeclineOrderButton.Enabled = true;
                AcceptOrderButton.Enabled = true;

                if (OrderStatus == "Pending")
                {
                    ReadyOrderButton.Enabled = false;
                    FinishOrderButton.Enabled = false;
                }
                else if (OrderStatus == "Finished")
                {
                    ReadyOrderButton.Enabled = false;
                    DeclineOrderButton.Enabled = false;
                    AcceptOrderButton.Enabled = false;
                    FinishOrderButton.Enabled = false;
                }
                else if (OrderStatus == "Declined")
                {
                    ReadyOrderButton.Enabled = false;
                    DeclineOrderButton.Enabled = false;
                    FinishOrderButton.Enabled = false;
                }
                else if (OrderStatus == "Cancelled")
                {
                    ReadyOrderButton.Enabled = false;
                    DeclineOrderButton.Enabled = false;
                    FinishOrderButton.Enabled = false;
                }
                else if (OrderStatus == "Ready")
                {
                    ReadyOrderButton.Enabled = false;
                    AcceptOrderButton.Enabled = false;
                }
                else if (OrderStatus == "Processing")
                {
                    FinishOrderButton.Enabled = false;
                    AcceptOrderButton.Enabled = false;

                }
            }
        }

        /*private async Task<Image> DownloadImageAsync(string imageUrl)
        {
            using (var httpClient = new HttpClient())
            {
                var imageBytes = await httpClient.GetByteArrayAsync(imageUrl);
                using (var ms = new MemoryStream(imageBytes))
                {
                    return Image.FromStream(ms);
                }
            }
        }*/

        private void ViewOrderButton_Click(object sender, EventArgs e)
        {
            if (OrderList.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = OrderList.SelectedRows[0];

                string orderID = selectedRow.Cells["HiddenColumn"].Value.ToString();

                try
                {
                    using (ViewOrderDialog dialog = new ViewOrderDialog(orderID))
                    {
                        if (dialog.ShowDialog() == DialogResult.OK)
                        {
                            Console.WriteLine("Success");
                        }
                    }
                }
                finally
                {
                    OrderList.Rows.Clear();
                    LoadOrders();
                }
            }
        }


        private async void AcceptOrderButton_Click(object sender, EventArgs e)
        {
            if (OrderList.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = OrderList.SelectedRows[0];

                string orderID = selectedRow.Cells["HiddenColumn"].Value.ToString();

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
                        FirebaseResponse orderResponse = await client.GetAsync($"OrderDetails/{orderID}");
                        if (orderResponse.StatusCode != HttpStatusCode.OK || string.IsNullOrEmpty(orderResponse.Body))
                        {
                            MessageBox.Show("Order details not found.");
                            return;
                        }

                        var orderDetails = JsonConvert.DeserializeObject<OrderDetails>(orderResponse.Body);

                        if (orderDetails == null || orderDetails.products == null)
                        {
                            MessageBox.Show("No products in this order.");
                            return;
                        }

                        FirebaseResponse allProductsResponse = await client.GetAsync("Products");
                        if (allProductsResponse.StatusCode != HttpStatusCode.OK || string.IsNullOrEmpty(allProductsResponse.Body))
                        {
                            MessageBox.Show("Failed to fetch products.");
                            return;
                        }

                        var allProducts = JsonConvert.DeserializeObject<Dictionary<string, ProductData>>(allProductsResponse.Body);

                        if (allProducts == null || allProducts.Count == 0)
                        {
                            MessageBox.Show("No products found in database.");
                            return;
                        }

                        foreach (var orderProduct in orderDetails.products)
                        {
                            var matchingProduct = allProducts.Values.FirstOrDefault(p =>
                                p.productName == orderProduct.name && p.stallUID == UserUID);

                            if (matchingProduct == null)
                            {
                                MessageBox.Show($"No matching product found for {orderProduct.name}.");
                                continue;
                            }

                            if (int.TryParse(matchingProduct.productQuantity, out int currentQuantity) && currentQuantity >= orderProduct.quantity)
                            {
                                currentQuantity -= orderProduct.quantity;

                                matchingProduct.productQuantity = currentQuantity.ToString();
                                await client.SetAsync($"Products/{matchingProduct.productId}", matchingProduct);

                                var acceptStatus = "Processing";

                                var updateStatus = new
                                {
                                    orderStatus = acceptStatus
                                };
                                FirebaseResponse newestResponse = await client.UpdateAsync($"OrderDetails/{orderID}", updateStatus);
                                if (newestResponse.StatusCode == HttpStatusCode.OK)
                                {
                                    loading.Close();
                                    MessageBox.Show("Order Accept Successfully, the customer will be notify to get its order in 5 minutes!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    OrderList.Rows.Clear();
                                    LoadOrders();
                                }
                            }
                            else
                            {
                                DialogResult stock = MessageBox.Show(
                                $"Insufficient stock for {orderProduct.name}. Go to products and update the stock?",
                                "UPDATE",
                                MessageBoxButtons.OKCancel,
                                MessageBoxIcon.Error,
                                MessageBoxDefaultButton.Button2
                                );
                                if (stock == DialogResult.OK)
                                {
                                    materialTabControl1.SelectedTab = Products;
                                }
                            }
                        }
                    }
                }

            }
            
        }

        private async void DeclineOrderButton_Click(object sender, EventArgs e)
        {
            if (OrderList.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = OrderList.SelectedRows[0];

                string orderID = selectedRow.Cells["HiddenColumn"].Value.ToString();

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
                        FirebaseResponse newestResponse = await client.UpdateAsync($"OrderDetails/{orderID}", updateStatus);
                        if (newestResponse.StatusCode == HttpStatusCode.OK)
                        {
                            loading.Close();
                            MessageBox.Show("Order Declined, the customer will be notify about its order being declined!", "DECLINED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            OrderList.Rows.Clear();
                            LoadOrders();
                            LoadTransactions();
                        }
                    }
                }
            }
        }

        private async void ReadyOrderButton_Click(object sender, EventArgs e)
        {
            if (OrderList.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = OrderList.SelectedRows[0];

                string orderID = selectedRow.Cells["HiddenColumn"].Value.ToString();

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
                        FirebaseResponse newestResponse = await client.UpdateAsync($"OrderDetails/{orderID}", updateStatus);
                        if (newestResponse.StatusCode == HttpStatusCode.OK)
                        {
                            loading.Close();
                            MessageBox.Show("Order Ready, the customer will be notify to get its order now!", "Ready", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            OrderList.Rows.Clear();
                            LoadOrders();
                        }
                    }
                }
            }
        }


        private async void FinishOrderButton_Click(object sender, EventArgs e)
        {
            if (OrderList.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = OrderList.SelectedRows[0];

                string orderID = selectedRow.Cells["HiddenColumn"].Value.ToString();
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
                        FirebaseResponse newestResponse = await client.UpdateAsync($"OrderDetails/{orderID}", updateStatus);
                        if (newestResponse.StatusCode == HttpStatusCode.OK)
                        {
                            TimeZoneInfo philippineTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Singapore Standard Time");
                            DateTime philippineTime = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, philippineTimeZone);

                            string localDate = philippineTime.ToString("ddd, MMMM dd, yyyy");

                            var data = new
                            {
                                id = orderID,
                                date = localDate
                            };

                            FirebaseResponse response = await client.SetAsync("TimeFinished/" + orderID,data);

                            loading.Close();
                            MessageBox.Show("Finished, proceeding to verify the order", "FINISHED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            materialTabControl1.SelectedTab = Transactions;
                            LoadTransactions(null);
                            LoadOrders();
                        }
                    }
                }
            }
        }


        private void SortAllLabel_Click(object sender, EventArgs e)
        {
            AllLabelHighlighter1.Visible = true;
            TodayLabelHighlighter1.Visible = false;
            WeekLabelHighlighter1.Visible = false;
            MonthLabelHighlighter1.Visible = false;
            LoadOrders();
        }





        private void SortTodayLabel_Click(object sender, EventArgs e)
        {
            AllLabelHighlighter1.Visible = false;
            TodayLabelHighlighter1.Visible = true;
            WeekLabelHighlighter1.Visible = false;
            MonthLabelHighlighter1.Visible = false;

            LoadOrders(DateTime.Now.Date);
        }


        private void SortYesterdayLabel_Click(object sender, EventArgs e)
        {
            AllLabelHighlighter1.Visible = false;
            TodayLabelHighlighter1.Visible = false;
            WeekLabelHighlighter1.Visible = true;
            MonthLabelHighlighter1.Visible = false;

            LoadOrders(DateTime.Now.Date.AddDays(-1));
        }

        private void SortMonthLabel_Click(object sender, EventArgs e)
        {
            AllLabelHighlighter1.Visible = false;
            TodayLabelHighlighter1.Visible = false;
            WeekLabelHighlighter1.Visible = false;
            MonthLabelHighlighter1.Visible = true;

            DateTime todayDate = DateTime.Now.Date;
            DateTime yesterdayDate = todayDate.AddDays(-1);

            var rows = OrderList.Rows.Cast<DataGridViewRow>()
                          .Where(row => !row.IsNewRow)
                          .Select(row => new
                          {
                              Row = row,
                              Date = DateTime.ParseExact(row.Cells[3].Value.ToString(), "ddd, MMMM d, yyyy", null),
                              Time = DateTime.ParseExact(row.Cells[0].Value.ToString(), "h:mm tt", null)
                          })
                          .Where(order => order.Date.Date < yesterdayDate)
                          .OrderByDescending(order => order.Date)
                          .ThenByDescending(order => order.Time)
                          .ToList();

            OrderList.Rows.Clear();
            foreach (var item in rows)
            {
                OrderList.Rows.Add(item.Row.Cells[0].Value, item.Row.Cells[1].Value,
                                   item.Row.Cells[2].Value, item.Row.Cells[3].Value,
                                   item.Row.Cells[4].Value, item.Row.Cells[5].Value,
                                   item.Row.Cells[6].Value, item.Row.Cells[7].Value,
                                   item.Row.Cells[8].Value);
            }
        }


        //PRODUCT TAB


        private int currentPage = 0;
        private const int pageSize = 4;
        private Dictionary<string, ProductData> allProducts;

        private async void LoadProducts()
        {
            try
            {
                ProductsFlowLayoutPanel.Controls.Clear();

                if (client == null)
                {
                    AlertBox(Color.Coral, Color.SeaGreen, "Check your internet connection!", "ERROR", Properties.Resources.icons8_error_48);
                    return;
                }

                FirebaseResponse response = await client.GetAsync("Products");
                if (response.Body == "null")
                {
                    AlertBox(Color.DimGray, Color.White, "Add some products now!", "EMPTY", Properties.Resources.icons8_error_48);
                    return;
                }

                allProducts = response.ResultAs<Dictionary<string, ProductData>>();
                if (allProducts == null || allProducts.Count == 0)
                {
                    AlertBox(Color.DimGray, Color.White, "Add some products now!", "Empty", Properties.Resources.icons8_bell_48);
                    return;
                }

                allProducts = allProducts
                    .Where(p => p.Value.stallUID == UserUID) 
                    .ToDictionary(p => p.Key, p => p.Value);

                ProductCountLabel.Text = allProducts.Count.ToString();

                if (allProducts.Count == 0)
                {
                    AlertBox(Color.DimGray, Color.White, "No products yet, add some now!", "EMPTY", Properties.Resources.icons8_error_48);
                    return;
                }

                LoadPage(currentPage);
            }
            catch (Exception ex)
            {
                AlertBox(Color.Coral, Color.SeaGreen, $"Failed to load products: {ex.Message}", "ERROR", Properties.Resources.icons8_error_48);
            }
        }

        private bool isLoading = false;
        private int totalPages;

        private async void LoadPage(int page)
        {
            if (isLoading) return;

            isLoading = true;
            ProductsFlowLayoutPanel.Controls.Clear();

            totalPages = (int)Math.Ceiling((double)allProducts.Count / pageSize);

            if (page < 0 || page >= totalPages)
            {
                isLoading = false;
                return;
            }

            var productsToDisplay = allProducts
                .Skip(page * pageSize)
                .Take(pageSize)
                .ToDictionary(x => x.Key, x => x.Value);



            foreach (var product in productsToDisplay)
            {
                Image productImage = await LoadImageFromUrl(product.Value.productImage);
                if (productImage == null)
                {
                    productImage = Properties.Resources.icons8_error_48;
                }

                MaterialCard productCard = new MaterialCard
                {
                    Width = 250,
                    Height = 320,
                    Margin = new Padding(10),
                    BackColor = Color.White
                };

                BorderRadiusPictureBox pictureBox = new BorderRadiusPictureBox
                {
                    Image = productImage,
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Width = 240,
                    Height = 180,
                    Left = 5,
                    Top = 5,
                    BorderRadius = 10,
                };
                productCard.Controls.Add(pictureBox);

                MaterialLabel productNameLabel = new MaterialLabel
                {
                    Text = product.Value.productName,
                    Top = pictureBox.Bottom + 5,
                    Width = 280,
                    Left = 10,
                    TextAlign = ContentAlignment.MiddleLeft,
                    FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1,
                    AutoSize = false,
                    Font = new Font("Segoe UI", 10, FontStyle.Bold)
                };
                productCard.Controls.Add(productNameLabel);

                MaterialLabel productPriceLabel = new MaterialLabel
                {
                    Text = $"Price: {product.Value.productPrice:C}",
                    Top = productNameLabel.Bottom + 5,
                    Width = 280,
                    Left = 10,
                    TextAlign = ContentAlignment.MiddleLeft,
                    FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2,
                    AutoSize = false
                };
                productCard.Controls.Add(productPriceLabel);

                MaterialLabel productCategoryLabel = new MaterialLabel
                {
                    Text = $"Category: {product.Value.productCategory}",
                    Top = productPriceLabel.Bottom + 5,
                    Width = 270,
                    Left = 10,
                    TextAlign = ContentAlignment.MiddleLeft,
                    FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2,
                    AutoSize = false
                };
                productCard.Controls.Add(productCategoryLabel);

                MaterialButton deleteButton = new MaterialButton
                {
                    Text = "Delete",
                    Left = 2,
                    Top = productCategoryLabel.Bottom + 5,
                    Size = new Size(120, 30),
                    AutoSize = false,
                    Type = MaterialButton.MaterialButtonType.Outlined
                };

                deleteButton.Click += async (s, e) =>
                {
                    await DeleteProduct(product.Key);
                };

                productCard.Controls.Add(deleteButton);

                MaterialButton updateButton = new MaterialButton
                {
                    Text = "Update",
                    Top = productCategoryLabel.Bottom + 5,
                    Left = deleteButton.Right + 5,
                    Size = new Size(120, 30),
                    AutoSize = false
                };

                updateButton.Click += (s, e) =>
                {
                    Form modalBackground = new Form();
                    using (UpdateProductForm modal = new UpdateProductForm(product.Key))
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

                        modal.StartPosition = FormStartPosition.CenterScreen;

                        DialogResult result = modal.ShowDialog();
                        modalBackground.Dispose();

                        if (result == DialogResult.OK)
                        {
                            LoadProducts();
                        }
                    }
                };


                productCard.Controls.Add(updateButton);

                ProductsFlowLayoutPanel.Controls.Add(productCard);
            }
            isLoading = false;
            UpdatePaginationControls();
        }

        private void UpdatePaginationControls()
        {
            previousButton.Enabled = currentPage > 0 && !isLoading;
            nextButton.Enabled = (currentPage + 1) < totalPages && !isLoading;

            PageNumber.Text = $"Page {currentPage + 1} of {totalPages}";
        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            if (!isLoading && currentPage > 0)
            {
                currentPage--;
                LoadPage(currentPage);
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (!isLoading && (currentPage + 1) < totalPages) 
            {
                currentPage++;
                LoadPage(currentPage);
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

        private async Task DeleteProduct(string productId)
        {
            try
            {
                DialogResult result = MessageBox.Show(
                "Are you sure you want to delete the product?",
                "Delete Product",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2
                );

                if (result == DialogResult.OK)
                {
                    FirebaseResponse response = await client.DeleteAsync("Products/" + productId);
                    AlertBox(Color.Green, Color.Blue, "Success", "Product successfully deleted!", Properties.Resources.icons8_success_48);
                    LoadProducts();
                }
            }
            catch (Exception ex)
            {
                AlertBox(Color.Coral, Color.SeaGreen, "Error", $"Failed to delete product: {ex.Message}", Properties.Resources.icons8_error_48);
            }
        }

        private async void AddNewProductButton_Click(object sender, EventArgs e)
        {
            using (var loadingDialog = new LoadingDialog())
            {
                loadingDialog.Show();  
                try
                {
                    if (client == null)
                    {
                        loadingDialog.Close();
                        AlertBox(Color.Coral, Color.SeaGreen, "Error", "Firebase client is not initialized!", Properties.Resources.icons8_error_48);
                        return;
                    }
                    if (string.IsNullOrEmpty(TBAddProductName.Text))
                    {
                        loadingDialog.Close();
                        AlertBox(Color.Coral, Color.SeaGreen, "Error", "Name must not be empty!", Properties.Resources.icons8_error_48);
                        return;
                    }
                    if (string.IsNullOrEmpty(TBAddProductPrice.Text) || !Regex.IsMatch(TBAddProductPrice.Text, @"^[0-9]+$"))
                    {
                        loadingDialog.Close();
                        AlertBox(Color.Coral, Color.SeaGreen, "Error", "Price must contain only numbers!", Properties.Resources.icons8_error_48);
                        return;
                    }
                    if (string.IsNullOrEmpty(TBAddProductStocks.Text))
                    {
                        loadingDialog.Close();
                        AlertBox(Color.Coral, Color.SeaGreen, "Error", "Quantity must not be empty!", Properties.Resources.icons8_error_48);
                        return;
                    }
                    if (string.IsNullOrEmpty(TBAddProductCategory.Text))
                    {
                        loadingDialog.Close();
                        AlertBox(Color.Coral, Color.SeaGreen, "Error", "Category must not be empty!", Properties.Resources.icons8_error_48);
                        return;
                    }

                    string ProductID = GenerateShortProductID();
                    string ProductImageUrl = string.IsNullOrEmpty(selectedImagePath) ? "" : await UploadImageAsync(selectedImagePath);

                    if (string.IsNullOrEmpty(ProductImageUrl))
                    {
                        loadingDialog.Close();
                        AlertBox(Color.Coral, Color.SeaGreen, "Error", "Failed to upload image. Please try again.", Properties.Resources.icons8_error_48);
                        return;
                    }

                    var productData = new ProductData
                    {
                        productId = ProductID,
                        stallUID = UserUID,
                        productName = TBAddProductName.Text,
                        productPrice = TBAddProductPrice.Text,
                        productQuantity = TBAddProductStocks.Text,
                        productImage = ProductImageUrl,
                        productIdentity = TBAddProductQualification.Text,
                        productCategory = TBAddProductCategory.Text,
                        productStallName = StallNameOfMenu,
                        productDescription = TBAddProductDescription.Text
                    };

                    SetResponse response = await client.SetAsync("Products/" + ProductID, productData);
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        loadingDialog.Close();
                        AlertBox(Color.Green, Color.Blue, "Success", "Product successfully inserted!", Properties.Resources.icons8_success_48);
                        LoadProducts();

                        TBAddProductName.Clear();
                        TBAddProductPrice.Clear();
                        TBAddProductStocks.Clear();
                        TBAddProductCategory.Refresh();
                        TBAddProductQualification.Refresh();
                        TBAddProductDescription.Clear();
                        AddProductImage.Image = null;
                    }
                    else
                    {
                        loadingDialog.Close();
                        AlertBox(Color.Coral, Color.SeaGreen, "Error", "Failed to add product to Firebase. Please try again.", Properties.Resources.icons8_error_48);
                    }
                }
                catch (Exception ex)
                {
                    loadingDialog.Close();
                    AlertBox(Color.Coral, Color.SeaGreen, "Error", $"Failed to add product: {ex.Message}", Properties.Resources.icons8_error_48);
                }
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
                        Console.WriteLine($"An error occurred while displaying the image: {ex.Message}");
                    }
                }
            }
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

                    string downloadUrl = await storage
                        .Child("images")
                        .Child(Path.GetFileName(filePath))
                        .GetDownloadUrlAsync();

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

        private string GenerateShortProductID()
        {
            long timestamp = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
            Random random = new Random();
            int randomNumber = random.Next(1000, 9999);
            string combined = $"{timestamp % 1000000}{randomNumber}";

            return combined.Length > 12 ? combined.Substring(0, 12) : combined.PadRight(12, '0');
        }



        //MENU TAB


        private async void SaveMenuButton_Click(object sender, EventArgs e)
        {
            using (var loadingDialog = new LoadingDialog())
            {
                loadingDialog.Show();
                string itemName = TBMenuItemName.Text;
                string itemPrice = TBMenuItemPrice.Text;
                string itemStocks = TBMenuItemStocks.Text;
                Image itemImage = MenuPictureBoxItem.Image;

                if (string.IsNullOrEmpty(itemName) || string.IsNullOrEmpty(itemPrice) || itemImage == null)
                {
                    loadingDialog.Close();
                    AlertBox(Color.Coral, Color.SeaGreen, "Error", "Please fill all fields and add an image.", Properties.Resources.icons8_error_48);
                    return;
                }

                if (!Regex.IsMatch(itemPrice, @"^[0-9]+$"))
                {
                    loadingDialog.Close();
                    AlertBox(Color.Coral, Color.SeaGreen, "Error", "Price must contain only numbers!", Properties.Resources.icons8_error_48);
                    return;
                }

                string imageUrl = string.IsNullOrEmpty(selectedImagePath) ? "" : await UploadImageAsync(selectedImagePath);

                if (string.IsNullOrEmpty(imageUrl))
                {
                    loadingDialog.Close();
                    AlertBox(Color.Coral, Color.SeaGreen, "Error", "Failed to upload image. Please try again.", Properties.Resources.icons8_error_48);
                    return;
                }

                if (MenuType == null || string.IsNullOrEmpty(MenuType))
                {
                    loadingDialog.Close();
                    AlertBox(Color.Coral, Color.SeaGreen, "Error", "Menu Not Selected!", Properties.Resources.icons8_error_48);
                    return;
                }

                string menuItemId = GenerateShortProductID();

                var firebaseMenuItem = new MenuItem
                {
                    menuItemID = menuItemId,
                    stallUID = UserUID,
                    menuItemStallName = StallNameOfMenu,
                    nameMenu = MenuType,
                    menuType = MenuType,
                    menuName = itemName,
                    menuPrice = itemPrice,
                    menuQuantity = itemStocks,
                    menuImageUrl = imageUrl
                };

                var response = await client.SetAsync($"MenuItems/{menuItemId}", firebaseMenuItem);
                if (response.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    loadingDialog.Close();
                    AlertBox(Color.Coral, Color.SeaGreen, "Error", "Failed to add menu item to Firebase. Please try again.", Properties.Resources.icons8_error_48);
                    return;
                }

                TBMenuItemName.Clear();
                TBMenuItemPrice.Clear();
                TBMenuItemStocks.Clear();
                MenuPictureBoxItem.Image = null;
                LoadMenus();
                loadingDialog.Close();
                AlertBox(Color.Green, Color.Blue, "Success", "Menu item saved successfully!", Properties.Resources.icons8_success_48);
            }
        }


        private string defineType;
        private string MenuType => defineType;

        private void InitializeDate()
        {
            TimeZoneInfo philippineTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Singapore Standard Time");
            DateTime philippineTime = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, philippineTimeZone);

            string localDate = philippineTime.ToString("MMMM dd, yyyy");
            MenuTodaysDateText.Text = localDate;

            DateTime tomorrow = philippineTime.AddDays(1);
            string tomorrowDate = tomorrow.ToString("MMMM dd, yyyy");
            MenuTomorrowsDateText.Text = tomorrowDate;
        }

        private void TodaysMenuRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            DateTime todayDate = DateTime.Now;
            string formattedDate = todayDate.ToString("ddd, MMMM d, yyyy");
            SendKeys.Send("{ESC}");
            defineType = formattedDate;
        }

        private void TomorrowsMenuRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            DateTime tomorrowDate = DateTime.Now.AddDays(1);
            string formattedDate = tomorrowDate.ToString("ddd, MMMM d, yyyy");
            SendKeys.Send("{ESC}");
            defineType = formattedDate;
        }

        private void CustomRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            MenuCustomDateText.Focus();
            SendKeys.Send("%{DOWN}");
            string selectedDate = MenuCustomDateText.Value.ToString("ddd, MMMM d, yyyy");
            defineType = selectedDate;
        }

        /*private async Task<string> UploadImageToFirebaseAsync(string filePath)
        {
            try
            {
                using (var stream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    var storage = new FirebaseStorage(FirebaseStorageUrl);
                    var imageUrl = await storage
                        .Child("MenuImages")
                        .Child(Path.GetFileName(filePath))
                        .PutAsync(stream);

                    string downloadUrl = await storage
                        .Child("MenuImages")
                        .Child(Path.GetFileName(filePath))
                        .GetDownloadUrlAsync();

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
        }*/


        private void ViewMenuListComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMenus();
        }

        private async void LoadMenus()
        {
            try
            {
                string selectedOption = ViewMenuListComboBox.SelectedItem?.ToString() ?? "All Menu";

                FirebaseResponse menuresponse = await client.GetAsync($"MenuItems");
                if (menuresponse.Body == "null")
                {
                    AlertBox(Color.DimGray, Color.White, "Add some menu for your stall!", "EMPTY", Properties.Resources.icons8_error_48);
                    return;
                }
                var menus = menuresponse.ResultAs<Dictionary<string, MenuItem>>();
                if (menus == null || menus.Count == 0)
                {
                    AlertBox(Color.DimGray, Color.White, "Add some menu for your stall!", "EMPTY", Properties.Resources.icons8_error_48);
                    return;
                }

                MenuFlowLayout.Controls.Clear();

                foreach (var menu in menus)
                {
                    if (menu.Value == null) continue;

                    bool shouldLoad = false;

                    switch (selectedOption)
                    {
                        case "All Menu":
                            shouldLoad = menu.Value.stallUID == UserUID;
                            break;
                        case "Today":
                            shouldLoad = menu.Value.stallUID == UserUID && menu.Value.menuType == "MenuToday";
                            break;
                        case "Tomorrow":
                            shouldLoad = menu.Value.stallUID == UserUID && menu.Value.menuType == "MenuTomorrow";
                            break;
                        case "Custom":
                            shouldLoad = menu.Value.stallUID == UserUID && menu.Value.menuType != "MenuToday" && menu.Value.menuType != "MenuTomorrow";
                            break;
                    }

                    if (shouldLoad)
                    {
                        Image menuImage = await LoadImageFromUrl(menu.Value.menuImageUrl);
                        if (menuImage == null)
                        {
                            menuImage = Properties.Resources.icons8_error_48;
                        }

                        MaterialCard newItemPanel = new MaterialCard
                        {
                            Size = new Size(340, 70),
                            Margin = new Padding(5),
                            BackColor = Color.White
                        };

                        BorderRadiusPictureBox PicBox = new BorderRadiusPictureBox
                        {
                            Size = new Size(60, 60),
                            Image = menuImage,
                            SizeMode = PictureBoxSizeMode.StretchImage,
                            Location = new Point(5, 5)
                        };
                        newItemPanel.Controls.Add(PicBox);

                        Label lblName = new Label
                        {
                            Text = menu.Value.menuName,
                            Font = new Font("Arial Rounded MT", 11, FontStyle.Bold),
                            Location = new Point(70, 8),
                            AutoSize = true
                        };
                        newItemPanel.Controls.Add(lblName);

                        Label lblPrice = new Label
                        {
                            Text = $"Price: ₱{menu.Value.menuPrice}",
                            Font = new Font("Arial Rounded MT", 9, FontStyle.Bold),
                            ForeColor = Color.RoyalBlue,
                            Location = new Point(70, 28),
                            AutoSize = true
                        };
                        newItemPanel.Controls.Add(lblPrice);

                        Label lblStocks = new Label
                        {
                            Text = $"Stocks: {menu.Value.menuQuantity}",
                            Font = new Font("Arial Rounded MT", 9, FontStyle.Bold),
                            ForeColor = Color.RoyalBlue,
                            Location = new Point(70, 45),
                            AutoSize = true
                        };
                        newItemPanel.Controls.Add(lblStocks);

                        Label lblDate = new Label
                        {
                            Text = menu.Value.menuType,
                            Font = new Font("Arial Rounded MT", 9, FontStyle.Bold),
                            ForeColor = Color.RoyalBlue,
                            Location = new Point(156, 45),
                            AutoSize = true
                        };
                        newItemPanel.Controls.Add(lblDate);

                        PictureBox deleteButton = new PictureBox
                        {
                            Size = new Size(24, 24),
                            Image = Properties.Resources.icons8_delete_24,
                            SizeMode = PictureBoxSizeMode.StretchImage,
                            Location = new Point(309, 8)
                        };

                        deleteButton.Click += async (s, e) =>
                        {
                            await DeleteMenu(menu.Key);
                        };

                        newItemPanel.Controls.Add(deleteButton);

                        MenuFlowLayout.Controls.Add(newItemPanel);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading menu: {ex.Message}");
            }
        }

        private async Task DeleteMenu(string menuId)
        {
            try
            {
                DialogResult result = MessageBox.Show(
                "Are you sure you want to delete the product?",
                "Delete Product",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2
                );

                if (result == DialogResult.OK)
                {
                    FirebaseResponse response = await client.DeleteAsync("MenuItems/" + menuId);
                    AlertBox(Color.Green, Color.Blue, "Success", "Menu Item successfully deleted!", Properties.Resources.icons8_success_48);
                    LoadMenus();
                }
            }
            catch (Exception ex)
            {
                AlertBox(Color.Coral, Color.SeaGreen, "Error", $"Failed to delete product: {ex.Message}", Properties.Resources.icons8_error_48);
            }
        }


        private void BrowseImageMenuItemButton_Click(object sender, EventArgs e)
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

                        MenuPictureBoxItem.Image = Image.FromFile(selectedImagePath);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"An error occurred while displaying the image: {ex.Message}");
                    }
                }
            }
        }



        //TRANSACTION TAB

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

        private BorderRadiusPanel selectedPanel;
        private Dictionary<Control, Color> originalColors = new Dictionary<Control, Color>();

        private void SortAllHistoryLabel_Click(object sender, EventArgs e)
        {
            AllLabelHighlighter.Visible = true;
            TodayLabelHighlighter.Visible = false;
            WeekLabelHighlighter.Visible = false;
            LoadTransactions();
        }

        private void SortTodayHistoryLabel_Click(object sender, EventArgs e)
        {
            AllLabelHighlighter.Visible = false;
            WeekLabelHighlighter.Visible = false;
            TodayLabelHighlighter.Visible = true;
            LoadTransactions(DateTime.Now.Date);
        }

        private void SortYesterdayHistoryLabel_Click(object sender, EventArgs e)
        {
            AllLabelHighlighter.Visible = false;
            WeekLabelHighlighter.Visible = true;
            TodayLabelHighlighter.Visible = false;
            LoadTransactions(DateTime.Now.Date.AddDays(-1));
        }

        private async void LoadTransactions(DateTime? startDate = null)
        {
            try
            {
                TransactionListFlowLayoutPanel.Controls.Clear();

                var orderDetailsTask = client.GetAsync("OrderDetails");
                var customerTransactionTask = client.GetAsync("customerTransaction");
                var usersTask = client.GetAsync("users");

                await Task.WhenAll(orderDetailsTask, customerTransactionTask, usersTask);

                var orderResponse = orderDetailsTask.Result;
                var customerResponse = customerTransactionTask.Result;
                var usersResponse = usersTask.Result;

                if (orderResponse.StatusCode != HttpStatusCode.OK || customerResponse.StatusCode != HttpStatusCode.OK || usersResponse.StatusCode != HttpStatusCode.OK) return;

                var transactions = JsonConvert.DeserializeObject<Dictionary<string, OrderDetails>>(orderResponse.Body);
                var customerTrans = JsonConvert.DeserializeObject<Dictionary<string, customerTransaction>>(customerResponse.Body);
                var usersList = JsonConvert.DeserializeObject<Dictionary<string, users>>(usersResponse.Body);

                if (transactions == null || !transactions.Values.Any() || customerTrans == null || !customerTrans.Values.Any() || usersList == null || !usersList.Values.Any()) return;

                var declinedTransactions = transactions.Values
                    .Where(t => t.orderStatus == "Declined" && t.stallID == UserUID);

                var filteredTransactions = transactions.Values
                    .Where(t => (t.orderStatus == "Finished" || t.orderStatus == "Declined" || t.orderStatus == "Received")
                                 && t.stallID == UserUID);

                if (startDate.HasValue)
                {
                    DateTime startDateOnly = startDate.Value.Date;
                    filteredTransactions = filteredTransactions
                        .Where(t => DateTime.ParseExact(t.orderDate, "ddd, MMMM d, yyyy", null).Date == startDateOnly);
                }

                int totalDeclinedOrders = declinedTransactions.Count();

                TotalDeclinedOrdersLabel.Text = totalDeclinedOrders.ToString();

                filteredTransactions = filteredTransactions
                    .OrderByDescending(t => DateTime.ParseExact(t.orderDate, "ddd, MMMM d, yyyy", null))
                    .ToList();

                TransactionListFlowLayoutPanel.SuspendLayout();

                foreach (var transaction in filteredTransactions)
                {
                    var customerTransaction = customerTrans.Values.FirstOrDefault(ct => ct.customerTransactionID == transaction.orderId);
                    if (customerTransaction != null)
                    {
                        var user = usersList.Values.FirstOrDefault(u => u.userID == customerTransaction.customerID);
                        Image customerProfilePicture = user != null ? await LoadImageFromUrl(user.imagePath) : Properties.Resources.icons8_error_48;

                        BorderRadiusPanel bodyPanel = new BorderRadiusPanel
                        {
                            Size = new Size(316, 66),
                            BackColor = Color.White,
                            BorderColor = Color.Gainsboro,
                            BorderRadius = 15,
                            BorderSize = 7,
                        };

                        BorderRadiusPictureBox PicBox = new BorderRadiusPictureBox
                        {
                            Size = new Size(46, 50),
                            Image = customerProfilePicture,
                            SizeMode = PictureBoxSizeMode.StretchImage,
                            Location = new Point(8, 8)
                        };
                        bodyPanel.Controls.Add(PicBox);

                        Label customerName = new Label
                        {
                            Text = customerTransaction.customerName,
                            Size = new Size(135, 19),
                            TextAlign = ContentAlignment.MiddleLeft,
                            Font = new Font("Century Gothic", 12, FontStyle.Bold),
                            Location = new Point(59, 14)
                        };
                        bodyPanel.Controls.Add(customerName);

                        Label transactionStatus = new Label
                        {
                            Text = $"◉{transaction.orderStatus}",
                            Size = new Size(105, 20),
                            TextAlign = ContentAlignment.TopLeft,
                            Font = new Font("Century Gothic", 11, FontStyle.Regular),
                            Location = new Point(56, 33)
                        };
                        transactionStatus.ForeColor = transaction.orderStatus == "Declined" ? Color.Red : Color.LimeGreen;
                        bodyPanel.Controls.Add(transactionStatus);

                        Label transactionTotalPrice = new Label
                        {
                            Text = ($"₱{transaction.totalPrice}"),
                            Size = new Size(126, 19),
                            TextAlign = ContentAlignment.MiddleCenter,
                            Font = new Font("Century Gothic", 11, FontStyle.Bold),
                            Location = new Point(174, 15)
                        };
                        bodyPanel.Controls.Add(transactionTotalPrice);

                        Label dateTimeFinish = new Label
                        {
                            Text = transaction.orderDate,
                            Size = new Size(150, 14),
                            TextAlign = ContentAlignment.MiddleCenter,
                            Font = new Font("Arial Rounded MT", 9, FontStyle.Bold),
                            ForeColor = Color.DarkOrange,
                            Location = new Point(157, 38)
                        };
                        bodyPanel.Controls.Add(dateTimeFinish);

                        TransactionListFlowLayoutPanel.Controls.Add(bodyPanel);

                        bodyPanel.MouseDown += async (s, e) => { if (e.Button == MouseButtons.Left) await SelectPanelAsync(bodyPanel, customerTransaction, transaction, customerProfilePicture, transactionStatus); };
                        PicBox.MouseDown += async (s, e) => { if (e.Button == MouseButtons.Left) await SelectPanelAsync(bodyPanel, customerTransaction, transaction, customerProfilePicture, transactionStatus); };
                        customerName.MouseDown += async (s, e) => { if (e.Button == MouseButtons.Left) await SelectPanelAsync(bodyPanel, customerTransaction, transaction, customerProfilePicture, transactionStatus); };
                        transactionTotalPrice.MouseDown += async (s, e) => { if (e.Button == MouseButtons.Left) await SelectPanelAsync(bodyPanel, customerTransaction, transaction, customerProfilePicture, transactionStatus); };
                        transactionStatus.MouseDown += async (s, e) => { if (e.Button == MouseButtons.Left) await SelectPanelAsync(bodyPanel, customerTransaction, transaction, customerProfilePicture, transactionStatus); };
                        dateTimeFinish.MouseDown += async (s, e) => { if (e.Button == MouseButtons.Left) await SelectPanelAsync(bodyPanel, customerTransaction, transaction, customerProfilePicture, transactionStatus); };

                        TotalTransactionsLabel.Text = TransactionListFlowLayoutPanel.Controls.Count.ToString();
                    }
                }

                TransactionListFlowLayoutPanel.ResumeLayout();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error, {ex}");
            }
        }





        private async Task SelectPanelAsync(BorderRadiusPanel bodyPanel, customerTransaction customerTransaction, OrderDetails transaction, Image customerProfilePicture, Label transactionStatus)
        {
            if (selectedPanel != null)
            {
                selectedPanel.BackColor = Color.White;
                foreach (Control control in selectedPanel.Controls)
                {
                    if (originalColors.TryGetValue(control, out var originalColor))
                        control.ForeColor = originalColor;

                    if (control is BorderRadiusPictureBox picBox)
                        picBox.BorderColor = Color.White;
                }
            }

            selectedPanel = bodyPanel;
            selectedPanel.BackColor = Color.Blue;

            foreach (Control control in selectedPanel.Controls)
            {
                if (!originalColors.ContainsKey(control))
                    originalColors[control] = control.ForeColor;

                if (control is BorderRadiusPictureBox picBox)
                    picBox.BorderColor = Color.Blue;
                else if (control is Label label)
                    label.ForeColor = Color.White;
                    transactionStatus.ForeColor = transaction.orderStatus == "Declined" ? Color.Red : Color.LimeGreen;
            }

            customerPicturePcbx.Image = customerProfilePicture;
            customerUserIDLabel.Text = customerTransaction.customerID;
            customerNameLabel.Text = customerTransaction.customerName;
            string hashEmail = MaskEmail(customerTransaction.customerEmail);
            customerEmailLabel.Text = hashEmail;

            orderIDLabel.Text = transaction.orderId;
            orderTypeLabel.Text = transaction.type;
            orderStatusLabel.Text = transaction.orderStatus;
            if(transaction.orderStatus.ToString() == "Declined")
            {
                VerifyButton.Enabled = false;
                ReceiveOrderButton.Enabled = false;
                PrintReceiptButton.Enabled = false;
            } else
            {
                VerifyButton.Enabled = true;
                ReceiveOrderButton.Enabled = true;
                PrintReceiptButton.Enabled = true;
            }
            orderDateLabel.Text = transaction.orderDate;
            orderTimeLabel.Text = transaction.orderTime;
            paymentMethodLabel.Text = transaction.paymentMethod;
            isPaidLabel.Text = transaction.paid;
            overallTotalLabel.Text = ($"₱{transaction.totalPrice}");

            

            FirebaseResponse NewResponse = await client.GetAsync($"OrderDetails/{transaction.orderId}");
            if (NewResponse.StatusCode != HttpStatusCode.OK) return;

            var newTransaction = JsonConvert.DeserializeObject<OrderDetails>(NewResponse.Body);
            if (newTransaction != null)
            {
                OrderedProducts.Visible = true;
                OrderedProducts.Items.Clear();
                foreach (var product in newTransaction.products)
                {
                    var item = new ListViewItem(product.name);
                    item.SubItems.Add($"   {product.quantity}");
                    item.SubItems.Add($"₱{product.price}");
                    item.SubItems.Add($"₱{product.subTotalPrice}");
                    OrderedProducts.Items.Add(item);
                }
            }
        }


        private void SortTransactionMonthLabel_Click(object sender, EventArgs e)
        {
            LoadTransactions();
        }


        private void PrintReceiptButton_Click(object sender, EventArgs e)
        {
            if (orderIDLabel.Text == "Order ID")
            {
                MessageBox.Show("Select transaction first!", "EMPTY", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                var orderId = orderIDLabel.Text;
                LoadPrintDetails(orderId);
            }
        }


        private async void LoadPrintDetails(string orderId)
        {
            FirebaseResponse response = await client.GetAsync($"customerTransaction/{orderId}");
            if (response.StatusCode == HttpStatusCode.OK)
            {
                var customerTrans = JsonConvert.DeserializeObject<customerTransaction>(response.Body);
                if (customerTrans != null)
                {
                    FirebaseResponse orderResponse = await client.GetAsync($"OrderDetails/{orderId}");
                    if (orderResponse.StatusCode == HttpStatusCode.OK)
                    {
                        var orderData = JsonConvert.DeserializeObject<OrderDetails>(orderResponse.Body);
                        if (orderData != null && orderData.products != null)
                        {
                            var productList = orderData.products
                                .Select(p => $"{p.name},{p.quantity},{p.price},{p.subTotalPrice}")
                                .ToList();

                            Form modalBackground = new Form();
                            using (PrintReceiptDialog modal = new PrintReceiptDialog(
                                UserUID, customerTrans.customerName, orderData.type, orderData.paymentMethod,
                                orderData.paid, orderData.totalPrice, StallOwnerNameLabel.Text,
                                productList, orderData.orderDate, orderData.orderTime))
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
            }
        }

        private async void ReceiveOrderButton_Click(object sender, EventArgs e)
        {
            if (customerUserIDLabel.Text == "User ID")
            {
                MessageBox.Show("Please select a transaction to scan!", "EMPTY", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            } else if (orderStatusLabel.Text == "Received")
            {
                MessageBox.Show("This order is already receive!", "ALREADY RECEIVED", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                string orderID = orderIDLabel.Text;
                DialogResult result = MessageBox.Show(
                "Are you sure the Order is served to the customer?",
                "Finish",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2
                );

                if (result == DialogResult.Yes)
                {

                    var acceptStatus = "Received";

                    var updateStatus = new
                    {
                        orderStatus = acceptStatus
                    };
                    FirebaseResponse response = await client.UpdateAsync($"OrderDetails/{orderID}", updateStatus);
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        var paidStatus = "Paid";

                        var updatePaymentStatus = new
                        {
                            paid = paidStatus
                        };
                        FirebaseResponse newestResponse = await client.UpdateAsync($"OrderDetails/{orderID}", updatePaymentStatus);
                        if (newestResponse.StatusCode == HttpStatusCode.OK)
                        {
                            MessageBox.Show("Received, proceeding to print receipt", "Received", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadTransactions();
                            LoadSales();
                        }
                        
                    }
                }
            }
        }

        //SALES HISTORY


        private async void LoadSales()
        {
            try
            {
                decimal totalSales = 0;
                var paymentMethodsSales = new Dictionary<string, decimal>();
                var monthlySales = new Dictionary<string, decimal>();
                var weeklySales = new Dictionary<int, decimal>(); // Dictionary to hold weekly sales

                FirebaseResponse orderResponse = await client.GetAsync("OrderDetails");
                if (orderResponse.StatusCode != HttpStatusCode.OK) return;

                var transactions = JsonConvert.DeserializeObject<Dictionary<string, OrderDetails>>(orderResponse.Body);
                if (transactions == null || !transactions.Values.Any()) return;

                var receivedOrders = transactions.Values
                    .Where(t => t.orderStatus == "Received" && t.stallID == UserUID)
                    .ToList();

                Console.WriteLine($"Received Orders Count: {receivedOrders.Count}");

                if (!receivedOrders.Any())
                {
                    Console.WriteLine("No orders with status 'Received' were found.");
                    return;
                }

                foreach (var transaction in receivedOrders)
                {
                    string cleanTotalPrice = transaction.totalPrice.Replace("₱", "").Replace(",", "");
                    decimal parsedTotalPrice = decimal.Parse(cleanTotalPrice);
                    totalSales += parsedTotalPrice;
                    LifeTimeSalesLabel.Text = ($"₱{totalSales.ToString()}");

                    string paymentMethod = transaction.paymentMethod.Trim();

                    // Aggregate sales by payment method
                    if (!paymentMethodsSales.ContainsKey(paymentMethod))
                    {
                        paymentMethodsSales[paymentMethod] = 0;
                    }
                    paymentMethodsSales[paymentMethod] += parsedTotalPrice;

                    // Manual extraction of month, day, and year from orderDate string
                    string orderDate = transaction.orderDate; // "Wed, January 01, 2025"
                    string[] dateParts = orderDate.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

                    string month = dateParts[1]; // The month is at index 1 (January)
                    string day = dateParts[2]; // The day is at index 2 (01)
                    string year = dateParts[3]; // The year is at index 3 (2025)

                    // Calculate the week number for the current month
                    DateTime orderDateTime = new DateTime(int.Parse(year), DateTime.ParseExact(month, "MMMM", CultureInfo.InvariantCulture).Month, int.Parse(day));
                    int weekOfMonth = (orderDateTime.Day - 1) / 7 + 1; // Week number

                    // Update weekly sales
                    if (!weeklySales.ContainsKey(weekOfMonth))
                    {
                        weeklySales[weekOfMonth] = 0;
                    }
                    weeklySales[weekOfMonth] += parsedTotalPrice;

                    string monthYear = $"{month} {year}"; // Combine month and year for aggregation

                    if (monthlySales.ContainsKey(monthYear))
                    {
                        monthlySales[monthYear] += parsedTotalPrice;
                    }
                    else
                    {
                        monthlySales[monthYear] = parsedTotalPrice;
                    }
                }

                decimal totalSalesAmount = totalSales != 0 ? totalSales : 1m;
                var paymentMethodPercentages = paymentMethodsSales
                    .ToDictionary(kvp => kvp.Key, kvp => (kvp.Value / totalSalesAmount) * 100m);

                Console.WriteLine("Payment Method Sales Breakdown:");
                foreach (var payment in paymentMethodPercentages)
                {
                    Console.WriteLine($"{payment.Key} Sales: {payment.Value:F2}%");
                }

                // Update the chart for payment method percentages
                var chartValues = new ChartValues<decimal>(paymentMethodPercentages.Values);
                cartesianChart1.Series = new LiveCharts.SeriesCollection
        {
            new ColumnSeries
            {
                Title = "Sales Percentage",
                Values = chartValues
            }
        };

                cartesianChart1.AxisX = new LiveCharts.Wpf.AxesCollection
        {
            new LiveCharts.Wpf.Axis
            {
                Title = "Payment Method",
                Labels = paymentMethodPercentages.Keys.ToArray() // Dynamic labels for payment methods
            }
        };

                cartesianChart1.AxisY = new LiveCharts.Wpf.AxesCollection
        {
            new LiveCharts.Wpf.Axis
            {
                Title = "Percentage",
                LabelFormatter = value => value.ToString("N0") + "%"
            }
        };

                // Display monthly sales
                var monthlyChartValues = monthlySales.Select(m => new { Month = m.Key, Sales = m.Value }).ToList();

                var monthlySeries = new LiveCharts.SeriesCollection
        {
            new LiveCharts.Wpf.ColumnSeries
            {
                Title = "Monthly Sales",
                Values = new LiveCharts.ChartValues<decimal>(monthlyChartValues.Select(v => v.Sales)),
                DataLabels = true
            }
        };

                cartesianChart2.Series = monthlySeries;
                cartesianChart2.AxisX.Add(new LiveCharts.Wpf.Axis
                {
                    Title = "Month",
                    Labels = monthlyChartValues.Select(v => v.Month).ToArray()
                });
                cartesianChart2.AxisY.Add(new LiveCharts.Wpf.Axis
                {
                    Title = "Sales",
                    LabelFormatter = value => $"₱{value:0.##}"
                });

                // Display weekly sales for the current month
                var weeklyChartValues = weeklySales.Select(w => new { Week = w.Key, Sales = w.Value }).ToList();

                var weeklySeries = new LiveCharts.SeriesCollection
        {
            new LiveCharts.Wpf.ColumnSeries
            {
                Title = "Weekly Sales",
                Values = new LiveCharts.ChartValues<decimal>(weeklyChartValues.Select(v => v.Sales)),
                DataLabels = true
            }
        };

                cartesianChart3.Series = weeklySeries;
                cartesianChart3.AxisX.Add(new LiveCharts.Wpf.Axis
                {
                    Title = "Week",
                    Labels = new[] { "Week 1", "Week 2", "Week 3", "Week 4" } // Label the weeks dynamically
                });
                cartesianChart3.AxisY.Add(new LiveCharts.Wpf.Axis
                {
                    Title = "Sales",
                    LabelFormatter = value => $"₱{value:0.##}"
                });

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }






        //STALL ACCOUNT

        private async void LoadStallInformation()
        {
            try
            {
                FirebaseResponse response = await client.GetAsync($"adminInformation/{UserUID}");

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var userData = JsonConvert.DeserializeObject<StallInfo>(response.Body);

                    if (userData != null)
                    {
                        

                        StallNameOf = userData.stallName;

                        /*StallNumberEditLabel.Text = userData.stallNumber;
                        StallOwnerNameLabel.Text = $"{userData.firstName} {userData.lastName}";
                        ContactNumberEditLabel.Text = userData.contactNumber;
                        OperatingHoursEditLabel.Text = $"{userData.timein} - {userData.timeout}";
                        StallNameEditLabel.Text = userData.stallName;
                        List<string> daysSelected = userData.selectedDays;
                        StringBuilder abbreviatedDays = new StringBuilder();

                        foreach (var day in daysSelected)
                        {
                            if (day.Length >= 3)
                            {
                                abbreviatedDays.Append(day.Substring(0, 3) + ", ");
                            }
                        }
                        DaysOperationEditLabel.Text = abbreviatedDays.ToString().Trim();*/

                        if (!string.IsNullOrWhiteSpace(userData.Img))
                        {
                            var image = await LoadImageFromUrl(userData.Img);
                            if (image != null)
                            {
                                ViewStallProfilePictureBox.Image = image;
                                StallProfilePicturePcbx.Image = image;
                            }
                            else
                            {
                                AlertBox(Color.Coral, Color.SeaGreen, "Error", "Failed to load image.", Properties.Resources.icons8_error_48);
                            }
                        }
                    }
                }
                else
                {
                    AlertBox(Color.Coral, Color.SeaGreen, "Error", "Failed to retrieve user data.", Properties.Resources.icons8_error_48);
                }
            }
            catch (Exception e)
            {
                AlertBox(Color.Coral, Color.SeaGreen, "Error", $"Please check your network! {e}", Properties.Resources.icons8_error_48);
            }
        }


        /*private async Task LoadImageToPictureBox(string imageUrl, PictureBox pictureBox)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var response = await client.GetAsync(imageUrl);
                    if (response.IsSuccessStatusCode)
                    {
                        var imageStream = await response.Content.ReadAsStreamAsync();
                        pictureBox.Image = Image.FromStream(imageStream);
                    }
                    else
                    {
                        AlertBox(Color.Coral, Color.SeaGreen, "Error", "Failed to load image.", Properties.Resources.icons8_error_48);
                    }
                }
            }
            catch (Exception ex)
            {
                AlertBox(Color.Coral, Color.SeaGreen, "Error", $"Image loading error: {ex.Message}", Properties.Resources.icons8_error_48);
            }
        }*/

        private void roundedButton1_Click(object sender, EventArgs e)
        {
           if (customerUserIDLabel.Text == "User ID")
            {
                MessageBox.Show("Please select a transaction to scan!", "EMPTY", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
           else
            {
                var customerId = customerUserIDLabel.Text;
                var orderId = orderIDLabel.Text;
                using (QRCodeScanner scanner = new QRCodeScanner(customerId, orderId))
                    if (scanner.ShowDialog() == DialogResult.OK)
                    {
                        MessageBox.Show("Successfully scanned!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
            }
        }


        private string stallNameof;
        private string stallNameOfMenu => stallNameof;
        private async void LoadStallInfo()
        {
            try
            {
                FirebaseResponse response = await client.GetAsync($"adminInformation/{UserUID}");

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var userData = JsonConvert.DeserializeObject<StallInfo>(response.Body);

                    if (userData != null)
                    {

                        stallNameof = userData.stallName;
                        menuStallNameLabel.Text = userData.stallName;

                        StallNumberLabel.Text = ($"Stall No. {userData.stallNumber}");
                        StallOperationsLabel.Text = $"{userData.timein} - {userData.timeout}";

                        StallNumberEditLabel.Text = userData.stallNumber;
                        StallOwnerNameLabel.Text = $"{userData.firstName} {userData.lastName}";
                        ContactNumberEditLabel.Text = userData.contactNumber;
                        OperatingHoursEditLabel.Text = $"{userData.timein} - {userData.timeout}";
                        StallNameEditLabel.Text = userData.stallName;
                        List<string> daysSelected = userData.selectedDays;
                        StringBuilder abbreviatedDays = new StringBuilder();

                        foreach (var day in daysSelected)
                        {
                            if (day.Length >= 3)
                            {
                                abbreviatedDays.Append(day.Substring(0, 3) + ", ");
                            }
                        }
                        DaysOperationEditLabel.Text = abbreviatedDays.ToString().Trim();

                        if (!string.IsNullOrWhiteSpace(userData.Img))
                        {
                            var image = await LoadImageFromUrl(userData.Img);
                            if (image != null)
                            {
                                StallProfilePictureBox.Image = image;
                            }
                            else
                            {
                                AlertBox(Color.Coral, Color.SeaGreen, "Error", "Failed to load image.", Properties.Resources.icons8_error_48);
                            }
                        }
                        StallPaymentMethod();
                    }
                }
                else
                {
                    AlertBox(Color.Coral, Color.SeaGreen, "Error", "Failed to retrieve user data. Check Connection", Properties.Resources.icons8_error_48);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        private void EditStallButton_Click(object sender, EventArgs e)
        {
            Form modalBackground = new Form();
            using (DialogForm modal = new DialogForm(UserUID))
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
                    LoadStallInfo();
                }
            }
        }

        private void EditProfileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                StallProfilePictureBox.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private async void SaveStallPhotoButton_Click(object sender, EventArgs e)
        {
            using (var loadingDialog = new LoadingDialog())
            {
                loadingDialog.Show();
                string _imageUrl = await UploadImageToFirebaseAsync(StallProfilePictureBox.Image, $"{currentUserUID}_{Guid.NewGuid()}.png");
                if (_imageUrl == null)
                {
                    loadingDialog.Close();
                    AlertBox(Color.Coral, Color.SeaGreen, "Error", "Failed to upload, image is Empty!", Properties.Resources.icons8_error_48);
                }
                var updateData = new
                {
                    Img = _imageUrl
                };
                try
                {
                    FirebaseResponse response = await client.UpdateAsync($"adminInformation/{currentUserUID}", updateData);
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        loadingDialog.Close();
                        AlertBox(Color.SeaGreen, Color.White, "Sucess", "Image Successfully updated!", Properties.Resources.icons8_success_48);
                    }
                    else
                    {
                        loadingDialog.Close();
                        AlertBox(Color.Coral, Color.SeaGreen, "Error", "Error uploading image!", Properties.Resources.icons8_error_48);
                    }
                }
                catch (Exception ex)
                {
                    loadingDialog.Close();
                    AlertBox(Color.Coral, Color.SeaGreen, "Error", $"Failed to upload image! reason: {ex}", Properties.Resources.icons8_error_48);
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
                Console.WriteLine($"I/O Error: {ioEx.Message}", "Error");
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while uploading the image: {ex.Message}");
                return null;
            }
        }

        private async void StallPaymentMethod()
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
                        GcashButton.Checked = true;
                        label20.Visible = false;
                        ConnectGcashAccount.Text = "View >";
                    }
                }
            }
        }


        private void ConnectGcashAccount_Click(object sender, EventArgs e)
        {
            Form modalBackground = new Form();
            using (PaymentMethodGCash modal = new PaymentMethodGCash(UserUID))
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
                    LoadStallInfo();
                }
            }
        }




        //Functions for deleting the menus

        private async void DeleteMenus()
        {
            TimeZoneInfo philippineTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Singapore Standard Time");
            DateTime philippineTime = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, philippineTimeZone);

            string localDate = philippineTime.ToString("ddd, MMMM dd, yyyy");

            DateTime yesterday = philippineTime.AddDays(-1);
            //string yesterdayDate = yesterday.ToString("ddd, MMMM dd, yyyy");
            string yesterdayDate = "Fri, November 1, 2024";

            FirebaseResponse response = await client.GetAsync("MenuItems");
            if (response.StatusCode == HttpStatusCode.OK)
            {
                var menu = JsonConvert.DeserializeObject<Dictionary<string, MenuItem>>(response.Body);
                if (menu != null)
                {
                    foreach(var menuData in menu.Values)
                    {
                        if (menuData != null && menuData.menuType == yesterdayDate)
                        {
                            var id = menuData.menuItemID;
                            FirebaseResponse newResponse = await client.DeleteAsync($"MenuItems/{id}");
                            if (newResponse.StatusCode == HttpStatusCode.OK)
                            {
                                Console.WriteLine("Delete Success");
                                LoadMenus();
                            }
                        }
                        
                    }
                    
                } 
            }
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginStallForm stallLogin = new LoginStallForm();
            stallLogin.Show();
        }
    }
}

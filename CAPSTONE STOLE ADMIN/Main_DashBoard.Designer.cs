namespace CAPSTONE_STOLE_ADMIN
{
    partial class Main_DashBoard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_DashBoard));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Shake",
            "3",
            "$10",
            "$30"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "Cake",
            "1",
            "$100",
            "$100"}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "Cookies",
            "10",
            "$6",
            "$60"}, -1);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.Home = new System.Windows.Forms.TabPage();
            this.SortMonthLabel = new System.Windows.Forms.Label();
            this.SortYesterdayLabel = new System.Windows.Forms.Label();
            this.SortTodayLabel = new System.Windows.Forms.Label();
            this.SortAllLabel = new System.Windows.Forms.Label();
            this.AllLabelHighlighter1 = new System.Windows.Forms.Label();
            this.TodayLabelHighlighter1 = new System.Windows.Forms.Label();
            this.WeekLabelHighlighter1 = new System.Windows.Forms.Label();
            this.MonthLabelHighlighter1 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.OrderList = new System.Windows.Forms.DataGridView();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.label1 = new System.Windows.Forms.Label();
            this.Products = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.BrowseProductPicture = new MaterialSkin.Controls.MaterialButton();
            this.label11 = new System.Windows.Forms.Label();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.TBAddProductName = new MaterialSkin.Controls.MaterialTextBox2();
            this.TBAddProductDescription = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.TBAddProductStocks = new MaterialSkin.Controls.MaterialTextBox2();
            this.TBAddProductPrice = new MaterialSkin.Controls.MaterialTextBox2();
            this.TBAddProductCategory = new MaterialSkin.Controls.MaterialComboBox();
            this.TBAddProductQualification = new MaterialSkin.Controls.MaterialComboBox();
            this.PaginationPanel = new System.Windows.Forms.Panel();
            this.PageNumber = new MaterialSkin.Controls.MaterialLabel();
            this.nextButton = new MaterialSkin.Controls.MaterialButton();
            this.previousButton = new MaterialSkin.Controls.MaterialButton();
            this.ProductsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.Menus = new System.Windows.Forms.TabPage();
            this.materialCard8 = new MaterialSkin.Controls.MaterialCard();
            this.ViewMenuListComboBox = new System.Windows.Forms.ComboBox();
            this.CustomRadioButton = new System.Windows.Forms.RadioButton();
            this.TomorrowsMenuRadioButton = new System.Windows.Forms.RadioButton();
            this.TodaysMenuRadioButton = new System.Windows.Forms.RadioButton();
            this.MenuCustomDateText = new System.Windows.Forms.DateTimePicker();
            this.MenuTomorrowsDateText = new System.Windows.Forms.Label();
            this.MenuTodaysDateText = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.menuStallNameLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.materialCard4 = new MaterialSkin.Controls.MaterialCard();
            this.MenuFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.TBMenuItemStocks = new MaterialSkin.Controls.MaterialTextBox2();
            this.label7 = new System.Windows.Forms.Label();
            this.TBMenuItemPrice = new MaterialSkin.Controls.MaterialTextBox2();
            this.label6 = new System.Windows.Forms.Label();
            this.TBMenuItemName = new MaterialSkin.Controls.MaterialTextBox2();
            this.label5 = new System.Windows.Forms.Label();
            this.BrowseImageMenuItemButton = new MaterialSkin.Controls.MaterialButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Transactions = new System.Windows.Forms.TabPage();
            this.label16 = new System.Windows.Forms.Label();
            this.SortTodayHistoryLabel = new System.Windows.Forms.Label();
            this.SortAllHistoryLabel = new System.Windows.Forms.Label();
            this.materialCard11 = new MaterialSkin.Controls.MaterialCard();
            this.orderIDLabel = new System.Windows.Forms.Label();
            this.overallTotalLabel = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.isPaidLabel = new System.Windows.Forms.Label();
            this.paymentMethodLabel = new System.Windows.Forms.Label();
            this.orderTimeLabel = new System.Windows.Forms.Label();
            this.orderDateLabel = new System.Windows.Forms.Label();
            this.orderStatusLabel = new System.Windows.Forms.Label();
            this.OrderedProducts = new MaterialSkin.Controls.MaterialListView();
            this.OrderedProductsColumnInListView = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.QuantityListView = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PriceListView = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TotalPriceListView = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label31 = new System.Windows.Forms.Label();
            this.orderTypeLabel = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.customerEmailLabel = new System.Windows.Forms.Label();
            this.customerUserIDLabel = new System.Windows.Forms.Label();
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.TransactionListFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.materialCard10 = new MaterialSkin.Controls.MaterialCard();
            this.label13 = new System.Windows.Forms.Label();
            this.AllLabelHighlighter = new System.Windows.Forms.Label();
            this.TodayLabelHighlighter = new System.Windows.Forms.Label();
            this.WeekLabelHighlighter = new System.Windows.Forms.Label();
            this.SalesHistory = new System.Windows.Forms.TabPage();
            this.cartesianChart2 = new LiveCharts.WinForms.CartesianChart();
            this.cartesianChart3 = new LiveCharts.WinForms.CartesianChart();
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.label32 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Account = new System.Windows.Forms.TabPage();
            this.StallNumberLabel = new MaterialSkin.Controls.MaterialLabel();
            this.ConnectGcashAccount = new System.Windows.Forms.Label();
            this.StallOperationsLabel = new MaterialSkin.Controls.MaterialLabel();
            this.GcashButton = new System.Windows.Forms.CheckBox();
            this.PayOnPickupButton = new System.Windows.Forms.CheckBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.StallOwnerNameLabel = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel28 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel30 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel31 = new MaterialSkin.Controls.MaterialLabel();
            this.StallNumberEditLabel = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel33 = new MaterialSkin.Controls.MaterialLabel();
            this.StallNameEditLabel = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel35 = new MaterialSkin.Controls.MaterialLabel();
            this.OperatingHoursEditLabel = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel37 = new MaterialSkin.Controls.MaterialLabel();
            this.DaysOperationEditLabel = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel39 = new MaterialSkin.Controls.MaterialLabel();
            this.ContactNumberEditLabel = new MaterialSkin.Controls.MaterialLabel();
            this.materialFloatingActionButton6 = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.materialFloatingActionButton7 = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.materialFloatingActionButton8 = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.materialFloatingActionButton9 = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.materialFloatingActionButton10 = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.AddProductCategory = new MaterialSkin.Controls.MaterialComboBox();
            this.addProductQualification = new MaterialSkin.Controls.MaterialComboBox();
            this.Category = new MaterialSkin.Controls.MaterialLabel();
            this.Qualification = new MaterialSkin.Controls.MaterialLabel();
            this.MaterialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.addProductQuantity = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.MaterialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.AddProductPrice = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borderRadiusPanel9 = new CAPSTONE_STOLE_ADMIN.BorderRadiusPanel();
            this.TotalSalesLabel = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.borderRadiusPanel10 = new CAPSTONE_STOLE_ADMIN.BorderRadiusPanel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.borderRadiusPanel7 = new CAPSTONE_STOLE_ADMIN.BorderRadiusPanel();
            this.TotalDeclinedOrdersLabel = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.borderRadiusPanel8 = new CAPSTONE_STOLE_ADMIN.BorderRadiusPanel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.borderRadiusPanel5 = new CAPSTONE_STOLE_ADMIN.BorderRadiusPanel();
            this.TotalTransactionsLabel = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.borderRadiusPanel6 = new CAPSTONE_STOLE_ADMIN.BorderRadiusPanel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.borderRadiusPanel3 = new CAPSTONE_STOLE_ADMIN.BorderRadiusPanel();
            this.ProductCountLabel = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.borderRadiusPanel4 = new CAPSTONE_STOLE_ADMIN.BorderRadiusPanel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.borderRadiusPanel1 = new CAPSTONE_STOLE_ADMIN.BorderRadiusPanel();
            this.TotalOrdersLabel = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.borderRadiusPanel2 = new CAPSTONE_STOLE_ADMIN.BorderRadiusPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Orders = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Paid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ViewOrderButton = new CAPSTONE_STOLE_ADMIN.RoundedButton();
            this.AcceptOrderButton = new CAPSTONE_STOLE_ADMIN.RoundedButton();
            this.FinishOrderButton = new CAPSTONE_STOLE_ADMIN.RoundedButton();
            this.DeclineOrderButton = new CAPSTONE_STOLE_ADMIN.RoundedButton();
            this.ReadyOrderButton = new CAPSTONE_STOLE_ADMIN.RoundedButton();
            this.AddProductImage = new CAPSTONE_STOLE_ADMIN.BorderRadiusPictureBox();
            this.AddNewProductButton = new CAPSTONE_STOLE_ADMIN.RoundedButton();
            this.ViewStallProfilePictureBox = new CAPSTONE_STOLE_ADMIN.BorderRadiusPictureBox();
            this.SaveMenuButton = new CAPSTONE_STOLE_ADMIN.RoundedButton();
            this.MenuPictureBoxItem = new CAPSTONE_STOLE_ADMIN.BorderRadiusPictureBox();
            this.PrintReceiptButton = new CAPSTONE_STOLE_ADMIN.RoundedButton();
            this.ReceiveOrderButton = new CAPSTONE_STOLE_ADMIN.RoundedButton();
            this.VerifyButton = new CAPSTONE_STOLE_ADMIN.RoundedButton();
            this.customerPicturePcbx = new CAPSTONE_STOLE_ADMIN.BorderRadiusPictureBox();
            this.StallProfilePicturePcbx = new CAPSTONE_STOLE_ADMIN.BorderRadiusPictureBox();
            this.borderRadiusPanel11 = new CAPSTONE_STOLE_ADMIN.BorderRadiusPanel();
            this.label15 = new System.Windows.Forms.Label();
            this.LifeTimeSalesLabel = new System.Windows.Forms.Label();
            this.LogoutButton = new CAPSTONE_STOLE_ADMIN.RoundedButton();
            this.StallProfilePictureBox = new CAPSTONE_STOLE_ADMIN.BorderRadiusPictureBox();
            this.EditStallButton = new CAPSTONE_STOLE_ADMIN.RoundedButton();
            this.EditProfileButton = new CAPSTONE_STOLE_ADMIN.RoundedButton();
            this.SaveStallPhotoButton = new CAPSTONE_STOLE_ADMIN.RoundedButton();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialTabControl1.SuspendLayout();
            this.Home.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderList)).BeginInit();
            this.materialCard1.SuspendLayout();
            this.Products.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.PaginationPanel.SuspendLayout();
            this.Menus.SuspendLayout();
            this.materialCard8.SuspendLayout();
            this.materialCard4.SuspendLayout();
            this.materialCard3.SuspendLayout();
            this.Transactions.SuspendLayout();
            this.materialCard11.SuspendLayout();
            this.materialCard10.SuspendLayout();
            this.SalesHistory.SuspendLayout();
            this.Account.SuspendLayout();
            this.borderRadiusPanel9.SuspendLayout();
            this.borderRadiusPanel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.borderRadiusPanel7.SuspendLayout();
            this.borderRadiusPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.borderRadiusPanel5.SuspendLayout();
            this.borderRadiusPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.borderRadiusPanel3.SuspendLayout();
            this.borderRadiusPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.borderRadiusPanel1.SuspendLayout();
            this.borderRadiusPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddProductImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewStallProfilePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuPictureBoxItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerPicturePcbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StallProfilePicturePcbx)).BeginInit();
            this.borderRadiusPanel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StallProfilePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8-menu-50.png");
            this.imageList1.Images.SetKeyName(1, "icons8-account-50.png");
            this.imageList1.Images.SetKeyName(2, "icons8-home-48.png");
            this.imageList1.Images.SetKeyName(3, "icons8-products-50.png");
            this.imageList1.Images.SetKeyName(4, "icons8-transaction-30.png");
            this.imageList1.Images.SetKeyName(5, "icons8-preorder-32 (1).png");
            this.imageList1.Images.SetKeyName(6, "icons8-sales-50 (2).png");
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.Home);
            this.materialTabControl1.Controls.Add(this.Products);
            this.materialTabControl1.Controls.Add(this.Menus);
            this.materialTabControl1.Controls.Add(this.Transactions);
            this.materialTabControl1.Controls.Add(this.SalesHistory);
            this.materialTabControl1.Controls.Add(this.Account);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.imageList1;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 64);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1258, 614);
            this.materialTabControl1.TabIndex = 0;
            // 
            // Home
            // 
            this.Home.AutoScroll = true;
            this.Home.BackColor = System.Drawing.Color.White;
            this.Home.Controls.Add(this.SortMonthLabel);
            this.Home.Controls.Add(this.SortYesterdayLabel);
            this.Home.Controls.Add(this.SortTodayLabel);
            this.Home.Controls.Add(this.SortAllLabel);
            this.Home.Controls.Add(this.AllLabelHighlighter1);
            this.Home.Controls.Add(this.TodayLabelHighlighter1);
            this.Home.Controls.Add(this.WeekLabelHighlighter1);
            this.Home.Controls.Add(this.MonthLabelHighlighter1);
            this.Home.Controls.Add(this.label28);
            this.Home.Controls.Add(this.borderRadiusPanel9);
            this.Home.Controls.Add(this.borderRadiusPanel7);
            this.Home.Controls.Add(this.borderRadiusPanel5);
            this.Home.Controls.Add(this.borderRadiusPanel3);
            this.Home.Controls.Add(this.borderRadiusPanel1);
            this.Home.Controls.Add(this.OrderList);
            this.Home.Controls.Add(this.materialCard1);
            this.Home.ImageKey = "icons8-home-48.png";
            this.Home.Location = new System.Drawing.Point(4, 23);
            this.Home.Name = "Home";
            this.Home.Padding = new System.Windows.Forms.Padding(3);
            this.Home.Size = new System.Drawing.Size(1250, 587);
            this.Home.TabIndex = 0;
            this.Home.Text = "Home";
            // 
            // SortMonthLabel
            // 
            this.SortMonthLabel.AutoSize = true;
            this.SortMonthLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SortMonthLabel.Location = new System.Drawing.Point(296, 158);
            this.SortMonthLabel.Name = "SortMonthLabel";
            this.SortMonthLabel.Size = new System.Drawing.Size(43, 21);
            this.SortMonthLabel.TabIndex = 64;
            this.SortMonthLabel.Text = "Past";
            this.SortMonthLabel.Click += new System.EventHandler(this.SortMonthLabel_Click);
            // 
            // SortYesterdayLabel
            // 
            this.SortYesterdayLabel.AutoSize = true;
            this.SortYesterdayLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SortYesterdayLabel.Location = new System.Drawing.Point(192, 158);
            this.SortYesterdayLabel.Name = "SortYesterdayLabel";
            this.SortYesterdayLabel.Size = new System.Drawing.Size(89, 21);
            this.SortYesterdayLabel.TabIndex = 63;
            this.SortYesterdayLabel.Text = "Yesterday";
            this.SortYesterdayLabel.Click += new System.EventHandler(this.SortYesterdayLabel_Click);
            // 
            // SortTodayLabel
            // 
            this.SortTodayLabel.AutoSize = true;
            this.SortTodayLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SortTodayLabel.Location = new System.Drawing.Point(110, 158);
            this.SortTodayLabel.Name = "SortTodayLabel";
            this.SortTodayLabel.Size = new System.Drawing.Size(58, 21);
            this.SortTodayLabel.TabIndex = 62;
            this.SortTodayLabel.Text = "Today";
            this.SortTodayLabel.Click += new System.EventHandler(this.SortTodayLabel_Click);
            // 
            // SortAllLabel
            // 
            this.SortAllLabel.AutoSize = true;
            this.SortAllLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SortAllLabel.Location = new System.Drawing.Point(48, 158);
            this.SortAllLabel.Name = "SortAllLabel";
            this.SortAllLabel.Size = new System.Drawing.Size(29, 21);
            this.SortAllLabel.TabIndex = 60;
            this.SortAllLabel.Text = "All";
            this.SortAllLabel.Click += new System.EventHandler(this.SortAllLabel_Click);
            // 
            // AllLabelHighlighter1
            // 
            this.AllLabelHighlighter1.AutoSize = true;
            this.AllLabelHighlighter1.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllLabelHighlighter1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.AllLabelHighlighter1.Location = new System.Drawing.Point(40, 156);
            this.AllLabelHighlighter1.Name = "AllLabelHighlighter1";
            this.AllLabelHighlighter1.Size = new System.Drawing.Size(48, 27);
            this.AllLabelHighlighter1.TabIndex = 61;
            this.AllLabelHighlighter1.Text = "___";
            // 
            // TodayLabelHighlighter1
            // 
            this.TodayLabelHighlighter1.AutoSize = true;
            this.TodayLabelHighlighter1.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TodayLabelHighlighter1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.TodayLabelHighlighter1.Location = new System.Drawing.Point(104, 156);
            this.TodayLabelHighlighter1.Name = "TodayLabelHighlighter1";
            this.TodayLabelHighlighter1.Size = new System.Drawing.Size(72, 27);
            this.TodayLabelHighlighter1.TabIndex = 65;
            this.TodayLabelHighlighter1.Text = "_____";
            // 
            // WeekLabelHighlighter1
            // 
            this.WeekLabelHighlighter1.AutoSize = true;
            this.WeekLabelHighlighter1.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeekLabelHighlighter1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.WeekLabelHighlighter1.Location = new System.Drawing.Point(195, 156);
            this.WeekLabelHighlighter1.Name = "WeekLabelHighlighter1";
            this.WeekLabelHighlighter1.Size = new System.Drawing.Size(84, 27);
            this.WeekLabelHighlighter1.TabIndex = 66;
            this.WeekLabelHighlighter1.Text = "______";
            // 
            // MonthLabelHighlighter1
            // 
            this.MonthLabelHighlighter1.AutoSize = true;
            this.MonthLabelHighlighter1.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonthLabelHighlighter1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.MonthLabelHighlighter1.Location = new System.Drawing.Point(293, 156);
            this.MonthLabelHighlighter1.Name = "MonthLabelHighlighter1";
            this.MonthLabelHighlighter1.Size = new System.Drawing.Size(48, 27);
            this.MonthLabelHighlighter1.TabIndex = 67;
            this.MonthLabelHighlighter1.Text = "___";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label28.Location = new System.Drawing.Point(27, 124);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(163, 23);
            this.label28.TabIndex = 23;
            this.label28.Text = "Incoming Orders";
            // 
            // OrderList
            // 
            this.OrderList.AllowUserToAddRows = false;
            this.OrderList.AllowUserToDeleteRows = false;
            this.OrderList.AllowUserToResizeColumns = false;
            this.OrderList.AllowUserToResizeRows = false;
            this.OrderList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OrderList.BackgroundColor = System.Drawing.Color.White;
            this.OrderList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OrderList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.OrderList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OrderList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.OrderList.ColumnHeadersHeight = 40;
            this.OrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.OrderList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Time,
            this.Orders,
            this.Type,
            this.Date,
            this.Status,
            this.Paid,
            this.TotalPrice,
            this.PaymentMethod});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OrderList.DefaultCellStyle = dataGridViewCellStyle2;
            this.OrderList.GridColor = System.Drawing.Color.White;
            this.OrderList.Location = new System.Drawing.Point(17, 201);
            this.OrderList.Name = "OrderList";
            this.OrderList.ReadOnly = true;
            this.OrderList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OrderList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.OrderList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OrderList.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.OrderList.RowTemplate.Height = 16;
            this.OrderList.RowTemplate.ReadOnly = true;
            this.OrderList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.OrderList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OrderList.ShowCellErrors = false;
            this.OrderList.ShowCellToolTips = false;
            this.OrderList.ShowEditingIcon = false;
            this.OrderList.ShowRowErrors = false;
            this.OrderList.Size = new System.Drawing.Size(1063, 344);
            this.OrderList.TabIndex = 0;
            this.OrderList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OrderList_MouseClick);
            // 
            // materialCard1
            // 
            this.materialCard1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.ViewOrderButton);
            this.materialCard1.Controls.Add(this.label1);
            this.materialCard1.Controls.Add(this.AcceptOrderButton);
            this.materialCard1.Controls.Add(this.FinishOrderButton);
            this.materialCard1.Controls.Add(this.DeclineOrderButton);
            this.materialCard1.Controls.Add(this.ReadyOrderButton);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(1097, 158);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(136, 387);
            this.materialCard1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(29, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Actions";
            // 
            // Products
            // 
            this.Products.AutoScroll = true;
            this.Products.BackColor = System.Drawing.Color.White;
            this.Products.Controls.Add(this.label12);
            this.Products.Controls.Add(this.BrowseProductPicture);
            this.Products.Controls.Add(this.label11);
            this.Products.Controls.Add(this.materialCard2);
            this.Products.Controls.Add(this.TBAddProductName);
            this.Products.Controls.Add(this.TBAddProductDescription);
            this.Products.Controls.Add(this.TBAddProductStocks);
            this.Products.Controls.Add(this.TBAddProductPrice);
            this.Products.Controls.Add(this.TBAddProductCategory);
            this.Products.Controls.Add(this.TBAddProductQualification);
            this.Products.Controls.Add(this.PaginationPanel);
            this.Products.Controls.Add(this.ProductsFlowLayoutPanel);
            this.Products.Controls.Add(this.AddNewProductButton);
            this.Products.ImageKey = "icons8-products-50.png";
            this.Products.Location = new System.Drawing.Point(4, 23);
            this.Products.Name = "Products";
            this.Products.Padding = new System.Windows.Forms.Padding(3);
            this.Products.Size = new System.Drawing.Size(1250, 587);
            this.Products.TabIndex = 1;
            this.Products.Text = "Products";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label12.Location = new System.Drawing.Point(270, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(684, 54);
            this.label12.TabIndex = 49;
            this.label12.Text = "\"A great meal is a masterpiece; it’s crafted with care, seasoned with passion,\r\na" +
    "nd served with joy.\"\r\n";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BrowseProductPicture
            // 
            this.BrowseProductPicture.AutoSize = false;
            this.BrowseProductPicture.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BrowseProductPicture.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            this.BrowseProductPicture.Depth = 0;
            this.BrowseProductPicture.HighEmphasis = true;
            this.BrowseProductPicture.Icon = null;
            this.BrowseProductPicture.Location = new System.Drawing.Point(984, 276);
            this.BrowseProductPicture.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BrowseProductPicture.MouseState = MaterialSkin.MouseState.HOVER;
            this.BrowseProductPicture.Name = "BrowseProductPicture";
            this.BrowseProductPicture.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BrowseProductPicture.Size = new System.Drawing.Size(84, 21);
            this.BrowseProductPicture.TabIndex = 44;
            this.BrowseProductPicture.Text = "Browse";
            this.BrowseProductPicture.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.BrowseProductPicture.UseAccentColor = false;
            this.BrowseProductPicture.UseVisualStyleBackColor = true;
            this.BrowseProductPicture.Click += new System.EventHandler(this.BrowseProductPicture_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(73, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(136, 36);
            this.label11.TabIndex = 48;
            this.label11.Text = "Products";
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.AddProductImage);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(901, 112);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(248, 175);
            this.materialCard2.TabIndex = 43;
            // 
            // TBAddProductName
            // 
            this.TBAddProductName.AnimateReadOnly = false;
            this.TBAddProductName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TBAddProductName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TBAddProductName.Depth = 0;
            this.TBAddProductName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TBAddProductName.HideSelection = true;
            this.TBAddProductName.Hint = "Name";
            this.TBAddProductName.LeadingIcon = null;
            this.TBAddProductName.Location = new System.Drawing.Point(76, 112);
            this.TBAddProductName.MaxLength = 32767;
            this.TBAddProductName.MouseState = MaterialSkin.MouseState.OUT;
            this.TBAddProductName.Name = "TBAddProductName";
            this.TBAddProductName.PasswordChar = '\0';
            this.TBAddProductName.PrefixSuffixText = null;
            this.TBAddProductName.ReadOnly = false;
            this.TBAddProductName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TBAddProductName.SelectedText = "";
            this.TBAddProductName.SelectionLength = 0;
            this.TBAddProductName.SelectionStart = 0;
            this.TBAddProductName.ShortcutsEnabled = true;
            this.TBAddProductName.Size = new System.Drawing.Size(250, 48);
            this.TBAddProductName.TabIndex = 41;
            this.TBAddProductName.TabStop = false;
            this.TBAddProductName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TBAddProductName.TrailingIcon = null;
            this.TBAddProductName.UseAccent = false;
            this.TBAddProductName.UseSystemPasswordChar = false;
            // 
            // TBAddProductDescription
            // 
            this.TBAddProductDescription.AnimateReadOnly = false;
            this.TBAddProductDescription.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TBAddProductDescription.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TBAddProductDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TBAddProductDescription.Depth = 0;
            this.TBAddProductDescription.HideSelection = true;
            this.TBAddProductDescription.Hint = "Description";
            this.TBAddProductDescription.Location = new System.Drawing.Point(350, 178);
            this.TBAddProductDescription.MaxLength = 32767;
            this.TBAddProductDescription.MouseState = MaterialSkin.MouseState.OUT;
            this.TBAddProductDescription.Name = "TBAddProductDescription";
            this.TBAddProductDescription.PasswordChar = '\0';
            this.TBAddProductDescription.ReadOnly = false;
            this.TBAddProductDescription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TBAddProductDescription.SelectedText = "";
            this.TBAddProductDescription.SelectionLength = 0;
            this.TBAddProductDescription.SelectionStart = 0;
            this.TBAddProductDescription.ShortcutsEnabled = true;
            this.TBAddProductDescription.Size = new System.Drawing.Size(524, 111);
            this.TBAddProductDescription.TabIndex = 40;
            this.TBAddProductDescription.TabStop = false;
            this.TBAddProductDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TBAddProductDescription.UseAccent = false;
            this.TBAddProductDescription.UseSystemPasswordChar = false;
            // 
            // TBAddProductStocks
            // 
            this.TBAddProductStocks.AnimateReadOnly = false;
            this.TBAddProductStocks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TBAddProductStocks.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TBAddProductStocks.Depth = 0;
            this.TBAddProductStocks.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TBAddProductStocks.HideSelection = true;
            this.TBAddProductStocks.Hint = "Stocks";
            this.TBAddProductStocks.LeadingIcon = null;
            this.TBAddProductStocks.Location = new System.Drawing.Point(77, 240);
            this.TBAddProductStocks.MaxLength = 32767;
            this.TBAddProductStocks.MouseState = MaterialSkin.MouseState.OUT;
            this.TBAddProductStocks.Name = "TBAddProductStocks";
            this.TBAddProductStocks.PasswordChar = '\0';
            this.TBAddProductStocks.PrefixSuffixText = null;
            this.TBAddProductStocks.ReadOnly = false;
            this.TBAddProductStocks.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TBAddProductStocks.SelectedText = "";
            this.TBAddProductStocks.SelectionLength = 0;
            this.TBAddProductStocks.SelectionStart = 0;
            this.TBAddProductStocks.ShortcutsEnabled = true;
            this.TBAddProductStocks.Size = new System.Drawing.Size(250, 48);
            this.TBAddProductStocks.TabIndex = 39;
            this.TBAddProductStocks.TabStop = false;
            this.TBAddProductStocks.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TBAddProductStocks.TrailingIcon = null;
            this.TBAddProductStocks.UseAccent = false;
            this.TBAddProductStocks.UseSystemPasswordChar = false;
            // 
            // TBAddProductPrice
            // 
            this.TBAddProductPrice.AnimateReadOnly = false;
            this.TBAddProductPrice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TBAddProductPrice.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TBAddProductPrice.Depth = 0;
            this.TBAddProductPrice.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TBAddProductPrice.HideSelection = true;
            this.TBAddProductPrice.Hint = "Price";
            this.TBAddProductPrice.LeadingIcon = null;
            this.TBAddProductPrice.Location = new System.Drawing.Point(77, 177);
            this.TBAddProductPrice.MaxLength = 32767;
            this.TBAddProductPrice.MouseState = MaterialSkin.MouseState.OUT;
            this.TBAddProductPrice.Name = "TBAddProductPrice";
            this.TBAddProductPrice.PasswordChar = '\0';
            this.TBAddProductPrice.PrefixSuffixText = null;
            this.TBAddProductPrice.ReadOnly = false;
            this.TBAddProductPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TBAddProductPrice.SelectedText = "";
            this.TBAddProductPrice.SelectionLength = 0;
            this.TBAddProductPrice.SelectionStart = 0;
            this.TBAddProductPrice.ShortcutsEnabled = true;
            this.TBAddProductPrice.Size = new System.Drawing.Size(250, 48);
            this.TBAddProductPrice.TabIndex = 38;
            this.TBAddProductPrice.TabStop = false;
            this.TBAddProductPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TBAddProductPrice.TrailingIcon = null;
            this.TBAddProductPrice.UseAccent = false;
            this.TBAddProductPrice.UseSystemPasswordChar = false;
            // 
            // TBAddProductCategory
            // 
            this.TBAddProductCategory.AutoResize = false;
            this.TBAddProductCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TBAddProductCategory.Depth = 0;
            this.TBAddProductCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.TBAddProductCategory.DropDownHeight = 174;
            this.TBAddProductCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TBAddProductCategory.DropDownWidth = 121;
            this.TBAddProductCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.TBAddProductCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TBAddProductCategory.FormattingEnabled = true;
            this.TBAddProductCategory.IntegralHeight = false;
            this.TBAddProductCategory.ItemHeight = 43;
            this.TBAddProductCategory.Items.AddRange(new object[] {
            "Dish",
            "Drinks",
            "Dessert",
            "Fast Food"});
            this.TBAddProductCategory.Location = new System.Drawing.Point(350, 112);
            this.TBAddProductCategory.MaxDropDownItems = 4;
            this.TBAddProductCategory.MouseState = MaterialSkin.MouseState.OUT;
            this.TBAddProductCategory.Name = "TBAddProductCategory";
            this.TBAddProductCategory.Size = new System.Drawing.Size(250, 49);
            this.TBAddProductCategory.StartIndex = 1;
            this.TBAddProductCategory.TabIndex = 37;
            this.TBAddProductCategory.UseAccent = false;
            // 
            // TBAddProductQualification
            // 
            this.TBAddProductQualification.AutoResize = false;
            this.TBAddProductQualification.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TBAddProductQualification.Depth = 0;
            this.TBAddProductQualification.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.TBAddProductQualification.DropDownHeight = 174;
            this.TBAddProductQualification.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TBAddProductQualification.DropDownWidth = 121;
            this.TBAddProductQualification.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.TBAddProductQualification.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TBAddProductQualification.FormattingEnabled = true;
            this.TBAddProductQualification.IntegralHeight = false;
            this.TBAddProductQualification.ItemHeight = 43;
            this.TBAddProductQualification.Items.AddRange(new object[] {
            "Default",
            "Special"});
            this.TBAddProductQualification.Location = new System.Drawing.Point(624, 112);
            this.TBAddProductQualification.MaxDropDownItems = 4;
            this.TBAddProductQualification.MouseState = MaterialSkin.MouseState.OUT;
            this.TBAddProductQualification.Name = "TBAddProductQualification";
            this.TBAddProductQualification.Size = new System.Drawing.Size(250, 49);
            this.TBAddProductQualification.StartIndex = 1;
            this.TBAddProductQualification.TabIndex = 36;
            this.TBAddProductQualification.UseAccent = false;
            // 
            // PaginationPanel
            // 
            this.PaginationPanel.Controls.Add(this.PageNumber);
            this.PaginationPanel.Controls.Add(this.nextButton);
            this.PaginationPanel.Controls.Add(this.previousButton);
            this.PaginationPanel.Location = new System.Drawing.Point(364, 768);
            this.PaginationPanel.Name = "PaginationPanel";
            this.PaginationPanel.Size = new System.Drawing.Size(505, 47);
            this.PaginationPanel.TabIndex = 1;
            // 
            // PageNumber
            // 
            this.PageNumber.Depth = 0;
            this.PageNumber.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.PageNumber.Location = new System.Drawing.Point(194, -671);
            this.PageNumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.PageNumber.Name = "PageNumber";
            this.PageNumber.Size = new System.Drawing.Size(100, 36);
            this.PageNumber.TabIndex = 3;
            this.PageNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nextButton
            // 
            this.nextButton.AutoSize = false;
            this.nextButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.nextButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.nextButton.Depth = 0;
            this.nextButton.HighEmphasis = true;
            this.nextButton.Icon = null;
            this.nextButton.Location = new System.Drawing.Point(320, 6);
            this.nextButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.nextButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.nextButton.Name = "nextButton";
            this.nextButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.nextButton.Size = new System.Drawing.Size(158, 36);
            this.nextButton.TabIndex = 2;
            this.nextButton.Text = "Next";
            this.nextButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.nextButton.UseAccentColor = false;
            this.nextButton.UseVisualStyleBackColor = true;
            // 
            // previousButton
            // 
            this.previousButton.AutoSize = false;
            this.previousButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.previousButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.previousButton.Depth = 0;
            this.previousButton.HighEmphasis = true;
            this.previousButton.Icon = null;
            this.previousButton.Location = new System.Drawing.Point(16, 6);
            this.previousButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.previousButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.previousButton.Name = "previousButton";
            this.previousButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.previousButton.Size = new System.Drawing.Size(153, 36);
            this.previousButton.TabIndex = 0;
            this.previousButton.Text = "Previous";
            this.previousButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.previousButton.UseAccentColor = false;
            this.previousButton.UseVisualStyleBackColor = true;
            // 
            // ProductsFlowLayoutPanel
            // 
            this.ProductsFlowLayoutPanel.Location = new System.Drawing.Point(76, 382);
            this.ProductsFlowLayoutPanel.Name = "ProductsFlowLayoutPanel";
            this.ProductsFlowLayoutPanel.Size = new System.Drawing.Size(1073, 364);
            this.ProductsFlowLayoutPanel.TabIndex = 0;
            this.ProductsFlowLayoutPanel.WrapContents = false;
            // 
            // Menus
            // 
            this.Menus.BackColor = System.Drawing.Color.White;
            this.Menus.Controls.Add(this.materialCard8);
            this.Menus.Controls.Add(this.materialCard4);
            this.Menus.Controls.Add(this.materialCard3);
            this.Menus.ImageKey = "icons8-menu-50.png";
            this.Menus.Location = new System.Drawing.Point(4, 23);
            this.Menus.Name = "Menus";
            this.Menus.Size = new System.Drawing.Size(1250, 587);
            this.Menus.TabIndex = 2;
            this.Menus.Text = "Menus";
            // 
            // materialCard8
            // 
            this.materialCard8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.materialCard8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard8.Controls.Add(this.ViewMenuListComboBox);
            this.materialCard8.Controls.Add(this.CustomRadioButton);
            this.materialCard8.Controls.Add(this.TomorrowsMenuRadioButton);
            this.materialCard8.Controls.Add(this.TodaysMenuRadioButton);
            this.materialCard8.Controls.Add(this.MenuCustomDateText);
            this.materialCard8.Controls.Add(this.MenuTomorrowsDateText);
            this.materialCard8.Controls.Add(this.MenuTodaysDateText);
            this.materialCard8.Controls.Add(this.label10);
            this.materialCard8.Controls.Add(this.menuStallNameLabel);
            this.materialCard8.Controls.Add(this.label8);
            this.materialCard8.Controls.Add(this.ViewStallProfilePictureBox);
            this.materialCard8.Depth = 0;
            this.materialCard8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard8.Location = new System.Drawing.Point(25, 25);
            this.materialCard8.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard8.Name = "materialCard8";
            this.materialCard8.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard8.Size = new System.Drawing.Size(215, 537);
            this.materialCard8.TabIndex = 4;
            // 
            // ViewMenuListComboBox
            // 
            this.ViewMenuListComboBox.BackColor = System.Drawing.Color.White;
            this.ViewMenuListComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewMenuListComboBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewMenuListComboBox.ForeColor = System.Drawing.Color.SlateGray;
            this.ViewMenuListComboBox.FormattingEnabled = true;
            this.ViewMenuListComboBox.Items.AddRange(new object[] {
            "All Menu",
            "Today",
            "Tomorrow",
            "Custom"});
            this.ViewMenuListComboBox.Location = new System.Drawing.Point(114, 252);
            this.ViewMenuListComboBox.Name = "ViewMenuListComboBox";
            this.ViewMenuListComboBox.Size = new System.Drawing.Size(84, 24);
            this.ViewMenuListComboBox.TabIndex = 24;
            this.ViewMenuListComboBox.Text = "     View";
            this.ViewMenuListComboBox.SelectedIndexChanged += new System.EventHandler(this.ViewMenuListComboBox_SelectedIndexChanged);
            // 
            // CustomRadioButton
            // 
            this.CustomRadioButton.AutoSize = true;
            this.CustomRadioButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomRadioButton.ForeColor = System.Drawing.Color.Black;
            this.CustomRadioButton.Location = new System.Drawing.Point(17, 438);
            this.CustomRadioButton.Name = "CustomRadioButton";
            this.CustomRadioButton.Size = new System.Drawing.Size(147, 27);
            this.CustomRadioButton.TabIndex = 23;
            this.CustomRadioButton.TabStop = true;
            this.CustomRadioButton.Text = "Custom Date";
            this.CustomRadioButton.UseVisualStyleBackColor = true;
            this.CustomRadioButton.CheckedChanged += new System.EventHandler(this.CustomRadioButton_CheckedChanged);
            // 
            // TomorrowsMenuRadioButton
            // 
            this.TomorrowsMenuRadioButton.AutoSize = true;
            this.TomorrowsMenuRadioButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TomorrowsMenuRadioButton.ForeColor = System.Drawing.Color.Black;
            this.TomorrowsMenuRadioButton.Location = new System.Drawing.Point(17, 370);
            this.TomorrowsMenuRadioButton.Name = "TomorrowsMenuRadioButton";
            this.TomorrowsMenuRadioButton.Size = new System.Drawing.Size(185, 27);
            this.TomorrowsMenuRadioButton.TabIndex = 22;
            this.TomorrowsMenuRadioButton.TabStop = true;
            this.TomorrowsMenuRadioButton.Text = "Tomorrow\'s Menu";
            this.TomorrowsMenuRadioButton.UseVisualStyleBackColor = true;
            this.TomorrowsMenuRadioButton.CheckedChanged += new System.EventHandler(this.TomorrowsMenuRadioButton_CheckedChanged);
            // 
            // TodaysMenuRadioButton
            // 
            this.TodaysMenuRadioButton.AutoSize = true;
            this.TodaysMenuRadioButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TodaysMenuRadioButton.ForeColor = System.Drawing.Color.Black;
            this.TodaysMenuRadioButton.Location = new System.Drawing.Point(21, 294);
            this.TodaysMenuRadioButton.Name = "TodaysMenuRadioButton";
            this.TodaysMenuRadioButton.Size = new System.Drawing.Size(153, 27);
            this.TodaysMenuRadioButton.TabIndex = 21;
            this.TodaysMenuRadioButton.TabStop = true;
            this.TodaysMenuRadioButton.Text = "Today\'s Menu";
            this.TodaysMenuRadioButton.UseVisualStyleBackColor = true;
            this.TodaysMenuRadioButton.CheckedChanged += new System.EventHandler(this.TodaysMenuRadioButton_CheckedChanged);
            // 
            // MenuCustomDateText
            // 
            this.MenuCustomDateText.CalendarFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuCustomDateText.CalendarForeColor = System.Drawing.Color.DarkOrange;
            this.MenuCustomDateText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuCustomDateText.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.MenuCustomDateText.Location = new System.Drawing.Point(49, 471);
            this.MenuCustomDateText.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.MenuCustomDateText.MinDate = new System.DateTime(2024, 10, 30, 0, 0, 0, 0);
            this.MenuCustomDateText.Name = "MenuCustomDateText";
            this.MenuCustomDateText.Size = new System.Drawing.Size(127, 27);
            this.MenuCustomDateText.TabIndex = 20;
            this.MenuCustomDateText.Value = new System.DateTime(2024, 10, 30, 0, 0, 0, 0);
            // 
            // MenuTomorrowsDateText
            // 
            this.MenuTomorrowsDateText.BackColor = System.Drawing.Color.White;
            this.MenuTomorrowsDateText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuTomorrowsDateText.ForeColor = System.Drawing.Color.RoyalBlue;
            this.MenuTomorrowsDateText.Location = new System.Drawing.Point(17, 400);
            this.MenuTomorrowsDateText.Name = "MenuTomorrowsDateText";
            this.MenuTomorrowsDateText.Size = new System.Drawing.Size(181, 32);
            this.MenuTomorrowsDateText.TabIndex = 18;
            this.MenuTomorrowsDateText.Text = "October 10, 2024";
            this.MenuTomorrowsDateText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MenuTodaysDateText
            // 
            this.MenuTodaysDateText.BackColor = System.Drawing.Color.White;
            this.MenuTodaysDateText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuTodaysDateText.ForeColor = System.Drawing.Color.RoyalBlue;
            this.MenuTodaysDateText.Location = new System.Drawing.Point(17, 324);
            this.MenuTodaysDateText.Name = "MenuTodaysDateText";
            this.MenuTodaysDateText.Size = new System.Drawing.Size(181, 32);
            this.MenuTodaysDateText.TabIndex = 16;
            this.MenuTodaysDateText.Text = "October 9, 2024";
            this.MenuTodaysDateText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(21, 247);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 32);
            this.label10.TabIndex = 14;
            this.label10.Text = "Menu";
            // 
            // menuStallNameLabel
            // 
            this.menuStallNameLabel.BackColor = System.Drawing.Color.White;
            this.menuStallNameLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStallNameLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.menuStallNameLabel.Location = new System.Drawing.Point(17, 64);
            this.menuStallNameLabel.Name = "menuStallNameLabel";
            this.menuStallNameLabel.Size = new System.Drawing.Size(181, 37);
            this.menuStallNameLabel.TabIndex = 13;
            this.menuStallNameLabel.Text = "Stall Name";
            this.menuStallNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(21, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 32);
            this.label8.TabIndex = 13;
            this.label8.Text = "Stall";
            // 
            // materialCard4
            // 
            this.materialCard4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard4.Controls.Add(this.MenuFlowLayout);
            this.materialCard4.Depth = 0;
            this.materialCard4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard4.Location = new System.Drawing.Point(846, 25);
            this.materialCard4.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard4.Name = "materialCard4";
            this.materialCard4.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard4.Size = new System.Drawing.Size(378, 537);
            this.materialCard4.TabIndex = 3;
            // 
            // MenuFlowLayout
            // 
            this.MenuFlowLayout.AutoScroll = true;
            this.MenuFlowLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MenuFlowLayout.Location = new System.Drawing.Point(14, 14);
            this.MenuFlowLayout.Name = "MenuFlowLayout";
            this.MenuFlowLayout.Size = new System.Drawing.Size(350, 509);
            this.MenuFlowLayout.TabIndex = 0;
            // 
            // materialCard3
            // 
            this.materialCard3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.TBMenuItemStocks);
            this.materialCard3.Controls.Add(this.SaveMenuButton);
            this.materialCard3.Controls.Add(this.label7);
            this.materialCard3.Controls.Add(this.TBMenuItemPrice);
            this.materialCard3.Controls.Add(this.label6);
            this.materialCard3.Controls.Add(this.TBMenuItemName);
            this.materialCard3.Controls.Add(this.label5);
            this.materialCard3.Controls.Add(this.BrowseImageMenuItemButton);
            this.materialCard3.Controls.Add(this.label4);
            this.materialCard3.Controls.Add(this.label3);
            this.materialCard3.Controls.Add(this.label2);
            this.materialCard3.Controls.Add(this.MenuPictureBoxItem);
            this.materialCard3.Depth = 0;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(258, 25);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard3.Size = new System.Drawing.Size(571, 537);
            this.materialCard3.TabIndex = 2;
            // 
            // TBMenuItemStocks
            // 
            this.TBMenuItemStocks.AnimateReadOnly = false;
            this.TBMenuItemStocks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TBMenuItemStocks.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TBMenuItemStocks.Depth = 0;
            this.TBMenuItemStocks.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TBMenuItemStocks.HelperText = "20";
            this.TBMenuItemStocks.HideSelection = true;
            this.TBMenuItemStocks.Hint = "20";
            this.TBMenuItemStocks.LeadingIcon = null;
            this.TBMenuItemStocks.Location = new System.Drawing.Point(37, 408);
            this.TBMenuItemStocks.MaxLength = 32767;
            this.TBMenuItemStocks.MouseState = MaterialSkin.MouseState.OUT;
            this.TBMenuItemStocks.Name = "TBMenuItemStocks";
            this.TBMenuItemStocks.PasswordChar = '\0';
            this.TBMenuItemStocks.PrefixSuffixText = null;
            this.TBMenuItemStocks.ReadOnly = false;
            this.TBMenuItemStocks.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TBMenuItemStocks.SelectedText = "";
            this.TBMenuItemStocks.SelectionLength = 0;
            this.TBMenuItemStocks.SelectionStart = 0;
            this.TBMenuItemStocks.ShortcutsEnabled = true;
            this.TBMenuItemStocks.Size = new System.Drawing.Size(482, 36);
            this.TBMenuItemStocks.TabIndex = 16;
            this.TBMenuItemStocks.TabStop = false;
            this.TBMenuItemStocks.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TBMenuItemStocks.TrailingIcon = null;
            this.TBMenuItemStocks.UseSystemPasswordChar = false;
            this.TBMenuItemStocks.UseTallSize = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label7.Location = new System.Drawing.Point(34, 382);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 18);
            this.label7.TabIndex = 10;
            this.label7.Text = "Stocks";
            // 
            // TBMenuItemPrice
            // 
            this.TBMenuItemPrice.AnimateReadOnly = false;
            this.TBMenuItemPrice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TBMenuItemPrice.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TBMenuItemPrice.Depth = 0;
            this.TBMenuItemPrice.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TBMenuItemPrice.HelperText = "10";
            this.TBMenuItemPrice.HideSelection = true;
            this.TBMenuItemPrice.Hint = "25";
            this.TBMenuItemPrice.LeadingIcon = null;
            this.TBMenuItemPrice.Location = new System.Drawing.Point(37, 332);
            this.TBMenuItemPrice.MaxLength = 32767;
            this.TBMenuItemPrice.MouseState = MaterialSkin.MouseState.OUT;
            this.TBMenuItemPrice.Name = "TBMenuItemPrice";
            this.TBMenuItemPrice.PasswordChar = '\0';
            this.TBMenuItemPrice.PrefixSuffixText = null;
            this.TBMenuItemPrice.ReadOnly = false;
            this.TBMenuItemPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TBMenuItemPrice.SelectedText = "";
            this.TBMenuItemPrice.SelectionLength = 0;
            this.TBMenuItemPrice.SelectionStart = 0;
            this.TBMenuItemPrice.ShortcutsEnabled = true;
            this.TBMenuItemPrice.Size = new System.Drawing.Size(482, 36);
            this.TBMenuItemPrice.TabIndex = 9;
            this.TBMenuItemPrice.TabStop = false;
            this.TBMenuItemPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TBMenuItemPrice.TrailingIcon = null;
            this.TBMenuItemPrice.UseSystemPasswordChar = false;
            this.TBMenuItemPrice.UseTallSize = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label6.Location = new System.Drawing.Point(34, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "Price";
            // 
            // TBMenuItemName
            // 
            this.TBMenuItemName.AnimateReadOnly = false;
            this.TBMenuItemName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TBMenuItemName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TBMenuItemName.Depth = 0;
            this.TBMenuItemName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TBMenuItemName.HideSelection = true;
            this.TBMenuItemName.Hint = "Burger";
            this.TBMenuItemName.LeadingIcon = null;
            this.TBMenuItemName.Location = new System.Drawing.Point(37, 256);
            this.TBMenuItemName.MaxLength = 32767;
            this.TBMenuItemName.MouseState = MaterialSkin.MouseState.OUT;
            this.TBMenuItemName.Name = "TBMenuItemName";
            this.TBMenuItemName.PasswordChar = '\0';
            this.TBMenuItemName.PrefixSuffixText = null;
            this.TBMenuItemName.ReadOnly = false;
            this.TBMenuItemName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TBMenuItemName.SelectedText = "";
            this.TBMenuItemName.SelectionLength = 0;
            this.TBMenuItemName.SelectionStart = 0;
            this.TBMenuItemName.ShortcutsEnabled = true;
            this.TBMenuItemName.Size = new System.Drawing.Size(482, 36);
            this.TBMenuItemName.TabIndex = 7;
            this.TBMenuItemName.TabStop = false;
            this.TBMenuItemName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TBMenuItemName.TrailingIcon = null;
            this.TBMenuItemName.UseSystemPasswordChar = false;
            this.TBMenuItemName.UseTallSize = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label5.Location = new System.Drawing.Point(34, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Item Name";
            // 
            // BrowseImageMenuItemButton
            // 
            this.BrowseImageMenuItemButton.AutoSize = false;
            this.BrowseImageMenuItemButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BrowseImageMenuItemButton.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Title;
            this.BrowseImageMenuItemButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BrowseImageMenuItemButton.Depth = 0;
            this.BrowseImageMenuItemButton.HighEmphasis = false;
            this.BrowseImageMenuItemButton.Icon = null;
            this.BrowseImageMenuItemButton.Location = new System.Drawing.Point(77, 132);
            this.BrowseImageMenuItemButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BrowseImageMenuItemButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.BrowseImageMenuItemButton.Name = "BrowseImageMenuItemButton";
            this.BrowseImageMenuItemButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BrowseImageMenuItemButton.Size = new System.Drawing.Size(127, 36);
            this.BrowseImageMenuItemButton.TabIndex = 4;
            this.BrowseImageMenuItemButton.Text = "Upload Image";
            this.BrowseImageMenuItemButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.BrowseImageMenuItemButton.UseAccentColor = false;
            this.BrowseImageMenuItemButton.UseVisualStyleBackColor = true;
            this.BrowseImageMenuItemButton.Click += new System.EventHandler(this.BrowseImageMenuItemButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(34, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Photo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(34, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(490, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Add a new item to your menu. You can also add photo of the item";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Add a menu item";
            // 
            // Transactions
            // 
            this.Transactions.BackColor = System.Drawing.Color.White;
            this.Transactions.Controls.Add(this.label16);
            this.Transactions.Controls.Add(this.SortTodayHistoryLabel);
            this.Transactions.Controls.Add(this.SortAllHistoryLabel);
            this.Transactions.Controls.Add(this.materialCard11);
            this.Transactions.Controls.Add(this.materialCard10);
            this.Transactions.Controls.Add(this.AllLabelHighlighter);
            this.Transactions.Controls.Add(this.TodayLabelHighlighter);
            this.Transactions.Controls.Add(this.WeekLabelHighlighter);
            this.Transactions.ImageKey = "icons8-transaction-30.png";
            this.Transactions.Location = new System.Drawing.Point(4, 23);
            this.Transactions.Name = "Transactions";
            this.Transactions.Size = new System.Drawing.Size(1250, 587);
            this.Transactions.TabIndex = 4;
            this.Transactions.Text = "Transactions";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(188, 75);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(89, 21);
            this.label16.TabIndex = 55;
            this.label16.Text = "Yesterday";
            this.label16.Click += new System.EventHandler(this.SortYesterdayHistoryLabel_Click);
            // 
            // SortTodayHistoryLabel
            // 
            this.SortTodayHistoryLabel.AutoSize = true;
            this.SortTodayHistoryLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SortTodayHistoryLabel.Location = new System.Drawing.Point(109, 74);
            this.SortTodayHistoryLabel.Name = "SortTodayHistoryLabel";
            this.SortTodayHistoryLabel.Size = new System.Drawing.Size(58, 21);
            this.SortTodayHistoryLabel.TabIndex = 54;
            this.SortTodayHistoryLabel.Text = "Today";
            this.SortTodayHistoryLabel.Click += new System.EventHandler(this.SortTodayHistoryLabel_Click);
            // 
            // SortAllHistoryLabel
            // 
            this.SortAllHistoryLabel.AutoSize = true;
            this.SortAllHistoryLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SortAllHistoryLabel.Location = new System.Drawing.Point(47, 74);
            this.SortAllHistoryLabel.Name = "SortAllHistoryLabel";
            this.SortAllHistoryLabel.Size = new System.Drawing.Size(29, 21);
            this.SortAllHistoryLabel.TabIndex = 53;
            this.SortAllHistoryLabel.Text = "All";
            this.SortAllHistoryLabel.Click += new System.EventHandler(this.SortAllHistoryLabel_Click);
            // 
            // materialCard11
            // 
            this.materialCard11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard11.Controls.Add(this.PrintReceiptButton);
            this.materialCard11.Controls.Add(this.ReceiveOrderButton);
            this.materialCard11.Controls.Add(this.orderIDLabel);
            this.materialCard11.Controls.Add(this.overallTotalLabel);
            this.materialCard11.Controls.Add(this.label36);
            this.materialCard11.Controls.Add(this.isPaidLabel);
            this.materialCard11.Controls.Add(this.paymentMethodLabel);
            this.materialCard11.Controls.Add(this.orderTimeLabel);
            this.materialCard11.Controls.Add(this.orderDateLabel);
            this.materialCard11.Controls.Add(this.VerifyButton);
            this.materialCard11.Controls.Add(this.orderStatusLabel);
            this.materialCard11.Controls.Add(this.OrderedProducts);
            this.materialCard11.Controls.Add(this.label31);
            this.materialCard11.Controls.Add(this.orderTypeLabel);
            this.materialCard11.Controls.Add(this.label30);
            this.materialCard11.Controls.Add(this.label29);
            this.materialCard11.Controls.Add(this.customerEmailLabel);
            this.materialCard11.Controls.Add(this.customerUserIDLabel);
            this.materialCard11.Controls.Add(this.customerPicturePcbx);
            this.materialCard11.Controls.Add(this.customerNameLabel);
            this.materialCard11.Controls.Add(this.TransactionListFlowLayoutPanel);
            this.materialCard11.Depth = 0;
            this.materialCard11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard11.Location = new System.Drawing.Point(25, 109);
            this.materialCard11.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard11.Name = "materialCard11";
            this.materialCard11.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard11.Size = new System.Drawing.Size(1200, 468);
            this.materialCard11.TabIndex = 51;
            // 
            // orderIDLabel
            // 
            this.orderIDLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.orderIDLabel.AutoSize = true;
            this.orderIDLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderIDLabel.Location = new System.Drawing.Point(650, 52);
            this.orderIDLabel.Name = "orderIDLabel";
            this.orderIDLabel.Size = new System.Drawing.Size(88, 22);
            this.orderIDLabel.TabIndex = 80;
            this.orderIDLabel.Text = "Order ID";
            this.orderIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // overallTotalLabel
            // 
            this.overallTotalLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.overallTotalLabel.AutoSize = true;
            this.overallTotalLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overallTotalLabel.Location = new System.Drawing.Point(785, 380);
            this.overallTotalLabel.Name = "overallTotalLabel";
            this.overallTotalLabel.Size = new System.Drawing.Size(48, 23);
            this.overallTotalLabel.TabIndex = 79;
            this.overallTotalLabel.Text = "0.00";
            this.overallTotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label36
            // 
            this.label36.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(649, 380);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(130, 22);
            this.label36.TabIndex = 78;
            this.label36.Text = "Overall Total:";
            this.label36.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // isPaidLabel
            // 
            this.isPaidLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.isPaidLabel.AutoSize = true;
            this.isPaidLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isPaidLabel.Location = new System.Drawing.Point(785, 83);
            this.isPaidLabel.Name = "isPaidLabel";
            this.isPaidLabel.Size = new System.Drawing.Size(73, 22);
            this.isPaidLabel.TabIndex = 77;
            this.isPaidLabel.Text = "IsPaid?";
            this.isPaidLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // paymentMethodLabel
            // 
            this.paymentMethodLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.paymentMethodLabel.AutoSize = true;
            this.paymentMethodLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentMethodLabel.Location = new System.Drawing.Point(785, 52);
            this.paymentMethodLabel.Name = "paymentMethodLabel";
            this.paymentMethodLabel.Size = new System.Drawing.Size(171, 22);
            this.paymentMethodLabel.TabIndex = 76;
            this.paymentMethodLabel.Text = "Payment Method";
            this.paymentMethodLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // orderTimeLabel
            // 
            this.orderTimeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.orderTimeLabel.AutoSize = true;
            this.orderTimeLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderTimeLabel.Location = new System.Drawing.Point(992, 52);
            this.orderTimeLabel.Name = "orderTimeLabel";
            this.orderTimeLabel.Size = new System.Drawing.Size(109, 22);
            this.orderTimeLabel.TabIndex = 75;
            this.orderTimeLabel.Text = "Order Time";
            this.orderTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // orderDateLabel
            // 
            this.orderDateLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.orderDateLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderDateLabel.Location = new System.Drawing.Point(903, 83);
            this.orderDateLabel.Name = "orderDateLabel";
            this.orderDateLabel.Size = new System.Drawing.Size(225, 22);
            this.orderDateLabel.TabIndex = 74;
            this.orderDateLabel.Text = "Order Date";
            this.orderDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // orderStatusLabel
            // 
            this.orderStatusLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.orderStatusLabel.AutoSize = true;
            this.orderStatusLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderStatusLabel.Location = new System.Drawing.Point(649, 114);
            this.orderStatusLabel.Name = "orderStatusLabel";
            this.orderStatusLabel.Size = new System.Drawing.Size(124, 22);
            this.orderStatusLabel.TabIndex = 12;
            this.orderStatusLabel.Text = "Order Status";
            this.orderStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OrderedProducts
            // 
            this.OrderedProducts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OrderedProducts.AutoSizeTable = false;
            this.OrderedProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.OrderedProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OrderedProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.OrderedProductsColumnInListView,
            this.QuantityListView,
            this.PriceListView,
            this.TotalPriceListView});
            this.OrderedProducts.Depth = 0;
            this.OrderedProducts.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderedProducts.FullRowSelect = true;
            this.OrderedProducts.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.OrderedProducts.HideSelection = false;
            this.OrderedProducts.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.OrderedProducts.LargeImageList = this.imageList1;
            this.OrderedProducts.Location = new System.Drawing.Point(651, 194);
            this.OrderedProducts.MinimumSize = new System.Drawing.Size(200, 100);
            this.OrderedProducts.MouseLocation = new System.Drawing.Point(-1, -1);
            this.OrderedProducts.MouseState = MaterialSkin.MouseState.OUT;
            this.OrderedProducts.Name = "OrderedProducts";
            this.OrderedProducts.OwnerDraw = true;
            this.OrderedProducts.Size = new System.Drawing.Size(477, 168);
            this.OrderedProducts.TabIndex = 1;
            this.OrderedProducts.UseCompatibleStateImageBehavior = false;
            this.OrderedProducts.View = System.Windows.Forms.View.Details;
            // 
            // OrderedProductsColumnInListView
            // 
            this.OrderedProductsColumnInListView.Text = "Order sumarry";
            this.OrderedProductsColumnInListView.Width = 130;
            // 
            // QuantityListView
            // 
            this.QuantityListView.Text = "QTY";
            this.QuantityListView.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.QuantityListView.Width = 90;
            // 
            // PriceListView
            // 
            this.PriceListView.Text = "Price";
            this.PriceListView.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PriceListView.Width = 100;
            // 
            // TotalPriceListView
            // 
            this.TotalPriceListView.Text = "Total Price";
            this.TotalPriceListView.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TotalPriceListView.Width = 120;
            // 
            // label31
            // 
            this.label31.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(649, 163);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(179, 23);
            this.label31.TabIndex = 11;
            this.label31.Text = "Order Products List";
            this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // orderTypeLabel
            // 
            this.orderTypeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.orderTypeLabel.AutoSize = true;
            this.orderTypeLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderTypeLabel.Location = new System.Drawing.Point(650, 83);
            this.orderTypeLabel.Name = "orderTypeLabel";
            this.orderTypeLabel.Size = new System.Drawing.Size(113, 22);
            this.orderTypeLabel.TabIndex = 10;
            this.orderTypeLabel.Text = "Order Type";
            this.orderTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label30
            // 
            this.label30.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(649, 17);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(136, 23);
            this.label30.TabIndex = 9;
            this.label30.Text = "Order Details";
            this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label29
            // 
            this.label29.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(374, 17);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(221, 23);
            this.label29.TabIndex = 8;
            this.label29.Text = "Customer Information";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // customerEmailLabel
            // 
            this.customerEmailLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customerEmailLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerEmailLabel.Location = new System.Drawing.Point(374, 205);
            this.customerEmailLabel.Name = "customerEmailLabel";
            this.customerEmailLabel.Size = new System.Drawing.Size(258, 22);
            this.customerEmailLabel.TabIndex = 7;
            this.customerEmailLabel.Text = "Email";
            this.customerEmailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // customerUserIDLabel
            // 
            this.customerUserIDLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customerUserIDLabel.AutoSize = true;
            this.customerUserIDLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerUserIDLabel.Location = new System.Drawing.Point(374, 183);
            this.customerUserIDLabel.Name = "customerUserIDLabel";
            this.customerUserIDLabel.Size = new System.Drawing.Size(71, 22);
            this.customerUserIDLabel.TabIndex = 6;
            this.customerUserIDLabel.Text = "User ID";
            this.customerUserIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customerNameLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameLabel.Location = new System.Drawing.Point(374, 161);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(258, 22);
            this.customerNameLabel.TabIndex = 4;
            this.customerNameLabel.Text = "Customer Name";
            this.customerNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TransactionListFlowLayoutPanel
            // 
            this.TransactionListFlowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TransactionListFlowLayoutPanel.AutoScroll = true;
            this.TransactionListFlowLayoutPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.TransactionListFlowLayoutPanel.Location = new System.Drawing.Point(14, 17);
            this.TransactionListFlowLayoutPanel.Name = "TransactionListFlowLayoutPanel";
            this.TransactionListFlowLayoutPanel.Size = new System.Drawing.Size(342, 437);
            this.TransactionListFlowLayoutPanel.TabIndex = 2;
            // 
            // materialCard10
            // 
            this.materialCard10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard10.Controls.Add(this.StallProfilePicturePcbx);
            this.materialCard10.Controls.Add(this.label13);
            this.materialCard10.Depth = 0;
            this.materialCard10.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialCard10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard10.Location = new System.Drawing.Point(0, 0);
            this.materialCard10.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard10.Name = "materialCard10";
            this.materialCard10.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard10.Size = new System.Drawing.Size(1250, 58);
            this.materialCard10.TabIndex = 50;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(17, 14);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(421, 28);
            this.label13.TabIndex = 49;
            this.label13.Text = "Transactions and Order Verification";
            // 
            // AllLabelHighlighter
            // 
            this.AllLabelHighlighter.AutoSize = true;
            this.AllLabelHighlighter.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllLabelHighlighter.ForeColor = System.Drawing.Color.RoyalBlue;
            this.AllLabelHighlighter.Location = new System.Drawing.Point(39, 72);
            this.AllLabelHighlighter.Name = "AllLabelHighlighter";
            this.AllLabelHighlighter.Size = new System.Drawing.Size(48, 27);
            this.AllLabelHighlighter.TabIndex = 53;
            this.AllLabelHighlighter.Text = "___";
            // 
            // TodayLabelHighlighter
            // 
            this.TodayLabelHighlighter.AutoSize = true;
            this.TodayLabelHighlighter.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TodayLabelHighlighter.ForeColor = System.Drawing.Color.RoyalBlue;
            this.TodayLabelHighlighter.Location = new System.Drawing.Point(103, 72);
            this.TodayLabelHighlighter.Name = "TodayLabelHighlighter";
            this.TodayLabelHighlighter.Size = new System.Drawing.Size(72, 27);
            this.TodayLabelHighlighter.TabIndex = 57;
            this.TodayLabelHighlighter.Text = "_____";
            // 
            // WeekLabelHighlighter
            // 
            this.WeekLabelHighlighter.AutoSize = true;
            this.WeekLabelHighlighter.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeekLabelHighlighter.ForeColor = System.Drawing.Color.RoyalBlue;
            this.WeekLabelHighlighter.Location = new System.Drawing.Point(185, 73);
            this.WeekLabelHighlighter.Name = "WeekLabelHighlighter";
            this.WeekLabelHighlighter.Size = new System.Drawing.Size(96, 27);
            this.WeekLabelHighlighter.TabIndex = 58;
            this.WeekLabelHighlighter.Text = "_______";
            // 
            // SalesHistory
            // 
            this.SalesHistory.AutoScroll = true;
            this.SalesHistory.Controls.Add(this.cartesianChart2);
            this.SalesHistory.Controls.Add(this.cartesianChart3);
            this.SalesHistory.Controls.Add(this.cartesianChart1);
            this.SalesHistory.Controls.Add(this.label32);
            this.SalesHistory.Controls.Add(this.label26);
            this.SalesHistory.Controls.Add(this.label24);
            this.SalesHistory.Controls.Add(this.label22);
            this.SalesHistory.Controls.Add(this.label19);
            this.SalesHistory.Controls.Add(this.label14);
            this.SalesHistory.Controls.Add(this.label9);
            this.SalesHistory.Controls.Add(this.borderRadiusPanel11);
            this.SalesHistory.ImageKey = "icons8-sales-50 (2).png";
            this.SalesHistory.Location = new System.Drawing.Point(4, 23);
            this.SalesHistory.Name = "SalesHistory";
            this.SalesHistory.Size = new System.Drawing.Size(1250, 587);
            this.SalesHistory.TabIndex = 5;
            this.SalesHistory.Text = "Sales History";
            this.SalesHistory.UseVisualStyleBackColor = true;
            // 
            // cartesianChart2
            // 
            this.cartesianChart2.Location = new System.Drawing.Point(101, 987);
            this.cartesianChart2.Name = "cartesianChart2";
            this.cartesianChart2.Size = new System.Drawing.Size(1055, 328);
            this.cartesianChart2.TabIndex = 68;
            this.cartesianChart2.Text = "cartesianChart3";
            // 
            // cartesianChart3
            // 
            this.cartesianChart3.Location = new System.Drawing.Point(92, 586);
            this.cartesianChart3.Name = "cartesianChart3";
            this.cartesianChart3.Size = new System.Drawing.Size(1055, 328);
            this.cartesianChart3.TabIndex = 67;
            this.cartesianChart3.Text = "cartesianChart2";
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cartesianChart1.Location = new System.Drawing.Point(296, 671);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(842, 226);
            this.cartesianChart1.TabIndex = 66;
            this.cartesianChart1.Text = "cartesianChart1";
            // 
            // label32
            // 
            this.label32.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(60, 898);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(144, 23);
            this.label32.TabIndex = 65;
            this.label32.Text = "Sales by Week";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(69, 937);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(149, 23);
            this.label26.TabIndex = 63;
            this.label26.Text = "Sales by Month";
            // 
            // label24
            // 
            this.label24.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label24.Location = new System.Drawing.Point(88, 741);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(61, 19);
            this.label24.TabIndex = 59;
            this.label24.Text = "GCash";
            // 
            // label22
            // 
            this.label22.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label22.Location = new System.Drawing.Point(88, 692);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(119, 19);
            this.label22.TabIndex = 57;
            this.label22.Text = "Pay on Pickup";
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(57, 629);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(253, 23);
            this.label19.TabIndex = 56;
            this.label19.Text = "Sales by payment method";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label14.Location = new System.Drawing.Point(58, 441);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(288, 18);
            this.label14.TabIndex = 50;
            this.label14.Text = "How are your sales trending overtime?";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(55, 405);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 36);
            this.label9.TabIndex = 49;
            this.label9.Text = "Sales";
            // 
            // Account
            // 
            this.Account.BackColor = System.Drawing.Color.White;
            this.Account.Controls.Add(this.LogoutButton);
            this.Account.Controls.Add(this.StallProfilePictureBox);
            this.Account.Controls.Add(this.StallNumberLabel);
            this.Account.Controls.Add(this.ConnectGcashAccount);
            this.Account.Controls.Add(this.StallOperationsLabel);
            this.Account.Controls.Add(this.GcashButton);
            this.Account.Controls.Add(this.PayOnPickupButton);
            this.Account.Controls.Add(this.label20);
            this.Account.Controls.Add(this.label17);
            this.Account.Controls.Add(this.materialLabel1);
            this.Account.Controls.Add(this.StallOwnerNameLabel);
            this.Account.Controls.Add(this.materialLabel28);
            this.Account.Controls.Add(this.materialLabel30);
            this.Account.Controls.Add(this.materialLabel31);
            this.Account.Controls.Add(this.StallNumberEditLabel);
            this.Account.Controls.Add(this.materialLabel33);
            this.Account.Controls.Add(this.StallNameEditLabel);
            this.Account.Controls.Add(this.materialLabel35);
            this.Account.Controls.Add(this.OperatingHoursEditLabel);
            this.Account.Controls.Add(this.materialLabel37);
            this.Account.Controls.Add(this.DaysOperationEditLabel);
            this.Account.Controls.Add(this.materialLabel39);
            this.Account.Controls.Add(this.ContactNumberEditLabel);
            this.Account.Controls.Add(this.materialFloatingActionButton6);
            this.Account.Controls.Add(this.materialFloatingActionButton7);
            this.Account.Controls.Add(this.materialFloatingActionButton8);
            this.Account.Controls.Add(this.materialFloatingActionButton9);
            this.Account.Controls.Add(this.materialFloatingActionButton10);
            this.Account.Controls.Add(this.EditStallButton);
            this.Account.Controls.Add(this.EditProfileButton);
            this.Account.Controls.Add(this.SaveStallPhotoButton);
            this.Account.ImageKey = "icons8-account-50.png";
            this.Account.Location = new System.Drawing.Point(4, 23);
            this.Account.Name = "Account";
            this.Account.Size = new System.Drawing.Size(1250, 587);
            this.Account.TabIndex = 3;
            this.Account.Text = "Account";
            // 
            // StallNumberLabel
            // 
            this.StallNumberLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StallNumberLabel.BackColor = System.Drawing.Color.Transparent;
            this.StallNumberLabel.Depth = 0;
            this.StallNumberLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.StallNumberLabel.Location = new System.Drawing.Point(546, 62);
            this.StallNumberLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.StallNumberLabel.Name = "StallNumberLabel";
            this.StallNumberLabel.Size = new System.Drawing.Size(158, 19);
            this.StallNumberLabel.TabIndex = 174;
            this.StallNumberLabel.Text = "Stall Number";
            this.StallNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ConnectGcashAccount
            // 
            this.ConnectGcashAccount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ConnectGcashAccount.AutoSize = true;
            this.ConnectGcashAccount.BackColor = System.Drawing.Color.White;
            this.ConnectGcashAccount.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectGcashAccount.ForeColor = System.Drawing.Color.RoyalBlue;
            this.ConnectGcashAccount.Location = new System.Drawing.Point(1040, 259);
            this.ConnectGcashAccount.Name = "ConnectGcashAccount";
            this.ConnectGcashAccount.Size = new System.Drawing.Size(141, 19);
            this.ConnectGcashAccount.TabIndex = 173;
            this.ConnectGcashAccount.Text = "Connect Account >";
            this.ConnectGcashAccount.Click += new System.EventHandler(this.ConnectGcashAccount_Click);
            // 
            // StallOperationsLabel
            // 
            this.StallOperationsLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StallOperationsLabel.BackColor = System.Drawing.Color.Transparent;
            this.StallOperationsLabel.Depth = 0;
            this.StallOperationsLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.StallOperationsLabel.Location = new System.Drawing.Point(492, 104);
            this.StallOperationsLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.StallOperationsLabel.Name = "StallOperationsLabel";
            this.StallOperationsLabel.Size = new System.Drawing.Size(267, 19);
            this.StallOperationsLabel.TabIndex = 172;
            this.StallOperationsLabel.Text = "Operating Hours:  10:00 AM - 5:00 PM";
            this.StallOperationsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GcashButton
            // 
            this.GcashButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GcashButton.AutoSize = true;
            this.GcashButton.Enabled = false;
            this.GcashButton.Font = new System.Drawing.Font("Roboto", 12F);
            this.GcashButton.Location = new System.Drawing.Point(946, 259);
            this.GcashButton.Name = "GcashButton";
            this.GcashButton.Size = new System.Drawing.Size(73, 23);
            this.GcashButton.TabIndex = 169;
            this.GcashButton.Text = "Gcash";
            this.GcashButton.UseVisualStyleBackColor = true;
            // 
            // PayOnPickupButton
            // 
            this.PayOnPickupButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PayOnPickupButton.AutoSize = true;
            this.PayOnPickupButton.Enabled = false;
            this.PayOnPickupButton.Font = new System.Drawing.Font("Roboto", 12F);
            this.PayOnPickupButton.Location = new System.Drawing.Point(946, 233);
            this.PayOnPickupButton.Name = "PayOnPickupButton";
            this.PayOnPickupButton.Size = new System.Drawing.Size(129, 23);
            this.PayOnPickupButton.TabIndex = 168;
            this.PayOnPickupButton.Text = "Pay on Pickup";
            this.PayOnPickupButton.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            this.label20.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Roboto", 12F);
            this.label20.ForeColor = System.Drawing.Color.Silver;
            this.label20.Location = new System.Drawing.Point(985, 284);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(103, 19);
            this.label20.TabIndex = 166;
            this.label20.Text = "Not Available";
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.White;
            this.label17.Font = new System.Drawing.Font("Roboto", 12F);
            this.label17.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label17.Location = new System.Drawing.Point(1081, 234);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(74, 19);
            this.label17.TabIndex = 163;
            this.label17.Text = "Available";
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel1.Location = new System.Drawing.Point(910, 192);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(165, 24);
            this.materialLabel1.TabIndex = 161;
            this.materialLabel1.Text = "Payment Methods";
            // 
            // StallOwnerNameLabel
            // 
            this.StallOwnerNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StallOwnerNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.StallOwnerNameLabel.Depth = 0;
            this.StallOwnerNameLabel.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.StallOwnerNameLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.StallOwnerNameLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.StallOwnerNameLabel.Location = new System.Drawing.Point(390, 16);
            this.StallOwnerNameLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.StallOwnerNameLabel.Name = "StallOwnerNameLabel";
            this.StallOwnerNameLabel.Size = new System.Drawing.Size(471, 24);
            this.StallOwnerNameLabel.TabIndex = 160;
            this.StallOwnerNameLabel.Text = "Stall Name";
            this.StallOwnerNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.StallOwnerNameLabel.UseAccent = true;
            // 
            // materialLabel28
            // 
            this.materialLabel28.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel28.AutoSize = true;
            this.materialLabel28.Depth = 0;
            this.materialLabel28.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel28.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel28.Location = new System.Drawing.Point(56, 64);
            this.materialLabel28.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel28.Name = "materialLabel28";
            this.materialLabel28.Size = new System.Drawing.Size(150, 24);
            this.materialLabel28.TabIndex = 123;
            this.materialLabel28.Text = "Stall Information";
            // 
            // materialLabel30
            // 
            this.materialLabel30.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel30.AutoSize = true;
            this.materialLabel30.Depth = 0;
            this.materialLabel30.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel30.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.materialLabel30.Location = new System.Drawing.Point(90, 123);
            this.materialLabel30.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel30.Name = "materialLabel30";
            this.materialLabel30.Size = new System.Drawing.Size(93, 19);
            this.materialLabel30.TabIndex = 127;
            this.materialLabel30.Text = "Stall Number";
            this.materialLabel30.UseAccent = true;
            // 
            // materialLabel31
            // 
            this.materialLabel31.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel31.AutoSize = true;
            this.materialLabel31.Depth = 0;
            this.materialLabel31.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel31.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.materialLabel31.HighEmphasis = true;
            this.materialLabel31.Location = new System.Drawing.Point(91, 142);
            this.materialLabel31.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel31.Name = "materialLabel31";
            this.materialLabel31.Size = new System.Drawing.Size(30, 17);
            this.materialLabel31.TabIndex = 143;
            this.materialLabel31.Text = "Stall";
            // 
            // StallNumberEditLabel
            // 
            this.StallNumberEditLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StallNumberEditLabel.AutoSize = true;
            this.StallNumberEditLabel.Depth = 0;
            this.StallNumberEditLabel.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.StallNumberEditLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.StallNumberEditLabel.HighEmphasis = true;
            this.StallNumberEditLabel.Location = new System.Drawing.Point(123, 142);
            this.StallNumberEditLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.StallNumberEditLabel.Name = "StallNumberEditLabel";
            this.StallNumberEditLabel.Size = new System.Drawing.Size(17, 17);
            this.StallNumberEditLabel.TabIndex = 128;
            this.StallNumberEditLabel.Text = "01";
            // 
            // materialLabel33
            // 
            this.materialLabel33.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel33.AutoSize = true;
            this.materialLabel33.Depth = 0;
            this.materialLabel33.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel33.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.materialLabel33.Location = new System.Drawing.Point(90, 201);
            this.materialLabel33.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel33.Name = "materialLabel33";
            this.materialLabel33.Size = new System.Drawing.Size(79, 19);
            this.materialLabel33.TabIndex = 130;
            this.materialLabel33.Text = "Stall Name";
            this.materialLabel33.UseAccent = true;
            // 
            // StallNameEditLabel
            // 
            this.StallNameEditLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StallNameEditLabel.AutoSize = true;
            this.StallNameEditLabel.Depth = 0;
            this.StallNameEditLabel.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.StallNameEditLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.StallNameEditLabel.HighEmphasis = true;
            this.StallNameEditLabel.Location = new System.Drawing.Point(91, 220);
            this.StallNameEditLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.StallNameEditLabel.Name = "StallNameEditLabel";
            this.StallNameEditLabel.Size = new System.Drawing.Size(49, 17);
            this.StallNameEditLabel.TabIndex = 131;
            this.StallNameEditLabel.Text = "Stall 01";
            // 
            // materialLabel35
            // 
            this.materialLabel35.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel35.AutoSize = true;
            this.materialLabel35.Depth = 0;
            this.materialLabel35.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel35.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.materialLabel35.Location = new System.Drawing.Point(90, 279);
            this.materialLabel35.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel35.Name = "materialLabel35";
            this.materialLabel35.Size = new System.Drawing.Size(116, 19);
            this.materialLabel35.TabIndex = 133;
            this.materialLabel35.Text = "Operating Hours";
            this.materialLabel35.UseAccent = true;
            // 
            // OperatingHoursEditLabel
            // 
            this.OperatingHoursEditLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OperatingHoursEditLabel.AutoSize = true;
            this.OperatingHoursEditLabel.Depth = 0;
            this.OperatingHoursEditLabel.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.OperatingHoursEditLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.OperatingHoursEditLabel.HighEmphasis = true;
            this.OperatingHoursEditLabel.Location = new System.Drawing.Point(91, 298);
            this.OperatingHoursEditLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.OperatingHoursEditLabel.Name = "OperatingHoursEditLabel";
            this.OperatingHoursEditLabel.Size = new System.Drawing.Size(124, 17);
            this.OperatingHoursEditLabel.TabIndex = 134;
            this.OperatingHoursEditLabel.Text = "10:00 AM - 5:00 PM";
            // 
            // materialLabel37
            // 
            this.materialLabel37.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel37.AutoSize = true;
            this.materialLabel37.Depth = 0;
            this.materialLabel37.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel37.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.materialLabel37.Location = new System.Drawing.Point(90, 357);
            this.materialLabel37.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel37.Name = "materialLabel37";
            this.materialLabel37.Size = new System.Drawing.Size(129, 19);
            this.materialLabel37.TabIndex = 136;
            this.materialLabel37.Text = "Days of Operation";
            this.materialLabel37.UseAccent = true;
            // 
            // DaysOperationEditLabel
            // 
            this.DaysOperationEditLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DaysOperationEditLabel.AutoSize = true;
            this.DaysOperationEditLabel.Depth = 0;
            this.DaysOperationEditLabel.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.DaysOperationEditLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.DaysOperationEditLabel.HighEmphasis = true;
            this.DaysOperationEditLabel.Location = new System.Drawing.Point(91, 376);
            this.DaysOperationEditLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.DaysOperationEditLabel.Name = "DaysOperationEditLabel";
            this.DaysOperationEditLabel.Size = new System.Drawing.Size(113, 17);
            this.DaysOperationEditLabel.TabIndex = 137;
            this.DaysOperationEditLabel.Text = "Thu, Wed, Fri, Sat,";
            // 
            // materialLabel39
            // 
            this.materialLabel39.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel39.AutoSize = true;
            this.materialLabel39.Depth = 0;
            this.materialLabel39.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel39.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.materialLabel39.Location = new System.Drawing.Point(90, 435);
            this.materialLabel39.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel39.Name = "materialLabel39";
            this.materialLabel39.Size = new System.Drawing.Size(116, 19);
            this.materialLabel39.TabIndex = 139;
            this.materialLabel39.Text = "Contact Number";
            this.materialLabel39.UseAccent = true;
            // 
            // ContactNumberEditLabel
            // 
            this.ContactNumberEditLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ContactNumberEditLabel.AutoSize = true;
            this.ContactNumberEditLabel.Depth = 0;
            this.ContactNumberEditLabel.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ContactNumberEditLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.ContactNumberEditLabel.HighEmphasis = true;
            this.ContactNumberEditLabel.Location = new System.Drawing.Point(91, 454);
            this.ContactNumberEditLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.ContactNumberEditLabel.Name = "ContactNumberEditLabel";
            this.ContactNumberEditLabel.Size = new System.Drawing.Size(89, 17);
            this.ContactNumberEditLabel.TabIndex = 140;
            this.ContactNumberEditLabel.Text = "09123456789";
            // 
            // materialFloatingActionButton6
            // 
            this.materialFloatingActionButton6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialFloatingActionButton6.AnimateShowHideButton = true;
            this.materialFloatingActionButton6.Depth = 0;
            this.materialFloatingActionButton6.Icon = global::CAPSTONE_STOLE_ADMIN.Properties.Resources.icons8_stall_100;
            this.materialFloatingActionButton6.Location = new System.Drawing.Point(28, 114);
            this.materialFloatingActionButton6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFloatingActionButton6.Name = "materialFloatingActionButton6";
            this.materialFloatingActionButton6.Size = new System.Drawing.Size(56, 56);
            this.materialFloatingActionButton6.TabIndex = 126;
            this.materialFloatingActionButton6.Text = "materialFloatingActionButton6";
            this.materialFloatingActionButton6.UseVisualStyleBackColor = true;
            // 
            // materialFloatingActionButton7
            // 
            this.materialFloatingActionButton7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialFloatingActionButton7.Depth = 0;
            this.materialFloatingActionButton7.Icon = global::CAPSTONE_STOLE_ADMIN.Properties.Resources.icons8_newsstand_100;
            this.materialFloatingActionButton7.Location = new System.Drawing.Point(28, 192);
            this.materialFloatingActionButton7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFloatingActionButton7.Name = "materialFloatingActionButton7";
            this.materialFloatingActionButton7.Size = new System.Drawing.Size(56, 56);
            this.materialFloatingActionButton7.TabIndex = 129;
            this.materialFloatingActionButton7.Text = "materialFloatingActionButton7";
            this.materialFloatingActionButton7.UseVisualStyleBackColor = true;
            // 
            // materialFloatingActionButton8
            // 
            this.materialFloatingActionButton8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialFloatingActionButton8.Depth = 0;
            this.materialFloatingActionButton8.Icon = global::CAPSTONE_STOLE_ADMIN.Properties.Resources.icons8_clock_94;
            this.materialFloatingActionButton8.Location = new System.Drawing.Point(28, 270);
            this.materialFloatingActionButton8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFloatingActionButton8.Name = "materialFloatingActionButton8";
            this.materialFloatingActionButton8.Size = new System.Drawing.Size(56, 56);
            this.materialFloatingActionButton8.TabIndex = 132;
            this.materialFloatingActionButton8.Text = "materialFloatingActionButton8";
            this.materialFloatingActionButton8.UseVisualStyleBackColor = true;
            // 
            // materialFloatingActionButton9
            // 
            this.materialFloatingActionButton9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialFloatingActionButton9.Depth = 0;
            this.materialFloatingActionButton9.Icon = global::CAPSTONE_STOLE_ADMIN.Properties.Resources.icons8_calendar_48;
            this.materialFloatingActionButton9.Location = new System.Drawing.Point(28, 348);
            this.materialFloatingActionButton9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFloatingActionButton9.Name = "materialFloatingActionButton9";
            this.materialFloatingActionButton9.Size = new System.Drawing.Size(56, 56);
            this.materialFloatingActionButton9.TabIndex = 135;
            this.materialFloatingActionButton9.Text = "materialFloatingActionButton9";
            this.materialFloatingActionButton9.UseVisualStyleBackColor = true;
            // 
            // materialFloatingActionButton10
            // 
            this.materialFloatingActionButton10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialFloatingActionButton10.Depth = 0;
            this.materialFloatingActionButton10.Icon = global::CAPSTONE_STOLE_ADMIN.Properties.Resources.icons8_telephone_94;
            this.materialFloatingActionButton10.Location = new System.Drawing.Point(28, 426);
            this.materialFloatingActionButton10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFloatingActionButton10.Name = "materialFloatingActionButton10";
            this.materialFloatingActionButton10.Size = new System.Drawing.Size(56, 56);
            this.materialFloatingActionButton10.TabIndex = 138;
            this.materialFloatingActionButton10.Text = "materialFloatingActionButton10";
            this.materialFloatingActionButton10.UseVisualStyleBackColor = true;
            // 
            // AddProductCategory
            // 
            this.AddProductCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddProductCategory.AutoResize = false;
            this.AddProductCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AddProductCategory.Depth = 0;
            this.AddProductCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.AddProductCategory.DropDownHeight = 174;
            this.AddProductCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AddProductCategory.DropDownWidth = 121;
            this.AddProductCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.AddProductCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AddProductCategory.FormattingEnabled = true;
            this.AddProductCategory.IntegralHeight = false;
            this.AddProductCategory.ItemHeight = 43;
            this.AddProductCategory.Items.AddRange(new object[] {
            "Dish",
            "Drinks",
            "Dessert",
            "Fast Food"});
            this.AddProductCategory.Location = new System.Drawing.Point(686, 154);
            this.AddProductCategory.MaxDropDownItems = 4;
            this.AddProductCategory.MouseState = MaterialSkin.MouseState.OUT;
            this.AddProductCategory.Name = "AddProductCategory";
            this.AddProductCategory.Size = new System.Drawing.Size(155, 49);
            this.AddProductCategory.StartIndex = 0;
            this.AddProductCategory.TabIndex = 31;
            // 
            // addProductQualification
            // 
            this.addProductQualification.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addProductQualification.AutoResize = false;
            this.addProductQualification.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.addProductQualification.Depth = 0;
            this.addProductQualification.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.addProductQualification.DropDownHeight = 174;
            this.addProductQualification.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addProductQualification.DropDownWidth = 121;
            this.addProductQualification.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.addProductQualification.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.addProductQualification.FormattingEnabled = true;
            this.addProductQualification.IntegralHeight = false;
            this.addProductQualification.ItemHeight = 43;
            this.addProductQualification.Items.AddRange(new object[] {
            "Default",
            "Special"});
            this.addProductQualification.Location = new System.Drawing.Point(493, 243);
            this.addProductQualification.MaxDropDownItems = 4;
            this.addProductQualification.MouseState = MaterialSkin.MouseState.OUT;
            this.addProductQualification.Name = "addProductQualification";
            this.addProductQualification.Size = new System.Drawing.Size(155, 49);
            this.addProductQualification.StartIndex = 0;
            this.addProductQualification.TabIndex = 30;
            // 
            // Category
            // 
            this.Category.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Category.AutoSize = true;
            this.Category.Depth = 0;
            this.Category.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Category.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.Category.Location = new System.Drawing.Point(740, 132);
            this.Category.MouseState = MaterialSkin.MouseState.HOVER;
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(64, 19);
            this.Category.TabIndex = 29;
            this.Category.Text = "Category";
            // 
            // Qualification
            // 
            this.Qualification.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Qualification.AutoSize = true;
            this.Qualification.Depth = 0;
            this.Qualification.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Qualification.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.Qualification.Location = new System.Drawing.Point(497, 222);
            this.Qualification.MouseState = MaterialSkin.MouseState.HOVER;
            this.Qualification.Name = "Qualification";
            this.Qualification.Size = new System.Drawing.Size(92, 19);
            this.Qualification.TabIndex = 28;
            this.Qualification.Text = "Qualification";
            // 
            // MaterialLabel8
            // 
            this.MaterialLabel8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MaterialLabel8.AutoSize = true;
            this.MaterialLabel8.Depth = 0;
            this.MaterialLabel8.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MaterialLabel8.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.MaterialLabel8.Location = new System.Drawing.Point(302, 222);
            this.MaterialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.MaterialLabel8.Name = "MaterialLabel8";
            this.MaterialLabel8.Size = new System.Drawing.Size(61, 19);
            this.MaterialLabel8.TabIndex = 27;
            this.MaterialLabel8.Text = "Quantity";
            // 
            // addProductQuantity
            // 
            this.addProductQuantity.AllowPromptAsInput = true;
            this.addProductQuantity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addProductQuantity.AnimateReadOnly = false;
            this.addProductQuantity.AsciiOnly = false;
            this.addProductQuantity.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addProductQuantity.BeepOnError = false;
            this.addProductQuantity.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.addProductQuantity.Depth = 0;
            this.addProductQuantity.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.addProductQuantity.HidePromptOnLeave = false;
            this.addProductQuantity.HideSelection = true;
            this.addProductQuantity.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.addProductQuantity.LeadingIcon = null;
            this.addProductQuantity.Location = new System.Drawing.Point(296, 244);
            this.addProductQuantity.Mask = "";
            this.addProductQuantity.MaxLength = 32767;
            this.addProductQuantity.MouseState = MaterialSkin.MouseState.OUT;
            this.addProductQuantity.Name = "addProductQuantity";
            this.addProductQuantity.PasswordChar = '\0';
            this.addProductQuantity.PrefixSuffixText = null;
            this.addProductQuantity.PromptChar = '_';
            this.addProductQuantity.ReadOnly = false;
            this.addProductQuantity.RejectInputOnFirstFailure = false;
            this.addProductQuantity.ResetOnPrompt = true;
            this.addProductQuantity.ResetOnSpace = true;
            this.addProductQuantity.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.addProductQuantity.SelectedText = "";
            this.addProductQuantity.SelectionLength = 0;
            this.addProductQuantity.SelectionStart = 0;
            this.addProductQuantity.ShortcutsEnabled = true;
            this.addProductQuantity.Size = new System.Drawing.Size(154, 48);
            this.addProductQuantity.SkipLiterals = true;
            this.addProductQuantity.TabIndex = 26;
            this.addProductQuantity.TabStop = false;
            this.addProductQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.addProductQuantity.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.addProductQuantity.TrailingIcon = null;
            this.addProductQuantity.UseSystemPasswordChar = false;
            this.addProductQuantity.ValidatingType = null;
            // 
            // MaterialLabel6
            // 
            this.MaterialLabel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MaterialLabel6.AutoSize = true;
            this.MaterialLabel6.Depth = 0;
            this.MaterialLabel6.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MaterialLabel6.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.MaterialLabel6.Location = new System.Drawing.Point(544, 132);
            this.MaterialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.MaterialLabel6.Name = "MaterialLabel6";
            this.MaterialLabel6.Size = new System.Drawing.Size(36, 19);
            this.MaterialLabel6.TabIndex = 25;
            this.MaterialLabel6.Text = "Price";
            // 
            // AddProductPrice
            // 
            this.AddProductPrice.AllowPromptAsInput = true;
            this.AddProductPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddProductPrice.AnimateReadOnly = false;
            this.AddProductPrice.AsciiOnly = false;
            this.AddProductPrice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AddProductPrice.BeepOnError = false;
            this.AddProductPrice.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.AddProductPrice.Depth = 0;
            this.AddProductPrice.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.AddProductPrice.HidePromptOnLeave = false;
            this.AddProductPrice.HideSelection = true;
            this.AddProductPrice.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.AddProductPrice.LeadingIcon = null;
            this.AddProductPrice.Location = new System.Drawing.Point(491, 154);
            this.AddProductPrice.Mask = "";
            this.AddProductPrice.MaxLength = 32767;
            this.AddProductPrice.MouseState = MaterialSkin.MouseState.OUT;
            this.AddProductPrice.Name = "AddProductPrice";
            this.AddProductPrice.PasswordChar = '\0';
            this.AddProductPrice.PrefixSuffixText = null;
            this.AddProductPrice.PromptChar = '_';
            this.AddProductPrice.ReadOnly = false;
            this.AddProductPrice.RejectInputOnFirstFailure = false;
            this.AddProductPrice.ResetOnPrompt = true;
            this.AddProductPrice.ResetOnSpace = true;
            this.AddProductPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AddProductPrice.SelectedText = "";
            this.AddProductPrice.SelectionLength = 0;
            this.AddProductPrice.SelectionStart = 0;
            this.AddProductPrice.ShortcutsEnabled = true;
            this.AddProductPrice.Size = new System.Drawing.Size(154, 48);
            this.AddProductPrice.SkipLiterals = true;
            this.AddProductPrice.TabIndex = 24;
            this.AddProductPrice.TabStop = false;
            this.AddProductPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.AddProductPrice.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.AddProductPrice.TrailingIcon = null;
            this.AddProductPrice.UseSystemPasswordChar = false;
            this.AddProductPrice.ValidatingType = null;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Time";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Orders";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dataGridViewTextBoxColumn2.Width = 220;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.FillWeight = 80F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Type";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Date";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dataGridViewTextBoxColumn4.Width = 130;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Status";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dataGridViewTextBoxColumn5.Width = 120;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Paid";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dataGridViewTextBoxColumn6.Width = 80;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "TotalPrice";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Payment Method";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dataGridViewTextBoxColumn8.Width = 170;
            // 
            // borderRadiusPanel9
            // 
            this.borderRadiusPanel9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.borderRadiusPanel9.BackColor = System.Drawing.Color.Goldenrod;
            this.borderRadiusPanel9.BorderColor = System.Drawing.Color.White;
            this.borderRadiusPanel9.BorderRadius = 10;
            this.borderRadiusPanel9.BorderSize = 4;
            this.borderRadiusPanel9.Controls.Add(this.TotalSalesLabel);
            this.borderRadiusPanel9.Controls.Add(this.label27);
            this.borderRadiusPanel9.Controls.Add(this.borderRadiusPanel10);
            this.borderRadiusPanel9.Location = new System.Drawing.Point(981, 17);
            this.borderRadiusPanel9.Name = "borderRadiusPanel9";
            this.borderRadiusPanel9.Size = new System.Drawing.Size(229, 78);
            this.borderRadiusPanel9.TabIndex = 23;
            // 
            // TotalSalesLabel
            // 
            this.TotalSalesLabel.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalSalesLabel.ForeColor = System.Drawing.Color.Navy;
            this.TotalSalesLabel.Location = new System.Drawing.Point(74, 39);
            this.TotalSalesLabel.Name = "TotalSalesLabel";
            this.TotalSalesLabel.Size = new System.Drawing.Size(123, 19);
            this.TotalSalesLabel.TabIndex = 22;
            this.TotalSalesLabel.Text = "0";
            this.TotalSalesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.White;
            this.label27.Location = new System.Drawing.Point(108, 11);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(52, 19);
            this.label27.TabIndex = 21;
            this.label27.Text = "Sales";
            // 
            // borderRadiusPanel10
            // 
            this.borderRadiusPanel10.BackColor = System.Drawing.Color.WhiteSmoke;
            this.borderRadiusPanel10.BorderColor = System.Drawing.Color.Goldenrod;
            this.borderRadiusPanel10.BorderRadius = 30;
            this.borderRadiusPanel10.BorderSize = 17;
            this.borderRadiusPanel10.Controls.Add(this.pictureBox6);
            this.borderRadiusPanel10.Location = new System.Drawing.Point(3, 8);
            this.borderRadiusPanel10.Name = "borderRadiusPanel10";
            this.borderRadiusPanel10.Size = new System.Drawing.Size(65, 63);
            this.borderRadiusPanel10.TabIndex = 20;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(14, 14);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(37, 37);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 0;
            this.pictureBox6.TabStop = false;
            // 
            // borderRadiusPanel7
            // 
            this.borderRadiusPanel7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.borderRadiusPanel7.BackColor = System.Drawing.Color.Tomato;
            this.borderRadiusPanel7.BorderColor = System.Drawing.Color.White;
            this.borderRadiusPanel7.BorderRadius = 10;
            this.borderRadiusPanel7.BorderSize = 4;
            this.borderRadiusPanel7.Controls.Add(this.TotalDeclinedOrdersLabel);
            this.borderRadiusPanel7.Controls.Add(this.label25);
            this.borderRadiusPanel7.Controls.Add(this.borderRadiusPanel8);
            this.borderRadiusPanel7.Location = new System.Drawing.Point(746, 17);
            this.borderRadiusPanel7.Name = "borderRadiusPanel7";
            this.borderRadiusPanel7.Size = new System.Drawing.Size(229, 78);
            this.borderRadiusPanel7.TabIndex = 23;
            // 
            // TotalDeclinedOrdersLabel
            // 
            this.TotalDeclinedOrdersLabel.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalDeclinedOrdersLabel.ForeColor = System.Drawing.Color.Navy;
            this.TotalDeclinedOrdersLabel.Location = new System.Drawing.Point(69, 40);
            this.TotalDeclinedOrdersLabel.Name = "TotalDeclinedOrdersLabel";
            this.TotalDeclinedOrdersLabel.Size = new System.Drawing.Size(150, 19);
            this.TotalDeclinedOrdersLabel.TabIndex = 22;
            this.TotalDeclinedOrdersLabel.Text = "0";
            this.TotalDeclinedOrdersLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.White;
            this.label25.Location = new System.Drawing.Point(65, 11);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(142, 19);
            this.label25.TabIndex = 21;
            this.label25.Text = "Declined Orders";
            // 
            // borderRadiusPanel8
            // 
            this.borderRadiusPanel8.BackColor = System.Drawing.Color.Plum;
            this.borderRadiusPanel8.BorderColor = System.Drawing.Color.Tomato;
            this.borderRadiusPanel8.BorderRadius = 30;
            this.borderRadiusPanel8.BorderSize = 17;
            this.borderRadiusPanel8.Controls.Add(this.pictureBox5);
            this.borderRadiusPanel8.Location = new System.Drawing.Point(3, 8);
            this.borderRadiusPanel8.Name = "borderRadiusPanel8";
            this.borderRadiusPanel8.Size = new System.Drawing.Size(65, 63);
            this.borderRadiusPanel8.TabIndex = 20;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(14, 14);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(37, 37);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            // 
            // borderRadiusPanel5
            // 
            this.borderRadiusPanel5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.borderRadiusPanel5.BackColor = System.Drawing.Color.SteelBlue;
            this.borderRadiusPanel5.BorderColor = System.Drawing.Color.White;
            this.borderRadiusPanel5.BorderRadius = 10;
            this.borderRadiusPanel5.BorderSize = 4;
            this.borderRadiusPanel5.Controls.Add(this.TotalTransactionsLabel);
            this.borderRadiusPanel5.Controls.Add(this.label23);
            this.borderRadiusPanel5.Controls.Add(this.borderRadiusPanel6);
            this.borderRadiusPanel5.Location = new System.Drawing.Point(511, 17);
            this.borderRadiusPanel5.Name = "borderRadiusPanel5";
            this.borderRadiusPanel5.Size = new System.Drawing.Size(229, 78);
            this.borderRadiusPanel5.TabIndex = 24;
            // 
            // TotalTransactionsLabel
            // 
            this.TotalTransactionsLabel.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalTransactionsLabel.ForeColor = System.Drawing.Color.Navy;
            this.TotalTransactionsLabel.Location = new System.Drawing.Point(88, 40);
            this.TotalTransactionsLabel.Name = "TotalTransactionsLabel";
            this.TotalTransactionsLabel.Size = new System.Drawing.Size(105, 21);
            this.TotalTransactionsLabel.TabIndex = 22;
            this.TotalTransactionsLabel.Text = "0";
            this.TotalTransactionsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.SteelBlue;
            this.label23.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(84, 11);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(109, 19);
            this.label23.TabIndex = 21;
            this.label23.Text = "Transactions";
            // 
            // borderRadiusPanel6
            // 
            this.borderRadiusPanel6.BackColor = System.Drawing.Color.Khaki;
            this.borderRadiusPanel6.BorderColor = System.Drawing.Color.SteelBlue;
            this.borderRadiusPanel6.BorderRadius = 30;
            this.borderRadiusPanel6.BorderSize = 17;
            this.borderRadiusPanel6.Controls.Add(this.pictureBox4);
            this.borderRadiusPanel6.Location = new System.Drawing.Point(3, 8);
            this.borderRadiusPanel6.Name = "borderRadiusPanel6";
            this.borderRadiusPanel6.Size = new System.Drawing.Size(65, 63);
            this.borderRadiusPanel6.TabIndex = 20;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(14, 14);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(37, 37);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // borderRadiusPanel3
            // 
            this.borderRadiusPanel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.borderRadiusPanel3.BackColor = System.Drawing.Color.ForestGreen;
            this.borderRadiusPanel3.BorderColor = System.Drawing.Color.White;
            this.borderRadiusPanel3.BorderRadius = 10;
            this.borderRadiusPanel3.BorderSize = 4;
            this.borderRadiusPanel3.Controls.Add(this.ProductCountLabel);
            this.borderRadiusPanel3.Controls.Add(this.label21);
            this.borderRadiusPanel3.Controls.Add(this.borderRadiusPanel4);
            this.borderRadiusPanel3.Location = new System.Drawing.Point(276, 17);
            this.borderRadiusPanel3.Name = "borderRadiusPanel3";
            this.borderRadiusPanel3.Size = new System.Drawing.Size(229, 78);
            this.borderRadiusPanel3.TabIndex = 23;
            // 
            // ProductCountLabel
            // 
            this.ProductCountLabel.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductCountLabel.ForeColor = System.Drawing.Color.Navy;
            this.ProductCountLabel.Location = new System.Drawing.Point(99, 40);
            this.ProductCountLabel.Name = "ProductCountLabel";
            this.ProductCountLabel.Size = new System.Drawing.Size(75, 21);
            this.ProductCountLabel.TabIndex = 22;
            this.ProductCountLabel.Text = "0";
            this.ProductCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.ForestGreen;
            this.label21.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(95, 11);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(79, 19);
            this.label21.TabIndex = 21;
            this.label21.Text = "Products";
            // 
            // borderRadiusPanel4
            // 
            this.borderRadiusPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.borderRadiusPanel4.BorderColor = System.Drawing.Color.ForestGreen;
            this.borderRadiusPanel4.BorderRadius = 30;
            this.borderRadiusPanel4.BorderSize = 17;
            this.borderRadiusPanel4.Controls.Add(this.pictureBox3);
            this.borderRadiusPanel4.Location = new System.Drawing.Point(3, 8);
            this.borderRadiusPanel4.Name = "borderRadiusPanel4";
            this.borderRadiusPanel4.Size = new System.Drawing.Size(65, 63);
            this.borderRadiusPanel4.TabIndex = 20;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(14, 13);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(37, 37);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // borderRadiusPanel1
            // 
            this.borderRadiusPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.borderRadiusPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.borderRadiusPanel1.BorderColor = System.Drawing.Color.White;
            this.borderRadiusPanel1.BorderRadius = 10;
            this.borderRadiusPanel1.BorderSize = 4;
            this.borderRadiusPanel1.Controls.Add(this.TotalOrdersLabel);
            this.borderRadiusPanel1.Controls.Add(this.label18);
            this.borderRadiusPanel1.Controls.Add(this.borderRadiusPanel2);
            this.borderRadiusPanel1.Location = new System.Drawing.Point(41, 17);
            this.borderRadiusPanel1.Name = "borderRadiusPanel1";
            this.borderRadiusPanel1.Size = new System.Drawing.Size(229, 78);
            this.borderRadiusPanel1.TabIndex = 19;
            // 
            // TotalOrdersLabel
            // 
            this.TotalOrdersLabel.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalOrdersLabel.ForeColor = System.Drawing.Color.Navy;
            this.TotalOrdersLabel.Location = new System.Drawing.Point(84, 40);
            this.TotalOrdersLabel.Name = "TotalOrdersLabel";
            this.TotalOrdersLabel.Size = new System.Drawing.Size(106, 19);
            this.TotalOrdersLabel.TabIndex = 22;
            this.TotalOrdersLabel.Text = "0";
            this.TotalOrdersLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(84, 11);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(106, 19);
            this.label18.TabIndex = 21;
            this.label18.Text = "New Orders";
            // 
            // borderRadiusPanel2
            // 
            this.borderRadiusPanel2.BackColor = System.Drawing.Color.Navy;
            this.borderRadiusPanel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.borderRadiusPanel2.BorderRadius = 30;
            this.borderRadiusPanel2.BorderSize = 17;
            this.borderRadiusPanel2.Controls.Add(this.pictureBox2);
            this.borderRadiusPanel2.Location = new System.Drawing.Point(3, 8);
            this.borderRadiusPanel2.Name = "borderRadiusPanel2";
            this.borderRadiusPanel2.Size = new System.Drawing.Size(65, 63);
            this.borderRadiusPanel2.TabIndex = 20;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(14, 14);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // Time
            // 
            this.Time.HeaderText = "Time";
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            this.Time.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // Orders
            // 
            this.Orders.HeaderText = "Orders";
            this.Orders.Name = "Orders";
            this.Orders.ReadOnly = true;
            this.Orders.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Orders.Width = 220;
            // 
            // Type
            // 
            this.Type.FillWeight = 80F;
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Date.Width = 150;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // Paid
            // 
            this.Paid.HeaderText = "Payment Status";
            this.Paid.Name = "Paid";
            this.Paid.ReadOnly = true;
            this.Paid.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Paid.Width = 80;
            // 
            // TotalPrice
            // 
            this.TotalPrice.HeaderText = "TotalPrice";
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.ReadOnly = true;
            this.TotalPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // PaymentMethod
            // 
            this.PaymentMethod.HeaderText = "Payment Method";
            this.PaymentMethod.Name = "PaymentMethod";
            this.PaymentMethod.ReadOnly = true;
            this.PaymentMethod.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.PaymentMethod.Width = 170;
            // 
            // ViewOrderButton
            // 
            this.ViewOrderButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ViewOrderButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.ViewOrderButton.FlatAppearance.BorderSize = 0;
            this.ViewOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewOrderButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewOrderButton.ForeColor = System.Drawing.Color.White;
            this.ViewOrderButton.Image = ((System.Drawing.Image)(resources.GetObject("ViewOrderButton.Image")));
            this.ViewOrderButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ViewOrderButton.Location = new System.Drawing.Point(9, 79);
            this.ViewOrderButton.Name = "ViewOrderButton";
            this.ViewOrderButton.Padding = new System.Windows.Forms.Padding(4);
            this.ViewOrderButton.Size = new System.Drawing.Size(117, 41);
            this.ViewOrderButton.TabIndex = 70;
            this.ViewOrderButton.Text = "  View";
            this.ViewOrderButton.UseVisualStyleBackColor = false;
            this.ViewOrderButton.Click += new System.EventHandler(this.ViewOrderButton_Click);
            // 
            // AcceptOrderButton
            // 
            this.AcceptOrderButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AcceptOrderButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.AcceptOrderButton.FlatAppearance.BorderSize = 0;
            this.AcceptOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AcceptOrderButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AcceptOrderButton.ForeColor = System.Drawing.Color.White;
            this.AcceptOrderButton.Image = ((System.Drawing.Image)(resources.GetObject("AcceptOrderButton.Image")));
            this.AcceptOrderButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AcceptOrderButton.Location = new System.Drawing.Point(9, 189);
            this.AcceptOrderButton.Name = "AcceptOrderButton";
            this.AcceptOrderButton.Padding = new System.Windows.Forms.Padding(4);
            this.AcceptOrderButton.Size = new System.Drawing.Size(117, 41);
            this.AcceptOrderButton.TabIndex = 69;
            this.AcceptOrderButton.Text = "     Accept";
            this.AcceptOrderButton.UseVisualStyleBackColor = false;
            this.AcceptOrderButton.Click += new System.EventHandler(this.AcceptOrderButton_Click);
            // 
            // FinishOrderButton
            // 
            this.FinishOrderButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FinishOrderButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.FinishOrderButton.FlatAppearance.BorderSize = 0;
            this.FinishOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FinishOrderButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinishOrderButton.ForeColor = System.Drawing.Color.White;
            this.FinishOrderButton.Image = ((System.Drawing.Image)(resources.GetObject("FinishOrderButton.Image")));
            this.FinishOrderButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FinishOrderButton.Location = new System.Drawing.Point(9, 299);
            this.FinishOrderButton.Name = "FinishOrderButton";
            this.FinishOrderButton.Padding = new System.Windows.Forms.Padding(4);
            this.FinishOrderButton.Size = new System.Drawing.Size(117, 41);
            this.FinishOrderButton.TabIndex = 10;
            this.FinishOrderButton.Text = "  Finish";
            this.FinishOrderButton.UseVisualStyleBackColor = false;
            this.FinishOrderButton.Click += new System.EventHandler(this.FinishOrderButton_Click);
            // 
            // DeclineOrderButton
            // 
            this.DeclineOrderButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DeclineOrderButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.DeclineOrderButton.FlatAppearance.BorderSize = 0;
            this.DeclineOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeclineOrderButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeclineOrderButton.ForeColor = System.Drawing.Color.White;
            this.DeclineOrderButton.Image = ((System.Drawing.Image)(resources.GetObject("DeclineOrderButton.Image")));
            this.DeclineOrderButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeclineOrderButton.Location = new System.Drawing.Point(9, 134);
            this.DeclineOrderButton.Name = "DeclineOrderButton";
            this.DeclineOrderButton.Padding = new System.Windows.Forms.Padding(4);
            this.DeclineOrderButton.Size = new System.Drawing.Size(117, 41);
            this.DeclineOrderButton.TabIndex = 68;
            this.DeclineOrderButton.Text = "     Decline";
            this.DeclineOrderButton.UseVisualStyleBackColor = false;
            this.DeclineOrderButton.Click += new System.EventHandler(this.DeclineOrderButton_Click);
            // 
            // ReadyOrderButton
            // 
            this.ReadyOrderButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ReadyOrderButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.ReadyOrderButton.FlatAppearance.BorderSize = 0;
            this.ReadyOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReadyOrderButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReadyOrderButton.ForeColor = System.Drawing.Color.White;
            this.ReadyOrderButton.Image = global::CAPSTONE_STOLE_ADMIN.Properties.Resources.icons8_food_served_at_restaurant_in_a_dome_lid_cover_28;
            this.ReadyOrderButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ReadyOrderButton.Location = new System.Drawing.Point(9, 244);
            this.ReadyOrderButton.Name = "ReadyOrderButton";
            this.ReadyOrderButton.Padding = new System.Windows.Forms.Padding(4);
            this.ReadyOrderButton.Size = new System.Drawing.Size(117, 41);
            this.ReadyOrderButton.TabIndex = 15;
            this.ReadyOrderButton.Text = "    Ready";
            this.ReadyOrderButton.UseVisualStyleBackColor = false;
            this.ReadyOrderButton.Click += new System.EventHandler(this.ReadyOrderButton_Click);
            // 
            // AddProductImage
            // 
            this.AddProductImage.BorderColor = System.Drawing.Color.White;
            this.AddProductImage.BorderRadius = 10;
            this.AddProductImage.BorderSize = 4;
            this.AddProductImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddProductImage.Location = new System.Drawing.Point(14, 14);
            this.AddProductImage.Name = "AddProductImage";
            this.AddProductImage.Size = new System.Drawing.Size(220, 147);
            this.AddProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AddProductImage.TabIndex = 0;
            this.AddProductImage.TabStop = false;
            // 
            // AddNewProductButton
            // 
            this.AddNewProductButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.AddNewProductButton.FlatAppearance.BorderSize = 0;
            this.AddNewProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddNewProductButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewProductButton.ForeColor = System.Drawing.Color.White;
            this.AddNewProductButton.Image = global::CAPSTONE_STOLE_ADMIN.Properties.Resources.box__1_;
            this.AddNewProductButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddNewProductButton.Location = new System.Drawing.Point(428, 312);
            this.AddNewProductButton.Name = "AddNewProductButton";
            this.AddNewProductButton.Padding = new System.Windows.Forms.Padding(4);
            this.AddNewProductButton.Size = new System.Drawing.Size(369, 43);
            this.AddNewProductButton.TabIndex = 47;
            this.AddNewProductButton.Text = "ADD PRODUCT";
            this.AddNewProductButton.UseVisualStyleBackColor = false;
            this.AddNewProductButton.Click += new System.EventHandler(this.AddNewProductButton_Click);
            // 
            // ViewStallProfilePictureBox
            // 
            this.ViewStallProfilePictureBox.BorderColor = System.Drawing.Color.White;
            this.ViewStallProfilePictureBox.BorderRadius = 10;
            this.ViewStallProfilePictureBox.BorderSize = 4;
            this.ViewStallProfilePictureBox.Image = global::CAPSTONE_STOLE_ADMIN.Properties.Resources._806ea7d3ec0a77b9412333973ad287d6;
            this.ViewStallProfilePictureBox.Location = new System.Drawing.Point(17, 109);
            this.ViewStallProfilePictureBox.Name = "ViewStallProfilePictureBox";
            this.ViewStallProfilePictureBox.Size = new System.Drawing.Size(181, 119);
            this.ViewStallProfilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ViewStallProfilePictureBox.TabIndex = 18;
            this.ViewStallProfilePictureBox.TabStop = false;
            // 
            // SaveMenuButton
            // 
            this.SaveMenuButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.SaveMenuButton.FlatAppearance.BorderSize = 0;
            this.SaveMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveMenuButton.ForeColor = System.Drawing.Color.White;
            this.SaveMenuButton.Location = new System.Drawing.Point(37, 466);
            this.SaveMenuButton.Name = "SaveMenuButton";
            this.SaveMenuButton.Padding = new System.Windows.Forms.Padding(5);
            this.SaveMenuButton.Size = new System.Drawing.Size(482, 43);
            this.SaveMenuButton.TabIndex = 15;
            this.SaveMenuButton.Text = "SAVE";
            this.SaveMenuButton.UseVisualStyleBackColor = false;
            this.SaveMenuButton.Click += new System.EventHandler(this.SaveMenuButton_Click);
            // 
            // MenuPictureBoxItem
            // 
            this.MenuPictureBoxItem.BorderColor = System.Drawing.Color.White;
            this.MenuPictureBoxItem.BorderRadius = 10;
            this.MenuPictureBoxItem.BorderSize = 4;
            this.MenuPictureBoxItem.Location = new System.Drawing.Point(280, 93);
            this.MenuPictureBoxItem.Name = "MenuPictureBoxItem";
            this.MenuPictureBoxItem.Size = new System.Drawing.Size(214, 135);
            this.MenuPictureBoxItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MenuPictureBoxItem.TabIndex = 17;
            this.MenuPictureBoxItem.TabStop = false;
            // 
            // PrintReceiptButton
            // 
            this.PrintReceiptButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PrintReceiptButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.PrintReceiptButton.FlatAppearance.BorderSize = 0;
            this.PrintReceiptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrintReceiptButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintReceiptButton.ForeColor = System.Drawing.Color.White;
            this.PrintReceiptButton.Image = global::CAPSTONE_STOLE_ADMIN.Properties.Resources.icons8_print_281;
            this.PrintReceiptButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PrintReceiptButton.Location = new System.Drawing.Point(1066, 414);
            this.PrintReceiptButton.Name = "PrintReceiptButton";
            this.PrintReceiptButton.Padding = new System.Windows.Forms.Padding(4);
            this.PrintReceiptButton.Size = new System.Drawing.Size(117, 41);
            this.PrintReceiptButton.TabIndex = 82;
            this.PrintReceiptButton.Text = "  Print";
            this.PrintReceiptButton.UseVisualStyleBackColor = false;
            this.PrintReceiptButton.Click += new System.EventHandler(this.PrintReceiptButton_Click);
            // 
            // ReceiveOrderButton
            // 
            this.ReceiveOrderButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ReceiveOrderButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.ReceiveOrderButton.FlatAppearance.BorderSize = 0;
            this.ReceiveOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReceiveOrderButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReceiveOrderButton.ForeColor = System.Drawing.Color.White;
            this.ReceiveOrderButton.Image = global::CAPSTONE_STOLE_ADMIN.Properties.Resources.icons8_give_28;
            this.ReceiveOrderButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ReceiveOrderButton.Location = new System.Drawing.Point(922, 413);
            this.ReceiveOrderButton.Name = "ReceiveOrderButton";
            this.ReceiveOrderButton.Padding = new System.Windows.Forms.Padding(4);
            this.ReceiveOrderButton.Size = new System.Drawing.Size(138, 41);
            this.ReceiveOrderButton.TabIndex = 81;
            this.ReceiveOrderButton.Text = "      Receive    ";
            this.ReceiveOrderButton.UseVisualStyleBackColor = false;
            this.ReceiveOrderButton.Click += new System.EventHandler(this.ReceiveOrderButton_Click);
            // 
            // VerifyButton
            // 
            this.VerifyButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.VerifyButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.VerifyButton.FlatAppearance.BorderSize = 0;
            this.VerifyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VerifyButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VerifyButton.ForeColor = System.Drawing.Color.White;
            this.VerifyButton.Image = global::CAPSTONE_STOLE_ADMIN.Properties.Resources.icons8_qr_code_28;
            this.VerifyButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.VerifyButton.Location = new System.Drawing.Point(799, 414);
            this.VerifyButton.Name = "VerifyButton";
            this.VerifyButton.Padding = new System.Windows.Forms.Padding(4);
            this.VerifyButton.Size = new System.Drawing.Size(117, 41);
            this.VerifyButton.TabIndex = 73;
            this.VerifyButton.Text = "  Scan";
            this.VerifyButton.UseVisualStyleBackColor = false;
            this.VerifyButton.Click += new System.EventHandler(this.roundedButton1_Click);
            // 
            // customerPicturePcbx
            // 
            this.customerPicturePcbx.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customerPicturePcbx.BorderColor = System.Drawing.Color.White;
            this.customerPicturePcbx.BorderRadius = 10;
            this.customerPicturePcbx.BorderSize = 4;
            this.customerPicturePcbx.Image = global::CAPSTONE_STOLE_ADMIN.Properties.Resources.default_image;
            this.customerPicturePcbx.Location = new System.Drawing.Point(378, 52);
            this.customerPicturePcbx.Name = "customerPicturePcbx";
            this.customerPicturePcbx.Size = new System.Drawing.Size(115, 97);
            this.customerPicturePcbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.customerPicturePcbx.TabIndex = 5;
            this.customerPicturePcbx.TabStop = false;
            // 
            // StallProfilePicturePcbx
            // 
            this.StallProfilePicturePcbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StallProfilePicturePcbx.BorderColor = System.Drawing.Color.White;
            this.StallProfilePicturePcbx.BorderRadius = 10;
            this.StallProfilePicturePcbx.BorderSize = 4;
            this.StallProfilePicturePcbx.Image = ((System.Drawing.Image)(resources.GetObject("StallProfilePicturePcbx.Image")));
            this.StallProfilePicturePcbx.Location = new System.Drawing.Point(1186, 7);
            this.StallProfilePicturePcbx.Name = "StallProfilePicturePcbx";
            this.StallProfilePicturePcbx.Size = new System.Drawing.Size(47, 44);
            this.StallProfilePicturePcbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.StallProfilePicturePcbx.TabIndex = 52;
            this.StallProfilePicturePcbx.TabStop = false;
            // 
            // borderRadiusPanel11
            // 
            this.borderRadiusPanel11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.borderRadiusPanel11.BackColor = System.Drawing.Color.RoyalBlue;
            this.borderRadiusPanel11.BorderColor = System.Drawing.Color.White;
            this.borderRadiusPanel11.BorderRadius = 10;
            this.borderRadiusPanel11.BorderSize = 4;
            this.borderRadiusPanel11.Controls.Add(this.label15);
            this.borderRadiusPanel11.Controls.Add(this.LifeTimeSalesLabel);
            this.borderRadiusPanel11.Location = new System.Drawing.Point(61, 492);
            this.borderRadiusPanel11.Name = "borderRadiusPanel11";
            this.borderRadiusPanel11.Size = new System.Drawing.Size(1077, 100);
            this.borderRadiusPanel11.TabIndex = 55;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(27, 25);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(134, 23);
            this.label15.TabIndex = 52;
            this.label15.Text = "Lifetime Sales";
            // 
            // LifeTimeSalesLabel
            // 
            this.LifeTimeSalesLabel.AutoSize = true;
            this.LifeTimeSalesLabel.BackColor = System.Drawing.Color.Transparent;
            this.LifeTimeSalesLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LifeTimeSalesLabel.ForeColor = System.Drawing.Color.White;
            this.LifeTimeSalesLabel.Location = new System.Drawing.Point(26, 48);
            this.LifeTimeSalesLabel.Name = "LifeTimeSalesLabel";
            this.LifeTimeSalesLabel.Size = new System.Drawing.Size(69, 25);
            this.LifeTimeSalesLabel.TabIndex = 53;
            this.LifeTimeSalesLabel.Text = "₱0.00";
            // 
            // LogoutButton
            // 
            this.LogoutButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LogoutButton.BackColor = System.Drawing.Color.Silver;
            this.LogoutButton.FlatAppearance.BorderSize = 0;
            this.LogoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutButton.ForeColor = System.Drawing.Color.Black;
            this.LogoutButton.Location = new System.Drawing.Point(1125, 532);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Padding = new System.Windows.Forms.Padding(4);
            this.LogoutButton.Size = new System.Drawing.Size(107, 40);
            this.LogoutButton.TabIndex = 176;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = false;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // StallProfilePictureBox
            // 
            this.StallProfilePictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StallProfilePictureBox.BorderColor = System.Drawing.Color.White;
            this.StallProfilePictureBox.BorderRadius = 20;
            this.StallProfilePictureBox.BorderSize = 9;
            this.StallProfilePictureBox.Image = global::CAPSTONE_STOLE_ADMIN.Properties.Resources._806ea7d3ec0a77b9412333973ad287d6;
            this.StallProfilePictureBox.Location = new System.Drawing.Point(422, 142);
            this.StallProfilePictureBox.Name = "StallProfilePictureBox";
            this.StallProfilePictureBox.Size = new System.Drawing.Size(406, 243);
            this.StallProfilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.StallProfilePictureBox.TabIndex = 175;
            this.StallProfilePictureBox.TabStop = false;
            // 
            // EditStallButton
            // 
            this.EditStallButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EditStallButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.EditStallButton.FlatAppearance.BorderSize = 0;
            this.EditStallButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditStallButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditStallButton.ForeColor = System.Drawing.Color.White;
            this.EditStallButton.Location = new System.Drawing.Point(510, 454);
            this.EditStallButton.Name = "EditStallButton";
            this.EditStallButton.Padding = new System.Windows.Forms.Padding(4);
            this.EditStallButton.Size = new System.Drawing.Size(230, 40);
            this.EditStallButton.TabIndex = 148;
            this.EditStallButton.Text = "Edit Stall Data";
            this.EditStallButton.UseVisualStyleBackColor = false;
            this.EditStallButton.Click += new System.EventHandler(this.EditStallButton_Click);
            // 
            // EditProfileButton
            // 
            this.EditProfileButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EditProfileButton.BackColor = System.Drawing.Color.Silver;
            this.EditProfileButton.FlatAppearance.BorderSize = 0;
            this.EditProfileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditProfileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditProfileButton.ForeColor = System.Drawing.Color.Black;
            this.EditProfileButton.Location = new System.Drawing.Point(510, 399);
            this.EditProfileButton.Name = "EditProfileButton";
            this.EditProfileButton.Padding = new System.Windows.Forms.Padding(4);
            this.EditProfileButton.Size = new System.Drawing.Size(112, 40);
            this.EditProfileButton.TabIndex = 147;
            this.EditProfileButton.Text = "Browse";
            this.EditProfileButton.UseVisualStyleBackColor = false;
            this.EditProfileButton.Click += new System.EventHandler(this.EditProfileButton_Click);
            // 
            // SaveStallPhotoButton
            // 
            this.SaveStallPhotoButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SaveStallPhotoButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.SaveStallPhotoButton.FlatAppearance.BorderSize = 0;
            this.SaveStallPhotoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveStallPhotoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveStallPhotoButton.ForeColor = System.Drawing.Color.White;
            this.SaveStallPhotoButton.Location = new System.Drawing.Point(628, 399);
            this.SaveStallPhotoButton.Name = "SaveStallPhotoButton";
            this.SaveStallPhotoButton.Padding = new System.Windows.Forms.Padding(4);
            this.SaveStallPhotoButton.Size = new System.Drawing.Size(112, 40);
            this.SaveStallPhotoButton.TabIndex = 146;
            this.SaveStallPhotoButton.Text = "Save Image";
            this.SaveStallPhotoButton.UseVisualStyleBackColor = false;
            this.SaveStallPhotoButton.Click += new System.EventHandler(this.SaveStallPhotoButton_Click);
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Payment Method";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dataGridViewTextBoxColumn9.Width = 170;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "Time";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dataGridViewTextBoxColumn10.Width = 220;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.FillWeight = 80F;
            this.dataGridViewTextBoxColumn11.HeaderText = "Orders";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dataGridViewTextBoxColumn11.Width = 220;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.FillWeight = 80F;
            this.dataGridViewTextBoxColumn12.HeaderText = "Type";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dataGridViewTextBoxColumn12.Width = 130;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.HeaderText = "Date";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dataGridViewTextBoxColumn13.Width = 130;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.HeaderText = "Status";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dataGridViewTextBoxColumn14.Width = 120;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.HeaderText = "Paid";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dataGridViewTextBoxColumn15.Width = 80;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.HeaderText = "TotalPrice";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            this.dataGridViewTextBoxColumn16.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dataGridViewTextBoxColumn16.Width = 170;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.HeaderText = "Payment Method";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.Width = 170;
            // 
            // Main_DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerTabControl = this.materialTabControl1;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main_DashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stall Management";
            this.materialTabControl1.ResumeLayout(false);
            this.Home.ResumeLayout(false);
            this.Home.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderList)).EndInit();
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.Products.ResumeLayout(false);
            this.Products.PerformLayout();
            this.materialCard2.ResumeLayout(false);
            this.PaginationPanel.ResumeLayout(false);
            this.Menus.ResumeLayout(false);
            this.materialCard8.ResumeLayout(false);
            this.materialCard8.PerformLayout();
            this.materialCard4.ResumeLayout(false);
            this.materialCard3.ResumeLayout(false);
            this.materialCard3.PerformLayout();
            this.Transactions.ResumeLayout(false);
            this.Transactions.PerformLayout();
            this.materialCard11.ResumeLayout(false);
            this.materialCard11.PerformLayout();
            this.materialCard10.ResumeLayout(false);
            this.materialCard10.PerformLayout();
            this.SalesHistory.ResumeLayout(false);
            this.SalesHistory.PerformLayout();
            this.Account.ResumeLayout(false);
            this.Account.PerformLayout();
            this.borderRadiusPanel9.ResumeLayout(false);
            this.borderRadiusPanel9.PerformLayout();
            this.borderRadiusPanel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.borderRadiusPanel7.ResumeLayout(false);
            this.borderRadiusPanel7.PerformLayout();
            this.borderRadiusPanel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.borderRadiusPanel5.ResumeLayout(false);
            this.borderRadiusPanel5.PerformLayout();
            this.borderRadiusPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.borderRadiusPanel3.ResumeLayout(false);
            this.borderRadiusPanel3.PerformLayout();
            this.borderRadiusPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.borderRadiusPanel1.ResumeLayout(false);
            this.borderRadiusPanel1.PerformLayout();
            this.borderRadiusPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddProductImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewStallProfilePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuPictureBoxItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerPicturePcbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StallProfilePicturePcbx)).EndInit();
            this.borderRadiusPanel11.ResumeLayout(false);
            this.borderRadiusPanel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StallProfilePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage Products;
        private System.Windows.Forms.TabPage Menus;
        private System.Windows.Forms.TabPage Account;
        private System.Windows.Forms.TabPage Transactions;
        private System.Windows.Forms.TabPage Home;
        private System.Windows.Forms.DataGridView OrderList;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel ProductsFlowLayoutPanel;
        private System.Windows.Forms.Panel PaginationPanel;
        private MaterialSkin.Controls.MaterialButton previousButton;
        private MaterialSkin.Controls.MaterialButton nextButton;
        private MaterialSkin.Controls.MaterialLabel PageNumber;
        private MaterialSkin.Controls.MaterialComboBox AddProductCategory;
        private MaterialSkin.Controls.MaterialComboBox addProductQualification;
        private MaterialSkin.Controls.MaterialLabel Category;
        private MaterialSkin.Controls.MaterialLabel Qualification;
        private MaterialSkin.Controls.MaterialLabel MaterialLabel8;
        private MaterialSkin.Controls.MaterialMaskedTextBox addProductQuantity;
        private MaterialSkin.Controls.MaterialLabel MaterialLabel6;
        private MaterialSkin.Controls.MaterialMaskedTextBox AddProductPrice;
        private MaterialSkin.Controls.MaterialMaskedTextBox AddProductName;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 TBAddProductDescription;
        private MaterialSkin.Controls.MaterialTextBox2 TBAddProductStocks;
        private MaterialSkin.Controls.MaterialTextBox2 TBAddProductPrice;
        private MaterialSkin.Controls.MaterialComboBox TBAddProductCategory;
        private MaterialSkin.Controls.MaterialComboBox TBAddProductQualification;
        private MaterialSkin.Controls.MaterialTextBox2 TBAddProductName;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialButton BrowseProductPicture;
        private BorderRadiusPictureBox AddProductImage;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private MaterialSkin.Controls.MaterialButton BrowseImageMenuItemButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialTextBox2 TBMenuItemName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private MaterialSkin.Controls.MaterialTextBox2 TBMenuItemPrice;
        private System.Windows.Forms.Label label6;
        private MaterialSkin.Controls.MaterialCard materialCard4;
        private System.Windows.Forms.FlowLayoutPanel MenuFlowLayout;
        private MaterialSkin.Controls.MaterialCard materialCard8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label menuStallNameLabel;
        private System.Windows.Forms.Label label10;
        private RoundedButton SaveMenuButton;
        private MaterialSkin.Controls.MaterialTextBox2 TBMenuItemStocks;
        private RoundedButton AddNewProductButton;
        private System.Windows.Forms.Label MenuTomorrowsDateText;
        private System.Windows.Forms.Label MenuTodaysDateText;
        private System.Windows.Forms.DateTimePicker MenuCustomDateText;
        private BorderRadiusPictureBox MenuPictureBoxItem;
        private BorderRadiusPictureBox ViewStallProfilePictureBox;
        private System.Windows.Forms.RadioButton CustomRadioButton;
        private System.Windows.Forms.RadioButton TomorrowsMenuRadioButton;
        private System.Windows.Forms.RadioButton TodaysMenuRadioButton;
        private System.Windows.Forms.ComboBox ViewMenuListComboBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private MaterialSkin.Controls.MaterialCard materialCard10;
        private BorderRadiusPictureBox StallProfilePicturePcbx;
        private MaterialSkin.Controls.MaterialCard materialCard11;
        private System.Windows.Forms.Label SortAllHistoryLabel;
        private System.Windows.Forms.Label SortTodayHistoryLabel;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label AllLabelHighlighter;
        private System.Windows.Forms.Label TodayLabelHighlighter;
        private System.Windows.Forms.Label WeekLabelHighlighter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private BorderRadiusPanel borderRadiusPanel1;
        private BorderRadiusPanel borderRadiusPanel2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label TotalOrdersLabel;
        private BorderRadiusPanel borderRadiusPanel3;
        private System.Windows.Forms.Label ProductCountLabel;
        private System.Windows.Forms.Label label21;
        private BorderRadiusPanel borderRadiusPanel4;
        private BorderRadiusPanel borderRadiusPanel5;
        private System.Windows.Forms.Label TotalTransactionsLabel;
        private System.Windows.Forms.Label label23;
        private BorderRadiusPanel borderRadiusPanel6;
        private System.Windows.Forms.PictureBox pictureBox4;
        private BorderRadiusPanel borderRadiusPanel7;
        private System.Windows.Forms.Label TotalDeclinedOrdersLabel;
        private System.Windows.Forms.Label label25;
        private BorderRadiusPanel borderRadiusPanel8;
        private System.Windows.Forms.PictureBox pictureBox5;
        private BorderRadiusPanel borderRadiusPanel9;
        private System.Windows.Forms.Label TotalSalesLabel;
        private System.Windows.Forms.Label label27;
        private BorderRadiusPanel borderRadiusPanel10;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label SortMonthLabel;
        private System.Windows.Forms.Label SortYesterdayLabel;
        private System.Windows.Forms.Label SortTodayLabel;
        private System.Windows.Forms.Label SortAllLabel;
        private System.Windows.Forms.Label AllLabelHighlighter1;
        private System.Windows.Forms.Label TodayLabelHighlighter1;
        private System.Windows.Forms.Label WeekLabelHighlighter1;
        private System.Windows.Forms.Label MonthLabelHighlighter1;
        private System.Windows.Forms.Label label28;
        private RoundedButton FinishOrderButton;
        private RoundedButton ReadyOrderButton;
        private RoundedButton DeclineOrderButton;
        private RoundedButton AcceptOrderButton;
        private RoundedButton ViewOrderButton;
        private System.Windows.Forms.FlowLayoutPanel TransactionListFlowLayoutPanel;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MaterialSkin.Controls.MaterialLabel materialLabel28;
        private MaterialSkin.Controls.MaterialLabel materialLabel30;
        private MaterialSkin.Controls.MaterialFloatingActionButton materialFloatingActionButton6;
        private MaterialSkin.Controls.MaterialLabel materialLabel31;
        private MaterialSkin.Controls.MaterialLabel StallNumberEditLabel;
        private MaterialSkin.Controls.MaterialFloatingActionButton materialFloatingActionButton7;
        private MaterialSkin.Controls.MaterialLabel materialLabel33;
        private MaterialSkin.Controls.MaterialLabel StallNameEditLabel;
        private MaterialSkin.Controls.MaterialFloatingActionButton materialFloatingActionButton8;
        private MaterialSkin.Controls.MaterialLabel materialLabel35;
        private MaterialSkin.Controls.MaterialLabel OperatingHoursEditLabel;
        private MaterialSkin.Controls.MaterialFloatingActionButton materialFloatingActionButton9;
        private MaterialSkin.Controls.MaterialLabel materialLabel37;
        private MaterialSkin.Controls.MaterialLabel DaysOperationEditLabel;
        private MaterialSkin.Controls.MaterialFloatingActionButton materialFloatingActionButton10;
        private MaterialSkin.Controls.MaterialLabel materialLabel39;
        private MaterialSkin.Controls.MaterialLabel ContactNumberEditLabel;
        private MaterialSkin.Controls.MaterialButton EditStallPhotoButton;
        private RoundedButton EditStallButton;
        private RoundedButton EditProfileButton;
        private RoundedButton SaveStallPhotoButton;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label17;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel StallOwnerNameLabel;
        private System.Windows.Forms.CheckBox PayOnPickupButton;
        private System.Windows.Forms.CheckBox GcashButton;
        private MaterialSkin.Controls.MaterialLabel StallOperationsLabel;
        private System.Windows.Forms.Label ConnectGcashAccount;
        private System.Windows.Forms.Label customerNameLabel;
        private BorderRadiusPictureBox customerPicturePcbx;
        private System.Windows.Forms.Label customerUserIDLabel;
        private System.Windows.Forms.Label customerEmailLabel;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label orderTypeLabel;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label orderStatusLabel;
        private MaterialSkin.Controls.MaterialListView OrderedProducts;
        private System.Windows.Forms.ColumnHeader OrderedProductsColumnInListView;
        private System.Windows.Forms.ColumnHeader QuantityListView;
        private System.Windows.Forms.ColumnHeader PriceListView;
        private System.Windows.Forms.ColumnHeader TotalPriceListView;
        private RoundedButton VerifyButton;
        private System.Windows.Forms.Label orderDateLabel;
        private System.Windows.Forms.Label orderTimeLabel;
        private System.Windows.Forms.Label isPaidLabel;
        private System.Windows.Forms.Label paymentMethodLabel;
        private System.Windows.Forms.Label overallTotalLabel;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label orderIDLabel;
        private RoundedButton ReceiveOrderButton;
        private RoundedButton PrintReceiptButton;
        private MaterialSkin.Controls.MaterialLabel StallNumberLabel;
        private BorderRadiusPictureBox StallProfilePictureBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Orders;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Paid;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentMethod;
        private System.Windows.Forms.TabPage SalesHistory;
        private System.Windows.Forms.Label LifeTimeSalesLabel;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label9;
        private BorderRadiusPanel borderRadiusPanel11;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label26;
        private RoundedButton LogoutButton;
        private System.Windows.Forms.Label label32;
        private LiveCharts.WinForms.CartesianChart cartesianChart3;
        private LiveCharts.WinForms.CartesianChart cartesianChart1;
        private LiveCharts.WinForms.CartesianChart cartesianChart2;
    }
}
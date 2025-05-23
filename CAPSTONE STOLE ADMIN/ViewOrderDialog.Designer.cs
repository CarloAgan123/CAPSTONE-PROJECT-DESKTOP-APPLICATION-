namespace CAPSTONE_STOLE_ADMIN
{
    partial class ViewOrderDialog
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
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "Payment Method",
            "Gcash"}, -1);
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "Payment Status",
            "True"}, -1);
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem(new string[] {
            "Order Created",
            "Sun, September 7, 2024"}, -1);
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem(new string[] {
            "Order Time",
            "06:49 AM"}, -1);
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem(new System.Windows.Forms.ListViewItem.ListViewSubItem[] {
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "Customer Name", System.Drawing.SystemColors.WindowText, System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))), new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)))),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "Juan Santos", System.Drawing.SystemColors.WindowText, System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))), new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))))}, -1);
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem(new System.Windows.Forms.ListViewItem.ListViewSubItem[] {
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "Customer ID", System.Drawing.SystemColors.WindowText, System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))), new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)))),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "12-123456", System.Drawing.SystemColors.WindowText, System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))), new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))))}, -1);
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem(new System.Windows.Forms.ListViewItem.ListViewSubItem[] {
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "Email", System.Drawing.SystemColors.WindowText, System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))), new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)))),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "juansantos@gmail.com", System.Drawing.SystemColors.WindowText, System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))), new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))))}, -1);
            System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem(new System.Windows.Forms.ListViewItem.ListViewSubItem[] {
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "Type", System.Drawing.SystemColors.WindowText, System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))), new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)))),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "Order", System.Drawing.SystemColors.WindowText, System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))), new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))))}, -1);
            System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem(new string[] {
            "Status",
            "Pending"}, -1);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.materialCard5 = new MaterialSkin.Controls.MaterialCard();
            this.OrderedProducts = new MaterialSkin.Controls.MaterialListView();
            this.OrderedProductsColumnInListView = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.QuantityListView = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PriceListView = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TotalPriceListView = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialCard7 = new MaterialSkin.Controls.MaterialCard();
            this.PaymentListView = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.OverallTotalPrice = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.DateTimeListView = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DataObtained2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.customerPictureBox = new CAPSTONE_STOLE_ADMIN.BorderRadiusPictureBox();
            this.CustomerNameLabel = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard6 = new MaterialSkin.Controls.MaterialCard();
            this.CustomerOtherDetails = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DataObtained = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialCard4 = new MaterialSkin.Controls.MaterialCard();
            this.FinishOrderButton = new CAPSTONE_STOLE_ADMIN.RoundedButton();
            this.ReadyOrderButton = new CAPSTONE_STOLE_ADMIN.RoundedButton();
            this.AcceptOrderButton = new CAPSTONE_STOLE_ADMIN.RoundedButton();
            this.DeclineOrderButton = new CAPSTONE_STOLE_ADMIN.RoundedButton();
            this.BackButton = new MaterialSkin.Controls.MaterialButton();
            this.GCashImage = new CAPSTONE_STOLE_ADMIN.BorderRadiusPictureBox();
            this.GCashLabel = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard5.SuspendLayout();
            this.materialCard7.SuspendLayout();
            this.materialCard3.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerPictureBox)).BeginInit();
            this.materialCard6.SuspendLayout();
            this.materialCard4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GCashImage)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // materialCard5
            // 
            this.materialCard5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard5.Controls.Add(this.OrderedProducts);
            this.materialCard5.Depth = 0;
            this.materialCard5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard5.Location = new System.Drawing.Point(20, 44);
            this.materialCard5.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard5.Name = "materialCard5";
            this.materialCard5.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard5.Size = new System.Drawing.Size(474, 196);
            this.materialCard5.TabIndex = 13;
            // 
            // OrderedProducts
            // 
            this.OrderedProducts.AutoSizeTable = false;
            this.OrderedProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.OrderedProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OrderedProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.OrderedProductsColumnInListView,
            this.QuantityListView,
            this.PriceListView,
            this.TotalPriceListView});
            this.OrderedProducts.Depth = 0;
            this.OrderedProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrderedProducts.Font = new System.Drawing.Font("Open Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderedProducts.FullRowSelect = true;
            this.OrderedProducts.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.OrderedProducts.HideSelection = false;
            this.OrderedProducts.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.OrderedProducts.LargeImageList = this.imageList1;
            this.OrderedProducts.Location = new System.Drawing.Point(14, 14);
            this.OrderedProducts.MinimumSize = new System.Drawing.Size(200, 100);
            this.OrderedProducts.MouseLocation = new System.Drawing.Point(-1, -1);
            this.OrderedProducts.MouseState = MaterialSkin.MouseState.OUT;
            this.OrderedProducts.Name = "OrderedProducts";
            this.OrderedProducts.OwnerDraw = true;
            this.OrderedProducts.Size = new System.Drawing.Size(446, 168);
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
            // materialCard7
            // 
            this.materialCard7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard7.Controls.Add(this.PaymentListView);
            this.materialCard7.Depth = 0;
            this.materialCard7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard7.Location = new System.Drawing.Point(860, 44);
            this.materialCard7.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard7.Name = "materialCard7";
            this.materialCard7.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard7.Size = new System.Drawing.Size(346, 147);
            this.materialCard7.TabIndex = 18;
            // 
            // PaymentListView
            // 
            this.PaymentListView.AutoSizeTable = false;
            this.PaymentListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.PaymentListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PaymentListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.PaymentListView.Depth = 0;
            this.PaymentListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PaymentListView.Font = new System.Drawing.Font("Open Sans", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentListView.FullRowSelect = true;
            this.PaymentListView.HideSelection = false;
            this.PaymentListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem4,
            listViewItem5});
            this.PaymentListView.Location = new System.Drawing.Point(14, 14);
            this.PaymentListView.MinimumSize = new System.Drawing.Size(200, 100);
            this.PaymentListView.MouseLocation = new System.Drawing.Point(-1, -1);
            this.PaymentListView.MouseState = MaterialSkin.MouseState.OUT;
            this.PaymentListView.Name = "PaymentListView";
            this.PaymentListView.OwnerDraw = true;
            this.PaymentListView.Size = new System.Drawing.Size(318, 119);
            this.PaymentListView.TabIndex = 0;
            this.PaymentListView.UseCompatibleStateImageBehavior = false;
            this.PaymentListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Payment";
            this.columnHeader3.Width = 170;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "";
            this.columnHeader4.Width = 130;
            // 
            // materialCard3
            // 
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.OverallTotalPrice);
            this.materialCard3.Controls.Add(this.materialLabel3);
            this.materialCard3.Depth = 0;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(504, 466);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard3.Size = new System.Drawing.Size(346, 53);
            this.materialCard3.TabIndex = 17;
            // 
            // OverallTotalPrice
            // 
            this.OverallTotalPrice.Depth = 0;
            this.OverallTotalPrice.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.OverallTotalPrice.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.OverallTotalPrice.Location = new System.Drawing.Point(70, 14);
            this.OverallTotalPrice.MouseState = MaterialSkin.MouseState.HOVER;
            this.OverallTotalPrice.Name = "OverallTotalPrice";
            this.OverallTotalPrice.Size = new System.Drawing.Size(257, 24);
            this.OverallTotalPrice.TabIndex = 1;
            this.OverallTotalPrice.Text = "$190.00";
            this.OverallTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel3.Location = new System.Drawing.Point(17, 14);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(47, 24);
            this.materialLabel3.TabIndex = 0;
            this.materialLabel3.Text = "Total";
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.DateTimeListView);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(504, 308);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(346, 130);
            this.materialCard2.TabIndex = 16;
            // 
            // DateTimeListView
            // 
            this.DateTimeListView.AutoSizeTable = false;
            this.DateTimeListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DateTimeListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DateTimeListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.DataObtained2});
            this.DateTimeListView.Depth = 0;
            this.DateTimeListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DateTimeListView.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimeListView.FullRowSelect = true;
            this.DateTimeListView.HideSelection = false;
            this.DateTimeListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem6,
            listViewItem7});
            this.DateTimeListView.Location = new System.Drawing.Point(14, 14);
            this.DateTimeListView.MinimumSize = new System.Drawing.Size(200, 100);
            this.DateTimeListView.MouseLocation = new System.Drawing.Point(-1, -1);
            this.DateTimeListView.MouseState = MaterialSkin.MouseState.OUT;
            this.DateTimeListView.Name = "DateTimeListView";
            this.DateTimeListView.OwnerDraw = true;
            this.DateTimeListView.Size = new System.Drawing.Size(318, 102);
            this.DateTimeListView.TabIndex = 0;
            this.DateTimeListView.UseCompatibleStateImageBehavior = false;
            this.DateTimeListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Summary";
            this.columnHeader2.Width = 120;
            // 
            // DataObtained2
            // 
            this.DataObtained2.Text = "";
            this.DataObtained2.Width = 180;
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.customerPictureBox);
            this.materialCard1.Controls.Add(this.CustomerNameLabel);
            this.materialCard1.Controls.Add(this.materialLabel1);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(504, 44);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(346, 236);
            this.materialCard1.TabIndex = 15;
            // 
            // customerPictureBox
            // 
            this.customerPictureBox.BorderColor = System.Drawing.Color.White;
            this.customerPictureBox.BorderRadius = 20;
            this.customerPictureBox.BorderSize = 11;
            this.customerPictureBox.Image = global::CAPSTONE_STOLE_ADMIN.Properties.Resources._806ea7d3ec0a77b9412333973ad287d6;
            this.customerPictureBox.Location = new System.Drawing.Point(100, 78);
            this.customerPictureBox.Name = "customerPictureBox";
            this.customerPictureBox.Size = new System.Drawing.Size(147, 135);
            this.customerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.customerPictureBox.TabIndex = 3;
            this.customerPictureBox.TabStop = false;
            // 
            // CustomerNameLabel
            // 
            this.CustomerNameLabel.Depth = 0;
            this.CustomerNameLabel.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.CustomerNameLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.CustomerNameLabel.HighEmphasis = true;
            this.CustomerNameLabel.Location = new System.Drawing.Point(21, 40);
            this.CustomerNameLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.CustomerNameLabel.Name = "CustomerNameLabel";
            this.CustomerNameLabel.Size = new System.Drawing.Size(306, 24);
            this.CustomerNameLabel.TabIndex = 2;
            this.CustomerNameLabel.Text = "Juan Santos";
            this.CustomerNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CustomerNameLabel.UseAccent = true;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.materialLabel1.Location = new System.Drawing.Point(122, 14);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(109, 17);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Customer Profile";
            // 
            // materialCard6
            // 
            this.materialCard6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard6.Controls.Add(this.CustomerOtherDetails);
            this.materialCard6.Depth = 0;
            this.materialCard6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard6.Location = new System.Drawing.Point(20, 252);
            this.materialCard6.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard6.Name = "materialCard6";
            this.materialCard6.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard6.Size = new System.Drawing.Size(474, 267);
            this.materialCard6.TabIndex = 19;
            // 
            // CustomerOtherDetails
            // 
            this.CustomerOtherDetails.AutoSizeTable = false;
            this.CustomerOtherDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CustomerOtherDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CustomerOtherDetails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.DataObtained});
            this.CustomerOtherDetails.Depth = 0;
            this.CustomerOtherDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomerOtherDetails.Font = new System.Drawing.Font("Open Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerOtherDetails.FullRowSelect = true;
            this.CustomerOtherDetails.HideSelection = false;
            this.CustomerOtherDetails.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem8,
            listViewItem9,
            listViewItem10,
            listViewItem11,
            listViewItem12});
            this.CustomerOtherDetails.Location = new System.Drawing.Point(14, 14);
            this.CustomerOtherDetails.MinimumSize = new System.Drawing.Size(200, 100);
            this.CustomerOtherDetails.MouseLocation = new System.Drawing.Point(-1, -1);
            this.CustomerOtherDetails.MouseState = MaterialSkin.MouseState.OUT;
            this.CustomerOtherDetails.Name = "CustomerOtherDetails";
            this.CustomerOtherDetails.OwnerDraw = true;
            this.CustomerOtherDetails.Size = new System.Drawing.Size(446, 239);
            this.CustomerOtherDetails.TabIndex = 2;
            this.CustomerOtherDetails.UseCompatibleStateImageBehavior = false;
            this.CustomerOtherDetails.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Customer And Other Details";
            this.columnHeader1.Width = 270;
            // 
            // DataObtained
            // 
            this.DataObtained.Text = "";
            this.DataObtained.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataObtained.Width = 170;
            // 
            // materialCard4
            // 
            this.materialCard4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard4.Controls.Add(this.FinishOrderButton);
            this.materialCard4.Controls.Add(this.ReadyOrderButton);
            this.materialCard4.Controls.Add(this.AcceptOrderButton);
            this.materialCard4.Controls.Add(this.DeclineOrderButton);
            this.materialCard4.Depth = 0;
            this.materialCard4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard4.Location = new System.Drawing.Point(17, 540);
            this.materialCard4.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard4.Name = "materialCard4";
            this.materialCard4.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard4.Size = new System.Drawing.Size(837, 77);
            this.materialCard4.TabIndex = 20;
            // 
            // FinishOrderButton
            // 
            this.FinishOrderButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FinishOrderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FinishOrderButton.FlatAppearance.BorderSize = 0;
            this.FinishOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FinishOrderButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinishOrderButton.ForeColor = System.Drawing.Color.Blue;
            this.FinishOrderButton.Image = global::CAPSTONE_STOLE_ADMIN.Properties.Resources.icons8_success_28;
            this.FinishOrderButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FinishOrderButton.Location = new System.Drawing.Point(601, 17);
            this.FinishOrderButton.Name = "FinishOrderButton";
            this.FinishOrderButton.Padding = new System.Windows.Forms.Padding(4);
            this.FinishOrderButton.Size = new System.Drawing.Size(156, 41);
            this.FinishOrderButton.TabIndex = 72;
            this.FinishOrderButton.Text = "  Finish";
            this.FinishOrderButton.UseVisualStyleBackColor = false;
            this.FinishOrderButton.Click += new System.EventHandler(this.FinishOrderButton_Click);
            // 
            // ReadyOrderButton
            // 
            this.ReadyOrderButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ReadyOrderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ReadyOrderButton.FlatAppearance.BorderSize = 0;
            this.ReadyOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReadyOrderButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReadyOrderButton.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.ReadyOrderButton.Image = global::CAPSTONE_STOLE_ADMIN.Properties.Resources.icons8_room_service_with_food_serving_by_hotel_staff_28;
            this.ReadyOrderButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ReadyOrderButton.Location = new System.Drawing.Point(427, 18);
            this.ReadyOrderButton.Name = "ReadyOrderButton";
            this.ReadyOrderButton.Padding = new System.Windows.Forms.Padding(4);
            this.ReadyOrderButton.Size = new System.Drawing.Size(156, 41);
            this.ReadyOrderButton.TabIndex = 71;
            this.ReadyOrderButton.Text = "    Ready";
            this.ReadyOrderButton.UseVisualStyleBackColor = false;
            this.ReadyOrderButton.Click += new System.EventHandler(this.ReadyOrderButton_Click);
            // 
            // AcceptOrderButton
            // 
            this.AcceptOrderButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AcceptOrderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.AcceptOrderButton.FlatAppearance.BorderSize = 0;
            this.AcceptOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AcceptOrderButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AcceptOrderButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.AcceptOrderButton.Image = global::CAPSTONE_STOLE_ADMIN.Properties.Resources.icons8_order_completed_28;
            this.AcceptOrderButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AcceptOrderButton.Location = new System.Drawing.Point(253, 19);
            this.AcceptOrderButton.Name = "AcceptOrderButton";
            this.AcceptOrderButton.Padding = new System.Windows.Forms.Padding(4);
            this.AcceptOrderButton.Size = new System.Drawing.Size(156, 41);
            this.AcceptOrderButton.TabIndex = 70;
            this.AcceptOrderButton.Text = "     Accept";
            this.AcceptOrderButton.UseVisualStyleBackColor = false;
            this.AcceptOrderButton.Click += new System.EventHandler(this.AcceptOrderButton_Click);
            // 
            // DeclineOrderButton
            // 
            this.DeclineOrderButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DeclineOrderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DeclineOrderButton.FlatAppearance.BorderSize = 0;
            this.DeclineOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeclineOrderButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeclineOrderButton.ForeColor = System.Drawing.Color.Tomato;
            this.DeclineOrderButton.Image = global::CAPSTONE_STOLE_ADMIN.Properties.Resources.icons8_cancel_28;
            this.DeclineOrderButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeclineOrderButton.Location = new System.Drawing.Point(79, 19);
            this.DeclineOrderButton.Name = "DeclineOrderButton";
            this.DeclineOrderButton.Padding = new System.Windows.Forms.Padding(4);
            this.DeclineOrderButton.Size = new System.Drawing.Size(156, 41);
            this.DeclineOrderButton.TabIndex = 69;
            this.DeclineOrderButton.Text = "     Decline";
            this.DeclineOrderButton.UseVisualStyleBackColor = false;
            this.DeclineOrderButton.Click += new System.EventHandler(this.DeclineOrderButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.AutoSize = false;
            this.BackButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            this.BackButton.Depth = 0;
            this.BackButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BackButton.DrawShadows = false;
            this.BackButton.HighEmphasis = false;
            this.BackButton.Icon = global::CAPSTONE_STOLE_ADMIN.Properties.Resources.icons8_left_arrow_50;
            this.BackButton.Location = new System.Drawing.Point(20, 6);
            this.BackButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BackButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.BackButton.Name = "BackButton";
            this.BackButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BackButton.Size = new System.Drawing.Size(103, 32);
            this.BackButton.TabIndex = 14;
            this.BackButton.Text = "Back";
            this.BackButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.BackButton.UseAccentColor = true;
            this.BackButton.UseVisualStyleBackColor = true;
            // 
            // GCashImage
            // 
            this.GCashImage.BorderColor = System.Drawing.Color.DodgerBlue;
            this.GCashImage.BorderRadius = 10;
            this.GCashImage.BorderSize = 4;
            this.GCashImage.Image = global::CAPSTONE_STOLE_ADMIN.Properties.Resources._806ea7d3ec0a77b9412333973ad287d6;
            this.GCashImage.Location = new System.Drawing.Point(928, 234);
            this.GCashImage.Name = "GCashImage";
            this.GCashImage.Size = new System.Drawing.Size(219, 383);
            this.GCashImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GCashImage.TabIndex = 21;
            this.GCashImage.TabStop = false;
            // 
            // GCashLabel
            // 
            this.GCashLabel.AutoSize = true;
            this.GCashLabel.Depth = 0;
            this.GCashLabel.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.GCashLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.GCashLabel.Location = new System.Drawing.Point(913, 202);
            this.GCashLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.GCashLabel.Name = "GCashLabel";
            this.GCashLabel.Size = new System.Drawing.Size(251, 24);
            this.GCashLabel.TabIndex = 2;
            this.GCashLabel.Text = "GCash Payment Screenshot";
            // 
            // ViewOrderDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1223, 634);
            this.Controls.Add(this.GCashLabel);
            this.Controls.Add(this.GCashImage);
            this.Controls.Add(this.materialCard4);
            this.Controls.Add(this.materialCard6);
            this.Controls.Add(this.materialCard7);
            this.Controls.Add(this.materialCard3);
            this.Controls.Add(this.materialCard2);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.materialCard5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewOrderDialog";
            this.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewOrderDialog";
            this.Activated += new System.EventHandler(this.ViewOrderDialog_Activated);
            this.ResizeEnd += new System.EventHandler(this.ViewOrderDialog_ResizeEnd);
            this.SizeChanged += new System.EventHandler(this.ViewOrderDialog_SizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ViewOrderDialog_Paint);
            this.materialCard5.ResumeLayout(false);
            this.materialCard7.ResumeLayout(false);
            this.materialCard3.ResumeLayout(false);
            this.materialCard3.PerformLayout();
            this.materialCard2.ResumeLayout(false);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerPictureBox)).EndInit();
            this.materialCard6.ResumeLayout(false);
            this.materialCard4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GCashImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private MaterialSkin.Controls.MaterialButton BackButton;
        private MaterialSkin.Controls.MaterialCard materialCard5;
        private MaterialSkin.Controls.MaterialListView OrderedProducts;
        private System.Windows.Forms.ColumnHeader OrderedProductsColumnInListView;
        private System.Windows.Forms.ColumnHeader QuantityListView;
        private System.Windows.Forms.ColumnHeader PriceListView;
        private System.Windows.Forms.ColumnHeader TotalPriceListView;
        private MaterialSkin.Controls.MaterialCard materialCard7;
        private MaterialSkin.Controls.MaterialListView PaymentListView;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private MaterialSkin.Controls.MaterialLabel OverallTotalPrice;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialListView DateTimeListView;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader DataObtained2;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private BorderRadiusPictureBox customerPictureBox;
        private MaterialSkin.Controls.MaterialLabel CustomerNameLabel;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialCard materialCard6;
        private MaterialSkin.Controls.MaterialListView CustomerOtherDetails;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader DataObtained;
        private MaterialSkin.Controls.MaterialCard materialCard4;
        private RoundedButton FinishOrderButton;
        private RoundedButton ReadyOrderButton;
        private RoundedButton AcceptOrderButton;
        private RoundedButton DeclineOrderButton;
        private BorderRadiusPictureBox GCashImage;
        private MaterialSkin.Controls.MaterialLabel GCashLabel;
    }
}
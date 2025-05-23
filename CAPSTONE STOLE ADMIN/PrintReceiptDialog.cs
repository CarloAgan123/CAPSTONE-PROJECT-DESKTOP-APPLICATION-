using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;

namespace CAPSTONE_STOLE_ADMIN
{
    public partial class PrintReceiptDialog : Form
    {
        public string StallNumber { get; set; }
        public string CustomerName { get; set; }
        public string Type { get; set; }
        public string PaymentMethod { get; set; }
        public string IsPaid { get; set; }
        public string TotalPrice { get; set; }
        public string StallName { get; set; }
        public List<string> OrderProductList { get; set; }
        public string OrderDate { get; set; }
        public string OrderTime { get; set; }

        private int finalY;
        private int startY;
        private int animationStep = 10;

        public PrintReceiptDialog(
            string stallNumber, string customerName, string type, string paymentMethod,
            string isPaid, string totalPrice, string stallName, List<string> orderProductList,
            string orderDate, string orderTime)
        {
            InitializeComponent();
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            SetPaperSize();
            StallNumber = stallNumber;
            CustomerName = customerName;
            Type = type;
            PaymentMethod = paymentMethod;
            IsPaid = isPaid;
            TotalPrice = totalPrice;
            StallName = stallName;
            OrderProductList = orderProductList;
            OrderDate = orderDate;
            OrderTime = orderTime;
        }

        private void PrintReceiptButton_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void SetPaperSize()
        {
            printDocument1.DefaultPageSettings.PaperSize = printDocument1.PrinterSettings.DefaultPageSettings.PaperSize;
            printDocument1.DefaultPageSettings.Margins = new Margins(0, 0, 0, 0);
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font regularFont = new Font("Arial", 9);
            Font boldFont = new Font("Arial", 9, FontStyle.Bold);
            Font titleFont = new Font("Arial", 11, FontStyle.Bold);
            float lineHeight = regularFont.GetHeight(e.Graphics);
            float x = 5;
            float y = 5;

            Image logo = Properties.Resources.cdm_mobile_app_icon;
            float logoWidth = logo.Width * 2;  
            float logoHeight = logo.Height * 2;
            float centerX = (e.PageBounds.Width - logoWidth) / 2;


            e.Graphics.DrawImage(logo, centerX, y, logoWidth, logoHeight);
            y += logoHeight + 10; 

            e.Graphics.DrawString("CDM Canteen", titleFont, Brushes.Black, x, y);
            y += lineHeight * 2;

            e.Graphics.DrawString("-------------------------------------------------", regularFont, Brushes.Black, x, y);
            y += lineHeight;

            e.Graphics.DrawString($"Customer: {CustomerName}", boldFont, Brushes.Black, x, y);
            y += lineHeight;
            e.Graphics.DrawString($"Order Type: {Type}", regularFont, Brushes.Black, x, y);
            y += lineHeight;

            e.Graphics.DrawString("Order Date:", boldFont, Brushes.Black, x, y);
            y += lineHeight;
            e.Graphics.DrawString(OrderDate, regularFont, Brushes.Black, x, y);
            y += lineHeight * 2;

            e.Graphics.DrawString("Ordered Products", boldFont, Brushes.Black, x, y);
            y += lineHeight;

            e.Graphics.DrawString("-------------------------------------------------", regularFont, Brushes.Black, x, y);
            y += lineHeight;

            foreach (var product in OrderProductList)
            {
                string[] productDetails = product.Split(new[] { ',' }, StringSplitOptions.None);

                if (productDetails.Length >= 4)
                {
                    e.Graphics.DrawString($"Name: {productDetails[0]}", regularFont, Brushes.Black, x, y);
                    y += lineHeight;

                    e.Graphics.DrawString($"Price: {productDetails[2]}", regularFont, Brushes.Black, x, y);
                    y += lineHeight;

                    e.Graphics.DrawString($"Subtotal: {productDetails[3]}", regularFont, Brushes.Black, x, y);
                    y += lineHeight * 2; 
                }
                else
                {
                    e.Graphics.DrawString("Invalid product data", regularFont, Brushes.Black, x, y);
                    y += lineHeight * 2;
                }
            }

            e.Graphics.DrawString("-------------------------------------------------", regularFont, Brushes.Black, x, y);
            y += lineHeight * 2;

            e.Graphics.DrawString($"Payment Method: {PaymentMethod}", regularFont, Brushes.Black, x, y);
            y += lineHeight;
            e.Graphics.DrawString($"Payment Status: {IsPaid}", regularFont, Brushes.Black, x, y);
            y += lineHeight * 2;

            e.Graphics.DrawString($"Total: ₱{TotalPrice}", boldFont, Brushes.Black, x, y);
            y += lineHeight * 2;

            e.Graphics.DrawString($"Stall: {StallName}", boldFont, Brushes.Black, x, y);
            y += lineHeight * 2;

            e.Graphics.DrawString("Thank you for your purchase!", regularFont, Brushes.Black, x, y);
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

        private void PrintReceiptDialog_Load(object sender, EventArgs e)
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

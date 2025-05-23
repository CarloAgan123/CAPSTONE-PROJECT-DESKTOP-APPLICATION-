using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCvSharp;

namespace CAPSTONE_STOLE_ADMIN
{
    public partial class QRCodeScanner : Form
    {
        private string previousDecodedInfo = "";
        private const string Url = "http://192.168.8.100/cam-hi.jpg";
        private CancellationTokenSource cancellationTokenSource;
        private bool isScanning = true;

        private string currentCustomerId;
        private string currentOrderId;
        public string customerID => currentCustomerId;
        public string orderID => currentOrderId;

        public QRCodeScanner(string customerId, string orderId)
        {
            InitializeComponent();
            StartLiveFeed();
            StartProgressBarAnimation();
            currentCustomerId = customerId;
            currentOrderId = orderId;
        }

        private void StartLiveFeed()
        {
            cancellationTokenSource = new CancellationTokenSource();
            Task.Run(() => FetchImages(cancellationTokenSource.Token));
        }

        private void StartProgressBarAnimation()
        {
            isScanning = true;
            Task.Run(async () =>
            {
                while (isScanning)
                {
                    Invoke(new Action(() =>
                    {
                        circularProgressBar1.Progress = (circularProgressBar1.Progress + 5) % 100;
                    }));
                    await Task.Delay(50);
                }
            });
        }

        private async Task FetchImages(CancellationToken token)
        {
            while (!token.IsCancellationRequested)
            {
                try
                {
                    using (WebClient webClient = new WebClient())
                    {
                        byte[] imageBytes = webClient.DownloadData(Url);
                        using (var ms = new MemoryStream(imageBytes))
                        {
                            Mat frame = Cv2.ImDecode(ms.ToArray(), ImreadModes.Color);

                            if (frame.Empty())
                                return;

                            Cv2.Flip(frame, frame, FlipMode.X);

                            QRCodeDetector qrCodeDetector = new QRCodeDetector();
                            string decodedInfo = qrCodeDetector.DetectAndDecode(frame, out var points);

                            if (!string.IsNullOrEmpty(decodedInfo) && previousDecodedInfo != decodedInfo)
                            {
                                previousDecodedInfo = decodedInfo;
                                ProcessLabel.Text = "Verifying...";
                                VerifyTransaction(decodedInfo);
                            }

                            if (!string.IsNullOrEmpty(decodedInfo))
                            {
                                Cv2.PutText(frame, decodedInfo, new OpenCvSharp.Point(50, 50),
                                            HersheyFonts.HersheyPlain, 2, new Scalar(255, 0, 0), 3);
                            }

                            Invoke(new Action(() =>
                            {
                                pictureBox1.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(frame);
                            }));
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error fetching image: " + ex.Message);
                }
            }
        }

        private void VerifyTransaction(string data)
        {
            StartProgressBarAnimation();

            string orderIdFromData = ExtractValue(data, "OrderID:", "UserID:");
            string userIdFromData = ExtractValue(data, "UserID:", "");

            bool isOrderValid = orderIdFromData == currentOrderId;
            bool isCustomerValid = userIdFromData == currentCustomerId;

            if (isOrderValid && isCustomerValid)
            {
                ProcessLabel.Text = "Verification successful!";
                FailedSuccessIndicatorPictureBox.Image = Properties.Resources.icons8_success_48;
            }
            else
            {
                ProcessLabel.Text = "Verification failed. Invalid OrderID or UserID.";
                FailedSuccessIndicatorPictureBox.Image = Properties.Resources.icons8_error_48;
            }

            StopProgressBarAnimation();
        }

        private string ExtractValue(string source, string start, string end)
        {
            int startIndex = source.IndexOf(start) + start.Length;
            int endIndex = string.IsNullOrEmpty(end) ? source.Length : source.IndexOf(end, startIndex);

            if (startIndex >= 0 && endIndex >= startIndex)
            {
                return source.Substring(startIndex, endIndex - startIndex).Trim();
            }
            return string.Empty;
        }

        private void StopProgressBarAnimation()
        {
            isScanning = false;
            Invoke(new Action(() =>
            {
                circularProgressBar1.Progress = 100;
            }));
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            cancellationTokenSource.Cancel();
            base.OnFormClosing(e);
        }
    }
}

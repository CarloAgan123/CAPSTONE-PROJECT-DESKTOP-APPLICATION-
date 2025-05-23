namespace CAPSTONE_STOLE_ADMIN
{
    partial class QRCodeScanner
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.roundedButton1 = new CAPSTONE_STOLE_ADMIN.RoundedButton();
            this.label1 = new System.Windows.Forms.Label();
            this.ProcessLabel = new System.Windows.Forms.Label();
            this.circularProgressBar1 = new CAPSTONE_STOLE_ADMIN.CircularProgressBar();
            this.FailedSuccessIndicatorPictureBox = new CAPSTONE_STOLE_ADMIN.BorderRadiusPictureBox();
            this.roundedButton2 = new CAPSTONE_STOLE_ADMIN.RoundedButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FailedSuccessIndicatorPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(34, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(744, 534);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // roundedButton1
            // 
            this.roundedButton1.BackColor = System.Drawing.Color.OrangeRed;
            this.roundedButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.roundedButton1.FlatAppearance.BorderSize = 0;
            this.roundedButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButton1.ForeColor = System.Drawing.Color.White;
            this.roundedButton1.Location = new System.Drawing.Point(912, 535);
            this.roundedButton1.Name = "roundedButton1";
            this.roundedButton1.Padding = new System.Windows.Forms.Padding(4);
            this.roundedButton1.Size = new System.Drawing.Size(171, 43);
            this.roundedButton1.TabIndex = 1;
            this.roundedButton1.Text = "Cancel";
            this.roundedButton1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Tomato;
            this.label1.Location = new System.Drawing.Point(476, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "QR Code Scanner";
            // 
            // ProcessLabel
            // 
            this.ProcessLabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProcessLabel.ForeColor = System.Drawing.Color.Black;
            this.ProcessLabel.Location = new System.Drawing.Point(792, 147);
            this.ProcessLabel.Name = "ProcessLabel";
            this.ProcessLabel.Size = new System.Drawing.Size(392, 32);
            this.ProcessLabel.TabIndex = 3;
            this.ProcessLabel.Text = "Scanning...";
            this.ProcessLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // circularProgressBar1
            // 
            this.circularProgressBar1.BackgroundColor = System.Drawing.Color.Green;
            this.circularProgressBar1.Location = new System.Drawing.Point(917, 257);
            this.circularProgressBar1.Name = "circularProgressBar1";
            this.circularProgressBar1.Progress = 0;
            this.circularProgressBar1.ProgressColor = System.Drawing.Color.DodgerBlue;
            this.circularProgressBar1.Size = new System.Drawing.Size(150, 150);
            this.circularProgressBar1.TabIndex = 4;
            this.circularProgressBar1.Thickness = 10;
            // 
            // FailedSuccessIndicatorPictureBox
            // 
            this.FailedSuccessIndicatorPictureBox.BorderColor = System.Drawing.Color.White;
            this.FailedSuccessIndicatorPictureBox.BorderRadius = 10;
            this.FailedSuccessIndicatorPictureBox.BorderSize = 4;
            this.FailedSuccessIndicatorPictureBox.Location = new System.Drawing.Point(967, 310);
            this.FailedSuccessIndicatorPictureBox.Name = "FailedSuccessIndicatorPictureBox";
            this.FailedSuccessIndicatorPictureBox.Size = new System.Drawing.Size(51, 46);
            this.FailedSuccessIndicatorPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FailedSuccessIndicatorPictureBox.TabIndex = 5;
            this.FailedSuccessIndicatorPictureBox.TabStop = false;
            // 
            // roundedButton2
            // 
            this.roundedButton2.BackColor = System.Drawing.Color.MediumBlue;
            this.roundedButton2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.roundedButton2.FlatAppearance.BorderSize = 0;
            this.roundedButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButton2.ForeColor = System.Drawing.Color.White;
            this.roundedButton2.Location = new System.Drawing.Point(912, 486);
            this.roundedButton2.Name = "roundedButton2";
            this.roundedButton2.Padding = new System.Windows.Forms.Padding(4);
            this.roundedButton2.Size = new System.Drawing.Size(171, 43);
            this.roundedButton2.TabIndex = 6;
            this.roundedButton2.Text = "Done";
            this.roundedButton2.UseVisualStyleBackColor = false;
            // 
            // QRCodeScanner
            // 
            this.AcceptButton = this.roundedButton2;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.roundedButton1;
            this.ClientSize = new System.Drawing.Size(1201, 632);
            this.Controls.Add(this.roundedButton2);
            this.Controls.Add(this.FailedSuccessIndicatorPictureBox);
            this.Controls.Add(this.circularProgressBar1);
            this.Controls.Add(this.ProcessLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.roundedButton1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QRCodeScanner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QRCodeScanner";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FailedSuccessIndicatorPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private RoundedButton roundedButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ProcessLabel;
        private CircularProgressBar circularProgressBar1;
        private BorderRadiusPictureBox FailedSuccessIndicatorPictureBox;
        private RoundedButton roundedButton2;
    }
}
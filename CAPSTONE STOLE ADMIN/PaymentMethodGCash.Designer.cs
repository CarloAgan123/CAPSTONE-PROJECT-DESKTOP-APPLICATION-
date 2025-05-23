namespace CAPSTONE_STOLE_ADMIN
{
    partial class PaymentMethodGCash
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
            this.roundedButton1 = new CAPSTONE_STOLE_ADMIN.RoundedButton();
            this.BrowseImageButton = new CAPSTONE_STOLE_ADMIN.RoundedButton();
            this.SaveGCashImageButton = new CAPSTONE_STOLE_ADMIN.RoundedButton();
            this.borderRadiusPictureBox2 = new CAPSTONE_STOLE_ADMIN.BorderRadiusPictureBox();
            this.GCashImage = new CAPSTONE_STOLE_ADMIN.BorderRadiusPictureBox();
            this.modalEffect_Timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.borderRadiusPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GCashImage)).BeginInit();
            this.SuspendLayout();
            // 
            // roundedButton1
            // 
            this.roundedButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(151)))), ((int)(((byte)(212)))));
            this.roundedButton1.FlatAppearance.BorderSize = 0;
            this.roundedButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButton1.ForeColor = System.Drawing.Color.White;
            this.roundedButton1.Location = new System.Drawing.Point(297, 331);
            this.roundedButton1.Name = "roundedButton1";
            this.roundedButton1.Padding = new System.Windows.Forms.Padding(4);
            this.roundedButton1.Size = new System.Drawing.Size(188, 43);
            this.roundedButton1.TabIndex = 1;
            this.roundedButton1.Text = "Back";
            this.roundedButton1.UseVisualStyleBackColor = false;
            this.roundedButton1.Click += new System.EventHandler(this.roundedButton1_Click);
            // 
            // BrowseImageButton
            // 
            this.BrowseImageButton.BackColor = System.Drawing.Color.Gray;
            this.BrowseImageButton.FlatAppearance.BorderSize = 0;
            this.BrowseImageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BrowseImageButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrowseImageButton.ForeColor = System.Drawing.Color.White;
            this.BrowseImageButton.Location = new System.Drawing.Point(297, 187);
            this.BrowseImageButton.Name = "BrowseImageButton";
            this.BrowseImageButton.Padding = new System.Windows.Forms.Padding(4);
            this.BrowseImageButton.Size = new System.Drawing.Size(188, 43);
            this.BrowseImageButton.TabIndex = 3;
            this.BrowseImageButton.Text = "Browse Image";
            this.BrowseImageButton.UseVisualStyleBackColor = false;
            this.BrowseImageButton.Click += new System.EventHandler(this.BrowseImageButton_Click);
            // 
            // SaveGCashImageButton
            // 
            this.SaveGCashImageButton.BackColor = System.Drawing.Color.Green;
            this.SaveGCashImageButton.FlatAppearance.BorderSize = 0;
            this.SaveGCashImageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveGCashImageButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveGCashImageButton.ForeColor = System.Drawing.Color.White;
            this.SaveGCashImageButton.Location = new System.Drawing.Point(297, 236);
            this.SaveGCashImageButton.Name = "SaveGCashImageButton";
            this.SaveGCashImageButton.Padding = new System.Windows.Forms.Padding(4);
            this.SaveGCashImageButton.Size = new System.Drawing.Size(188, 43);
            this.SaveGCashImageButton.TabIndex = 4;
            this.SaveGCashImageButton.Text = "Save";
            this.SaveGCashImageButton.UseVisualStyleBackColor = false;
            this.SaveGCashImageButton.Click += new System.EventHandler(this.SaveGCashImageButton_Click);
            // 
            // borderRadiusPictureBox2
            // 
            this.borderRadiusPictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.borderRadiusPictureBox2.BorderColor = System.Drawing.SystemColors.Control;
            this.borderRadiusPictureBox2.BorderRadius = 20;
            this.borderRadiusPictureBox2.BorderSize = 11;
            this.borderRadiusPictureBox2.Image = global::CAPSTONE_STOLE_ADMIN.Properties.Resources._1000018010;
            this.borderRadiusPictureBox2.Location = new System.Drawing.Point(269, 12);
            this.borderRadiusPictureBox2.Name = "borderRadiusPictureBox2";
            this.borderRadiusPictureBox2.Size = new System.Drawing.Size(246, 139);
            this.borderRadiusPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.borderRadiusPictureBox2.TabIndex = 5;
            this.borderRadiusPictureBox2.TabStop = false;
            // 
            // GCashImage
            // 
            this.GCashImage.BorderColor = System.Drawing.SystemColors.Control;
            this.GCashImage.BorderRadius = 10;
            this.GCashImage.BorderSize = 4;
            this.GCashImage.Location = new System.Drawing.Point(12, 12);
            this.GCashImage.Name = "GCashImage";
            this.GCashImage.Size = new System.Drawing.Size(219, 383);
            this.GCashImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GCashImage.TabIndex = 0;
            this.GCashImage.TabStop = false;
            // 
            // modalEffect_Timer
            // 
            this.modalEffect_Timer.Enabled = true;
            this.modalEffect_Timer.Interval = 1;
            this.modalEffect_Timer.Tick += new System.EventHandler(this.modalEffect_Timer_Tick);
            // 
            // PaymentMethodGCash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 407);
            this.ControlBox = false;
            this.Controls.Add(this.borderRadiusPictureBox2);
            this.Controls.Add(this.SaveGCashImageButton);
            this.Controls.Add(this.BrowseImageButton);
            this.Controls.Add(this.roundedButton1);
            this.Controls.Add(this.GCashImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PaymentMethodGCash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PaymentMethodGCash";
            this.Load += new System.EventHandler(this.PaymentMethodGCash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.borderRadiusPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GCashImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BorderRadiusPictureBox GCashImage;
        private RoundedButton roundedButton1;
        private RoundedButton BrowseImageButton;
        private RoundedButton SaveGCashImageButton;
        private BorderRadiusPictureBox borderRadiusPictureBox2;
        private System.Windows.Forms.Timer modalEffect_Timer;
    }
}
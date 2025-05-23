namespace CAPSTONE_STOLE_ADMIN
{
    partial class ForgotPasswordDialogForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPasswordDialogForm));
            this.panelContainer = new System.Windows.Forms.Panel();
            this.BackLoginButton = new System.Windows.Forms.Label();
            this.SendEmailButton = new CAPSTONE_STOLE_ADMIN.RoundedButton();
            this.EmailTextbox = new MaterialSkin.Controls.MaterialTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.modalEffect_Timer = new System.Windows.Forms.Timer(this.components);
            this.panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.White;
            this.panelContainer.Controls.Add(this.BackLoginButton);
            this.panelContainer.Controls.Add(this.SendEmailButton);
            this.panelContainer.Controls.Add(this.EmailTextbox);
            this.panelContainer.Controls.Add(this.label2);
            this.panelContainer.Controls.Add(this.label1);
            this.panelContainer.Controls.Add(this.pictureBox1);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(407, 432);
            this.panelContainer.TabIndex = 0;
            // 
            // BackLoginButton
            // 
            this.BackLoginButton.AutoSize = true;
            this.BackLoginButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackLoginButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackLoginButton.Location = new System.Drawing.Point(130, 368);
            this.BackLoginButton.Name = "BackLoginButton";
            this.BackLoginButton.Size = new System.Drawing.Size(132, 21);
            this.BackLoginButton.TabIndex = 5;
            this.BackLoginButton.Text = "<  Back to Login";
            this.BackLoginButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BackLoginButton.Click += new System.EventHandler(this.BackLoginButton_Click);
            // 
            // SendEmailButton
            // 
            this.SendEmailButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.SendEmailButton.FlatAppearance.BorderSize = 0;
            this.SendEmailButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendEmailButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendEmailButton.ForeColor = System.Drawing.Color.White;
            this.SendEmailButton.Location = new System.Drawing.Point(46, 294);
            this.SendEmailButton.Name = "SendEmailButton";
            this.SendEmailButton.Padding = new System.Windows.Forms.Padding(4);
            this.SendEmailButton.Size = new System.Drawing.Size(314, 40);
            this.SendEmailButton.TabIndex = 4;
            this.SendEmailButton.Text = "Send";
            this.SendEmailButton.UseVisualStyleBackColor = false;
            this.SendEmailButton.Click += new System.EventHandler(this.SendEmailButton_Click);
            // 
            // EmailTextbox
            // 
            this.EmailTextbox.AnimateReadOnly = false;
            this.EmailTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmailTextbox.Depth = 0;
            this.EmailTextbox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.EmailTextbox.Hint = "Email";
            this.EmailTextbox.LeadingIcon = global::CAPSTONE_STOLE_ADMIN.Properties.Resources.icons8_email_50;
            this.EmailTextbox.Location = new System.Drawing.Point(46, 228);
            this.EmailTextbox.MaxLength = 50;
            this.EmailTextbox.MouseState = MaterialSkin.MouseState.OUT;
            this.EmailTextbox.Multiline = false;
            this.EmailTextbox.Name = "EmailTextbox";
            this.EmailTextbox.Size = new System.Drawing.Size(314, 36);
            this.EmailTextbox.TabIndex = 1;
            this.EmailTextbox.Text = "";
            this.EmailTextbox.TrailingIcon = null;
            this.EmailTextbox.UseAccent = false;
            this.EmailTextbox.UseTallSize = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(42, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(323, 42);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter your email and we\'ll send you a link\r\nto reset your password.\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Forgot Password";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(179, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // modalEffect_Timer
            // 
            this.modalEffect_Timer.Enabled = true;
            this.modalEffect_Timer.Interval = 1;
            this.modalEffect_Timer.Tick += new System.EventHandler(this.modalEffect_Timer_Tick);
            // 
            // ForgotPasswordDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 432);
            this.Controls.Add(this.panelContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ForgotPasswordDialogForm";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForgotPasswordDialogForm";
            this.Activated += new System.EventHandler(this.ForgotPasswordDialogForm_Activated);
            this.Load += new System.EventHandler(this.ForgotPasswordDialogForm_Load);
            this.ResizeEnd += new System.EventHandler(this.ForgotPasswordDialogForm_ResizeEnd);
            this.SizeChanged += new System.EventHandler(this.ForgotPasswordDialogForm_SizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ForgotPasswordDialogForm_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ForgotPasswordDialogForm_MouseDown);
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private RoundedButton SendEmailButton;
        private MaterialSkin.Controls.MaterialTextBox EmailTextbox;
        private System.Windows.Forms.Label BackLoginButton;
        private System.Windows.Forms.Timer modalEffect_Timer;
    }
}
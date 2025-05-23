namespace CAPSTONE_STOLE_ADMIN
{
    partial class LoginStallForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginStallForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.borderRadiusPanel1 = new CAPSTONE_STOLE_ADMIN.BorderRadiusPanel();
            this.borderRadiusPanel2 = new CAPSTONE_STOLE_ADMIN.BorderRadiusPanel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.GotoSignUpButton = new CAPSTONE_STOLE_ADMIN.RoundedButton();
            this.LoginButton = new CAPSTONE_STOLE_ADMIN.RoundedButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PasswordTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            this.EmailTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            this.ShowPasswordCheckBox = new System.Windows.Forms.CheckBox();
            this.ForgotPasswordLabel = new MaterialSkin.Controls.MaterialLabel();
            this.panel1.SuspendLayout();
            this.borderRadiusPanel1.SuspendLayout();
            this.borderRadiusPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.borderRadiusPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 592);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // borderRadiusPanel1
            // 
            this.borderRadiusPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("borderRadiusPanel1.BackgroundImage")));
            this.borderRadiusPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.borderRadiusPanel1.BorderColor = System.Drawing.Color.White;
            this.borderRadiusPanel1.BorderRadius = 15;
            this.borderRadiusPanel1.BorderSize = 7;
            this.borderRadiusPanel1.Controls.Add(this.borderRadiusPanel2);
            this.borderRadiusPanel1.Location = new System.Drawing.Point(12, 12);
            this.borderRadiusPanel1.Name = "borderRadiusPanel1";
            this.borderRadiusPanel1.Size = new System.Drawing.Size(976, 568);
            this.borderRadiusPanel1.TabIndex = 0;
            this.borderRadiusPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LoginStallForm_MouseDown);
            // 
            // borderRadiusPanel2
            // 
            this.borderRadiusPanel2.BackColor = System.Drawing.SystemColors.Window;
            this.borderRadiusPanel2.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.borderRadiusPanel2.BorderRadius = 20;
            this.borderRadiusPanel2.BorderSize = 12;
            this.borderRadiusPanel2.Controls.Add(this.materialLabel2);
            this.borderRadiusPanel2.Controls.Add(this.materialLabel1);
            this.borderRadiusPanel2.Controls.Add(this.GotoSignUpButton);
            this.borderRadiusPanel2.Controls.Add(this.LoginButton);
            this.borderRadiusPanel2.Controls.Add(this.pictureBox1);
            this.borderRadiusPanel2.Controls.Add(this.PasswordTextBox);
            this.borderRadiusPanel2.Controls.Add(this.EmailTextBox);
            this.borderRadiusPanel2.Controls.Add(this.ShowPasswordCheckBox);
            this.borderRadiusPanel2.Controls.Add(this.ForgotPasswordLabel);
            this.borderRadiusPanel2.Location = new System.Drawing.Point(92, 41);
            this.borderRadiusPanel2.Name = "borderRadiusPanel2";
            this.borderRadiusPanel2.Size = new System.Drawing.Size(364, 498);
            this.borderRadiusPanel2.TabIndex = 1;
            // 
            // materialLabel2
            // 
            this.materialLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption;
            this.materialLabel2.Location = new System.Drawing.Point(67, 162);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(230, 14);
            this.materialLabel2.TabIndex = 45;
            this.materialLabel2.Text = "Sign in by entering your information below";
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel1.Location = new System.Drawing.Point(84, 123);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(196, 29);
            this.materialLabel1.TabIndex = 44;
            this.materialLabel1.Text = "Get ready to Login";
            // 
            // GotoSignUpButton
            // 
            this.GotoSignUpButton.BackColor = System.Drawing.Color.White;
            this.GotoSignUpButton.FlatAppearance.BorderSize = 0;
            this.GotoSignUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GotoSignUpButton.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GotoSignUpButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GotoSignUpButton.Location = new System.Drawing.Point(52, 440);
            this.GotoSignUpButton.Name = "GotoSignUpButton";
            this.GotoSignUpButton.Padding = new System.Windows.Forms.Padding(4);
            this.GotoSignUpButton.Size = new System.Drawing.Size(251, 41);
            this.GotoSignUpButton.TabIndex = 5;
            this.GotoSignUpButton.Text = "Sign Up";
            this.GotoSignUpButton.UseVisualStyleBackColor = false;
            this.GotoSignUpButton.Click += new System.EventHandler(this.GotoSignUpButton_Click);
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.LoginButton.FlatAppearance.BorderSize = 0;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.ForeColor = System.Drawing.Color.White;
            this.LoginButton.Location = new System.Drawing.Point(52, 393);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Padding = new System.Windows.Forms.Padding(4);
            this.LoginButton.Size = new System.Drawing.Size(251, 41);
            this.LoginButton.TabIndex = 4;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(121, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.AnimateReadOnly = false;
            this.PasswordTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PasswordTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.PasswordTextBox.Depth = 0;
            this.PasswordTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.PasswordTextBox.HideSelection = true;
            this.PasswordTextBox.Hint = "Password";
            this.PasswordTextBox.LeadingIcon = ((System.Drawing.Image)(resources.GetObject("PasswordTextBox.LeadingIcon")));
            this.PasswordTextBox.Location = new System.Drawing.Point(52, 278);
            this.PasswordTextBox.MaxLength = 32767;
            this.PasswordTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.PrefixSuffixText = null;
            this.PasswordTextBox.ReadOnly = false;
            this.PasswordTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PasswordTextBox.SelectedText = "";
            this.PasswordTextBox.SelectionLength = 0;
            this.PasswordTextBox.SelectionStart = 0;
            this.PasswordTextBox.ShortcutsEnabled = true;
            this.PasswordTextBox.Size = new System.Drawing.Size(253, 48);
            this.PasswordTextBox.TabIndex = 2;
            this.PasswordTextBox.TabStop = false;
            this.PasswordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.PasswordTextBox.TrailingIcon = null;
            this.PasswordTextBox.UseAccent = false;
            this.PasswordTextBox.UseSystemPasswordChar = false;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.AnimateReadOnly = false;
            this.EmailTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.EmailTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.EmailTextBox.Depth = 0;
            this.EmailTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.EmailTextBox.HelperText = "@gmail.com";
            this.EmailTextBox.HideSelection = true;
            this.EmailTextBox.Hint = "Email";
            this.EmailTextBox.LeadingIcon = ((System.Drawing.Image)(resources.GetObject("EmailTextBox.LeadingIcon")));
            this.EmailTextBox.Location = new System.Drawing.Point(52, 206);
            this.EmailTextBox.MaxLength = 32767;
            this.EmailTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.PasswordChar = '\0';
            this.EmailTextBox.PrefixSuffixText = null;
            this.EmailTextBox.ReadOnly = false;
            this.EmailTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.EmailTextBox.SelectedText = "";
            this.EmailTextBox.SelectionLength = 0;
            this.EmailTextBox.SelectionStart = 0;
            this.EmailTextBox.ShortcutsEnabled = true;
            this.EmailTextBox.Size = new System.Drawing.Size(253, 48);
            this.EmailTextBox.TabIndex = 1;
            this.EmailTextBox.TabStop = false;
            this.EmailTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.EmailTextBox.TrailingIcon = null;
            this.EmailTextBox.UseAccent = false;
            this.EmailTextBox.UseSystemPasswordChar = false;
            // 
            // ShowPasswordCheckBox
            // 
            this.ShowPasswordCheckBox.AutoSize = true;
            this.ShowPasswordCheckBox.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowPasswordCheckBox.Location = new System.Drawing.Point(250, 332);
            this.ShowPasswordCheckBox.Name = "ShowPasswordCheckBox";
            this.ShowPasswordCheckBox.Size = new System.Drawing.Size(53, 17);
            this.ShowPasswordCheckBox.TabIndex = 3;
            this.ShowPasswordCheckBox.Text = "Show";
            this.ShowPasswordCheckBox.UseVisualStyleBackColor = true;
            this.ShowPasswordCheckBox.CheckedChanged += new System.EventHandler(this.ShowPasswordCheckBox_CheckedChanged);
            // 
            // ForgotPasswordLabel
            // 
            this.ForgotPasswordLabel.AutoSize = true;
            this.ForgotPasswordLabel.Depth = 0;
            this.ForgotPasswordLabel.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ForgotPasswordLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption;
            this.ForgotPasswordLabel.Location = new System.Drawing.Point(51, 332);
            this.ForgotPasswordLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.ForgotPasswordLabel.Name = "ForgotPasswordLabel";
            this.ForgotPasswordLabel.Size = new System.Drawing.Size(99, 14);
            this.ForgotPasswordLabel.TabIndex = 39;
            this.ForgotPasswordLabel.Text = "Forgot password?";
            this.ForgotPasswordLabel.Click += new System.EventHandler(this.ForgotPasswordLabel_Click);
            // 
            // LoginStallForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 592);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginStallForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginStallForm";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.LoginStallForm_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LoginStallForm_MouseDown);
            this.panel1.ResumeLayout(false);
            this.borderRadiusPanel1.ResumeLayout(false);
            this.borderRadiusPanel2.ResumeLayout(false);
            this.borderRadiusPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private BorderRadiusPanel borderRadiusPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private BorderRadiusPanel borderRadiusPanel2;
        private MaterialSkin.Controls.MaterialTextBox2 PasswordTextBox;
        private MaterialSkin.Controls.MaterialTextBox2 EmailTextBox;
        private System.Windows.Forms.CheckBox ShowPasswordCheckBox;
        private MaterialSkin.Controls.MaterialLabel ForgotPasswordLabel;
        private RoundedButton LoginButton;
        private RoundedButton GotoSignUpButton;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}
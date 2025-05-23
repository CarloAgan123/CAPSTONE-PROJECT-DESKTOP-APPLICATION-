namespace CAPSTONE_STOLE_ADMIN
{
    partial class UpdateProductForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateProductForm));
            this.label12 = new System.Windows.Forms.Label();
            this.BrowseProductPicture = new MaterialSkin.Controls.MaterialButton();
            this.label11 = new System.Windows.Forms.Label();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.AddProductImage = new CAPSTONE_STOLE_ADMIN.BorderRadiusPictureBox();
            this.TBAddProductName = new MaterialSkin.Controls.MaterialTextBox2();
            this.TBAddProductDescription = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.TBAddProductStocks = new MaterialSkin.Controls.MaterialTextBox2();
            this.TBAddProductPrice = new MaterialSkin.Controls.MaterialTextBox2();
            this.TBAddProductCategory = new MaterialSkin.Controls.MaterialComboBox();
            this.TBAddProductQualification = new MaterialSkin.Controls.MaterialComboBox();
            this.UpdateProductButton = new CAPSTONE_STOLE_ADMIN.RoundedButton();
            this.roundedButton1 = new CAPSTONE_STOLE_ADMIN.RoundedButton();
            this.modalEffect_Timer = new System.Windows.Forms.Timer(this.components);
            this.materialCard2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddProductImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DarkOrange;
            this.label12.Location = new System.Drawing.Point(242, 86);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(684, 54);
            this.label12.TabIndex = 60;
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
            this.BrowseProductPicture.Location = new System.Drawing.Point(956, 334);
            this.BrowseProductPicture.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BrowseProductPicture.MouseState = MaterialSkin.MouseState.HOVER;
            this.BrowseProductPicture.Name = "BrowseProductPicture";
            this.BrowseProductPicture.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BrowseProductPicture.Size = new System.Drawing.Size(84, 21);
            this.BrowseProductPicture.TabIndex = 57;
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
            this.label11.Location = new System.Drawing.Point(45, 86);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(136, 36);
            this.label11.TabIndex = 59;
            this.label11.Text = "Products";
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.AddProductImage);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(873, 170);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(248, 175);
            this.materialCard2.TabIndex = 56;
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
            this.TBAddProductName.Location = new System.Drawing.Point(48, 170);
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
            this.TBAddProductName.TabIndex = 55;
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
            this.TBAddProductDescription.Location = new System.Drawing.Point(322, 236);
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
            this.TBAddProductDescription.TabIndex = 54;
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
            this.TBAddProductStocks.Location = new System.Drawing.Point(49, 298);
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
            this.TBAddProductStocks.TabIndex = 53;
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
            this.TBAddProductPrice.Location = new System.Drawing.Point(49, 235);
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
            this.TBAddProductPrice.TabIndex = 52;
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
            this.TBAddProductCategory.Location = new System.Drawing.Point(322, 170);
            this.TBAddProductCategory.MaxDropDownItems = 4;
            this.TBAddProductCategory.MouseState = MaterialSkin.MouseState.OUT;
            this.TBAddProductCategory.Name = "TBAddProductCategory";
            this.TBAddProductCategory.Size = new System.Drawing.Size(250, 49);
            this.TBAddProductCategory.StartIndex = 1;
            this.TBAddProductCategory.TabIndex = 51;
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
            this.TBAddProductQualification.Location = new System.Drawing.Point(596, 170);
            this.TBAddProductQualification.MaxDropDownItems = 4;
            this.TBAddProductQualification.MouseState = MaterialSkin.MouseState.OUT;
            this.TBAddProductQualification.Name = "TBAddProductQualification";
            this.TBAddProductQualification.Size = new System.Drawing.Size(250, 49);
            this.TBAddProductQualification.StartIndex = 1;
            this.TBAddProductQualification.TabIndex = 50;
            this.TBAddProductQualification.UseAccent = false;
            // 
            // UpdateProductButton
            // 
            this.UpdateProductButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.UpdateProductButton.FlatAppearance.BorderSize = 0;
            this.UpdateProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateProductButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateProductButton.ForeColor = System.Drawing.Color.White;
            this.UpdateProductButton.Image = global::CAPSTONE_STOLE_ADMIN.Properties.Resources.box__1_;
            this.UpdateProductButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UpdateProductButton.Location = new System.Drawing.Point(586, 370);
            this.UpdateProductButton.Name = "UpdateProductButton";
            this.UpdateProductButton.Padding = new System.Windows.Forms.Padding(4);
            this.UpdateProductButton.Size = new System.Drawing.Size(162, 43);
            this.UpdateProductButton.TabIndex = 58;
            this.UpdateProductButton.Text = "Update";
            this.UpdateProductButton.UseVisualStyleBackColor = false;
            this.UpdateProductButton.Click += new System.EventHandler(this.UpdateProductButton_Click);
            // 
            // roundedButton1
            // 
            this.roundedButton1.BackColor = System.Drawing.Color.Gray;
            this.roundedButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.roundedButton1.FlatAppearance.BorderSize = 0;
            this.roundedButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButton1.ForeColor = System.Drawing.Color.White;
            this.roundedButton1.Image = global::CAPSTONE_STOLE_ADMIN.Properties.Resources.icons8_cancel_28;
            this.roundedButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roundedButton1.Location = new System.Drawing.Point(418, 370);
            this.roundedButton1.Name = "roundedButton1";
            this.roundedButton1.Padding = new System.Windows.Forms.Padding(4);
            this.roundedButton1.Size = new System.Drawing.Size(162, 43);
            this.roundedButton1.TabIndex = 61;
            this.roundedButton1.Text = "Cancel";
            this.roundedButton1.UseVisualStyleBackColor = false;
            // 
            // modalEffect_Timer
            // 
            this.modalEffect_Timer.Enabled = true;
            this.modalEffect_Timer.Interval = 1;
            this.modalEffect_Timer.Tick += new System.EventHandler(this.modalEffect_Timer_Tick);
            // 
            // UpdateProductForm
            // 
            this.AcceptButton = this.UpdateProductButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.roundedButton1;
            this.ClientSize = new System.Drawing.Size(1166, 499);
            this.Controls.Add(this.roundedButton1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.BrowseProductPicture);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.materialCard2);
            this.Controls.Add(this.TBAddProductName);
            this.Controls.Add(this.TBAddProductDescription);
            this.Controls.Add(this.TBAddProductStocks);
            this.Controls.Add(this.TBAddProductPrice);
            this.Controls.Add(this.TBAddProductCategory);
            this.Controls.Add(this.TBAddProductQualification);
            this.Controls.Add(this.UpdateProductButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpdateProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateProductForm";
            this.Load += new System.EventHandler(this.UpdateProductForm_Load);
            this.materialCard2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AddProductImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private MaterialSkin.Controls.MaterialButton BrowseProductPicture;
        private System.Windows.Forms.Label label11;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private BorderRadiusPictureBox AddProductImage;
        private MaterialSkin.Controls.MaterialTextBox2 TBAddProductName;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 TBAddProductDescription;
        private MaterialSkin.Controls.MaterialTextBox2 TBAddProductStocks;
        private MaterialSkin.Controls.MaterialTextBox2 TBAddProductPrice;
        private MaterialSkin.Controls.MaterialComboBox TBAddProductCategory;
        private MaterialSkin.Controls.MaterialComboBox TBAddProductQualification;
        private RoundedButton UpdateProductButton;
        private RoundedButton roundedButton1;
        private System.Windows.Forms.Timer modalEffect_Timer;
    }
}
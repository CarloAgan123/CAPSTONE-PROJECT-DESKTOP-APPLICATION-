namespace CAPSTONE_STOLE_ADMIN
{
    partial class AlertForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlertForm));
            this.textAlertTitle = new System.Windows.Forms.Label();
            this.picAlertBox = new System.Windows.Forms.PictureBox();
            this.textAlertMessage = new System.Windows.Forms.Label();
            this.panelAlertBox = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picAlertBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textAlertTitle
            // 
            this.textAlertTitle.AutoSize = true;
            this.textAlertTitle.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAlertTitle.Location = new System.Drawing.Point(87, 23);
            this.textAlertTitle.Name = "textAlertTitle";
            this.textAlertTitle.Size = new System.Drawing.Size(113, 22);
            this.textAlertTitle.TabIndex = 0;
            this.textAlertTitle.Text = "TextAlerTitle";
            this.textAlertTitle.Click += new System.EventHandler(this.textAlertTitle_Click);
            // 
            // picAlertBox
            // 
            this.picAlertBox.Location = new System.Drawing.Point(24, 14);
            this.picAlertBox.Name = "picAlertBox";
            this.picAlertBox.Size = new System.Drawing.Size(57, 52);
            this.picAlertBox.TabIndex = 1;
            this.picAlertBox.TabStop = false;
            // 
            // textAlertMessage
            // 
            this.textAlertMessage.AutoSize = true;
            this.textAlertMessage.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAlertMessage.Location = new System.Drawing.Point(88, 45);
            this.textAlertMessage.Name = "textAlertMessage";
            this.textAlertMessage.Size = new System.Drawing.Size(116, 17);
            this.textAlertMessage.TabIndex = 2;
            this.textAlertMessage.Text = "TextAlertMessage";
            this.textAlertMessage.Click += new System.EventHandler(this.textAlertMessage_Click);
            // 
            // panelAlertBox
            // 
            this.panelAlertBox.BackColor = System.Drawing.Color.Black;
            this.panelAlertBox.Location = new System.Drawing.Point(0, 73);
            this.panelAlertBox.Name = "panelAlertBox";
            this.panelAlertBox.Size = new System.Drawing.Size(5, 6);
            this.panelAlertBox.TabIndex = 3;
            this.panelAlertBox.Paint += new System.Windows.Forms.PaintEventHandler(this.panelAlertBox_Paint);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(482, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 16);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // AlertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(500, 80);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelAlertBox);
            this.Controls.Add(this.textAlertMessage);
            this.Controls.Add(this.picAlertBox);
            this.Controls.Add(this.textAlertTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AlertForm";
            this.Text = "AlertForm";
            this.Load += new System.EventHandler(this.AlertForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picAlertBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label textAlertTitle;
        private System.Windows.Forms.PictureBox picAlertBox;
        private System.Windows.Forms.Label textAlertMessage;
        private System.Windows.Forms.Panel panelAlertBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
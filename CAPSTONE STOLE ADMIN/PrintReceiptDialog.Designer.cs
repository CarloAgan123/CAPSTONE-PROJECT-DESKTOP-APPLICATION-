namespace CAPSTONE_STOLE_ADMIN
{
    partial class PrintReceiptDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintReceiptDialog));
            this.PrintReceiptButton = new CAPSTONE_STOLE_ADMIN.RoundedButton();
            this.label1 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.roundedButton1 = new CAPSTONE_STOLE_ADMIN.RoundedButton();
            this.modalEffect_Timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // PrintReceiptButton
            // 
            this.PrintReceiptButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.PrintReceiptButton.FlatAppearance.BorderSize = 0;
            this.PrintReceiptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrintReceiptButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintReceiptButton.ForeColor = System.Drawing.Color.White;
            this.PrintReceiptButton.Location = new System.Drawing.Point(110, 64);
            this.PrintReceiptButton.Name = "PrintReceiptButton";
            this.PrintReceiptButton.Padding = new System.Windows.Forms.Padding(4);
            this.PrintReceiptButton.Size = new System.Drawing.Size(195, 50);
            this.PrintReceiptButton.TabIndex = 0;
            this.PrintReceiptButton.Text = "Print Receipt";
            this.PrintReceiptButton.UseVisualStyleBackColor = false;
            this.PrintReceiptButton.Click += new System.EventHandler(this.PrintReceiptButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(96, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "RECEIPT PRINTING";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // roundedButton1
            // 
            this.roundedButton1.BackColor = System.Drawing.Color.Black;
            this.roundedButton1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.roundedButton1.FlatAppearance.BorderSize = 0;
            this.roundedButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButton1.ForeColor = System.Drawing.Color.White;
            this.roundedButton1.Location = new System.Drawing.Point(110, 120);
            this.roundedButton1.Name = "roundedButton1";
            this.roundedButton1.Padding = new System.Windows.Forms.Padding(4);
            this.roundedButton1.Size = new System.Drawing.Size(195, 50);
            this.roundedButton1.TabIndex = 3;
            this.roundedButton1.Text = "Back";
            this.roundedButton1.UseVisualStyleBackColor = false;
            // 
            // modalEffect_Timer
            // 
            this.modalEffect_Timer.Enabled = true;
            this.modalEffect_Timer.Interval = 1;
            this.modalEffect_Timer.Tick += new System.EventHandler(this.modalEffect_Timer_Tick);
            // 
            // PrintReceiptDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(413, 192);
            this.ControlBox = false;
            this.Controls.Add(this.roundedButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PrintReceiptButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PrintReceiptDialog";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PrintReceiptDialog";
            this.Load += new System.EventHandler(this.PrintReceiptDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RoundedButton PrintReceiptButton;
        private System.Windows.Forms.Label label1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private RoundedButton roundedButton1;
        private System.Windows.Forms.Timer modalEffect_Timer;
    }
}
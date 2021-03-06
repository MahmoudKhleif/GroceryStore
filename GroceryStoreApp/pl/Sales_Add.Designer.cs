
namespace GroceryStoreApp.pl
{
    partial class Sales_Add
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sales_Add));
            this.BuyerID = new System.Windows.Forms.ComboBox();
            this.ProductID = new System.Windows.Forms.ComboBox();
            this.textDate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textThetotalAmont = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Add = new DevExpress.XtraEditors.SimpleButton();
            this.closebutton = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.TextsellerId = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // BuyerID
            // 
            this.BuyerID.FormattingEnabled = true;
            this.BuyerID.Location = new System.Drawing.Point(78, 171);
            this.BuyerID.Name = "BuyerID";
            this.BuyerID.Size = new System.Drawing.Size(187, 24);
            this.BuyerID.TabIndex = 43;
            // 
            // ProductID
            // 
            this.ProductID.FormattingEnabled = true;
            this.ProductID.Location = new System.Drawing.Point(78, 232);
            this.ProductID.Name = "ProductID";
            this.ProductID.Size = new System.Drawing.Size(187, 24);
            this.ProductID.TabIndex = 44;
            // 
            // textDate
            // 
            this.textDate.Location = new System.Drawing.Point(78, 384);
            this.textDate.Multiline = true;
            this.textDate.Name = "textDate";
            this.textDate.Size = new System.Drawing.Size(187, 45);
            this.textDate.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(301, 384);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 37);
            this.label5.TabIndex = 37;
            this.label5.Text = "DATE";
            // 
            // textThetotalAmont
            // 
            this.textThetotalAmont.Location = new System.Drawing.Point(78, 302);
            this.textThetotalAmont.Multiline = true;
            this.textThetotalAmont.Name = "textThetotalAmont";
            this.textThetotalAmont.Size = new System.Drawing.Size(187, 45);
            this.textThetotalAmont.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(291, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(242, 37);
            this.label4.TabIndex = 38;
            this.label4.Text = "TheTotalAmount";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(316, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 37);
            this.label2.TabIndex = 39;
            this.label2.Text = "BuyerID";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(316, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 37);
            this.label1.TabIndex = 40;
            this.label1.Text = "ProductID";
            // 
            // Add
            // 
            this.Add.Appearance.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Add.Appearance.Options.UseFont = true;
            this.Add.Appearance.Options.UseForeColor = true;
            this.Add.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Add.ImageOptions.Image")));
            this.Add.Location = new System.Drawing.Point(368, 499);
            this.Add.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(240, 87);
            this.Add.TabIndex = 45;
            this.Add.Text = "Save";
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // closebutton
            // 
            this.closebutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closebutton.Appearance.Font = new System.Drawing.Font("Times New Roman", 7.8F);
            this.closebutton.Appearance.Options.UseFont = true;
            this.closebutton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("closebutton.ImageOptions.Image")));
            this.closebutton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.closebutton.Location = new System.Drawing.Point(533, 1);
            this.closebutton.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.closebutton.Name = "closebutton";
            this.closebutton.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.closebutton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.closebutton.Size = new System.Drawing.Size(75, 84);
            this.closebutton.TabIndex = 46;
            this.closebutton.Click += new System.EventHandler(this.closebutton_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(316, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 37);
            this.label3.TabIndex = 40;
            this.label3.Text = "SellerID";
            // 
            // TextsellerId
            // 
            this.TextsellerId.FormattingEnabled = true;
            this.TextsellerId.Location = new System.Drawing.Point(78, 105);
            this.TextsellerId.Name = "TextsellerId";
            this.TextsellerId.Size = new System.Drawing.Size(187, 24);
            this.TextsellerId.TabIndex = 44;
            // 
            // Sales_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(610, 593);
            this.Controls.Add(this.closebutton);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.BuyerID);
            this.Controls.Add(this.TextsellerId);
            this.Controls.Add(this.ProductID);
            this.Controls.Add(this.textDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textThetotalAmont);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Sales_Add";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales_Add";
            this.Activated += new System.EventHandler(this.Sales_Add_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox textDate;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox textThetotalAmont;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton Add;
        private DevExpress.XtraEditors.SimpleButton closebutton;
        public System.Windows.Forms.ComboBox ProductID;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox TextsellerId;
        public System.Windows.Forms.ComboBox BuyerID;
    }
}
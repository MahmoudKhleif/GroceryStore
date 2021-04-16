
namespace GroceryStoreApp.pl
{
    partial class Product_Add
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Product_Add));
            this.textExpirationDate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textProductionDate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textprice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Add = new DevExpress.XtraEditors.SimpleButton();
            this.closebutton = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // textExpirationDate
            // 
            this.textExpirationDate.Location = new System.Drawing.Point(62, 361);
            this.textExpirationDate.Multiline = true;
            this.textExpirationDate.Name = "textExpirationDate";
            this.textExpirationDate.Size = new System.Drawing.Size(187, 45);
            this.textExpirationDate.TabIndex = 55;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(264, 369);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(216, 37);
            this.label5.TabIndex = 50;
            this.label5.Text = "ExpirationDate";
            // 
            // textProductionDate
            // 
            this.textProductionDate.Location = new System.Drawing.Point(62, 286);
            this.textProductionDate.Multiline = true;
            this.textProductionDate.Name = "textProductionDate";
            this.textProductionDate.Size = new System.Drawing.Size(187, 45);
            this.textProductionDate.TabIndex = 56;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(264, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 37);
            this.label4.TabIndex = 51;
            this.label4.Text = "ProductionDate";
            // 
            // textprice
            // 
            this.textprice.Location = new System.Drawing.Point(62, 220);
            this.textprice.Multiline = true;
            this.textprice.Name = "textprice";
            this.textprice.Size = new System.Drawing.Size(187, 45);
            this.textprice.TabIndex = 57;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(270, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 37);
            this.label2.TabIndex = 52;
            this.label2.Text = "Price";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(62, 146);
            this.textName.Multiline = true;
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(187, 45);
            this.textName.TabIndex = 58;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(270, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 37);
            this.label1.TabIndex = 53;
            this.label1.Text = "Name";
            // 
            // Add
            // 
            this.Add.Appearance.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Add.Appearance.Options.UseFont = true;
            this.Add.Appearance.Options.UseForeColor = true;
            this.Add.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Add.ImageOptions.Image")));
            this.Add.Location = new System.Drawing.Point(400, 480);
            this.Add.Margin = new System.Windows.Forms.Padding(6);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(177, 51);
            this.Add.TabIndex = 59;
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
            this.closebutton.Location = new System.Drawing.Point(520, 2);
            this.closebutton.Margin = new System.Windows.Forms.Padding(6);
            this.closebutton.Name = "closebutton";
            this.closebutton.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.closebutton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.closebutton.Size = new System.Drawing.Size(69, 79);
            this.closebutton.TabIndex = 48;
            this.closebutton.Click += new System.EventHandler(this.closebutton_Click);
            // 
            // Product_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(592, 546);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.textExpirationDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textProductionDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textprice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.closebutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Product_Add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product_Add";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public DevExpress.XtraEditors.SimpleButton Add;
        public System.Windows.Forms.TextBox textExpirationDate;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox textProductionDate;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox textprice;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton closebutton;
    }
}
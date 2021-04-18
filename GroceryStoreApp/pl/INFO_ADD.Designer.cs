
namespace GroceryStoreApp.pl
{
    partial class INFO_ADD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(INFO_ADD));
            this.AdminID = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textPassWord = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textUserName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Add = new DevExpress.XtraEditors.SimpleButton();
            this.closebutton = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // AdminID
            // 
            this.AdminID.FormattingEnabled = true;
            this.AdminID.Location = new System.Drawing.Point(62, 120);
            this.AdminID.Name = "AdminID";
            this.AdminID.Size = new System.Drawing.Size(187, 24);
            this.AdminID.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(285, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 37);
            this.label2.TabIndex = 44;
            this.label2.Text = "AdminID";
            // 
            // textPassWord
            // 
            this.textPassWord.Location = new System.Drawing.Point(62, 267);
            this.textPassWord.Multiline = true;
            this.textPassWord.Name = "textPassWord";
            this.textPassWord.Size = new System.Drawing.Size(187, 45);
            this.textPassWord.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(285, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 37);
            this.label5.TabIndex = 46;
            this.label5.Text = "Password";
            // 
            // textUserName
            // 
            this.textUserName.Location = new System.Drawing.Point(62, 185);
            this.textUserName.Multiline = true;
            this.textUserName.Name = "textUserName";
            this.textUserName.Size = new System.Drawing.Size(187, 45);
            this.textUserName.TabIndex = 49;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(275, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 37);
            this.label4.TabIndex = 47;
            this.label4.Text = "UserName";
            // 
            // Add
            // 
            this.Add.Appearance.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Add.Appearance.Options.UseFont = true;
            this.Add.Appearance.Options.UseForeColor = true;
            this.Add.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Add.ImageOptions.Image")));
            this.Add.Location = new System.Drawing.Point(277, 477);
            this.Add.Margin = new System.Windows.Forms.Padding(8);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(240, 87);
            this.Add.TabIndex = 50;
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
            this.closebutton.Location = new System.Drawing.Point(465, 2);
            this.closebutton.Margin = new System.Windows.Forms.Padding(8);
            this.closebutton.Name = "closebutton";
            this.closebutton.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.closebutton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.closebutton.Size = new System.Drawing.Size(52, 49);
            this.closebutton.TabIndex = 51;
            this.closebutton.Click += new System.EventHandler(this.closebutton_Click);
            // 
            // INFO_ADD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(524, 572);
            this.Controls.Add(this.closebutton);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.textPassWord);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textUserName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AdminID);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "INFO_ADD";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INFO_ADD";
            this.Activated += new System.EventHandler(this.INFO_ADD_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox AdminID;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox textPassWord;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox textUserName;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SimpleButton Add;
        private DevExpress.XtraEditors.SimpleButton closebutton;
    }
}
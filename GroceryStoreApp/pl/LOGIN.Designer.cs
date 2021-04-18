
namespace GroceryStoreApp.pl
{
    partial class LOGIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LOGIN));
            this.textPassWord = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textUserName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.closebutton = new DevExpress.XtraEditors.SimpleButton();
            this.Add = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // textPassWord
            // 
            this.textPassWord.Location = new System.Drawing.Point(12, 223);
            this.textPassWord.Multiline = true;
            this.textPassWord.Name = "textPassWord";
            this.textPassWord.Size = new System.Drawing.Size(273, 45);
            this.textPassWord.TabIndex = 53;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(359, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 37);
            this.label5.TabIndex = 51;
            this.label5.Text = "Password";
            // 
            // textUserName
            // 
            this.textUserName.Location = new System.Drawing.Point(12, 130);
            this.textUserName.Multiline = true;
            this.textUserName.Name = "textUserName";
            this.textUserName.Size = new System.Drawing.Size(273, 45);
            this.textUserName.TabIndex = 54;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(339, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 37);
            this.label4.TabIndex = 52;
            this.label4.Text = "UserName";
            // 
            // closebutton
            // 
            this.closebutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closebutton.Appearance.Font = new System.Drawing.Font("Times New Roman", 7.8F);
            this.closebutton.Appearance.Options.UseFont = true;
            this.closebutton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("closebutton.ImageOptions.Image")));
            this.closebutton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.closebutton.Location = new System.Drawing.Point(464, -1);
            this.closebutton.Margin = new System.Windows.Forms.Padding(8);
            this.closebutton.Name = "closebutton";
            this.closebutton.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.closebutton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.closebutton.Size = new System.Drawing.Size(52, 49);
            this.closebutton.TabIndex = 56;
            this.closebutton.Click += new System.EventHandler(this.closebutton_Click);
            // 
            // Add
            // 
            this.Add.Appearance.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Add.Appearance.Options.UseFont = true;
            this.Add.Appearance.Options.UseForeColor = true;
            this.Add.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Add.ImageOptions.Image")));
            this.Add.Location = new System.Drawing.Point(12, 346);
            this.Add.Margin = new System.Windows.Forms.Padding(8);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(498, 59);
            this.Add.TabIndex = 55;
            this.Add.Text = "Log in";
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.ForeColor = System.Drawing.Color.Black;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Appearance.Options.UseForeColor = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(12, 421);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(8);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(498, 59);
            this.simpleButton1.TabIndex = 55;
            this.simpleButton1.Text = "Register";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // LOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(519, 513);
            this.Controls.Add(this.closebutton);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.textPassWord);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textUserName);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LOGIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton Add;
        public System.Windows.Forms.TextBox textPassWord;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox textUserName;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SimpleButton closebutton;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}
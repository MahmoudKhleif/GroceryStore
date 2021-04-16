
namespace GroceryStoreApp.pl
{
    partial class Supplier_FORM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Supplier_FORM));
            this.SUPP_PANEL = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFirstName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_search = new DevExpress.XtraEditors.SimpleButton();
            this.text_search = new System.Windows.Forms.TextBox();
            this.Refresh = new DevExpress.XtraEditors.SimpleButton();
            this.Delete = new DevExpress.XtraEditors.SimpleButton();
            this.Edit = new DevExpress.XtraEditors.SimpleButton();
            this.Add = new DevExpress.XtraEditors.SimpleButton();
            this.SUPP_PANEL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SUPP_PANEL
            // 
            this.SUPP_PANEL.Controls.Add(this.gridControl1);
            this.SUPP_PANEL.Controls.Add(this.panel1);
            this.SUPP_PANEL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SUPP_PANEL.Location = new System.Drawing.Point(0, 0);
            this.SUPP_PANEL.Name = "SUPP_PANEL";
            this.SUPP_PANEL.Size = new System.Drawing.Size(949, 512);
            this.SUPP_PANEL.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = typeof(GroceryStoreApp.TB_Suppliers);
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(949, 426);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colFirstName,
            this.colLastName,
            this.colEmail,
            this.colPhone,
            this.colAddress});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.MinWidth = 25;
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            this.colID.Width = 94;
            // 
            // colFirstName
            // 
            this.colFirstName.FieldName = "FirstName";
            this.colFirstName.MinWidth = 25;
            this.colFirstName.Name = "colFirstName";
            this.colFirstName.Visible = true;
            this.colFirstName.VisibleIndex = 1;
            this.colFirstName.Width = 94;
            // 
            // colLastName
            // 
            this.colLastName.FieldName = "LastName";
            this.colLastName.MinWidth = 25;
            this.colLastName.Name = "colLastName";
            this.colLastName.Visible = true;
            this.colLastName.VisibleIndex = 2;
            this.colLastName.Width = 94;
            // 
            // colEmail
            // 
            this.colEmail.FieldName = "Email";
            this.colEmail.MinWidth = 25;
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 3;
            this.colEmail.Width = 94;
            // 
            // colPhone
            // 
            this.colPhone.FieldName = "Phone";
            this.colPhone.MinWidth = 25;
            this.colPhone.Name = "colPhone";
            this.colPhone.Visible = true;
            this.colPhone.VisibleIndex = 4;
            this.colPhone.Width = 94;
            // 
            // colAddress
            // 
            this.colAddress.FieldName = "Address";
            this.colAddress.MinWidth = 25;
            this.colAddress.Name = "colAddress";
            this.colAddress.Visible = true;
            this.colAddress.VisibleIndex = 5;
            this.colAddress.Width = 94;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.btn_search);
            this.panel1.Controls.Add(this.text_search);
            this.panel1.Controls.Add(this.Refresh);
            this.panel1.Controls.Add(this.Delete);
            this.panel1.Controls.Add(this.Edit);
            this.panel1.Controls.Add(this.Add);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 426);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(949, 86);
            this.panel1.TabIndex = 0;
            // 
            // btn_search
            // 
            this.btn_search.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btn_search.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_search.ImageOptions.SvgImage")));
            this.btn_search.Location = new System.Drawing.Point(880, 13);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(59, 61);
            this.btn_search.TabIndex = 8;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // text_search
            // 
            this.text_search.Location = new System.Drawing.Point(645, 29);
            this.text_search.Multiline = true;
            this.text_search.Name = "text_search";
            this.text_search.Size = new System.Drawing.Size(243, 34);
            this.text_search.TabIndex = 7;
            // 
            // Refresh
            // 
            this.Refresh.Appearance.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Refresh.Appearance.Options.UseFont = true;
            this.Refresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Refresh.ImageOptions.Image")));
            this.Refresh.Location = new System.Drawing.Point(460, 13);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(155, 61);
            this.Refresh.TabIndex = 3;
            this.Refresh.Text = "Refresh";
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // Delete
            // 
            this.Delete.Appearance.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.Appearance.Options.UseFont = true;
            this.Delete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Delete.ImageOptions.Image")));
            this.Delete.Location = new System.Drawing.Point(296, 13);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(140, 61);
            this.Delete.TabIndex = 4;
            this.Delete.Text = "Delete";
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Edit
            // 
            this.Edit.Appearance.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit.Appearance.Options.UseFont = true;
            this.Edit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Edit.ImageOptions.Image")));
            this.Edit.Location = new System.Drawing.Point(153, 13);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(119, 61);
            this.Edit.TabIndex = 5;
            this.Edit.Text = "Edit";
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Add
            // 
            this.Add.Appearance.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.Appearance.Options.UseFont = true;
            this.Add.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Add.ImageOptions.Image")));
            this.Add.Location = new System.Drawing.Point(10, 13);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(119, 61);
            this.Add.TabIndex = 6;
            this.Add.Text = "Add";
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Supplier_FORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(949, 512);
            this.Controls.Add(this.SUPP_PANEL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Supplier_FORM";
            this.Text = "Supplier_FORM";
            this.SUPP_PANEL.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel SUPP_PANEL;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        public DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraEditors.SimpleButton btn_search;
        private System.Windows.Forms.TextBox text_search;
        private DevExpress.XtraEditors.SimpleButton Refresh;
        private DevExpress.XtraEditors.SimpleButton Delete;
        private DevExpress.XtraEditors.SimpleButton Edit;
        private DevExpress.XtraEditors.SimpleButton Add;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colFirstName;
        private DevExpress.XtraGrid.Columns.GridColumn colLastName;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colPhone;
        private DevExpress.XtraGrid.Columns.GridColumn colAddress;
    }
}
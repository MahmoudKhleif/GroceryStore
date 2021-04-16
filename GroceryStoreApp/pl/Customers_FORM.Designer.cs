
namespace GroceryStoreApp.pl
{
    partial class Customers_FORM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customers_FORM));
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gorceryStoreDataSet11 = new GroceryStoreApp.GorceryStoreDataSet1();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_search = new DevExpress.XtraEditors.SimpleButton();
            this.text_search = new System.Windows.Forms.TextBox();
            this.Refresh = new DevExpress.XtraEditors.SimpleButton();
            this.Delete = new DevExpress.XtraEditors.SimpleButton();
            this.Edit = new DevExpress.XtraEditors.SimpleButton();
            this.Add = new DevExpress.XtraEditors.SimpleButton();
            this.gorceryStoreDataSet1 = new GroceryStoreApp.GorceryStoreDataSet1();
            this.tBCustomerrBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tB_CustomerrTableAdapter = new GroceryStoreApp.GorceryStoreDataSet1TableAdapters.TB_CustomerrTableAdapter();
            this.tB_CustomerrTableAdapter1 = new GroceryStoreApp.GorceryStoreDataSet1TableAdapters.TB_CustomerrTableAdapter();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFirstName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gorceryStoreDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gorceryStoreDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBCustomerrBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridControl1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(931, 465);
            this.panel1.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = typeof(GroceryStoreApp.TB_Customer2);
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(4);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(931, 365);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gorceryStoreDataSet11
            // 
            this.gorceryStoreDataSet11.DataSetName = "GorceryStoreDataSet1";
            this.gorceryStoreDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colFirstName,
            this.colLastName,
            this.colEmail,
            this.colAddress,
            this.colPhone});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_search);
            this.panel2.Controls.Add(this.text_search);
            this.panel2.Controls.Add(this.Refresh);
            this.panel2.Controls.Add(this.Delete);
            this.panel2.Controls.Add(this.Edit);
            this.panel2.Controls.Add(this.Add);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 365);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(931, 100);
            this.panel2.TabIndex = 0;
            // 
            // btn_search
            // 
            this.btn_search.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btn_search.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_search.ImageOptions.SvgImage")));
            this.btn_search.Location = new System.Drawing.Point(834, 11);
            this.btn_search.Margin = new System.Windows.Forms.Padding(4);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(74, 76);
            this.btn_search.TabIndex = 18;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // text_search
            // 
            this.text_search.Location = new System.Drawing.Point(594, 35);
            this.text_search.Multiline = true;
            this.text_search.Name = "text_search";
            this.text_search.Size = new System.Drawing.Size(243, 34);
            this.text_search.TabIndex = 17;
            // 
            // Refresh
            // 
            this.Refresh.Appearance.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Refresh.Appearance.Options.UseFont = true;
            this.Refresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Refresh.ImageOptions.Image")));
            this.Refresh.Location = new System.Drawing.Point(408, 12);
            this.Refresh.Margin = new System.Windows.Forms.Padding(4);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(170, 76);
            this.Refresh.TabIndex = 16;
            this.Refresh.Text = "Refresh";
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // Delete
            // 
            this.Delete.Appearance.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.Appearance.Options.UseFont = true;
            this.Delete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Delete.ImageOptions.Image")));
            this.Delete.Location = new System.Drawing.Point(259, 12);
            this.Delete.Margin = new System.Windows.Forms.Padding(4);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(137, 76);
            this.Delete.TabIndex = 15;
            this.Delete.Text = "Delete";
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Edit
            // 
            this.Edit.Appearance.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit.Appearance.Options.UseFont = true;
            this.Edit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Edit.ImageOptions.Image")));
            this.Edit.Location = new System.Drawing.Point(141, 12);
            this.Edit.Margin = new System.Windows.Forms.Padding(4);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(106, 76);
            this.Edit.TabIndex = 14;
            this.Edit.Text = "Edit";
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Add
            // 
            this.Add.Appearance.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.Appearance.Options.UseFont = true;
            this.Add.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Add.ImageOptions.Image")));
            this.Add.Location = new System.Drawing.Point(13, 11);
            this.Add.Margin = new System.Windows.Forms.Padding(4);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(116, 76);
            this.Add.TabIndex = 13;
            this.Add.Text = "Add";
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // gorceryStoreDataSet1
            // 
            this.gorceryStoreDataSet1.DataSetName = "GorceryStoreDataSet1";
            this.gorceryStoreDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBCustomerrBindingSource
            // 
            this.tBCustomerrBindingSource.DataMember = "TB_Customerr";
            this.tBCustomerrBindingSource.DataSource = this.gorceryStoreDataSet1;
            // 
            // tB_CustomerrTableAdapter
            // 
            this.tB_CustomerrTableAdapter.ClearBeforeFill = true;
            // 
            // tB_CustomerrTableAdapter1
            // 
            this.tB_CustomerrTableAdapter1.ClearBeforeFill = true;
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
            // colAddress
            // 
            this.colAddress.FieldName = "Address";
            this.colAddress.MinWidth = 25;
            this.colAddress.Name = "colAddress";
            this.colAddress.Visible = true;
            this.colAddress.VisibleIndex = 4;
            this.colAddress.Width = 94;
            // 
            // colPhone
            // 
            this.colPhone.FieldName = "Phone";
            this.colPhone.MinWidth = 25;
            this.colPhone.Name = "colPhone";
            this.colPhone.Visible = true;
            this.colPhone.VisibleIndex = 5;
            this.colPhone.Width = 94;
            // 
            // Customers_FORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 465);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Customers_FORM";
            this.Text = "Customers_FORM";
            this.Load += new System.EventHandler(this.Customers_FORM_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gorceryStoreDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gorceryStoreDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBCustomerrBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        public DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraEditors.SimpleButton Add;
        private DevExpress.XtraEditors.SimpleButton Edit;
        private DevExpress.XtraEditors.SimpleButton Delete;
        private DevExpress.XtraEditors.SimpleButton Refresh;
        private DevExpress.XtraEditors.SimpleButton btn_search;
        private System.Windows.Forms.TextBox text_search;
        private GorceryStoreDataSet1 gorceryStoreDataSet1;
        private System.Windows.Forms.BindingSource tBCustomerrBindingSource;
        private GorceryStoreDataSet1TableAdapters.TB_CustomerrTableAdapter tB_CustomerrTableAdapter;
        private GorceryStoreDataSet1 gorceryStoreDataSet11;
        private GorceryStoreDataSet1TableAdapters.TB_CustomerrTableAdapter tB_CustomerrTableAdapter1;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colFirstName;
        private DevExpress.XtraGrid.Columns.GridColumn colLastName;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colPhone;
    }
}
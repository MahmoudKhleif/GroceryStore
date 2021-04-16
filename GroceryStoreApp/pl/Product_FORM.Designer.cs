
namespace GroceryStoreApp.pl
{
    partial class Product_FORM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Product_FORM));
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductionsDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExpirationDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_search = new DevExpress.XtraEditors.SimpleButton();
            this.text_search = new System.Windows.Forms.TextBox();
            this.Refresh = new DevExpress.XtraEditors.SimpleButton();
            this.Delete = new DevExpress.XtraEditors.SimpleButton();
            this.Edit = new DevExpress.XtraEditors.SimpleButton();
            this.Add = new DevExpress.XtraEditors.SimpleButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel2.SuspendLayout();
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
            this.gridControl1.DataSource = typeof(GroceryStoreApp.TB_Productt);
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(931, 365);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colName,
            this.colPrice,
            this.colProductionsDate,
            this.colExpirationDate});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
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
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.MinWidth = 25;
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            this.colName.Width = 94;
            // 
            // colPrice
            // 
            this.colPrice.FieldName = "Price";
            this.colPrice.MinWidth = 25;
            this.colPrice.Name = "colPrice";
            this.colPrice.Visible = true;
            this.colPrice.VisibleIndex = 2;
            this.colPrice.Width = 94;
            // 
            // colProductionsDate
            // 
            this.colProductionsDate.FieldName = "ProductionsDate";
            this.colProductionsDate.MinWidth = 25;
            this.colProductionsDate.Name = "colProductionsDate";
            this.colProductionsDate.Visible = true;
            this.colProductionsDate.VisibleIndex = 3;
            this.colProductionsDate.Width = 94;
            // 
            // colExpirationDate
            // 
            this.colExpirationDate.FieldName = "ExpirationDate";
            this.colExpirationDate.MinWidth = 25;
            this.colExpirationDate.Name = "colExpirationDate";
            this.colExpirationDate.Visible = true;
            this.colExpirationDate.VisibleIndex = 4;
            this.colExpirationDate.Width = 94;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
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
            this.btn_search.Location = new System.Drawing.Point(839, 12);
            this.btn_search.Margin = new System.Windows.Forms.Padding(4);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(74, 76);
            this.btn_search.TabIndex = 24;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // text_search
            // 
            this.text_search.Location = new System.Drawing.Point(599, 36);
            this.text_search.Multiline = true;
            this.text_search.Name = "text_search";
            this.text_search.Size = new System.Drawing.Size(243, 34);
            this.text_search.TabIndex = 23;
            // 
            // Refresh
            // 
            this.Refresh.Appearance.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Refresh.Appearance.Options.UseFont = true;
            this.Refresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Refresh.ImageOptions.Image")));
            this.Refresh.Location = new System.Drawing.Point(413, 13);
            this.Refresh.Margin = new System.Windows.Forms.Padding(4);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(170, 76);
            this.Refresh.TabIndex = 22;
            this.Refresh.Text = "Refresh";
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // Delete
            // 
            this.Delete.Appearance.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.Appearance.Options.UseFont = true;
            this.Delete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Delete.ImageOptions.Image")));
            this.Delete.Location = new System.Drawing.Point(264, 13);
            this.Delete.Margin = new System.Windows.Forms.Padding(4);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(137, 76);
            this.Delete.TabIndex = 21;
            this.Delete.Text = "Delete";
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Edit
            // 
            this.Edit.Appearance.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit.Appearance.Options.UseFont = true;
            this.Edit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Edit.ImageOptions.Image")));
            this.Edit.Location = new System.Drawing.Point(146, 13);
            this.Edit.Margin = new System.Windows.Forms.Padding(4);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(106, 76);
            this.Edit.TabIndex = 20;
            this.Edit.Text = "Edit";
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Add
            // 
            this.Add.Appearance.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.Appearance.Options.UseFont = true;
            this.Add.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Add.ImageOptions.Image")));
            this.Add.Location = new System.Drawing.Point(18, 12);
            this.Add.Margin = new System.Windows.Forms.Padding(4);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(116, 76);
            this.Add.TabIndex = 19;
            this.Add.Text = "Add";
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Product_FORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(931, 465);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Product_FORM";
            this.Text = "Product_FORM";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton btn_search;
        private System.Windows.Forms.TextBox text_search;
        private DevExpress.XtraEditors.SimpleButton Refresh;
        private DevExpress.XtraEditors.SimpleButton Delete;
        private DevExpress.XtraEditors.SimpleButton Edit;
        private DevExpress.XtraEditors.SimpleButton Add;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colProductionsDate;
        private DevExpress.XtraGrid.Columns.GridColumn colExpirationDate;
    }
}
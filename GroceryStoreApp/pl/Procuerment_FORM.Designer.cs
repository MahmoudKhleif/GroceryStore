
namespace GroceryStoreApp.pl
{
    partial class Procuerment_FORM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Procuerment_FORM));
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSupplierID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBuyerID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTheTotalAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDATE = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.panel1.Size = new System.Drawing.Size(949, 512);
            this.panel1.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = typeof(GroceryStoreApp.TB_Procurement);
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(949, 418);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colSupplierID,
            this.colBuyerID,
            this.colTheTotalAmount,
            this.colDATE});
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
            // colSupplierID
            // 
            this.colSupplierID.FieldName = "SupplierID";
            this.colSupplierID.MinWidth = 25;
            this.colSupplierID.Name = "colSupplierID";
            this.colSupplierID.Visible = true;
            this.colSupplierID.VisibleIndex = 1;
            this.colSupplierID.Width = 94;
            // 
            // colBuyerID
            // 
            this.colBuyerID.FieldName = "BuyerID";
            this.colBuyerID.MinWidth = 25;
            this.colBuyerID.Name = "colBuyerID";
            this.colBuyerID.Visible = true;
            this.colBuyerID.VisibleIndex = 2;
            this.colBuyerID.Width = 94;
            // 
            // colTheTotalAmount
            // 
            this.colTheTotalAmount.FieldName = "TheTotalAmount";
            this.colTheTotalAmount.MinWidth = 25;
            this.colTheTotalAmount.Name = "colTheTotalAmount";
            this.colTheTotalAmount.Visible = true;
            this.colTheTotalAmount.VisibleIndex = 3;
            this.colTheTotalAmount.Width = 94;
            // 
            // colDATE
            // 
            this.colDATE.FieldName = "DATE";
            this.colDATE.MinWidth = 25;
            this.colDATE.Name = "colDATE";
            this.colDATE.Visible = true;
            this.colDATE.VisibleIndex = 4;
            this.colDATE.Width = 94;
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
            this.panel2.Location = new System.Drawing.Point(0, 418);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(949, 94);
            this.panel2.TabIndex = 0;
            // 
            // btn_search
            // 
            this.btn_search.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btn_search.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_search.ImageOptions.SvgImage")));
            this.btn_search.Location = new System.Drawing.Point(880, 17);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(59, 61);
            this.btn_search.TabIndex = 14;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // text_search
            // 
            this.text_search.Location = new System.Drawing.Point(645, 33);
            this.text_search.Multiline = true;
            this.text_search.Name = "text_search";
            this.text_search.Size = new System.Drawing.Size(243, 34);
            this.text_search.TabIndex = 13;
            // 
            // Refresh
            // 
            this.Refresh.Appearance.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Refresh.Appearance.Options.UseFont = true;
            this.Refresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Refresh.ImageOptions.Image")));
            this.Refresh.Location = new System.Drawing.Point(460, 17);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(155, 61);
            this.Refresh.TabIndex = 9;
            this.Refresh.Text = "Refresh";
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // Delete
            // 
            this.Delete.Appearance.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.Appearance.Options.UseFont = true;
            this.Delete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Delete.ImageOptions.Image")));
            this.Delete.Location = new System.Drawing.Point(296, 17);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(140, 61);
            this.Delete.TabIndex = 10;
            this.Delete.Text = "Delete";
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Edit
            // 
            this.Edit.Appearance.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit.Appearance.Options.UseFont = true;
            this.Edit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Edit.ImageOptions.Image")));
            this.Edit.Location = new System.Drawing.Point(153, 17);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(119, 61);
            this.Edit.TabIndex = 11;
            this.Edit.Text = "Edit";
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Add
            // 
            this.Add.Appearance.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.Appearance.Options.UseFont = true;
            this.Add.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Add.ImageOptions.Image")));
            this.Add.Location = new System.Drawing.Point(10, 17);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(119, 61);
            this.Add.TabIndex = 12;
            this.Add.Text = "Add";
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Procuerment_FORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(949, 512);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Procuerment_FORM";
            this.Text = "Procuerment_FORM";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton btn_search;
        private System.Windows.Forms.TextBox text_search;
        private DevExpress.XtraEditors.SimpleButton Refresh;
        private DevExpress.XtraEditors.SimpleButton Delete;
        private DevExpress.XtraEditors.SimpleButton Edit;
        private DevExpress.XtraEditors.SimpleButton Add;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colSupplierID;
        private DevExpress.XtraGrid.Columns.GridColumn colBuyerID;
        private DevExpress.XtraGrid.Columns.GridColumn colTheTotalAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colDATE;
        public DevExpress.XtraGrid.GridControl gridControl1;
        public System.Windows.Forms.Panel panel1;
    }
}
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace GroceryStoreApp.pl
{
    public partial class Sales_FORM : Form
    {   GorceryStoreEntities DB = new GorceryStoreEntities();
        TB_Saless TB_Saless1 = new TB_Saless();
        public int id;
        public Sales_FORM()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            GroceryStoreApp.GorceryStoreEntities dbContext = new GroceryStoreApp.GorceryStoreEntities();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.TB_Saless.LoadAsync().ContinueWith(loadTask =>
            {
    // Bind data to control when loading complete
    gridControl1.DataSource = dbContext.TB_Saless.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }
        //show salesAdd form
        private void Add_Click(object sender, EventArgs e)
        {
            pl.Sales_Add sales_Add = new Sales_Add();
            sales_Add.Show();
        }
        //uppdate
        private void Refresh_Click(object sender, EventArgs e)
        {
            update1();
        }

        private void update1()
        {
            DB = new GorceryStoreEntities();
            gridControl1.DataSource = DB.TB_Saless.ToList();
        }
        //delete
        private void Delete_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID"));
            TB_Saless1 = DB.TB_Saless.Where(x => x.ID == id).FirstOrDefault();
            DB.Entry(TB_Saless1).State = EntityState.Deleted;
            DB.SaveChanges();
            update1();
            MessageBox.Show("one row has been deleted");
        }
        //edit
        private void Edit_Click(object sender, EventArgs e)
        {
            pl.Sales_Add sales_Add = new Sales_Add();
            id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID"));
            TB_Saless1 = DB.TB_Saless.Where(x => x.ID == id).FirstOrDefault();
            sales_Add.TextsellerId.Text = Convert.ToString(TB_Saless1.SellerID);
            sales_Add.ProductID.Text = TB_Saless1.ProductID.ToString();
           sales_Add.BuyerID.Text = TB_Saless1.BuyerID.ToString();
            sales_Add.textThetotalAmont.Text = TB_Saless1.TheTotalAmount.ToString();
            sales_Add.textDate.Text = TB_Saless1.DATE.ToString();
            sales_Add.id = id;
            sales_Add.Show();
        }
        // to show sales form
        private void Detail_Click(object sender, EventArgs e)
        {
            pl.SalesINFO salesINFO = new SalesINFO();
            salesINFO.Show();
        }
        // searching by the total amount
        private void btn_search_Click(object sender, EventArgs e)
        {
            var serch = text_search.Text;
            gridControl1.DataSource = DB.TB_Saless.Where(x => x.TheTotalAmount.Contains(serch)).ToList();
        }
    }
}

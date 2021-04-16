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
    public partial class Procuerment_FORM : Form
    {

        GorceryStoreEntities DB = new GorceryStoreEntities();
        TB_Procurement TB_Procurement = new TB_Procurement();
        public int id;
        public Procuerment_FORM()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            GroceryStoreApp.GorceryStoreEntities dbContext = new GroceryStoreApp.GorceryStoreEntities();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.TB_Procurement.LoadAsync().ContinueWith(loadTask =>
            {
    // Bind data to control when loading complete
    gridControl1.DataSource = dbContext.TB_Procurement.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }
        //add
        private void Add_Click(object sender, EventArgs e)
        {
            pl.Procuerment_ADD procuerment_ADD = new Procuerment_ADD();
            procuerment_ADD.Show();
        }
        // refrshe
        private void Refresh_Click(object sender, EventArgs e)
        {
            UPDATE();
        }
        // refresh
        private void UPDATE()
        {
            DB = new GorceryStoreEntities();
            gridControl1.DataSource = DB.TB_Procurement.ToList();
        }
        //Edit
        private void Edit_Click(object sender, EventArgs e)
        {
            pl.Procuerment_ADD ADDform = new Procuerment_ADD();
            id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID"));
            TB_Procurement = DB.TB_Procurement.Where(x => x.ID == id).FirstOrDefault();
            ADDform.textThetotalAmont.Text = TB_Procurement.TheTotalAmount.ToString();
            ADDform.textDate.Text = TB_Procurement.DATE.ToString();
            ADDform.id = id;
            ADDform.Show();
        }
        //Delete
        private void Delete_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID"));
            TB_Procurement = DB.TB_Procurement.Where(x => x.ID == id).FirstOrDefault();
            DB.Entry(TB_Procurement).State = EntityState.Deleted;
            DB.SaveChanges();
            UPDATE();
            MessageBox.Show("one row has been deleted");
        }
        //Searching by the total amount
        private void btn_search_Click(object sender, EventArgs e)
        {
           var search = text_search.Text;
            gridControl1.DataSource = DB.TB_Procurement.Where(x =>x.TheTotalAmount.Contains(search)).ToList();
        }
    }
}
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
    public partial class Users_Form : Form
    {
        GorceryStoreEntities DB = new GorceryStoreEntities();
        TB_User TB_User = new TB_User();
        public int id;
        public Users_Form()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            GroceryStoreApp.GorceryStoreEntities dbContext = new GroceryStoreApp.GorceryStoreEntities();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.TB_User.LoadAsync().ContinueWith(loadTask =>
            {
    // Bind data to control when loading complete
    gridControl1.DataSource = dbContext.TB_User.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }
        //show user add form
        private void Add_Click(object sender, EventArgs e)
        {
            pl.Users_ADD users_ADD = new Users_ADD();
            users_ADD.Show();
        }
        //Delete_BTN
        private void Delete_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID"));
            TB_User = DB.TB_User.Where(x => x.ID == id).FirstOrDefault();
            DB.Entry(TB_User).State = EntityState.Deleted;
            DB.SaveChanges();
            Uppdat_data();
            MessageBox.Show("one row has been deleted");
        }

       
        // edit
        private void Edit_Click(object sender, EventArgs e)
        {
            pl.Users_ADD users_ADD = new Users_ADD();
            id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID"));
            TB_User = DB.TB_User.Where(x => x.ID == id).FirstOrDefault();
            users_ADD.textFirstName.Text = TB_User.FirstName.ToString();
            users_ADD.textLastName.Text = TB_User.LastName.ToString();
            users_ADD.textPhone.Text = TB_User.Phone.ToString();
            users_ADD.textEmail.Text = TB_User.Email.ToString();
            users_ADD.textAddress.Text = TB_User.Address.ToString();
            users_ADD.id = id;
            users_ADD.Show();
        }
        // refresh data
        private void Uppdat_data()
        {
            DB = new GorceryStoreEntities();
            gridControl1.DataSource = DB.TB_User.ToList();
        }
        private void Refresh_Click(object sender, EventArgs e)
        {
            Uppdat_data();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            var search = text_search.Text;
            gridControl1.DataSource = DB.TB_User.Where(x => x.FirstName.Contains(search)).ToList();
        }
    }
}
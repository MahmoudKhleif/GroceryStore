using System;
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
    public partial class Customers_FORM : Form
    {
        GorceryStoreEntities DB = new GorceryStoreEntities();
        TB_Customer2 TB_Customerr1 = new TB_Customer2();
        public int id;
        public Customers_FORM()
        {
            InitializeComponent();
            
            GroceryStoreApp.GorceryStoreEntities dbContext = new GroceryStoreApp.GorceryStoreEntities();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.TB_Customer2.LoadAsync().ContinueWith(loadTask =>
            {
    // Bind data to control when loading complete
    gridControl1.DataSource = dbContext.TB_Customer2.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void Add_Click(object sender, EventArgs e)
        {
            pl.Customer_ADD customer_ADD = new Customer_ADD();
            customer_ADD.Show();
        }

        private void Customers_FORM_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gorceryStoreDataSet1.TB_Customerr' table. You can move, or remove it, as needed.
            this.tB_CustomerrTableAdapter.Fill(this.gorceryStoreDataSet1.TB_Customerr);

        }
        //edit
        private void Edit_Click(object sender, EventArgs e)
        {
            pl.Customer_ADD customer_ADD = new Customer_ADD();
            id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID"));
            TB_Customerr1 = DB.TB_Customer2.Where(x => x.ID == id).FirstOrDefault();
            customer_ADD.textFirstName.Text = TB_Customerr1.FirstName.ToString();
            customer_ADD.textLastName.Text = TB_Customerr1.LastName.ToString();
            customer_ADD.textPhone.Text = TB_Customerr1.Phone.ToString();
            customer_ADD.textEmail.Text = TB_Customerr1.Email.ToString();
            customer_ADD.textAddress.Text = TB_Customerr1.Address.ToString();
            customer_ADD.id = id;
            customer_ADD.Show();
        }
        //Refresh
        private void Refresh_Click(object sender, EventArgs e)
        {
            UPdate();
        }
        //Refresh//update method
        private void UPdate()
        {
            DB = new GorceryStoreEntities();
            gridControl1.DataSource = DB.TB_Customer2.ToList();
        }
        //searching by firstname
        private void btn_search_Click(object sender, EventArgs e)
        {
            var search = text_search.Text;
            gridControl1.DataSource = DB.TB_Customer2.Where(x => x.FirstName.Contains(search)).ToList();
        }
      //  Delete
        private void Delete_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID"));
            TB_Customerr1 = DB.TB_Customer2.Where(x => x.ID == id).FirstOrDefault();
            DB.Entry(TB_Customerr1).State = EntityState.Deleted;
            DB.SaveChanges();
            UPdate();
            MessageBox.Show("one row has been deleted");
        }
    }
}

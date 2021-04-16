using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroceryStoreApp.pl
{
    public partial class Customer_ADD : Form
    {
        GorceryStoreEntities DB = new GorceryStoreEntities();
        TB_Customer2 TB_Customer = new TB_Customer2();
        public int id;
        public Customer_ADD()
        {
            InitializeComponent();
        }

       
        //Add or edit
        private void Add_Click(object sender, EventArgs e)
        {
            if ( textFirstName.Text == "" || textLastName.Text == "" || textPhone.Text == ""
              || textEmail.Text == "" || textAddress.Text == "")
            {
                MessageBox.Show("Fill in the blanks please");
            }
            else
            {  //ADD
                if (id == 0)
                {
                   
                    TB_Customer.FirstName = textFirstName.Text;
                    TB_Customer.LastName = textLastName.Text;
                    TB_Customer.Phone = textPhone.Text;
                    TB_Customer.Email = textPhone.Text;
                    TB_Customer.Address = textAddress.Text;
                    DB.TB_Customer2.Add(TB_Customer);
                    DB.SaveChanges();
                    MessageBox.Show("A new Customer has been added");
                }
                //edit
                else
                {
                    TB_Customer.ID = id;
                    TB_Customer.FirstName = textFirstName.Text;
                    TB_Customer.LastName = textLastName.Text;
                    TB_Customer.Phone = textPhone.Text;
                    TB_Customer.Email = textPhone.Text;
                    TB_Customer.Address = textAddress.Text;
                    DB.Entry(TB_Customer).State = System.Data.Entity.EntityState.Modified;
                    DB.SaveChanges();

                    MessageBox.Show("one row has been modified");
                }
            }
        
    }
        //close
        private void closebutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

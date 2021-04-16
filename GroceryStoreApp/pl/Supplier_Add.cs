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
    public partial class Supplier_Add : Form
    {
        GorceryStoreEntities DB = new GorceryStoreEntities();
        TB_Suppliers TB_Suppliers = new TB_Suppliers();
        public int id;
        public Supplier_Add()
        {
            InitializeComponent();
        }

        private void closebutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // add or edit
        private void Add_Click(object sender, EventArgs e)
        {
            if (textFirstName.Text == "" || textLastName.Text == "" || textPhone.Text == ""
                || textEmail.Text == "" || textAddress.Text == "")
            {
                MessageBox.Show("Fill in the blanks please");
            }
            else
            {  //add a new supplier
                if (id == 0)
                {
                    TB_Suppliers.FirstName = textFirstName.Text;
                    TB_Suppliers.LastName = textLastName.Text;
                    TB_Suppliers.Phone = textPhone.Text;
                    TB_Suppliers.Email = textPhone.Text;
                    TB_Suppliers.Address = textAddress.Text;
                    DB.TB_Suppliers.Add(TB_Suppliers);
                    DB.SaveChanges();
                    MessageBox.Show("A new Supplier has been added");
                }
               // Edit
                else
                {
                    TB_Suppliers.ID = id;
                    TB_Suppliers.FirstName = textFirstName.Text;
                    TB_Suppliers.LastName = textLastName.Text;
                    TB_Suppliers.Phone = textPhone.Text;
                    TB_Suppliers.Email = textPhone.Text;
                    TB_Suppliers.Address = textAddress.Text;
                    DB.Entry(TB_Suppliers).State = System.Data.Entity.EntityState.Modified;
                    DB.SaveChanges();
               
                    MessageBox.Show("one row has been modified");
                }
            }
        }
    }
}

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
    public partial class Users_ADD : Form
    {
        GorceryStoreEntities DB = new GorceryStoreEntities();
        TB_User TB_User = new TB_User();
        public int id;
        public Users_ADD()
        {
            InitializeComponent();
        }
        //close form
        private void closebutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //add or edit
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
                    TB_User.FirstName = textFirstName.Text;
                    TB_User.LastName = textLastName.Text;
                    TB_User.Phone = textPhone.Text;
                    TB_User.Email = textPhone.Text;
                    TB_User.Address = textAddress.Text;
                    DB.TB_User.Add(TB_User);
                    DB.SaveChanges();
                    MessageBox.Show("A new User has been added");
                }
                // Edit
                else
                {
                    TB_User.ID = id;
                    TB_User.FirstName = textFirstName.Text;
                    TB_User.LastName = textLastName.Text;
                    TB_User.Phone = textPhone.Text;
                    TB_User.Email = textPhone.Text;
                    TB_User.Address = textAddress.Text;
                    DB.Entry(TB_User).State = System.Data.Entity.EntityState.Modified;
                    DB.SaveChanges();

                    MessageBox.Show("one row has been modified");
                }
            }
        }
    }
}

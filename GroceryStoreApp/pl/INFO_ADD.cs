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
    public partial class INFO_ADD : Form
    {

        GorceryStoreEntities DB = new GorceryStoreEntities();
        TB_INFO TB_INFO1 = new TB_INFO();
       
        public INFO_ADD()
        {
            InitializeComponent();
        }
        //Close BTN
        private void closebutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //add or Edit
        private void Add_Click(object sender, EventArgs e)
        {
            if (textUserName.Text == "" || textPassWord.Text == "" || AdminID.Text == "")
            {
                MessageBox.Show("Fill in the blanks please");
            }
            else
            {
               
                //add
                    TB_INFO1.UserID = Convert.ToInt32(AdminID.Text);
                    TB_INFO1.UserName = textUserName.Text;
                    TB_INFO1.Password = textPassWord.Text;
                    DB.TB_INFO.Add(TB_INFO1);
                    DB.SaveChanges();
                    MessageBox.Show("A new user has been added");
                    this.Close();
              

            }
        }
        // fetch forigen keys
        private void INFO_ADD_Activated(object sender, EventArgs e)
        {
            AdminID.DataSource = DB.TB_User.Select(x => x.ID).ToList();
        }
    }
}

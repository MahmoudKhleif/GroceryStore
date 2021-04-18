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
    public partial class LOGIN : Form
    {
        GorceryStoreEntities DB = new GorceryStoreEntities();
        TB_INFO TB_INFO1 = new TB_INFO();
        Main Main = new Main();
        public LOGIN()
        {
            InitializeComponent();
        }
        //display info form
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            pl.INFO_ADD iNFO_ADD = new INFO_ADD();
            iNFO_ADD.Show();
        }
        //log in 
        private void Add_Click(object sender, EventArgs e)
        {
       TB_INFO1 = DB.TB_INFO.Where(X => X.UserName == textUserName.Text && X.Password == textPassWord.Text).FirstOrDefault();
            if (TB_INFO1 != null)
            {
                DB.Entry(TB_INFO1).State = EntityState.Modified;
                Main.UserNAme.Text = TB_INFO1.UserName;
                Main.Enabled=true;
                DB.SaveChanges();
                
                Main.Show();
            }
            else
            {
                MessageBox.Show("Faild Login");
            }
        }
        //close
        private void closebutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LOGIN_Activated(object sender, EventArgs e)
        {
            Main.Enabled = false;
        }
    }
}

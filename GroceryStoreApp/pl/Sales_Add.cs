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
    public partial class Sales_Add : Form
    {
        GorceryStoreEntities DB = new GorceryStoreEntities();
        TB_Saless TB_Saless1 = new TB_Saless();
        public int id;
        public Sales_Add()
        {
            InitializeComponent();
        }
        //CLOSE
        private void closebutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //ADD OR EDIT
        private void Add_Click(object sender, EventArgs e)
        {
            if (textThetotalAmont.Text == "" || textDate.Text == ""
                || TextsellerId.Text==""||ProductID.Text==""|| BuyerID.Text == "")
            {
                MessageBox.Show("Fill in the blanks please");
            }
            else
            {
                if (id == 0)
                {//add
                    TB_Saless1.ProductID = Convert.ToInt32(ProductID.Text);
                    TB_Saless1.SellerID = Convert.ToInt32(TextsellerId.Text);
                    TB_Saless1.BuyerID = Convert.ToInt32(BuyerID.Text);
                    TB_Saless1.TheTotalAmount = textThetotalAmont.Text;
                    TB_Saless1.DATE = textDate.Text;
                    DB.TB_Saless.Add(TB_Saless1);
                    DB.SaveChanges();
                    MessageBox.Show("A new sale has been added");
                }
                //edit
                else
                {
                    TB_Saless1.ID = id;
                    TB_Saless1.ProductID = Convert.ToInt32(ProductID.Text);
                    TB_Saless1.SellerID = Convert.ToInt32(TextsellerId.Text);
                    TB_Saless1.BuyerID = Convert.ToInt32(BuyerID.Text);
                    TB_Saless1.TheTotalAmount = textThetotalAmont.Text;
                    TB_Saless1.DATE = textDate.Text;
                    DB.Entry(TB_Saless1).State = System.Data.Entity.EntityState.Modified;
                    DB.SaveChanges();

                    MessageBox.Show("one row has been modified");
                }
            }
        }
        // fetch forigen keys
        private void Sales_Add_Activated(object sender, EventArgs e)
        {
            ProductID.DataSource = DB.TB_Productt.Select(x => x.ID).ToList();
            TextsellerId.DataSource = DB.TB_User.Select(x => x.ID).ToList();
            BuyerID.DataSource = DB.TB_Customer2.Select(x => x.ID).ToList();
        }
    }
   }
 
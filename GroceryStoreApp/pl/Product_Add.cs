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
    public partial class Product_Add : Form
    {
        GorceryStoreEntities DB = new GorceryStoreEntities();
        TB_Productt TB_Productt1 = new TB_Productt();
        public int id;
        public Product_Add()
        {
            InitializeComponent();
        }
        //add or edit
        private void Add_Click(object sender, EventArgs e)
        {
            if (textName.Text == "" || textprice.Text == "" || textProductionDate.Text == ""
             || textExpirationDate.Text == "")
            {
                MessageBox.Show("Fill in the blanks please");
            }
            else
            {  //ADD
                if (id == 0)
                {

                    TB_Productt1.Name = textName.Text;
                    TB_Productt1.Price = textprice.Text;
                    TB_Productt1.ProductionsDate = textProductionDate.Text;
                    TB_Productt1.ExpirationDate = textExpirationDate.Text;
                    DB.TB_Productt.Add(TB_Productt1);
                    DB.SaveChanges();
                    MessageBox.Show("A new Product has been added");
                }
                else
                {
                    TB_Productt1.ID = id;
                    TB_Productt1.Name = textName.Text;
                    TB_Productt1.Price = textprice.Text;
                    TB_Productt1.ProductionsDate = textProductionDate.Text;
                    TB_Productt1.ExpirationDate = textExpirationDate.Text;
                    DB.Entry(TB_Productt1).State = System.Data.Entity.EntityState.Modified;
                    DB.SaveChanges();

                    MessageBox.Show("one row has been modified");
                }
            }
        }
        //CloseBtn
        private void closebutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

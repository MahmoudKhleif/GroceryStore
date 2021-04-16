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
    
    public partial class Procuerment_ADD : Form
    {
        GorceryStoreEntities DB = new GorceryStoreEntities();
        TB_Procurement TB_Procurement = new TB_Procurement();
        public int id;
        public Procuerment_ADD()
        {
            InitializeComponent();
        }
        // fetch forigen keys
        private void Procuerment_ADD_Activated(object sender, EventArgs e)
        {
            SupplierID.DataSource = DB.TB_Suppliers.Select(x => x.ID).ToList();
            BuyerID.DataSource = DB.TB_User.Select(x => x.ID).ToList();
        }
        // Add or edit
        private void Add_Click(object sender, EventArgs e)
        {
            if (textThetotalAmont.Text == "" || textDate.Text == "" || SupplierID.Text == ""
               || BuyerID.Text == "" )
            {
                MessageBox.Show("Fill in the blanks please");
            }
            else
            {  //ADD
                if (id == 0)
                {
                    TB_Procurement.SupplierID = Convert.ToInt32(SupplierID.Text);
                    TB_Procurement.BuyerID = Convert.ToInt32(BuyerID.Text);
                    TB_Procurement.TheTotalAmount = textThetotalAmont.Text;
                    TB_Procurement.DATE = textDate.Text;
                    DB.TB_Procurement.Add(TB_Procurement);
                    DB.SaveChanges();
                    MessageBox.Show("A new Procurement has been added");
                }
                //edit
                else
                {
                    TB_Procurement.ID = id;
                    TB_Procurement.SupplierID = Convert.ToInt32(SupplierID.Text);
                    TB_Procurement.BuyerID = Convert.ToInt32(BuyerID.Text);
                    TB_Procurement.TheTotalAmount = textThetotalAmont.Text;
                    TB_Procurement.DATE = textDate.Text;
                    DB.Entry(TB_Procurement).State = System.Data.Entity.EntityState.Modified;
                    DB.SaveChanges();

                    MessageBox.Show("one row has been modified");
                }
            }
        }
        //closeBtn
        private void closebutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

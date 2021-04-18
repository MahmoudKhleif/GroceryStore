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
    public partial class FormHomePage : Form
    {
        public FormHomePage()
        {
            InitializeComponent();
        }
        // show customer-add
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            pl.Customer_ADD customer_ADD = new Customer_ADD();
            customer_ADD.Show();
        }
        //show supplier-add
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            pl.Supplier_Add supplier_Add = new Supplier_Add();
            supplier_Add.Show();
        }
        //show procerument-form
        private void simpleButton3_Click(object sender, EventArgs e)
        {
            pl.Procuerment_ADD procuerment_ADD = new Procuerment_ADD();
            procuerment_ADD.Show();
        }
        //add sale
        private void simpleButton5_Click(object sender, EventArgs e)
        {
            pl.Sales_Add sales_Add = new Sales_Add();
            sales_Add.Show();

        }
        //add customer
        private void simpleButton4_Click(object sender, EventArgs e)
        {
            pl.Customer_ADD customer_ADD = new Customer_ADD();
            customer_ADD.Show();
        }
    }
}

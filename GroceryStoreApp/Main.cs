using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroceryStoreApp
{
    public partial class Main : Form
    {
        
        pl.FormHomePage HOMEp = new pl.FormHomePage();
        pl.Supplier_FORM Supplier_FORM = new pl.Supplier_FORM();
        pl.Users_Form Users_Form = new pl.Users_Form();
        pl.Procuerment_FORM Procuerment_FORM = new pl.Procuerment_FORM();
        pl.Customers_FORM Customers_FORM = new pl.Customers_FORM();
        pl.Product_FORM product_FORM = new pl.Product_FORM();
        pl.Sales_FORM Sales_FORM = new pl.Sales_FORM();
      
      
         
        public Main()
        {
            InitializeComponent();
            // to show admin name
            UserNAme.Text = GroceryStoreApp.pl.user1.Name; 

        }
        
        // minimise app
        private void Minimize_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        //Maximaize App
        private void Maximaizebutton_Click_1(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }
        //close app
        private void closebutton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
       // DisplayMAINPAGE
        private void Main1_Click(object sender, EventArgs e)
        {
           panelcontiner.Controls.Clear();
          panelcontiner.Controls.Add(HOMEp.Homepagepanal);
        }

        private void Main1_Load(object sender, EventArgs e)
        {
            panelcontiner.Controls.Clear();
            panelcontiner.Controls.Add(HOMEp.Homepagepanal);
        }
        //DISPLAY SUPPLIERSFORM
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            panelcontiner.Controls.Clear();
            panelcontiner.Controls.Add(Supplier_FORM.SUPP_PANEL);
        }
        // display Users_Form
        private void User_Btn_Click(object sender, EventArgs e)
        {
            panelcontiner.Controls.Clear();
            panelcontiner.Controls.Add(Users_Form.panel1);
        }
        // display Procuerment_FORM
        private void simpleButton3_Click(object sender, EventArgs e)
        {
            panelcontiner.Controls.Clear();
            panelcontiner.Controls.Add(Procuerment_FORM.panel1);
        }
        // display Customer_Form
        private void simpleButton4_Click(object sender, EventArgs e)
        {
            panelcontiner.Controls.Clear();
            panelcontiner.Controls.Add(Customers_FORM.panel1);
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            panelcontiner.Controls.Clear();
            panelcontiner.Controls.Add(product_FORM.panel1);

        }

        private void Sales_Click(object sender, EventArgs e)
        {
            panelcontiner.Controls.Clear();
            panelcontiner.Controls.Add(Sales_FORM.panel1);
        }

        private void UserNAme_Click(object sender, EventArgs e)
        {
            
        }
    }
}

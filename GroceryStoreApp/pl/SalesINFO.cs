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
    public partial class SalesINFO : Form
    {
        GorceryStoreEntities DB = new GorceryStoreEntities();
        TB_Saless TB_Saless = new TB_Saless();
        public SalesINFO()
        {
            InitializeComponent();
            // data gridview for fetch data from tow tables(TB-Saless and TB-Productt)
           dataGridView1.DataSource = DB.TB_Saless.Select(x => new {x.TB_Productt.ID, x.TB_Productt.Name, x.TB_Productt.Price,x.TheTotalAmount,x.DATE }).ToList();
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            DB = new GorceryStoreEntities();
            dataGridView1.DataSource = DB.TB_Saless.Select(x => new { x.TB_Productt.ID, x.TB_Productt.Name, x.TB_Productt.Price, x.TheTotalAmount, x.DATE }).ToList();
        }
        //search
        private void btn_search_Click(object sender, EventArgs e)
        {
            var Serach = text_search.Text;
            dataGridView1.DataSource = DB.TB_Saless.Where(x => x.TB_Productt.Name.Contains(Serach))
            .Select(x => new { x.TB_Productt.ID, x.TB_Productt.Name, x.TB_Productt.Price, x.TheTotalAmount, x.DATE }).Distinct().ToList();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManagementSystem.Utils;
using MySql.Data.MySqlClient;
using ManagementSystem.InventoryForms;

namespace ManagementSystem
{
    public partial class UCInventory : UserControl
    {
        String connection = string.Empty;
        public UCInventory()
        {
            InitializeComponent();
            String path = "C:\\CustomConfig\\CustomConfig.ini";
            connection = new DbConnect("Custom Config", path).getConnection();
            fillTable();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            ProductsForm pf = new ProductsForm();
            pf.Show();
            pf.btn_Update.Visible = false;
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_ProductID.Text))
            {
                MessageBox.Show("Please select a patient record.");
            }
            else
            {
                ProductsForm pf = new ProductsForm();
                pf.Show();
                pf.btn_Add.Visible = false;
                pf.txt_ID.Text = this.txt_ProductID.Text;
            }
        }

        private void btn_AddService_Click(object sender, EventArgs e)
        {
            ServicesForm sf = new ServicesForm();
            sf.Show();
            sf.btn_Update.Visible = false;
        }

        private void btn_EditService_Click(object sender, EventArgs e)
        {
            ServicesForm sf = new ServicesForm();
            sf.Show();
            sf.btn_Add.Visible = false;
        }

        public void fillTable()
        {
            using (MySqlConnection con = new MySqlConnection(connection))
            {
                con.Open();
                DataTable dt = new DataTable();
                MySqlDataAdapter adp = new MySqlDataAdapter();
                adp = new MySqlDataAdapter("SELECT ProductID AS ID, ProductName AS 'Name', ProductDesc AS 'Desc', Supplier, Qty FROM DbTest.Products ORDER BY Qty", con);
                adp.Fill(dt);
                ProductsDataGrid.DataSource = dt;
                con.Close();
            }
        }

        private void btn_RefreshProd_Click(object sender, EventArgs e)
        {
            fillTable();
        }

        private void ProductsDataGrid_MouseClick(object sender, MouseEventArgs e)
        {
            txt_ProductID.Text = ProductsDataGrid.CurrentRow.Cells[0].Value.ToString();
        }

        private void txt_SearchProduct_OnValueChanged(object sender, EventArgs e)
        {
            searchData(txt_SearchProduct.Text);
        }
        private void searchData(string findValue)
        {
            string searchQuery = "SELECT ProductID AS ID, ProductName AS 'Name', ProductDesc AS 'Desc', Supplier, Qty FROM DbTest.Products WHERE ProductName LIKE '%" + findValue + "%'";
            MySqlDataAdapter adp = new MySqlDataAdapter(searchQuery, connection);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            ProductsDataGrid.DataSource = dt;
        }
    }
}

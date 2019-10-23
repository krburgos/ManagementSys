using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManagementSystem.Utils;
using MySql.Data.MySqlClient;

namespace ManagementSystem.InventoryForms
{
    public partial class NewItemForm : Form
    {
        String connection = string.Empty;
        public NewItemForm()
        {
            InitializeComponent();
            String path = "C:\\CustomConfig\\CustomConfig.ini";
            connection = new DbConnect("Custom Config", path).getConnection(); 
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        //private void ProductsForm_Load(object sender, EventArgs e)
        //{
        //    LoadComboBox();
        //}

        //private void LoadComboBox() 
        //{
        //    cbox_Suppliers.Items.Clear();
        //    using (MySqlConnection con = new MySqlConnection(connection))
        //    {
        //        con.Open();
        //        MySqlCommand cmd = con.CreateCommand();
        //        cmd.CommandText = "Select SupplierName FROM DbTest.Suppliers";
        //        cmd.ExecuteNonQuery();
        //        DataTable dt = new DataTable();
        //        MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
        //        adp.Fill(dt);

        //        foreach (DataRow dr in dt.Rows)
        //        {
        //            cbox_Suppliers.Items.Add(dr["SupplierName"].ToString());
        //        }
        //        con.Close();
        //    }
        //}

        //private void btn_Add_Click(object sender, EventArgs e)
        //{
        //    if (string.IsNullOrEmpty(txt_ProductName.Text) || string.IsNullOrEmpty(txt_ProductDesc.Text) || string.IsNullOrEmpty(cbox_Suppliers.Text))
        //    {
        //        MessageBox.Show("Please input all fields.");
        //    }
        //    else
        //    {
        //        using (MySqlConnection con = new MySqlConnection(connection))
        //        {
        //            con.Open();
        //            MySqlCommand cmd = con.CreateCommand();
        //            cmd.CommandText = "INSERT INTO DbTest.Products(ProductName, ProductDesc, Supplier, Qty, SupplierPrice, StorePrice) VALUES (@ProductName, @ProductDesc, @Supplier, @Qty, @SupplierPrice, @StorePrice)";
        //            cmd.Parameters.AddWithValue("ProductName", txt_ProductName.Text);
        //            cmd.Parameters.AddWithValue("ProductDesc", txt_ProductDesc.Text);
        //            cmd.Parameters.AddWithValue("Supplier", cbox_Suppliers.Text);
        //            cmd.Parameters.AddWithValue("Qty", 0);
        //            cmd.Parameters.AddWithValue("SupplierPrice", 0.00);
        //            cmd.Parameters.AddWithValue("StorePrice", 0.00);
        //            cmd.ExecuteNonQuery();
        //            con.Close();
        //            MessageBox.Show("New product added.");
        //            this.Hide();
        //        }
        //    }
        //}

        //private void btn_Update_Click(object sender, EventArgs e)
        //{
        //    if (string.IsNullOrEmpty(txt_ProductName.Text) || string.IsNullOrEmpty(txt_ProductDesc.Text) || string.IsNullOrEmpty(cbox_Suppliers.Text))
        //    {
        //        MessageBox.Show("Please input all fields.");
        //    }
        //    else
        //    {
        //        DialogResult result = MessageBox.Show("Do You want to update record?", "Update", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        //        {
        //            if (result.Equals(DialogResult.OK))
        //            {
        //                using (MySqlConnection con = new MySqlConnection(connection))
        //                {
        //                    con.Open();
        //                    MySqlCommand cmd = con.CreateCommand();
        //                    cmd.CommandText = "UPDATE DbTest.Products SET ProductName=@ProductName, ProductDesc=@ProductDesc,Supplier=@Supplier WHERE ProductID=" + txt_ProductID.Text;
        //                    cmd.Parameters.AddWithValue("ProductName", txt_ProductName.Text);
        //                    cmd.Parameters.AddWithValue("ProductDesc", txt_ProductDesc.Text);
        //                    cmd.Parameters.AddWithValue("Supplier", cbox_Suppliers.Text);
        //                    cmd.ExecuteNonQuery();
        //                    con.Close();
        //                    MessageBox.Show("Record updated successfully.");
        //                    this.Hide();
        //                }
        //            }
        //        }
        //    }
        //}
    }
}

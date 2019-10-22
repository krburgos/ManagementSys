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
using ManagementSystem.PatientsForms;
using MySql.Data.MySqlClient;

namespace ManagementSystem
{
    public partial class UCSuppliers : UserControl
    {
        String connection = string.Empty;
        public UCSuppliers()
        {
            InitializeComponent();
            String path = "C:\\CustomConfig\\CustomConfig.ini";
            connection = new DbConnect("Custom Config", path).getConnection();
            fillTable();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_SupplierName.Text) || string.IsNullOrEmpty(txt_ContactNo.Text))
            {
                MessageBox.Show("Please input all fields.");
            }
            else
            {
                using (MySqlConnection con = new MySqlConnection(connection))
                {
                    con.Open();
                    using (MySqlCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandText = "INSERT INTO DbTest.Suppliers(SupplierName,SupplierContact) VALUES (@SupplierName, @SupplierContact)";
                        cmd.Parameters.AddWithValue("@SupplierName", txt_SupplierName.Text);
                        cmd.Parameters.AddWithValue("@SupplierContact", txt_ContactNo.Text);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Record successfully added.");
                    }
                }
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_ID.Text))
            {
                MessageBox.Show("Please select supplier to edit.");
            }
            else if (string.IsNullOrEmpty(txt_SupplierName.Text) || string.IsNullOrEmpty(txt_ContactNo.Text))
            {
                MessageBox.Show("Please input all fields");
            }
            else
            {
                DialogResult result = MessageBox.Show("Do You want to update record?", "Update", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                {
                    if (result.Equals(DialogResult.OK))
                    {
                        using (MySqlConnection con = new MySqlConnection(connection))
                        {
                            using (MySqlCommand cmd = con.CreateCommand())
                            {
                                con.Open();
                                cmd.CommandText = "UPDATE DbTest.Suppliers SET SupplierName=@SupplierName, SupplierContact=@SupplierContact WHERE SupplierID=" + txt_ID.Text;
                                cmd.Parameters.AddWithValue("@SupplierName", txt_SupplierName.Text);
                                cmd.Parameters.AddWithValue("@SupplierContact", txt_ContactNo.Text);
                                cmd.ExecuteNonQuery();
                                con.Close();
                                MessageBox.Show("Record updated successfully.");
                            }
                        }
                    }
                }
            }
        }

        public void fillTable()
        {
            using (MySqlConnection con = new MySqlConnection(connection))
            {
                con.Open();
                DataTable dt = new DataTable();
                MySqlDataAdapter adp = new MySqlDataAdapter();
                adp = new MySqlDataAdapter("SELECT * FROM DbTest.Suppliers", con);
                adp.Fill(dt);
                SuppliersDataGrid.DataSource = dt;
                con.Close();
            }
        }

        private void SuppliersDataGrid_MouseClick(object sender, MouseEventArgs e)
        {
            txt_ID.Text = SuppliersDataGrid.CurrentRow.Cells[0].Value.ToString();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            fillTable();
        }

        private void txt_ContactNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_Search_OnValueChanged(object sender, EventArgs e)
        {
            searchData(txt_Search.Text);
        }
        private void searchData(string findValue)
        {
            string searchQuery = "SELECT SupplierID, SupplierName, SupplierContact FROM DbTest.Suppliers WHERE CONCAT (SupplierName) LIKE '%" + findValue + "%'";
            MySqlDataAdapter adp = new MySqlDataAdapter(searchQuery, connection);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            SuppliersDataGrid.DataSource = dt;
        }
    }
}

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

namespace ManagementSystem
{
    public partial class ManagePatientForm : Form
    {
        String connection = string.Empty;
        public ManagePatientForm()
        {
            InitializeComponent();
            String path = "C:\\CustomConfig\\CustomConfig.ini";
            connection = new DbConnect("Custom Config", path).getConnection(); 
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_FirstName.Text) || string.IsNullOrEmpty(txt_MiddleName.Text) || string.IsNullOrEmpty(txt_LastName.Text) || string.IsNullOrEmpty(txt_Address.Text) || string.IsNullOrEmpty(txt_Age.Text) || down_Status.selectedValue == null || down_Gender.selectedValue == null)
                {
                    MessageBox.Show("Please input all fields");
                }
                else
                {
                    using (MySqlConnection con = new MySqlConnection(connection))
                    {
                        con.Open();
                        using (MySqlCommand cmd = con.CreateCommand())
                        {
                            cmd.CommandText = "INSERT INTO DbTest.Patients(FirstName, MiddleName, LastName, PatientAddress, CivilStatus, Gender, Age, DateAdded) VALUES (@FirstName, @MiddleName, @LastName, @PatientAddress, @CivilStatus, @Gender, @Age, @DateAdded)";
                            cmd.Parameters.AddWithValue("@FirstName", txt_FirstName.Text);
                            cmd.Parameters.AddWithValue("@MiddleName", txt_MiddleName.Text);
                            cmd.Parameters.AddWithValue("@LastName", txt_LastName.Text);
                            cmd.Parameters.AddWithValue("@PatientAddress", txt_Address.Text);
                            cmd.Parameters.AddWithValue("@CivilStatus", down_Status.selectedValue.ToString());
                            cmd.Parameters.AddWithValue("@Gender", down_Gender.selectedValue.ToString());
                            cmd.Parameters.AddWithValue("@Age", Convert.ToInt32(txt_Age.Text));
                            cmd.Parameters.AddWithValue("@DateAdded", DateTime.Now);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("New record successfully added.");
                            con.Close();
                            this.Hide();
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_FirstName.Text) || string.IsNullOrEmpty(txt_MiddleName.Text) || string.IsNullOrEmpty(txt_LastName.Text) || string.IsNullOrEmpty(txt_Address.Text) || string.IsNullOrEmpty(txt_Age.Text) || down_Status.selectedValue == null || down_Gender.selectedValue == null)
                {
                    MessageBox.Show("Please input all fields.", "ERROR");
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
                                    cmd.CommandText = "UPDATE DbTest.Patients SET Firstname=@FirstName,MiddleName=@MiddleName,LastName=@LastName,PatientAddress=@PatientAddress,CivilStatus=@CivilStatus,Gender=@Gender,Age=@Age WHERE PatientId=" + txt_ID.Text;
                                    cmd.Parameters.AddWithValue("@FirstName", txt_FirstName.Text);
                                    cmd.Parameters.AddWithValue("@MiddleName", txt_MiddleName.Text);
                                    cmd.Parameters.AddWithValue("@LastName", txt_LastName.Text);
                                    cmd.Parameters.AddWithValue("@PatientAddress", txt_Address.Text);
                                    cmd.Parameters.AddWithValue("@Age", txt_Age.Text.ToString());
                                    cmd.Parameters.AddWithValue("@CivilStatus", down_Status.selectedValue.ToString());
                                    cmd.Parameters.AddWithValue("@Gender", down_Gender.selectedValue.ToString());
                                    cmd.ExecuteNonQuery();
                                    MessageBox.Show("Record updated successfully.");
                                    con.Close();
                                    this.Hide();
                                    UCPatients ucp = new UCPatients();
                                    ucp.fillTable();
                                }
                            }
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Please input all fields.");
            }
        }
    }
}

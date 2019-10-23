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

namespace ManagementSystem.PatientsForms
{
    public partial class NewVisitForm : Form
    {
        String connection = string.Empty;
        public NewVisitForm()
        {
            InitializeComponent();
            String path = "C:\\CustomConfig\\CustomConfig.ini";
            connection = new DbConnect("Custom Config", path).getConnection();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_Findings.Text = "";
            txt_Treatment.Text = "";
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_Findings.Text) || string.IsNullOrEmpty(txt_Treatment.Text))
                {
                    MessageBox.Show("Please input fields.");
                }
                else
                {
                    using (MySqlConnection con = new MySqlConnection(connection))
                    {
                        con.Open();
                        using (MySqlCommand cmd = con.CreateCommand())
                        {
                            cmd.CommandText = "INSERT INTO DbTest.Visits(PID, Findings, Treatment, DateCreated) VALUES (@PID, @Findings, @Treatment, @DateCreated)";
                            cmd.Parameters.AddWithValue("@PID", txt_ID.Text);
                            cmd.Parameters.AddWithValue("@Findings", txt_Findings.Text);
                            cmd.Parameters.AddWithValue("@Treatment", txt_Treatment.Text);
                            cmd.Parameters.AddWithValue("@DateCreated", DateTime.Now);
                            cmd.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show("New record successfully added.");
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
                if (string.IsNullOrEmpty(txt_Findings.Text) || string.IsNullOrEmpty(txt_Treatment.Text))
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
                                    cmd.CommandText = "UPDATE DbTest.Visits SET Findings=@Findings, Treatment=@Treatment WHERE VisitID=" + txt_VisitID.Text + " AND PID=" + txt_ID.Text;
                                    cmd.Parameters.AddWithValue("@Findings", txt_Findings.Text);
                                    cmd.Parameters.AddWithValue("@Treatment", txt_Treatment.Text);
                                    cmd.ExecuteNonQuery();
                                    MessageBox.Show("Record updated successfully");
                                    con.Close();
                                    this.Hide();
                                }
                            }
                        }
                    }
                }
            }   
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

     
 

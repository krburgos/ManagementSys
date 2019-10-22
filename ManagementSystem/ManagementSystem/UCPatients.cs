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
    public partial class UCPatients : UserControl
    {
        String connection = string.Empty;
        public UCPatients()
        {
            InitializeComponent();
            String path = "C:\\CustomConfig\\CustomConfig.ini";
            connection = new DbConnect("Custom Config", path).getConnection();
            fillTable();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            ManagePatientForm mpf = new ManagePatientForm();
            mpf.Show();
            mpf.btn_Update.Visible = false;
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_ID.Text))
            {
                MessageBox.Show("Please select a patient record.");
            }
            else
            {
                ManagePatientForm mpf = new ManagePatientForm();
                mpf.Show();
                mpf.btn_Add.Visible = false;
                mpf.txt_ID.Text = this.txt_ID.Text;

                using (MySqlConnection con = new MySqlConnection(connection))
                {
                    con.Open();
                    using (MySqlCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandText = "SELECT * FROM DbTest.Patients WHERE PatientID=" + txt_ID.Text;
                        MySqlDataReader rdr = cmd.ExecuteReader();
                        while (rdr.Read())
                        {
                            mpf.txt_ID.Text = Convert.ToInt32(rdr["PatientID"]).ToString();
                            mpf.txt_FirstName.Text = rdr["FirstName"].ToString();
                            mpf.txt_MiddleName.Text = rdr["MiddleName"].ToString();
                            mpf.txt_LastName.Text = rdr["LastName"].ToString();
                            mpf.txt_Address.Text = rdr["PatientAddress"].ToString();
                            mpf.txt_Age.Text = Convert.ToInt32(rdr["Age"]).ToString();
                        }
                    }
                }
            }
        }

        private void btn_NewVisit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_ID.Text))
            {
                MessageBox.Show("Please select a record.");
            }
            else
            {
                NewVisitForm nvf = new NewVisitForm();
                nvf.Show();
                nvf.btn_Update.Visible = false;
                nvf.txt_ID.Text = this.txt_ID.Text;
            }
        }
        public void fillTable()
        {
            using (MySqlConnection con = new MySqlConnection(connection))
            {
                con.Open();
                DataTable dt = new DataTable();
                MySqlDataAdapter adp = new MySqlDataAdapter();
                adp = new MySqlDataAdapter("SELECT PatientID AS 'ID', CONCAT(LastName,' , ', FirstName,' ', MiddleName) AS 'Full Name',PatientAddress AS 'Address', CivilStatus AS 'Civil Status', Gender, Age, DateAdded AS 'Date Added' FROM DbTest.Patients", con);
                adp.Fill(dt);
                PatientsDataGrid.DataSource = dt;
                con.Close();
            }
        }

        private void PatientsDataGrid_MouseClick(object sender, MouseEventArgs e)
        {
            txt_ID.Text = PatientsDataGrid.CurrentRow.Cells[0].Value.ToString();
        }
        private void searchData(string findValue)
        {
            string searchQuery = "SELECT PatientID, CONCAT(LastName,' , ', FirstName,' ', MiddleName) AS 'Full Name',PatientAddress, DateAdded FROM DbTest.Patients WHERE CONCAT (LastName,Firstname,MiddleName) LIKE '%" + findValue + "%'";
            MySqlDataAdapter adp = new MySqlDataAdapter(searchQuery, connection);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            PatientsDataGrid.DataSource = dt;
        }

        private void txt_Search_OnValueChanged(object sender, EventArgs e)
        {
            searchData(txt_Search.Text);
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            fillTable();
        }

        private void btn_History_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_ID.Text))
            {
                MessageBox.Show("Please select a patient record.");
            }
            else
            {
                VisitHistoryForm vhf = new VisitHistoryForm();
                vhf.txt_ID.Text = this.txt_ID.Text;
                using (MySqlConnection con = new MySqlConnection(connection))
                {
                    con.Open();
                    DataTable dt = new DataTable();
                    MySqlDataAdapter adp = new MySqlDataAdapter("SELECT VisitID, Findings, Treatment, DateCreated FROM DbTest.Visits WHERE PID=" + txt_ID.Text, con);
                    adp.Fill(dt);
                    vhf.VisitsDataGrid.DataSource = dt;

                    using (MySqlCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandText = "SELECT CONCAT(LastName,' , ', FirstName,' ', MiddleName) AS 'Full Name' FROM DbTest.Patients WHERE PatientID=" + txt_ID.Text;
                        MySqlDataReader rdr = cmd.ExecuteReader();
                        while (rdr.Read())
                        {
                            vhf.txt_FullName.Text = rdr["Full Name"].ToString();
                        }
                        con.Close();
                    }
                }
                vhf.Show();
            }
        }
    }
}

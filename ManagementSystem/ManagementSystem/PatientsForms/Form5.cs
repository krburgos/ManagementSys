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



namespace ManagementSystem.PatientsForms
{
    public partial class VisitHistoryForm : Form
    {
        String connection = string.Empty;
        public VisitHistoryForm()
        {
            InitializeComponent();
            String path = "C:\\CustomConfig\\CustomConfig.ini";
            connection = new DbConnect("Custom Config", path).getConnection();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void VisitsDataGrid_RowHeaderMouseDoubleClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            NewVisitForm nvf = new NewVisitForm();
            nvf.Show();
            nvf.txt_VisitID.Text = this.VisitsDataGrid.CurrentRow.Cells[0].Value.ToString();
            nvf.btn_Add.Visible = false;
            
            using (MySqlConnection con = new MySqlConnection(connection))
            {
                con.Open();
                using (MySqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM DbTest.Visits WHERE VisitID=" + nvf.txt_VisitID.Text;
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        nvf.txt_ID.Text = Convert.ToInt32(rdr["PID"]).ToString();
                        nvf.txt_Findings.Text = rdr["Findings"].ToString();
                        nvf.txt_Treatment.Text = rdr["Treatment"].ToString();
                    }
                    con.Close();
                    rdr.Close();
                }
            }
        }
    }
}

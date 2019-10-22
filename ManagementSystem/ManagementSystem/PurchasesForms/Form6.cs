using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using ManagementSystem.PatientsForms;
using ManagementSystem.Utils;
using MySql.Data.MySqlClient;


namespace ManagementSystem.PurchasesForms
{
    public partial class PurchasesForm : Form
    {
        String connection = string.Empty;
        public PurchasesForm()
        {
            InitializeComponent();
            String path = "C:\\CustomConfig\\CustomConfig.ini";
            connection = new DbConnect("Custom Config", path).getConnection(); 
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

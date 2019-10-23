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
        }

        private void btn_Products_Click(object sender, EventArgs e)
        {
            ucProducts1.Visible = true;
            ucServices1.Visible = false;
        }

        private void btn_Services_Click(object sender, EventArgs e)
        {
            ucProducts1.Visible = false;
            ucServices1.Visible = true;
        }
    }
}

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

namespace ManagementSystem
{
    public partial class MainMenuForm : Form
    {
        String connection = string.Empty;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public MainMenuForm()
        {
            InitializeComponent();
            String path = "C:\\CustomConfig\\CustomConfig.ini";
            connection = new DbConnect("Custom Config", path).getConnection();           
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btn_Patients_Click(object sender, EventArgs e)
        {
            ucPatients1.Visible = true;
            ucInventory1.Visible = false;
            ucpos1.Visible = false;
            ucPurchases1.Visible = false;
            ucSuppliers1.Visible = false;
            ucReports1.Visible = false;
        }

        private void btn_Inventory_Click(object sender, EventArgs e)
        {
            ucPatients1.Visible = false;
            ucInventory1.Visible = true;
            ucpos1.Visible = false;
            ucPurchases1.Visible = false;
            ucSuppliers1.Visible = false;
            ucReports1.Visible = false;
        }

        private void btn_POS_Click(object sender, EventArgs e)
        {
            ucPatients1.Visible = false;
            ucInventory1.Visible = false;
            ucpos1.Visible = true;
            ucPurchases1.Visible = false;
            ucSuppliers1.Visible = false;
            ucReports1.Visible = false;
        }

        private void btn_Purchases_Click(object sender, EventArgs e)
        {
            ucPatients1.Visible = false;
            ucInventory1.Visible = false;
            ucpos1.Visible = false;
            ucPurchases1.Visible = true;
            ucSuppliers1.Visible = false;
            ucReports1.Visible = false;
        }

        private void btn_Suppliers_Click(object sender, EventArgs e)
        {
            ucPatients1.Visible = false;
            ucInventory1.Visible = false;
            ucpos1.Visible = false;
            ucPurchases1.Visible = false;
            ucSuppliers1.Visible = true;
            ucReports1.Visible = false;
        }

        private void btn_Reports_Click(object sender, EventArgs e)
        {
            ucPatients1.Visible = false;
            ucInventory1.Visible = false;
            ucpos1.Visible = false;
            ucPurchases1.Visible = false;
            ucSuppliers1.Visible = false;
            ucReports1.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            NavDateTime.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy h:mm tt");
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}

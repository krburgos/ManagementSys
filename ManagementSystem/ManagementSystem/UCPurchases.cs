using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManagementSystem.PurchasesForms;

namespace ManagementSystem
{
    public partial class UCPurchases : UserControl
    {
        public UCPurchases()
        {
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            PurchasesForm pf = new PurchasesForm();
            pf.Show();
            pf.btn_Update.Visible = false;
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            PurchasesForm pf = new PurchasesForm();
            pf.Show();
            pf.btn_Create.Visible = false;
        }
    }
}

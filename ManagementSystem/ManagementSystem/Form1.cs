using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementSystem
{
    public partial class UserLogin : Form
    {
        public UserLogin()
        {
            InitializeComponent();
        }

        private void txt_Password_OnValueChanged(object sender, EventArgs e)
        {
            txt_Password.isPassword = true;
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            txt_Username.Text = "";
            txt_Password.Text = "";
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (txt_Username.Text == "admin" && txt_Password.Text == "1234"){
                UserLogin ul = new UserLogin();
                this.Hide();
                MainMenuForm mm = new MainMenuForm();
                mm.Show();
            }
            else
            {
                MessageBox.Show("Invalid credentials.", "Error");
            }
        }

        private void txt_Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (txt_Username.Text == "admin" && txt_Password.Text == "1234")
                {
                    UserLogin ul = new UserLogin();
                    this.Hide();
                    MainMenuForm mm = new MainMenuForm();
                    mm.Show();
                }
                else
                {
                    MessageBox.Show("Invalid credentials.", "Error");
                }
            }
        }
    }
}

namespace ManagementSystem
{
    partial class ManagePatientForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagePatientForm));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Close = new System.Windows.Forms.Label();
            this.txt_FirstName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_MiddleName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_LastName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_Address = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_Age = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.down_Gender = new Bunifu.Framework.UI.BunifuDropdown();
            this.down_Status = new Bunifu.Framework.UI.BunifuDropdown();
            this.btn_Add = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_Update = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(177, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patient Information";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.btn_Close);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(492, 34);
            this.panel1.TabIndex = 1;
            // 
            // btn_Close
            // 
            this.btn_Close.AutoSize = true;
            this.btn_Close.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.ForeColor = System.Drawing.Color.White;
            this.btn_Close.Location = new System.Drawing.Point(469, 9);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(20, 19);
            this.btn_Close.TabIndex = 23;
            this.btn_Close.Text = "X";
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // txt_FirstName
            // 
            this.txt_FirstName.BorderColorFocused = System.Drawing.Color.Purple;
            this.txt_FirstName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_FirstName.BorderColorMouseHover = System.Drawing.Color.Purple;
            this.txt_FirstName.BorderThickness = 1;
            this.txt_FirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_FirstName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_FirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_FirstName.isPassword = false;
            this.txt_FirstName.Location = new System.Drawing.Point(14, 35);
            this.txt_FirstName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_FirstName.Name = "txt_FirstName";
            this.txt_FirstName.Size = new System.Drawing.Size(146, 35);
            this.txt_FirstName.TabIndex = 2;
            this.txt_FirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_MiddleName
            // 
            this.txt_MiddleName.BorderColorFocused = System.Drawing.Color.Purple;
            this.txt_MiddleName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_MiddleName.BorderColorMouseHover = System.Drawing.Color.Purple;
            this.txt_MiddleName.BorderThickness = 1;
            this.txt_MiddleName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_MiddleName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_MiddleName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_MiddleName.isPassword = false;
            this.txt_MiddleName.Location = new System.Drawing.Point(168, 35);
            this.txt_MiddleName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MiddleName.Name = "txt_MiddleName";
            this.txt_MiddleName.Size = new System.Drawing.Size(153, 35);
            this.txt_MiddleName.TabIndex = 3;
            this.txt_MiddleName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_LastName
            // 
            this.txt_LastName.BorderColorFocused = System.Drawing.Color.Purple;
            this.txt_LastName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_LastName.BorderColorMouseHover = System.Drawing.Color.Purple;
            this.txt_LastName.BorderThickness = 1;
            this.txt_LastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_LastName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_LastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_LastName.isPassword = false;
            this.txt_LastName.Location = new System.Drawing.Point(329, 35);
            this.txt_LastName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_LastName.Name = "txt_LastName";
            this.txt_LastName.Size = new System.Drawing.Size(145, 35);
            this.txt_LastName.TabIndex = 4;
            this.txt_LastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_Address
            // 
            this.txt_Address.BorderColorFocused = System.Drawing.Color.Purple;
            this.txt_Address.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Address.BorderColorMouseHover = System.Drawing.Color.Purple;
            this.txt_Address.BorderThickness = 1;
            this.txt_Address.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Address.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_Address.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Address.isPassword = false;
            this.txt_Address.Location = new System.Drawing.Point(14, 102);
            this.txt_Address.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(460, 35);
            this.txt_Address.TabIndex = 5;
            this.txt_Address.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_Age
            // 
            this.txt_Age.BorderColorFocused = System.Drawing.Color.Purple;
            this.txt_Age.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Age.BorderColorMouseHover = System.Drawing.Color.Purple;
            this.txt_Age.BorderThickness = 1;
            this.txt_Age.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Age.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_Age.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Age.isPassword = false;
            this.txt_Age.Location = new System.Drawing.Point(436, 176);
            this.txt_Age.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Age.Name = "txt_Age";
            this.txt_Age.Size = new System.Drawing.Size(38, 33);
            this.txt_Age.TabIndex = 10;
            this.txt_Age.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(326, 14);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(77, 17);
            this.bunifuCustomLabel1.TabIndex = 13;
            this.bunifuCustomLabel1.Text = "Last Name";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(11, 14);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(75, 17);
            this.bunifuCustomLabel2.TabIndex = 14;
            this.bunifuCustomLabel2.Text = "First Name";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(165, 14);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(95, 17);
            this.bunifuCustomLabel3.TabIndex = 15;
            this.bunifuCustomLabel3.Text = "Middle Name";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(11, 81);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(57, 17);
            this.bunifuCustomLabel4.TabIndex = 16;
            this.bunifuCustomLabel4.Text = "Address";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(431, 156);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(34, 17);
            this.bunifuCustomLabel5.TabIndex = 17;
            this.bunifuCustomLabel5.Text = "Age";
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(12, 156);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(78, 17);
            this.bunifuCustomLabel6.TabIndex = 18;
            this.bunifuCustomLabel6.Text = "Civil Status";
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(212, 156);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(56, 17);
            this.bunifuCustomLabel7.TabIndex = 20;
            this.bunifuCustomLabel7.Text = "Gender";
            // 
            // down_Gender
            // 
            this.down_Gender.BackColor = System.Drawing.Color.Transparent;
            this.down_Gender.BorderRadius = 3;
            this.down_Gender.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.down_Gender.DisabledColor = System.Drawing.Color.Gray;
            this.down_Gender.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.down_Gender.ForeColor = System.Drawing.Color.Black;
            this.down_Gender.Items = new string[] {
        "Male",
        "Female"};
            this.down_Gender.Location = new System.Drawing.Point(215, 176);
            this.down_Gender.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.down_Gender.Name = "down_Gender";
            this.down_Gender.NomalColor = System.Drawing.Color.White;
            this.down_Gender.onHoverColor = System.Drawing.Color.White;
            this.down_Gender.selectedIndex = -1;
            this.down_Gender.Size = new System.Drawing.Size(195, 33);
            this.down_Gender.TabIndex = 19;
            // 
            // down_Status
            // 
            this.down_Status.BackColor = System.Drawing.Color.Transparent;
            this.down_Status.BorderRadius = 3;
            this.down_Status.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.down_Status.DisabledColor = System.Drawing.Color.Gray;
            this.down_Status.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.down_Status.ForeColor = System.Drawing.Color.Black;
            this.down_Status.Items = new string[] {
        "Single",
        "Married",
        "Legally Separated",
        "Divorced",
        "Widowed"};
            this.down_Status.Location = new System.Drawing.Point(15, 177);
            this.down_Status.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.down_Status.Name = "down_Status";
            this.down_Status.NomalColor = System.Drawing.Color.White;
            this.down_Status.onHoverColor = System.Drawing.Color.White;
            this.down_Status.selectedIndex = -1;
            this.down_Status.Size = new System.Drawing.Size(179, 33);
            this.down_Status.TabIndex = 12;
            // 
            // btn_Add
            // 
            this.btn_Add.ActiveBorderThickness = 1;
            this.btn_Add.ActiveCornerRadius = 20;
            this.btn_Add.ActiveFillColor = System.Drawing.Color.Purple;
            this.btn_Add.ActiveForecolor = System.Drawing.Color.White;
            this.btn_Add.ActiveLineColor = System.Drawing.Color.Purple;
            this.btn_Add.BackColor = System.Drawing.Color.White;
            this.btn_Add.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Add.BackgroundImage")));
            this.btn_Add.ButtonText = "Add";
            this.btn_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Add.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.Color.Black;
            this.btn_Add.IdleBorderThickness = 1;
            this.btn_Add.IdleCornerRadius = 20;
            this.btn_Add.IdleFillColor = System.Drawing.Color.White;
            this.btn_Add.IdleForecolor = System.Drawing.Color.Black;
            this.btn_Add.IdleLineColor = System.Drawing.Color.Black;
            this.btn_Add.Location = new System.Drawing.Point(15, 226);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(82, 41);
            this.btn_Add.TabIndex = 21;
            this.btn_Add.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.ActiveBorderThickness = 1;
            this.btn_Update.ActiveCornerRadius = 20;
            this.btn_Update.ActiveFillColor = System.Drawing.Color.Purple;
            this.btn_Update.ActiveForecolor = System.Drawing.Color.White;
            this.btn_Update.ActiveLineColor = System.Drawing.Color.Purple;
            this.btn_Update.BackColor = System.Drawing.Color.White;
            this.btn_Update.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Update.BackgroundImage")));
            this.btn_Update.ButtonText = "Update";
            this.btn_Update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Update.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.ForeColor = System.Drawing.Color.Black;
            this.btn_Update.IdleBorderThickness = 1;
            this.btn_Update.IdleCornerRadius = 20;
            this.btn_Update.IdleFillColor = System.Drawing.Color.White;
            this.btn_Update.IdleForecolor = System.Drawing.Color.Black;
            this.btn_Update.IdleLineColor = System.Drawing.Color.Black;
            this.btn_Update.Location = new System.Drawing.Point(396, 226);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(82, 41);
            this.btn_Update.TabIndex = 23;
            this.btn_Update.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txt_ID);
            this.panel2.Controls.Add(this.down_Gender);
            this.panel2.Controls.Add(this.bunifuCustomLabel7);
            this.panel2.Controls.Add(this.btn_Add);
            this.panel2.Controls.Add(this.bunifuCustomLabel6);
            this.panel2.Controls.Add(this.btn_Update);
            this.panel2.Controls.Add(this.bunifuCustomLabel4);
            this.panel2.Controls.Add(this.bunifuCustomLabel3);
            this.panel2.Controls.Add(this.bunifuCustomLabel1);
            this.panel2.Controls.Add(this.bunifuCustomLabel2);
            this.panel2.Controls.Add(this.bunifuCustomLabel5);
            this.panel2.Controls.Add(this.down_Status);
            this.panel2.Controls.Add(this.txt_Address);
            this.panel2.Controls.Add(this.txt_LastName);
            this.panel2.Controls.Add(this.txt_MiddleName);
            this.panel2.Controls.Add(this.txt_FirstName);
            this.panel2.Controls.Add(this.txt_Age);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(492, 276);
            this.panel2.TabIndex = 24;
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(207, 242);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(53, 20);
            this.txt_ID.TabIndex = 24;
            this.txt_ID.Visible = false;
            // 
            // ManagePatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(492, 310);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManagePatientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        public Bunifu.Framework.UI.BunifuMetroTextbox txt_FirstName;
        public Bunifu.Framework.UI.BunifuMetroTextbox txt_MiddleName;
        public Bunifu.Framework.UI.BunifuMetroTextbox txt_LastName;
        public Bunifu.Framework.UI.BunifuMetroTextbox txt_Address;
        public Bunifu.Framework.UI.BunifuMetroTextbox txt_Age;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        public Bunifu.Framework.UI.BunifuDropdown down_Gender;
        public Bunifu.Framework.UI.BunifuDropdown down_Status;
        private System.Windows.Forms.Label btn_Close;
        public Bunifu.Framework.UI.BunifuThinButton2 btn_Add;
        public Bunifu.Framework.UI.BunifuThinButton2 btn_Update;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.TextBox txt_ID;
    }
}
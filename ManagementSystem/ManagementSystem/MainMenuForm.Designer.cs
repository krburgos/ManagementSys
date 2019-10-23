namespace ManagementSystem
{
    partial class MainMenuForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            this.SidePanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btn_Suppliers = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Purchases = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Reports = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Inventory = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_POS = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Patients = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lableTitle = new System.Windows.Forms.Label();
            this.NavDateTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.dtTimer = new System.Windows.Forms.Timer(this.components);
            this.ucPatients1 = new ManagementSystem.UCPatients();
            this.ucPurchases1 = new ManagementSystem.UCPurchases();
            this.ucReports1 = new ManagementSystem.UCReports();
            this.ucSuppliers1 = new ManagementSystem.UCSuppliers();
            this.ucpos1 = new ManagementSystem.UCPOS();
            this.ucInventory1 = new ManagementSystem.UCInventory();
            this.SidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.TopPanel.SuspendLayout();
            this.ContentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SidePanel
            // 
            this.SidePanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SidePanel.BackgroundImage")));
            this.SidePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SidePanel.Controls.Add(this.btn_Suppliers);
            this.SidePanel.Controls.Add(this.btn_Purchases);
            this.SidePanel.Controls.Add(this.btn_Reports);
            this.SidePanel.Controls.Add(this.btn_Inventory);
            this.SidePanel.Controls.Add(this.btn_POS);
            this.SidePanel.Controls.Add(this.btn_Patients);
            this.SidePanel.Controls.Add(this.pictureBox1);
            this.SidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidePanel.GradientBottomLeft = System.Drawing.Color.Purple;
            this.SidePanel.GradientBottomRight = System.Drawing.Color.Purple;
            this.SidePanel.GradientTopLeft = System.Drawing.Color.Purple;
            this.SidePanel.GradientTopRight = System.Drawing.Color.Purple;
            this.SidePanel.Location = new System.Drawing.Point(0, 34);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Quality = 10;
            this.SidePanel.Size = new System.Drawing.Size(183, 551);
            this.SidePanel.TabIndex = 0;
            // 
            // btn_Suppliers
            // 
            this.btn_Suppliers.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_Suppliers.BackColor = System.Drawing.Color.Purple;
            this.btn_Suppliers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Suppliers.BorderRadius = 0;
            this.btn_Suppliers.ButtonText = "Suppliers";
            this.btn_Suppliers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Suppliers.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Suppliers.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Suppliers.Iconimage = null;
            this.btn_Suppliers.Iconimage_right = null;
            this.btn_Suppliers.Iconimage_right_Selected = null;
            this.btn_Suppliers.Iconimage_Selected = null;
            this.btn_Suppliers.IconMarginLeft = 0;
            this.btn_Suppliers.IconMarginRight = 0;
            this.btn_Suppliers.IconRightVisible = true;
            this.btn_Suppliers.IconRightZoom = 0D;
            this.btn_Suppliers.IconVisible = true;
            this.btn_Suppliers.IconZoom = 90D;
            this.btn_Suppliers.IsTab = false;
            this.btn_Suppliers.Location = new System.Drawing.Point(0, 403);
            this.btn_Suppliers.Name = "btn_Suppliers";
            this.btn_Suppliers.Normalcolor = System.Drawing.Color.Purple;
            this.btn_Suppliers.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_Suppliers.OnHoverTextColor = System.Drawing.Color.Black;
            this.btn_Suppliers.selected = false;
            this.btn_Suppliers.Size = new System.Drawing.Size(183, 54);
            this.btn_Suppliers.TabIndex = 9;
            this.btn_Suppliers.Text = "Suppliers";
            this.btn_Suppliers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Suppliers.Textcolor = System.Drawing.Color.White;
            this.btn_Suppliers.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Suppliers.Click += new System.EventHandler(this.btn_Suppliers_Click);
            // 
            // btn_Purchases
            // 
            this.btn_Purchases.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_Purchases.BackColor = System.Drawing.Color.Purple;
            this.btn_Purchases.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Purchases.BorderRadius = 0;
            this.btn_Purchases.ButtonText = "Purchases";
            this.btn_Purchases.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Purchases.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Purchases.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Purchases.Iconimage = null;
            this.btn_Purchases.Iconimage_right = null;
            this.btn_Purchases.Iconimage_right_Selected = null;
            this.btn_Purchases.Iconimage_Selected = null;
            this.btn_Purchases.IconMarginLeft = 0;
            this.btn_Purchases.IconMarginRight = 0;
            this.btn_Purchases.IconRightVisible = true;
            this.btn_Purchases.IconRightZoom = 0D;
            this.btn_Purchases.IconVisible = true;
            this.btn_Purchases.IconZoom = 90D;
            this.btn_Purchases.IsTab = false;
            this.btn_Purchases.Location = new System.Drawing.Point(0, 343);
            this.btn_Purchases.Name = "btn_Purchases";
            this.btn_Purchases.Normalcolor = System.Drawing.Color.Purple;
            this.btn_Purchases.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_Purchases.OnHoverTextColor = System.Drawing.Color.Black;
            this.btn_Purchases.selected = false;
            this.btn_Purchases.Size = new System.Drawing.Size(183, 54);
            this.btn_Purchases.TabIndex = 8;
            this.btn_Purchases.Text = "Purchases";
            this.btn_Purchases.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Purchases.Textcolor = System.Drawing.Color.White;
            this.btn_Purchases.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Purchases.Click += new System.EventHandler(this.btn_Purchases_Click);
            // 
            // btn_Reports
            // 
            this.btn_Reports.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_Reports.BackColor = System.Drawing.Color.Purple;
            this.btn_Reports.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Reports.BorderRadius = 0;
            this.btn_Reports.ButtonText = "Reports";
            this.btn_Reports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Reports.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Reports.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Reports.Iconimage = null;
            this.btn_Reports.Iconimage_right = null;
            this.btn_Reports.Iconimage_right_Selected = null;
            this.btn_Reports.Iconimage_Selected = null;
            this.btn_Reports.IconMarginLeft = 0;
            this.btn_Reports.IconMarginRight = 0;
            this.btn_Reports.IconRightVisible = true;
            this.btn_Reports.IconRightZoom = 0D;
            this.btn_Reports.IconVisible = true;
            this.btn_Reports.IconZoom = 90D;
            this.btn_Reports.IsTab = false;
            this.btn_Reports.Location = new System.Drawing.Point(0, 463);
            this.btn_Reports.Name = "btn_Reports";
            this.btn_Reports.Normalcolor = System.Drawing.Color.Purple;
            this.btn_Reports.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_Reports.OnHoverTextColor = System.Drawing.Color.Black;
            this.btn_Reports.selected = false;
            this.btn_Reports.Size = new System.Drawing.Size(183, 54);
            this.btn_Reports.TabIndex = 7;
            this.btn_Reports.Text = "Reports";
            this.btn_Reports.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Reports.Textcolor = System.Drawing.Color.White;
            this.btn_Reports.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reports.Click += new System.EventHandler(this.btn_Reports_Click);
            // 
            // btn_Inventory
            // 
            this.btn_Inventory.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_Inventory.BackColor = System.Drawing.Color.Purple;
            this.btn_Inventory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Inventory.BorderRadius = 0;
            this.btn_Inventory.ButtonText = "Inventory";
            this.btn_Inventory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Inventory.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Inventory.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Inventory.Iconimage = null;
            this.btn_Inventory.Iconimage_right = null;
            this.btn_Inventory.Iconimage_right_Selected = null;
            this.btn_Inventory.Iconimage_Selected = null;
            this.btn_Inventory.IconMarginLeft = 0;
            this.btn_Inventory.IconMarginRight = 0;
            this.btn_Inventory.IconRightVisible = true;
            this.btn_Inventory.IconRightZoom = 0D;
            this.btn_Inventory.IconVisible = true;
            this.btn_Inventory.IconZoom = 90D;
            this.btn_Inventory.IsTab = false;
            this.btn_Inventory.Location = new System.Drawing.Point(0, 283);
            this.btn_Inventory.Name = "btn_Inventory";
            this.btn_Inventory.Normalcolor = System.Drawing.Color.Purple;
            this.btn_Inventory.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_Inventory.OnHoverTextColor = System.Drawing.Color.Black;
            this.btn_Inventory.selected = false;
            this.btn_Inventory.Size = new System.Drawing.Size(183, 54);
            this.btn_Inventory.TabIndex = 6;
            this.btn_Inventory.Text = "Inventory";
            this.btn_Inventory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Inventory.Textcolor = System.Drawing.Color.White;
            this.btn_Inventory.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Inventory.Click += new System.EventHandler(this.btn_Inventory_Click);
            // 
            // btn_POS
            // 
            this.btn_POS.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_POS.BackColor = System.Drawing.Color.Purple;
            this.btn_POS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_POS.BorderRadius = 0;
            this.btn_POS.ButtonText = "POS";
            this.btn_POS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_POS.DisabledColor = System.Drawing.Color.Gray;
            this.btn_POS.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_POS.Iconimage = null;
            this.btn_POS.Iconimage_right = null;
            this.btn_POS.Iconimage_right_Selected = null;
            this.btn_POS.Iconimage_Selected = null;
            this.btn_POS.IconMarginLeft = 0;
            this.btn_POS.IconMarginRight = 0;
            this.btn_POS.IconRightVisible = true;
            this.btn_POS.IconRightZoom = 0D;
            this.btn_POS.IconVisible = true;
            this.btn_POS.IconZoom = 90D;
            this.btn_POS.IsTab = false;
            this.btn_POS.Location = new System.Drawing.Point(0, 223);
            this.btn_POS.Name = "btn_POS";
            this.btn_POS.Normalcolor = System.Drawing.Color.Purple;
            this.btn_POS.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_POS.OnHoverTextColor = System.Drawing.Color.Black;
            this.btn_POS.selected = false;
            this.btn_POS.Size = new System.Drawing.Size(183, 54);
            this.btn_POS.TabIndex = 5;
            this.btn_POS.Text = "POS";
            this.btn_POS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_POS.Textcolor = System.Drawing.Color.White;
            this.btn_POS.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_POS.Click += new System.EventHandler(this.btn_POS_Click);
            // 
            // btn_Patients
            // 
            this.btn_Patients.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_Patients.BackColor = System.Drawing.Color.Purple;
            this.btn_Patients.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Patients.BorderRadius = 0;
            this.btn_Patients.ButtonText = "Patients";
            this.btn_Patients.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Patients.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Patients.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Patients.Iconimage = null;
            this.btn_Patients.Iconimage_right = null;
            this.btn_Patients.Iconimage_right_Selected = null;
            this.btn_Patients.Iconimage_Selected = null;
            this.btn_Patients.IconMarginLeft = 0;
            this.btn_Patients.IconMarginRight = 0;
            this.btn_Patients.IconRightVisible = true;
            this.btn_Patients.IconRightZoom = 0D;
            this.btn_Patients.IconVisible = true;
            this.btn_Patients.IconZoom = 90D;
            this.btn_Patients.IsTab = false;
            this.btn_Patients.Location = new System.Drawing.Point(0, 163);
            this.btn_Patients.Name = "btn_Patients";
            this.btn_Patients.Normalcolor = System.Drawing.Color.Purple;
            this.btn_Patients.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_Patients.OnHoverTextColor = System.Drawing.Color.Black;
            this.btn_Patients.selected = false;
            this.btn_Patients.Size = new System.Drawing.Size(183, 54);
            this.btn_Patients.TabIndex = 4;
            this.btn_Patients.Text = "Patients";
            this.btn_Patients.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Patients.Textcolor = System.Drawing.Color.White;
            this.btn_Patients.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Patients.Click += new System.EventHandler(this.btn_Patients_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.Black;
            this.TopPanel.Controls.Add(this.label2);
            this.TopPanel.Controls.Add(this.lableTitle);
            this.TopPanel.Controls.Add(this.NavDateTime);
            this.TopPanel.Controls.Add(this.label1);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(954, 34);
            this.TopPanel.TabIndex = 1;
            this.TopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(899, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "_";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lableTitle
            // 
            this.lableTitle.AutoSize = true;
            this.lableTitle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableTitle.ForeColor = System.Drawing.Color.White;
            this.lableTitle.Location = new System.Drawing.Point(12, 9);
            this.lableTitle.Name = "lableTitle";
            this.lableTitle.Size = new System.Drawing.Size(236, 17);
            this.lableTitle.TabIndex = 2;
            this.lableTitle.Text = "Skin Care Management System     |";
            // 
            // NavDateTime
            // 
            this.NavDateTime.AutoSize = true;
            this.NavDateTime.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NavDateTime.ForeColor = System.Drawing.Color.White;
            this.NavDateTime.Location = new System.Drawing.Point(263, 9);
            this.NavDateTime.Name = "NavDateTime";
            this.NavDateTime.Size = new System.Drawing.Size(0, 17);
            this.NavDateTime.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(922, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ContentPanel
            // 
            this.ContentPanel.BackColor = System.Drawing.Color.Gray;
            this.ContentPanel.Controls.Add(this.ucPatients1);
            this.ContentPanel.Controls.Add(this.ucPurchases1);
            this.ContentPanel.Controls.Add(this.ucReports1);
            this.ContentPanel.Controls.Add(this.ucSuppliers1);
            this.ContentPanel.Controls.Add(this.ucpos1);
            this.ContentPanel.Controls.Add(this.ucInventory1);
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentPanel.Location = new System.Drawing.Point(183, 34);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(771, 551);
            this.ContentPanel.TabIndex = 2;
            // 
            // dtTimer
            // 
            this.dtTimer.Enabled = true;
            this.dtTimer.Interval = 1000;
            this.dtTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ucPatients1
            // 
            this.ucPatients1.BackColor = System.Drawing.Color.White;
            this.ucPatients1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPatients1.Location = new System.Drawing.Point(0, 0);
            this.ucPatients1.Name = "ucPatients1";
            this.ucPatients1.Size = new System.Drawing.Size(771, 551);
            this.ucPatients1.TabIndex = 0;
            // 
            // ucPurchases1
            // 
            this.ucPurchases1.BackColor = System.Drawing.Color.White;
            this.ucPurchases1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPurchases1.Location = new System.Drawing.Point(0, 0);
            this.ucPurchases1.Name = "ucPurchases1";
            this.ucPurchases1.Size = new System.Drawing.Size(771, 551);
            this.ucPurchases1.TabIndex = 5;
            // 
            // ucReports1
            // 
            this.ucReports1.BackColor = System.Drawing.Color.White;
            this.ucReports1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucReports1.Location = new System.Drawing.Point(0, 0);
            this.ucReports1.Name = "ucReports1";
            this.ucReports1.Size = new System.Drawing.Size(771, 551);
            this.ucReports1.TabIndex = 4;
            // 
            // ucSuppliers1
            // 
            this.ucSuppliers1.BackColor = System.Drawing.Color.White;
            this.ucSuppliers1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucSuppliers1.Location = new System.Drawing.Point(0, 0);
            this.ucSuppliers1.Name = "ucSuppliers1";
            this.ucSuppliers1.Size = new System.Drawing.Size(771, 551);
            this.ucSuppliers1.TabIndex = 3;
            // 
            // ucpos1
            // 
            this.ucpos1.BackColor = System.Drawing.Color.White;
            this.ucpos1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucpos1.Location = new System.Drawing.Point(0, 0);
            this.ucpos1.Name = "ucpos1";
            this.ucpos1.Size = new System.Drawing.Size(771, 551);
            this.ucpos1.TabIndex = 2;
            // 
            // ucInventory1
            // 
            this.ucInventory1.BackColor = System.Drawing.Color.White;
            this.ucInventory1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucInventory1.Location = new System.Drawing.Point(0, 0);
            this.ucInventory1.Name = "ucInventory1";
            this.ucInventory1.Size = new System.Drawing.Size(771, 551);
            this.ucInventory1.TabIndex = 1;
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 585);
            this.Controls.Add(this.ContentPanel);
            this.Controls.Add(this.SidePanel);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.SidePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.ContentPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel SidePanel;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Patients;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Suppliers;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Purchases;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Reports;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Inventory;
        private Bunifu.Framework.UI.BunifuFlatButton btn_POS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel ContentPanel;
        private UCPatients ucPatients1;
        private UCInventory ucInventory1;
        private UCPurchases ucPurchases1;
        private UCReports ucReports1;
        private UCSuppliers ucSuppliers1;
        private UCPOS ucpos1;
        private System.Windows.Forms.Label NavDateTime;
        private System.Windows.Forms.Timer dtTimer;
        private System.Windows.Forms.Label lableTitle;
        private System.Windows.Forms.Label label2;
    }
}
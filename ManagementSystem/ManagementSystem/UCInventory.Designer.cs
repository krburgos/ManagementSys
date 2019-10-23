namespace ManagementSystem
{
    partial class UCInventory
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Nav = new System.Windows.Forms.Panel();
            this.InvContent = new System.Windows.Forms.Panel();
            this.btn_Products = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Services = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ucProducts1 = new ManagementSystem.UCProducts();
            this.ucServices1 = new ManagementSystem.UCServices();
            this.panel1.SuspendLayout();
            this.Nav.SuspendLayout();
            this.InvContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inventory";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 54);
            this.panel1.TabIndex = 12;
            // 
            // Nav
            // 
            this.Nav.BackColor = System.Drawing.Color.Black;
            this.Nav.Controls.Add(this.btn_Services);
            this.Nav.Controls.Add(this.btn_Products);
            this.Nav.Dock = System.Windows.Forms.DockStyle.Top;
            this.Nav.Location = new System.Drawing.Point(0, 54);
            this.Nav.Name = "Nav";
            this.Nav.Size = new System.Drawing.Size(775, 44);
            this.Nav.TabIndex = 13;
            // 
            // InvContent
            // 
            this.InvContent.Controls.Add(this.ucProducts1);
            this.InvContent.Controls.Add(this.ucServices1);
            this.InvContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InvContent.Location = new System.Drawing.Point(0, 98);
            this.InvContent.Name = "InvContent";
            this.InvContent.Size = new System.Drawing.Size(775, 437);
            this.InvContent.TabIndex = 14;
            // 
            // btn_Products
            // 
            this.btn_Products.Activecolor = System.Drawing.Color.Purple;
            this.btn_Products.BackColor = System.Drawing.Color.Black;
            this.btn_Products.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Products.BorderRadius = 0;
            this.btn_Products.ButtonText = "Products";
            this.btn_Products.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Products.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Products.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Products.Iconimage = null;
            this.btn_Products.Iconimage_right = null;
            this.btn_Products.Iconimage_right_Selected = null;
            this.btn_Products.Iconimage_Selected = null;
            this.btn_Products.IconMarginLeft = 0;
            this.btn_Products.IconMarginRight = 0;
            this.btn_Products.IconRightVisible = true;
            this.btn_Products.IconRightZoom = 0D;
            this.btn_Products.IconVisible = true;
            this.btn_Products.IconZoom = 90D;
            this.btn_Products.IsTab = false;
            this.btn_Products.Location = new System.Drawing.Point(0, 0);
            this.btn_Products.Name = "btn_Products";
            this.btn_Products.Normalcolor = System.Drawing.Color.Black;
            this.btn_Products.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_Products.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Products.selected = false;
            this.btn_Products.Size = new System.Drawing.Size(106, 44);
            this.btn_Products.TabIndex = 0;
            this.btn_Products.Text = "Products";
            this.btn_Products.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Products.Textcolor = System.Drawing.Color.White;
            this.btn_Products.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Products.Click += new System.EventHandler(this.btn_Products_Click);
            // 
            // btn_Services
            // 
            this.btn_Services.Activecolor = System.Drawing.Color.Purple;
            this.btn_Services.BackColor = System.Drawing.Color.Black;
            this.btn_Services.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Services.BorderRadius = 0;
            this.btn_Services.ButtonText = "Services";
            this.btn_Services.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Services.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Services.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Services.Iconimage = null;
            this.btn_Services.Iconimage_right = null;
            this.btn_Services.Iconimage_right_Selected = null;
            this.btn_Services.Iconimage_Selected = null;
            this.btn_Services.IconMarginLeft = 0;
            this.btn_Services.IconMarginRight = 0;
            this.btn_Services.IconRightVisible = true;
            this.btn_Services.IconRightZoom = 0D;
            this.btn_Services.IconVisible = true;
            this.btn_Services.IconZoom = 90D;
            this.btn_Services.IsTab = false;
            this.btn_Services.Location = new System.Drawing.Point(112, 0);
            this.btn_Services.Name = "btn_Services";
            this.btn_Services.Normalcolor = System.Drawing.Color.Black;
            this.btn_Services.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_Services.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Services.selected = false;
            this.btn_Services.Size = new System.Drawing.Size(106, 44);
            this.btn_Services.TabIndex = 1;
            this.btn_Services.Text = "Services";
            this.btn_Services.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Services.Textcolor = System.Drawing.Color.White;
            this.btn_Services.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Services.Click += new System.EventHandler(this.btn_Services_Click);
            // 
            // ucProducts1
            // 
            this.ucProducts1.BackColor = System.Drawing.Color.White;
            this.ucProducts1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucProducts1.Location = new System.Drawing.Point(0, 0);
            this.ucProducts1.Name = "ucProducts1";
            this.ucProducts1.Size = new System.Drawing.Size(775, 437);
            this.ucProducts1.TabIndex = 0;
            // 
            // ucServices1
            // 
            this.ucServices1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucServices1.Location = new System.Drawing.Point(0, 0);
            this.ucServices1.Name = "ucServices1";
            this.ucServices1.Size = new System.Drawing.Size(775, 437);
            this.ucServices1.TabIndex = 1;
            // 
            // UCInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.InvContent);
            this.Controls.Add(this.Nav);
            this.Controls.Add(this.panel1);
            this.Name = "UCInventory";
            this.Size = new System.Drawing.Size(775, 535);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Nav.ResumeLayout(false);
            this.InvContent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel Nav;
        private System.Windows.Forms.Panel InvContent;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Products;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Services;
        private UCProducts ucProducts1;
        private UCServices ucServices1;

    }
}

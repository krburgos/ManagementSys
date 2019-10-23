namespace ManagementSystem.InventoryForms
{
    partial class NewItemForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewItemForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Close = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.txt_ProductName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_ProductDesc = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.cbox_Suppliers = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Update = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Price = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Quantity = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Add = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.btn_Close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(314, 37);
            this.panel1.TabIndex = 0;
            // 
            // btn_Close
            // 
            this.btn_Close.AutoSize = true;
            this.btn_Close.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.ForeColor = System.Drawing.Color.White;
            this.btn_Close.Location = new System.Drawing.Point(291, 15);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(20, 19);
            this.btn_Close.TabIndex = 25;
            this.btn_Close.Text = "X";
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(314, 436);
            this.panel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.txt_ID);
            this.groupBox1.Controls.Add(this.txt_ProductName);
            this.groupBox1.Controls.Add(this.txt_ProductDesc);
            this.groupBox1.Controls.Add(this.cbox_Suppliers);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btn_Update);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_Price);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_Quantity);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn_Add);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(11, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 416);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product Information";
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(224, 22);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(44, 23);
            this.txt_ID.TabIndex = 22;
            this.txt_ID.Visible = false;
            // 
            // txt_ProductName
            // 
            this.txt_ProductName.BorderColorFocused = System.Drawing.Color.Purple;
            this.txt_ProductName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_ProductName.BorderColorMouseHover = System.Drawing.Color.Purple;
            this.txt_ProductName.BorderThickness = 2;
            this.txt_ProductName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ProductName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_ProductName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_ProductName.isPassword = false;
            this.txt_ProductName.Location = new System.Drawing.Point(21, 56);
            this.txt_ProductName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ProductName.Name = "txt_ProductName";
            this.txt_ProductName.Size = new System.Drawing.Size(247, 32);
            this.txt_ProductName.TabIndex = 21;
            this.txt_ProductName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_ProductDesc
            // 
            this.txt_ProductDesc.BorderColorFocused = System.Drawing.Color.Purple;
            this.txt_ProductDesc.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_ProductDesc.BorderColorMouseHover = System.Drawing.Color.Purple;
            this.txt_ProductDesc.BorderThickness = 2;
            this.txt_ProductDesc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ProductDesc.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_ProductDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_ProductDesc.isPassword = false;
            this.txt_ProductDesc.Location = new System.Drawing.Point(20, 123);
            this.txt_ProductDesc.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ProductDesc.Name = "txt_ProductDesc";
            this.txt_ProductDesc.Size = new System.Drawing.Size(247, 32);
            this.txt_ProductDesc.TabIndex = 20;
            this.txt_ProductDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // cbox_Suppliers
            // 
            this.cbox_Suppliers.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbox_Suppliers.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbox_Suppliers.FormattingEnabled = true;
            this.cbox_Suppliers.Location = new System.Drawing.Point(21, 190);
            this.cbox_Suppliers.Name = "cbox_Suppliers";
            this.cbox_Suppliers.Size = new System.Drawing.Size(247, 25);
            this.cbox_Suppliers.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Supplier";
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
            this.btn_Update.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.ForeColor = System.Drawing.Color.Black;
            this.btn_Update.IdleBorderThickness = 1;
            this.btn_Update.IdleCornerRadius = 20;
            this.btn_Update.IdleFillColor = System.Drawing.Color.White;
            this.btn_Update.IdleForecolor = System.Drawing.Color.Black;
            this.btn_Update.IdleLineColor = System.Drawing.Color.Black;
            this.btn_Update.Location = new System.Drawing.Point(192, 365);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 40);
            this.btn_Update.TabIndex = 13;
            this.btn_Update.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Price";
            // 
            // txt_Price
            // 
            this.txt_Price.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_Price.BorderColorFocused = System.Drawing.Color.Purple;
            this.txt_Price.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Price.BorderColorMouseHover = System.Drawing.Color.Purple;
            this.txt_Price.BorderThickness = 2;
            this.txt_Price.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Price.Enabled = false;
            this.txt_Price.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_Price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Price.isPassword = false;
            this.txt_Price.Location = new System.Drawing.Point(20, 319);
            this.txt_Price.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(247, 32);
            this.txt_Price.TabIndex = 6;
            this.txt_Price.Text = "0.00";
            this.txt_Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Quantity";
            // 
            // txt_Quantity
            // 
            this.txt_Quantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_Quantity.BorderColorFocused = System.Drawing.Color.Purple;
            this.txt_Quantity.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Quantity.BorderColorMouseHover = System.Drawing.Color.Purple;
            this.txt_Quantity.BorderThickness = 2;
            this.txt_Quantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Quantity.Enabled = false;
            this.txt_Quantity.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_Quantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Quantity.isPassword = false;
            this.txt_Quantity.Location = new System.Drawing.Point(20, 253);
            this.txt_Quantity.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Quantity.Name = "txt_Quantity";
            this.txt_Quantity.Size = new System.Drawing.Size(247, 32);
            this.txt_Quantity.TabIndex = 4;
            this.txt_Quantity.Text = "0";
            this.txt_Quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Product Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Product Description";
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
            this.btn_Add.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.Color.Black;
            this.btn_Add.IdleBorderThickness = 1;
            this.btn_Add.IdleCornerRadius = 20;
            this.btn_Add.IdleFillColor = System.Drawing.Color.White;
            this.btn_Add.IdleForecolor = System.Drawing.Color.Black;
            this.btn_Add.IdleLineColor = System.Drawing.Color.Black;
            this.btn_Add.Location = new System.Drawing.Point(20, 365);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 40);
            this.btn_Add.TabIndex = 12;
            this.btn_Add.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NewItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 473);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewItemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label btn_Close;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox txt_ID;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_ProductName;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_ProductDesc;
        private System.Windows.Forms.ComboBox cbox_Suppliers;
        private System.Windows.Forms.Label label3;
        public Bunifu.Framework.UI.BunifuThinButton2 btn_Update;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_Price;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_Quantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        public Bunifu.Framework.UI.BunifuThinButton2 btn_Add;
    }
}
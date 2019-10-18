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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCInventory));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle41 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle42 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle43 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle44 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle45 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Add = new Bunifu.Framework.UI.BunifuThinButton2();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_ProductName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_Desc = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Quantity = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Price = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Update = new Bunifu.Framework.UI.BunifuThinButton2();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_ID = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_Search = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.ProductsDataGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDataGrid)).BeginInit();
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
            this.btn_Add.Location = new System.Drawing.Point(61, 304);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 40);
            this.btn_Add.TabIndex = 12;
            this.btn_Add.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btn_Update);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_Price);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_Quantity);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn_Add);
            this.groupBox1.Controls.Add(this.txt_Desc);
            this.groupBox1.Controls.Add(this.txt_ProductName);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(23, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 452);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product Information";
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
            this.txt_ProductName.Location = new System.Drawing.Point(20, 48);
            this.txt_ProductName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ProductName.Name = "txt_ProductName";
            this.txt_ProductName.Size = new System.Drawing.Size(247, 32);
            this.txt_ProductName.TabIndex = 0;
            this.txt_ProductName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_Desc
            // 
            this.txt_Desc.BorderColorFocused = System.Drawing.Color.Purple;
            this.txt_Desc.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Desc.BorderColorMouseHover = System.Drawing.Color.Purple;
            this.txt_Desc.BorderThickness = 2;
            this.txt_Desc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Desc.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_Desc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Desc.isPassword = false;
            this.txt_Desc.Location = new System.Drawing.Point(20, 115);
            this.txt_Desc.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Desc.Name = "txt_Desc";
            this.txt_Desc.Size = new System.Drawing.Size(247, 32);
            this.txt_Desc.TabIndex = 1;
            this.txt_Desc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Product Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Product Name";
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
            this.txt_Quantity.Location = new System.Drawing.Point(20, 181);
            this.txt_Quantity.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Quantity.Name = "txt_Quantity";
            this.txt_Quantity.Size = new System.Drawing.Size(247, 32);
            this.txt_Quantity.TabIndex = 4;
            this.txt_Quantity.Text = "0";
            this.txt_Quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Quantity";
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
            this.txt_Price.Location = new System.Drawing.Point(20, 247);
            this.txt_Price.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(247, 32);
            this.txt_Price.TabIndex = 6;
            this.txt_Price.Text = "0.00";
            this.txt_Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Price";
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
            this.btn_Update.Location = new System.Drawing.Point(144, 304);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 40);
            this.btn_Update.TabIndex = 13;
            this.btn_Update.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_ID);
            this.groupBox2.Controls.Add(this.txt_Search);
            this.groupBox2.Controls.Add(this.ProductsDataGrid);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(329, 80);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(415, 452);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Products";
            // 
            // txt_ID
            // 
            this.txt_ID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_ID.BorderColorFocused = System.Drawing.Color.Black;
            this.txt_ID.BorderColorIdle = System.Drawing.Color.Purple;
            this.txt_ID.BorderColorMouseHover = System.Drawing.Color.Purple;
            this.txt_ID.BorderThickness = 2;
            this.txt_ID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ID.Enabled = false;
            this.txt_ID.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_ID.isPassword = false;
            this.txt_ID.Location = new System.Drawing.Point(266, 23);
            this.txt_ID.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(41, 37);
            this.txt_ID.TabIndex = 18;
            this.txt_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_ID.Visible = false;
            // 
            // txt_Search
            // 
            this.txt_Search.BorderColorFocused = System.Drawing.Color.Black;
            this.txt_Search.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Search.BorderColorMouseHover = System.Drawing.Color.Purple;
            this.txt_Search.BorderThickness = 2;
            this.txt_Search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Search.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_Search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Search.isPassword = false;
            this.txt_Search.Location = new System.Drawing.Point(18, 23);
            this.txt_Search.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(240, 37);
            this.txt_Search.TabIndex = 17;
            this.txt_Search.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // ProductsDataGrid
            // 
            this.ProductsDataGrid.AllowUserToAddRows = false;
            this.ProductsDataGrid.AllowUserToDeleteRows = false;
            this.ProductsDataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle41.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle41.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ProductsDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle41;
            this.ProductsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProductsDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.ProductsDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProductsDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle42.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle42.BackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle42.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle42.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle42.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle42.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle42.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductsDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle42;
            this.ProductsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle43.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle43.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle43.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle43.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle43.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle43.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle43.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProductsDataGrid.DefaultCellStyle = dataGridViewCellStyle43;
            this.ProductsDataGrid.DoubleBuffered = true;
            this.ProductsDataGrid.EnableHeadersVisualStyles = false;
            this.ProductsDataGrid.GridColor = System.Drawing.Color.White;
            this.ProductsDataGrid.HeaderBgColor = System.Drawing.Color.Purple;
            this.ProductsDataGrid.HeaderForeColor = System.Drawing.Color.White;
            this.ProductsDataGrid.Location = new System.Drawing.Point(18, 83);
            this.ProductsDataGrid.MultiSelect = false;
            this.ProductsDataGrid.Name = "ProductsDataGrid";
            this.ProductsDataGrid.ReadOnly = true;
            this.ProductsDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle44.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle44.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle44.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle44.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle44.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle44.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle44.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductsDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle44;
            this.ProductsDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle45.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ProductsDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle45;
            this.ProductsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductsDataGrid.Size = new System.Drawing.Size(379, 348);
            this.ProductsDataGrid.TabIndex = 16;
            // 
            // UCInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "UCInventory";
            this.Size = new System.Drawing.Size(775, 535);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_Add;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_Update;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_Price;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_Quantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_Desc;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_ProductName;
        private System.Windows.Forms.GroupBox groupBox2;
        public Bunifu.Framework.UI.BunifuMetroTextbox txt_ID;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_Search;
        public Bunifu.Framework.UI.BunifuCustomDataGrid ProductsDataGrid;

    }
}

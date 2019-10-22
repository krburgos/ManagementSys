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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ProductID = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btn_Add = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_RefreshProd = new Bunifu.Framework.UI.BunifuThinButton2();
            this.ProductsDataGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btn_Edit = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txt_SearchProduct = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_SearchService = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btn_EditService = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txt_ServiceID = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.ServicesDataGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btn_AddService = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_RefreshServ = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDataGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ServicesDataGrid)).BeginInit();
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Search by Product Name";
            // 
            // txt_ProductID
            // 
            this.txt_ProductID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_ProductID.BorderColorFocused = System.Drawing.Color.Black;
            this.txt_ProductID.BorderColorIdle = System.Drawing.Color.Purple;
            this.txt_ProductID.BorderColorMouseHover = System.Drawing.Color.Purple;
            this.txt_ProductID.BorderThickness = 2;
            this.txt_ProductID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ProductID.Enabled = false;
            this.txt_ProductID.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_ProductID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_ProductID.isPassword = false;
            this.txt_ProductID.Location = new System.Drawing.Point(335, 49);
            this.txt_ProductID.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ProductID.Name = "txt_ProductID";
            this.txt_ProductID.Size = new System.Drawing.Size(41, 37);
            this.txt_ProductID.TabIndex = 19;
            this.txt_ProductID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_ProductID.Visible = false;
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
            this.btn_Add.Location = new System.Drawing.Point(21, 94);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 40);
            this.btn_Add.TabIndex = 18;
            this.btn_Add.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_RefreshProd
            // 
            this.btn_RefreshProd.ActiveBorderThickness = 1;
            this.btn_RefreshProd.ActiveCornerRadius = 20;
            this.btn_RefreshProd.ActiveFillColor = System.Drawing.Color.Purple;
            this.btn_RefreshProd.ActiveForecolor = System.Drawing.Color.White;
            this.btn_RefreshProd.ActiveLineColor = System.Drawing.Color.Purple;
            this.btn_RefreshProd.BackColor = System.Drawing.Color.White;
            this.btn_RefreshProd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_RefreshProd.BackgroundImage")));
            this.btn_RefreshProd.ButtonText = "Refresh";
            this.btn_RefreshProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_RefreshProd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RefreshProd.ForeColor = System.Drawing.Color.Black;
            this.btn_RefreshProd.IdleBorderThickness = 1;
            this.btn_RefreshProd.IdleCornerRadius = 20;
            this.btn_RefreshProd.IdleFillColor = System.Drawing.Color.White;
            this.btn_RefreshProd.IdleForecolor = System.Drawing.Color.Black;
            this.btn_RefreshProd.IdleLineColor = System.Drawing.Color.Black;
            this.btn_RefreshProd.Location = new System.Drawing.Point(301, 94);
            this.btn_RefreshProd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_RefreshProd.Name = "btn_RefreshProd";
            this.btn_RefreshProd.Size = new System.Drawing.Size(75, 40);
            this.btn_RefreshProd.TabIndex = 17;
            this.btn_RefreshProd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_RefreshProd.Click += new System.EventHandler(this.btn_RefreshProd_Click);
            // 
            // ProductsDataGrid
            // 
            this.ProductsDataGrid.AllowUserToAddRows = false;
            this.ProductsDataGrid.AllowUserToDeleteRows = false;
            this.ProductsDataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ProductsDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.ProductsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProductsDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.ProductsDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProductsDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductsDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.ProductsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProductsDataGrid.DefaultCellStyle = dataGridViewCellStyle13;
            this.ProductsDataGrid.DoubleBuffered = true;
            this.ProductsDataGrid.EnableHeadersVisualStyles = false;
            this.ProductsDataGrid.GridColor = System.Drawing.Color.White;
            this.ProductsDataGrid.HeaderBgColor = System.Drawing.Color.Purple;
            this.ProductsDataGrid.HeaderForeColor = System.Drawing.Color.White;
            this.ProductsDataGrid.Location = new System.Drawing.Point(21, 141);
            this.ProductsDataGrid.MultiSelect = false;
            this.ProductsDataGrid.Name = "ProductsDataGrid";
            this.ProductsDataGrid.ReadOnly = true;
            this.ProductsDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductsDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.ProductsDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ProductsDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.ProductsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductsDataGrid.Size = new System.Drawing.Size(355, 310);
            this.ProductsDataGrid.TabIndex = 16;
            this.ProductsDataGrid.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ProductsDataGrid_MouseClick);
            // 
            // btn_Edit
            // 
            this.btn_Edit.ActiveBorderThickness = 1;
            this.btn_Edit.ActiveCornerRadius = 20;
            this.btn_Edit.ActiveFillColor = System.Drawing.Color.Purple;
            this.btn_Edit.ActiveForecolor = System.Drawing.Color.White;
            this.btn_Edit.ActiveLineColor = System.Drawing.Color.Purple;
            this.btn_Edit.BackColor = System.Drawing.Color.White;
            this.btn_Edit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Edit.BackgroundImage")));
            this.btn_Edit.ButtonText = "Edit";
            this.btn_Edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Edit.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.ForeColor = System.Drawing.Color.Black;
            this.btn_Edit.IdleBorderThickness = 1;
            this.btn_Edit.IdleCornerRadius = 20;
            this.btn_Edit.IdleFillColor = System.Drawing.Color.White;
            this.btn_Edit.IdleForecolor = System.Drawing.Color.Black;
            this.btn_Edit.IdleLineColor = System.Drawing.Color.Black;
            this.btn_Edit.Location = new System.Drawing.Point(103, 94);
            this.btn_Edit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(75, 40);
            this.btn_Edit.TabIndex = 15;
            this.btn_Edit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // txt_SearchProduct
            // 
            this.txt_SearchProduct.BorderColorFocused = System.Drawing.Color.Black;
            this.txt_SearchProduct.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_SearchProduct.BorderColorMouseHover = System.Drawing.Color.Purple;
            this.txt_SearchProduct.BorderThickness = 2;
            this.txt_SearchProduct.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_SearchProduct.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_SearchProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_SearchProduct.isPassword = false;
            this.txt_SearchProduct.Location = new System.Drawing.Point(21, 49);
            this.txt_SearchProduct.Margin = new System.Windows.Forms.Padding(4);
            this.txt_SearchProduct.Name = "txt_SearchProduct";
            this.txt_SearchProduct.Size = new System.Drawing.Size(166, 37);
            this.txt_SearchProduct.TabIndex = 14;
            this.txt_SearchProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_SearchProduct.OnValueChanged += new System.EventHandler(this.txt_SearchProduct_OnValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_SearchProduct);
            this.groupBox1.Controls.Add(this.btn_Edit);
            this.groupBox1.Controls.Add(this.txt_ProductID);
            this.groupBox1.Controls.Add(this.ProductsDataGrid);
            this.groupBox1.Controls.Add(this.btn_Add);
            this.groupBox1.Controls.Add(this.btn_RefreshProd);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 472);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Products";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txt_SearchService);
            this.groupBox2.Controls.Add(this.btn_EditService);
            this.groupBox2.Controls.Add(this.txt_ServiceID);
            this.groupBox2.Controls.Add(this.ServicesDataGrid);
            this.groupBox2.Controls.Add(this.btn_AddService);
            this.groupBox2.Controls.Add(this.btn_RefreshServ);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(433, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(322, 472);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Services";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Search by Service Name";
            // 
            // txt_SearchService
            // 
            this.txt_SearchService.BorderColorFocused = System.Drawing.Color.Black;
            this.txt_SearchService.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_SearchService.BorderColorMouseHover = System.Drawing.Color.Purple;
            this.txt_SearchService.BorderThickness = 2;
            this.txt_SearchService.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_SearchService.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_SearchService.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_SearchService.isPassword = false;
            this.txt_SearchService.Location = new System.Drawing.Point(21, 49);
            this.txt_SearchService.Margin = new System.Windows.Forms.Padding(4);
            this.txt_SearchService.Name = "txt_SearchService";
            this.txt_SearchService.Size = new System.Drawing.Size(160, 37);
            this.txt_SearchService.TabIndex = 14;
            this.txt_SearchService.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btn_EditService
            // 
            this.btn_EditService.ActiveBorderThickness = 1;
            this.btn_EditService.ActiveCornerRadius = 20;
            this.btn_EditService.ActiveFillColor = System.Drawing.Color.Purple;
            this.btn_EditService.ActiveForecolor = System.Drawing.Color.White;
            this.btn_EditService.ActiveLineColor = System.Drawing.Color.Purple;
            this.btn_EditService.BackColor = System.Drawing.Color.White;
            this.btn_EditService.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_EditService.BackgroundImage")));
            this.btn_EditService.ButtonText = "Edit";
            this.btn_EditService.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_EditService.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EditService.ForeColor = System.Drawing.Color.Black;
            this.btn_EditService.IdleBorderThickness = 1;
            this.btn_EditService.IdleCornerRadius = 20;
            this.btn_EditService.IdleFillColor = System.Drawing.Color.White;
            this.btn_EditService.IdleForecolor = System.Drawing.Color.Black;
            this.btn_EditService.IdleLineColor = System.Drawing.Color.Black;
            this.btn_EditService.Location = new System.Drawing.Point(103, 94);
            this.btn_EditService.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_EditService.Name = "btn_EditService";
            this.btn_EditService.Size = new System.Drawing.Size(75, 40);
            this.btn_EditService.TabIndex = 15;
            this.btn_EditService.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_EditService.Click += new System.EventHandler(this.btn_EditService_Click);
            // 
            // txt_ServiceID
            // 
            this.txt_ServiceID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_ServiceID.BorderColorFocused = System.Drawing.Color.Black;
            this.txt_ServiceID.BorderColorIdle = System.Drawing.Color.Purple;
            this.txt_ServiceID.BorderColorMouseHover = System.Drawing.Color.Purple;
            this.txt_ServiceID.BorderThickness = 2;
            this.txt_ServiceID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ServiceID.Enabled = false;
            this.txt_ServiceID.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_ServiceID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_ServiceID.isPassword = false;
            this.txt_ServiceID.Location = new System.Drawing.Point(259, 49);
            this.txt_ServiceID.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ServiceID.Name = "txt_ServiceID";
            this.txt_ServiceID.Size = new System.Drawing.Size(41, 37);
            this.txt_ServiceID.TabIndex = 19;
            this.txt_ServiceID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_ServiceID.Visible = false;
            // 
            // ServicesDataGrid
            // 
            this.ServicesDataGrid.AllowUserToAddRows = false;
            this.ServicesDataGrid.AllowUserToDeleteRows = false;
            this.ServicesDataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ServicesDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.ServicesDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ServicesDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.ServicesDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ServicesDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ServicesDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.ServicesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ServicesDataGrid.DefaultCellStyle = dataGridViewCellStyle18;
            this.ServicesDataGrid.DoubleBuffered = true;
            this.ServicesDataGrid.EnableHeadersVisualStyles = false;
            this.ServicesDataGrid.GridColor = System.Drawing.Color.White;
            this.ServicesDataGrid.HeaderBgColor = System.Drawing.Color.Purple;
            this.ServicesDataGrid.HeaderForeColor = System.Drawing.Color.White;
            this.ServicesDataGrid.Location = new System.Drawing.Point(21, 141);
            this.ServicesDataGrid.MultiSelect = false;
            this.ServicesDataGrid.Name = "ServicesDataGrid";
            this.ServicesDataGrid.ReadOnly = true;
            this.ServicesDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ServicesDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.ServicesDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ServicesDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.ServicesDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ServicesDataGrid.Size = new System.Drawing.Size(279, 310);
            this.ServicesDataGrid.TabIndex = 16;
            // 
            // btn_AddService
            // 
            this.btn_AddService.ActiveBorderThickness = 1;
            this.btn_AddService.ActiveCornerRadius = 20;
            this.btn_AddService.ActiveFillColor = System.Drawing.Color.Purple;
            this.btn_AddService.ActiveForecolor = System.Drawing.Color.White;
            this.btn_AddService.ActiveLineColor = System.Drawing.Color.Purple;
            this.btn_AddService.BackColor = System.Drawing.Color.White;
            this.btn_AddService.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_AddService.BackgroundImage")));
            this.btn_AddService.ButtonText = "Add";
            this.btn_AddService.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AddService.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddService.ForeColor = System.Drawing.Color.Black;
            this.btn_AddService.IdleBorderThickness = 1;
            this.btn_AddService.IdleCornerRadius = 20;
            this.btn_AddService.IdleFillColor = System.Drawing.Color.White;
            this.btn_AddService.IdleForecolor = System.Drawing.Color.Black;
            this.btn_AddService.IdleLineColor = System.Drawing.Color.Black;
            this.btn_AddService.Location = new System.Drawing.Point(21, 94);
            this.btn_AddService.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_AddService.Name = "btn_AddService";
            this.btn_AddService.Size = new System.Drawing.Size(75, 40);
            this.btn_AddService.TabIndex = 18;
            this.btn_AddService.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_AddService.Click += new System.EventHandler(this.btn_AddService_Click);
            // 
            // btn_RefreshServ
            // 
            this.btn_RefreshServ.ActiveBorderThickness = 1;
            this.btn_RefreshServ.ActiveCornerRadius = 20;
            this.btn_RefreshServ.ActiveFillColor = System.Drawing.Color.Purple;
            this.btn_RefreshServ.ActiveForecolor = System.Drawing.Color.White;
            this.btn_RefreshServ.ActiveLineColor = System.Drawing.Color.Purple;
            this.btn_RefreshServ.BackColor = System.Drawing.Color.White;
            this.btn_RefreshServ.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_RefreshServ.BackgroundImage")));
            this.btn_RefreshServ.ButtonText = "Refresh";
            this.btn_RefreshServ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_RefreshServ.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RefreshServ.ForeColor = System.Drawing.Color.Black;
            this.btn_RefreshServ.IdleBorderThickness = 1;
            this.btn_RefreshServ.IdleCornerRadius = 20;
            this.btn_RefreshServ.IdleFillColor = System.Drawing.Color.White;
            this.btn_RefreshServ.IdleForecolor = System.Drawing.Color.Black;
            this.btn_RefreshServ.IdleLineColor = System.Drawing.Color.Black;
            this.btn_RefreshServ.Location = new System.Drawing.Point(225, 94);
            this.btn_RefreshServ.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_RefreshServ.Name = "btn_RefreshServ";
            this.btn_RefreshServ.Size = new System.Drawing.Size(75, 40);
            this.btn_RefreshServ.TabIndex = 17;
            this.btn_RefreshServ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDataGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ServicesDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        public Bunifu.Framework.UI.BunifuMetroTextbox txt_ProductID;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_Add;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_RefreshProd;
        public Bunifu.Framework.UI.BunifuCustomDataGrid ProductsDataGrid;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_Edit;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_SearchProduct;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_SearchService;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_EditService;
        public Bunifu.Framework.UI.BunifuMetroTextbox txt_ServiceID;
        public Bunifu.Framework.UI.BunifuCustomDataGrid ServicesDataGrid;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_AddService;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_RefreshServ;

    }
}

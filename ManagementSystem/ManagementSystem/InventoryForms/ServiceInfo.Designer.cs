namespace ManagementSystem.InventoryForms
{
    partial class EditServiceForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditServiceForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Remove = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_Add = new Bunifu.Framework.UI.BunifuThinButton2();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ProductDataGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.txt_ProductName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_ProductDesc = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Price = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_ServiceID = new System.Windows.Forms.TextBox();
            this.btn_Update = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Close = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDataGrid)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_Update);
            this.panel1.Controls.Add(this.txt_ServiceID);
            this.panel1.Controls.Add(this.txt_ProductName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_ProductDesc);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txt_Price);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(449, 441);
            this.panel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Remove);
            this.groupBox1.Controls.Add(this.btn_Add);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.ProductDataGrid);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(213, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 383);
            this.groupBox1.TabIndex = 59;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Products";
            // 
            // btn_Remove
            // 
            this.btn_Remove.ActiveBorderThickness = 1;
            this.btn_Remove.ActiveCornerRadius = 20;
            this.btn_Remove.ActiveFillColor = System.Drawing.Color.Purple;
            this.btn_Remove.ActiveForecolor = System.Drawing.Color.White;
            this.btn_Remove.ActiveLineColor = System.Drawing.Color.Purple;
            this.btn_Remove.BackColor = System.Drawing.Color.White;
            this.btn_Remove.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Remove.BackgroundImage")));
            this.btn_Remove.ButtonText = "Remove";
            this.btn_Remove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Remove.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Remove.ForeColor = System.Drawing.Color.Black;
            this.btn_Remove.IdleBorderThickness = 1;
            this.btn_Remove.IdleCornerRadius = 20;
            this.btn_Remove.IdleFillColor = System.Drawing.Color.White;
            this.btn_Remove.IdleForecolor = System.Drawing.Color.Black;
            this.btn_Remove.IdleLineColor = System.Drawing.Color.Black;
            this.btn_Remove.Location = new System.Drawing.Point(142, 63);
            this.btn_Remove.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(57, 35);
            this.btn_Remove.TabIndex = 60;
            this.btn_Remove.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btn_Add.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.Color.Black;
            this.btn_Add.IdleBorderThickness = 1;
            this.btn_Add.IdleCornerRadius = 20;
            this.btn_Add.IdleFillColor = System.Drawing.Color.White;
            this.btn_Add.IdleForecolor = System.Drawing.Color.Black;
            this.btn_Add.IdleLineColor = System.Drawing.Color.Black;
            this.btn_Add.Location = new System.Drawing.Point(15, 63);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(57, 35);
            this.btn_Add.TabIndex = 59;
            this.btn_Add.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Product",
            "Service"});
            this.comboBox1.Location = new System.Drawing.Point(16, 28);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(183, 24);
            this.comboBox1.TabIndex = 58;
            // 
            // ProductDataGrid
            // 
            this.ProductDataGrid.AllowUserToAddRows = false;
            this.ProductDataGrid.AllowUserToDeleteRows = false;
            this.ProductDataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ProductDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ProductDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProductDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ProductDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProductDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ProductDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProductDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.ProductDataGrid.DoubleBuffered = true;
            this.ProductDataGrid.EnableHeadersVisualStyles = false;
            this.ProductDataGrid.GridColor = System.Drawing.Color.White;
            this.ProductDataGrid.HeaderBgColor = System.Drawing.Color.Purple;
            this.ProductDataGrid.HeaderForeColor = System.Drawing.Color.White;
            this.ProductDataGrid.Location = new System.Drawing.Point(15, 105);
            this.ProductDataGrid.MultiSelect = false;
            this.ProductDataGrid.Name = "ProductDataGrid";
            this.ProductDataGrid.ReadOnly = true;
            this.ProductDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.ProductDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ProductDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.ProductDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductDataGrid.Size = new System.Drawing.Size(184, 257);
            this.ProductDataGrid.TabIndex = 57;
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
            this.txt_ProductName.Location = new System.Drawing.Point(18, 61);
            this.txt_ProductName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ProductName.Name = "txt_ProductName";
            this.txt_ProductName.Size = new System.Drawing.Size(177, 32);
            this.txt_ProductName.TabIndex = 65;
            this.txt_ProductName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 61;
            this.label4.Text = "Name";
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
            this.txt_ProductDesc.Location = new System.Drawing.Point(17, 128);
            this.txt_ProductDesc.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ProductDesc.Name = "txt_ProductDesc";
            this.txt_ProductDesc.Size = new System.Drawing.Size(177, 32);
            this.txt_ProductDesc.TabIndex = 64;
            this.txt_ProductDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 60;
            this.label2.Text = "Description";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 16);
            this.label6.TabIndex = 63;
            this.label6.Text = "Price";
            // 
            // txt_Price
            // 
            this.txt_Price.BackColor = System.Drawing.Color.White;
            this.txt_Price.BorderColorFocused = System.Drawing.Color.Purple;
            this.txt_Price.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Price.BorderColorMouseHover = System.Drawing.Color.Purple;
            this.txt_Price.BorderThickness = 2;
            this.txt_Price.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Price.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_Price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Price.isPassword = false;
            this.txt_Price.Location = new System.Drawing.Point(17, 198);
            this.txt_Price.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(177, 32);
            this.txt_Price.TabIndex = 62;
            this.txt_Price.Text = "0.00";
            this.txt_Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_ServiceID
            // 
            this.txt_ServiceID.Location = new System.Drawing.Point(150, 237);
            this.txt_ServiceID.Name = "txt_ServiceID";
            this.txt_ServiceID.Size = new System.Drawing.Size(44, 20);
            this.txt_ServiceID.TabIndex = 66;
            this.txt_ServiceID.Visible = false;
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
            this.btn_Update.Location = new System.Drawing.Point(18, 373);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 40);
            this.btn_Update.TabIndex = 67;
            this.btn_Update.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.btn_Close);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(449, 35);
            this.panel2.TabIndex = 2;
            // 
            // btn_Close
            // 
            this.btn_Close.AutoSize = true;
            this.btn_Close.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.ForeColor = System.Drawing.Color.White;
            this.btn_Close.Location = new System.Drawing.Point(425, 9);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(20, 19);
            this.btn_Close.TabIndex = 25;
            this.btn_Close.Text = "X";
            // 
            // EditServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 441);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditServiceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProductDataGrid)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        public Bunifu.Framework.UI.BunifuThinButton2 btn_Remove;
        public Bunifu.Framework.UI.BunifuThinButton2 btn_Add;
        private System.Windows.Forms.ComboBox comboBox1;
        public Bunifu.Framework.UI.BunifuCustomDataGrid ProductDataGrid;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_ProductName;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_ProductDesc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_Price;
        public System.Windows.Forms.TextBox txt_ServiceID;
        public Bunifu.Framework.UI.BunifuThinButton2 btn_Update;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label btn_Close;
    }
}
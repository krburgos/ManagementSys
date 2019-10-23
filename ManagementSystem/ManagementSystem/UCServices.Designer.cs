namespace ManagementSystem
{
    partial class UCServices
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCServices));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_SearchProduct = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btn_Edit = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txt_ProductID = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.ServicesDataGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btn_Add = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_RefreshProd = new Bunifu.Framework.UI.BunifuThinButton2();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ServicesDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_SearchProduct);
            this.groupBox1.Controls.Add(this.btn_Edit);
            this.groupBox1.Controls.Add(this.txt_ProductID);
            this.groupBox1.Controls.Add(this.ServicesDataGrid);
            this.groupBox1.Controls.Add(this.btn_Add);
            this.groupBox1.Controls.Add(this.btn_RefreshProd);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(725, 415);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Services";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Search by Service Name";
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
            this.btn_Edit.Location = new System.Drawing.Point(112, 94);
            this.btn_Edit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(75, 40);
            this.btn_Edit.TabIndex = 15;
            this.btn_Edit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.txt_ProductID.Location = new System.Drawing.Point(195, 49);
            this.txt_ProductID.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ProductID.Name = "txt_ProductID";
            this.txt_ProductID.Size = new System.Drawing.Size(41, 37);
            this.txt_ProductID.TabIndex = 19;
            this.txt_ProductID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_ProductID.Visible = false;
            // 
            // ServicesDataGrid
            // 
            this.ServicesDataGrid.AllowUserToAddRows = false;
            this.ServicesDataGrid.AllowUserToDeleteRows = false;
            this.ServicesDataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ServicesDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ServicesDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ServicesDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.ServicesDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ServicesDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ServicesDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ServicesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ServicesDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ServicesDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.ServicesDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ServicesDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.ServicesDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ServicesDataGrid.Size = new System.Drawing.Size(679, 259);
            this.ServicesDataGrid.TabIndex = 16;
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
            this.btn_RefreshProd.Location = new System.Drawing.Point(625, 94);
            this.btn_RefreshProd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_RefreshProd.Name = "btn_RefreshProd";
            this.btn_RefreshProd.Size = new System.Drawing.Size(75, 40);
            this.btn_RefreshProd.TabIndex = 17;
            this.btn_RefreshProd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UCServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox1);
            this.Name = "UCServices";
            this.Size = new System.Drawing.Size(767, 456);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ServicesDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_SearchProduct;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_Edit;
        public Bunifu.Framework.UI.BunifuMetroTextbox txt_ProductID;
        public Bunifu.Framework.UI.BunifuCustomDataGrid ServicesDataGrid;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_Add;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_RefreshProd;


    }
}

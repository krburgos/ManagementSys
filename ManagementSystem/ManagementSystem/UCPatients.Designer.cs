namespace ManagementSystem
{
    partial class UCPatients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCPatients));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Search = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btn_Edit = new Bunifu.Framework.UI.BunifuThinButton2();
            this.PatientsDataGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btn_NewVisit = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_Add = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txt_ID = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Refresh = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_History = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.PatientsDataGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patients";
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
            this.txt_Search.Location = new System.Drawing.Point(23, 92);
            this.txt_Search.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(240, 37);
            this.txt_Search.TabIndex = 1;
            this.txt_Search.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_Search.OnValueChanged += new System.EventHandler(this.txt_Search_OnValueChanged);
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
            this.btn_Edit.Location = new System.Drawing.Point(105, 137);
            this.btn_Edit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(75, 40);
            this.btn_Edit.TabIndex = 4;
            this.btn_Edit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // PatientsDataGrid
            // 
            this.PatientsDataGrid.AllowUserToAddRows = false;
            this.PatientsDataGrid.AllowUserToDeleteRows = false;
            this.PatientsDataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.PatientsDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.PatientsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PatientsDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.PatientsDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PatientsDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PatientsDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.PatientsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PatientsDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.PatientsDataGrid.DoubleBuffered = true;
            this.PatientsDataGrid.EnableHeadersVisualStyles = false;
            this.PatientsDataGrid.GridColor = System.Drawing.Color.White;
            this.PatientsDataGrid.HeaderBgColor = System.Drawing.Color.Purple;
            this.PatientsDataGrid.HeaderForeColor = System.Drawing.Color.White;
            this.PatientsDataGrid.Location = new System.Drawing.Point(23, 185);
            this.PatientsDataGrid.MultiSelect = false;
            this.PatientsDataGrid.Name = "PatientsDataGrid";
            this.PatientsDataGrid.ReadOnly = true;
            this.PatientsDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PatientsDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.PatientsDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.PatientsDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.PatientsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PatientsDataGrid.Size = new System.Drawing.Size(708, 346);
            this.PatientsDataGrid.TabIndex = 5;
            this.PatientsDataGrid.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PatientsDataGrid_MouseClick);
            // 
            // btn_NewVisit
            // 
            this.btn_NewVisit.ActiveBorderThickness = 1;
            this.btn_NewVisit.ActiveCornerRadius = 20;
            this.btn_NewVisit.ActiveFillColor = System.Drawing.Color.Purple;
            this.btn_NewVisit.ActiveForecolor = System.Drawing.Color.White;
            this.btn_NewVisit.ActiveLineColor = System.Drawing.Color.Purple;
            this.btn_NewVisit.BackColor = System.Drawing.Color.White;
            this.btn_NewVisit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_NewVisit.BackgroundImage")));
            this.btn_NewVisit.ButtonText = "Update";
            this.btn_NewVisit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_NewVisit.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NewVisit.ForeColor = System.Drawing.Color.Black;
            this.btn_NewVisit.IdleBorderThickness = 1;
            this.btn_NewVisit.IdleCornerRadius = 20;
            this.btn_NewVisit.IdleFillColor = System.Drawing.Color.White;
            this.btn_NewVisit.IdleForecolor = System.Drawing.Color.Black;
            this.btn_NewVisit.IdleLineColor = System.Drawing.Color.Black;
            this.btn_NewVisit.Location = new System.Drawing.Point(188, 137);
            this.btn_NewVisit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_NewVisit.Name = "btn_NewVisit";
            this.btn_NewVisit.Size = new System.Drawing.Size(75, 40);
            this.btn_NewVisit.TabIndex = 6;
            this.btn_NewVisit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_NewVisit.Click += new System.EventHandler(this.btn_NewVisit_Click);
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
            this.btn_Add.Location = new System.Drawing.Point(23, 137);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 40);
            this.btn_Add.TabIndex = 7;
            this.btn_Add.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
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
            this.txt_ID.Location = new System.Drawing.Point(271, 92);
            this.txt_ID.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(41, 37);
            this.txt_ID.TabIndex = 8;
            this.txt_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_ID.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "Search by Name";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(774, 54);
            this.panel1.TabIndex = 11;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.ActiveBorderThickness = 1;
            this.btn_Refresh.ActiveCornerRadius = 20;
            this.btn_Refresh.ActiveFillColor = System.Drawing.Color.Purple;
            this.btn_Refresh.ActiveForecolor = System.Drawing.Color.White;
            this.btn_Refresh.ActiveLineColor = System.Drawing.Color.Purple;
            this.btn_Refresh.BackColor = System.Drawing.Color.White;
            this.btn_Refresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Refresh.BackgroundImage")));
            this.btn_Refresh.ButtonText = "Refresh";
            this.btn_Refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Refresh.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.Black;
            this.btn_Refresh.IdleBorderThickness = 1;
            this.btn_Refresh.IdleCornerRadius = 20;
            this.btn_Refresh.IdleFillColor = System.Drawing.Color.White;
            this.btn_Refresh.IdleForecolor = System.Drawing.Color.Black;
            this.btn_Refresh.IdleLineColor = System.Drawing.Color.Black;
            this.btn_Refresh.Location = new System.Drawing.Point(664, 138);
            this.btn_Refresh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(75, 40);
            this.btn_Refresh.TabIndex = 12;
            this.btn_Refresh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_History
            // 
            this.btn_History.ActiveBorderThickness = 1;
            this.btn_History.ActiveCornerRadius = 20;
            this.btn_History.ActiveFillColor = System.Drawing.Color.Purple;
            this.btn_History.ActiveForecolor = System.Drawing.Color.White;
            this.btn_History.ActiveLineColor = System.Drawing.Color.Purple;
            this.btn_History.BackColor = System.Drawing.Color.White;
            this.btn_History.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_History.BackgroundImage")));
            this.btn_History.ButtonText = "History";
            this.btn_History.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_History.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_History.ForeColor = System.Drawing.Color.Black;
            this.btn_History.IdleBorderThickness = 1;
            this.btn_History.IdleCornerRadius = 20;
            this.btn_History.IdleFillColor = System.Drawing.Color.White;
            this.btn_History.IdleForecolor = System.Drawing.Color.Black;
            this.btn_History.IdleLineColor = System.Drawing.Color.Black;
            this.btn_History.Location = new System.Drawing.Point(271, 137);
            this.btn_History.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_History.Name = "btn_History";
            this.btn_History.Size = new System.Drawing.Size(75, 40);
            this.btn_History.TabIndex = 13;
            this.btn_History.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_History.Click += new System.EventHandler(this.btn_History_Click);
            // 
            // UCPatients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btn_History);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_NewVisit);
            this.Controls.Add(this.PatientsDataGrid);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.txt_Search);
            this.Name = "UCPatients";
            this.Size = new System.Drawing.Size(774, 534);
            ((System.ComponentModel.ISupportInitialize)(this.PatientsDataGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_Search;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_Edit;
        public Bunifu.Framework.UI.BunifuCustomDataGrid PatientsDataGrid;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_NewVisit;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_Add;
        public Bunifu.Framework.UI.BunifuMetroTextbox txt_ID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_Refresh;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_History;

    }
}

namespace InventoryManagementSystem.Category
{
    partial class formVendors
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formVendors));
            this.txtVendorDesciption = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddThirdCate = new Guna.UI2.WinForms.Guna2Button();
            this.cmbThirdCateName = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtVendorId = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtVendorName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.label24 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.VendosDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.vendorIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thirdCategoryNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendorStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registerDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendorDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendorsViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryDBDataSet6 = new InventoryManagementSystem.inventoryDBDataSet6();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpRegisterDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.pbImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.vendorsViewTableAdapter = new InventoryManagementSystem.inventoryDBDataSet6TableAdapters.VendorsViewTableAdapter();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VendosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorsViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDBDataSet6)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // txtVendorDesciption
            // 
            this.txtVendorDesciption.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtVendorDesciption.DefaultText = "";
            this.txtVendorDesciption.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtVendorDesciption.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtVendorDesciption.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtVendorDesciption.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtVendorDesciption.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtVendorDesciption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVendorDesciption.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtVendorDesciption.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtVendorDesciption.Location = new System.Drawing.Point(32, 654);
            this.txtVendorDesciption.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtVendorDesciption.Multiline = true;
            this.txtVendorDesciption.Name = "txtVendorDesciption";
            this.txtVendorDesciption.PasswordChar = '\0';
            this.txtVendorDesciption.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtVendorDesciption.PlaceholderText = "Ex: Vendor Details (Max 50 words)";
            this.txtVendorDesciption.SelectedText = "";
            this.txtVendorDesciption.Size = new System.Drawing.Size(197, 60);
            this.txtVendorDesciption.TabIndex = 215;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(509, 4);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(314, 51);
            this.panel5.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(96, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "Add Vendors";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(30, 634);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 214;
            this.label3.Text = "Description";
            // 
            // btnAddThirdCate
            // 
            this.btnAddThirdCate.Animated = true;
            this.btnAddThirdCate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddThirdCate.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddThirdCate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(255)))), ((int)(((byte)(203)))));
            this.btnAddThirdCate.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnAddThirdCate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(173)))), ((int)(((byte)(27)))));
            this.btnAddThirdCate.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(173)))), ((int)(((byte)(27)))));
            this.btnAddThirdCate.HoverState.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddThirdCate.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnAddThirdCate.HoverState.Image = global::InventoryManagementSystem.Properties.Resources.icons8_plus_math_480px_1;
            this.btnAddThirdCate.Image = global::InventoryManagementSystem.Properties.Resources.icons8_plus_math_480px;
            this.btnAddThirdCate.Location = new System.Drawing.Point(235, 401);
            this.btnAddThirdCate.Name = "btnAddThirdCate";
            this.btnAddThirdCate.Size = new System.Drawing.Size(35, 33);
            this.btnAddThirdCate.TabIndex = 212;
            this.btnAddThirdCate.TextOffset = new System.Drawing.Point(8, 0);
            this.btnAddThirdCate.Click += new System.EventHandler(this.btnAddThirdCate_Click);
            // 
            // cmbThirdCateName
            // 
            this.cmbThirdCateName.BackColor = System.Drawing.Color.Transparent;
            this.cmbThirdCateName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbThirdCateName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbThirdCateName.FocusedColor = System.Drawing.Color.Empty;
            this.cmbThirdCateName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbThirdCateName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbThirdCateName.FormattingEnabled = true;
            this.cmbThirdCateName.ItemHeight = 30;
            this.cmbThirdCateName.Location = new System.Drawing.Point(32, 398);
            this.cmbThirdCateName.Margin = new System.Windows.Forms.Padding(2);
            this.cmbThirdCateName.Name = "cmbThirdCateName";
            this.cmbThirdCateName.Size = new System.Drawing.Size(196, 36);
            this.cmbThirdCateName.TabIndex = 211;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(30, 376);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 15);
            this.label1.TabIndex = 210;
            this.label1.Text = "Third Category Name";
            // 
            // txtVendorId
            // 
            this.txtVendorId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtVendorId.DefaultText = "";
            this.txtVendorId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtVendorId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtVendorId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtVendorId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtVendorId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtVendorId.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVendorId.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtVendorId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtVendorId.Location = new System.Drawing.Point(32, 236);
            this.txtVendorId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtVendorId.Name = "txtVendorId";
            this.txtVendorId.PasswordChar = '\0';
            this.txtVendorId.PlaceholderText = "Auto Generate";
            this.txtVendorId.ReadOnly = true;
            this.txtVendorId.SelectedText = "";
            this.txtVendorId.Size = new System.Drawing.Size(197, 30);
            this.txtVendorId.TabIndex = 208;
            // 
            // txtVendorName
            // 
            this.txtVendorName.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.txtVendorName.BackColor = System.Drawing.Color.Transparent;
            this.txtVendorName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtVendorName.DefaultText = "";
            this.txtVendorName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtVendorName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtVendorName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtVendorName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtVendorName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtVendorName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVendorName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtVendorName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtVendorName.Location = new System.Drawing.Point(33, 316);
            this.txtVendorName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtVendorName.Name = "txtVendorName";
            this.txtVendorName.PasswordChar = '\0';
            this.txtVendorName.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.txtVendorName.PlaceholderText = "Ex : Muhammad Adan";
            this.txtVendorName.SelectedText = "";
            this.txtVendorName.Size = new System.Drawing.Size(196, 34);
            this.txtVendorName.TabIndex = 209;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(30, 216);
            this.label8.Margin = new System.Windows.Forms.Padding(0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 15);
            this.label8.TabIndex = 206;
            this.label8.Text = "Vendor ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(30, 296);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 15);
            this.label7.TabIndex = 207;
            this.label7.Text = "Vendor Name";
            // 
            // btnCancel
            // 
            this.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(226)))), ((int)(((byte)(229)))));
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(46)))), ((int)(((byte)(66)))));
            this.btnCancel.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(46)))), ((int)(((byte)(66)))));
            this.btnCancel.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(226)))), ((int)(((byte)(229)))));
            this.btnCancel.Location = new System.Drawing.Point(148, 6);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(135, 37);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnSave.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnSave.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnSave.Location = new System.Drawing.Point(9, 6);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(135, 37);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.label24.Location = new System.Drawing.Point(174, 13);
            this.label24.Margin = new System.Windows.Forms.Padding(0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(103, 19);
            this.label24.TabIndex = 165;
            this.label24.Text = "Search Vendors";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(3, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 21);
            this.label6.TabIndex = 4;
            this.label6.Text = "View All Vendors";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label24);
            this.panel3.Controls.Add(this.txtSearch);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(-1, -1);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(501, 51);
            this.panel3.TabIndex = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.HoverState.PlaceholderForeColor = System.Drawing.Color.Transparent;
            this.txtSearch.IconRight = global::InventoryManagementSystem.Properties.Resources.icons8_search_480px;
            this.txtSearch.Location = new System.Drawing.Point(281, 8);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "by Name, Category. Status";
            this.txtSearch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(208, 30);
            this.txtSearch.TabIndex = 135;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.VendosDataGridView);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(3, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(501, 570);
            this.panel1.TabIndex = 24;
            // 
            // VendosDataGridView
            // 
            this.VendosDataGridView.AllowUserToAddRows = false;
            this.VendosDataGridView.AllowUserToDeleteRows = false;
            this.VendosDataGridView.AllowUserToResizeColumns = false;
            this.VendosDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.VendosDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.VendosDataGridView.AutoGenerateColumns = false;
            this.VendosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.VendosDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.VendosDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.VendosDataGridView.ColumnHeadersHeight = 15;
            this.VendosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.VendosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vendorIdDataGridViewTextBoxColumn,
            this.vendorNameDataGridViewTextBoxColumn,
            this.thirdCategoryNameDataGridViewTextBoxColumn,
            this.vendorStatusDataGridViewTextBoxColumn,
            this.registerDateDataGridViewTextBoxColumn,
            this.vendorDescriptionDataGridViewTextBoxColumn});
            this.VendosDataGridView.DataSource = this.vendorsViewBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.VendosDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.VendosDataGridView.GridColor = System.Drawing.Color.Cyan;
            this.VendosDataGridView.Location = new System.Drawing.Point(-1, 55);
            this.VendosDataGridView.Name = "VendosDataGridView";
            this.VendosDataGridView.ReadOnly = true;
            this.VendosDataGridView.RowHeadersVisible = false;
            this.VendosDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.VendosDataGridView.Size = new System.Drawing.Size(501, 457);
            this.VendosDataGridView.TabIndex = 7;
            this.VendosDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.VendosDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.VendosDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.VendosDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.VendosDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.VendosDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.VendosDataGridView.ThemeStyle.GridColor = System.Drawing.Color.Cyan;
            this.VendosDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.VendosDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.VendosDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VendosDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.VendosDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.VendosDataGridView.ThemeStyle.HeaderStyle.Height = 15;
            this.VendosDataGridView.ThemeStyle.ReadOnly = true;
            this.VendosDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.VendosDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.VendosDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VendosDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.VendosDataGridView.ThemeStyle.RowsStyle.Height = 22;
            this.VendosDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.VendosDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.VendosDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.VendosDataGridView_CellDoubleClick);
            // 
            // vendorIdDataGridViewTextBoxColumn
            // 
            this.vendorIdDataGridViewTextBoxColumn.DataPropertyName = "VendorId";
            this.vendorIdDataGridViewTextBoxColumn.HeaderText = "VendorId";
            this.vendorIdDataGridViewTextBoxColumn.Name = "vendorIdDataGridViewTextBoxColumn";
            this.vendorIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.vendorIdDataGridViewTextBoxColumn.Width = 73;
            // 
            // vendorNameDataGridViewTextBoxColumn
            // 
            this.vendorNameDataGridViewTextBoxColumn.DataPropertyName = "VendorName";
            this.vendorNameDataGridViewTextBoxColumn.HeaderText = "VendorName";
            this.vendorNameDataGridViewTextBoxColumn.Name = "vendorNameDataGridViewTextBoxColumn";
            this.vendorNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.vendorNameDataGridViewTextBoxColumn.Width = 92;
            // 
            // thirdCategoryNameDataGridViewTextBoxColumn
            // 
            this.thirdCategoryNameDataGridViewTextBoxColumn.DataPropertyName = "ThirdCategoryName";
            this.thirdCategoryNameDataGridViewTextBoxColumn.HeaderText = "ThirdCategoryName";
            this.thirdCategoryNameDataGridViewTextBoxColumn.Name = "thirdCategoryNameDataGridViewTextBoxColumn";
            this.thirdCategoryNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.thirdCategoryNameDataGridViewTextBoxColumn.Width = 124;
            // 
            // vendorStatusDataGridViewTextBoxColumn
            // 
            this.vendorStatusDataGridViewTextBoxColumn.DataPropertyName = "VendorStatus";
            this.vendorStatusDataGridViewTextBoxColumn.HeaderText = "VendorStatus";
            this.vendorStatusDataGridViewTextBoxColumn.Name = "vendorStatusDataGridViewTextBoxColumn";
            this.vendorStatusDataGridViewTextBoxColumn.ReadOnly = true;
            this.vendorStatusDataGridViewTextBoxColumn.Width = 94;
            // 
            // registerDateDataGridViewTextBoxColumn
            // 
            this.registerDateDataGridViewTextBoxColumn.DataPropertyName = "RegisterDate";
            this.registerDateDataGridViewTextBoxColumn.HeaderText = "RegisterDate";
            this.registerDateDataGridViewTextBoxColumn.Name = "registerDateDataGridViewTextBoxColumn";
            this.registerDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.registerDateDataGridViewTextBoxColumn.Width = 92;
            // 
            // vendorDescriptionDataGridViewTextBoxColumn
            // 
            this.vendorDescriptionDataGridViewTextBoxColumn.DataPropertyName = "VendorDescription";
            this.vendorDescriptionDataGridViewTextBoxColumn.HeaderText = "VendorDescription";
            this.vendorDescriptionDataGridViewTextBoxColumn.Name = "vendorDescriptionDataGridViewTextBoxColumn";
            this.vendorDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.vendorDescriptionDataGridViewTextBoxColumn.Width = 117;
            // 
            // vendorsViewBindingSource
            // 
            this.vendorsViewBindingSource.DataMember = "VendorsView";
            this.vendorsViewBindingSource.DataSource = this.inventoryDBDataSet6;
            // 
            // inventoryDBDataSet6
            // 
            this.inventoryDBDataSet6.DataSetName = "inventoryDBDataSet6";
            this.inventoryDBDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btnDelete);
            this.panel4.Controls.Add(this.btnRefresh);
            this.panel4.Location = new System.Drawing.Point(-1, 519);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(501, 51);
            this.panel4.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.CustomImages.HoveredImage = global::InventoryManagementSystem.Properties.Resources.icons8_trash_can_480px;
            this.btnDelete.CustomImages.Image = global::InventoryManagementSystem.Properties.Resources.icons8_trash_can_480px_1;
            this.btnDelete.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(226)))), ((int)(((byte)(229)))));
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(46)))), ((int)(((byte)(66)))));
            this.btnDelete.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(46)))), ((int)(((byte)(66)))));
            this.btnDelete.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(226)))), ((int)(((byte)(229)))));
            this.btnDelete.Location = new System.Drawing.Point(264, 6);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(166, 37);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete ";
            this.btnDelete.TextOffset = new System.Drawing.Point(15, 0);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.CustomImages.HoveredImage = global::InventoryManagementSystem.Properties.Resources.icons8_restart_96px_1;
            this.btnRefresh.CustomImages.Image = global::InventoryManagementSystem.Properties.Resources.icons8_restart_96px;
            this.btnRefresh.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnRefresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRefresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRefresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRefresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRefresh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(233)))), ((int)(((byte)(249)))));
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(148)))), ((int)(((byte)(247)))));
            this.btnRefresh.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(148)))), ((int)(((byte)(247)))));
            this.btnRefresh.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(233)))), ((int)(((byte)(249)))));
            this.btnRefresh.Location = new System.Drawing.Point(80, 6);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(166, 37);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextOffset = new System.Drawing.Point(15, 0);
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.btnCancel);
            this.panel6.Controls.Add(this.btnSave);
            this.panel6.Location = new System.Drawing.Point(509, 524);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(314, 51);
            this.panel6.TabIndex = 27;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.cmbStatus);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.dtpRegisterDate);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtVendorDesciption);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnAddThirdCate);
            this.panel2.Controls.Add(this.cmbThirdCateName);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtVendorId);
            this.panel2.Controls.Add(this.txtVendorName);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.pbImage);
            this.panel2.Location = new System.Drawing.Point(509, 54);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(314, 471);
            this.panel2.TabIndex = 25;
            // 
            // cmbStatus
            // 
            this.cmbStatus.BackColor = System.Drawing.Color.Transparent;
            this.cmbStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FocusedColor = System.Drawing.Color.Empty;
            this.cmbStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.ItemHeight = 30;
            this.cmbStatus.Items.AddRange(new object[] {
            "Not Selected",
            "Active",
            "Inactive"});
            this.cmbStatus.Location = new System.Drawing.Point(33, 565);
            this.cmbStatus.Margin = new System.Windows.Forms.Padding(2);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(196, 36);
            this.cmbStatus.StartIndex = 0;
            this.cmbStatus.TabIndex = 220;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(30, 545);
            this.label9.Margin = new System.Windows.Forms.Padding(0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 15);
            this.label9.TabIndex = 219;
            this.label9.Text = "Vendor Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(115, 754);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 218;
            // 
            // dtpRegisterDate
            // 
            this.dtpRegisterDate.Checked = true;
            this.dtpRegisterDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtpRegisterDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpRegisterDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpRegisterDate.Location = new System.Drawing.Point(32, 480);
            this.dtpRegisterDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpRegisterDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpRegisterDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpRegisterDate.Name = "dtpRegisterDate";
            this.dtpRegisterDate.Size = new System.Drawing.Size(196, 29);
            this.dtpRegisterDate.TabIndex = 217;
            this.dtpRegisterDate.Value = new System.DateTime(2023, 6, 9, 7, 47, 1, 533);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(30, 460);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 216;
            this.label2.Text = "Register Date";
            // 
            // pbImage
            // 
            this.pbImage.BackColor = System.Drawing.Color.Transparent;
            this.pbImage.Image = global::InventoryManagementSystem.Properties.Resources._2405093;
            this.pbImage.ImageRotate = 0F;
            this.pbImage.InitialImage = global::InventoryManagementSystem.Properties.Resources.icons8_people_96px_1;
            this.pbImage.Location = new System.Drawing.Point(32, 17);
            this.pbImage.Margin = new System.Windows.Forms.Padding(2);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(205, 161);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImage.TabIndex = 149;
            this.pbImage.TabStop = false;
            this.pbImage.UseTransparentBackground = true;
            // 
            // vendorsViewTableAdapter
            // 
            this.vendorsViewTableAdapter.ClearBeforeFill = true;
            // 
            // formVendors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 581);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formVendors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IMS: Vendors";
            this.Load += new System.EventHandler(this.formVendors_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.VendosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorsViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDBDataSet6)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtVendorDesciption;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button btnAddThirdCate;
        private Guna.UI2.WinForms.Guna2ComboBox cmbThirdCateName;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtVendorId;
        private Guna.UI2.WinForms.Guna2TextBox txtVendorName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2PictureBox pbImage;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpRegisterDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox cmbStatus;
        private Guna.UI2.WinForms.Guna2DataGridView VendosDataGridView;
        private inventoryDBDataSet6 inventoryDBDataSet6;
        private System.Windows.Forms.BindingSource vendorsViewBindingSource;
        private inventoryDBDataSet6TableAdapters.VendorsViewTableAdapter vendorsViewTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendorIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thirdCategoryNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendorStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn registerDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendorDescriptionDataGridViewTextBoxColumn;
    }
}
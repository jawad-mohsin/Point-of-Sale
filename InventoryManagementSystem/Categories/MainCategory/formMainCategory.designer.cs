namespace InventoryManagementSystem.Category
{
    partial class formMainCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMainCategory));
            this.panel3 = new System.Windows.Forms.Panel();
            this.label24 = new System.Windows.Forms.Label();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMainCateId = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMainCateName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.pbImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnDeleteCategory = new Guna.UI2.WinForms.Guna2Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnSaveCategory = new Guna.UI2.WinForms.Guna2Button();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MainCategoriesDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.mainCategoryIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainCategoryNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainCategoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryDBDataSet3 = new InventoryManagementSystem.inventoryDBDataSet3();
            this.panel4 = new System.Windows.Forms.Panel();
            this.mainCategoriesTableAdapter = new InventoryManagementSystem.inventoryDBDataSet3TableAdapters.MainCategoriesTableAdapter();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainCategoriesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainCategoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDBDataSet3)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
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
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.label24.Location = new System.Drawing.Point(166, 15);
            this.label24.Margin = new System.Windows.Forms.Padding(0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(118, 19);
            this.label24.TabIndex = 165;
            this.label24.Text = "Search Categories";
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
            this.txtSearch.Location = new System.Drawing.Point(287, 8);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "by Category Name";
            this.txtSearch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(208, 30);
            this.txtSearch.TabIndex = 135;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(3, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 21);
            this.label6.TabIndex = 4;
            this.label6.Text = "View All Categories";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtMainCateId);
            this.panel2.Controls.Add(this.txtMainCateName);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.pbImage);
            this.panel2.Location = new System.Drawing.Point(507, 52);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(292, 471);
            this.panel2.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(38, 294);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 19);
            this.label1.TabIndex = 210;
            this.label1.Text = "Main Category Name";
            // 
            // txtMainCateId
            // 
            this.txtMainCateId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMainCateId.DefaultText = "";
            this.txtMainCateId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMainCateId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMainCateId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMainCateId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMainCateId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMainCateId.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMainCateId.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtMainCateId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMainCateId.Location = new System.Drawing.Point(40, 228);
            this.txtMainCateId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMainCateId.Name = "txtMainCateId";
            this.txtMainCateId.PasswordChar = '\0';
            this.txtMainCateId.PlaceholderText = "Auto Generate";
            this.txtMainCateId.ReadOnly = true;
            this.txtMainCateId.SelectedText = "";
            this.txtMainCateId.Size = new System.Drawing.Size(217, 29);
            this.txtMainCateId.TabIndex = 208;
            // 
            // txtMainCateName
            // 
            this.txtMainCateName.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.txtMainCateName.BackColor = System.Drawing.Color.Transparent;
            this.txtMainCateName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMainCateName.DefaultText = "";
            this.txtMainCateName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMainCateName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMainCateName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMainCateName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMainCateName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMainCateName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMainCateName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtMainCateName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMainCateName.Location = new System.Drawing.Point(41, 318);
            this.txtMainCateName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMainCateName.Name = "txtMainCateName";
            this.txtMainCateName.PasswordChar = '\0';
            this.txtMainCateName.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.txtMainCateName.PlaceholderText = "Ex : Electronics, Clothing etc";
            this.txtMainCateName.SelectedText = "";
            this.txtMainCateName.Size = new System.Drawing.Size(216, 29);
            this.txtMainCateName.TabIndex = 209;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(38, 203);
            this.label8.Margin = new System.Windows.Forms.Padding(0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 19);
            this.label8.TabIndex = 206;
            this.label8.Text = "Main Category ID";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(9, 967);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(0, 13);
            this.label16.TabIndex = 205;
            // 
            // pbImage
            // 
            this.pbImage.BackColor = System.Drawing.Color.Transparent;
            this.pbImage.Image = global::InventoryManagementSystem.Properties.Resources._1057072;
            this.pbImage.ImageRotate = 0F;
            this.pbImage.InitialImage = global::InventoryManagementSystem.Properties.Resources.icons8_people_96px_1;
            this.pbImage.Location = new System.Drawing.Point(32, 11);
            this.pbImage.Margin = new System.Windows.Forms.Padding(2);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(208, 166);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImage.TabIndex = 149;
            this.pbImage.TabStop = false;
            this.pbImage.UseTransparentBackground = true;
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.CustomImages.HoveredImage = global::InventoryManagementSystem.Properties.Resources.icons8_trash_can_480px;
            this.btnDeleteCategory.CustomImages.Image = global::InventoryManagementSystem.Properties.Resources.icons8_trash_can_480px_1;
            this.btnDeleteCategory.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDeleteCategory.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteCategory.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteCategory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteCategory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteCategory.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(226)))), ((int)(((byte)(229)))));
            this.btnDeleteCategory.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnDeleteCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(46)))), ((int)(((byte)(66)))));
            this.btnDeleteCategory.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(46)))), ((int)(((byte)(66)))));
            this.btnDeleteCategory.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(226)))), ((int)(((byte)(229)))));
            this.btnDeleteCategory.Location = new System.Drawing.Point(264, 6);
            this.btnDeleteCategory.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(166, 37);
            this.btnDeleteCategory.TabIndex = 4;
            this.btnDeleteCategory.Text = "Delete Category";
            this.btnDeleteCategory.TextOffset = new System.Drawing.Point(15, 0);
            this.btnDeleteCategory.Click += new System.EventHandler(this.btnDeleteCategory_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(507, 2);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(292, 51);
            this.panel5.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(63, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "Add Main Categories";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.btnCancel);
            this.panel6.Controls.Add(this.btnSaveCategory);
            this.panel6.Location = new System.Drawing.Point(507, 521);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(292, 51);
            this.panel6.TabIndex = 11;
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
            this.btnCancel.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSaveCategory
            // 
            this.btnSaveCategory.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveCategory.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveCategory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSaveCategory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSaveCategory.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnSaveCategory.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnSaveCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnSaveCategory.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnSaveCategory.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnSaveCategory.Location = new System.Drawing.Point(9, 6);
            this.btnSaveCategory.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveCategory.Name = "btnSaveCategory";
            this.btnSaveCategory.Size = new System.Drawing.Size(135, 37);
            this.btnSaveCategory.TabIndex = 10;
            this.btnSaveCategory.Text = "Save";
            this.btnSaveCategory.Click += new System.EventHandler(this.btnSaveCategory_Click);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.MainCategoriesDataGridView);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(501, 570);
            this.panel1.TabIndex = 8;
            // 
            // MainCategoriesDataGridView
            // 
            this.MainCategoriesDataGridView.AllowUserToAddRows = false;
            this.MainCategoriesDataGridView.AllowUserToDeleteRows = false;
            this.MainCategoriesDataGridView.AllowUserToResizeColumns = false;
            this.MainCategoriesDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.MainCategoriesDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.MainCategoriesDataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MainCategoriesDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.MainCategoriesDataGridView.ColumnHeadersHeight = 15;
            this.MainCategoriesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.MainCategoriesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mainCategoryIdDataGridViewTextBoxColumn,
            this.mainCategoryNameDataGridViewTextBoxColumn});
            this.MainCategoriesDataGridView.DataSource = this.mainCategoriesBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MainCategoriesDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.MainCategoriesDataGridView.GridColor = System.Drawing.Color.Cyan;
            this.MainCategoriesDataGridView.Location = new System.Drawing.Point(12, 67);
            this.MainCategoriesDataGridView.Name = "MainCategoriesDataGridView";
            this.MainCategoriesDataGridView.ReadOnly = true;
            this.MainCategoriesDataGridView.RowHeadersVisible = false;
            this.MainCategoriesDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.MainCategoriesDataGridView.Size = new System.Drawing.Size(473, 434);
            this.MainCategoriesDataGridView.TabIndex = 2;
            this.MainCategoriesDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.MainCategoriesDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.MainCategoriesDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.MainCategoriesDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.MainCategoriesDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.MainCategoriesDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.MainCategoriesDataGridView.ThemeStyle.GridColor = System.Drawing.Color.Cyan;
            this.MainCategoriesDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.MainCategoriesDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.MainCategoriesDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainCategoriesDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.MainCategoriesDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.MainCategoriesDataGridView.ThemeStyle.HeaderStyle.Height = 15;
            this.MainCategoriesDataGridView.ThemeStyle.ReadOnly = true;
            this.MainCategoriesDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.MainCategoriesDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.MainCategoriesDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainCategoriesDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.MainCategoriesDataGridView.ThemeStyle.RowsStyle.Height = 22;
            this.MainCategoriesDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.MainCategoriesDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.MainCategoriesDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MainCategoriesDataGridView_CellDoubleClick);
            // 
            // mainCategoryIdDataGridViewTextBoxColumn
            // 
            this.mainCategoryIdDataGridViewTextBoxColumn.DataPropertyName = "MainCategoryId";
            this.mainCategoryIdDataGridViewTextBoxColumn.HeaderText = "MainCategoryId";
            this.mainCategoryIdDataGridViewTextBoxColumn.Name = "mainCategoryIdDataGridViewTextBoxColumn";
            this.mainCategoryIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mainCategoryNameDataGridViewTextBoxColumn
            // 
            this.mainCategoryNameDataGridViewTextBoxColumn.DataPropertyName = "MainCategoryName";
            this.mainCategoryNameDataGridViewTextBoxColumn.HeaderText = "MainCategoryName";
            this.mainCategoryNameDataGridViewTextBoxColumn.Name = "mainCategoryNameDataGridViewTextBoxColumn";
            this.mainCategoryNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mainCategoriesBindingSource
            // 
            this.mainCategoriesBindingSource.DataMember = "MainCategories";
            this.mainCategoriesBindingSource.DataSource = this.inventoryDBDataSet3;
            // 
            // inventoryDBDataSet3
            // 
            this.inventoryDBDataSet3.DataSetName = "inventoryDBDataSet3";
            this.inventoryDBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btnDeleteCategory);
            this.panel4.Controls.Add(this.btnRefresh);
            this.panel4.Location = new System.Drawing.Point(-1, 519);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(501, 51);
            this.panel4.TabIndex = 1;
            // 
            // mainCategoriesTableAdapter
            // 
            this.mainCategoriesTableAdapter.ClearBeforeFill = true;
            // 
            // formMainCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 574);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formMainCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IMS: Main Categories";
            this.Load += new System.EventHandler(this.formMainCategory_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainCategoriesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainCategoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDBDataSet3)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label24;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label16;
        private Guna.UI2.WinForms.Guna2PictureBox pbImage;
        private Guna.UI2.WinForms.Guna2Button btnDeleteCategory;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel6;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2Button btnSaveCategory;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private Guna.UI2.WinForms.Guna2TextBox txtMainCateId;
        private Guna.UI2.WinForms.Guna2TextBox txtMainCateName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView MainCategoriesDataGridView;
        private inventoryDBDataSet3 inventoryDBDataSet3;
        private System.Windows.Forms.BindingSource mainCategoriesBindingSource;
        private inventoryDBDataSet3TableAdapters.MainCategoriesTableAdapter mainCategoriesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mainCategoryIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mainCategoryNameDataGridViewTextBoxColumn;
    }
}
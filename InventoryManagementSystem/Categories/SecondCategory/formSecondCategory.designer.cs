namespace InventoryManagementSystem.Category
{
    partial class formSecondCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formSecondCategory));
            this.txtSecondCateId = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSecondCateName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SecondCategoriesDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.secondCategoryIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secondCategoryNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainCategoryNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secondCategoriesViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryDBDataSet4 = new InventoryManagementSystem.inventoryDBDataSet4();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label24 = new System.Windows.Forms.Label();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAddMainCate = new Guna.UI2.WinForms.Guna2Button();
            this.cmbMainCateName = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.secondCategoriesViewTableAdapter = new InventoryManagementSystem.inventoryDBDataSet4TableAdapters.SecondCategoriesViewTableAdapter();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SecondCategoriesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondCategoriesViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDBDataSet4)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSecondCateId
            // 
            this.txtSecondCateId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSecondCateId.DefaultText = "";
            this.txtSecondCateId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSecondCateId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSecondCateId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSecondCateId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSecondCateId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSecondCateId.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecondCateId.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtSecondCateId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSecondCateId.Location = new System.Drawing.Point(32, 228);
            this.txtSecondCateId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSecondCateId.Name = "txtSecondCateId";
            this.txtSecondCateId.PasswordChar = '\0';
            this.txtSecondCateId.PlaceholderText = "Auto Generate";
            this.txtSecondCateId.ReadOnly = true;
            this.txtSecondCateId.SelectedText = "";
            this.txtSecondCateId.Size = new System.Drawing.Size(200, 29);
            this.txtSecondCateId.TabIndex = 208;
            // 
            // txtSecondCateName
            // 
            this.txtSecondCateName.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.txtSecondCateName.BackColor = System.Drawing.Color.Transparent;
            this.txtSecondCateName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSecondCateName.DefaultText = "";
            this.txtSecondCateName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSecondCateName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSecondCateName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSecondCateName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSecondCateName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSecondCateName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecondCateName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtSecondCateName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSecondCateName.Location = new System.Drawing.Point(32, 313);
            this.txtSecondCateName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSecondCateName.Name = "txtSecondCateName";
            this.txtSecondCateName.PasswordChar = '\0';
            this.txtSecondCateName.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.txtSecondCateName.PlaceholderText = "Ex : Laptops, Dresses";
            this.txtSecondCateName.SelectedText = "";
            this.txtSecondCateName.Size = new System.Drawing.Size(200, 29);
            this.txtSecondCateName.TabIndex = 209;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(33, 208);
            this.label8.Margin = new System.Windows.Forms.Padding(0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 15);
            this.label8.TabIndex = 206;
            this.label8.Text = "Second Category ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(33, 293);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 15);
            this.label7.TabIndex = 207;
            this.label7.Text = "Second Category Name";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btnDelete);
            this.panel4.Controls.Add(this.btnRefresh);
            this.panel4.Location = new System.Drawing.Point(-1, 518);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.SecondCategoriesDataGridView);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(501, 570);
            this.panel1.TabIndex = 12;
            // 
            // SecondCategoriesDataGridView
            // 
            this.SecondCategoriesDataGridView.AllowUserToAddRows = false;
            this.SecondCategoriesDataGridView.AllowUserToDeleteRows = false;
            this.SecondCategoriesDataGridView.AllowUserToResizeColumns = false;
            this.SecondCategoriesDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.SecondCategoriesDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.SecondCategoriesDataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SecondCategoriesDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.SecondCategoriesDataGridView.ColumnHeadersHeight = 15;
            this.SecondCategoriesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.SecondCategoriesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.secondCategoryIdDataGridViewTextBoxColumn,
            this.secondCategoryNameDataGridViewTextBoxColumn,
            this.mainCategoryNameDataGridViewTextBoxColumn});
            this.SecondCategoriesDataGridView.DataSource = this.secondCategoriesViewBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SecondCategoriesDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.SecondCategoriesDataGridView.GridColor = System.Drawing.Color.Cyan;
            this.SecondCategoriesDataGridView.Location = new System.Drawing.Point(13, 67);
            this.SecondCategoriesDataGridView.Name = "SecondCategoriesDataGridView";
            this.SecondCategoriesDataGridView.ReadOnly = true;
            this.SecondCategoriesDataGridView.RowHeadersVisible = false;
            this.SecondCategoriesDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.SecondCategoriesDataGridView.Size = new System.Drawing.Size(473, 434);
            this.SecondCategoriesDataGridView.TabIndex = 3;
            this.SecondCategoriesDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.SecondCategoriesDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.SecondCategoriesDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.SecondCategoriesDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.SecondCategoriesDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.SecondCategoriesDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.SecondCategoriesDataGridView.ThemeStyle.GridColor = System.Drawing.Color.Cyan;
            this.SecondCategoriesDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.SecondCategoriesDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.SecondCategoriesDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecondCategoriesDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.SecondCategoriesDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.SecondCategoriesDataGridView.ThemeStyle.HeaderStyle.Height = 15;
            this.SecondCategoriesDataGridView.ThemeStyle.ReadOnly = true;
            this.SecondCategoriesDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.SecondCategoriesDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.SecondCategoriesDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecondCategoriesDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.SecondCategoriesDataGridView.ThemeStyle.RowsStyle.Height = 22;
            this.SecondCategoriesDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.SecondCategoriesDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.SecondCategoriesDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SecondCategoriesDataGridView_CellDoubleClick);
            // 
            // secondCategoryIdDataGridViewTextBoxColumn
            // 
            this.secondCategoryIdDataGridViewTextBoxColumn.DataPropertyName = "SecondCategoryId";
            this.secondCategoryIdDataGridViewTextBoxColumn.HeaderText = "SecondCategoryId";
            this.secondCategoryIdDataGridViewTextBoxColumn.Name = "secondCategoryIdDataGridViewTextBoxColumn";
            this.secondCategoryIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // secondCategoryNameDataGridViewTextBoxColumn
            // 
            this.secondCategoryNameDataGridViewTextBoxColumn.DataPropertyName = "SecondCategoryName";
            this.secondCategoryNameDataGridViewTextBoxColumn.HeaderText = "SecondCategoryName";
            this.secondCategoryNameDataGridViewTextBoxColumn.Name = "secondCategoryNameDataGridViewTextBoxColumn";
            this.secondCategoryNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mainCategoryNameDataGridViewTextBoxColumn
            // 
            this.mainCategoryNameDataGridViewTextBoxColumn.DataPropertyName = "MainCategoryName";
            this.mainCategoryNameDataGridViewTextBoxColumn.HeaderText = "MainCategoryName";
            this.mainCategoryNameDataGridViewTextBoxColumn.Name = "mainCategoryNameDataGridViewTextBoxColumn";
            this.mainCategoryNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // secondCategoriesViewBindingSource
            // 
            this.secondCategoriesViewBindingSource.DataMember = "SecondCategoriesView";
            this.secondCategoriesViewBindingSource.DataSource = this.inventoryDBDataSet4;
            // 
            // inventoryDBDataSet4
            // 
            this.inventoryDBDataSet4.DataSetName = "inventoryDBDataSet4";
            this.inventoryDBDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.label24.Location = new System.Drawing.Point(167, 15);
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
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.btnCancel);
            this.panel6.Controls.Add(this.btnSave);
            this.panel6.Location = new System.Drawing.Point(507, 521);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(292, 51);
            this.panel6.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(53, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "Add Second Categories";
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
            this.panel5.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnAddMainCate);
            this.panel2.Controls.Add(this.cmbMainCateName);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtSecondCateId);
            this.panel2.Controls.Add(this.txtSecondCateName);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.pbImage);
            this.panel2.Location = new System.Drawing.Point(507, 52);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(292, 471);
            this.panel2.TabIndex = 13;
            // 
            // btnAddMainCate
            // 
            this.btnAddMainCate.Animated = true;
            this.btnAddMainCate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddMainCate.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddMainCate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(255)))), ((int)(((byte)(203)))));
            this.btnAddMainCate.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnAddMainCate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(173)))), ((int)(((byte)(27)))));
            this.btnAddMainCate.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(173)))), ((int)(((byte)(27)))));
            this.btnAddMainCate.HoverState.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMainCate.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnAddMainCate.HoverState.Image = global::InventoryManagementSystem.Properties.Resources.icons8_plus_math_480px_1;
            this.btnAddMainCate.Image = global::InventoryManagementSystem.Properties.Resources.icons8_plus_math_480px;
            this.btnAddMainCate.Location = new System.Drawing.Point(238, 404);
            this.btnAddMainCate.Name = "btnAddMainCate";
            this.btnAddMainCate.Size = new System.Drawing.Size(35, 30);
            this.btnAddMainCate.TabIndex = 212;
            this.btnAddMainCate.TextOffset = new System.Drawing.Point(8, 0);
            this.btnAddMainCate.Click += new System.EventHandler(this.btnAddMainCate_Click);
            // 
            // cmbMainCateName
            // 
            this.cmbMainCateName.BackColor = System.Drawing.Color.Transparent;
            this.cmbMainCateName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbMainCateName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMainCateName.FocusedColor = System.Drawing.Color.Empty;
            this.cmbMainCateName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMainCateName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbMainCateName.FormattingEnabled = true;
            this.cmbMainCateName.ItemHeight = 30;
            this.cmbMainCateName.Location = new System.Drawing.Point(32, 401);
            this.cmbMainCateName.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMainCateName.Name = "cmbMainCateName";
            this.cmbMainCateName.Size = new System.Drawing.Size(200, 36);
            this.cmbMainCateName.TabIndex = 211;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(33, 381);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 15);
            this.label1.TabIndex = 210;
            this.label1.Text = "Main Category Name";
            // 
            // pbImage
            // 
            this.pbImage.BackColor = System.Drawing.Color.Transparent;
            this.pbImage.Image = global::InventoryManagementSystem.Properties.Resources.category_icon_png_171;
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
            // secondCategoriesViewTableAdapter
            // 
            this.secondCategoriesViewTableAdapter.ClearBeforeFill = true;
            // 
            // formSecondCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 574);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formSecondCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IMS: Second Categories";
            this.Load += new System.EventHandler(this.formSecondCategory_Load);
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SecondCategoriesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondCategoriesViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDBDataSet4)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2TextBox txtSecondCateId;
        private Guna.UI2.WinForms.Guna2TextBox txtSecondCateName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel4;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2PictureBox pbImage;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnAddMainCate;
        private Guna.UI2.WinForms.Guna2ComboBox cmbMainCateName;
        private Guna.UI2.WinForms.Guna2DataGridView SecondCategoriesDataGridView;
        private inventoryDBDataSet4 inventoryDBDataSet4;
        private System.Windows.Forms.BindingSource secondCategoriesViewBindingSource;
        private inventoryDBDataSet4TableAdapters.SecondCategoriesViewTableAdapter secondCategoriesViewTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn secondCategoryIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn secondCategoryNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mainCategoryNameDataGridViewTextBoxColumn;
    }
}
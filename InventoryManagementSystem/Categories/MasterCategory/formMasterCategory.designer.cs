namespace InventoryManagementSystem.Category
{
    partial class formMasterCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMasterCategory));
            this.panel3 = new System.Windows.Forms.Panel();
            this.label24 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSerachAllCate = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddMainCate = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddVendor = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddSecondCate = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddThirdCate = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddBrandCate = new Guna.UI2.WinForms.Guna2Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label24);
            this.panel3.Controls.Add(this.txtSerachAllCate);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(4, 2);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1041, 62);
            this.panel3.TabIndex = 2;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.label24.Location = new System.Drawing.Point(532, 16);
            this.label24.Margin = new System.Windows.Forms.Padding(0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(141, 23);
            this.label24.TabIndex = 167;
            this.label24.Text = "Seach Categoires";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(18, 13);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 28);
            this.label6.TabIndex = 165;
            this.label6.Text = "View All Categories";
            // 
            // txtSerachAllCate
            // 
            this.txtSerachAllCate.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.txtSerachAllCate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSerachAllCate.DefaultText = "";
            this.txtSerachAllCate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSerachAllCate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSerachAllCate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSerachAllCate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSerachAllCate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSerachAllCate.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtSerachAllCate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSerachAllCate.HoverState.PlaceholderForeColor = System.Drawing.Color.Transparent;
            this.txtSerachAllCate.Location = new System.Drawing.Point(696, 9);
            this.txtSerachAllCate.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtSerachAllCate.Name = "txtSerachAllCate";
            this.txtSerachAllCate.PasswordChar = '\0';
            this.txtSerachAllCate.PlaceholderText = "by Name, Tag, Cate. Brand";
            this.txtSerachAllCate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSerachAllCate.SelectedText = "";
            this.txtSerachAllCate.Size = new System.Drawing.Size(327, 37);
            this.txtSerachAllCate.TabIndex = 166;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnAddBrandCate);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnAddMainCate);
            this.panel1.Controls.Add(this.btnAddVendor);
            this.panel1.Controls.Add(this.btnAddSecondCate);
            this.panel1.Controls.Add(this.btnAddThirdCate);
            this.panel1.Location = new System.Drawing.Point(4, 68);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1041, 92);
            this.panel1.TabIndex = 3;
            // 
            // btnAddMainCate
            // 
            this.btnAddMainCate.Animated = true;
            this.btnAddMainCate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddMainCate.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddMainCate.CustomImages.ImageOffset = new System.Drawing.Point(10, -1);
            this.btnAddMainCate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(255)))), ((int)(((byte)(203)))));
            this.btnAddMainCate.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMainCate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(173)))), ((int)(((byte)(27)))));
            this.btnAddMainCate.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(173)))), ((int)(((byte)(27)))));
            this.btnAddMainCate.HoverState.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMainCate.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnAddMainCate.Location = new System.Drawing.Point(16, 11);
            this.btnAddMainCate.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddMainCate.Name = "btnAddMainCate";
            this.btnAddMainCate.Size = new System.Drawing.Size(317, 43);
            this.btnAddMainCate.TabIndex = 174;
            this.btnAddMainCate.Text = "Add - Main Categories";
            this.btnAddMainCate.TextOffset = new System.Drawing.Point(8, 0);
            // 
            // btnAddVendor
            // 
            this.btnAddVendor.Animated = true;
            this.btnAddVendor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddVendor.CustomImages.HoveredImage = ((System.Drawing.Image)(resources.GetObject("resource.HoveredImage1")));
            this.btnAddVendor.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.btnAddVendor.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddVendor.CustomImages.ImageOffset = new System.Drawing.Point(10, -1);
            this.btnAddVendor.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(255)))), ((int)(((byte)(203)))));
            this.btnAddVendor.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddVendor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(173)))), ((int)(((byte)(27)))));
            this.btnAddVendor.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(173)))), ((int)(((byte)(27)))));
            this.btnAddVendor.HoverState.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddVendor.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnAddVendor.Location = new System.Drawing.Point(1039, 11);
            this.btnAddVendor.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddVendor.Name = "btnAddVendor";
            this.btnAddVendor.Size = new System.Drawing.Size(241, 43);
            this.btnAddVendor.TabIndex = 173;
            this.btnAddVendor.Text = "Add - Vendors";
            this.btnAddVendor.TextOffset = new System.Drawing.Point(8, 0);
            // 
            // btnAddSecondCate
            // 
            this.btnAddSecondCate.Animated = true;
            this.btnAddSecondCate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddSecondCate.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddSecondCate.CustomImages.ImageOffset = new System.Drawing.Point(10, -1);
            this.btnAddSecondCate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(255)))), ((int)(((byte)(203)))));
            this.btnAddSecondCate.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSecondCate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(173)))), ((int)(((byte)(27)))));
            this.btnAddSecondCate.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(173)))), ((int)(((byte)(27)))));
            this.btnAddSecondCate.HoverState.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSecondCate.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnAddSecondCate.Location = new System.Drawing.Point(355, 11);
            this.btnAddSecondCate.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddSecondCate.Name = "btnAddSecondCate";
            this.btnAddSecondCate.Size = new System.Drawing.Size(333, 43);
            this.btnAddSecondCate.TabIndex = 171;
            this.btnAddSecondCate.Text = "Add - Second Categories";
            this.btnAddSecondCate.TextOffset = new System.Drawing.Point(8, 0);
            // 
            // btnAddThirdCate
            // 
            this.btnAddThirdCate.Animated = true;
            this.btnAddThirdCate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddThirdCate.CustomImages.HoveredImage = ((System.Drawing.Image)(resources.GetObject("resource.HoveredImage2")));
            this.btnAddThirdCate.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.btnAddThirdCate.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddThirdCate.CustomImages.ImageOffset = new System.Drawing.Point(10, -1);
            this.btnAddThirdCate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(255)))), ((int)(((byte)(203)))));
            this.btnAddThirdCate.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddThirdCate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(173)))), ((int)(((byte)(27)))));
            this.btnAddThirdCate.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(173)))), ((int)(((byte)(27)))));
            this.btnAddThirdCate.HoverState.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddThirdCate.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnAddThirdCate.Location = new System.Drawing.Point(710, 11);
            this.btnAddThirdCate.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddThirdCate.Name = "btnAddThirdCate";
            this.btnAddThirdCate.Size = new System.Drawing.Size(308, 43);
            this.btnAddThirdCate.TabIndex = 170;
            this.btnAddThirdCate.Text = "Add - Third Categories";
            this.btnAddThirdCate.TextOffset = new System.Drawing.Point(8, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.label1.Location = new System.Drawing.Point(1541, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 23);
            this.label1.TabIndex = 168;
            // 
            // btnAddBrandCate
            // 
            this.btnAddBrandCate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddBrandCate.Animated = true;
            this.btnAddBrandCate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddBrandCate.CustomImages.HoveredImage = ((System.Drawing.Image)(resources.GetObject("resource.HoveredImage")));
            this.btnAddBrandCate.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btnAddBrandCate.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddBrandCate.CustomImages.ImageOffset = new System.Drawing.Point(10, -1);
            this.btnAddBrandCate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(255)))), ((int)(((byte)(203)))));
            this.btnAddBrandCate.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBrandCate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(173)))), ((int)(((byte)(27)))));
            this.btnAddBrandCate.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(173)))), ((int)(((byte)(27)))));
            this.btnAddBrandCate.HoverState.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBrandCate.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnAddBrandCate.Location = new System.Drawing.Point(1300, 11);
            this.btnAddBrandCate.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddBrandCate.Name = "btnAddBrandCate";
            this.btnAddBrandCate.Size = new System.Drawing.Size(228, 43);
            this.btnAddBrandCate.TabIndex = 175;
            this.btnAddBrandCate.Text = "Add - Brands";
            this.btnAddBrandCate.TextOffset = new System.Drawing.Point(8, 0);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv1,
            this.dgv2,
            this.dgv3,
            this.dgv4,
            this.dgv5});
            this.dataGridView1.Location = new System.Drawing.Point(4, 166);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1040, 429);
            this.dataGridView1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.guna2Button1);
            this.panel2.Location = new System.Drawing.Point(3, 600);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1041, 55);
            this.panel2.TabIndex = 5;
            // 
            // dgv1
            // 
            this.dgv1.FillWeight = 400F;
            this.dgv1.HeaderText = "Brand Name";
            this.dgv1.MinimumWidth = 6;
            this.dgv1.Name = "dgv1";
            this.dgv1.ReadOnly = true;
            this.dgv1.Width = 125;
            // 
            // dgv2
            // 
            this.dgv2.HeaderText = "Vendor Name";
            this.dgv2.MinimumWidth = 6;
            this.dgv2.Name = "dgv2";
            this.dgv2.ReadOnly = true;
            this.dgv2.Width = 125;
            // 
            // dgv3
            // 
            this.dgv3.HeaderText = "Third Category Name";
            this.dgv3.MinimumWidth = 6;
            this.dgv3.Name = "dgv3";
            this.dgv3.ReadOnly = true;
            this.dgv3.Width = 220;
            // 
            // dgv4
            // 
            this.dgv4.HeaderText = "Second Category Name";
            this.dgv4.MinimumWidth = 6;
            this.dgv4.Name = "dgv4";
            this.dgv4.ReadOnly = true;
            this.dgv4.Width = 220;
            // 
            // dgv5
            // 
            this.dgv5.HeaderText = "Main Category Name";
            this.dgv5.MinimumWidth = 6;
            this.dgv5.Name = "dgv5";
            this.dgv5.ReadOnly = true;
            this.dgv5.Width = 220;
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button1.CustomImages.HoveredImage = global::InventoryManagementSystem.Properties.Resources.icons8_restart_96px_11;
            this.guna2Button1.CustomImages.Image = global::InventoryManagementSystem.Properties.Resources.icons8_restart_96px1;
            this.guna2Button1.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button1.CustomImages.ImageOffset = new System.Drawing.Point(10, -1);
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(233)))), ((int)(((byte)(249)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(148)))), ((int)(((byte)(247)))));
            this.guna2Button1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(148)))), ((int)(((byte)(247)))));
            this.guna2Button1.HoverState.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(233)))), ((int)(((byte)(249)))));
            this.guna2Button1.Location = new System.Drawing.Point(399, 6);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(263, 43);
            this.guna2Button1.TabIndex = 174;
            this.guna2Button1.Text = "Refresh";
            this.guna2Button1.TextOffset = new System.Drawing.Point(15, 0);
            // 
            // formMasterCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Name = "formMasterCategory";
            this.Size = new System.Drawing.Size(1049, 660);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label24;
        private Guna.UI2.WinForms.Guna2TextBox txtSerachAllCate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnAddBrandCate;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnAddMainCate;
        private Guna.UI2.WinForms.Guna2Button btnAddVendor;
        private Guna.UI2.WinForms.Guna2Button btnAddSecondCate;
        private Guna.UI2.WinForms.Guna2Button btnAddThirdCate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv5;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}

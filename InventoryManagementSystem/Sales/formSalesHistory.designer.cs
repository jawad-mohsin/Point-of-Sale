namespace InventoryManagementSystem.Orders
{
    partial class formSalesHistory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTotalItemResult = new System.Windows.Forms.Label();
            this.lblTotalItemFound = new System.Windows.Forms.Label();
            this.btnCancelSearch = new Guna.UI2.WinForms.Guna2Button();
            this.txtSearchForSell = new Guna.UI2.WinForms.Guna2TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.SalesHistoryDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SalesHistoryDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lblTotalItemResult);
            this.panel3.Controls.Add(this.lblTotalItemFound);
            this.panel3.Controls.Add(this.btnCancelSearch);
            this.panel3.Controls.Add(this.txtSearchForSell);
            this.panel3.Controls.Add(this.label24);
            this.panel3.Location = new System.Drawing.Point(3, 2);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(781, 51);
            this.panel3.TabIndex = 3;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // lblTotalItemResult
            // 
            this.lblTotalItemResult.AutoSize = true;
            this.lblTotalItemResult.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalItemResult.ForeColor = System.Drawing.Color.Black;
            this.lblTotalItemResult.Location = new System.Drawing.Point(730, 12);
            this.lblTotalItemResult.Name = "lblTotalItemResult";
            this.lblTotalItemResult.Size = new System.Drawing.Size(19, 21);
            this.lblTotalItemResult.TabIndex = 216;
            this.lblTotalItemResult.Text = "0";
            // 
            // lblTotalItemFound
            // 
            this.lblTotalItemFound.AutoSize = true;
            this.lblTotalItemFound.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalItemFound.ForeColor = System.Drawing.Color.Black;
            this.lblTotalItemFound.Location = new System.Drawing.Point(673, 11);
            this.lblTotalItemFound.Name = "lblTotalItemFound";
            this.lblTotalItemFound.Size = new System.Drawing.Size(53, 21);
            this.lblTotalItemFound.TabIndex = 215;
            this.lblTotalItemFound.Text = "Total :";
            // 
            // btnCancelSearch
            // 
            this.btnCancelSearch.Animated = true;
            this.btnCancelSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelSearch.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCancelSearch.FillColor = System.Drawing.Color.Transparent;
            this.btnCancelSearch.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnCancelSearch.ForeColor = System.Drawing.Color.Transparent;
            this.btnCancelSearch.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnCancelSearch.HoverState.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelSearch.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnCancelSearch.Location = new System.Drawing.Point(632, 11);
            this.btnCancelSearch.Name = "btnCancelSearch";
            this.btnCancelSearch.Size = new System.Drawing.Size(26, 25);
            this.btnCancelSearch.TabIndex = 214;
            this.btnCancelSearch.TextOffset = new System.Drawing.Point(8, 0);
            // 
            // txtSearchForSell
            // 
            this.txtSearchForSell.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.txtSearchForSell.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchForSell.DefaultText = "";
            this.txtSearchForSell.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchForSell.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchForSell.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchForSell.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchForSell.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchForSell.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchForSell.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchForSell.HoverState.PlaceholderForeColor = System.Drawing.Color.Transparent;
            this.txtSearchForSell.Location = new System.Drawing.Point(125, 10);
            this.txtSearchForSell.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSearchForSell.Name = "txtSearchForSell";
            this.txtSearchForSell.PasswordChar = '\0';
            this.txtSearchForSell.PlaceholderText = "by Name, Tag, Brand etc.";
            this.txtSearchForSell.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSearchForSell.SelectedText = "";
            this.txtSearchForSell.Size = new System.Drawing.Size(500, 30);
            this.txtSearchForSell.TabIndex = 212;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.label24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.label24.Location = new System.Drawing.Point(7, 15);
            this.label24.Margin = new System.Windows.Forms.Padding(0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(109, 20);
            this.label24.TabIndex = 211;
            this.label24.Text = "Search Invoice";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.guna2Button1);
            this.panel2.Location = new System.Drawing.Point(3, 488);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(781, 45);
            this.panel2.TabIndex = 6;
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button1.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button1.CustomImages.ImageOffset = new System.Drawing.Point(10, -1);
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(233)))), ((int)(((byte)(249)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(148)))), ((int)(((byte)(247)))));
            this.guna2Button1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(148)))), ((int)(((byte)(247)))));
            this.guna2Button1.HoverState.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(233)))), ((int)(((byte)(249)))));
            this.guna2Button1.Location = new System.Drawing.Point(299, 5);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(197, 35);
            this.guna2Button1.TabIndex = 174;
            this.guna2Button1.Text = "Refresh";
            this.guna2Button1.TextOffset = new System.Drawing.Point(15, 0);
            // 
            // SalesHistoryDataGridView
            // 
            this.SalesHistoryDataGridView.AllowUserToAddRows = false;
            this.SalesHistoryDataGridView.AllowUserToDeleteRows = false;
            this.SalesHistoryDataGridView.AllowUserToResizeColumns = false;
            this.SalesHistoryDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.SalesHistoryDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.SalesHistoryDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.SalesHistoryDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SalesHistoryDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.SalesHistoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SalesHistoryDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.SalesHistoryDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.SalesHistoryDataGridView.Location = new System.Drawing.Point(15, 68);
            this.SalesHistoryDataGridView.Name = "SalesHistoryDataGridView";
            this.SalesHistoryDataGridView.RowHeadersVisible = false;
            this.SalesHistoryDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.SalesHistoryDataGridView.Size = new System.Drawing.Size(756, 407);
            this.SalesHistoryDataGridView.TabIndex = 7;
            this.SalesHistoryDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.SalesHistoryDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.SalesHistoryDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.SalesHistoryDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.SalesHistoryDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.SalesHistoryDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.SalesHistoryDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.SalesHistoryDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.SalesHistoryDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.SalesHistoryDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesHistoryDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.SalesHistoryDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SalesHistoryDataGridView.ThemeStyle.HeaderStyle.Height = 4;
            this.SalesHistoryDataGridView.ThemeStyle.ReadOnly = false;
            this.SalesHistoryDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.SalesHistoryDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.SalesHistoryDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesHistoryDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.SalesHistoryDataGridView.ThemeStyle.RowsStyle.Height = 22;
            this.SalesHistoryDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.SalesHistoryDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // formSalesHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SalesHistoryDataGridView);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "formSalesHistory";
            this.Size = new System.Drawing.Size(787, 536);
            this.Load += new System.EventHandler(this.formSalesHistory_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SalesHistoryDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTotalItemResult;
        private System.Windows.Forms.Label lblTotalItemFound;
        private Guna.UI2.WinForms.Guna2Button btnCancelSearch;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchForSell;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2DataGridView SalesHistoryDataGridView;
    }
}


namespace Accounting.App
{
    partial class frmCustomers
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAddNewCustomer = new System.Windows.Forms.ToolStripButton();
            this.btnEditCustomer = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteCustomer = new System.Windows.Forms.ToolStripButton();
            this.btnRefreshCustomer = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtFilterCustomer = new System.Windows.Forms.ToolStripTextBox();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.CustomerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerMobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddNewCustomer,
            this.btnEditCustomer,
            this.btnDeleteCustomer,
            this.btnRefreshCustomer,
            this.toolStripLabel1,
            this.txtFilterCustomer});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(584, 62);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAddNewCustomer
            // 
            this.btnAddNewCustomer.Image = global::Accounting.App.Properties.Resources._1371475930_filenew;
            this.btnAddNewCustomer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAddNewCustomer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddNewCustomer.Name = "btnAddNewCustomer";
            this.btnAddNewCustomer.Size = new System.Drawing.Size(90, 59);
            this.btnAddNewCustomer.Text = "New Customer";
            this.btnAddNewCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAddNewCustomer.Click += new System.EventHandler(this.btnAddNewCustomer_Click);
            // 
            // btnEditCustomer
            // 
            this.btnEditCustomer.Image = global::Accounting.App.Properties.Resources._1371475973_document_edit;
            this.btnEditCustomer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnEditCustomer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditCustomer.Name = "btnEditCustomer";
            this.btnEditCustomer.Size = new System.Drawing.Size(86, 59);
            this.btnEditCustomer.Text = "Edit Customer";
            this.btnEditCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.Image = global::Accounting.App.Properties.Resources._1371476007_Close_Box_Red;
            this.btnDeleteCustomer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnDeleteCustomer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(99, 59);
            this.btnDeleteCustomer.Text = "Delete Customer";
            this.btnDeleteCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            // 
            // btnRefreshCustomer
            // 
            this.btnRefreshCustomer.Image = global::Accounting.App.Properties.Resources._1371476368_Synchronize;
            this.btnRefreshCustomer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnRefreshCustomer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefreshCustomer.Name = "btnRefreshCustomer";
            this.btnRefreshCustomer.Size = new System.Drawing.Size(50, 59);
            this.btnRefreshCustomer.Text = "Refresh";
            this.btnRefreshCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRefreshCustomer.Click += new System.EventHandler(this.btnRefreshCustomer_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(42, 59);
            this.toolStripLabel1.Text = "Search";
            // 
            // txtFilterCustomer
            // 
            this.txtFilterCustomer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFilterCustomer.Name = "txtFilterCustomer";
            this.txtFilterCustomer.Size = new System.Drawing.Size(100, 62);
            this.txtFilterCustomer.TextChanged += new System.EventHandler(this.txtFilterCustomer_TextChanged);
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.AllowUserToAddRows = false;
            this.dgvCustomers.AllowUserToDeleteRows = false;
            this.dgvCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerId,
            this.CustomerFullName,
            this.CustomerMobile,
            this.CustomerEmail,
            this.CustomerAddress});
            this.dgvCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCustomers.Location = new System.Drawing.Point(0, 62);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.ReadOnly = true;
            this.dgvCustomers.Size = new System.Drawing.Size(584, 299);
            this.dgvCustomers.TabIndex = 1;
            // 
            // CustomerId
            // 
            this.CustomerId.DataPropertyName = "CustomerID";
            this.CustomerId.HeaderText = "ID";
            this.CustomerId.Name = "CustomerId";
            this.CustomerId.ReadOnly = true;
            this.CustomerId.Visible = false;
            // 
            // CustomerFullName
            // 
            this.CustomerFullName.DataPropertyName = "FullName";
            this.CustomerFullName.HeaderText = "FullName";
            this.CustomerFullName.Name = "CustomerFullName";
            this.CustomerFullName.ReadOnly = true;
            // 
            // CustomerMobile
            // 
            this.CustomerMobile.DataPropertyName = "Mobile";
            this.CustomerMobile.HeaderText = "Mobile";
            this.CustomerMobile.Name = "CustomerMobile";
            this.CustomerMobile.ReadOnly = true;
            // 
            // CustomerEmail
            // 
            this.CustomerEmail.DataPropertyName = "Email";
            this.CustomerEmail.HeaderText = "Email";
            this.CustomerEmail.Name = "CustomerEmail";
            this.CustomerEmail.ReadOnly = true;
            // 
            // CustomerAddress
            // 
            this.CustomerAddress.DataPropertyName = "Address";
            this.CustomerAddress.HeaderText = "Address";
            this.CustomerAddress.Name = "CustomerAddress";
            this.CustomerAddress.ReadOnly = true;
            // 
            // frmCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.dgvCustomers);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmCustomers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Customers List";
            this.Load += new System.EventHandler(this.frmCustomers_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAddNewCustomer;
        private System.Windows.Forms.ToolStripButton btnEditCustomer;
        private System.Windows.Forms.ToolStripButton btnDeleteCustomer;
        private System.Windows.Forms.ToolStripButton btnRefreshCustomer;
        private System.Windows.Forms.ToolStripTextBox txtFilterCustomer;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerMobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerAddress;
    }
}
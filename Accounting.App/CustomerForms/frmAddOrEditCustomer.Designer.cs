
namespace Accounting.App
{
    partial class frmAddOrEditCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddOrEditCustomer));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSelectCustomerImage = new System.Windows.Forms.Button();
            this.pcCustomerImage = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCustomerAddress = new System.Windows.Forms.TextBox();
            this.lblCustomerAddress = new System.Windows.Forms.Label();
            this.txtCustomerEmail = new System.Windows.Forms.TextBox();
            this.lblCustomerEmail = new System.Windows.Forms.Label();
            this.txtCustomerMobile = new System.Windows.Forms.TextBox();
            this.lblCustomerMobile = new System.Windows.Forms.Label();
            this.txtCustomerFullName = new System.Windows.Forms.TextBox();
            this.lblCustomerFullName = new System.Windows.Forms.Label();
            this.brnSaveCustomer = new System.Windows.Forms.Button();
            this.requiredFieldValidator1 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.requiredFieldValidator2 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcCustomerImage)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSelectCustomerImage);
            this.groupBox1.Controls.Add(this.pcCustomerImage);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(192, 265);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Image";
            // 
            // btnSelectCustomerImage
            // 
            this.btnSelectCustomerImage.Location = new System.Drawing.Point(6, 228);
            this.btnSelectCustomerImage.Name = "btnSelectCustomerImage";
            this.btnSelectCustomerImage.Size = new System.Drawing.Size(180, 23);
            this.btnSelectCustomerImage.TabIndex = 9;
            this.btnSelectCustomerImage.Text = "Select Image";
            this.btnSelectCustomerImage.UseVisualStyleBackColor = true;
            this.btnSelectCustomerImage.Click += new System.EventHandler(this.btnSelectCustomerImage_Click);
            // 
            // pcCustomerImage
            // 
            this.pcCustomerImage.Image = global::Accounting.App.Properties.Resources.no_photo_available_icon_20;
            this.pcCustomerImage.Location = new System.Drawing.Point(6, 19);
            this.pcCustomerImage.Name = "pcCustomerImage";
            this.pcCustomerImage.Size = new System.Drawing.Size(180, 203);
            this.pcCustomerImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcCustomerImage.TabIndex = 8;
            this.pcCustomerImage.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCustomerAddress);
            this.groupBox2.Controls.Add(this.lblCustomerAddress);
            this.groupBox2.Controls.Add(this.txtCustomerEmail);
            this.groupBox2.Controls.Add(this.lblCustomerEmail);
            this.groupBox2.Controls.Add(this.txtCustomerMobile);
            this.groupBox2.Controls.Add(this.lblCustomerMobile);
            this.groupBox2.Controls.Add(this.txtCustomerFullName);
            this.groupBox2.Controls.Add(this.lblCustomerFullName);
            this.groupBox2.Location = new System.Drawing.Point(210, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(262, 265);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Customer Information";
            // 
            // txtCustomerAddress
            // 
            this.txtCustomerAddress.Location = new System.Drawing.Point(9, 171);
            this.txtCustomerAddress.Multiline = true;
            this.txtCustomerAddress.Name = "txtCustomerAddress";
            this.txtCustomerAddress.Size = new System.Drawing.Size(232, 88);
            this.txtCustomerAddress.TabIndex = 7;
            // 
            // lblCustomerAddress
            // 
            this.lblCustomerAddress.AutoSize = true;
            this.lblCustomerAddress.Location = new System.Drawing.Point(6, 155);
            this.lblCustomerAddress.Name = "lblCustomerAddress";
            this.lblCustomerAddress.Size = new System.Drawing.Size(48, 13);
            this.lblCustomerAddress.TabIndex = 6;
            this.lblCustomerAddress.Text = "Address:";
            // 
            // txtCustomerEmail
            // 
            this.txtCustomerEmail.Location = new System.Drawing.Point(9, 130);
            this.txtCustomerEmail.Name = "txtCustomerEmail";
            this.txtCustomerEmail.Size = new System.Drawing.Size(232, 20);
            this.txtCustomerEmail.TabIndex = 5;
            // 
            // lblCustomerEmail
            // 
            this.lblCustomerEmail.AutoSize = true;
            this.lblCustomerEmail.Location = new System.Drawing.Point(6, 114);
            this.lblCustomerEmail.Name = "lblCustomerEmail";
            this.lblCustomerEmail.Size = new System.Drawing.Size(35, 13);
            this.lblCustomerEmail.TabIndex = 4;
            this.lblCustomerEmail.Text = "Email:";
            // 
            // txtCustomerMobile
            // 
            this.txtCustomerMobile.Location = new System.Drawing.Point(9, 87);
            this.txtCustomerMobile.Name = "txtCustomerMobile";
            this.txtCustomerMobile.Size = new System.Drawing.Size(232, 20);
            this.txtCustomerMobile.TabIndex = 3;
            // 
            // lblCustomerMobile
            // 
            this.lblCustomerMobile.AutoSize = true;
            this.lblCustomerMobile.Location = new System.Drawing.Point(6, 71);
            this.lblCustomerMobile.Name = "lblCustomerMobile";
            this.lblCustomerMobile.Size = new System.Drawing.Size(41, 13);
            this.lblCustomerMobile.TabIndex = 2;
            this.lblCustomerMobile.Text = "Mobile:";
            // 
            // txtCustomerFullName
            // 
            this.txtCustomerFullName.Location = new System.Drawing.Point(9, 43);
            this.txtCustomerFullName.Name = "txtCustomerFullName";
            this.txtCustomerFullName.Size = new System.Drawing.Size(232, 20);
            this.txtCustomerFullName.TabIndex = 1;
            // 
            // lblCustomerFullName
            // 
            this.lblCustomerFullName.AutoSize = true;
            this.lblCustomerFullName.Location = new System.Drawing.Point(6, 27);
            this.lblCustomerFullName.Name = "lblCustomerFullName";
            this.lblCustomerFullName.Size = new System.Drawing.Size(57, 13);
            this.lblCustomerFullName.TabIndex = 0;
            this.lblCustomerFullName.Text = "Full Name:";
            // 
            // brnSaveCustomer
            // 
            this.brnSaveCustomer.Location = new System.Drawing.Point(397, 283);
            this.brnSaveCustomer.Name = "brnSaveCustomer";
            this.brnSaveCustomer.Size = new System.Drawing.Size(75, 23);
            this.brnSaveCustomer.TabIndex = 1;
            this.brnSaveCustomer.Text = "Save";
            this.brnSaveCustomer.UseVisualStyleBackColor = true;
            this.brnSaveCustomer.Click += new System.EventHandler(this.brnSaveCustomer_Click);
            // 
            // requiredFieldValidator1
            // 
            this.requiredFieldValidator1.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator1.ControlToValidate = this.txtCustomerFullName;
            this.requiredFieldValidator1.ErrorMessage = "Please Fill Full Name";
            this.requiredFieldValidator1.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator1.Icon")));
            // 
            // requiredFieldValidator2
            // 
            this.requiredFieldValidator2.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator2.ControlToValidate = this.txtCustomerMobile;
            this.requiredFieldValidator2.ErrorMessage = "Please Fill Mobile Field";
            this.requiredFieldValidator2.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator2.Icon")));
            // 
            // frmAddOrEditCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 311);
            this.Controls.Add(this.brnSaveCustomer);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddOrEditCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add New Customer";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcCustomerImage)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCustomerAddress;
        private System.Windows.Forms.Label lblCustomerAddress;
        private System.Windows.Forms.TextBox txtCustomerEmail;
        private System.Windows.Forms.Label lblCustomerEmail;
        private System.Windows.Forms.TextBox txtCustomerMobile;
        private System.Windows.Forms.Label lblCustomerMobile;
        private System.Windows.Forms.TextBox txtCustomerFullName;
        private System.Windows.Forms.Label lblCustomerFullName;
        private System.Windows.Forms.PictureBox pcCustomerImage;
        private System.Windows.Forms.Button btnSelectCustomerImage;
        private System.Windows.Forms.Button brnSaveCustomer;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator1;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator2;
    }
}
using Accounting.DataLayer.Context;
using Accounting.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ValidationComponents;

namespace Accounting.App
{
    public partial class frmAddOrEditCustomer : Form
    {
        UnitOfWork db = new UnitOfWork();
        public frmAddOrEditCustomer()
        {
            InitializeComponent();
        }

        private void btnSelectCustomerImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                pcCustomerImage.ImageLocation = openFile.FileName;
            }
        }

        private void brnSaveCustomer_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components))
            {
                string imageName = Guid.NewGuid().ToString() + Path.GetExtension(pcCustomerImage.ImageLocation);
                string path = Application.StartupPath + "/Image/";
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                pcCustomerImage.Image.Save(path + imageName);
                Customer customer = new Customer()
                {
                    FullName = txtCustomerFullName.Text,
                    Mobile = txtCustomerMobile.Text,
                    Email = txtCustomerEmail.Text,
                    Address = txtCustomerAddress.Text,
                    CustomerImage = imageName
                };
                db.CustomerRepository.InsertCustomer(customer);
                db.Save();
                DialogResult = DialogResult.OK;
            }
        }
    }
}

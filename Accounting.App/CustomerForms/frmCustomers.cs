using Accounting.DataLayer.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accounting.App
{
    public partial class frmCustomers : Form
    {
        public frmCustomers()
        {
            InitializeComponent();
        }

        private void frmCustomers_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        void BindGrid()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                dgvCustomers.AutoGenerateColumns = false;
                dgvCustomers.DataSource = db.CustomerRepository.GetAllCustomers();
            }
        }

        private void btnRefreshCustomer_Click(object sender, EventArgs e)
        {
            BindGrid();
            txtFilterCustomer.Text = "";
        }

        private void txtFilterCustomer_TextChanged(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                dgvCustomers.DataSource = db.CustomerRepository.GetCustomersByFilter(txtFilterCustomer.Text);
            }
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.CurrentRow != null)
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    string name = dgvCustomers.CurrentRow.Cells[1].Value.ToString();
                    if (MessageBox.Show($"Are you sure to delete {name}?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        int customerId = int.Parse(dgvCustomers.CurrentRow.Cells[0].Value.ToString());
                        db.CustomerRepository.DeleteCustomer(customerId);
                        db.Save();
                        BindGrid();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select one row from grid to delete", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAddNewCustomer_Click(object sender, EventArgs e)
        {
            frmAddOrEditCustomer frmAdd = new frmAddOrEditCustomer();
            if (frmAdd.ShowDialog() == DialogResult.OK)
            {
                BindGrid();
            } 
        }
    }
}

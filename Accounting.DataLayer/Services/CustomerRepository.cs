using Accounting.DataLayer.Context;
using Accounting.DataLayer.Repositories;
using Accounting.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.DataLayer.Services
{
    public class CustomerRepository : ICustomerRepository
    {
        private AccountingContext db;

        public CustomerRepository(AccountingContext context)
        {
            db = context;
        }
        public List<Customer> GetAllCustomers()
        {
            return db.Customers.ToList();
        }

        public Customer GetCustomerById(int customerId)
        {
            return db.Customers.Find(customerId);
        }

        public bool InsertCustomer(Customer customer)
        {
            try
            {
                db.Customers.Add(customer);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool UpdateCustomer(Customer customer)
        {
            try
            {
                db.Entry(customer).State = EntityState.Modified;
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool DeleteCustomer(Customer customer)
        {
            try
            {
                db.Entry(customer).State = EntityState.Deleted;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteCustomer(int customerId)
        {
            try
            {
                var customer = GetCustomerById(customerId);
                DeleteCustomer(customer);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
        public void Save()
        {
            db.SaveChanges();
        }

        public IEnumerable<Customer> GetCustomersByFilter(string parameter)
        {
            return db.Customers.Where(c => c.FullName.Contains(parameter) || c.Email.Contains(parameter) || c.Mobile.Contains(parameter)).ToList();
        }
    }
}

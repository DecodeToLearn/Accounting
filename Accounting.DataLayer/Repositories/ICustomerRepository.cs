using Accounting.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.DataLayer.Repositories
{
    public interface ICustomerRepository
    {
        List<Customer> GetAllCustomers();
        Customer GetCustomerById(int customerId);
        IEnumerable<Customer> GetCustomersByFilter(string parameter);
        bool InsertCustomer(Customer customer);
        bool UpdateCustomer(Customer customer);
        bool DeleteCustomer(Customer customer);
        bool DeleteCustomer(int customerId);
    }
}

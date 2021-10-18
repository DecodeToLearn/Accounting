using Accounting.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.DataLayer.Context
{
    public class AccountingContext : DbContext
    {
        public AccountingContext() : base("name=Accounting_DBConnectionString")
        {

        }

        public DbSet<Customer> Customers { get; set; }
    }
}

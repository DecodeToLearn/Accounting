using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Domain
{
    public class Customer
    {
        public int CustomerID { get; set; }
        [StringLength(300)]
        public string FullName { get; set; }
        [StringLength(150)]
        public string Mobile { get; set; }
        [StringLength(150)]
        public string Email { get; set; }
        [StringLength(800)]
        public string Address { get; set; }
        [StringLength(50)]
        public string CustomerImage { get; set; }
    }
}

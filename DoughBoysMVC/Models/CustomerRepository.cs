using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoughBoysMVC.Models
{
    public class CustomerRepository
    {
        private static List<Customer> customers = new List<Customer>();
        public static IEnumerable<Customer> Customers { get; }
        public static void AddCustomer(Customer customer)
        {
            customers.Add(customer);
        }
    }
}

using LocalDbExample.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalDbExample.Domain
{
    public class CustomerManager
    {
        public static List<DTO.Customer> GetCustomers()
        {
            var customers = CustomersRepository.GetCustomers();
            return customers;

        } 

    }
}

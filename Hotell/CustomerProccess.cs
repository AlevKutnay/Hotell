using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotell
{

    internal class CustomerProccess : ICrud<Customer>
    {
        public bool Add(Customer entity)
        {
            try
            {
                DbContext.CustomerList.Add(entity);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            bool result = false;
            foreach (var customer in DbContext.CustomerList.ToList())
            {
                if (customer.Id == id)
                {
                    DbContext.CustomerList.Remove(customer);
                    result = true;
                }
            }
            return result;
        }

        public Customer Detail(int id)
        {
            Customer newCustomer = new Customer();
            foreach (var customer in DbContext.CustomerList.ToList())
            {
                if (customer.Id == id)
                {
                    newCustomer = customer;
                }
            }
            return newCustomer;
        }

        public List<Customer> List()
        {
            return DbContext.CustomerList.ToList();
        }
    }
}

using Kamran.Core.Data;
using Kamran.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kamran.Services
{
    public partial class CustomerService : ICustomerService
    {

        private readonly IRepository<Customer> _customerRepository;


        public CustomerService(IRepository<Customer> customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public List<Customer> GetAll()
        {
            var query = _customerRepository.Table.ToList();
            return query;
        }



        public virtual Customer GetCustomerById(int customerId)
        {
            if (customerId == 0)
                return null;

            return _customerRepository.GetById(customerId);
        }
    }
}

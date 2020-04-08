using Kamran.Core.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kamran.Services
{
    public partial interface ICustomerService
    {
        List<Customer> GetAll();

        Customer GetCustomerById(int customerId);
    }
}

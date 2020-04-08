using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kamran.Core.Data;
using Kamran.Core.Domain;
using Kamran.Data;
using Kamran.Services;
using Microsoft.AspNetCore.Mvc;

namespace Kamran.Web.Controllers
{
    public class HomeController : Controller
    {
        private ICustomerService _customer;

        public HomeController(ICustomerService customer)
        {
            _customer = customer;
        }

        public IActionResult Index()
        {
            //_customer.GetAll();
             var OneCustomer=_customer.GetCustomerById(1);
            return View();
        }
    }
}
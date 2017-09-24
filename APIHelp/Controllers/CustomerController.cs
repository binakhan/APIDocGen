using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using APIHelp.Models;

namespace APIHelp.Controllers
{
    /// <summary>
    /// Contains functionality for Customer Services
    /// </summary>
    public class CustomerController : ApiController
    {
        /// <summary>
        /// Gets Customer
        /// </summary>
        /// <returns>Customer object</returns>
        [HttpGet]
        public Customer GetCustomer()
        {
            Customer cust = new Customer { Address = "Karachi, Pakistan", DateofBirth = DateTime.Now,
            FirstName = "Test", ID = 234, LastName = "Customer"};
            return cust;
        }

        /// <summary>
        /// Inserts Customer
        /// </summary>
        /// <param name="customer">Customer to be added</param>
        /// <returns>Response of operation</returns>
        [HttpPost]
        public string Add(Customer customer)
        {
            return "Customer added successfully";
        }
    }
}

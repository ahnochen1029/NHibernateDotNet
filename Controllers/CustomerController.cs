using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NHibernateDotNet.Models;
using NHibernate.Linq;
using NHibernateDotNet.DataAccess;
using System;
using System.Collections.Generic;

namespace NHibernateDotNet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        NHibernateHelper helper = new NHibernateHelper();
        // private readonly NHibernateHelper helper;

        // public CustomerController(NHibernateHelper helper)
        // {
        //     this.helper = helper ?? throw new ArgumentNullException(nameof(helper));
        // }

        // create customer
        [HttpPost]
        public void Create(Customer customer)
        {
            if (customer == null)
            {
                throw new ArgumentException(nameof(customer));
            }

            using (var session = helper.GetSession())
            {
                daoCustomer daoCustomers = new daoCustomer(session);
                daoCustomers.CreateCustomer(customer);
            }
        }

        // update customer
        [HttpPut]
        public void Update(Customer customer)
        {
            if (customer == null)
            {
                throw new ArgumentException(nameof(customer));
            }

            using (var session = helper.GetSession())
            {
                daoCustomer daoCustomers = new daoCustomer(session);
                daoCustomers.UpdateCustomer(customer);
            }
        }

        // delete customer
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            using (var session = helper.GetSession())
            {
                daoCustomer daoCustomers = new daoCustomer(session);
                daoCustomers.DeleteCustomer(id);
            }
        }

        [HttpGet("{id}")]
        public Customer GetById(int id)
        {
            using (var session = helper.GetSession())
            {
                daoCustomer daoCustomers = new daoCustomer(session);
                Customer customer = daoCustomers.GetCustomerById(id);
                return customer;
            }
        }

        [HttpGet]
        public IEnumerable<Customer> GetAll()
        {
            using (var session = helper.GetSession())
            {
                daoCustomer daoCustomers = new daoCustomer(session);
                IEnumerable<Customer> customers = daoCustomers.GetCustomers();
                return customers;
            }
        }
    }
}

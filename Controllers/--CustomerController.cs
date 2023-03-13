// using Microsoft.AspNetCore.Mvc;
// using NHibernateDotNet.Models;
// using NHibernateDotNet.DataAccess;
// using NHibernate;
// using NHibernateDotNet.Infrastructure;


// namespace NHibernateDotNet.Controllers;

// [ApiController]
// [Route("[controller]")]

// public class CustomerController : ControllerBase
// {
//     NHibernateHelper helper = new NHibernateHelper();

//     // create customer
//     [HttpPost]
//     public void Create(Customer customer)
//     {

//         using (var session = helper.GetSession())
//         {
//             if (customer == null)
//             {
//                 throw new ArgumentNullException();
//             }
//             daoCustomer daoCustomers = new daoCustomer(session);
//             daoCustomers.CreateCustomer(customer);
//         }

//     }

//     // update customer
//     [HttpPut]
//     public void Update(Customer customer)
//     {
//         using (var session = helper.GetSession())
//         {
//             if (customer == null)
//             {
//                 throw new ArgumentNullException();
//             }
//             daoCustomer daoCustomers = new daoCustomer(session);
//             daoCustomers.UpdateCustomer(customer);
//         }

//     }

//     // delete customer
//     [HttpDelete("{id}")]
//     public void Delete(int id)
//     {
//         using (var session = helper.GetSession())
//         {
//             daoCustomer daoCustomers = new daoCustomer(session);
//             daoCustomers.DeleteCustomer(id);
//         }

//     }

//     [HttpGet("{id}")]
//     public Customer GetById(int id)
//     {
//         using (var session = helper.GetSession())
//         {
//             daoCustomer daoCustomers = new daoCustomer(session);
//             Customer customer = daoCustomers.GetCustomerById(id);
//             return customer;
//         }

//     }
// }




using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NHibernateDotNet.Models;
using NHibernate.Linq;
using NHibernateDotNet.DataAccess;

namespace NHibernateDotNet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {

        NHibernateHelper helper = new NHibernateHelper();

        // create customer
        [HttpPost]

        public ActionResult Create(Customer customer)
        {
            using (var session = helper.GetSession())
            {
                if (customer == null)
                {
                    throw new ArgumentNullException();
                }
                daoCustomer daoCustomers = new daoCustomer(session);
                daoCustomers.CreateCustomer(customer);
                return Ok();
            }
        }

    }
}

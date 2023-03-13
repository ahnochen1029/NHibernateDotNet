using NHibernateDotNet.Models;
using NHibernate;

namespace NHibernateDotNet.DataAccess
{
    public class daoCustomer
    {
        private NHibernate.ISession _session { get; set; }

        public daoCustomer(NHibernate.ISession session)
        {
            this._session = session;
        }

        public void CreateCustomer(Customer customer)
        {
            _session.Save(customer);
            _session.Flush();
        }
        public void UpdateCustomer(Customer customer)
        {
            _session.Update(customer);
            _session.Flush();
        }
        public void DeleteCustomer(Customer customer)
        {
            _session.Delete(customer);
            _session.Flush();
        }
        public Customer GetCustomerById(int id)
        {
            return _session.Get<Customer>(id);
        }

        public IList<Customer> GetCustomers()
        {
            return _session.Query<Customer>().ToList();
        }
    }

}

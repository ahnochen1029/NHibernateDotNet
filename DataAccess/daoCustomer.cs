﻿using NHibernateDotNet.Models;
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
            Console.WriteLine("AAAAAAAAAAAAAAAAAAAAA");
            Console.WriteLine(customer.FirstName);
            Console.WriteLine(customer.LastName);
            _session.Save(customer);
            _session.Flush();
        }
        public void UpdateCustomer(Customer customer)
        {
            _session.Update(customer);
            _session.Flush();
        }
        public void DeleteCustomer(int id)
        {
            _session.Delete(id);
            _session.Flush();
        }
        public Customer GetCustomerById(int id)
        {
            return _session.Get<Customer>(id);
        }

    }

}

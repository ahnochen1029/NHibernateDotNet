using NHibernate;
using NHibernate.Cfg;
using NHibernateDotNet.Models;


namespace NHibernateDotNet
{
    public class NHibernateHelper
    {
        private ISessionFactory _sessionFactory;
        public NHibernateHelper()
        {
            var configuration = new Configuration();
            configuration.Configure("hibernate.cfg.xml");
            configuration.AddAssembly(typeof(Customer).Assembly);
            _sessionFactory = configuration.BuildSessionFactory();
        }

        public NHibernate.ISession GetSession()
        {
            return _sessionFactory.OpenSession();
        }
    }
}

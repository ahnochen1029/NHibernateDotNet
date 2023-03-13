using NHibernate;
using NHibernate.Cfg;


namespace NHibernateDotNet
{
    public class NHibernateHelper
    {
        private ISessionFactory _sessionFactory;
        public NHibernateHelper()
        {
            var configuration = new Configuration();
            configuration.Configure("hibernate.cfg.xml");
            _sessionFactory = configuration.BuildSessionFactory();
        }

        public NHibernate.ISession GetSession()
        {
            return _sessionFactory.OpenSession();
        }
    }
}

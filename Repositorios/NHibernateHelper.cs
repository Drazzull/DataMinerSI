namespace DataMinerSI.Repositorios
{
    using DataMinerSI.Domain;
    using NHibernate;
    using NHibernate.Cfg;

    /// <summary>
    /// Classe de utilização do hibernate
    /// </summary>
    public class NHibernateHelper
    {
        #region Campos
        /// <summary>
        /// Campo contendo a sessão
        /// </summary>
        private static ISessionFactory sessionFactory;
        #endregion

        #region Propriedades
        /// <summary>
        /// Obtém a sessão de conexão com o hibernate
        /// </summary>
        private static ISessionFactory SessionFactory
        {
            get
            {
                if (sessionFactory == null)
                {
                    Configuration configuration = new Configuration();
                    configuration.Configure();
                    configuration.AddAssembly(typeof(Pessoa).Assembly);
                    sessionFactory = configuration.BuildSessionFactory();
                }

                return sessionFactory;
            }
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Abre a sessão do hibernate
        /// </summary>
        /// <returns></returns>
        public static ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }
        #endregion
    }
}

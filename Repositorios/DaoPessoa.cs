namespace DataMinerSI.Repositorios
{
    using DataMinerSI.Domain;
    using NHibernate;
    using System;

    /// <summary>
    /// Classe de conexão com o banco de dados
    /// </summary>
    public class DaoPessoa : IDaoPessoa
    {
        /// <summary>
        /// Adiciona ou atualiza os dados de uma pessoa
        /// </summary>
        /// <param name="pessoa">Pessoa que terá seus dados persistidos</param>
        public void InsertUpdate(Pessoa pessoa)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.SaveOrUpdate(pessoa);
                    transaction.Commit();
                }
            }
        }

        /// <summary>
        /// Excluir uma pessoa
        /// </summary>
        /// <param name="pessoa">Pessoa será excluída</param>
        public void Remove(Pessoa pessoa)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Procura uma pessoa através de seu código
        /// </summary>
        /// <param name="idPessoa">Código a ser pesquisado</param>
        /// <returns>Pessoa encontrada</returns>
        public Pessoa GetById(long idPessoa)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                // Seleciona a pessoa do id desejado
                return session.QueryOver<Pessoa>()
                    .Where(x => x.IdPessoa == idPessoa)
                    .Take(1)
                    .SingleOrDefault();
            }
        }
    }
}

namespace DataMinerSI.Domain
{
    /// <summary>
    /// Interface de conexão com o banco de dados
    /// </summary>
    public interface IDaoPessoa
    {
        /// <summary>
        /// Adiciona ou atualiza os dados de uma pessoa
        /// </summary>
        /// <param name="pessoa">Pessoa que terá seus dados persistidos</param>
        void InsertUpdate(Pessoa pessoa);

        /// <summary>
        /// Excluir uma pessoa
        /// </summary>
        /// <param name="pessoa">Pessoa será excluída</param>
        void Remove(Pessoa pessoa);

        /// <summary>
        /// Procura uma pessoa através de seu código
        /// </summary>
        /// <param name="idPessoa">Código a ser pesquisado</param>
        /// <returns>Pessoa encontrada</returns>
        Pessoa GetById(long idPessoa);
    }
}

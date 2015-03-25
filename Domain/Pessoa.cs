namespace DataMinerSI.Domain
{
    /// <summary>
    /// Cria uma instância da classe <see cref="Pessoa.cs"/>
    /// </summary>
    public class Pessoa
    {
        /// <summary>
        /// Obtém ou define o código da pessoa
        /// </summary>
        /// <returns></returns>
        public long IdPessoa { get; set; }

        /// <summary>
        /// Obtém ou define o estado civil da pessoa
        /// </summary>
        public string EstadoCivil { get; set; }

        /// <summary>
        /// Obtém ou define o grau de instrução da pessoa
        /// </summary>
        public string GrauInstrucao { get; set; }

        /// <summary>
        /// Obtém ou define o número de filhos da pessoa
        /// </summary>
        public int NumeroFilhos { get; set; }

        /// <summary>
        /// Obtém ou define o salário da pessoa
        /// </summary>
        public double Salario { get; set; }

        /// <summary>
        /// Obtém ou define o número de anos da idade da pessoa
        /// </summary>
        public int IdadeAnos { get; set; }

        /// <summary>
        /// Obtém ou define o número de meses da idade da pessoa
        /// </summary>
        public int IdadeMeses { get; set; }
    }
}
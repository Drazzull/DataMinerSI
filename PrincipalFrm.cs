namespace DataMinerSI
{
    using DataMinerSI.Domain;
    using DataMinerSI.Repositorios;
    using DataMinerSI.Util;
    using DevExpress.XtraEditors;
    using DevExpress.XtraLayout.Utils;
    using System;
    using System.IO;
    using System.Text.RegularExpressions;
    using System.Threading;
    using System.Windows.Forms;

    public partial class PrincipalFrm : XtraForm
    {
        /// <summary>
        /// Cria uma instância da classe <see cref="PrincipalFrm.cs"/>
        /// </summary>
        public PrincipalFrm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Abre a tela de dialogo para selecionar um arquivo de texto
        /// </summary>
        /// <param name="sender">Parâmetro sender</param>
        /// <param name="e">Parâmetro EventArgs</param>
        private void btnSelecionarArquivo_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofdSelecionar = new OpenFileDialog()
                {
                    Filter = "Arquivos de texto|*.txt",
                    Title = "Selecione um arquivo de texto a ser processado"
                };

                if (ofdSelecionar.ShowDialog() == DialogResult.OK)
                {
                    this.txtArquivoSelecionado.Text = ofdSelecionar.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    string.Format(
                    "Ocorreu o seguinte erro ao selecionar o arquivo:{0}[Erro]{1}",
                    Environment.NewLine,
                    ex.Message));
            }
        }

        /// <summary>
        /// Processa o arquivo de texto selecionado
        /// </summary>
        /// <param name="sender">Parâmetro sender</param>
        /// <param name="e">Parâmetro EventArgs</param>
        private void btnProcessar_Click(object sender, EventArgs e)
        {
            // Ativa a thread para ataulização da progressBar
            Thread thread = new Thread(this.AtualizarProgressBar);
            thread.Start();

            try
            {
                // Verifica se o arquivo foi selecionado
                if (string.IsNullOrEmpty(this.txtArquivoSelecionado.Text))
                {
                    throw new BasicException("Você deve selecionar o arquivo que será processado.");
                }

                // Mostra a barra de progresso
                this.pnliProcessamento.Visibility = LayoutVisibility.Always;

                using (StreamReader arquivo = new StreamReader(this.txtArquivoSelecionado.Text))
                {
                    // Obtém uma string com todos os dados do arquivo
                    string stringReader = arquivo.ReadToEnd();

                    // Atualiza a ProgressBar
                    this.pgrProcessamento.Properties.Maximum =
                        (new Regex(Environment.NewLine).Matches(stringReader).Count + 1);
                    this.pgrProcessamento.Properties.Minimum = 0;
                    this.pgrProcessamento.Properties.Step = 1;
                }

                // Faz a leitura do arquivo de texto
                using (StreamReader arquivo = new StreamReader(this.txtArquivoSelecionado.Text))
                {
                    // Faz a leitura de cada linha
                    string linha = string.Empty;
                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        this.pgrProcessamento.PerformStep();

                        // Separa a linha em um array contendo os dados
                        string[] dados = linha.Split('	');

                        // Verifica se é uma linha válida
                        long idPessoa = 0;
                        long.TryParse(dados[0], out idPessoa);
                        if (idPessoa == 0)
                        {
                            continue;
                        }

                        // Cria o objeto para utilização do banco
                        IDaoPessoa pessoaDao = new DaoPessoa();

                        // Tenta encontrar o id da pessoa no banco
                        Pessoa pessoa = pessoaDao.GetById(idPessoa);

                        // No caso de não ser encontrado o id correto, cria um novo objeto
                        if ((pessoa == null) || (pessoa.IdPessoa != idPessoa))
                        {
                            pessoa = new Pessoa() { IdPessoa = idPessoa };
                        }

                        // Faz a conversão dos valores numéricos
                        int numeroFilhos = 0;
                        double salario = 0;
                        int idadeAnos = 0;
                        int idadeMeses = 0;
                        int.TryParse(dados[3], out numeroFilhos);
                        double.TryParse(dados[4].Replace('.', ','), out salario);
                        int.TryParse(dados[5], out idadeAnos);
                        int.TryParse(dados[6], out idadeMeses);

                        // Atribui os valores de acordo com o arquivo de texto
                        pessoa.EstadoCivil = dados[1].Trim();
                        pessoa.GrauInstrucao = dados[2].Trim();
                        pessoa.NumeroFilhos = numeroFilhos;
                        pessoa.Salario = salario;
                        pessoa.IdadeAnos = idadeAnos;
                        pessoa.IdadeMeses = idadeMeses;

                        // Persiste os dados no banco
                        pessoaDao.InsertUpdate(pessoa);
                    }
                }
            }
            catch (BasicException bex)
            {
                // Mensagem personalizada de erro
                MessageBox.Show(bex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                // Mostra a mensagem com o erro que ocorreu
                MessageBox.Show(
                    string.Format(
                    "Ocorreu o seguinte erro ao processar o arquivo:{0}[Erro]{1}",
                    Environment.NewLine,
                    ex.Message),
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                // Apaga a visibilidade da ProgressBar
                this.pnliProcessamento.Visibility = LayoutVisibility.OnlyInCustomization;
                thread.Abort();
            }
        }

        /// <summary>
        /// Atualiza a posição da ProgressBar
        /// </summary>
        private void AtualizarProgressBar()
        {
            // Atualiza os dados da ProgressBar
            this.pgrProcessamento.Update();
        }
    }
}
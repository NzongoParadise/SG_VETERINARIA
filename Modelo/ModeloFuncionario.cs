using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloFuncionario
    {
        public int usuarioID{ get; set; }
        private int funcionarioID;
        private string nome;
        private string sobrenome;
        private string apelido;
        private string sexo;
        private string nomePai;
        private string nomeMae;
        private string cargo;
        private Decimal salario;
        private DateTime dataContratacao;
        private DateTime dataNascimento;
        private string tipoDocumento;
        private string numIdentificacao;
        private DateTime dataEmissaoBI;
        private DateTime dataExpiracaoBI;
        private string nacionalidade;
        private byte[] foto;
        private string grauAcademico;
        private string estadoCivil;
        private string observacao;
	    private int enderecoID;

        public ModeloFuncionario()
        {
            this.funcionarioID = funcionarioID;
            this.nome = nome;
            this.sobrenome = sobrenome;
            this.apelido = apelido;
            this.sexo = sexo;
            this.nomePai = nomePai;
            this.nomeMae = nomeMae;
            this.cargo = cargo;
            this.salario = salario;
            this.dataContratacao = dataContratacao;
            this.dataNascimento = dataNascimento;
            this.tipoDocumento = tipoDocumento;
            this.numIdentificacao = numIdentificacao;
            this.dataEmissaoBI = dataEmissaoBI;
            this.dataExpiracaoBI = dataExpiracaoBI;
            this.nacionalidade = nacionalidade;
            this.foto = foto;
            this.grauAcademico = grauAcademico;
            this.estadoCivil = estadoCivil;
            this.observacao = observacao;
            this.enderecoID = enderecoID;
        }
        public ModeloFuncionario(int funcionarioID, string nome, string sobrenome, string apelido,string sexo, string nomePai, string nomeMae, string cargo, decimal salario, DateTime dataContratacao, DateTime dataNascimento, string tipoDocumento, string numIdentificacao, DateTime dataEmissaoBI, DateTime dataExpiracaoBI, string nacionalidade, byte[] foto, string grauAcademico, string estadoCivil, string observacao, int enderecoID)
        {
            this.funcionarioID = funcionarioID;
            this.nome = nome;
            this.sobrenome = sobrenome;
            this.apelido = apelido;
            this.sexo = sexo;
            this.nomePai = nomePai;
            this.nomeMae = nomeMae;
            this.cargo = cargo;
            this.salario = salario;
            this.dataContratacao = dataContratacao;
            this.dataNascimento = dataNascimento;
            this.tipoDocumento = tipoDocumento;
            this.numIdentificacao = numIdentificacao;
            this.dataEmissaoBI = dataEmissaoBI;
            this.dataExpiracaoBI = dataExpiracaoBI;
            this.nacionalidade = nacionalidade;
            this.foto = foto;
            this.grauAcademico = grauAcademico;
            this.estadoCivil = estadoCivil;
            this.observacao = observacao;
            this.enderecoID = enderecoID;
        }
        public int FuncionarioID
        {
            get
            {
                return funcionarioID;
            }

            set
            {
                funcionarioID = value;
            }
        }
        public string Sexo
        {
            get
            {
                return sexo;
            }

            set
            {
                sexo = value;
            }
        }

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public string Sobrenome
        {
            get
            {
                return sobrenome;
            }

            set
            {
                sobrenome = value;
            }
        }

        public string Apelido
        {
            get
            {
                return apelido;
            }

            set
            {
                apelido = value;
            }
        }

        public string NomePai
        {
            get
            {
                return nomePai;
            }

            set
            {
                nomePai = value;
            }
        }

        public string NomeMae
        {
            get
            {
                return nomeMae;
            }

            set
            {
                nomeMae = value;
            }
        }

        public string Cargo
        {
            get
            {
                return cargo;
            }

            set
            {
                cargo = value;
            }
        }

        public decimal Salario
        {
            get
            {
                return salario;
            }

            set
            {
                salario = value;
            }
        }

        public DateTime DataContratacao
        {
            get
            {
                return dataContratacao;
            }

            set
            {
                dataContratacao = value;
            }
        }

        public DateTime DataNascimento
        {
            get
            {
                return dataNascimento;
            }

            set
            {
                dataNascimento = value;
            }
        }

        public string TipoDocumento1
        {
            get
            {
                return tipoDocumento;
            }

            set
            {
                tipoDocumento = value;
            }
        }

        public string NumIdentificacao
        {
            get
            {
                return numIdentificacao;
            }

            set
            {
                numIdentificacao = value;
            }
        }

        public DateTime DataEmissaoBI
        {
            get
            {
                return dataEmissaoBI;
            }

            set
            {
                dataEmissaoBI = value;
            }
        }

        public DateTime DataExpiracaoBI
        {
            get
            {
                return dataExpiracaoBI;
            }

            set
            {
                dataExpiracaoBI = value;
            }
        }

        public string Nacionalidade
        {
            get
            {
                return nacionalidade;
            }

            set
            {
                nacionalidade = value;
            }
        }

        public byte[] Foto
        {
            get
            {
                return foto;
            }

            set
            {
                foto = value;
            }
        }

        public string GrauAcademico
        {
            get
            {
                return grauAcademico;
            }

            set
            {
                grauAcademico = value;
            }
        }

        public string EstadoCivil
        {
            get
            {
                return estadoCivil;
            }

            set
            {
                estadoCivil = value;
            }
        }

        public string Observacao
        {
            get
            {
                return observacao;
            }

            set
            {
                observacao = value;
            }
        }

        public int EnderecoID
        {
            get
            {
                return enderecoID;
            }

            set
            {
                enderecoID = value;
            }
        }
        public void CarregaImage(String imgCaminho)
        {
            try
            {
                if (string.IsNullOrEmpty(imgCaminho))
                {
                    return;
                    /*
                     * fornecer priopriedade metodos de instancia para criar, copiar
                     * excluir, mover, abrir arquivos e  ajuda na criação de objectos FileStream
                    */

                    FileInfo arqImagem = new FileInfo(imgCaminho);
                    /*
                     * Expoe um Stream ao redor de um arquivo de suporte
                     * síncrono e assíncrono operações de leitura e gravar
                    */
                    FileStream fs = new FileStream(imgCaminho, FileMode.Open, FileAccess.Read, FileShare.Read);

                    // aloca memória para o vetor

                    this.Foto = new byte[Convert.ToInt32(arqImagem.Length)];

                    //Lê um bloco de bytes do fluxo e grava os dados em buffer fornecido.

                    int iBytesRead = fs.Read(this.Foto, 0, Convert.ToInt32(arqImagem.Length));
                    fs.Close();
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }
    }
}

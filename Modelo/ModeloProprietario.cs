using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;

namespace Modelo
{
    
    public class ModeloProprietario
    {
        //public int propietarioId { get; set; }
        //public string nome { get; set; }
        //public string sexo { get; set; }
        //public int enderecoID { get; set; }
        //public string sobrenome { get; set; }
        //public string apelido { get; set; }
        //public string tipodocumento { get; set; }
        //public string numIdnt { get; set; }
        //public DateTime dataEmissao { get; set; }
        //public DateTime dataValidade { get; set; }
        //public string nomePai { get; set; }
        //public string nomeMae { get; set; }
        //public string nacionalidade { get; set; }
        //public string descricao { get; set; }
        //public string genero { get; set; }
        //public DateTime datanascimento { get; set; }


        private int propietarioId;
        private String nome;
        private string sexo;
        private int enderecoID;
        private string sobrenome;
        private string apelido;
        private string tipodocumento;
        private string numIdnt;
        private DateTime dataEmissao;
        private DateTime dataValidade;
        //private string municipio;
        //private string comuna;
        private string nomePai;
        private string nomeMae;
        private string nacionalidade;
        private string descricao;
        private byte[] foto;
        private string genero;
        private DateTime datanascimento;
        public ModeloProprietario()
        {
            this.propietarioId = 0;
            this.nome = "";
            this.sexo = "";
            this.enderecoID = 0;
            this.sobrenome = "";
            this.apelido = "";
            this.tipodocumento = "";
            this.numIdnt = "";
            this.dataEmissao = DateTime.Now;
            this.dataValidade = DateTime.Now;
            //this.municipio = "";
            //this.comuna = "";
            this.nomePai = "";
            this.nomeMae = "";
            this.nacionalidade = "";
            this.descricao = "";
            //this.foto = "";
            this.genero = "";
            this.datanascimento = DateTime.Now;
        }
        public ModeloProprietario(int propietarioId, string nome, string sexo, int enderecoID, string sobrenome, string apelido, string tipodocumento, string numIdnt, DateTime dataEmissao, DateTime dataValidade, string municipio, string comuna, string nomePai, string nomeMae, string nacionalidade, string descricao, byte[] foto, string genero, DateTime datanascimento)
        {
            this.propietarioId = propietarioId;
            this.nome = nome;
            this.sexo = sexo;
            this.enderecoID = enderecoID;
            this.sobrenome = sobrenome;
            this.apelido = apelido;
            this.tipodocumento = tipodocumento;
            this.numIdnt = numIdnt;
            this.dataEmissao = dataEmissao;
            this.dataValidade = dataValidade;
            //this.municipio = municipio;
            //this.comuna = comuna;
            this.nomePai = nomePai;
            this.nomeMae = nomeMae;
            this.nacionalidade = nacionalidade;
            this.descricao = descricao;
            this.foto = foto;
            this.genero = genero;
            this.datanascimento = datanascimento;
        }

        public int PropietarioId
        {
            get
            {
                return propietarioId;
            }

            set
            {
                propietarioId = value;
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

        public string Tipodocumento
        {
            get
            {
                return tipodocumento;
            }

            set
            {
                tipodocumento = value;
            }
        }

        public string NumIdnt
        {
            get
            {
                return numIdnt;
            }

            set
            {
                numIdnt = value;
            }
        }

        public DateTime DataEmissao
        {
            get
            {
                return dataEmissao;
            }

            set
            {
                dataEmissao = value;
            }
        }

        public DateTime DataValidade
        {
            get
            {
                return dataValidade;
            }

            set
            {
                dataValidade = value;
            }
        }

        //public string Municipio
        //{
        //    get
        //    {
        //        return municipio;
        //    }

        //    set
        //    {
        //        municipio = value;
        //    }
        //}

        //public string Comuna
        //{
        //    get
        //    {
        //        return comuna;
        //    }

        //    set
        //    {
        //        comuna = value;
        //    }
        //}

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

        public string Descricao
        {
            get
            {
                return descricao;
            }

            set
            {
                descricao = value;
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

        public string Genero
        {
            get
            {
                return genero;
            }

            set
            {
                genero = value;
            }
        }

        public DateTime Datanascimento
        {
            get
            {
                return datanascimento;
            }

            set
            {
                datanascimento = value;
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

                    this.foto = new byte[Convert.ToInt32(arqImagem.Length)];

                    //Lê um bloco de bytes do fluxo e grava os dados em buffer fornecido.

                    int iBytesRead = fs.Read(this.foto, 0, Convert.ToInt32(arqImagem.Length));
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

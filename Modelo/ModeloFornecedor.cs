using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloFornecedor
    {
        private int fornecedorID;
        private string nomeFornecedor;
        private string tipoServico;
	    private int enderecoID;

        public ModeloFornecedor()
        {
            this.fornecedorID = 0;
            this.nomeFornecedor = "";
            this.tipoServico = "";
            this.enderecoID = 0;
        }
        public ModeloFornecedor(int fornecedorID, string nomeFornecedor, string tipoServico, int enderecoID)
        {
            this.fornecedorID = fornecedorID;
            this.nomeFornecedor = nomeFornecedor;
            this.tipoServico = tipoServico;
            this.enderecoID = enderecoID;
        }
        public int FornecedorID
        {
            get
            {
                return fornecedorID;
            }

            set
            {
                fornecedorID = value;
            }
        }

        public string NomeFornecedor
        {
            get
            {
                return nomeFornecedor;
            }

            set
            {
                nomeFornecedor = value;
            }
        }

        public string TipoServico
        {
            get
            {
                return tipoServico;
            }

            set
            {
                tipoServico = value;
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
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloEntradasEstoque
    {
        private int entradaID;
        private int codeMedicamento;
        private int fornecedorID;
        private DateTime dataEntrada;
        private int quantidade;
        private int quantidade_minima;
        private string lote;
	    private string tipoEstoque;
	    private int qtdTipoEstoque;
        private DateTime dataFabricado;
        private DateTime dataValidade;
        private Decimal PrecoCompra;

        public ModeloEntradasEstoque()
        {
            this.entradaID = 0;
            this.codeMedicamento = 0;
            this.fornecedorID = 0;
            this.dataEntrada = DateTime.Now;
            this.quantidade = 0;
            this.quantidade_minima = 0;
            this.lote = "";
            this.tipoEstoque = "";
            this.qtdTipoEstoque = 0;
            this.dataFabricado = DateTime.Now;
            this.dataValidade = DateTime.Now;
            PrecoCompra = 0;
        }
        public ModeloEntradasEstoque(int entradaID, int codeMedicamento, int fornecedorID, DateTime dataEntrada, int quantidade, int quantidade_minima, string lote, string tipoEstoque, int qtdTipoEstoque, DateTime dataFabricado, DateTime dataValidade, decimal precoCompra)
        {
            this.entradaID = entradaID;
            this.codeMedicamento = codeMedicamento;
            this.fornecedorID = fornecedorID;
            this.dataEntrada = dataEntrada;
            this.quantidade = quantidade;
            this.quantidade_minima = quantidade_minima;
            this.lote = lote;
            this.tipoEstoque = tipoEstoque;
            this.qtdTipoEstoque = qtdTipoEstoque;
            this.dataFabricado = dataFabricado;
            this.dataValidade = dataValidade;
            PrecoCompra = precoCompra;
        }
        public int EntradaID
        {
            get
            {
                return entradaID;
            }

            set
            {
                entradaID = value;
            }
        }

        public int CodeMedicamento
        {
            get
            {
                return codeMedicamento;
            }

            set
            {
                codeMedicamento = value;
            }
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

        public DateTime DataEntrada
        {
            get
            {
                return dataEntrada;
            }

            set
            {
                dataEntrada = value;
            }
        }

        public int Quantidade
        {
            get
            {
                return quantidade;
            }

            set
            {
                quantidade = value;
            }
        }

        public int Quantidade_minima
        {
            get
            {
                return quantidade_minima;
            }

            set
            {
                quantidade_minima = value;
            }
        }

        public string Lote
        {
            get
            {
                return lote;
            }

            set
            {
                lote = value;
            }
        }

        public string TipoEstoque
        {
            get
            {
                return tipoEstoque;
            }

            set
            {
                tipoEstoque = value;
            }
        }

        public int QtdTipoEstoque
        {
            get
            {
                return qtdTipoEstoque;
            }

            set
            {
                qtdTipoEstoque = value;
            }
        }

        public DateTime DataFabricado
        {
            get
            {
                return dataFabricado;
            }

            set
            {
                dataFabricado = value;
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

        public decimal PrecoCompra1
        {
            get
            {
                return PrecoCompra;
            }

            set
            {
                PrecoCompra = value;
            }
        }
    }
}

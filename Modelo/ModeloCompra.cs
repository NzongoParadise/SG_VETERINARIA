using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Modelo
{
    public class ModeloCompra
    {
        public int compraID { get; set; }
        public int produtoID { get; set; }
        public string formaPagamento { get; set; }
        public string NomeProduto { get; set; }
        public int CodFornecedor { get; set; }
        public int Qtd { get; set; }
        public decimal precoCompraUnitario { get; set; }
        public decimal precoUnitarioVenda { get; set; }
        public string Concentracao { get; set; }
        public string Dosagem { get; set; }
        public string TipoProduto { get; set; }
        public string CategoriaProduto { get; set; }
        public string FormaFarmaceutica { get; set; }
        public string CodigodeBara { get; set; }
        public string Obs { get; set; }
        public string NomeFornecedor { get; set; }
        public decimal Total { get; set; }
        public string Fabricante { get; set; }
        public DateTime dataProducao { get; set; }
        public DateTime dataExpiracao { get; set; }
        public string finalidadeProduto { get; set; }
        public DateTime DataCompra { get; set; }
        public string metedoPagamento { get; set; }
        public DateTime DataCadastro  { get; set; }
        public int UsuarioID { get; set; }
        public decimal totalGeral { get; set; }
        public bool eestadoProduto { get; set; }
        public string isentoCusto { get; set; }
        public decimal troco { get; set; }
        public decimal valorEntregue { get; set; }
        public decimal imposto { get; set; }
        public decimal desconto { get; set; }
    }

}

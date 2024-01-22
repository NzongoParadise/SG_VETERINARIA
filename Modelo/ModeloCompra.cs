using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Modelo
{
    public class ModeloCompra
    {
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
        public string Obs { get; set; }
        public string NomeFornecedor { get; set; }
        public decimal Total { get; set; }
        public string Fabricante { get; set; }
        public DateTime dataProducao { get; set; }
        public DateTime dataExpiracao { get; set; }
        public string finalidadeProduto { get; set; }
        public DateTime DataCompra { get; set; }
        public string metedoPagamento { get; set; }
    }

}

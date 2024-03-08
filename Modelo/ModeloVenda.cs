using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{

    public  class ModeloVenda
    {
        public  int vendaID { get; set; }
        public string nomeProduto { get; set; }
        public string nomeCliente{ get; set; }
        public  int produtoID { get; set; }
        public int Qtd { get; set; }
        public decimal precoUnitario { get; set; }
        public decimal Total{ get; set; }
        public DateTime dataVenda  { get; set; }
        public decimal totalGeral { get; set; }
        public  int UsuarioID { get; set; }
        public decimal valorentregue { get; set; }
        public decimal desconto{ get; set; }
        public decimal imposto { get; set; }
        public string formaPagamento { get; set; }
        public decimal troco { get; set; }


    }
}

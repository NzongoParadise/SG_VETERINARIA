using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public  class ModeloVenda
    {
        public string nomeProduto { get; set; }
        public  int produtoID { get; set; }
        public int Qtd { get; set; }
        public decimal precoUnitario { get; set; }
        public decimal Total{ get; set; }
        public DateTime dataVenda  { get; set; }
        public decimal totalGeral { get; set; }


    }
}

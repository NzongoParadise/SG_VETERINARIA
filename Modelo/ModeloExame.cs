using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloExame
    {
        public string ObsGeral { get; set; }
        public string tipoExame { get; set; }
        public string observacoesItemExame{ get; set; }
        public int funcionarioID{ get; set; }
        public string condicaoAtualAnimal { get; set; }
        public string diagnosticoPeliminar{ get; set; }
        public string  instrucoesProprietario { get; set; }
        public string acomanhamentoNecessario { get; set; }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloCadastrarAgendamento
    {
        public int UsuarioID { get; set; }
        public int ProprietarioID { get; set; }
        public int funcionarioID{ get; set; }
        public int animalID { get; set; }
        public string tipoAgendamento { get; set; }
        public string Obs{ get;set; }
        public string status { get; set; }
        public string gravidade { get; set; }
        public DateTime horaInicial { get; set; }
        public DateTime horaFinal { get; set; }


    }
}

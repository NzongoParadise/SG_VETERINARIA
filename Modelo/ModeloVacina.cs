using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloVacina
    {
        public int IDRegistroVacinacao { get; set; }
        public int AnimalID { get; set; }
        public string tipoVacina { get; set; }
        public int FuncionarioID { get; set; }
        public int IdVacina { get; set; }
        public int UsuarioID { get; set; }
        public int DoseVacina { get; set; }
        public decimal qtdAdministrada { get; set; }
        public string NomeVacina { get; set; }
        public string LoteVacina { get; set; }
        public string ViaAdministracao { get; set; }
        public string LocalAdministracao { get; set; }
        public DateTime dataValidadeVacina { get; set; }
        public string ReacoesAdversas { get; set; }
        public string VeterinarioResponsavel { get; set; }
        public DateTime dataVacinacao { get; set; }
        public DateTime dataProximaDataVacinacao { get; set; }
        public bool VacinacaoCompleta { get; set; }
        public string ResponsavelAdministracao { get; set; }
        //public DateTime DataRegistro { get; set; }
        public string NotasObservacoes { get; set; }
        public decimal custoTotalCompra { get; set; }
        public decimal custoUnitarioVacina { get; set; }
        public string finalidade { get; set; }
        public string IsentoCusto { get; set; }
        public decimal totalGeral { get; set; }
    }

}


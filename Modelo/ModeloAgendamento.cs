using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloAgendamento
    {
        private int agendamentoID;
        private DateTime dataAgendamento;
        private int consultaID;
        private string observacoes;

        public ModeloAgendamento()
        {
            this.agendamentoID = 0;
            this.dataAgendamento = DateTime.Now;
            this.consultaID = 0;
            this.observacoes = "";
        }
        public ModeloAgendamento(int agendamentoID, DateTime dataAgendamento, int consultaID, string observacoes)
        {
            this.agendamentoID = agendamentoID;
            this.dataAgendamento = dataAgendamento;
            this.consultaID = consultaID;
            this.observacoes = observacoes;
        }
        public int AgendamentoID
        {
            get
            {
                return agendamentoID;
            }

            set
            {
                agendamentoID = value;
            }
        }

        public DateTime DataAgendamento
        {
            get
            {
                return dataAgendamento;
            }

            set
            {
                dataAgendamento = value;
            }
        }

        public int ConsultaID
        {
            get
            {
                return consultaID;
            }

            set
            {
                consultaID = value;
            }
        }

        public string Observacoes
        {
            get
            {
                return observacoes;
            }

            set
            {
                observacoes = value;
            }
        }
    }
}

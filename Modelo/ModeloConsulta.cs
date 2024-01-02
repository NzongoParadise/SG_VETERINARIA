using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloConsulta
    {
        private int  consultaID;
        private DateTime dataConsulta;
        private int animalID;
        private string diagnostico;
        private string tratamento;
        private string observacao;

        public ModeloConsulta()
        {
            this.consultaID = 0;
            this.dataConsulta = DateTime.Now;
            this.animalID = 0;
            this.diagnostico = "";
            this.tratamento = "";
            this.observacao = "";
        }
        public ModeloConsulta(int consultaID, DateTime dataConsulta, int animalID, string diagnostico, string tratamento, string observacao)
        {
            this.consultaID = consultaID;
            this.dataConsulta = dataConsulta;
            this.animalID = animalID;
            this.diagnostico = diagnostico;
            this.tratamento = tratamento;
            this.observacao = observacao;
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

        public DateTime DataConsulta
        {
            get
            {
                return dataConsulta;
            }

            set
            {
                dataConsulta = value;
            }
        }

        public int AnimalID
        {
            get
            {
                return animalID;
            }

            set
            {
                animalID = value;
            }
        }

        public string Diagnostico
        {
            get
            {
                return diagnostico;
            }

            set
            {
                diagnostico = value;
            }
        }

        public string Tratamento
        {
            get
            {
                return tratamento;
            }

            set
            {
                tratamento = value;
            }
        }

        public string Observacao
        {
            get
            {
                return observacao;
            }

            set
            {
                observacao = value;
            }
        }
    }
}

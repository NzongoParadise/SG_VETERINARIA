using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    class ModeloSaidasEstoque
    {
        private int saidaID;
	    private int entradaID;
        private int animalID;
	    private DateTime dataSaida;
        private int quantidade;
	    private string destino;
	    private string prescritor;
	    private string motivo;

        public ModeloSaidasEstoque()
        {
            this.saidaID = 0;
            this.entradaID = 0;
            this.animalID = 0;
            this.dataSaida = DateTime.Now;
            this.quantidade = 0;
            this.destino = "";
            this.prescritor = "";
            this.motivo = "";
        }
        public ModeloSaidasEstoque(int saidaID, int entradaID, int animalID, DateTime dataSaida, int quantidade, string destino, string prescritor, string motivo)
        {
            this.saidaID = saidaID;
            this.entradaID = entradaID;
            this.animalID = animalID;
            this.dataSaida = dataSaida;
            this.quantidade = quantidade;
            this.destino = destino;
            this.prescritor = prescritor;
            this.motivo = motivo;
        }
        public int SaidaID
        {
            get
            {
                return saidaID;
            }

            set
            {
                saidaID = value;
            }
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

        public DateTime DataSaida
        {
            get
            {
                return dataSaida;
            }

            set
            {
                dataSaida = value;
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

        public string Destino
        {
            get
            {
                return destino;
            }

            set
            {
                destino = value;
            }
        }

        public string Prescritor
        {
            get
            {
                return prescritor;
            }

            set
            {
                prescritor = value;
            }
        }

        public string Motivo
        {
            get
            {
                return motivo;
            }

            set
            {
                motivo = value;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloTratamento
    {
        private int id_Tratamento;
        private int funcionarioID;
        private int animalID;
        private DateTime data_Inicio;
        private DateTime data_Fim;
        private string escricao;

        public ModeloTratamento()
        {
            this.id_Tratamento = 0;
            this.funcionarioID = 0;
            this.animalID = 0;
            this.data_Inicio = DateTime.Now;
            this.data_Fim = DateTime.Now;
            this.escricao = "";
        }
        public ModeloTratamento(int id_Tratamento, int funcionarioID, int animalID, DateTime data_Inicio, DateTime data_Fim, string escricao)
        {
            this.id_Tratamento = id_Tratamento;
            this.funcionarioID = funcionarioID;
            this.animalID = animalID;
            this.data_Inicio = data_Inicio;
            this.data_Fim = data_Fim;
            this.escricao = escricao;
        }
        public int Id_Tratamento
        {
            get
            {
                return id_Tratamento;
            }

            set
            {
                id_Tratamento = value;
            }
        }

        public int FuncionarioID
        {
            get
            {
                return funcionarioID;
            }

            set
            {
                funcionarioID = value;
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

        public DateTime Data_Inicio
        {
            get
            {
                return data_Inicio;
            }

            set
            {
                data_Inicio = value;
            }
        }

        public DateTime Data_Fim
        {
            get
            {
                return data_Fim;
            }

            set
            {
                data_Fim = value;
            }
        }

        public string Escricao
        {
            get
            {
                return escricao;
            }

            set
            {
                escricao = value;
            }
        }
    }
}

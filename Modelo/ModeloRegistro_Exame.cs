using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloRegistro_Exame
    {
        private int iD_Registro_Exame;
        private int funcionarioID;
	    private int iD_Exame;
        private int animalID;
        private DateTime data_Hora;
        private string observacoes;

        public ModeloRegistro_Exame()
        {
            this.iD_Registro_Exame = 0;
            this.funcionarioID = 0;
            this.iD_Exame = 0;
            this.animalID = 0;
            this.data_Hora = DateTime.Now;
            this.observacoes = "";
        }
        public ModeloRegistro_Exame(int iD_Registro_Exame, int funcionarioID, int iD_Exame, int animalID, DateTime data_Hora, string observacoes)
        {
            this.iD_Registro_Exame = iD_Registro_Exame;
            this.funcionarioID = funcionarioID;
            this.iD_Exame = iD_Exame;
            this.animalID = animalID;
            this.data_Hora = data_Hora;
            this.observacoes = observacoes;
        }
        public int ID_Registro_Exame
        {
            get
            {
                return iD_Registro_Exame;
            }

            set
            {
                iD_Registro_Exame = value;
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

        public int ID_Exame
        {
            get
            {
                return iD_Exame;
            }

            set
            {
                iD_Exame = value;
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

        public DateTime Data_Hora
        {
            get
            {
                return data_Hora;
            }

            set
            {
                data_Hora = value;
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

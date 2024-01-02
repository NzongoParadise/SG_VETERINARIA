using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloExame
    {
        private int iD_Exame;
        private int animalID;
        private int funcionarioID;
        private int iD_Tipo_Exame;
        private DateTime data_Hora;
        private string resultado;

        public ModeloExame()
        {
            this.iD_Exame = 0;
            this.animalID = 0;
            this.funcionarioID = 0;
            this.iD_Tipo_Exame = 0;
            this.data_Hora = DateTime.Now;
            this.resultado = "";
        }
        public ModeloExame(int iD_Exame, int animalID, int funcionarioID, int iD_Tipo_Exame, DateTime data_Hora, string resultado)
        {
            this.iD_Exame = iD_Exame;
            this.animalID = animalID;
            this.funcionarioID = funcionarioID;
            this.iD_Tipo_Exame = iD_Tipo_Exame;
            this.data_Hora = data_Hora;
            this.resultado = resultado;
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

        public int ID_Tipo_Exame
        {
            get
            {
                return iD_Tipo_Exame;
            }

            set
            {
                iD_Tipo_Exame = value;
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

        public string Resultado
        {
            get
            {
                return resultado;
            }

            set
            {
                resultado = value;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloTipo_Exame
    {
        private int iD_Tipo_Exame;
        private string descricao;

        public ModeloTipo_Exame()
        {
            this.iD_Tipo_Exame = 0;
            this.descricao = "";
        }
        public ModeloTipo_Exame(int iD_Tipo_Exame, string descricao)
        {
            this.iD_Tipo_Exame = iD_Tipo_Exame;
            this.descricao = descricao;
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

        public string Descricao
        {
            get
            {
                return descricao;
            }

            set
            {
                descricao = value;
            }
        }
    }
}

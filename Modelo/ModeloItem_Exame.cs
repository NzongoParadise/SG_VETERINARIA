using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloItem_Exame
    {
        private int iD_Item_Exame;
        private int iD_Exame;
        private string descricao_Exame;
        private string resultado_Exame;

        public ModeloItem_Exame()
        {
            this.iD_Item_Exame = 0;
            this.iD_Exame = 0;
            this.descricao_Exame = "";
            this.resultado_Exame = "";
        }
        public ModeloItem_Exame(int iD_Item_Exame, int iD_Exame, string descricao_Exame, string resultado_Exame)
        {
            this.iD_Item_Exame = iD_Item_Exame;
            this.iD_Exame = iD_Exame;
            this.descricao_Exame = descricao_Exame;
            this.resultado_Exame = resultado_Exame;
        }
        public int ID_Item_Exame
        {
            get
            {
                return iD_Item_Exame;
            }

            set
            {
                iD_Item_Exame = value;
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

        public string Descricao_Exame
        {
            get
            {
                return descricao_Exame;
            }

            set
            {
                descricao_Exame = value;
            }
        }

        public string Resultado_Exame
        {
            get
            {
                return resultado_Exame;
            }

            set
            {
                resultado_Exame = value;
            }
        }
    }
}

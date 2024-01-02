using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloReceita
    {
        private int num_receita;
	    private DateTime data_receita;
        private string desc_orientacoes_gerais;
	    private string codigo_de_barra;
	    private int consultaID;
        private int animalID;
	    private string descricao;

        public ModeloReceita()
        {
            this.num_receita = 0;
            this.data_receita =DateTime.Now;
            this.desc_orientacoes_gerais = "";
            this.codigo_de_barra = "";
            this.consultaID = 0;
            this.animalID = 0;
            this.descricao = "";
        }

        public ModeloReceita(int num_receita, DateTime data_receita, string desc_orientacoes_gerais, string codigo_de_barra, int consultaID, int animalID, string descricao)
        {
            this.num_receita = num_receita;
            this.data_receita = data_receita;
            this.desc_orientacoes_gerais = desc_orientacoes_gerais;
            this.codigo_de_barra = codigo_de_barra;
            this.consultaID = consultaID;
            this.animalID = animalID;
            this.descricao = descricao;
        }
        public int Num_receita
        {
            get
            {
                return num_receita;
            }

            set
            {
                num_receita = value;
            }
        }

        public DateTime Data_receita
        {
            get
            {
                return data_receita;
            }

            set
            {
                data_receita = value;
            }
        }

        public string Desc_orientacoes_gerais
        {
            get
            {
                return desc_orientacoes_gerais;
            }

            set
            {
                desc_orientacoes_gerais = value;
            }
        }

        public string Codigo_de_barra
        {
            get
            {
                return codigo_de_barra;
            }

            set
            {
                codigo_de_barra = value;
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

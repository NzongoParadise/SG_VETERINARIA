using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
   public class ModeloMedicamento
    {
        private int codeMedicamento;
        private string nomeMedicamento;
        private string tipoProduto;
        private string formaFarmaceutica;
        private string dosagemMedicamento;
        private string instrucoes;
        private string fabricante;
        private int codeUnidadeMedida;
        private string concentracao;
        private string descricao;

        public ModeloMedicamento()
        {
            this.codeMedicamento = 0;
            this.nomeMedicamento = "";
            this.tipoProduto = "";
            this.formaFarmaceutica = "";
            this.dosagemMedicamento = "";
            this.instrucoes = "";
            this.fabricante = "";
            this.codeUnidadeMedida = 0;
            this.concentracao = "";
            this.descricao = "";
        }
        public ModeloMedicamento(int codeMedicamento, string nomeMedicamento, string tipoProduto, string formaFarmaceutica, string dosagemMedicamento, string instrucoes, string fabricante, int codeUnidadeMedida, string concentracao, string descricao)
        {
            this.codeMedicamento = codeMedicamento;
            this.nomeMedicamento = nomeMedicamento;
            this.tipoProduto = tipoProduto;
            this.formaFarmaceutica = formaFarmaceutica;
            this.dosagemMedicamento = dosagemMedicamento;
            this.instrucoes = instrucoes;
            this.fabricante = fabricante;
            this.codeUnidadeMedida = codeUnidadeMedida;
            this.concentracao = concentracao;
            this.descricao = descricao;
        }
        public int CodeMedicamento
        {
            get
            {
                return codeMedicamento;
            }

            set
            {
                codeMedicamento = value;
            }
        }

        public string NomeMedicamento
        {
            get
            {
                return nomeMedicamento;
            }

            set
            {
                nomeMedicamento = value;
            }
        }

        public string TipoProduto
        {
            get
            {
                return tipoProduto;
            }

            set
            {
                tipoProduto = value;
            }
        }

        public string FormaFarmaceutica
        {
            get
            {
                return formaFarmaceutica;
            }

            set
            {
                formaFarmaceutica = value;
            }
        }

        public string DosagemMedicamento
        {
            get
            {
                return dosagemMedicamento;
            }

            set
            {
                dosagemMedicamento = value;
            }
        }

        public string Instrucoes
        {
            get
            {
                return instrucoes;
            }

            set
            {
                instrucoes = value;
            }
        }

        public string Fabricante
        {
            get
            {
                return fabricante;
            }

            set
            {
                fabricante = value;
            }
        }

        public int CodeUnidadeMedida
        {
            get
            {
                return codeUnidadeMedida;
            }

            set
            {
                codeUnidadeMedida = value;
            }
        }

        public string Concentracao
        {
            get
            {
                return concentracao;
            }

            set
            {
                concentracao = value;
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

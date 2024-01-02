using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloItemReceita
    {
        private int item_num_receita;
        private int num_receita ;
	    private int codeMedicamento;
        private int quantidade;
        private string observacao;

        public ModeloItemReceita()
        {
            this.item_num_receita = 0;
            this.num_receita = 0;
            this.codeMedicamento = 0;
            this.quantidade = 0;
            this.observacao = "";
        }
        public ModeloItemReceita(int item_num_receita, int num_receita, int codeMedicamento, int quantidade, string observacao)
        {
            this.item_num_receita = item_num_receita;
            this.num_receita = num_receita;
            this.codeMedicamento = codeMedicamento;
            this.quantidade = quantidade;
            this.observacao = observacao;
        }
        public int Item_num_receita
        {
            get
            {
                return item_num_receita;
            }

            set
            {
                item_num_receita = value;
            }
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

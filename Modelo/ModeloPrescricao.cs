using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloPrescricao
    {
        private int codePrescricao;
	    private string descr_orietancoes;
        private string descr_dosagem;
        private string descr_apresentacao;
        private int num_receita;
	    private DateTime dataPrescricao;
        private string duracao;
        private string frequencia;
	    private int codeMedicamento;

        public ModeloPrescricao()
        {
            this.codePrescricao = 0;
            this.descr_orietancoes = "";
            this.descr_dosagem = "";
            this.descr_apresentacao = "";
            this.num_receita = 0;
            this.dataPrescricao = DateTime.Now;
            this.duracao = "";
            this.frequencia = "";
            this.codeMedicamento = 0;
        }
        public ModeloPrescricao(int codePrescricao, string descr_orietancoes, string descr_dosagem, string descr_apresentacao, int num_receita, DateTime dataPrescricao, string duracao, string frequencia, int codeMedicamento)
        {
            this.codePrescricao = codePrescricao;
            this.descr_orietancoes = descr_orietancoes;
            this.descr_dosagem = descr_dosagem;
            this.descr_apresentacao = descr_apresentacao;
            this.num_receita = num_receita;
            this.dataPrescricao = dataPrescricao;
            this.duracao = duracao;
            this.frequencia = frequencia;
            this.codeMedicamento = codeMedicamento;
        }
        public int CodePrescricao
        {
            get
            {
                return codePrescricao;
            }

            set
            {
                codePrescricao = value;
            }
        }

        public string Descr_orietancoes
        {
            get
            {
                return descr_orietancoes;
            }

            set
            {
                descr_orietancoes = value;
            }
        }

        public string Descr_dosagem
        {
            get
            {
                return descr_dosagem;
            }

            set
            {
                descr_dosagem = value;
            }
        }

        public string Descr_apresentacao
        {
            get
            {
                return descr_apresentacao;
            }

            set
            {
                descr_apresentacao = value;
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

        public DateTime DataPrescricao
        {
            get
            {
                return dataPrescricao;
            }

            set
            {
                dataPrescricao = value;
            }
        }

        public string Duracao
        {
            get
            {
                return duracao;
            }

            set
            {
                duracao = value;
            }
        }

        public string Frequencia
        {
            get
            {
                return frequencia;
            }

            set
            {
                frequencia = value;
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
    }
}
